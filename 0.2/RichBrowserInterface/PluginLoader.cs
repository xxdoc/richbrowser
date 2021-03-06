using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI;
using System.IO;
using JinwooMin.Logging;
using System.Reflection;

namespace JinwooMin.RichBrowserInterface
{
    /// <summary>
    /// TODO
    /// </summary>
    public class PluginLoader
    {
        private List<IPlugin> m_plugins = new List<IPlugin>(); 
        private ILogger m_logger;
        private IPluginHost m_pluginHost;
        private string m_pluginPath;
        private string m_platformDataPath;
        private string m_searchOption;

        /// <summary>
        /// TODO
        /// </summary>
        public PluginLoader(ILogger logger, string platformDataPath, IPluginHost pluginHost, string pluginPath, string searchOption)
        {
            m_logger = logger;
            m_pluginHost = pluginHost;
            m_pluginPath = pluginPath;
            m_platformDataPath = platformDataPath;
            m_searchOption = searchOption;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public PluginResult Load()
        {
            m_logger.Debug("plugin path=" + m_pluginPath);

            try
            {
                string[] dirs = Directory.GetDirectories(m_pluginPath);
                //string binPaths = "";
                foreach (string dir in dirs)
                {
                    m_logger.Debug("dir=" + dir);

                    // Yes, I know it's DEPRECATED.
                    AppDomain.CurrentDomain.AppendPrivatePath(dir);

                    #region Test Code
                    
                    // 아래는 작동 안함.
                    // ref: http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=745624&SiteID=1
                    m_logger.Debug("privatebinpath=" + AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
                    //binPaths = dir + ";" + binPaths;
                    //AppDomain.CurrentDomain.SetupInformation.PrivateBinPath = binPaths;

                    #endregion

                    string[] plugins = Directory.GetFiles(dir, m_searchOption);
                    foreach (string plugin in plugins)
                    {
                        m_logger.Debug("plugin=" + plugin);
                        LoadPlugin(plugin);
                    }
                }
                return PluginResult.Success;
            }
            catch (DirectoryNotFoundException e)
            {
                m_logger.Warn("Can't found Plugins folder.");
                m_logger.Debug(e.StackTrace);
                return PluginResult.Fail;
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public PluginResult Unload()
        {
            foreach (IPlugin plugin in m_plugins)
            {
                plugin.DeinitResult = PluginResult.None;
                plugin.Deinit();
                if (plugin.DeinitResult == PluginResult.Cancel
                    || plugin.DeinitResult == PluginResult.Fail)
                {
                    return plugin.DeinitResult;
                }
            }

            return PluginResult.Success;
        }

        private void LoadPlugin(string filename)
        {
            Assembly asm;
            try
            {
                asm = Assembly.LoadFile(filename);
                if (asm != null)
                {
                    foreach (Type type in asm.GetTypes())
                    {
                        if (type.IsAbstract) continue;

                        m_logger.Debug(String.Format("type={0}, base={1}", type, type.BaseType));

                        bool isPlugin = false;
                        string asmTitle = "";
                        string pluginName = "";
                        foreach (Type ifoftype in type.GetInterfaces())
                        {
                            m_logger.Debug(String.Format("interface={0}", ifoftype.FullName));
                            if (ifoftype.FullName == typeof(IPlugin).FullName)
                            {
                                // ref: http://vbcity.com/forums/faq.asp?fid=30&cat=System
                                asmTitle = (asm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0] as AssemblyTitleAttribute).Title;
                                string asmVersion = (asm.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0] as AssemblyFileVersionAttribute).Version;
                                pluginName = asmTitle + " v" + asmVersion;
                                m_logger.Info(string.Format(Properties.Resources.MSG_FOUND_PLUGIN, pluginName));
                                isPlugin = true;
                                break;
                            }
                        }

                        if (isPlugin == true)
                        {
                            m_logger.Info(string.Format(Properties.Resources.MSG_INITING_PLUGIN, pluginName));
                            Object obj = Activator.CreateInstance(type);

                            IPlugin plugin = obj as IPlugin;
                            plugin.PluginHost = m_pluginHost;
                            plugin.PluginPath = Path.GetDirectoryName(filename);
                            plugin.PlatformDataPath = m_platformDataPath;
                            plugin.Logger = m_logger;
                            plugin.Init();

                            m_logger.Info(string.Format(Properties.Resources.MSG_INITED_PLUGIN, pluginName));

                            m_plugins.Add(plugin);
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                m_logger.Error("loadplugin: " + e.Message);
            }
        }
    }
}

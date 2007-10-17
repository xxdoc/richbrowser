﻿using System;
using System.Collections.Generic;
using System.Text;
using RichBrowserPlatform;

namespace RBPDefaultWebBrowser
{
    public class DefaultWebBrowserFactory : IWebBrowserFactory
    {
        #region IWebBrowserFactory 멤버

        IWebBrowser IWebBrowserFactory.Create()
        {
            return new RBPDefaultWebBrowser.WebBrowser();
        }

        #endregion
    }
}

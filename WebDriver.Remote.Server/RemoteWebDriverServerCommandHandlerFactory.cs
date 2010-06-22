﻿/* Copyright notice and license
Copyright 2007-2010 WebDriver committers
Copyright 2007-2010 Google Inc.
Portions copyright 2007 ThoughtWorks, Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using OpenQA.Selenium.Remote.Server.CommandHandlers;

namespace OpenQA.Selenium.Remote.Server
{
    /// <summary>
    /// Creates instances of <see cref="CommandHandler"/> objects for the desired <see cref="DriverCommand"/>.
    /// </summary>
    internal class RemoteWebDriverServerCommandHandlerFactory : CommandHandlerFactory
    {
        /// <summary>
        /// Adds handler constructors to the dictionary of handler creators.
        /// </summary>
        protected override void AddHandlers()
        {
            // We could reduce the coupling of classes by loading the types
            // dynamically using strings instead of the typeof operator; 
            // however, this is marginally faster.
            MapCommandHandler(DriverCommand.DefineDriverMapping, typeof(DefineDriverMappingHandler));
            MapCommandHandler(DriverCommand.NewSession, typeof(NewSessionHandler));
            MapCommandHandler(DriverCommand.GetSessionCapabilities, typeof(GetSessionCapabilitiesHandler));
            MapCommandHandler(DriverCommand.Close, typeof(CloseHandler));
            MapCommandHandler(DriverCommand.Quit, typeof(QuitHandler));
            MapCommandHandler(DriverCommand.Get, typeof(ChangeUrlHandler));
            MapCommandHandler(DriverCommand.GoBack, typeof(GoBackHandler));
            MapCommandHandler(DriverCommand.GoForward, typeof(GoForwardHandler));
            MapCommandHandler(DriverCommand.Refresh, typeof(RefreshHandler));
            MapCommandHandler(DriverCommand.AddCookie, typeof(AddCookieHandler));
            MapCommandHandler(DriverCommand.GetAllCookies, typeof(GetAllCookiesHandler));
            MapCommandHandler(DriverCommand.DeleteCookie, typeof(DeleteCookieNamedHandler));
            MapCommandHandler(DriverCommand.DeleteAllCookies, typeof(DeleteAllCookiesHandler));
            MapCommandHandler(DriverCommand.FindElement, typeof(FindElementHandler));
            MapCommandHandler(DriverCommand.FindElements, typeof(FindElementsHandler));
            MapCommandHandler(DriverCommand.FindChildElement, typeof(FindChildElementHandler));
            MapCommandHandler(DriverCommand.FindChildElements, typeof(FindChildElementsHandler));
            MapCommandHandler(DriverCommand.DescribeElement, typeof(DescribeElementHandler));
            MapCommandHandler(DriverCommand.ClearElement, typeof(ClearElementHandler));
            MapCommandHandler(DriverCommand.ClickElement, typeof(ClickElementHandler));
            MapCommandHandler(DriverCommand.HoverOverElement, typeof(HoverOverElementHandler));
            MapCommandHandler(DriverCommand.SendKeysToElement, typeof(SendKeysToElementHandler));
            MapCommandHandler(DriverCommand.SubmitElement, typeof(SubmitElementHandler));
            MapCommandHandler(DriverCommand.ToggleElement, typeof(ToggleElementHandler));
            MapCommandHandler(DriverCommand.GetCurrentWindowHandle, typeof(GetCurrentWindowHandler));
            MapCommandHandler(DriverCommand.GetWindowHandles, typeof(GetAllWindowsHandler));
            MapCommandHandler(DriverCommand.SwitchToWindow, typeof(SwitchToWindowHandler));
            MapCommandHandler(DriverCommand.SwitchToFrame, typeof(SwitchToFrameHandler));
            MapCommandHandler(DriverCommand.GetActiveElement, typeof(GetActiveElementHandler));
            MapCommandHandler(DriverCommand.GetCurrentUrl, typeof(GetCurrentUrlHandler));
            MapCommandHandler(DriverCommand.GetPageSource, typeof(GetPageSourceHandler));
            MapCommandHandler(DriverCommand.GetTitle, typeof(GetTitleHandler));
            MapCommandHandler(DriverCommand.ExecuteScript, typeof(ExecuteScriptHandler));
            MapCommandHandler(DriverCommand.GetSpeed, typeof(GetSpeedHandler));
            MapCommandHandler(DriverCommand.SetSpeed, typeof(SetSpeedHandler));
            MapCommandHandler(DriverCommand.GetElementText, typeof(GetElementTextHandler));
            MapCommandHandler(DriverCommand.GetElementValue, typeof(GetElementValueHandler));
            MapCommandHandler(DriverCommand.GetElementTagName, typeof(GetElementTagNameHandler));
            MapCommandHandler(DriverCommand.SetElementSelected, typeof(SetElementSelectedHandler));
            MapCommandHandler(DriverCommand.DragElement, typeof(DragElementHandler));
            MapCommandHandler(DriverCommand.IsElementSelected, typeof(GetElementSelectedHandler));
            MapCommandHandler(DriverCommand.IsElementEnabled, typeof(GetElementEnabledHandler));
            MapCommandHandler(DriverCommand.IsElementDisplayed, typeof(GetElementDisplayedHandler));
            MapCommandHandler(DriverCommand.GetElementLocation, typeof(GetElementLocationHandler));
            MapCommandHandler(DriverCommand.GetElementLocationOnceScrolledIntoView, typeof(GetElementScrolledIntoViewLocationHandler));
            MapCommandHandler(DriverCommand.GetElementSize, typeof(GetElementSizeHandler));
            MapCommandHandler(DriverCommand.GetElementAttribute, typeof(GetElementAttributeHandler));
            MapCommandHandler(DriverCommand.GetElementValueOfCssProperty, typeof(GetElementValueOfCssPropertyHandler));
            MapCommandHandler(DriverCommand.ElementEquals, typeof(ElementEqualsHandler));
            MapCommandHandler(DriverCommand.Screenshot, typeof(ScreenshotHandler));
            MapCommandHandler(DriverCommand.ImplicitlyWait, typeof(ImplicitlyWaitHandler));
        }
    }
}
﻿// <copyright file="NullLogger.cs" company="WebDriver Committers">
//
// Copyright 2010-2013 Jim Evans (james.h.evans.jr@gmail.com)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenQA.Selenium.Remote.Server.Loggers
{
    /// <summary>
    /// A logger object that ignores all messages. This should only be used for testing purposes.
    /// </summary>
    public class NullLogger : Logger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullLogger"/> class.
        /// </summary>
        /// <param name="level">A <see cref="LogLevel"/> value specifying the level of messages to log.</param>
        public NullLogger(LogLevel level)
            : base(level)
        {
        }

        /// <summary>
        /// Writes a message to the log.
        /// </summary>
        /// <param name="message">The message to write to the log.</param>
        protected override void WriteMessage(string message)
        {
        }
    }
}

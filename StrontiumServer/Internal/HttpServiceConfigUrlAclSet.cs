﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace StrontiumServer.Internal
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct HttpServiceConfigUrlAclSet
    {
        public HttpServiceConfigUrlAclKey KeyDesc;
        public HttpServiceConfigUrlAclParam ParamDesc;
    }
}

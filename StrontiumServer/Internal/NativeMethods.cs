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
using System.Runtime.InteropServices;
using System.Text;

namespace StrontiumServer.Internal
{
    internal static class NativeMethods
    {
        internal enum SystemMetrics
        {
            ServerR2 = 89,
            MediaCenter = 87,
            Starter = 88,
            TabletPC = 86
        }

        internal enum ProcessorArchitecture
        {
            AMD64 = 9, // x64 (AMD or Intel)
            IA64 = 6, // Intel Itanium Processor Family (IPF)
            X86 = 0, // x86
            Unknown = 0xffff // Unknown architecture.
        }

        internal enum VersionNT
        {
            DomainController = 0x0000002, // The system is a domain controller and the operating system is Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
            Server = 0x0000003, // The operating system is Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
            // Note that a server that is also a domain controller is reported as DomainController, not Server.
            Workstation = 0x0000001 // The operating system is Windows Vista, Windows XP Professional, Windows XP Home Edition, or Windows 2000 Professional.
        }

        [DllImport("httpapi.dll", SetLastError = true)]
        internal static extern ErrorCode HttpQueryServiceConfiguration(
             IntPtr ServiceIntPtr,
             HttpServiceConfigId ConfigId,
             IntPtr pInputConfigInfo,
             int InputConfigInfoLength,
             IntPtr pOutputConfigInfo,
             int OutputConfigInfoLength,
             [Optional()]
             out int pReturnLength,
             IntPtr pOverlapped);

        [DllImport("httpapi.dll", SetLastError = true)]
        internal static extern ErrorCode HttpSetServiceConfiguration(
             IntPtr ServiceIntPtr,
             HttpServiceConfigId ConfigId,
             IntPtr pConfigInformation,
             int ConfigInformationLength,
             IntPtr pOverlapped);

        [DllImport("httpapi.dll", SetLastError = true)]
        internal static extern ErrorCode HttpDeleteServiceConfiguration(
             IntPtr ServiceIntPtr,
             HttpServiceConfigId ConfigId,
             IntPtr pConfigInformation,
             int ConfigInformationLength,
             IntPtr pOverlapped);

        [DllImport("httpapi.dll", SetLastError = true)]
        internal static extern ErrorCode HttpInitialize(
             HttpApiVersion Version,
             uint Flags,
             IntPtr pReserved);

        [DllImport("httpapi.dll", SetLastError = true)]
        internal static extern ErrorCode HttpTerminate(
             uint Flags,
             IntPtr pReserved);

        [DllImport("kernel32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetVersionEx(ref OSVersionInfoEx lpVersionInfo);

        [DllImport("kernel32")]
        internal static extern void GetSystemInfo(out SystemInfo lpSystemInfo);

        [DllImport("user32")]
        internal static extern int GetSystemMetrics(int nIndex);

        [StructLayout(LayoutKind.Sequential)]
        internal struct OSVersionInfoEx
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public short wServicePackMajor;
            public short wServicePackMinor;
            public short wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SystemInfo
        {
            public ushort processorArchitecture;
            public ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }
    }
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct PackageId
{
    [NativeTypeName("UINT32")]
    public uint Reserved;

    [NativeTypeName("UINT32")]
    public uint ProcessorArchitecture;
    public PACKAGE_VERSION Version;

    [NativeTypeName("PWSTR")]
    public char* Name;

    [NativeTypeName("PWSTR")]
    public char* Publisher;

    [NativeTypeName("PWSTR")]
    public char* ResourceId;

    [NativeTypeName("PWSTR")]
    public char* PublisherId;
}

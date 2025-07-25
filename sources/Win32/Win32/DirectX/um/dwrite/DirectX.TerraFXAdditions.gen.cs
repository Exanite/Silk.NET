// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.DirectX.DWRITE;
using static Silk.NET.Win32.FACILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static uint DwriteMakeOpentypeTag(byte a, byte b, byte c, byte d) =>
        ((uint)d << 24) | ((uint)c << 16) | ((uint)b << 8) | a;

    public static HResult MakeDwriteHr(int severity, int code) =>
        MAKE_HRESULT(severity, FACILITY_DWRITE, DWRITE_ERR_BASE + code);

    public static HResult MakeDwriteHrErr(int code) => MakeDwriteHr(SEVERITY_ERROR, code);
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2derr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Win32.FACILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static HResult MakeD2Dhr(int sev, int code) => MAKE_HRESULT(sev, FACILITY_D2D, code);

    public static HResult MakeD2DhrErr(int code) => MakeD2Dhr(1, code);
}

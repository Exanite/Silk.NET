// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static HRESULT MakeDxgiHresult(int code) => Windows.MakeHresult(1, Facdxgi, code);

    public static HResult MakeDxgiStatus(int code) => Windows.MakeHresult(0, Facdxgi, code);
}

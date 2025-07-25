// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static nint IntPtrMin => nint.MinValue;
    public static nint LongPtrMin => nint.MinValue;
    public static nint PtrdiffTMin => nint.MinValue;
    public static nint SsizeTMin => nint.MinValue;
    public static nint IntPtrMax => nint.MaxValue;
    public static nuint UintPtrMax => nuint.MaxValue;
    public static nint LongPtrMax => nint.MaxValue;
    public static nuint UlongPtrMax => nuint.MaxValue;
    public static nuint DwordPtrMax => nuint.MaxValue;
    public static nint PtrdiffTMax => nint.MaxValue;
    public static nuint SizeTMax => nuint.MaxValue;
    public static nint SsizeTMax => nint.MaxValue;
    public static nuint SizeTMax => nuint.MaxValue;
    public static nint IntPtrError => (-1);
    public static nuint UintPtrError => nuint.MaxValue;
    public static nint LongPtrError => (-1);
    public static nuint UlongPtrError => nuint.MaxValue;
    public static nuint DwordPtrError => nuint.MaxValue;
    public static nint PtrdiffTError => (-1);
    public static nuint SizeTError => nuint.MaxValue;
    public static nint SsizeTError => (-1);
    public static nuint SizeTError => nuint.MaxValue;
}

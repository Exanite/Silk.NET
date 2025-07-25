// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public const int Null = 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Hibyte([NativeTypeName("DWORD_PTR")] nuint w) =>
        ((byte)((((nuint)(w)) >> 8) & 0xff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Hibyte(nint w) => unchecked(Hibyte((nuint)(w)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort Hiword([NativeTypeName("DWORD_PTR")] nuint l) =>
        ((ushort)((((nuint)(l)) >> 16) & 0xffff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort Hiword(nint l) => unchecked(Hiword((nuint)(l)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Lobyte([NativeTypeName("DWORD_PTR")] nuint w) =>
        ((byte)(((nuint)(w)) & 0xff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Lobyte(nint w) => unchecked(Lobyte((nuint)(w)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort Loword([NativeTypeName("DWORD_PTR")] nuint l) =>
        unchecked((ushort)(((nuint)(l)) & 0xffff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort Loword(nint l) => unchecked(Loword((nuint)(l)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("LONG")]
    public static int Makelong(
        [NativeTypeName("DWORD_PTR")] nuint a,
        [NativeTypeName("DWORD_PTR")] nuint b
    ) =>
        unchecked(
            (int)(
                ((ushort)(((nuint)(a)) & 0xffff)) | ((uint)((ushort)(((nuint)(b)) & 0xffff))) << 16
            )
        );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Makelong(nint a, nint b) => unchecked(Makeword((nuint)(a), (nuint)(b)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort Makeword(
        [NativeTypeName("DWORD_PTR")] nuint a,
        [NativeTypeName("DWORD_PTR")] nuint b
    ) =>
        unchecked(
            (ushort)(((byte)(((nuint)(a)) & 0xff)) | ((ushort)((byte)(((nuint)(b)) & 0xff))) << 8)
        );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort Makeword(nint a, nint b) => unchecked(Makeword((nuint)(a), (nuint)(b)));
}

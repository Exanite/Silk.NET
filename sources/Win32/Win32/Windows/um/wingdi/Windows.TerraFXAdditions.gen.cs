// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static Handle HgdiError => (HANDLE)(-1);
    public const int Gdiregisterddrawpacketversion = 0x1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF Cmyk(byte c, byte m, byte y, byte k) =>
        k | ((uint)y << 8) | (((uint)m) << 16) | (((uint)c) << 24);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GdiDibsize(BITMAPINFOHEADER bi) => GdiDibwidthbytes(bi) * (uint)bi.biHeight;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GdiDibsize(BITMAPINFOHEADER bi) =>
        bi.biHeight < 0 ? unchecked((uint)-1) * GdiDibsize(bi) : GdiDibsize(bi);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GdiDibwidthbytes(BITMAPINFOHEADER bi) =>
        GdiWidthbytes((uint)bi.biWidth * bi.biBitCount);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GdiWidthbytes(uint bits) => ((bits + 31) & ~31u) / 8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetBValue(COLORREF rgb) => Lobyte((ushort)(rgb >> 16));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetCValue(COLORREF cmyk) => (byte)(cmyk >> 24);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetGValue(COLORREF rgb) => Lobyte((ushort)(rgb >> 8));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetKValue(COLORREF cmyk) => (byte)cmyk;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetMValue(COLORREF cmyk) => (byte)(cmyk >> 16);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetRValue(COLORREF rgb) => Lobyte((ushort)rgb);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetYValue(COLORREF cmyk) => (byte)(cmyk >> 8);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static POINTS Makepoints(int l) => *(POINTS*)&l;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Makerop4(uint fore, uint back) => ((back << 8) & 0xFF000000) | fore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF Paletteindex(ushort i) => 0x01000000 | (uint)i;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF Palettergb(byte r, byte g, byte b) => 0x02000000 | Rgb(r, g, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF Rgb(byte r, byte g, byte b) => r | ((uint)g << 8) | (((uint)b) << 16);
}

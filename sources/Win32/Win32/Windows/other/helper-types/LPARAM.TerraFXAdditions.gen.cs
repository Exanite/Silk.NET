// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Lparam
{
    public static explicit operator Lparam(void* value) => new Lparam((nint)(value));

    public static implicit operator void*(Lparam value) => (void*)(value.Value);

    public static explicit operator Lparam(MaybeBool<int> value) => new Lparam(value.Value);

    public static explicit operator BOOL(Lparam value) => new MaybeBool<int>((int)(value.Value));

    public static explicit operator Lparam(Handle value) => new Lparam((nint)(value.Value));

    public static explicit operator Handle(Lparam value) => new Handle((void*)(value.Value));

    public static explicit operator Lparam(Hbrush value) => new Lparam((nint)(value.Value));

    public static explicit operator Hbrush(Lparam value) => new Hbrush((void*)(value.Value));

    public static explicit operator Lparam(Hcursor value) => new Lparam((nint)(value.Value));

    public static explicit operator Hcursor(Lparam value) => new Hcursor((void*)(value.Value));

    public static explicit operator Lparam(HDC value) => new Lparam((nint)(value.Value));

    public static explicit operator HDC(Lparam value) => new HDC((void*)(value.Value));

    public static explicit operator Lparam(HDROP value) => new Lparam((nint)(value.Value));

    public static explicit operator HDROP(Lparam value) => new HDROP((void*)(value.Value));

    public static explicit operator Lparam(Hfont value) => new Lparam((nint)(value.Value));

    public static explicit operator Hfont(Lparam value) => new Hfont((void*)(value.Value));

    public static explicit operator Lparam(HGDIOBJ value) => new Lparam((nint)(value.Value));

    public static explicit operator HGDIOBJ(Lparam value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator Lparam(HGLOBAL value) => new Lparam((nint)(value.Value));

    public static explicit operator HGLOBAL(Lparam value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator Lparam(HICON value) => new Lparam((nint)(value.Value));

    public static explicit operator HICON(Lparam value) => new HICON((void*)(value.Value));

    public static explicit operator Lparam(HINSTANCE value) => new Lparam((nint)(value.Value));

    public static explicit operator HINSTANCE(Lparam value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator Lparam(HLOCAL value) => new Lparam((nint)(value.Value));

    public static explicit operator HLOCAL(Lparam value) => new HLOCAL((void*)(value.Value));

    public static explicit operator Lparam(HMENU value) => new Lparam((nint)(value.Value));

    public static explicit operator HMENU(Lparam value) => new HMENU((void*)(value.Value));

    public static explicit operator Lparam(Hmodule value) => new Lparam((nint)(value.Value));

    public static explicit operator Hmodule(Lparam value) => new Hmodule((void*)(value.Value));

    public static explicit operator Lparam(Hpalette value) => new Lparam((nint)(value.Value));

    public static explicit operator Hpalette(Lparam value) => new Hpalette((void*)(value.Value));

    public static explicit operator Lparam(HPEN value) => new Lparam((nint)(value.Value));

    public static explicit operator HPEN(Lparam value) => new HPEN((void*)(value.Value));

    public static explicit operator Lparam(HRGN value) => new Lparam((nint)(value.Value));

    public static explicit operator HRGN(Lparam value) => new HRGN((void*)(value.Value));

    public static explicit operator Lparam(HWND value) => new Lparam((nint)(value.Value));

    public static explicit operator HWND(Lparam value) => new HWND((void*)(value.Value));

    public static explicit operator Lparam(Lresult value) => new Lparam(value.Value);

    public static explicit operator Lparam(Wparam value) => new Lparam((nint)(value.Value));
}

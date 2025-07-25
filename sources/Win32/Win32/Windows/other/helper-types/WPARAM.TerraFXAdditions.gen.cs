// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Wparam
{
    public static explicit operator Wparam(void* value) => new Wparam((nuint)(value));

    public static implicit operator void*(Wparam value) => (void*)(value.Value);

    public static explicit operator Wparam(MaybeBool<int> value) =>
        new Wparam((nuint)(value.Value));

    public static explicit operator MaybeBool<int>(Wparam value) =>
        new MaybeBool<int>((int)(value.Value));

    public static explicit operator Wparam(Handle value) => new Wparam((nuint)(value.Value));

    public static explicit operator Handle(Wparam value) => new Handle((void*)(value.Value));

    public static explicit operator Wparam(Hbrush value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hbrush(Wparam value) => new Hbrush((void*)(value.Value));

    public static explicit operator Wparam(Hcursor value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hcursor(Wparam value) => new Hcursor((void*)(value.Value));

    public static explicit operator Wparam(HDC value) => new Wparam((nuint)(value.Value));

    public static explicit operator HDC(Wparam value) => new HDC((void*)(value.Value));

    public static explicit operator Wparam(HDROP value) => new Wparam((nuint)(value.Value));

    public static explicit operator HDROP(Wparam value) => new HDROP((void*)(value.Value));

    public static explicit operator Wparam(Hfont value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hfont(Wparam value) => new Hfont((void*)(value.Value));

    public static explicit operator Wparam(HGDIOBJ value) => new Wparam((nuint)(value.Value));

    public static explicit operator HGDIOBJ(Wparam value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator Wparam(HGLOBAL value) => new Wparam((nuint)(value.Value));

    public static explicit operator HGLOBAL(Wparam value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator Wparam(HICON value) => new Wparam((nuint)(value.Value));

    public static explicit operator HICON(Wparam value) => new HICON((void*)(value.Value));

    public static explicit operator Wparam(HINSTANCE value) => new Wparam((nuint)(value.Value));

    public static explicit operator HINSTANCE(Wparam value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator Wparam(HLOCAL value) => new Wparam((nuint)(value.Value));

    public static explicit operator HLOCAL(Wparam value) => new HLOCAL((void*)(value.Value));

    public static explicit operator Wparam(HMENU value) => new Wparam((nuint)(value.Value));

    public static explicit operator HMENU(Wparam value) => new HMENU((void*)(value.Value));

    public static explicit operator Wparam(Hmodule value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hmodule(Wparam value) => new Hmodule((void*)(value.Value));

    public static explicit operator Wparam(Hpalette value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hpalette(Wparam value) => new Hpalette((void*)(value.Value));

    public static explicit operator Wparam(HPEN value) => new Wparam((nuint)(value.Value));

    public static explicit operator HPEN(Wparam value) => new HPEN((void*)(value.Value));

    public static explicit operator Wparam(HRGN value) => new Wparam((nuint)(value.Value));

    public static explicit operator HRGN(Wparam value) => new HRGN((void*)(value.Value));

    public static explicit operator Wparam(HWND value) => new Wparam((nuint)(value.Value));

    public static explicit operator HWND(Wparam value) => new HWND((void*)(value.Value));

    public static explicit operator Wparam(Lparam value) => new Wparam((nuint)(value.Value));

    public static explicit operator Wparam(Lresult value) => new Wparam((nuint)(value.Value));
}

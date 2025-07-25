// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Lresult
{
    public static explicit operator Lresult(void* value) => new Lresult((nint)(value));

    public static implicit operator void*(Lresult value) => (void*)(value.Value);

    public static explicit operator Lresult(MaybeBool<int> value) => new Lresult(value.Value);

    public static explicit operator MaybeBool<int>(Lresult value) =>
        new MaybeBool<int>((int)(value.Value));

    public static explicit operator Lresult(Handle value) => new Lresult((nint)(value.Value));

    public static explicit operator Handle(Lresult value) => new Handle((void*)(value.Value));

    public static explicit operator Lresult(Hbrush value) => new Lresult((nint)(value.Value));

    public static explicit operator Hbrush(Lresult value) => new Hbrush((void*)(value.Value));

    public static explicit operator Lresult(Hcursor value) => new Lresult((nint)(value.Value));

    public static explicit operator Hcursor(Lresult value) => new Hcursor((void*)(value.Value));

    public static explicit operator Lresult(HDC value) => new Lresult((nint)(value.Value));

    public static explicit operator HDC(Lresult value) => new HDC((void*)(value.Value));

    public static explicit operator Lresult(HDROP value) => new Lresult((nint)(value.Value));

    public static explicit operator HDROP(Lresult value) => new HDROP((void*)(value.Value));

    public static explicit operator Lresult(Hfont value) => new Lresult((nint)(value.Value));

    public static explicit operator Hfont(Lresult value) => new Hfont((void*)(value.Value));

    public static explicit operator Lresult(HGDIOBJ value) => new Lresult((nint)(value.Value));

    public static explicit operator HGDIOBJ(Lresult value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator Lresult(HGLOBAL value) => new Lresult((nint)(value.Value));

    public static explicit operator HGLOBAL(Lresult value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator Lresult(HICON value) => new Lresult((nint)(value.Value));

    public static explicit operator HICON(Lresult value) => new HICON((void*)(value.Value));

    public static explicit operator Lresult(HINSTANCE value) => new Lresult((nint)(value.Value));

    public static explicit operator HINSTANCE(Lresult value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator Lresult(HLOCAL value) => new Lresult((nint)(value.Value));

    public static explicit operator HLOCAL(Lresult value) => new HLOCAL((void*)(value.Value));

    public static explicit operator Lresult(HMENU value) => new Lresult((nint)(value.Value));

    public static explicit operator HMENU(Lresult value) => new HMENU((void*)(value.Value));

    public static explicit operator Lresult(Hmodule value) => new Lresult((nint)(value.Value));

    public static explicit operator Hmodule(Lresult value) => new Hmodule((void*)(value.Value));

    public static explicit operator Lresult(Hpalette value) => new Lresult((nint)(value.Value));

    public static explicit operator Hpalette(Lresult value) => new Hpalette((void*)(value.Value));

    public static explicit operator Lresult(HPEN value) => new Lresult((nint)(value.Value));

    public static explicit operator HPEN(Lresult value) => new HPEN((void*)(value.Value));

    public static explicit operator Lresult(HRGN value) => new Lresult((nint)(value.Value));

    public static explicit operator HRGN(Lresult value) => new HRGN((void*)(value.Value));

    public static explicit operator Lresult(HWND value) => new Lresult((nint)(value.Value));

    public static explicit operator HWND(Lresult value) => new HWND((void*)(value.Value));

    public static explicit operator Lresult(Lparam value) => new Lresult(value.Value);

    public static explicit operator Lresult(Wparam value) => new Lresult((nint)(value.Value));
}

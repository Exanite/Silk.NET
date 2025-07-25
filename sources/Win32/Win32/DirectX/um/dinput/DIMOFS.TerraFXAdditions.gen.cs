// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class Dimofs
{
    [NativeTypeName("#define DIMOFS_X FIELD_OFFSET(DIMOUSESTATE, lX)")]
    public static uint X
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIMOUSESTATE tmp);
            return (uint)(&tmp.lX) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIMOFS_Y FIELD_OFFSET(DIMOUSESTATE, lY)")]
    public static uint Y
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIMOUSESTATE tmp);
            return (uint)(&tmp.lY) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIMOFS_Z FIELD_OFFSET(DIMOUSESTATE, lZ)")]
    public static uint Z
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIMOUSESTATE tmp);
            return (uint)(&tmp.lZ) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIMOFS_BUTTON0 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 0)")]
    public static uint Button0 => Button(0);

    [NativeTypeName("#define DIMOFS_BUTTON1 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 1)")]
    public static uint Button1 => Button(1);

    [NativeTypeName("#define DIMOFS_BUTTON2 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 2)")]
    public static uint Button2 => Button(2);

    [NativeTypeName("#define DIMOFS_BUTTON3 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 3)")]
    public static uint Button3 => Button(3);

    [NativeTypeName("#define DIMOFS_BUTTON4 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 4)")]
    public static uint Button4 => Button(4);

    [NativeTypeName("#define DIMOFS_BUTTON5 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 5)")]
    public static uint Button5 => Button(5);

    [NativeTypeName("#define DIMOFS_BUTTON6 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 6)")]
    public static uint Button6 => Button(6);

    [NativeTypeName("#define DIMOFS_BUTTON7 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 7)")]
    public static uint Button7 => Button(7);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Button(uint n)
    {
        Unsafe.SkipInit(out DIMOUSESTATE tmp);
        return ((uint)(&tmp.rgbButtons) - (uint)(&tmp)) + n;
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("#define DIMOUSE_XAXISAB (0x82000200 |DIMOFS_X )")]
    public static uint DimouseXaxisab => 0x82000200u | Dimofs.X;

    [NativeTypeName("#define DIMOUSE_YAXISAB (0x82000200 |DIMOFS_Y )")]
    public static uint DimouseYaxisab => 0x82000200u | Dimofs.Y;

    [NativeTypeName("#define DIMOUSE_XAXIS (0x82000300 |DIMOFS_X )")]
    public static uint DimouseXaxis => 0x82000300u | Dimofs.X;

    [NativeTypeName("#define DIMOUSE_YAXIS (0x82000300 |DIMOFS_Y )")]
    public static uint DimouseYaxis => 0x82000300u | Dimofs.Y;

    [NativeTypeName("#define DIMOUSE_WHEEL (0x82000300 |DIMOFS_Z )")]
    public static uint DimouseWheel => 0x82000300u | Dimofs.Z;

    [NativeTypeName("#define DIMOUSE_BUTTON0 (0x82000400 |DIMOFS_BUTTON0)")]
    public static uint DimouseButton0 => 0x82000400u | Dimofs.Button0;

    [NativeTypeName("#define DIMOUSE_BUTTON1 (0x82000400 |DIMOFS_BUTTON1)")]
    public static uint DimouseButton1 => 0x82000400u | Dimofs.Button1;

    [NativeTypeName("#define DIMOUSE_BUTTON2 (0x82000400 |DIMOFS_BUTTON2)")]
    public static uint DimouseButton2 => 0x82000400u | Dimofs.Button2;

    [NativeTypeName("#define DIMOUSE_BUTTON3 (0x82000400 |DIMOFS_BUTTON3)")]
    public static uint DimouseButton3 => 0x82000400u | Dimofs.Button3;

    [NativeTypeName("#define DIMOUSE_BUTTON4 (0x82000400 |DIMOFS_BUTTON4)")]
    public static uint DimouseButton4 => 0x82000400u | Dimofs.Button4;

    [NativeTypeName("#define DIMOUSE_BUTTON5 (0x82000400 |DIMOFS_BUTTON5)")]
    public static uint DimouseButton5 => 0x82000400u | Dimofs.Button5;

    [NativeTypeName("#define DIMOUSE_BUTTON6 (0x82000400 |DIMOFS_BUTTON6)")]
    public static uint DimouseButton6 => 0x82000400u | Dimofs.Button6;

    [NativeTypeName("#define DIMOUSE_BUTTON7 (0x82000400 |DIMOFS_BUTTON7)")]
    public static uint DimouseButton7 => 0x82000400u | Dimofs.Button7;
}

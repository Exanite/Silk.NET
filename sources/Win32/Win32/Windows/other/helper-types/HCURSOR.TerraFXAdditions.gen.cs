// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Hcursor
{
    public static explicit operator Hcursor(HICON value) => new Hcursor(value.Value);

    public static implicit operator HICON(Hcursor value) => new HICON(value.Value);
}

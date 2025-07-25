// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Hmodule
{
    public static explicit operator Hmodule(HINSTANCE value) => new Hmodule(value.Value);

    public static implicit operator HINSTANCE(Hmodule value) => new HINSTANCE(value.Value);
}

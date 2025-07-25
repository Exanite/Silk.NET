// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.AF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6AddrEqual(
        [NativeTypeName("CONST IN6_ADDR *")] In6Addr* x,
        [NativeTypeName("CONST IN6_ADDR *")] In6Addr* y
    )
    {
        long* a;
        long* b;
        a = (long*)x;
        b = (long*)y;
        return (byte)(((a[1] == b[1]) && (a[0] == b[0])) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6AddrEqual(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> x,
        [NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> y
    )
    {
        fixed (In6Addr* __dsl_y = y)
        fixed (In6Addr* __dsl_x = x)
        {
            return (byte)In6AddrEqual(__dsl_x, __dsl_y);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrAnycast([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            ((In6IsAddrSubnetReservedAnycast(a) != 0) | (In6IsAddrSubnetRouterAnycast(a) != 0))
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrAnycast([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrAnycast(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrEui64([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)((((a->s6_bytes[0] & 0xE0) != 0) && !(In6IsAddrMulticast(a) != 0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrEui64([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrEui64(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrGlobal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        uint High = (a->s6_bytes[0] & 0xF0u);
        return (byte)(((High != 0) && (High != 0xF0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrGlobal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrGlobal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrLinklocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((a->s6_bytes[0] == 0xFE) && ((a->s6_bytes[1] & 0xC0) == 0x80)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrLinklocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrLinklocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrLoopback([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0x0100)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrLoopback([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrLoopback(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMcGlobal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((In6IsAddrMulticast(a) != 0) && ((a->s6_bytes[1] & 0xF) == 0xE)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMcGlobal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMcGlobal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMcLinklocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((In6IsAddrMulticast(a) != 0) && ((a->s6_bytes[1] & 0xF) == 2)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMcLinklocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMcLinklocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMcNodelocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((In6IsAddrMulticast(a) != 0) && ((a->s6_bytes[1] & 0xF) == 1)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMcNodelocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMcNodelocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMcOrglocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((In6IsAddrMulticast(a) != 0) && ((a->s6_bytes[1] & 0xF) == 8)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMcOrglocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMcOrglocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMcSitelocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((In6IsAddrMulticast(a) != 0) && ((a->s6_bytes[1] & 0xF) == 5)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMcSitelocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMcSitelocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrMulticast([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)((a->s6_bytes[0] == 0xFF) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrMulticast([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrMulticast(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrSitelocal([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(((a->s6_bytes[0] == 0xFE) && ((a->s6_bytes[1] & 0xC0) == 0xC0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrSitelocal([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrSitelocal(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrSubnetReservedAnycast(
        [NativeTypeName("CONST IN6_ADDR *")] In6Addr* a
    )
    {
        return (byte)(
            (
                (In6IsAddrEui64(a) != 0)
                && (a->s6_words[4] == 0xFFFD)
                && (a->s6_words[5] == 0xFFFF)
                && (a->s6_words[6] == 0xFFFF)
                && ((a->s6_words[7] & 0x80FF) == 0x80FF)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrSubnetReservedAnycast(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a
    )
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrSubnetReservedAnycast(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrSubnetRouterAnycast([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (In6IsAddrEui64(a) != 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrSubnetRouterAnycast(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a
    )
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrSubnetRouterAnycast(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrUnspecified([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrUnspecified([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrUnspecified(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrV4Compat([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && !(
                    (a->s6_words[6] == 0)
                    && (a->s6_addr[14] == 0)
                    && ((a->s6_addr[15] == 0) || (a->s6_addr[15] == 1))
                )
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrV4Compat([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrV4Compat(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrV4Mapped([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0xFFFF)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrV4Mapped([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrV4Mapped(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6IsAddrV4Translated([NativeTypeName("CONST IN6_ADDR *")] In6Addr* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0xFFFF)
                && (a->s6_words[5] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6IsAddrV4Translated([NativeTypeName("CONST IN6_ADDR *")] Ref<In6Addr> a)
    {
        fixed (In6Addr* __dsl_a = a)
        {
            return (byte)In6IsAddrV4Translated(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6AddrIsany([NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a)
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return In6IsAddrUnspecified(&a->sin6_addr);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6AddrIsany([NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a)
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)In6AddrIsany(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6AddrIsequal(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a,
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* b
    )
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return (byte)(
            (
                (a->sin6_scope_id == b->sin6_scope_id)
                && (In6AddrEqual(&a->sin6_addr, &b->sin6_addr) != 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6AddrIsequal(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a,
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> b
    )
    {
        fixed (SOCKADDR_IN6* __dsl_b = b)
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)In6AddrIsequal(__dsl_a, __dsl_b);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6AddrIsloopback([NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a)
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return In6IsAddrLoopback(&a->sin6_addr);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6AddrIsloopback(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a
    )
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)In6AddrIsloopback(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte In6AddrIsunspecified(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a
    )
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return (byte)(
            ((a->sin6_scope_id == 0) && (In6IsAddrUnspecified(&a->sin6_addr) != 0)) ? 1 : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte In6AddrIsunspecified(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a
    )
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)In6AddrIsunspecified(__dsl_a);
        }
    }
}

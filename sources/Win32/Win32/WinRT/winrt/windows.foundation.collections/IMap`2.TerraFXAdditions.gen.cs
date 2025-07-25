// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3C2925FE-8519-45C1-AA79-197B6718C1C1")]
public unsafe partial struct IMap<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint>)(LpVtbl[1]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Clear()
    {
        return ((delegate* unmanaged<IMap<K, V>*, int>)(LpVtbl[12]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, int>)(LpVtbl[7]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            size
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] Ref<uint> size)
    {
        fixed (uint* __dsl_size = size)
        {
            return (HRESULT)get_Size(__dsl_size);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            iidCount,
            iids
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] Ref<uint> iidCount,
        [NativeTypeName("IID **")] Ref2D<Guid> iids
    )
    {
        fixed (Guid** __dsl_iids = iids)
        fixed (uint* __dsl_iidCount = iidCount)
        {
            return (HResult)GetIids(__dsl_iidCount, __dsl_iids);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetRuntimeClassName(HString* className)
    {
        return ((delegate* unmanaged<IMap<K, V>*, HSTRING*, int>)(LpVtbl[4]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            className
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRuntimeClassName(Ref<HString> className)
    {
        fixed (HString* __dsl_className = className)
        {
            return (HResult)GetRuntimeClassName(__dsl_className);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMap<K, V>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            trustLevel
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTrustLevel([NativeTypeName("TrustLevel *")] Ref<TrustLevel> trustLevel)
    {
        fixed (TrustLevel* __dsl_trustLevel = trustLevel)
        {
            return (HResult)GetTrustLevel(__dsl_trustLevel);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetView(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** view
    )
    {
        return ((delegate* unmanaged<IMap<K, V>*, IMapView<K, V>**, int>)(LpVtbl[9]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            view
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetView(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] Ref2D<IMapView<K, V>> view
    )
    {
        fixed (IMapView<K, V>** __dsl_view = view)
        {
            return (HResult)GetView(__dsl_view);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult HasKey(
        [NativeTypeName("T_abi")] K key,
        [NativeTypeName("boolean *")] byte* found
    )
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, byte*, int>)(LpVtbl[8]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            key,
            found
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult HasKey(
        [NativeTypeName("T_abi")] K key,
        [NativeTypeName("boolean *")] Ref<byte> found
    )
    {
        fixed (byte* __dsl_found = found)
        {
            return (HResult)HasKey(key, __dsl_found);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Insert([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, int>)(LpVtbl[10]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            size
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT Insert([NativeTypeName("unsigned int *")] Ref<uint> size)
    {
        fixed (uint* __dsl_size = size)
        {
            return (HRESULT)Insert(__dsl_size);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, V*, int>)(LpVtbl[6]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            key,
            value
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] Ref<V> value)
    {
        fixed (V* __dsl_value = value)
        {
            return (HResult)Lookup(key, __dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IMap<K, V>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        [NativeTypeName("void **")] Ref2D ppvObject
    )
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [Transformed]
    public HRESULT QueryInterface<TCom>([NativeTypeName("void **")] out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint>)(LpVtbl[2]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Remove(
        [NativeTypeName("K_abi")] K key,
        [NativeTypeName("V_abi")] V value,
        [NativeTypeName("boolean *")] byte* replaced
    )
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, V, byte*, int>)(LpVtbl[11]))(
            (IMap<K, V>*)Unsafe.AsPointer(ref this),
            key,
            value,
            replaced
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Remove(
        [NativeTypeName("K_abi")] K key,
        [NativeTypeName("V_abi")] V value,
        [NativeTypeName("boolean *")] Ref<byte> replaced
    )
    {
        fixed (byte* __dsl_replaced = replaced)
        {
            return (HResult)Remove(key, value, __dsl_replaced);
        }
    }
}

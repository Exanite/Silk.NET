// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E480CE40-A338-4ADA-ADCF-272272E48CB9")]
public unsafe partial struct IMapView<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(LpVtbl[1]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Size([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, int>)(LpVtbl[7]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            size
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Size([NativeTypeName("unsigned int *")] Ref<uint> size)
    {
        fixed (uint* __dsl_size = size)
        {
            return (HResult)get_Size(__dsl_size);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IMapView<K, V>*, HString*, int>)(LpVtbl[4]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IMapView<K, V>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
    public HResult HasKey(
        [NativeTypeName("T_abi")] K key,
        [NativeTypeName("boolean *")] byte* found
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, byte*, int>)(LpVtbl[8]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
    public HResult Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, V*, int>)(LpVtbl[6]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        [NativeTypeName("void **")] Ref2D ppvObject
    )
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [Transformed]
    public HResult QueryInterface<TCom>([NativeTypeName("void **")] out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(LpVtbl[2]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Split(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** firstPartition,
        [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** secondPartition
    )
    {
        return (
            (delegate* unmanaged<IMapView<K, V>*, IMapView<K, V>**, IMapView<K, V>**, int>)(
                LpVtbl[9]
            )
        )((IMapView<K, V>*)Unsafe.AsPointer(ref this), firstPartition, secondPartition);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Split(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] Ref2D<IMapView<K, V>> firstPartition,
        [NativeTypeName("IMapView<K_logical, V_logical> **")] Ref2D<IMapView<K, V>> secondPartition
    )
    {
        fixed (IMapView<K, V>** __dsl_secondPartition = secondPartition)
        fixed (IMapView<K, V>** __dsl_firstPartition = firstPartition)
        {
            return (HResult)Split(__dsl_firstPartition, __dsl_secondPartition);
        }
    }
}

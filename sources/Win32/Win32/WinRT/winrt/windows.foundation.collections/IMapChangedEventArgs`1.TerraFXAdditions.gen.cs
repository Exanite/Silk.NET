// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9939F4DF-050A-4C0F-AA60-77075F9C4777")]
public unsafe partial struct IMapChangedEventArgs<K>
    where K : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint>)(LpVtbl[1]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_CollectionChange(
        [NativeTypeName("CollectionChange *")] CollectionChange* value
    )
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, CollectionChange*, int>)(LpVtbl[6]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
            value
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_CollectionChange(
        [NativeTypeName("CollectionChange *")] Ref<CollectionChange> value
    )
    {
        fixed (CollectionChange* __dsl_value = value)
        {
            return (HResult)get_CollectionChange(__dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Key([NativeTypeName("K_abi *")] K* value)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, K*, int>)(LpVtbl[7]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
            value
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Key([NativeTypeName("K_abi *")] Ref<K> value)
    {
        fixed (K* __dsl_value = value)
        {
            return (HResult)get_Key(__dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
            iidCount,
            iids
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] Ref<uint> iidCount,
        [NativeTypeName("IID **")] Ref2D<Guid> iids
    )
    {
        fixed (Guid** __dsl_iids = iids)
        fixed (uint* __dsl_iidCount = iidCount)
        {
            return (HRESULT)GetIids(__dsl_iidCount, __dsl_iids);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetRuntimeClassName(HString* className)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, HSTRING*, int>)(LpVtbl[4]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
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
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint>)(LpVtbl[2]))(
            (IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this)
        );
    }
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("65DF2BF5-BF39-41B5-AEBC-5A9D865E472B")]
public unsafe partial struct IObservableMap<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult add_MapChanged(
        [NativeTypeName("MapChangedEventHandler<K_logical, V_logical> *")]
            MapChangedEventHandler<K, V>* handler,
        [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IObservableMap<K, V>*,
                MapChangedEventHandler<K, V>*,
                EventRegistrationToken*,
                int>)(LpVtbl[6])
        )((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), handler, token);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult add_MapChanged(
        [NativeTypeName("MapChangedEventHandler<K_logical, V_logical> *")]
            Ref<MapChangedEventHandler<K, V>> handler,
        [NativeTypeName("EventRegistrationToken *")] Ref<EventRegistrationToken> token
    )
    {
        fixed (EventRegistrationToken* __dsl_token = token)
        fixed (MapChangedEventHandler<K, V>* __dsl_handler = handler)
        {
            return (HResult)add_MapChanged(__dsl_handler, __dsl_token);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(LpVtbl[1]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableMap<K, V>*, HString*, int>)(LpVtbl[4]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableMap<K, V>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableMap<K, V>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(LpVtbl[2]))(
            (IObservableMap<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult remove_MapChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IObservableMap<K, V>*, EventRegistrationToken, int>)(LpVtbl[7])
        )((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), token);
    }
}

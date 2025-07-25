// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5917EB53-50B4-4A0D-B309-65862B3F1DBC")]
public unsafe partial struct IObservableVector<T>
    where T : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult add_VectorChanged(
        [NativeTypeName("VectorChangedEventHandler<T_logical> *")]
            VectorChangedEventHandler<T>* handler,
        [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IObservableVector<T>*,
                VectorChangedEventHandler<T>*,
                EventRegistrationToken*,
                int>)(LpVtbl[6])
        )((IObservableVector<T>*)Unsafe.AsPointer(ref this), handler, token);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult add_VectorChanged(
        [NativeTypeName("VectorChangedEventHandler<T_logical> *")]
            Ref<VectorChangedEventHandler<T>> handler,
        [NativeTypeName("EventRegistrationToken *")] Ref<EventRegistrationToken> token
    )
    {
        fixed (EventRegistrationToken* __dsl_token = token)
        fixed (VectorChangedEventHandler<T>* __dsl_handler = handler)
        {
            return (HResult)add_VectorChanged(__dsl_handler, __dsl_token);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObservableVector<T>*, uint>)(LpVtbl[1]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IObservableVector<T>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this),
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
    public HRESULT GetRuntimeClassName(HString* className)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, HString*, int>)(LpVtbl[4]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this),
            className
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetRuntimeClassName(Ref<HString> className)
    {
        fixed (HString* __dsl_className = className)
        {
            return (HRESULT)GetRuntimeClassName(__dsl_className);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableVector<T>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IObservableVector<T>*, uint>)(LpVtbl[2]))(
            (IObservableVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult remove_VectorChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IObservableVector<T>*, EventRegistrationToken, int>)(LpVtbl[7])
        )((IObservableVector<T>*)Unsafe.AsPointer(ref this), token);
    }
}

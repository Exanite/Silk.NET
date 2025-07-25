// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0C051752-9FBF-4C70-AA0C-0E4C82D9A761")]
public unsafe partial struct VectorChangedEventHandler<T>
    where T : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, uint>)(LpVtbl[1]))(
            (VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Invoke(
        [NativeTypeName("IObservableVector<T_logical> *")] IObservableVector<T>* sender,
        IVectorChangedEventArgs* e
    )
    {
        return (
            (delegate* unmanaged<
                VectorChangedEventHandler<T>*,
                IObservableVector<T>*,
                IVectorChangedEventArgs*,
                int>)(LpVtbl[3])
        )((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this), sender, e);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Invoke(
        [NativeTypeName("IObservableVector<T_logical> *")] Ref<IObservableVector<T>> sender,
        Ref<IVectorChangedEventArgs> e
    )
    {
        fixed (IVectorChangedEventArgs* __dsl_e = e)
        fixed (IObservableVector<T>* __dsl_sender = sender)
        {
            return (HResult)Invoke(__dsl_sender, __dsl_e);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<VectorChangedEventHandler<T>*, Guid*, void**, int>)(LpVtbl[0])
        )((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, uint>)(LpVtbl[2]))(
            (VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this)
        );
    }
}

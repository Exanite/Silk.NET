// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FCDCF02C-E5D8-4478-915A-4D90B74B83A5")]
public unsafe partial struct IAsyncOperationCompletedHandler<TResult>
    where TResult : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, uint>)(LpVtbl[1]))(
            (IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Invoke(
        [NativeTypeName("IAsyncOperation<TResult_logical> *")] IAsyncOperation<TResult>* asyncInfo,
        [NativeTypeName("Windows::Foundation::AsyncStatus")] AsyncStatus status
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationCompletedHandler<TResult>*,
                IAsyncOperation<TResult>*,
                AsyncStatus,
                int>)(LpVtbl[3])
        )((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this), asyncInfo, status);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Invoke(
        [NativeTypeName("IAsyncOperation<TResult_logical> *")]
            Ref<IAsyncOperation<TResult>> asyncInfo,
        [NativeTypeName("Windows::Foundation::AsyncStatus")] AsyncStatus status
    )
    {
        fixed (IAsyncOperation<TResult>* __dsl_asyncInfo = asyncInfo)
        {
            return (HResult)Invoke(__dsl_asyncInfo, status);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, Guid*, void**, int>)(
                LpVtbl[0]
            )
        )((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, uint>)(LpVtbl[2]))(
            (IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this)
        );
    }
}

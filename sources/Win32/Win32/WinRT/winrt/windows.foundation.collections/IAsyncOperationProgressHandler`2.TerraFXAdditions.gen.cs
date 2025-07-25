// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("55690902-0AAB-421A-8778-F8CE5026D758")]
public unsafe partial struct IAsyncOperationProgressHandler<TResult, TProgress>
    where TResult : unmanaged
    where TProgress : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAsyncOperationProgressHandler<TResult, TProgress>*, uint>)(
                LpVtbl[1]
            )
        )((IAsyncOperationProgressHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult Invoke(
        [NativeTypeName("IAsyncOperationWithProgress<TResult_logical, TProgress_logical> *")]
            IAsyncOperationWithProgress<TResult, TProgress>* asyncInfo,
        [NativeTypeName("TProgress_abi")] TProgress progressInfo
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationProgressHandler<TResult, TProgress>*,
                IAsyncOperationWithProgress<TResult, TProgress>*,
                TProgress,
                int>)(LpVtbl[3])
        )(
            (IAsyncOperationProgressHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this),
            asyncInfo,
            progressInfo
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Invoke(
        [NativeTypeName("IAsyncOperationWithProgress<TResult_logical, TProgress_logical> *")]
            Ref<IAsyncOperationWithProgress<TResult, TProgress>> asyncInfo,
        [NativeTypeName("TProgress_abi")] TProgress progressInfo
    )
    {
        fixed (IAsyncOperationWithProgress<TResult, TProgress>* __dsl_asyncInfo = asyncInfo)
        {
            return (HResult)Invoke(__dsl_asyncInfo, progressInfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationProgressHandler<TResult, TProgress>*,
                Guid*,
                void**,
                int>)(LpVtbl[0])
        )(
            (IAsyncOperationProgressHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this),
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
        return (
            (delegate* unmanaged<IAsyncOperationProgressHandler<TResult, TProgress>*, uint>)(
                LpVtbl[2]
            )
        )((IAsyncOperationProgressHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9FC2B0BB-E446-44E2-AA61-9CAB8F636AF2")]
public unsafe partial struct IAsyncOperation<TResult>
    where TResult : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, uint>)(LpVtbl[1]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Completed(
        [NativeTypeName("IAsyncOperationCompletedHandler<TResult_logical> **")]
            IAsyncOperationCompletedHandler<TResult>** handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperation<TResult>*,
                IAsyncOperationCompletedHandler<TResult>**,
                int>)(LpVtbl[7])
        )((IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Completed(
        [NativeTypeName("IAsyncOperationCompletedHandler<TResult_logical> **")]
            Ref2D<IAsyncOperationCompletedHandler<TResult>> handler
    )
    {
        fixed (IAsyncOperationCompletedHandler<TResult>** __dsl_handler = handler)
        {
            return (HResult)get_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this),
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
    public HResult GetResults([NativeTypeName("TResult_abi *")] TResult* results)
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, TResult*, int>)(LpVtbl[8]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this),
            results
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetResults([NativeTypeName("TResult_abi *")] Ref<TResult> results)
    {
        fixed (TResult* __dsl_results = results)
        {
            return (HResult)GetResults(__dsl_results);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, HString*, int>)(LpVtbl[4]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this),
            className
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRuntimeClassName(Ref<HSTRING> className)
    {
        fixed (HSTRING* __dsl_className = className)
        {
            return (HResult)GetRuntimeClassName(__dsl_className);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this),
            trustLevel
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] Ref<TrustLevel> trustLevel)
    {
        fixed (TrustLevel* __dsl_trustLevel = trustLevel)
        {
            return (HRESULT)GetTrustLevel(__dsl_trustLevel);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult put_Completed(
        [NativeTypeName("IAsyncOperationCompletedHandler<TResult_logical> *")]
            IAsyncOperationCompletedHandler<TResult>* handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperation<TResult>*,
                IAsyncOperationCompletedHandler<TResult>*,
                int>)(LpVtbl[6])
        )((IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult put_Completed(
        [NativeTypeName("IAsyncOperationCompletedHandler<TResult_logical> *")]
            Ref<IAsyncOperationCompletedHandler<TResult>> handler
    )
    {
        fixed (IAsyncOperationCompletedHandler<TResult>* __dsl_handler = handler)
        {
            return (HResult)put_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IAsyncOperation<TResult>*, uint>)(LpVtbl[2]))(
            (IAsyncOperation<TResult>*)Unsafe.AsPointer(ref this)
        );
    }
}

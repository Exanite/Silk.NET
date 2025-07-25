// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1F6DB258-E803-48A1-9546-EB7353398884")]
public unsafe partial struct IAsyncActionWithProgress<TProgress>
    where TProgress : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint>)(LpVtbl[1]))(
            (IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Completed(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")]
            IAsyncActionWithProgressCompletedHandler<TProgress>** handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncActionWithProgress<TProgress>*,
                IAsyncActionWithProgressCompletedHandler<TProgress>**,
                int>)(LpVtbl[9])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Completed(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")]
            Ref2D<IAsyncActionWithProgressCompletedHandler<TProgress>> handler
    )
    {
        fixed (IAsyncActionWithProgressCompletedHandler<TProgress>** __dsl_handler = handler)
        {
            return (HResult)get_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Progress(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")]
            IAsyncActionWithProgressCompletedHandler<TProgress>** handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncActionWithProgress<TProgress>*,
                IAsyncActionWithProgressCompletedHandler<TProgress>**,
                int>)(LpVtbl[7])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Progress(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")]
            Ref2D<IAsyncActionWithProgressCompletedHandler<TProgress>> handler
    )
    {
        fixed (IAsyncActionWithProgressCompletedHandler<TProgress>** __dsl_handler = handler)
        {
            return (HResult)get_Progress(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint*, Guid**, int>)(
                LpVtbl[3]
            )
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), iidCount, iids);
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
    public HResult GetResults()
    {
        return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, int>)(LpVtbl[10]))(
            (IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HString* className)
    {
        return (
            (delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, HString*, int>)(LpVtbl[4])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), className);
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
        return (
            (delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, TrustLevel*, int>)(LpVtbl[5])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), trustLevel);
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
    public HResult put_Completed(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")]
            IAsyncActionWithProgressCompletedHandler<TProgress>* handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncActionWithProgress<TProgress>*,
                IAsyncActionWithProgressCompletedHandler<TProgress>*,
                int>)(LpVtbl[8])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult put_Completed(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")]
            Ref<IAsyncActionWithProgressCompletedHandler<TProgress>> handler
    )
    {
        fixed (IAsyncActionWithProgressCompletedHandler<TProgress>* __dsl_handler = handler)
        {
            return (HResult)put_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult put_Progress(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")]
            IAsyncActionWithProgressCompletedHandler<TProgress>* handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncActionWithProgress<TProgress>*,
                IAsyncActionWithProgressCompletedHandler<TProgress>*,
                int>)(LpVtbl[6])
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult put_Progress(
        [NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")]
            Ref<IAsyncActionWithProgressCompletedHandler<TProgress>> handler
    )
    {
        fixed (IAsyncActionWithProgressCompletedHandler<TProgress>* __dsl_handler = handler)
        {
            return (HResult)put_Progress(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, Guid*, void**, int>)(
                LpVtbl[0]
            )
        )((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
        return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint>)(LpVtbl[2]))(
            (IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this)
        );
    }
}

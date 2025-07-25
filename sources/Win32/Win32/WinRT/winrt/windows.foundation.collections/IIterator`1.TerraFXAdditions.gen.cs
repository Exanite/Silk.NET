// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6A79E863-4300-459A-9966-CBB660963EE1")]
public unsafe partial struct IIterator<T>
    where T : unmanaged
{
    public void** LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIterator<T>*, uint>)(LpVtbl[1]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_Current([NativeTypeName("T_abi *")] T* current)
    {
        return ((delegate* unmanaged<IIterator<T>*, T*, int>)(LpVtbl[6]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
            current
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_Current([NativeTypeName("T_abi *")] Ref<T> current)
    {
        fixed (T* __dsl_current = current)
        {
            return (HResult)get_Current(__dsl_current);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult get_HasCurrent([NativeTypeName("boolean *")] byte* hasCurrent)
    {
        return ((delegate* unmanaged<IIterator<T>*, byte*, int>)(LpVtbl[7]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
            hasCurrent
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult get_HasCurrent([NativeTypeName("boolean *")] Ref<byte> hasCurrent)
    {
        fixed (byte* __dsl_hasCurrent = hasCurrent)
        {
            return (HResult)get_HasCurrent(__dsl_hasCurrent);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIterator<T>*, uint*, Guid**, int>)(LpVtbl[3]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
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
    public HResult GetMany(
        [NativeTypeName("unsigned")] uint capacity,
        [NativeTypeName("T_abi *")] T* value,
        [NativeTypeName("unsigned *")] uint* actual
    )
    {
        return ((delegate* unmanaged<IIterator<T>*, uint, T*, uint*, int>)(LpVtbl[9]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
            capacity,
            value,
            actual
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMany(
        [NativeTypeName("unsigned")] uint capacity,
        [NativeTypeName("T_abi *")] Ref<T> value,
        [NativeTypeName("unsigned *")] Ref<uint> actual
    )
    {
        fixed (uint* __dsl_actual = actual)
        fixed (T* __dsl_value = value)
        {
            return (HResult)GetMany(capacity, __dsl_value, __dsl_actual);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult GetRuntimeClassName(HString* className)
    {
        return ((delegate* unmanaged<IIterator<T>*, HString*, int>)(LpVtbl[4]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IIterator<T>*, TrustLevel*, int>)(LpVtbl[5]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
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
    public HRESULT MoveNext([NativeTypeName("boolean *")] byte* hasCurrent)
    {
        return ((delegate* unmanaged<IIterator<T>*, byte*, int>)(LpVtbl[8]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
            hasCurrent
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT MoveNext([NativeTypeName("boolean *")] Ref<byte> hasCurrent)
    {
        fixed (byte* __dsl_hasCurrent = hasCurrent)
        {
            return (HRESULT)MoveNext(__dsl_hasCurrent);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HResult QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IIterator<T>*, Guid*, void**, int>)(LpVtbl[0]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IIterator<T>*, uint>)(LpVtbl[2]))(
            (IIterator<T>*)Unsafe.AsPointer(ref this)
        );
    }
}

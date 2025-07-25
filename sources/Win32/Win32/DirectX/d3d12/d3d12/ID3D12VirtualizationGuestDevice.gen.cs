// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice"]/*'/>
[Guid("BC66D368-7373-4943-8757-FC87DC79E476")]
[NativeTypeName("struct ID3D12VirtualizationGuestDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct ID3D12VirtualizationGuestDevice : ID3D12VirtualizationGuestDevice.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VirtualizationGuestDevice));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, int* pFenceFd);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, Ref<int> pFenceFd);
        [VtblIndex(3)]
        HResult ShareWithHost(ID3D12DeviceChild pObject, Handle* pHandle);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult ShareWithHost(ID3D12DeviceChild pObject, Ref<Handle> pHandle);
    }

    /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice"]/*'/>
    [Guid("BC66D368-7373-4943-8757-FC87DC79E476")]
    [NativeTypeName("struct ID3D12VirtualizationGuestDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VirtualizationGuestDevice));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;
            [NativeTypeName("HRESULT (ID3D12DeviceChild *, HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12DeviceChild.Native*, Handle*, HResult> ShareWithHost;
            [NativeTypeName("HRESULT (ID3D12Fence *, UINT64, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Fence.Native*, ulong, int*, HResult> CreateFenceFd;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice.Native*, uint> )(lpVtbl[1]))((ID3D12VirtualizationGuestDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.CreateFenceFd"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, int* pFenceFd)
        {
            return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice.Native*, ID3D12Fence.Native*, ulong, int*, HResult> )(lpVtbl[4]))((ID3D12VirtualizationGuestDevice.Native*)Unsafe.AsPointer(ref this), pFence.LpVtbl, FenceValue, pFenceFd);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, Ref<int> pFenceFd)
        {
            fixed (int* __dsl_pFenceFd = pFenceFd)
            {
                return (HResult)CreateFenceFd(pFence, FenceValue, __dsl_pFenceFd);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VirtualizationGuestDevice.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice.Native*, uint> )(lpVtbl[2]))((ID3D12VirtualizationGuestDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.ShareWithHost"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult ShareWithHost(ID3D12DeviceChild pObject, Handle* pHandle)
        {
            return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice.Native*, ID3D12DeviceChild.Native*, Handle*, HResult> )(lpVtbl[3]))((ID3D12VirtualizationGuestDevice.Native*)Unsafe.AsPointer(ref this), pObject.LpVtbl, pHandle);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ShareWithHost(ID3D12DeviceChild pObject, Ref<Handle> pHandle)
        {
            fixed (Handle* __dsl_pHandle = pHandle)
            {
                return (HResult)ShareWithHost(pObject, __dsl_pHandle);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VirtualizationGuestDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VirtualizationGuestDevice(Ptr3D vtbl) => LpVtbl = (ID3D12VirtualizationGuestDevice.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VirtualizationGuestDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VirtualizationGuestDevice(Ptr<ID3D12VirtualizationGuestDevice.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice.Native"/> to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VirtualizationGuestDevice(ID3D12VirtualizationGuestDevice.Native* value) => new ID3D12VirtualizationGuestDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice"/> to <see cref = "ID3D12VirtualizationGuestDevice.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator ID3D12VirtualizationGuestDevice.Native*(ID3D12VirtualizationGuestDevice value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VirtualizationGuestDevice(Ptr3D value) => new ID3D12VirtualizationGuestDevice(value);
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VirtualizationGuestDevice value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VirtualizationGuestDevice(Ptr<ID3D12VirtualizationGuestDevice.Native> value) => new ID3D12VirtualizationGuestDevice(value);
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VirtualizationGuestDevice.Native>(ID3D12VirtualizationGuestDevice value) => (Ptr<ID3D12VirtualizationGuestDevice.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VirtualizationGuestDevice(void*** value) => new ID3D12VirtualizationGuestDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VirtualizationGuestDevice value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VirtualizationGuestDevice(nuint value) => new ID3D12VirtualizationGuestDevice((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VirtualizationGuestDevice"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VirtualizationGuestDevice value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.CreateFenceFd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, int* pFenceFd) => LpVtbl->CreateFenceFd(pFence, FenceValue, pFenceFd);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateFenceFd(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue, Ref<int> pFenceFd)
    {
        fixed (int* __dsl_pFenceFd = pFenceFd)
        {
            return (HResult)CreateFenceFd(pFence, FenceValue, __dsl_pFenceFd);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.ShareWithHost"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult ShareWithHost(ID3D12DeviceChild pObject, Handle* pHandle) => LpVtbl->ShareWithHost(pObject, pHandle);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ShareWithHost(ID3D12DeviceChild pObject, Ref<Handle> pHandle)
    {
        fixed (Handle* __dsl_pHandle = pHandle)
        {
            return (HResult)ShareWithHost(pObject, __dsl_pHandle);
        }
    }
}
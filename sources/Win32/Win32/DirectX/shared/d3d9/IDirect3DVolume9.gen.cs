// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9"]/*'/>
[Guid("24F416E6-1F67-4AA7-B88E-D33F6F3128A1")]
[NativeTypeName("struct IDirect3DVolume9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DVolume9 : IDirect3DVolume9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DVolume9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(6)]
        HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult FreePrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid);
        [VtblIndex(7)]
        HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer);
        [VtblIndex(8)]
        HResult GetDesc(D3DvolumeDesc* pDesc);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3DvolumeDesc> pDesc);
        [VtblIndex(3)]
        HResult GetDevice(IDirect3DDevice9* ppDevice);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDevice(Ref<IDirect3DDevice9> ppDevice);
        [VtblIndex(5)]
        HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, Ref pData, [NativeTypeName("DWORD *")] Ref<uint> pSizeOfData);
        [VtblIndex(9)]
        HResult LockBox(D3DlockedBox* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3Dbox* pBox, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LockBox(Ref<D3DlockedBox> pLockedVolume, [NativeTypeName("const D3DBOX *")] Ref<D3Dbox> pBox, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(4)]
        HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, [NativeTypeName("const void *")] Ref pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(10)]
        HResult UnlockBox();
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9"]/*'/>
    [Guid("24F416E6-1F67-4AA7-B88E-D33F6F3128A1")]
    [NativeTypeName("struct IDirect3DVolume9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DVolume9));

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
            [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DDevice9.Native**, HResult> GetDevice;
            [NativeTypeName("HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void*, uint, uint, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void*, uint*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, HResult> FreePrivateData;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetContainer;
            [NativeTypeName("HRESULT (D3DVOLUME_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DvolumeDesc*, HResult> GetDesc;
            [NativeTypeName("HRESULT (D3DLOCKED_BOX *, const D3DBOX *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DlockedBox*, D3Dbox*, uint, HResult> LockBox;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> UnlockBox;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, uint> )(lpVtbl[1]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.FreePrivateData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, Guid*, HResult> )(lpVtbl[6]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), refguid);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult FreePrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid)
        {
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)FreePrivateData(__dsl_refguid);
            }
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetContainer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), riid, ppContainer);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer)
        {
            fixed (void** __dsl_ppContainer = ppContainer)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetContainer(__dsl_riid, __dsl_ppContainer);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetContainer<TCom>(out TCom ppContainer)
            where TCom : unmanaged, IComVtbl
        {
            ppContainer = default;
            return GetContainer(TCom.NativeGuid, ppContainer.GetAddressOf());
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDesc(D3DvolumeDesc* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, D3DvolumeDesc*, HResult> )(lpVtbl[8]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3DvolumeDesc> pDesc)
        {
            fixed (D3DvolumeDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
        {
            fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
            {
                return (HResult)GetDevice(__dsl_ppDevice);
            }
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetPrivateData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, Guid*, void*, uint*, HResult> )(lpVtbl[5]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, Ref pData, [NativeTypeName("DWORD *")] Ref<uint> pSizeOfData)
        {
            fixed (uint* __dsl_pSizeOfData = pSizeOfData)
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)GetPrivateData(__dsl_refguid, __dsl_pData, __dsl_pSizeOfData);
            }
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.LockBox"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult LockBox(D3DlockedBox* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3Dbox* pBox, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, D3DlockedBox*, D3Dbox*, uint, HResult> )(lpVtbl[9]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), pLockedVolume, pBox, Flags);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LockBox(Ref<D3DlockedBox> pLockedVolume, [NativeTypeName("const D3DBOX *")] Ref<D3Dbox> pBox, [NativeTypeName("DWORD")] uint Flags)
        {
            fixed (D3Dbox* __dsl_pBox = pBox)
            fixed (D3DlockedBox* __dsl_pLockedVolume = pLockedVolume)
            {
                return (HResult)LockBox(__dsl_pLockedVolume, __dsl_pBox, Flags);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, uint> )(lpVtbl[2]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.SetPrivateData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, Guid*, void*, uint, uint, HResult> )(lpVtbl[4]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, [NativeTypeName("const void *")] Ref pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)SetPrivateData(__dsl_refguid, __dsl_pData, SizeOfData, Flags);
            }
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.UnlockBox"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult UnlockBox()
        {
            return ((delegate* unmanaged<IDirect3DVolume9.Native*, HResult> )(lpVtbl[10]))((IDirect3DVolume9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DVolume9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DVolume9(Ptr3D vtbl) => LpVtbl = (IDirect3DVolume9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DVolume9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DVolume9(Ptr<IDirect3DVolume9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DVolume9.Native"/> to <see cref = "IDirect3DVolume9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DVolume9(IDirect3DVolume9.Native* value) => new IDirect3DVolume9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DVolume9"/> to <see cref = "IDirect3DVolume9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9"/> instance to be converted </param>
    public static implicit operator IDirect3DVolume9.Native*(IDirect3DVolume9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DVolume9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DVolume9(Ptr3D value) => new IDirect3DVolume9(value);
    /// <summary>casts <see cref = "IDirect3DVolume9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DVolume9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DVolume9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DVolume9(Ptr<IDirect3DVolume9.Native> value) => new IDirect3DVolume9(value);
    /// <summary>casts <see cref = "IDirect3DVolume9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DVolume9.Native>(IDirect3DVolume9 value) => (Ptr<IDirect3DVolume9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DVolume9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DVolume9(void*** value) => new IDirect3DVolume9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DVolume9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DVolume9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DVolume9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DVolume9(nuint value) => new IDirect3DVolume9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DVolume9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVolume9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DVolume9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.FreePrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid) => LpVtbl->FreePrivateData(refguid);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult FreePrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid)
    {
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)FreePrivateData(__dsl_refguid);
        }
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetContainer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer) => LpVtbl->GetContainer(riid, ppContainer);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer)
    {
        fixed (void** __dsl_ppContainer = ppContainer)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetContainer(__dsl_riid, __dsl_ppContainer);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetContainer<TCom>(out TCom ppContainer)
        where TCom : unmanaged, IComVtbl
    {
        ppContainer = default;
        return GetContainer(TCom.NativeGuid, ppContainer.GetAddressOf());
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDesc(D3DvolumeDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3DvolumeDesc> pDesc)
    {
        fixed (D3DvolumeDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetDevice(IDirect3DDevice9* ppDevice) => LpVtbl->GetDevice(ppDevice);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
    {
        fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
        {
            return (HResult)GetDevice(__dsl_ppDevice);
        }
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetPrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData) => LpVtbl->GetPrivateData(refguid, pData, pSizeOfData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, Ref pData, [NativeTypeName("DWORD *")] Ref<uint> pSizeOfData)
    {
        fixed (uint* __dsl_pSizeOfData = pSizeOfData)
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)GetPrivateData(__dsl_refguid, __dsl_pData, __dsl_pSizeOfData);
        }
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.LockBox"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult LockBox(D3DlockedBox* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3Dbox* pBox, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->LockBox(pLockedVolume, pBox, Flags);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LockBox(Ref<D3DlockedBox> pLockedVolume, [NativeTypeName("const D3DBOX *")] Ref<D3Dbox> pBox, [NativeTypeName("DWORD")] uint Flags)
    {
        fixed (D3Dbox* __dsl_pBox = pBox)
        fixed (D3DlockedBox* __dsl_pLockedVolume = pLockedVolume)
        {
            return (HResult)LockBox(__dsl_pLockedVolume, __dsl_pBox, Flags);
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
    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.SetPrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->SetPrivateData(refguid, pData, SizeOfData, Flags);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, [NativeTypeName("const void *")] Ref pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)SetPrivateData(__dsl_refguid, __dsl_pData, SizeOfData, Flags);
        }
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.UnlockBox"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult UnlockBox() => LpVtbl->UnlockBox();
}
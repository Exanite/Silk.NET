// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory"]/*'/>
[Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
[NativeTypeName("struct IDXGIFactory : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIFactory : IDXGIFactory.Interface, INativeGuid
{
    public Native* lpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IID_IDXGIFactory));

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => lpVtbl->QueryInterface(riid, ppvObject);
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => lpVtbl->AddRef();
    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => lpVtbl->Release();
    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData) => lpVtbl->SetPrivateData(Name, DataSize, pData);
    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown pUnknown) => lpVtbl->SetPrivateDataInterface(Name, pUnknown);
    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData) => lpVtbl->GetPrivateData(Name, pDataSize, pData);
    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent) => lpVtbl->GetParent(riid, ppParent);
    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.EnumAdapters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter) => lpVtbl->EnumAdapters(Adapter, ppAdapter);
    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.MakeWindowAssociation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult MakeWindowAssociation(HWND WindowHandle, uint Flags) => lpVtbl->MakeWindowAssociation(WindowHandle, Flags);
    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.GetWindowAssociation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetWindowAssociation(HWND* pWindowHandle) => lpVtbl->GetWindowAssociation(pWindowHandle);
    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.CreateSwapChain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CreateSwapChain(IUnknown pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain* ppSwapChain) => lpVtbl->CreateSwapChain(pDevice, pDesc, ppSwapChain);
    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.CreateSoftwareAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter* ppAdapter) => lpVtbl->CreateSoftwareAdapter(Module, ppAdapter);
    public interface Interface : IDXGIObject.Interface
    {
        [VtblIndex(7)]
        HResult EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter);
        [VtblIndex(8)]
        HResult MakeWindowAssociation(HWND WindowHandle, uint Flags);
        [VtblIndex(9)]
        HResult GetWindowAssociation(HWND* pWindowHandle);
        [VtblIndex(10)]
        HResult CreateSwapChain(IUnknown pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain* ppSwapChain);
        [VtblIndex(11)]
        HResult CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter* ppAdapter);
    }

    /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory"]/*'/>
    [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
    [NativeTypeName("struct IDXGIFactory : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IID_IDXGIFactory));

        public void** lpVtbl;
        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, uint> )(lpVtbl[1]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, uint> )(lpVtbl[2]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, Guid*, uint, void*, HResult> )(lpVtbl[3]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown pUnknown)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[4]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
        }

        /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[5]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref = "IDXGIObject.GetParent"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, Guid*, void**, HResult> )(lpVtbl[6]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.EnumAdapters"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, uint, IDXGIAdapter.Native**, HResult> )(lpVtbl[7]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), Adapter, &ppAdapter->lpVtbl);
        }

        /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.MakeWindowAssociation"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult MakeWindowAssociation(HWND WindowHandle, uint Flags)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, HWND, uint, HResult> )(lpVtbl[8]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.GetWindowAssociation"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetWindowAssociation(HWND* pWindowHandle)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, HWND*, HResult> )(lpVtbl[9]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.CreateSwapChain"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CreateSwapChain(IUnknown pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain* ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, IUnknown.Native*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain.Native**, HResult> )(lpVtbl[10]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), pDevice.lpVtbl, pDesc, &ppSwapChain->lpVtbl);
        }

        /// <include file='IDXGIFactory.xml' path='doc/member[@name="IDXGIFactory.CreateSoftwareAdapter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter* ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory.Native*, HMODULE, IDXGIAdapter.Native**, HResult> )(lpVtbl[11]))((IDXGIFactory.Native*)Unsafe.AsPointer(ref this), Module, &ppAdapter->lpVtbl);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;
            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, IUnknown.Native*, HResult> SetPrivateDataInterface;
            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetParent;
            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDXGIAdapter.Native**, HResult> EnumAdapters;
            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND, uint, HResult> MakeWindowAssociation;
            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND*, HResult> GetWindowAssociation;
            [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IUnknown.Native*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain.Native**, HResult> CreateSwapChain;
            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HMODULE, IDXGIAdapter.Native**, HResult> CreateSoftwareAdapter;
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactory(Ptr3D vtbl) => lpVtbl = (IDXGIFactory.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactory(Ptr<IDXGIFactory.Native> vtbl) => lpVtbl = vtbl;
    /// <summary>casts <see cref = "IDXGIFactory.Native"/> to <see cref = "IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory.Native"/> instance to be converted </param>
    public static implicit operator IDXGIFactory(IDXGIFactory.Native* value) => new IDXGIFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXGIFactory"/> to <see cref = "IDXGIFactory.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory"/> instance to be converted </param>
    public static implicit operator IDXGIFactory.Native*(IDXGIFactory value) => value.lpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDXGIFactory(Ptr3D value) => new IDXGIFactory(value);
    /// <summary>casts <see cref = "IDXGIFactory"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDXGIFactory value) => (Ptr3D)value.lpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDXGIFactory(Ptr<IDXGIFactory.Native> value) => new IDXGIFactory(value);
    /// <summary>casts <see cref = "IDXGIFactory"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory"/> instance to be converted </param>
    public static implicit operator Ptr<IDXGIFactory.Native>(IDXGIFactory value) => (Ptr<IDXGIFactory.Native>)value.lpVtbl;
    /// <summary>casts void*** to <see cref = "IDXGIFactory"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDXGIFactory(void*** value) => new IDXGIFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXGIFactory"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory"/> instance to be converted </param>
    public static implicit operator void***(IDXGIFactory value) => (void***)value.lpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDXGIFactory(nuint value) => new IDXGIFactory((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDXGIFactory"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory"/> instance to be converted </param>
    public static implicit operator nuint(IDXGIFactory value) => (nuint)value.lpVtbl;
}
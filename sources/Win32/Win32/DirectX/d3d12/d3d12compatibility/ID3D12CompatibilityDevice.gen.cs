// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice"]/*'/>
[Guid("8F1C0E3C-FAE3-4A82-B098-BFE1708207FF")]
[NativeTypeName("struct ID3D12CompatibilityDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CompatibilityDevice : ID3D12CompatibilityDevice.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12CompatibilityDevice));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppHeap);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppHeap);
        [VtblIndex(3)]
        HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Guid* riid, void** ppResource);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] Ref<D3D11_RESOURCE_FLAGS> pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppResource);
        [VtblIndex(5)]
        HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, void* pData, uint DataSize);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, Ref pData, uint DataSize);
    }

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice"]/*'/>
    [Guid("8F1C0E3C-FAE3-4A82-B098-BFE1708207FF")]
    [NativeTypeName("struct ID3D12CompatibilityDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12CompatibilityDevice));

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
            [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const D3D11_RESOURCE_FLAGS *, D3D12_COMPATIBILITY_SHARED_FLAGS, ID3D12LifetimeTracker *, ID3D12SwapChainAssistant *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapProperties*, D3D12HeapFlags, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, D3D11_RESOURCE_FLAGS*, D3D12CompatibilitySharedFlags, ID3D12LifetimeTracker.Native*, ID3D12SwapChainAssistant.Native*, Guid*, void**, HResult> CreateSharedResource;
            [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, D3D12_COMPATIBILITY_SHARED_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapDesc*, D3D12CompatibilitySharedFlags, Guid*, void**, HResult> CreateSharedHeap;
            [NativeTypeName("HRESULT (ID3D12Object *, D3D12_REFLECT_SHARED_PROPERTY, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Object.Native*, D3D12ReflectSharedProperty, void*, uint, HResult> ReflectSharedProperties;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, uint> )(lpVtbl[1]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppHeap)
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, D3D12HeapDesc*, D3D12CompatibilitySharedFlags, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this), pHeapDesc, CompatibilityFlags, riid, ppHeap);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppHeap)
        {
            fixed (void** __dsl_ppHeap = ppHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12HeapDesc* __dsl_pHeapDesc = pHeapDesc)
            {
                return (HResult)CreateSharedHeap(__dsl_pHeapDesc, CompatibilityFlags, __dsl_riid, __dsl_ppHeap);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateSharedHeap<TCom>([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, out TCom ppHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12HeapDesc* __dsl_pHeapDesc = pHeapDesc)
            {
                ppHeap = default;
                return CreateSharedHeap(__dsl_pHeapDesc, CompatibilityFlags, TCom.NativeGuid, ppHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Guid* riid, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, D3D12HeapProperties*, D3D12HeapFlags, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, D3D11_RESOURCE_FLAGS*, D3D12CompatibilitySharedFlags, ID3D12LifetimeTracker.Native*, ID3D12SwapChainAssistant.Native*, Guid*, void**, HResult> )(lpVtbl[3]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pFlags11, CompatibilityFlags, pLifetimeTracker.LpVtbl, pOwningSwapchain.LpVtbl, riid, ppResource);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] Ref<D3D11_RESOURCE_FLAGS> pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppResource)
        {
            fixed (void** __dsl_ppResource = ppResource)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D11_RESOURCE_FLAGS* __dsl_pFlags11 = pFlags11)
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
            {
                return (HResult)CreateSharedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_pFlags11, CompatibilityFlags, pLifetimeTracker, pOwningSwapchain, __dsl_riid, __dsl_ppResource);
            }
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateSharedResource<TCom>([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] Ref<D3D11_RESOURCE_FLAGS> pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, out TCom ppResource)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D11_RESOURCE_FLAGS* __dsl_pFlags11 = pFlags11)
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
            {
                ppResource = default;
                return CreateSharedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_pFlags11, CompatibilityFlags, pLifetimeTracker, pOwningSwapchain, TCom.NativeGuid, ppResource.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.ReflectSharedProperties"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, ID3D12Object.Native*, D3D12ReflectSharedProperty, void*, uint, HResult> )(lpVtbl[5]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this), pHeapOrResource.LpVtbl, ReflectType, pData, DataSize);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, Ref pData, uint DataSize)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)ReflectSharedProperties(pHeapOrResource, ReflectType, __dsl_pData, DataSize);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12CompatibilityDevice.Native*, uint> )(lpVtbl[2]))((ID3D12CompatibilityDevice.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12CompatibilityDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CompatibilityDevice(Ptr3D vtbl) => LpVtbl = (ID3D12CompatibilityDevice.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12CompatibilityDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CompatibilityDevice(Ptr<ID3D12CompatibilityDevice.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice.Native"/> to <see cref = "ID3D12CompatibilityDevice"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice.Native"/> instance to be converted </param>
    public static implicit operator ID3D12CompatibilityDevice(ID3D12CompatibilityDevice.Native* value) => new ID3D12CompatibilityDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice"/> to <see cref = "ID3D12CompatibilityDevice.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice"/> instance to be converted </param>
    public static implicit operator ID3D12CompatibilityDevice.Native*(ID3D12CompatibilityDevice value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12CompatibilityDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12CompatibilityDevice(Ptr3D value) => new ID3D12CompatibilityDevice(value);
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12CompatibilityDevice value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12CompatibilityDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12CompatibilityDevice(Ptr<ID3D12CompatibilityDevice.Native> value) => new ID3D12CompatibilityDevice(value);
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12CompatibilityDevice.Native>(ID3D12CompatibilityDevice value) => (Ptr<ID3D12CompatibilityDevice.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12CompatibilityDevice"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12CompatibilityDevice(void*** value) => new ID3D12CompatibilityDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice"/> instance to be converted </param>
    public static implicit operator void***(ID3D12CompatibilityDevice value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12CompatibilityDevice"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12CompatibilityDevice(nuint value) => new ID3D12CompatibilityDevice((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12CompatibilityDevice"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CompatibilityDevice"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12CompatibilityDevice value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppHeap) => LpVtbl->CreateSharedHeap(pHeapDesc, CompatibilityFlags, riid, ppHeap);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSharedHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppHeap)
    {
        fixed (void** __dsl_ppHeap = ppHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12HeapDesc* __dsl_pHeapDesc = pHeapDesc)
        {
            return (HResult)CreateSharedHeap(__dsl_pHeapDesc, CompatibilityFlags, __dsl_riid, __dsl_ppHeap);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSharedHeap<TCom>([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pHeapDesc, D3D12CompatibilitySharedFlags CompatibilityFlags, out TCom ppHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12HeapDesc* __dsl_pHeapDesc = pHeapDesc)
        {
            ppHeap = default;
            return CreateSharedHeap(__dsl_pHeapDesc, CompatibilityFlags, TCom.NativeGuid, ppHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Guid* riid, void** ppResource) => LpVtbl->CreateSharedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pFlags11, CompatibilityFlags, pLifetimeTracker, pOwningSwapchain, riid, ppResource);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSharedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] Ref<D3D11_RESOURCE_FLAGS> pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppResource)
    {
        fixed (void** __dsl_ppResource = ppResource)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D11_RESOURCE_FLAGS* __dsl_pFlags11 = pFlags11)
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
        {
            return (HResult)CreateSharedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_pFlags11, CompatibilityFlags, pLifetimeTracker, pOwningSwapchain, __dsl_riid, __dsl_ppResource);
        }
    }

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSharedResource<TCom>([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] Ref<D3D11_RESOURCE_FLAGS> pFlags11, D3D12CompatibilitySharedFlags CompatibilityFlags, ID3D12LifetimeTracker pLifetimeTracker, ID3D12SwapChainAssistant pOwningSwapchain, out TCom ppResource)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D11_RESOURCE_FLAGS* __dsl_pFlags11 = pFlags11)
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
        {
            ppResource = default;
            return CreateSharedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_pFlags11, CompatibilityFlags, pLifetimeTracker, pOwningSwapchain, TCom.NativeGuid, ppResource.GetAddressOf());
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

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.ReflectSharedProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, void* pData, uint DataSize) => LpVtbl->ReflectSharedProperties(pHeapOrResource, ReflectType, pData, DataSize);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ReflectSharedProperties(ID3D12Object pHeapOrResource, D3D12ReflectSharedProperty ReflectType, Ref pData, uint DataSize)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)ReflectSharedProperties(pHeapOrResource, ReflectType, __dsl_pData, DataSize);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
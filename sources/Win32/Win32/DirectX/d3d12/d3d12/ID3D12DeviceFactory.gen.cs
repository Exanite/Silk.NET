// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory"]/*'/>
[Guid("61F307D3-D34E-4E7C-8374-3BA4DE23CCCB")]
[NativeTypeName("struct ID3D12DeviceFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceFactory : ID3D12DeviceFactory.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceFactory));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult ApplyToGlobalState();
        [VtblIndex(9)]
        HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppvDevice);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice);
        [VtblIndex(8)]
        HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Ref<Guid> pIIDs, Ref pConfigurationStructs, Ref<uint> pConfigurationStructSizes);
        [VtblIndex(7)]
        HResult GetConfigurationInterface([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* iid, void** ppv);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetConfigurationInterface([NativeTypeName("const IID &")] Ref<Guid> clsid, [NativeTypeName("const IID &")] Ref<Guid> iid, Ref2D ppv);
        [VtblIndex(6)]
        D3D12DeviceFactoryFlags GetFlags();
        [VtblIndex(3)]
        HResult InitializeFromGlobalState();
        [VtblIndex(5)]
        HResult SetFlags(D3D12DeviceFactoryFlags flags);
    }

    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory"]/*'/>
    [Guid("61F307D3-D34E-4E7C-8374-3BA4DE23CCCB")]
    [NativeTypeName("struct ID3D12DeviceFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceFactory));

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
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> InitializeFromGlobalState;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> ApplyToGlobalState;
            [NativeTypeName("HRESULT (D3D12_DEVICE_FACTORY_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DeviceFactoryFlags, HResult> SetFlags;
            [NativeTypeName("D3D12_DEVICE_FACTORY_FLAGS () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DeviceFactoryFlags> GetFlags;
            [NativeTypeName("HRESULT (const IID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, HResult> GetConfigurationInterface;
            [NativeTypeName("HRESULT (UINT, const IID *, void *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, Guid*, void*, uint*, HResult> EnableExperimentalFeatures;
            [NativeTypeName("HRESULT (IUnknown *, D3D_FEATURE_LEVEL, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IUnknown.Native*, D3DFeatureLevel, Guid*, void**, HResult> CreateDevice;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, uint> )(lpVtbl[1]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.ApplyToGlobalState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult ApplyToGlobalState()
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, HResult> )(lpVtbl[4]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.CreateDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, IUnknown.Native*, D3DFeatureLevel, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this), adapter.lpVtbl, FeatureLevel, riid, ppvDevice);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
        {
            fixed (void** __dsl_ppvDevice = ppvDevice)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateDevice(adapter, FeatureLevel, __dsl_riid, __dsl_ppvDevice);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        public HResult CreateDevice<TCom>(IUnknown adapter, D3DFeatureLevel FeatureLevel, out TCom ppvDevice)
            where TCom : unmanaged, IComVtbl
        {
            ppvDevice = default;
            return CreateDevice(adapter, FeatureLevel, TCom.NativeGuid, ppvDevice.GetAddressOf());
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.EnableExperimentalFeatures"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, uint, Guid*, void*, uint*, HResult> )(lpVtbl[8]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this), NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizes);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Ref<Guid> pIIDs, Ref pConfigurationStructs, Ref<uint> pConfigurationStructSizes)
        {
            fixed (uint* __dsl_pConfigurationStructSizes = pConfigurationStructSizes)
            fixed (void* __dsl_pConfigurationStructs = pConfigurationStructs)
            fixed (Guid* __dsl_pIIDs = pIIDs)
            {
                return (HResult)EnableExperimentalFeatures(NumFeatures, __dsl_pIIDs, __dsl_pConfigurationStructs, __dsl_pConfigurationStructSizes);
            }
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.GetConfigurationInterface"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetConfigurationInterface([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* iid, void** ppv)
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, Guid*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this), clsid, iid, ppv);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetConfigurationInterface([NativeTypeName("const IID &")] Ref<Guid> clsid, [NativeTypeName("const IID &")] Ref<Guid> iid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_iid = iid)
            fixed (Guid* __dsl_clsid = clsid)
            {
                return (HResult)GetConfigurationInterface(__dsl_clsid, __dsl_iid, __dsl_ppv);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetConfigurationInterface<TCom>([NativeTypeName("const IID &")] Ref<Guid> clsid, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            fixed (Guid* __dsl_clsid = clsid)
            {
                ppv = default;
                return GetConfigurationInterface(__dsl_clsid, TCom.NativeGuid, ppv.GetAddressOf());
            }
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.GetFlags"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public D3D12DeviceFactoryFlags GetFlags()
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, D3D12DeviceFactoryFlags> )(lpVtbl[6]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.InitializeFromGlobalState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult InitializeFromGlobalState()
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, HResult> )(lpVtbl[3]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, uint> )(lpVtbl[2]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.SetFlags"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetFlags(D3D12DeviceFactoryFlags flags)
        {
            return ((delegate* unmanaged<ID3D12DeviceFactory.Native*, D3D12DeviceFactoryFlags, HResult> )(lpVtbl[5]))((ID3D12DeviceFactory.Native*)Unsafe.AsPointer(ref this), flags);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceFactory(Ptr3D vtbl) => LpVtbl = (ID3D12DeviceFactory.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceFactory(Ptr<ID3D12DeviceFactory.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DeviceFactory.Native"/> to <see cref = "ID3D12DeviceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceFactory(ID3D12DeviceFactory.Native* value) => new ID3D12DeviceFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceFactory"/> to <see cref = "ID3D12DeviceFactory.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceFactory.Native*(ID3D12DeviceFactory value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DeviceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceFactory(Ptr3D value) => new ID3D12DeviceFactory(value);
    /// <summary>casts <see cref = "ID3D12DeviceFactory"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DeviceFactory value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DeviceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceFactory(Ptr<ID3D12DeviceFactory.Native> value) => new ID3D12DeviceFactory(value);
    /// <summary>casts <see cref = "ID3D12DeviceFactory"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DeviceFactory.Native>(ID3D12DeviceFactory value) => (Ptr<ID3D12DeviceFactory.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DeviceFactory"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DeviceFactory(void*** value) => new ID3D12DeviceFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceFactory"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DeviceFactory value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DeviceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceFactory(nuint value) => new ID3D12DeviceFactory((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DeviceFactory"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceFactory"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DeviceFactory value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.ApplyToGlobalState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult ApplyToGlobalState() => LpVtbl->ApplyToGlobalState();
    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.CreateDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppvDevice) => LpVtbl->CreateDevice(adapter, FeatureLevel, riid, ppvDevice);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDevice(IUnknown adapter, D3DFeatureLevel FeatureLevel, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
    {
        fixed (void** __dsl_ppvDevice = ppvDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateDevice(adapter, FeatureLevel, __dsl_riid, __dsl_ppvDevice);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    public HResult CreateDevice<TCom>(IUnknown adapter, D3DFeatureLevel FeatureLevel, out TCom ppvDevice)
        where TCom : unmanaged, IComVtbl
    {
        ppvDevice = default;
        return CreateDevice(adapter, FeatureLevel, TCom.NativeGuid, ppvDevice.GetAddressOf());
    }

    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.EnableExperimentalFeatures"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes) => LpVtbl->EnableExperimentalFeatures(NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizes);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Ref<Guid> pIIDs, Ref pConfigurationStructs, Ref<uint> pConfigurationStructSizes)
    {
        fixed (uint* __dsl_pConfigurationStructSizes = pConfigurationStructSizes)
        fixed (void* __dsl_pConfigurationStructs = pConfigurationStructs)
        fixed (Guid* __dsl_pIIDs = pIIDs)
        {
            return (HResult)EnableExperimentalFeatures(NumFeatures, __dsl_pIIDs, __dsl_pConfigurationStructs, __dsl_pConfigurationStructSizes);
        }
    }

    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.GetConfigurationInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetConfigurationInterface([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* iid, void** ppv) => LpVtbl->GetConfigurationInterface(clsid, iid, ppv);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetConfigurationInterface([NativeTypeName("const IID &")] Ref<Guid> clsid, [NativeTypeName("const IID &")] Ref<Guid> iid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_iid = iid)
        fixed (Guid* __dsl_clsid = clsid)
        {
            return (HResult)GetConfigurationInterface(__dsl_clsid, __dsl_iid, __dsl_ppv);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetConfigurationInterface<TCom>([NativeTypeName("const IID &")] Ref<Guid> clsid, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        fixed (Guid* __dsl_clsid = clsid)
        {
            ppv = default;
            return GetConfigurationInterface(__dsl_clsid, TCom.NativeGuid, ppv.GetAddressOf());
        }
    }

    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.GetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D3D12DeviceFactoryFlags GetFlags() => LpVtbl->GetFlags();
    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.InitializeFromGlobalState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult InitializeFromGlobalState() => LpVtbl->InitializeFromGlobalState();
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
    /// <include file='ID3D12DeviceFactory.xml' path='doc/member[@name="ID3D12DeviceFactory.SetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SetFlags(D3D12DeviceFactoryFlags flags) => LpVtbl->SetFlags(flags);
}
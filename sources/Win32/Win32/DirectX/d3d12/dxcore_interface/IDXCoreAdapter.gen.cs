// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter"]/*'/>
[Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
[NativeTypeName("struct IDXCoreAdapter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapter : IDXCoreAdapter.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapter));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(12)]
        HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory);
        [VtblIndex(6)]
        HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, Ref propertyData);
        [VtblIndex(7)]
        HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] Ref<nuint> bufferSize);
        [VtblIndex(4)]
        bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        bool IsAttributeSupported([NativeTypeName("const GUID &")] Ref<Guid> attributeGUID);
        [VtblIndex(5)]
        bool IsPropertySupported(DXCoreAdapterProperty property);
        [VtblIndex(8)]
        bool IsQueryStateSupported(DXCoreAdapterState property);
        [VtblIndex(10)]
        bool IsSetStateSupported(DXCoreAdapterState property);
        [VtblIndex(3)]
        bool IsValid();
        [VtblIndex(9)]
        HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer);
        [VtblIndex(11)]
        HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] Ref inputData);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter"]/*'/>
    [Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
    [NativeTypeName("struct IDXCoreAdapter : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapter));

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
            [NativeTypeName("bool () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, byte> IsValid;
            [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, byte> IsAttributeSupported;
            [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, byte> IsPropertySupported;
            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, nuint, void*, HResult> GetProperty;
            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, nuint*, HResult> GetPropertySize;
            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterState, byte> IsQueryStateSupported;
            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> QueryState;
            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterState, byte> IsSetStateSupported;
            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> SetState;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetFactory;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, uint> )(lpVtbl[1]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetFactory"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, Guid*, void**, HResult> )(lpVtbl[12]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
        {
            fixed (void** __dsl_ppvFactory = ppvFactory)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetFactory(__dsl_riid, __dsl_ppvFactory);
            }
        }

        [VtblIndex(12)]
        [Transformed]
        public HResult GetFactory<TCom>(out TCom ppvFactory)
            where TCom : unmanaged, IComVtbl
        {
            ppvFactory = default;
            return GetFactory(TCom.NativeGuid, ppvFactory.GetAddressOf());
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetProperty"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterProperty, nuint, void*, HResult> )(lpVtbl[6]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, Ref propertyData)
        {
            fixed (void* __dsl_propertyData = propertyData)
            {
                return (HResult)GetProperty(property, bufferSize, __dsl_propertyData);
            }
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetPropertySize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterProperty, nuint*, HResult> )(lpVtbl[7]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), property, bufferSize);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] Ref<nuint> bufferSize)
        {
            fixed (nuint* __dsl_bufferSize = bufferSize)
            {
                return (HResult)GetPropertySize(property, __dsl_bufferSize);
            }
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsAttributeSupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, Guid*, byte> )(lpVtbl[4]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), attributeGUID) != 0;
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Ref<Guid> attributeGUID)
        {
            fixed (Guid* __dsl_attributeGUID = attributeGUID)
            {
                return (bool)IsAttributeSupported(__dsl_attributeGUID);
            }
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsPropertySupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool IsPropertySupported(DXCoreAdapterProperty property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterProperty, byte> )(lpVtbl[5]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsQueryStateSupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public bool IsQueryStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterState, byte> )(lpVtbl[8]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsSetStateSupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public bool IsSetStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterState, byte> )(lpVtbl[10]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsValid"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public bool IsValid()
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, byte> )(lpVtbl[3]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this)) != 0;
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.QueryState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> )(lpVtbl[9]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer)
        {
            fixed (void* __dsl_outputBuffer = outputBuffer)
            fixed (void* __dsl_inputStateDetails = inputStateDetails)
            {
                return (HResult)QueryState(state, inputStateDetailsSize, __dsl_inputStateDetails, outputBufferSize, __dsl_outputBuffer);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, uint> )(lpVtbl[2]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.SetState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter.Native*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> )(lpVtbl[11]))((IDXCoreAdapter.Native*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] Ref inputData)
        {
            fixed (void* __dsl_inputData = inputData)
            fixed (void* __dsl_inputStateDetails = inputStateDetails)
            {
                return (HResult)SetState(state, inputStateDetailsSize, __dsl_inputStateDetails, inputDataSize, __dsl_inputData);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapter(Ptr3D vtbl) => LpVtbl = (IDXCoreAdapter.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapter(Ptr<IDXCoreAdapter.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDXCoreAdapter.Native"/> to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter.Native"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapter(IDXCoreAdapter.Native* value) => new IDXCoreAdapter((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapter"/> to <see cref = "IDXCoreAdapter.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapter.Native*(IDXCoreAdapter value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter(Ptr3D value) => new IDXCoreAdapter(value);
    /// <summary>casts <see cref = "IDXCoreAdapter"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDXCoreAdapter value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter(Ptr<IDXCoreAdapter.Native> value) => new IDXCoreAdapter(value);
    /// <summary>casts <see cref = "IDXCoreAdapter"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator Ptr<IDXCoreAdapter.Native>(IDXCoreAdapter value) => (Ptr<IDXCoreAdapter.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDXCoreAdapter(void*** value) => new IDXCoreAdapter((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapter"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator void***(IDXCoreAdapter value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter(nuint value) => new IDXCoreAdapter((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDXCoreAdapter"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator nuint(IDXCoreAdapter value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetFactory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory) => LpVtbl->GetFactory(riid, ppvFactory);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
    {
        fixed (void** __dsl_ppvFactory = ppvFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetFactory(__dsl_riid, __dsl_ppvFactory);
        }
    }

    [VtblIndex(12)]
    [Transformed]
    public HResult GetFactory<TCom>(out TCom ppvFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppvFactory = default;
        return GetFactory(TCom.NativeGuid, ppvFactory.GetAddressOf());
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData) => LpVtbl->GetProperty(property, bufferSize, propertyData);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, Ref propertyData)
    {
        fixed (void* __dsl_propertyData = propertyData)
        {
            return (HResult)GetProperty(property, bufferSize, __dsl_propertyData);
        }
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetPropertySize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize) => LpVtbl->GetPropertySize(property, bufferSize);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] Ref<nuint> bufferSize)
    {
        fixed (nuint* __dsl_bufferSize = bufferSize)
        {
            return (HResult)GetPropertySize(property, __dsl_bufferSize);
        }
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsAttributeSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID) => LpVtbl->IsAttributeSupported(attributeGUID);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool IsAttributeSupported([NativeTypeName("const GUID &")] Ref<Guid> attributeGUID)
    {
        fixed (Guid* __dsl_attributeGUID = attributeGUID)
        {
            return (bool)IsAttributeSupported(__dsl_attributeGUID);
        }
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsPropertySupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsPropertySupported(DXCoreAdapterProperty property) => LpVtbl->IsPropertySupported(property);
    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsQueryStateSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsQueryStateSupported(DXCoreAdapterState property) => LpVtbl->IsQueryStateSupported(property);
    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsSetStateSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsSetStateSupported(DXCoreAdapterState property) => LpVtbl->IsSetStateSupported(property);
    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsValid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool IsValid() => LpVtbl->IsValid();
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

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.QueryState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer) => LpVtbl->QueryState(state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer)
    {
        fixed (void* __dsl_outputBuffer = outputBuffer)
        fixed (void* __dsl_inputStateDetails = inputStateDetails)
        {
            return (HResult)QueryState(state, inputStateDetailsSize, __dsl_inputStateDetails, outputBufferSize, __dsl_outputBuffer);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.SetState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData) => LpVtbl->SetState(state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] Ref inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] Ref inputData)
    {
        fixed (void* __dsl_inputData = inputData)
        fixed (void* __dsl_inputStateDetails = inputStateDetails)
        {
            return (HResult)SetState(state, inputStateDetailsSize, __dsl_inputStateDetails, inputDataSize, __dsl_inputData);
        }
    }
}
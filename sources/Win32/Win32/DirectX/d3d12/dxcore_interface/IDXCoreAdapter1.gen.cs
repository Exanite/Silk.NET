// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1"]/*'/>
[Guid("A0783366-CFA3-43BE-9D79-55B2DA97C63C")]
[NativeTypeName("struct IDXCoreAdapter1 : IDXCoreAdapter")]
[NativeInheritance("IDXCoreAdapter")]
public unsafe partial struct IDXCoreAdapter1 : IDXCoreAdapter1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapter1));

    public interface Interface : IDXCoreAdapter.Interface
    {
        [VtblIndex(13)]
        HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] void* inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer);
        [VtblIndex(13)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] Ref inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer);
    }

    /// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1"]/*'/>
    [Guid("A0783366-CFA3-43BE-9D79-55B2DA97C63C")]
    [NativeTypeName("struct IDXCoreAdapter1 : IDXCoreAdapter")]
    [NativeInheritance("IDXCoreAdapter")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapter1));

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
            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, nuint, void*, nuint, void*, HResult> GetPropertyWithInput;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, uint> )(lpVtbl[1]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDXCoreAdapter.GetFactory"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, Guid*, void**, HResult> )(lpVtbl[12]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), riid, ppvFactory);
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

        /// <inheritdoc cref = "IDXCoreAdapter.GetProperty"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterProperty, nuint, void*, HResult> )(lpVtbl[6]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
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

        /// <inheritdoc cref = "IDXCoreAdapter.GetPropertySize"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterProperty, nuint*, HResult> )(lpVtbl[7]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property, bufferSize);
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

        /// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1.GetPropertyWithInput"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] void* inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterProperty, nuint, void*, nuint, void*, HResult> )(lpVtbl[13]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property, inputPropertyDetailsSize, inputPropertyDetails, outputBufferSize, outputBuffer);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] Ref inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer)
        {
            fixed (void* __dsl_outputBuffer = outputBuffer)
            fixed (void* __dsl_inputPropertyDetails = inputPropertyDetails)
            {
                return (HResult)GetPropertyWithInput(property, inputPropertyDetailsSize, __dsl_inputPropertyDetails, outputBufferSize, __dsl_outputBuffer);
            }
        }

        /// <inheritdoc cref = "IDXCoreAdapter.IsAttributeSupported"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, Guid*, byte> )(lpVtbl[4]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), attributeGUID) != 0;
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

        /// <inheritdoc cref = "IDXCoreAdapter.IsPropertySupported"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool IsPropertySupported(DXCoreAdapterProperty property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterProperty, byte> )(lpVtbl[5]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <inheritdoc cref = "IDXCoreAdapter.IsQueryStateSupported"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public bool IsQueryStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterState, byte> )(lpVtbl[8]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <inheritdoc cref = "IDXCoreAdapter.IsSetStateSupported"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public bool IsSetStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterState, byte> )(lpVtbl[10]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), property) != 0;
        }

        /// <inheritdoc cref = "IDXCoreAdapter.IsValid"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public bool IsValid()
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, byte> )(lpVtbl[3]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this)) != 0;
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <inheritdoc cref = "IDXCoreAdapter.QueryState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> )(lpVtbl[9]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
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
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, uint> )(lpVtbl[2]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDXCoreAdapter.SetState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter1.Native*, DXCoreAdapterState, nuint, void*, nuint, void*, HResult> )(lpVtbl[11]))((IDXCoreAdapter1.Native*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
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

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapter1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapter1(Ptr3D vtbl) => LpVtbl = (IDXCoreAdapter1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapter1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapter1(Ptr<IDXCoreAdapter1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDXCoreAdapter1.Native"/> to <see cref = "IDXCoreAdapter1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1.Native"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapter1(IDXCoreAdapter1.Native* value) => new IDXCoreAdapter1((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapter1"/> to <see cref = "IDXCoreAdapter1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapter1.Native*(IDXCoreAdapter1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDXCoreAdapter1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter1(Ptr3D value) => new IDXCoreAdapter1(value);
    /// <summary>casts <see cref = "IDXCoreAdapter1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDXCoreAdapter1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDXCoreAdapter1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter1(Ptr<IDXCoreAdapter1.Native> value) => new IDXCoreAdapter1(value);
    /// <summary>casts <see cref = "IDXCoreAdapter1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1"/> instance to be converted </param>
    public static implicit operator Ptr<IDXCoreAdapter1.Native>(IDXCoreAdapter1 value) => (Ptr<IDXCoreAdapter1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDXCoreAdapter1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDXCoreAdapter1(void*** value) => new IDXCoreAdapter1((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapter1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1"/> instance to be converted </param>
    public static implicit operator void***(IDXCoreAdapter1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDXCoreAdapter1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter1(nuint value) => new IDXCoreAdapter1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDXCoreAdapter1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter1"/> instance to be converted </param>
    public static implicit operator nuint(IDXCoreAdapter1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDXCoreAdapter.GetFactory"/>
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

    /// <inheritdoc cref = "IDXCoreAdapter.GetProperty"/>
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

    /// <inheritdoc cref = "IDXCoreAdapter.GetPropertySize"/>
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

    /// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1.GetPropertyWithInput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] void* inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer) => LpVtbl->GetPropertyWithInput(property, inputPropertyDetailsSize, inputPropertyDetails, outputBufferSize, outputBuffer);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] Ref inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, Ref outputBuffer)
    {
        fixed (void* __dsl_outputBuffer = outputBuffer)
        fixed (void* __dsl_inputPropertyDetails = inputPropertyDetails)
        {
            return (HResult)GetPropertyWithInput(property, inputPropertyDetailsSize, __dsl_inputPropertyDetails, outputBufferSize, __dsl_outputBuffer);
        }
    }

    /// <inheritdoc cref = "IDXCoreAdapter.IsAttributeSupported"/>
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

    /// <inheritdoc cref = "IDXCoreAdapter.IsPropertySupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsPropertySupported(DXCoreAdapterProperty property) => LpVtbl->IsPropertySupported(property);
    /// <inheritdoc cref = "IDXCoreAdapter.IsQueryStateSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsQueryStateSupported(DXCoreAdapterState property) => LpVtbl->IsQueryStateSupported(property);
    /// <inheritdoc cref = "IDXCoreAdapter.IsSetStateSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsSetStateSupported(DXCoreAdapterState property) => LpVtbl->IsSetStateSupported(property);
    /// <inheritdoc cref = "IDXCoreAdapter.IsValid"/>
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

    /// <inheritdoc cref = "IDXCoreAdapter.QueryState"/>
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
    /// <inheritdoc cref = "IDXCoreAdapter.SetState"/>
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
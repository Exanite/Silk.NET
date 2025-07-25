// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1"]/*'/>
[Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
[NativeTypeName("struct ID3D12DebugDevice1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugDevice1 : ID3D12DebugDevice1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugDevice1));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, void* pData, uint DataSize);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, Ref pData, uint DataSize);
        [VtblIndex(5)]
        HResult ReportLiveDeviceObjects(D3D12RldoFlags Flags);
        [VtblIndex(3)]
        HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] void* pData, uint DataSize);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] Ref pData, uint DataSize);
    }

    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1"]/*'/>
    [Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
    [NativeTypeName("struct ID3D12DebugDevice1 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugDevice1));

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
            [NativeTypeName("HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugDeviceParameterType, void*, uint, HResult> SetDebugParameter;
            [NativeTypeName("HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugDeviceParameterType, void*, uint, HResult> GetDebugParameter;
            [NativeTypeName("HRESULT (D3D12_RLDO_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12RldoFlags, HResult> ReportLiveDeviceObjects;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, uint> )(lpVtbl[1]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.GetDebugParameter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, D3D12DebugDeviceParameterType, void*, uint, HResult> )(lpVtbl[4]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, Ref pData, uint DataSize)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)GetDebugParameter(Type, __dsl_pData, DataSize);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, uint> )(lpVtbl[2]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.ReportLiveDeviceObjects"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult ReportLiveDeviceObjects(D3D12RldoFlags Flags)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, D3D12RldoFlags, HResult> )(lpVtbl[5]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this), Flags);
        }

        /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.SetDebugParameter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice1.Native*, D3D12DebugDeviceParameterType, void*, uint, HResult> )(lpVtbl[3]))((ID3D12DebugDevice1.Native*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] Ref pData, uint DataSize)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)SetDebugParameter(Type, __dsl_pData, DataSize);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugDevice1(Ptr3D vtbl) => LpVtbl = (ID3D12DebugDevice1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugDevice1(Ptr<ID3D12DebugDevice1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DebugDevice1.Native"/> to <see cref = "ID3D12DebugDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DebugDevice1(ID3D12DebugDevice1.Native* value) => new ID3D12DebugDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugDevice1"/> to <see cref = "ID3D12DebugDevice1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1"/> instance to be converted </param>
    public static implicit operator ID3D12DebugDevice1.Native*(ID3D12DebugDevice1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DebugDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DebugDevice1(Ptr3D value) => new ID3D12DebugDevice1(value);
    /// <summary>casts <see cref = "ID3D12DebugDevice1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DebugDevice1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DebugDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DebugDevice1(Ptr<ID3D12DebugDevice1.Native> value) => new ID3D12DebugDevice1(value);
    /// <summary>casts <see cref = "ID3D12DebugDevice1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DebugDevice1.Native>(ID3D12DebugDevice1 value) => (Ptr<ID3D12DebugDevice1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DebugDevice1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DebugDevice1(void*** value) => new ID3D12DebugDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugDevice1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DebugDevice1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DebugDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DebugDevice1(nuint value) => new ID3D12DebugDevice1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DebugDevice1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DebugDevice1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.GetDebugParameter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, void* pData, uint DataSize) => LpVtbl->GetDebugParameter(Type, pData, DataSize);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDebugParameter(D3D12DebugDeviceParameterType Type, Ref pData, uint DataSize)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)GetDebugParameter(Type, __dsl_pData, DataSize);
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
    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.ReportLiveDeviceObjects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult ReportLiveDeviceObjects(D3D12RldoFlags Flags) => LpVtbl->ReportLiveDeviceObjects(Flags);
    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.SetDebugParameter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] void* pData, uint DataSize) => LpVtbl->SetDebugParameter(Type, pData, DataSize);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetDebugParameter(D3D12DebugDeviceParameterType Type, [NativeTypeName("const void *")] Ref pData, uint DataSize)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)SetDebugParameter(Type, __dsl_pData, DataSize);
        }
    }
}
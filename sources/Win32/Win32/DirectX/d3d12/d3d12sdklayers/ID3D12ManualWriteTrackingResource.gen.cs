// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource"]/*'/>
[Guid("86CA3B85-49AD-4B6E-AED5-EDDB18540F41")]
[NativeTypeName("struct ID3D12ManualWriteTrackingResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ManualWriteTrackingResource : ID3D12ManualWriteTrackingResource.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ManualWriteTrackingResource));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pWrittenRange);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pWrittenRange);
    }

    /// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource"]/*'/>
    [Guid("86CA3B85-49AD-4B6E-AED5-EDDB18540F41")]
    [NativeTypeName("struct ID3D12ManualWriteTrackingResource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ManualWriteTrackingResource));

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
            [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12Range*, void> TrackWrite;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ManualWriteTrackingResource.Native*, uint> )(lpVtbl[1]))((ID3D12ManualWriteTrackingResource.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ManualWriteTrackingResource.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12ManualWriteTrackingResource.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12ManualWriteTrackingResource.Native*, uint> )(lpVtbl[2]))((ID3D12ManualWriteTrackingResource.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource.TrackWrite"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pWrittenRange)
        {
            ((delegate* unmanaged<ID3D12ManualWriteTrackingResource.Native*, uint, D3D12Range*, void> )(lpVtbl[3]))((ID3D12ManualWriteTrackingResource.Native*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pWrittenRange)
        {
            fixed (D3D12Range* __dsl_pWrittenRange = pWrittenRange)
            {
                TrackWrite(Subresource, __dsl_pWrittenRange);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ManualWriteTrackingResource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ManualWriteTrackingResource(Ptr3D vtbl) => LpVtbl = (ID3D12ManualWriteTrackingResource.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ManualWriteTrackingResource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ManualWriteTrackingResource(Ptr<ID3D12ManualWriteTrackingResource.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource.Native"/> to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ManualWriteTrackingResource(ID3D12ManualWriteTrackingResource.Native* value) => new ID3D12ManualWriteTrackingResource((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource"/> to <see cref = "ID3D12ManualWriteTrackingResource.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator ID3D12ManualWriteTrackingResource.Native*(ID3D12ManualWriteTrackingResource value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ManualWriteTrackingResource(Ptr3D value) => new ID3D12ManualWriteTrackingResource(value);
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ManualWriteTrackingResource value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ManualWriteTrackingResource(Ptr<ID3D12ManualWriteTrackingResource.Native> value) => new ID3D12ManualWriteTrackingResource(value);
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ManualWriteTrackingResource.Native>(ID3D12ManualWriteTrackingResource value) => (Ptr<ID3D12ManualWriteTrackingResource.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ManualWriteTrackingResource(void*** value) => new ID3D12ManualWriteTrackingResource((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ManualWriteTrackingResource value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ManualWriteTrackingResource(nuint value) => new ID3D12ManualWriteTrackingResource((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ManualWriteTrackingResource"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ManualWriteTrackingResource value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
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
    /// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource.TrackWrite"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pWrittenRange) => LpVtbl->TrackWrite(Subresource, pWrittenRange);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pWrittenRange)
    {
        fixed (D3D12Range* __dsl_pWrittenRange = pWrittenRange)
        {
            TrackWrite(Subresource, __dsl_pWrittenRange);
        }
    }
}
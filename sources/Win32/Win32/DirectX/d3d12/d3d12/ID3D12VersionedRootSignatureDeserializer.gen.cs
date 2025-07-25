// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer"]/*'/>
[Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
[NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VersionedRootSignatureDeserializer : ID3D12VersionedRootSignatureDeserializer.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VersionedRootSignatureDeserializer));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12VersionedRootSignatureDesc** ppDesc);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] Ref2D<D3D12VersionedRootSignatureDesc> ppDesc);
        [VtblIndex(4)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        Ptr<D3D12VersionedRootSignatureDesc> GetUnconvertedRootSignatureDesc();
        [VtblIndex(4)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        D3D12VersionedRootSignatureDesc* GetUnconvertedRootSignatureDescRaw();
    }

    /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer"]/*'/>
    [Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
    [NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VersionedRootSignatureDeserializer));

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
            [NativeTypeName("HRESULT (D3D_ROOT_SIGNATURE_VERSION, const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DRootSignatureVersion, D3D12VersionedRootSignatureDesc**, HResult> GetRootSignatureDescAtVersion;
            [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VersionedRootSignatureDesc*> GetUnconvertedRootSignatureDesc;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer.Native*, uint> )(lpVtbl[1]))((ID3D12VersionedRootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetRootSignatureDescAtVersion"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12VersionedRootSignatureDesc** ppDesc)
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer.Native*, D3DRootSignatureVersion, D3D12VersionedRootSignatureDesc**, HResult> )(lpVtbl[3]))((ID3D12VersionedRootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] Ref2D<D3D12VersionedRootSignatureDesc> ppDesc)
        {
            fixed (D3D12VersionedRootSignatureDesc** __dsl_ppDesc = ppDesc)
            {
                return (HResult)GetRootSignatureDescAtVersion(convertToVersion, __dsl_ppDesc);
            }
        }

        [VtblIndex(4)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr<D3D12VersionedRootSignatureDesc> GetUnconvertedRootSignatureDesc() => (D3D12VersionedRootSignatureDesc*)GetUnconvertedRootSignatureDescRaw();
        /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetUnconvertedRootSignatureDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        public D3D12VersionedRootSignatureDesc* GetUnconvertedRootSignatureDescRaw()
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer.Native*, D3D12VersionedRootSignatureDesc*> )(lpVtbl[4]))((ID3D12VersionedRootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VersionedRootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer.Native*, uint> )(lpVtbl[2]))((ID3D12VersionedRootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VersionedRootSignatureDeserializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VersionedRootSignatureDeserializer(Ptr3D vtbl) => LpVtbl = (ID3D12VersionedRootSignatureDeserializer.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VersionedRootSignatureDeserializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VersionedRootSignatureDeserializer(Ptr<ID3D12VersionedRootSignatureDeserializer.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer.Native"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VersionedRootSignatureDeserializer(ID3D12VersionedRootSignatureDeserializer.Native* value) => new ID3D12VersionedRootSignatureDeserializer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator ID3D12VersionedRootSignatureDeserializer.Native*(ID3D12VersionedRootSignatureDeserializer value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VersionedRootSignatureDeserializer(Ptr3D value) => new ID3D12VersionedRootSignatureDeserializer(value);
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VersionedRootSignatureDeserializer value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VersionedRootSignatureDeserializer(Ptr<ID3D12VersionedRootSignatureDeserializer.Native> value) => new ID3D12VersionedRootSignatureDeserializer(value);
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VersionedRootSignatureDeserializer.Native>(ID3D12VersionedRootSignatureDeserializer value) => (Ptr<ID3D12VersionedRootSignatureDeserializer.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VersionedRootSignatureDeserializer(void*** value) => new ID3D12VersionedRootSignatureDeserializer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VersionedRootSignatureDeserializer value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VersionedRootSignatureDeserializer(nuint value) => new ID3D12VersionedRootSignatureDeserializer((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VersionedRootSignatureDeserializer value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetRootSignatureDescAtVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12VersionedRootSignatureDesc** ppDesc) => LpVtbl->GetRootSignatureDescAtVersion(convertToVersion, ppDesc);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] Ref2D<D3D12VersionedRootSignatureDesc> ppDesc)
    {
        fixed (D3D12VersionedRootSignatureDesc** __dsl_ppDesc = ppDesc)
        {
            return (HResult)GetRootSignatureDescAtVersion(convertToVersion, __dsl_ppDesc);
        }
    }

    [VtblIndex(4)]
    [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr<D3D12VersionedRootSignatureDesc> GetUnconvertedRootSignatureDesc() => (D3D12VersionedRootSignatureDesc*)GetUnconvertedRootSignatureDescRaw();
    /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetUnconvertedRootSignatureDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
    public D3D12VersionedRootSignatureDesc* GetUnconvertedRootSignatureDescRaw() => LpVtbl->GetUnconvertedRootSignatureDescRaw();
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
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer"]/*'/>
[Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
[NativeTypeName("struct ID3D12RootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12RootSignatureDeserializer : ID3D12RootSignatureDeserializer.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12RootSignatureDeserializer));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        Ptr<D3D12RootSignatureDesc> GetRootSignatureDesc();
        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        D3D12RootSignatureDesc* GetRootSignatureDescRaw();
    }

    /// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer"]/*'/>
    [Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
    [NativeTypeName("struct ID3D12RootSignatureDeserializer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12RootSignatureDeserializer));

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
            [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12RootSignatureDesc*> GetRootSignatureDesc;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12RootSignatureDeserializer.Native*, uint> )(lpVtbl[1]))((ID3D12RootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }

        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr<D3D12RootSignatureDesc> GetRootSignatureDesc() => (D3D12RootSignatureDesc*)GetRootSignatureDescRaw();
        /// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer.GetRootSignatureDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        public D3D12RootSignatureDesc* GetRootSignatureDescRaw()
        {
            return ((delegate* unmanaged<ID3D12RootSignatureDeserializer.Native*, D3D12RootSignatureDesc*> )(lpVtbl[3]))((ID3D12RootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12RootSignatureDeserializer.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12RootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12RootSignatureDeserializer.Native*, uint> )(lpVtbl[2]))((ID3D12RootSignatureDeserializer.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12RootSignatureDeserializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12RootSignatureDeserializer(Ptr3D vtbl) => LpVtbl = (ID3D12RootSignatureDeserializer.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12RootSignatureDeserializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12RootSignatureDeserializer(Ptr<ID3D12RootSignatureDeserializer.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer.Native"/> to <see cref = "ID3D12RootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer.Native"/> instance to be converted </param>
    public static implicit operator ID3D12RootSignatureDeserializer(ID3D12RootSignatureDeserializer.Native* value) => new ID3D12RootSignatureDeserializer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer"/> to <see cref = "ID3D12RootSignatureDeserializer.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator ID3D12RootSignatureDeserializer.Native*(ID3D12RootSignatureDeserializer value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12RootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12RootSignatureDeserializer(Ptr3D value) => new ID3D12RootSignatureDeserializer(value);
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12RootSignatureDeserializer value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12RootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12RootSignatureDeserializer(Ptr<ID3D12RootSignatureDeserializer.Native> value) => new ID3D12RootSignatureDeserializer(value);
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12RootSignatureDeserializer.Native>(ID3D12RootSignatureDeserializer value) => (Ptr<ID3D12RootSignatureDeserializer.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12RootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12RootSignatureDeserializer(void*** value) => new ID3D12RootSignatureDeserializer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator void***(ID3D12RootSignatureDeserializer value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12RootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12RootSignatureDeserializer(nuint value) => new ID3D12RootSignatureDeserializer((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12RootSignatureDeserializer"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12RootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12RootSignatureDeserializer value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    [VtblIndex(3)]
    [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr<D3D12RootSignatureDesc> GetRootSignatureDesc() => (D3D12RootSignatureDesc*)GetRootSignatureDescRaw();
    /// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer.GetRootSignatureDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
    public D3D12RootSignatureDesc* GetRootSignatureDescRaw() => LpVtbl->GetRootSignatureDescRaw();
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
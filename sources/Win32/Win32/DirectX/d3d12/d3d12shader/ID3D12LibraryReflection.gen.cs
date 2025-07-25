// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection"]/*'/>
[Guid("8E349D19-54DB-4A56-9DC9-119D87BDB804")]
[NativeTypeName("struct ID3D12LibraryReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12LibraryReflection : ID3D12LibraryReflection.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12LibraryReflection));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetDesc(D3D12LibraryDesc* pDesc);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12LibraryDesc> pDesc);
        [VtblIndex(4)]
        ID3D12FunctionReflection GetFunctionByIndex(int FunctionIndex);
    }

    /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection"]/*'/>
    [Guid("8E349D19-54DB-4A56-9DC9-119D87BDB804")]
    [NativeTypeName("struct ID3D12LibraryReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12LibraryReflection));

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
            [NativeTypeName("HRESULT (D3D12_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12LibraryDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int, ID3D12FunctionReflection.Native*> GetFunctionByIndex;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12LibraryReflection.Native*, uint> )(lpVtbl[1]))((ID3D12LibraryReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDesc(D3D12LibraryDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12LibraryReflection.Native*, D3D12LibraryDesc*, HResult> )(lpVtbl[3]))((ID3D12LibraryReflection.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12LibraryDesc> pDesc)
        {
            fixed (D3D12LibraryDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetFunctionByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D12FunctionReflection GetFunctionByIndex(int FunctionIndex)
        {
            return (ID3D12FunctionReflection)((delegate* unmanaged<ID3D12LibraryReflection.Native*, int, ID3D12FunctionReflection.Native*> )(lpVtbl[4]))((ID3D12LibraryReflection.Native*)Unsafe.AsPointer(ref this), FunctionIndex);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12LibraryReflection.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12LibraryReflection.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12LibraryReflection.Native*, uint> )(lpVtbl[2]))((ID3D12LibraryReflection.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12LibraryReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12LibraryReflection(Ptr3D vtbl) => LpVtbl = (ID3D12LibraryReflection.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12LibraryReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12LibraryReflection(Ptr<ID3D12LibraryReflection.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12LibraryReflection.Native"/> to <see cref = "ID3D12LibraryReflection"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection.Native"/> instance to be converted </param>
    public static implicit operator ID3D12LibraryReflection(ID3D12LibraryReflection.Native* value) => new ID3D12LibraryReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12LibraryReflection"/> to <see cref = "ID3D12LibraryReflection.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection"/> instance to be converted </param>
    public static implicit operator ID3D12LibraryReflection.Native*(ID3D12LibraryReflection value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12LibraryReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12LibraryReflection(Ptr3D value) => new ID3D12LibraryReflection(value);
    /// <summary>casts <see cref = "ID3D12LibraryReflection"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12LibraryReflection value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12LibraryReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12LibraryReflection(Ptr<ID3D12LibraryReflection.Native> value) => new ID3D12LibraryReflection(value);
    /// <summary>casts <see cref = "ID3D12LibraryReflection"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12LibraryReflection.Native>(ID3D12LibraryReflection value) => (Ptr<ID3D12LibraryReflection.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12LibraryReflection"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12LibraryReflection(void*** value) => new ID3D12LibraryReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12LibraryReflection"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection"/> instance to be converted </param>
    public static implicit operator void***(ID3D12LibraryReflection value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12LibraryReflection"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12LibraryReflection(nuint value) => new ID3D12LibraryReflection((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12LibraryReflection"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LibraryReflection"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12LibraryReflection value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetDesc(D3D12LibraryDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12LibraryDesc> pDesc)
    {
        fixed (D3D12LibraryDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetFunctionByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D12FunctionReflection GetFunctionByIndex(int FunctionIndex) => LpVtbl->GetFunctionByIndex(FunctionIndex);
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
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools"]/*'/>
[Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
[NativeTypeName("struct ID3D12Tools : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Tools : ID3D12Tools.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Tools));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void EnableShaderInstrumentation([NativeTypeName("BOOL")] MaybeBool<int> bEnable);
        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> ShaderInstrumentationEnabled();
    }

    /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools"]/*'/>
    [Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
    [NativeTypeName("struct ID3D12Tools : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Tools));

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
            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> EnableShaderInstrumentation;
            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> ShaderInstrumentationEnabled;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Tools.Native*, uint> )(lpVtbl[1]))((ID3D12Tools.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.EnableShaderInstrumentation"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void EnableShaderInstrumentation([NativeTypeName("BOOL")] MaybeBool<int> bEnable)
        {
            ((delegate* unmanaged<ID3D12Tools.Native*, MaybeBool<int>, void> )(lpVtbl[3]))((ID3D12Tools.Native*)Unsafe.AsPointer(ref this), bEnable);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Tools.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Tools.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12Tools.Native*, uint> )(lpVtbl[2]))((ID3D12Tools.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.ShaderInstrumentationEnabled"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> ShaderInstrumentationEnabled()
        {
            return ((delegate* unmanaged<ID3D12Tools.Native*, MaybeBool<int>> )(lpVtbl[4]))((ID3D12Tools.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Tools"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Tools(Ptr3D vtbl) => LpVtbl = (ID3D12Tools.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Tools"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Tools(Ptr<ID3D12Tools.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Tools.Native"/> to <see cref = "ID3D12Tools"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Tools(ID3D12Tools.Native* value) => new ID3D12Tools((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Tools"/> to <see cref = "ID3D12Tools.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools"/> instance to be converted </param>
    public static implicit operator ID3D12Tools.Native*(ID3D12Tools value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Tools"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Tools(Ptr3D value) => new ID3D12Tools(value);
    /// <summary>casts <see cref = "ID3D12Tools"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Tools value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Tools"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Tools(Ptr<ID3D12Tools.Native> value) => new ID3D12Tools(value);
    /// <summary>casts <see cref = "ID3D12Tools"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Tools.Native>(ID3D12Tools value) => (Ptr<ID3D12Tools.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Tools"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Tools(void*** value) => new ID3D12Tools((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Tools"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Tools value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Tools"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Tools(nuint value) => new ID3D12Tools((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Tools"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Tools"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Tools value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.EnableShaderInstrumentation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableShaderInstrumentation([NativeTypeName("BOOL")] MaybeBool<int> bEnable) => LpVtbl->EnableShaderInstrumentation(bEnable);
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
    /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.ShaderInstrumentationEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> ShaderInstrumentationEnabled() => LpVtbl->ShaderInstrumentationEnabled();
}
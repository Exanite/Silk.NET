// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList"]/*'/>
[Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053F")]
[NativeTypeName("struct ID3D12DebugCommandList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandList : ID3D12DebugCommandList.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandList));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
        [VtblIndex(5)]
        D3D12DebugFeature GetFeatureMask();
        [VtblIndex(4)]
        HResult SetFeatureMask(D3D12DebugFeature Mask);
    }

    /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList"]/*'/>
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053F")]
    [NativeTypeName("struct ID3D12DebugCommandList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandList));

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
            [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, uint, MaybeBool<int>> AssertResourceState;
            [NativeTypeName("HRESULT (D3D12_DEBUG_FEATURE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugFeature, HResult> SetFeatureMask;
            [NativeTypeName("D3D12_DEBUG_FEATURE () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugFeature> GetFeatureMask;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, uint> )(lpVtbl[1]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.AssertResourceState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, ID3D12Resource.Native*, uint, uint, MaybeBool<int>> )(lpVtbl[3]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, State);
        }

        /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.GetFeatureMask"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public D3D12DebugFeature GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, D3D12DebugFeature> )(lpVtbl[5]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, uint> )(lpVtbl[2]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.SetFeatureMask"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetFeatureMask(D3D12DebugFeature Mask)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList.Native*, D3D12DebugFeature, HResult> )(lpVtbl[4]))((ID3D12DebugCommandList.Native*)Unsafe.AsPointer(ref this), Mask);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandList(Ptr3D vtbl) => LpVtbl = (ID3D12DebugCommandList.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandList(Ptr<ID3D12DebugCommandList.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DebugCommandList.Native"/> to <see cref = "ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandList(ID3D12DebugCommandList.Native* value) => new ID3D12DebugCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList"/> to <see cref = "ID3D12DebugCommandList.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandList.Native*(ID3D12DebugCommandList value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList(Ptr3D value) => new ID3D12DebugCommandList(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DebugCommandList value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList(Ptr<ID3D12DebugCommandList.Native> value) => new ID3D12DebugCommandList(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DebugCommandList.Native>(ID3D12DebugCommandList value) => (Ptr<ID3D12DebugCommandList.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList(void*** value) => new ID3D12DebugCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DebugCommandList value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList(nuint value) => new ID3D12DebugCommandList((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DebugCommandList"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DebugCommandList value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.AssertResourceState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State) => LpVtbl->AssertResourceState(pResource, Subresource, State);
    /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.GetFeatureMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D3D12DebugFeature GetFeatureMask() => LpVtbl->GetFeatureMask();
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
    /// <include file='ID3D12DebugCommandList.xml' path='doc/member[@name="ID3D12DebugCommandList.SetFeatureMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetFeatureMask(D3D12DebugFeature Mask) => LpVtbl->SetFeatureMask(Mask);
}
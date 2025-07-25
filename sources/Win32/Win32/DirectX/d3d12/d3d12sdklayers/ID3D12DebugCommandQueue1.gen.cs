// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1"]/*'/>
[Guid("16BE35A2-BFD6-49F2-BCAE-EAAE4AFF862D")]
[NativeTypeName("struct ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue")]
[NativeInheritance("ID3D12DebugCommandQueue")]
public unsafe partial struct ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandQueue1));

    public interface Interface : ID3D12DebugCommandQueue.Interface
    {
        [VtblIndex(4)]
        void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access);
        [VtblIndex(5)]
        void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout);
    }

    /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1"]/*'/>
    [Guid("16BE35A2-BFD6-49F2-BCAE-EAAE4AFF862D")]
    [NativeTypeName("struct ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue")]
    [NativeInheritance("ID3D12DebugCommandQueue")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandQueue1));

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
            [NativeTypeName("void (ID3D12Resource *, UINT, D3D12_BARRIER_ACCESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, D3D12BarrierAccess, void> AssertResourceAccess;
            [NativeTypeName("void (ID3D12Resource *, UINT, D3D12_BARRIER_LAYOUT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, D3D12BarrierLayout, void> AssertTextureLayout;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, uint> )(lpVtbl[1]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertResourceAccess"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access)
        {
            ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, ID3D12Resource.Native*, uint, D3D12BarrierAccess, void> )(lpVtbl[4]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, Access);
        }

        /// <inheritdoc cref = "ID3D12DebugCommandQueue.AssertResourceState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, ID3D12Resource.Native*, uint, uint, MaybeBool<int>> )(lpVtbl[3]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, State);
        }

        /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertTextureLayout"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout)
        {
            ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, ID3D12Resource.Native*, uint, D3D12BarrierLayout, void> )(lpVtbl[5]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, Layout);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DebugCommandQueue1.Native*, uint> )(lpVtbl[2]))((ID3D12DebugCommandQueue1.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandQueue1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandQueue1(Ptr3D vtbl) => LpVtbl = (ID3D12DebugCommandQueue1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandQueue1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandQueue1(Ptr<ID3D12DebugCommandQueue1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1.Native"/> to <see cref = "ID3D12DebugCommandQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandQueue1(ID3D12DebugCommandQueue1.Native* value) => new ID3D12DebugCommandQueue1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1"/> to <see cref = "ID3D12DebugCommandQueue1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandQueue1.Native*(ID3D12DebugCommandQueue1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DebugCommandQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue1(Ptr3D value) => new ID3D12DebugCommandQueue1(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DebugCommandQueue1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DebugCommandQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue1(Ptr<ID3D12DebugCommandQueue1.Native> value) => new ID3D12DebugCommandQueue1(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DebugCommandQueue1.Native>(ID3D12DebugCommandQueue1 value) => (Ptr<ID3D12DebugCommandQueue1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DebugCommandQueue1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue1(void*** value) => new ID3D12DebugCommandQueue1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DebugCommandQueue1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DebugCommandQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue1(nuint value) => new ID3D12DebugCommandQueue1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DebugCommandQueue1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertResourceAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access) => LpVtbl->AssertResourceAccess(pResource, Subresource, Access);
    /// <inheritdoc cref = "ID3D12DebugCommandQueue.AssertResourceState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State) => LpVtbl->AssertResourceState(pResource, Subresource, State);
    /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertTextureLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout) => LpVtbl->AssertTextureLayout(pResource, Subresource, Layout);
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
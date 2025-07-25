// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugCommandQueue.xml' path='doc/member[@name="ID3D12DebugCommandQueue"]/*'/>
[Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053A")]
[NativeTypeName("struct ID3D12DebugCommandQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandQueue : ID3D12DebugCommandQueue.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandQueue));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
    }

    /// <include file='ID3D12DebugCommandQueue.xml' path='doc/member[@name="ID3D12DebugCommandQueue"]/*'/>
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053A")]
    [NativeTypeName("struct ID3D12DebugCommandQueue : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandQueue));

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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue.Native*, uint> )(lpVtbl[1]))((ID3D12DebugCommandQueue.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugCommandQueue.xml' path='doc/member[@name="ID3D12DebugCommandQueue.AssertResourceState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue.Native*, ID3D12Resource.Native*, uint, uint, MaybeBool<int>> )(lpVtbl[3]))((ID3D12DebugCommandQueue.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, State);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandQueue.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DebugCommandQueue.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DebugCommandQueue.Native*, uint> )(lpVtbl[2]))((ID3D12DebugCommandQueue.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandQueue(Ptr3D vtbl) => LpVtbl = (ID3D12DebugCommandQueue.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandQueue(Ptr<ID3D12DebugCommandQueue.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue.Native"/> to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandQueue(ID3D12DebugCommandQueue.Native* value) => new ID3D12DebugCommandQueue((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue"/> to <see cref = "ID3D12DebugCommandQueue.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandQueue.Native*(ID3D12DebugCommandQueue value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue(Ptr3D value) => new ID3D12DebugCommandQueue(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DebugCommandQueue value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue(Ptr<ID3D12DebugCommandQueue.Native> value) => new ID3D12DebugCommandQueue(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DebugCommandQueue.Native>(ID3D12DebugCommandQueue value) => (Ptr<ID3D12DebugCommandQueue.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue(void*** value) => new ID3D12DebugCommandQueue((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DebugCommandQueue value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue(nuint value) => new ID3D12DebugCommandQueue((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DebugCommandQueue"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DebugCommandQueue value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DebugCommandQueue.xml' path='doc/member[@name="ID3D12DebugCommandQueue.AssertResourceState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State) => LpVtbl->AssertResourceState(pResource, Subresource, State);
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
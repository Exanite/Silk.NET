// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3"]/*'/>
[Guid("197D5E15-4D37-4D34-AF78-724CD70FDB1F")]
[NativeTypeName("struct ID3D12DebugCommandList3 : ID3D12DebugCommandList2")]
[NativeInheritance("ID3D12DebugCommandList2")]
public unsafe partial struct ID3D12DebugCommandList3 : ID3D12DebugCommandList3.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandList3));

    public interface Interface : ID3D12DebugCommandList2.Interface
    {
        [VtblIndex(8)]
        void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access);
        [VtblIndex(9)]
        void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout);
    }

    /// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3"]/*'/>
    [Guid("197D5E15-4D37-4D34-AF78-724CD70FDB1F")]
    [NativeTypeName("struct ID3D12DebugCommandList3 : ID3D12DebugCommandList2")]
    [NativeInheritance("ID3D12DebugCommandList2")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DebugCommandList3));

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
            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugCommandListParameterType, void*, uint, HResult> SetDebugParameter;
            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DebugCommandListParameterType, void*, uint, HResult> GetDebugParameter;
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
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, uint> )(lpVtbl[1]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3.AssertResourceAccess"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access)
        {
            ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, ID3D12Resource.Native*, uint, D3D12BarrierAccess, void> )(lpVtbl[8]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, Access);
        }

        /// <inheritdoc cref = "ID3D12DebugCommandList.AssertResourceState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, ID3D12Resource.Native*, uint, uint, MaybeBool<int>> )(lpVtbl[3]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, State);
        }

        /// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3.AssertTextureLayout"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout)
        {
            ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, ID3D12Resource.Native*, uint, D3D12BarrierLayout, void> )(lpVtbl[9]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, Layout);
        }

        /// <inheritdoc cref = "ID3D12DebugCommandList2.GetDebugParameter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDebugParameter(D3D12DebugCommandListParameterType Type, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, D3D12DebugCommandListParameterType, void*, uint, HResult> )(lpVtbl[7]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDebugParameter(D3D12DebugCommandListParameterType Type, Ref pData, uint DataSize)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)GetDebugParameter(Type, __dsl_pData, DataSize);
            }
        }

        /// <inheritdoc cref = "ID3D12DebugCommandList.GetFeatureMask"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public D3D12DebugFeature GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, D3D12DebugFeature> )(lpVtbl[5]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, uint> )(lpVtbl[2]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DebugCommandList2.SetDebugParameter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetDebugParameter(D3D12DebugCommandListParameterType Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, D3D12DebugCommandListParameterType, void*, uint, HResult> )(lpVtbl[6]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetDebugParameter(D3D12DebugCommandListParameterType Type, [NativeTypeName("const void *")] Ref pData, uint DataSize)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)SetDebugParameter(Type, __dsl_pData, DataSize);
            }
        }

        /// <inheritdoc cref = "ID3D12DebugCommandList.SetFeatureMask"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetFeatureMask(D3D12DebugFeature Mask)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList3.Native*, D3D12DebugFeature, HResult> )(lpVtbl[4]))((ID3D12DebugCommandList3.Native*)Unsafe.AsPointer(ref this), Mask);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandList3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandList3(Ptr3D vtbl) => LpVtbl = (ID3D12DebugCommandList3.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandList3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandList3(Ptr<ID3D12DebugCommandList3.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DebugCommandList3.Native"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandList3(ID3D12DebugCommandList3.Native* value) => new ID3D12DebugCommandList3((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "ID3D12DebugCommandList3.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator ID3D12DebugCommandList3.Native*(ID3D12DebugCommandList3 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(Ptr3D value) => new ID3D12DebugCommandList3(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DebugCommandList3 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(Ptr<ID3D12DebugCommandList3.Native> value) => new ID3D12DebugCommandList3(value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DebugCommandList3.Native>(ID3D12DebugCommandList3 value) => (Ptr<ID3D12DebugCommandList3.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(void*** value) => new ID3D12DebugCommandList3((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DebugCommandList3"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DebugCommandList3 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(nuint value) => new ID3D12DebugCommandList3((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DebugCommandList3 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3.AssertResourceAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void AssertResourceAccess(ID3D12Resource pResource, uint Subresource, D3D12BarrierAccess Access) => LpVtbl->AssertResourceAccess(pResource, Subresource, Access);
    /// <inheritdoc cref = "ID3D12DebugCommandList.AssertResourceState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State) => LpVtbl->AssertResourceState(pResource, Subresource, State);
    /// <include file='ID3D12DebugCommandList3.xml' path='doc/member[@name="ID3D12DebugCommandList3.AssertTextureLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void AssertTextureLayout(ID3D12Resource pResource, uint Subresource, D3D12BarrierLayout Layout) => LpVtbl->AssertTextureLayout(pResource, Subresource, Layout);
    /// <inheritdoc cref = "ID3D12DebugCommandList2.GetDebugParameter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDebugParameter(D3D12DebugCommandListParameterType Type, void* pData, uint DataSize) => LpVtbl->GetDebugParameter(Type, pData, DataSize);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDebugParameter(D3D12DebugCommandListParameterType Type, Ref pData, uint DataSize)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)GetDebugParameter(Type, __dsl_pData, DataSize);
        }
    }

    /// <inheritdoc cref = "ID3D12DebugCommandList.GetFeatureMask"/>
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
    /// <inheritdoc cref = "ID3D12DebugCommandList2.SetDebugParameter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetDebugParameter(D3D12DebugCommandListParameterType Type, [NativeTypeName("const void *")] void* pData, uint DataSize) => LpVtbl->SetDebugParameter(Type, pData, DataSize);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetDebugParameter(D3D12DebugCommandListParameterType Type, [NativeTypeName("const void *")] Ref pData, uint DataSize)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)SetDebugParameter(Type, __dsl_pData, DataSize);
        }
    }

    /// <inheritdoc cref = "ID3D12DebugCommandList.SetFeatureMask"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetFeatureMask(D3D12DebugFeature Mask) => LpVtbl->SetFeatureMask(Mask);
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract"]/*'/>
[Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
[NativeTypeName("struct ID3D12SharingContract : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SharingContract : ID3D12SharingContract.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SharingContract));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BeginCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid);
        [VtblIndex(6)]
        void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void EndCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid);
        [VtblIndex(3)]
        void Present(ID3D12Resource pResource, uint Subresource, HWND window);
        [VtblIndex(4)]
        void SharedFenceSignal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue);
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract"]/*'/>
    [Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
    [NativeTypeName("struct ID3D12SharingContract : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SharingContract));

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
            [NativeTypeName("void (ID3D12Resource *, UINT, HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, HWND, void> Present;
            [NativeTypeName("void (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Fence.Native*, ulong, void> SharedFenceSignal;
            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void> BeginCapturableWork;
            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void> EndCapturableWork;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SharingContract.Native*, uint> )(lpVtbl[1]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.BeginCapturableWork"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* unmanaged<ID3D12SharingContract.Native*, Guid*, void> )(lpVtbl[5]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this), guid);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BeginCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid)
        {
            fixed (Guid* __dsl_guid = guid)
            {
                BeginCapturableWork(__dsl_guid);
            }
        }

        /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.EndCapturableWork"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* unmanaged<ID3D12SharingContract.Native*, Guid*, void> )(lpVtbl[6]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this), guid);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void EndCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid)
        {
            fixed (Guid* __dsl_guid = guid)
            {
                EndCapturableWork(__dsl_guid);
            }
        }

        /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.Present"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Present(ID3D12Resource pResource, uint Subresource, HWND window)
        {
            ((delegate* unmanaged<ID3D12SharingContract.Native*, ID3D12Resource.Native*, uint, HWND, void> )(lpVtbl[3]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, window);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SharingContract.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12SharingContract.Native*, uint> )(lpVtbl[2]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.SharedFenceSignal"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SharedFenceSignal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue)
        {
            ((delegate* unmanaged<ID3D12SharingContract.Native*, ID3D12Fence.Native*, ulong, void> )(lpVtbl[4]))((ID3D12SharingContract.Native*)Unsafe.AsPointer(ref this), pFence.LpVtbl, FenceValue);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SharingContract"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SharingContract(Ptr3D vtbl) => LpVtbl = (ID3D12SharingContract.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12SharingContract"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SharingContract(Ptr<ID3D12SharingContract.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12SharingContract.Native"/> to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract.Native"/> instance to be converted </param>
    public static implicit operator ID3D12SharingContract(ID3D12SharingContract.Native* value) => new ID3D12SharingContract((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SharingContract"/> to <see cref = "ID3D12SharingContract.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator ID3D12SharingContract.Native*(ID3D12SharingContract value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12SharingContract(Ptr3D value) => new ID3D12SharingContract(value);
    /// <summary>casts <see cref = "ID3D12SharingContract"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12SharingContract value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12SharingContract(Ptr<ID3D12SharingContract.Native> value) => new ID3D12SharingContract(value);
    /// <summary>casts <see cref = "ID3D12SharingContract"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12SharingContract.Native>(ID3D12SharingContract value) => (Ptr<ID3D12SharingContract.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12SharingContract(void*** value) => new ID3D12SharingContract((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SharingContract"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator void***(ID3D12SharingContract value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12SharingContract(nuint value) => new ID3D12SharingContract((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12SharingContract"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12SharingContract value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.BeginCapturableWork"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid) => LpVtbl->BeginCapturableWork(guid);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BeginCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid)
    {
        fixed (Guid* __dsl_guid = guid)
        {
            BeginCapturableWork(__dsl_guid);
        }
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.EndCapturableWork"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid) => LpVtbl->EndCapturableWork(guid);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void EndCapturableWork([NativeTypeName("const GUID &")] Ref<Guid> guid)
    {
        fixed (Guid* __dsl_guid = guid)
        {
            EndCapturableWork(__dsl_guid);
        }
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.Present"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Present(ID3D12Resource pResource, uint Subresource, HWND window) => LpVtbl->Present(pResource, Subresource, window);
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
    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.SharedFenceSignal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SharedFenceSignal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue) => LpVtbl->SharedFenceSignal(pFence, FenceValue);
}
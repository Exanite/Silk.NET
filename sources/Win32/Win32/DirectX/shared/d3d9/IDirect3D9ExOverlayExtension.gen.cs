// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension"]/*'/>
[Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
[NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3D9ExOverlayExtension : IDirect3D9ExOverlayExtension.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3D9ExOverlayExtension));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, D3Ddisplaymodeex* pDisplayMode, D3Ddisplayrotation DisplayRotation, D3Doverlaycaps* pOverlayCaps);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, Ref<D3Ddisplaymodeex> pDisplayMode, D3Ddisplayrotation DisplayRotation, Ref<D3Doverlaycaps> pOverlayCaps);
    }

    /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension"]/*'/>
    [Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
    [NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3D9ExOverlayExtension));

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
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, UINT, UINT, D3DFORMAT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION, D3DOVERLAYCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, uint, uint, D3Dformat, D3Ddisplaymodeex*, D3Ddisplayrotation, D3Doverlaycaps*, HResult> CheckDeviceOverlayType;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension.Native*, uint> )(lpVtbl[1]))((IDirect3D9ExOverlayExtension.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension.CheckDeviceOverlayType"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, D3Ddisplaymodeex* pDisplayMode, D3Ddisplayrotation DisplayRotation, D3Doverlaycaps* pOverlayCaps)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension.Native*, uint, D3Ddevtype, uint, uint, D3Dformat, D3Ddisplaymodeex*, D3Ddisplayrotation, D3Doverlaycaps*, HResult> )(lpVtbl[3]))((IDirect3D9ExOverlayExtension.Native*)Unsafe.AsPointer(ref this), Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, Ref<D3Ddisplaymodeex> pDisplayMode, D3Ddisplayrotation DisplayRotation, Ref<D3Doverlaycaps> pOverlayCaps)
        {
            fixed (D3Doverlaycaps* __dsl_pOverlayCaps = pOverlayCaps)
            fixed (D3Ddisplaymodeex* __dsl_pDisplayMode = pDisplayMode)
            {
                return (HResult)CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, __dsl_pDisplayMode, DisplayRotation, __dsl_pOverlayCaps);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3D9ExOverlayExtension.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension.Native*, uint> )(lpVtbl[2]))((IDirect3D9ExOverlayExtension.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9ExOverlayExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9ExOverlayExtension(Ptr3D vtbl) => LpVtbl = (IDirect3D9ExOverlayExtension.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9ExOverlayExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9ExOverlayExtension(Ptr<IDirect3D9ExOverlayExtension.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension.Native"/> to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension.Native"/> instance to be converted </param>
    public static implicit operator IDirect3D9ExOverlayExtension(IDirect3D9ExOverlayExtension.Native* value) => new IDirect3D9ExOverlayExtension((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension"/> to <see cref = "IDirect3D9ExOverlayExtension.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator IDirect3D9ExOverlayExtension.Native*(IDirect3D9ExOverlayExtension value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3D9ExOverlayExtension(Ptr3D value) => new IDirect3D9ExOverlayExtension(value);
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3D9ExOverlayExtension value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3D9ExOverlayExtension(Ptr<IDirect3D9ExOverlayExtension.Native> value) => new IDirect3D9ExOverlayExtension(value);
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3D9ExOverlayExtension.Native>(IDirect3D9ExOverlayExtension value) => (Ptr<IDirect3D9ExOverlayExtension.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3D9ExOverlayExtension(void*** value) => new IDirect3D9ExOverlayExtension((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator void***(IDirect3D9ExOverlayExtension value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3D9ExOverlayExtension(nuint value) => new IDirect3D9ExOverlayExtension((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3D9ExOverlayExtension"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3D9ExOverlayExtension value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension.CheckDeviceOverlayType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, D3Ddisplaymodeex* pDisplayMode, D3Ddisplayrotation DisplayRotation, D3Doverlaycaps* pOverlayCaps) => LpVtbl->CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckDeviceOverlayType(uint Adapter, D3Ddevtype DevType, uint OverlayWidth, uint OverlayHeight, D3Dformat OverlayFormat, Ref<D3Ddisplaymodeex> pDisplayMode, D3Ddisplayrotation DisplayRotation, Ref<D3Doverlaycaps> pOverlayCaps)
    {
        fixed (D3Doverlaycaps* __dsl_pOverlayCaps = pOverlayCaps)
        fixed (D3Ddisplaymodeex* __dsl_pDisplayMode = pDisplayMode)
        {
            return (HResult)CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, __dsl_pDisplayMode, DisplayRotation, __dsl_pOverlayCaps);
        }
    }

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
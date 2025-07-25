// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl"]/*'/>
[Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
[NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IdxgiDisplayControl : IdxgiDisplayControl.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDisplayControl));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> IsStereoEnabled();

        [VtblIndex(4)]
        void SetStereoEnabled([NativeTypeName("BOOL")] MaybeBool<int> enabled);
    }

    /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl"]/*'/>

    [Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
    [NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDisplayControl));
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

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> IsStereoEnabled;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> SetStereoEnabled;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiDisplayControl.Native*, uint>)(lpVtbl[1]))(
                (IdxgiDisplayControl.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.IsStereoEnabled"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsStereoEnabled()
        {
            return ((delegate* unmanaged<IdxgiDisplayControl.Native*, MaybeBool<int>>)(lpVtbl[3]))(
                (IdxgiDisplayControl.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiDisplayControl.Native*, Guid*, void**, HResult>)(
                    lpVtbl[0]
                )
            )((IdxgiDisplayControl.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
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
            return ((delegate* unmanaged<IdxgiDisplayControl.Native*, uint>)(lpVtbl[2]))(
                (IdxgiDisplayControl.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.SetStereoEnabled"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetStereoEnabled([NativeTypeName("BOOL")] MaybeBool<int> enabled)
        {
            ((delegate* unmanaged<IdxgiDisplayControl.Native*, MaybeBool<int>, void>)(lpVtbl[4]))(
                (IdxgiDisplayControl.Native*)Unsafe.AsPointer(ref this),
                enabled
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDisplayControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDisplayControl(Ptr3D vtbl) => LpVtbl = (IdxgiDisplayControl.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDisplayControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDisplayControl(Ptr<IdxgiDisplayControl.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiDisplayControl.Native"/> to <see cref = "IdxgiDisplayControl"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl.Native"/> instance to be converted </param>

    public static implicit operator IdxgiDisplayControl(IdxgiDisplayControl.Native* value) =>
        new IdxgiDisplayControl((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDisplayControl"/> to <see cref = "IdxgiDisplayControl.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl"/> instance to be converted </param>

    public static implicit operator IdxgiDisplayControl.Native*(IdxgiDisplayControl value) =>
        value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiDisplayControl"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiDisplayControl(Ptr3D value) =>
        new IdxgiDisplayControl(value);

    /// <summary>casts <see cref = "IdxgiDisplayControl"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiDisplayControl value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiDisplayControl"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiDisplayControl(Ptr<IdxgiDisplayControl.Native> value) =>
        new IdxgiDisplayControl(value);

    /// <summary>casts <see cref = "IdxgiDisplayControl"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiDisplayControl.Native>(IdxgiDisplayControl value) =>
        (Ptr<IdxgiDisplayControl.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiDisplayControl"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiDisplayControl(void*** value) =>
        new IdxgiDisplayControl((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDisplayControl"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl"/> instance to be converted </param>

    public static implicit operator void***(IdxgiDisplayControl value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiDisplayControl"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiDisplayControl(nuint value) =>
        new IdxgiDisplayControl((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiDisplayControl"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDisplayControl"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiDisplayControl value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.IsStereoEnabled"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsStereoEnabled() => LpVtbl->IsStereoEnabled();

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

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

    /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.SetStereoEnabled"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetStereoEnabled([NativeTypeName("BOOL")] MaybeBool<int> enabled) =>
        LpVtbl->SetStereoEnabled(enabled);
}

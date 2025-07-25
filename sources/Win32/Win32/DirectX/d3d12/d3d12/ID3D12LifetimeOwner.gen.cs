// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner"]/*'/>
[Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
[NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12LifetimeOwner : ID3D12LifetimeOwner.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12LifetimeOwner));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void LifetimeStateUpdated(D3D12LifetimeState NewState);
    }

    /// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner"]/*'/>
    [Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
    [NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12LifetimeOwner));

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
            [NativeTypeName("void (D3D12_LIFETIME_STATE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12LifetimeState, void> LifetimeStateUpdated;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12LifetimeOwner.Native*, uint> )(lpVtbl[1]))((ID3D12LifetimeOwner.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner.LifetimeStateUpdated"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void LifetimeStateUpdated(D3D12LifetimeState NewState)
        {
            ((delegate* unmanaged<ID3D12LifetimeOwner.Native*, D3D12LifetimeState, void> )(lpVtbl[3]))((ID3D12LifetimeOwner.Native*)Unsafe.AsPointer(ref this), NewState);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12LifetimeOwner.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12LifetimeOwner.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12LifetimeOwner.Native*, uint> )(lpVtbl[2]))((ID3D12LifetimeOwner.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12LifetimeOwner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12LifetimeOwner(Ptr3D vtbl) => LpVtbl = (ID3D12LifetimeOwner.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12LifetimeOwner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12LifetimeOwner(Ptr<ID3D12LifetimeOwner.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12LifetimeOwner.Native"/> to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner.Native"/> instance to be converted </param>
    public static implicit operator ID3D12LifetimeOwner(ID3D12LifetimeOwner.Native* value) => new ID3D12LifetimeOwner((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12LifetimeOwner"/> to <see cref = "ID3D12LifetimeOwner.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator ID3D12LifetimeOwner.Native*(ID3D12LifetimeOwner value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12LifetimeOwner(Ptr3D value) => new ID3D12LifetimeOwner(value);
    /// <summary>casts <see cref = "ID3D12LifetimeOwner"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12LifetimeOwner value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12LifetimeOwner(Ptr<ID3D12LifetimeOwner.Native> value) => new ID3D12LifetimeOwner(value);
    /// <summary>casts <see cref = "ID3D12LifetimeOwner"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12LifetimeOwner.Native>(ID3D12LifetimeOwner value) => (Ptr<ID3D12LifetimeOwner.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12LifetimeOwner(void*** value) => new ID3D12LifetimeOwner((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12LifetimeOwner"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator void***(ID3D12LifetimeOwner value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12LifetimeOwner(nuint value) => new ID3D12LifetimeOwner((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12LifetimeOwner"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12LifetimeOwner value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner.LifetimeStateUpdated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void LifetimeStateUpdated(D3D12LifetimeState NewState) => LpVtbl->LifetimeStateUpdated(NewState);
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
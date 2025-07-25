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
/// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings"]/*'/>
[Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings : ID3D12DeviceRemovedExtendedDataSettings.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceRemovedExtendedDataSettings));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetAutoBreadcrumbsEnablement(D3D12DredEnablement Enablement);
        [VtblIndex(4)]
        void SetPageFaultEnablement(D3D12DredEnablement Enablement);
        [VtblIndex(5)]
        void SetWatsonDumpEnablement(D3D12DredEnablement Enablement);
    }

    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings"]/*'/>
    [Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.18362.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceRemovedExtendedDataSettings));

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
            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredEnablement, void> SetAutoBreadcrumbsEnablement;
            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredEnablement, void> SetPageFaultEnablement;
            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredEnablement, void> SetWatsonDumpEnablement;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, uint> )(lpVtbl[1]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, uint> )(lpVtbl[2]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetAutoBreadcrumbsEnablement"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetAutoBreadcrumbsEnablement(D3D12DredEnablement Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, D3D12DredEnablement, void> )(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this), Enablement);
        }

        /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetPageFaultEnablement"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetPageFaultEnablement(D3D12DredEnablement Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, D3D12DredEnablement, void> )(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this), Enablement);
        }

        /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetWatsonDumpEnablement"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetWatsonDumpEnablement(D3D12DredEnablement Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings.Native*, D3D12DredEnablement, void> )(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings.Native*)Unsafe.AsPointer(ref this), Enablement);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedDataSettings(Ptr3D vtbl) => LpVtbl = (ID3D12DeviceRemovedExtendedDataSettings.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedDataSettings(Ptr<ID3D12DeviceRemovedExtendedDataSettings.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings.Native"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceRemovedExtendedDataSettings(ID3D12DeviceRemovedExtendedDataSettings.Native* value) => new ID3D12DeviceRemovedExtendedDataSettings((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceRemovedExtendedDataSettings.Native*(ID3D12DeviceRemovedExtendedDataSettings value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings(Ptr3D value) => new ID3D12DeviceRemovedExtendedDataSettings(value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DeviceRemovedExtendedDataSettings value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings(Ptr<ID3D12DeviceRemovedExtendedDataSettings.Native> value) => new ID3D12DeviceRemovedExtendedDataSettings(value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DeviceRemovedExtendedDataSettings.Native>(ID3D12DeviceRemovedExtendedDataSettings value) => (Ptr<ID3D12DeviceRemovedExtendedDataSettings.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings(void*** value) => new ID3D12DeviceRemovedExtendedDataSettings((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DeviceRemovedExtendedDataSettings value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings(nuint value) => new ID3D12DeviceRemovedExtendedDataSettings((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DeviceRemovedExtendedDataSettings value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
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
    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetAutoBreadcrumbsEnablement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetAutoBreadcrumbsEnablement(D3D12DredEnablement Enablement) => LpVtbl->SetAutoBreadcrumbsEnablement(Enablement);
    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetPageFaultEnablement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetPageFaultEnablement(D3D12DredEnablement Enablement) => LpVtbl->SetPageFaultEnablement(Enablement);
    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetWatsonDumpEnablement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetWatsonDumpEnablement(D3D12DredEnablement Enablement) => LpVtbl->SetWatsonDumpEnablement(Enablement);
}
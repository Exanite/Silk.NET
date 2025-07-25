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
/// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration"]/*'/>
[Guid("E9EB5314-33AA-42B2-A718-D77F58B1F1C7")]
[NativeTypeName("struct ID3D12SDKConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12SDKConfiguration : ID3D12SDKConfiguration.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SDKConfiguration));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath);
    }

    /// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration"]/*'/>
    [Guid("E9EB5314-33AA-42B2-A718-D77F58B1F1C7")]
    [NativeTypeName("struct ID3D12SDKConfiguration : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SDKConfiguration));

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
            [NativeTypeName("HRESULT (UINT, LPCSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, sbyte*, HResult> SetSDKVersion;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration.Native*, uint> )(lpVtbl[1]))((ID3D12SDKConfiguration.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12SDKConfiguration.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12SDKConfiguration.Native*, uint> )(lpVtbl[2]))((ID3D12SDKConfiguration.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration.SetSDKVersion"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration.Native*, uint, sbyte*, HResult> )(lpVtbl[3]))((ID3D12SDKConfiguration.Native*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath)
        {
            fixed (sbyte* __dsl_SDKPath = SDKPath)
            {
                return (HResult)SetSDKVersion(SDKVersion, __dsl_SDKPath);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SDKConfiguration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SDKConfiguration(Ptr3D vtbl) => LpVtbl = (ID3D12SDKConfiguration.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12SDKConfiguration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SDKConfiguration(Ptr<ID3D12SDKConfiguration.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12SDKConfiguration.Native"/> to <see cref = "ID3D12SDKConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration.Native"/> instance to be converted </param>
    public static implicit operator ID3D12SDKConfiguration(ID3D12SDKConfiguration.Native* value) => new ID3D12SDKConfiguration((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration"/> to <see cref = "ID3D12SDKConfiguration.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration"/> instance to be converted </param>
    public static implicit operator ID3D12SDKConfiguration.Native*(ID3D12SDKConfiguration value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12SDKConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration(Ptr3D value) => new ID3D12SDKConfiguration(value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12SDKConfiguration value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12SDKConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration(Ptr<ID3D12SDKConfiguration.Native> value) => new ID3D12SDKConfiguration(value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12SDKConfiguration.Native>(ID3D12SDKConfiguration value) => (Ptr<ID3D12SDKConfiguration.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12SDKConfiguration"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration(void*** value) => new ID3D12SDKConfiguration((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration"/> instance to be converted </param>
    public static implicit operator void***(ID3D12SDKConfiguration value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12SDKConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration(nuint value) => new ID3D12SDKConfiguration((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12SDKConfiguration"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12SDKConfiguration value) => (nuint)value.LpVtbl;
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
    /// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration.SetSDKVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath) => LpVtbl->SetSDKVersion(SDKVersion, SDKPath);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath)
    {
        fixed (sbyte* __dsl_SDKPath = SDKPath)
        {
            return (HResult)SetSDKVersion(SDKVersion, __dsl_SDKPath);
        }
    }
}
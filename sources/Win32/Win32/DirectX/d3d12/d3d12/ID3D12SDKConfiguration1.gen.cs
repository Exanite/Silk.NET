// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1"]/*'/>
[Guid("8AAF9303-AD25-48B9-9A57-D9C37E009D9F")]
[NativeTypeName("struct ID3D12SDKConfiguration1 : ID3D12SDKConfiguration")]
[NativeInheritance("ID3D12SDKConfiguration")]
public unsafe partial struct ID3D12SDKConfiguration1 : ID3D12SDKConfiguration1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SDKConfiguration1));

    public interface Interface : ID3D12SDKConfiguration.Interface
    {
        [VtblIndex(4)]
        HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath, [NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory);
        [VtblIndex(5)]
        void FreeUnusedSDKs();
    }

    /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1"]/*'/>
    [Guid("8AAF9303-AD25-48B9-9A57-D9C37E009D9F")]
    [NativeTypeName("struct ID3D12SDKConfiguration1 : ID3D12SDKConfiguration")]
    [NativeInheritance("ID3D12SDKConfiguration")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SDKConfiguration1));

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
            [NativeTypeName("HRESULT (UINT, LPCSTR, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, sbyte*, Guid*, void**, HResult> CreateDeviceFactory;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> FreeUnusedSDKs;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, uint> )(lpVtbl[1]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.CreateDeviceFactory"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath, [NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, uint, sbyte*, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath, riid, ppvFactory);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
        {
            fixed (void** __dsl_ppvFactory = ppvFactory)
            fixed (Guid* __dsl_riid = riid)
            fixed (sbyte* __dsl_SDKPath = SDKPath)
            {
                return (HResult)CreateDeviceFactory(SDKVersion, __dsl_SDKPath, __dsl_riid, __dsl_ppvFactory);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDeviceFactory<TCom>(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath, out TCom ppvFactory)
            where TCom : unmanaged, IComVtbl
        {
            fixed (sbyte* __dsl_SDKPath = SDKPath)
            {
                ppvFactory = default;
                return CreateDeviceFactory(SDKVersion, __dsl_SDKPath, TCom.NativeGuid, ppvFactory.GetAddressOf());
            }
        }

        /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.FreeUnusedSDKs"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void FreeUnusedSDKs()
        {
            ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, void> )(lpVtbl[5]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, uint> )(lpVtbl[2]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12SDKConfiguration.SetSDKVersion"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration1.Native*, uint, sbyte*, HResult> )(lpVtbl[3]))((ID3D12SDKConfiguration1.Native*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
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

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SDKConfiguration1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SDKConfiguration1(Ptr3D vtbl) => LpVtbl = (ID3D12SDKConfiguration1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12SDKConfiguration1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SDKConfiguration1(Ptr<ID3D12SDKConfiguration1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1.Native"/> to <see cref = "ID3D12SDKConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12SDKConfiguration1(ID3D12SDKConfiguration1.Native* value) => new ID3D12SDKConfiguration1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1"/> to <see cref = "ID3D12SDKConfiguration1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1"/> instance to be converted </param>
    public static implicit operator ID3D12SDKConfiguration1.Native*(ID3D12SDKConfiguration1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12SDKConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration1(Ptr3D value) => new ID3D12SDKConfiguration1(value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12SDKConfiguration1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12SDKConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration1(Ptr<ID3D12SDKConfiguration1.Native> value) => new ID3D12SDKConfiguration1(value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12SDKConfiguration1.Native>(ID3D12SDKConfiguration1 value) => (Ptr<ID3D12SDKConfiguration1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12SDKConfiguration1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration1(void*** value) => new ID3D12SDKConfiguration1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12SDKConfiguration1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12SDKConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12SDKConfiguration1(nuint value) => new ID3D12SDKConfiguration1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12SDKConfiguration1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SDKConfiguration1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12SDKConfiguration1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.CreateDeviceFactory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath, [NativeTypeName("const IID &")] Guid* riid, void** ppvFactory) => LpVtbl->CreateDeviceFactory(SDKVersion, SDKPath, riid, ppvFactory);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
    {
        fixed (void** __dsl_ppvFactory = ppvFactory)
        fixed (Guid* __dsl_riid = riid)
        fixed (sbyte* __dsl_SDKPath = SDKPath)
        {
            return (HResult)CreateDeviceFactory(SDKVersion, __dsl_SDKPath, __dsl_riid, __dsl_ppvFactory);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDeviceFactory<TCom>(uint SDKVersion, [NativeTypeName("LPCSTR")] Ref<sbyte> SDKPath, out TCom ppvFactory)
        where TCom : unmanaged, IComVtbl
    {
        fixed (sbyte* __dsl_SDKPath = SDKPath)
        {
            ppvFactory = default;
            return CreateDeviceFactory(SDKVersion, __dsl_SDKPath, TCom.NativeGuid, ppvFactory.GetAddressOf());
        }
    }

    /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.FreeUnusedSDKs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void FreeUnusedSDKs() => LpVtbl->FreeUnusedSDKs();
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
    /// <inheritdoc cref = "ID3D12SDKConfiguration.SetSDKVersion"/>
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
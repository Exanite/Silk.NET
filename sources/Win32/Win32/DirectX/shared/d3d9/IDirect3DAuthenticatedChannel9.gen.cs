// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9"]/*'/>
[Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
[NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DAuthenticatedChannel9 : IDirect3DAuthenticatedChannel9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DAuthenticatedChannel9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(7)]
        HResult Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DauthenticatedchannelConfigureOutput* pOutput);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Configure(uint InputSize, [NativeTypeName("const void *")] Ref pInput, Ref<D3DauthenticatedchannelConfigureOutput> pOutput);
        [VtblIndex(4)]
        HResult GetCertificate(uint CertifacteSize, byte* ppCertificate);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetCertificate(uint CertifacteSize, Ref<byte> ppCertificate);
        [VtblIndex(3)]
        HResult GetCertificateSize(uint* pCertificateSize);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetCertificateSize(Ref<uint> pCertificateSize);
        [VtblIndex(5)]
        HResult NegotiateKeyExchange(uint DataSize, void* pData);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult NegotiateKeyExchange(uint DataSize, Ref pData);
        [VtblIndex(6)]
        HResult Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Query(uint InputSize, [NativeTypeName("const void *")] Ref pInput, uint OutputSize, Ref pOutput);
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9"]/*'/>
    [Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
    [NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DAuthenticatedChannel9));

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
            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetCertificateSize;
            [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, byte*, HResult> GetCertificate;
            [NativeTypeName("HRESULT (UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, HResult> NegotiateKeyExchange;
            [NativeTypeName("HRESULT (UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, uint, void*, HResult> Query;
            [NativeTypeName("HRESULT (UINT, const void *, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, D3DauthenticatedchannelConfigureOutput*, HResult> Configure;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint> )(lpVtbl[1]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Configure"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DauthenticatedchannelConfigureOutput* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint, void*, D3DauthenticatedchannelConfigureOutput*, HResult> )(lpVtbl[7]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), InputSize, pInput, pOutput);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Configure(uint InputSize, [NativeTypeName("const void *")] Ref pInput, Ref<D3DauthenticatedchannelConfigureOutput> pOutput)
        {
            fixed (D3DauthenticatedchannelConfigureOutput* __dsl_pOutput = pOutput)
            fixed (void* __dsl_pInput = pInput)
            {
                return (HResult)Configure(InputSize, __dsl_pInput, __dsl_pOutput);
            }
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificate"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint, byte*, HResult> )(lpVtbl[4]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCertificate(uint CertifacteSize, Ref<byte> ppCertificate)
        {
            fixed (byte* __dsl_ppCertificate = ppCertificate)
            {
                return (HResult)GetCertificate(CertifacteSize, __dsl_ppCertificate);
            }
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificateSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint*, HResult> )(lpVtbl[3]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCertificateSize(Ref<uint> pCertificateSize)
        {
            fixed (uint* __dsl_pCertificateSize = pCertificateSize)
            {
                return (HResult)GetCertificateSize(__dsl_pCertificateSize);
            }
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.NegotiateKeyExchange"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult NegotiateKeyExchange(uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint, void*, HResult> )(lpVtbl[5]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), DataSize, pData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult NegotiateKeyExchange(uint DataSize, Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)NegotiateKeyExchange(DataSize, __dsl_pData);
            }
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Query"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint, void*, uint, void*, HResult> )(lpVtbl[6]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), InputSize, pInput, OutputSize, pOutput);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Query(uint InputSize, [NativeTypeName("const void *")] Ref pInput, uint OutputSize, Ref pOutput)
        {
            fixed (void* __dsl_pOutput = pOutput)
            fixed (void* __dsl_pInput = pInput)
            {
                return (HResult)Query(InputSize, __dsl_pInput, OutputSize, __dsl_pOutput);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9.Native*, uint> )(lpVtbl[2]))((IDirect3DAuthenticatedChannel9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DAuthenticatedChannel9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DAuthenticatedChannel9(Ptr3D vtbl) => LpVtbl = (IDirect3DAuthenticatedChannel9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DAuthenticatedChannel9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DAuthenticatedChannel9(Ptr<IDirect3DAuthenticatedChannel9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9.Native"/> to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DAuthenticatedChannel9(IDirect3DAuthenticatedChannel9.Native* value) => new IDirect3DAuthenticatedChannel9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9"/> to <see cref = "IDirect3DAuthenticatedChannel9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator IDirect3DAuthenticatedChannel9.Native*(IDirect3DAuthenticatedChannel9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DAuthenticatedChannel9(Ptr3D value) => new IDirect3DAuthenticatedChannel9(value);
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DAuthenticatedChannel9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DAuthenticatedChannel9(Ptr<IDirect3DAuthenticatedChannel9.Native> value) => new IDirect3DAuthenticatedChannel9(value);
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DAuthenticatedChannel9.Native>(IDirect3DAuthenticatedChannel9 value) => (Ptr<IDirect3DAuthenticatedChannel9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DAuthenticatedChannel9(void*** value) => new IDirect3DAuthenticatedChannel9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DAuthenticatedChannel9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DAuthenticatedChannel9(nuint value) => new IDirect3DAuthenticatedChannel9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DAuthenticatedChannel9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DAuthenticatedChannel9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Configure"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DauthenticatedchannelConfigureOutput* pOutput) => LpVtbl->Configure(InputSize, pInput, pOutput);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Configure(uint InputSize, [NativeTypeName("const void *")] Ref pInput, Ref<D3DauthenticatedchannelConfigureOutput> pOutput)
    {
        fixed (D3DauthenticatedchannelConfigureOutput* __dsl_pOutput = pOutput)
        fixed (void* __dsl_pInput = pInput)
        {
            return (HResult)Configure(InputSize, __dsl_pInput, __dsl_pOutput);
        }
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetCertificate(uint CertifacteSize, byte* ppCertificate) => LpVtbl->GetCertificate(CertifacteSize, ppCertificate);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCertificate(uint CertifacteSize, Ref<byte> ppCertificate)
    {
        fixed (byte* __dsl_ppCertificate = ppCertificate)
        {
            return (HResult)GetCertificate(CertifacteSize, __dsl_ppCertificate);
        }
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificateSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetCertificateSize(uint* pCertificateSize) => LpVtbl->GetCertificateSize(pCertificateSize);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCertificateSize(Ref<uint> pCertificateSize)
    {
        fixed (uint* __dsl_pCertificateSize = pCertificateSize)
        {
            return (HResult)GetCertificateSize(__dsl_pCertificateSize);
        }
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.NegotiateKeyExchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult NegotiateKeyExchange(uint DataSize, void* pData) => LpVtbl->NegotiateKeyExchange(DataSize, pData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult NegotiateKeyExchange(uint DataSize, Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)NegotiateKeyExchange(DataSize, __dsl_pData);
        }
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Query"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput) => LpVtbl->Query(InputSize, pInput, OutputSize, pOutput);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Query(uint InputSize, [NativeTypeName("const void *")] Ref pInput, uint OutputSize, Ref pOutput)
    {
        fixed (void* __dsl_pOutput = pOutput)
        fixed (void* __dsl_pInput = pInput)
        {
            return (HResult)Query(InputSize, __dsl_pInput, OutputSize, __dsl_pOutput);
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
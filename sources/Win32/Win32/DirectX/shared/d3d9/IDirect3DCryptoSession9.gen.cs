// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9"]/*'/>
[Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
[NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DCryptoSession9 : IDirect3DCryptoSession9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DCryptoSession9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(7)]
        HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, D3DencryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, Ref<D3DencryptedBlockInfo> pEncryptedBlockInfo, Ref pContentKey, Ref pIV);
        [VtblIndex(6)]
        HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, Ref pIV);
        [VtblIndex(10)]
        HResult FinishSessionKeyRefresh();
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
        [VtblIndex(11)]
        HResult GetEncryptionBltKey(void* pReadbackKey, uint KeySize);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetEncryptionBltKey(Ref pReadbackKey, uint KeySize);
        [VtblIndex(8)]
        HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, Ref<uint> pSurfacePitch);
        [VtblIndex(5)]
        HResult NegotiateKeyExchange(uint DataSize, void* pData);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult NegotiateKeyExchange(uint DataSize, Ref pData);
        [VtblIndex(9)]
        HResult StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult StartSessionKeyRefresh(Ref pRandomNumber, uint RandomNumberSize);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9"]/*'/>
    [Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
    [NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DCryptoSession9));

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
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, uint, void*, HResult> EncryptionBlt;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, D3DENCRYPTED_BLOCK_INFO *, void *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, uint, D3DencryptedBlockInfo*, void*, void*, HResult> DecryptionBlt;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, uint*, HResult> GetSurfacePitch;
            [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, HResult> StartSessionKeyRefresh;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> FinishSessionKeyRefresh;
            [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, HResult> GetEncryptionBltKey;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, uint> )(lpVtbl[1]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.DecryptionBlt"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, D3DencryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, uint, D3DencryptedBlockInfo*, void*, void*, HResult> )(lpVtbl[7]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pSrcSurface.LpVtbl, pDstSurface.LpVtbl, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, Ref<D3DencryptedBlockInfo> pEncryptedBlockInfo, Ref pContentKey, Ref pIV)
        {
            fixed (void* __dsl_pIV = pIV)
            fixed (void* __dsl_pContentKey = pContentKey)
            fixed (D3DencryptedBlockInfo* __dsl_pEncryptedBlockInfo = pEncryptedBlockInfo)
            {
                return (HResult)DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, __dsl_pEncryptedBlockInfo, __dsl_pContentKey, __dsl_pIV);
            }
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.EncryptionBlt"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, uint, void*, HResult> )(lpVtbl[6]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pSrcSurface.LpVtbl, pDstSurface.LpVtbl, DstSurfaceSize, pIV);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, Ref pIV)
        {
            fixed (void* __dsl_pIV = pIV)
            {
                return (HResult)EncryptionBlt(pSrcSurface, pDstSurface, DstSurfaceSize, __dsl_pIV);
            }
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.FinishSessionKeyRefresh"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult FinishSessionKeyRefresh()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, HResult> )(lpVtbl[10]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificate"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, uint, byte*, HResult> )(lpVtbl[4]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
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

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificateSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, uint*, HResult> )(lpVtbl[3]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pCertificateSize);
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

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetEncryptionBltKey"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetEncryptionBltKey(void* pReadbackKey, uint KeySize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, void*, uint, HResult> )(lpVtbl[11]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pReadbackKey, KeySize);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetEncryptionBltKey(Ref pReadbackKey, uint KeySize)
        {
            fixed (void* __dsl_pReadbackKey = pReadbackKey)
            {
                return (HResult)GetEncryptionBltKey(__dsl_pReadbackKey, KeySize);
            }
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetSurfacePitch"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, IDirect3DSurface9.Native*, uint*, HResult> )(lpVtbl[8]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pSrcSurface.LpVtbl, pSurfacePitch);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, Ref<uint> pSurfacePitch)
        {
            fixed (uint* __dsl_pSurfacePitch = pSurfacePitch)
            {
                return (HResult)GetSurfacePitch(pSrcSurface, __dsl_pSurfacePitch);
            }
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.NegotiateKeyExchange"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult NegotiateKeyExchange(uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, uint, void*, HResult> )(lpVtbl[5]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), DataSize, pData);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, uint> )(lpVtbl[2]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.StartSessionKeyRefresh"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9.Native*, void*, uint, HResult> )(lpVtbl[9]))((IDirect3DCryptoSession9.Native*)Unsafe.AsPointer(ref this), pRandomNumber, RandomNumberSize);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult StartSessionKeyRefresh(Ref pRandomNumber, uint RandomNumberSize)
        {
            fixed (void* __dsl_pRandomNumber = pRandomNumber)
            {
                return (HResult)StartSessionKeyRefresh(__dsl_pRandomNumber, RandomNumberSize);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DCryptoSession9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DCryptoSession9(Ptr3D vtbl) => LpVtbl = (IDirect3DCryptoSession9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DCryptoSession9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DCryptoSession9(Ptr<IDirect3DCryptoSession9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DCryptoSession9.Native"/> to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DCryptoSession9(IDirect3DCryptoSession9.Native* value) => new IDirect3DCryptoSession9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DCryptoSession9"/> to <see cref = "IDirect3DCryptoSession9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator IDirect3DCryptoSession9.Native*(IDirect3DCryptoSession9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DCryptoSession9(Ptr3D value) => new IDirect3DCryptoSession9(value);
    /// <summary>casts <see cref = "IDirect3DCryptoSession9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DCryptoSession9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DCryptoSession9(Ptr<IDirect3DCryptoSession9.Native> value) => new IDirect3DCryptoSession9(value);
    /// <summary>casts <see cref = "IDirect3DCryptoSession9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DCryptoSession9.Native>(IDirect3DCryptoSession9 value) => (Ptr<IDirect3DCryptoSession9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DCryptoSession9(void*** value) => new IDirect3DCryptoSession9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DCryptoSession9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DCryptoSession9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DCryptoSession9(nuint value) => new IDirect3DCryptoSession9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DCryptoSession9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DCryptoSession9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.DecryptionBlt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, D3DencryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) => LpVtbl->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, Ref<D3DencryptedBlockInfo> pEncryptedBlockInfo, Ref pContentKey, Ref pIV)
    {
        fixed (void* __dsl_pIV = pIV)
        fixed (void* __dsl_pContentKey = pContentKey)
        fixed (D3DencryptedBlockInfo* __dsl_pEncryptedBlockInfo = pEncryptedBlockInfo)
        {
            return (HResult)DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, __dsl_pEncryptedBlockInfo, __dsl_pContentKey, __dsl_pIV);
        }
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.EncryptionBlt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV) => LpVtbl->EncryptionBlt(pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, Ref pIV)
    {
        fixed (void* __dsl_pIV = pIV)
        {
            return (HResult)EncryptionBlt(pSrcSurface, pDstSurface, DstSurfaceSize, __dsl_pIV);
        }
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.FinishSessionKeyRefresh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult FinishSessionKeyRefresh() => LpVtbl->FinishSessionKeyRefresh();
    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificate"]/*'/>
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

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificateSize"]/*'/>
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

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetEncryptionBltKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetEncryptionBltKey(void* pReadbackKey, uint KeySize) => LpVtbl->GetEncryptionBltKey(pReadbackKey, KeySize);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetEncryptionBltKey(Ref pReadbackKey, uint KeySize)
    {
        fixed (void* __dsl_pReadbackKey = pReadbackKey)
        {
            return (HResult)GetEncryptionBltKey(__dsl_pReadbackKey, KeySize);
        }
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetSurfacePitch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch) => LpVtbl->GetSurfacePitch(pSrcSurface, pSurfacePitch);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSurfacePitch(IDirect3DSurface9 pSrcSurface, Ref<uint> pSurfacePitch)
    {
        fixed (uint* __dsl_pSurfacePitch = pSurfacePitch)
        {
            return (HResult)GetSurfacePitch(pSrcSurface, __dsl_pSurfacePitch);
        }
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.NegotiateKeyExchange"]/*'/>
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
    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.StartSessionKeyRefresh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize) => LpVtbl->StartSessionKeyRefresh(pRandomNumber, RandomNumberSize);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult StartSessionKeyRefresh(Ref pRandomNumber, uint RandomNumberSize)
    {
        fixed (void* __dsl_pRandomNumber = pRandomNumber)
        {
            return (HResult)StartSessionKeyRefresh(__dsl_pRandomNumber, RandomNumberSize);
        }
    }
}
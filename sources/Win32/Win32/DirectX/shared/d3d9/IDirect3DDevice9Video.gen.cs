// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video"]/*'/>
[Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
[NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DDevice9Video : IDirect3DDevice9Video.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DDevice9Video));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, Handle* pChannelHandle);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, Ref<IDirect3DAuthenticatedChannel9> ppAuthenticatedChannel, Ref<Handle> pChannelHandle);
        [VtblIndex(5)]
        HResult CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9* ppCryptoSession, Handle* pCryptoHandle);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCryptoSession([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<IDirect3DCryptoSession9> ppCryptoSession, Ref<Handle> pCryptoHandle);
        [VtblIndex(3)]
        HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3Dcontentprotectioncaps* pCaps);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<D3Dcontentprotectioncaps> pCaps);
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video"]/*'/>
    [Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
    [NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DDevice9Video));

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
            [NativeTypeName("HRESULT (const GUID *, const GUID *, D3DCONTENTPROTECTIONCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, Guid*, D3Dcontentprotectioncaps*, HResult> GetContentProtectionCaps;
            [NativeTypeName("HRESULT (D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dauthenticatedchanneltype, IDirect3DAuthenticatedChannel9.Native**, Handle*, HResult> CreateAuthenticatedChannel;
            [NativeTypeName("HRESULT (const GUID *, const GUID *, IDirect3DCryptoSession9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, Guid*, IDirect3DCryptoSession9.Native**, Handle*, HResult> CreateCryptoSession;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, uint> )(lpVtbl[1]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateAuthenticatedChannel"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, Handle* pChannelHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, D3Dauthenticatedchanneltype, IDirect3DAuthenticatedChannel9.Native**, Handle*, HResult> )(lpVtbl[4]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this), ChannelType, &ppAuthenticatedChannel->LpVtbl, pChannelHandle);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, Ref<IDirect3DAuthenticatedChannel9> ppAuthenticatedChannel, Ref<Handle> pChannelHandle)
        {
            fixed (Handle* __dsl_pChannelHandle = pChannelHandle)
            fixed (IDirect3DAuthenticatedChannel9* __dsl_ppAuthenticatedChannel = ppAuthenticatedChannel)
            {
                return (HResult)CreateAuthenticatedChannel(ChannelType, __dsl_ppAuthenticatedChannel, __dsl_pChannelHandle);
            }
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateCryptoSession"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9* ppCryptoSession, Handle* pCryptoHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, Guid*, Guid*, IDirect3DCryptoSession9.Native**, Handle*, HResult> )(lpVtbl[5]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, &ppCryptoSession->LpVtbl, pCryptoHandle);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCryptoSession([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<IDirect3DCryptoSession9> ppCryptoSession, Ref<Handle> pCryptoHandle)
        {
            fixed (Handle* __dsl_pCryptoHandle = pCryptoHandle)
            fixed (IDirect3DCryptoSession9* __dsl_ppCryptoSession = ppCryptoSession)
            fixed (Guid* __dsl_pDecodeProfile = pDecodeProfile)
            fixed (Guid* __dsl_pCryptoType = pCryptoType)
            {
                return (HResult)CreateCryptoSession(__dsl_pCryptoType, __dsl_pDecodeProfile, __dsl_ppCryptoSession, __dsl_pCryptoHandle);
            }
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.GetContentProtectionCaps"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3Dcontentprotectioncaps* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, Guid*, Guid*, D3Dcontentprotectioncaps*, HResult> )(lpVtbl[3]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, pCaps);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<D3Dcontentprotectioncaps> pCaps)
        {
            fixed (D3Dcontentprotectioncaps* __dsl_pCaps = pCaps)
            fixed (Guid* __dsl_pDecodeProfile = pDecodeProfile)
            fixed (Guid* __dsl_pCryptoType = pCryptoType)
            {
                return (HResult)GetContentProtectionCaps(__dsl_pCryptoType, __dsl_pDecodeProfile, __dsl_pCaps);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DDevice9Video.Native*, uint> )(lpVtbl[2]))((IDirect3DDevice9Video.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Video"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Video(Ptr3D vtbl) => LpVtbl = (IDirect3DDevice9Video.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Video"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Video(Ptr<IDirect3DDevice9Video.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DDevice9Video.Native"/> to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DDevice9Video(IDirect3DDevice9Video.Native* value) => new IDirect3DDevice9Video((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DDevice9Video"/> to <see cref = "IDirect3DDevice9Video.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator IDirect3DDevice9Video.Native*(IDirect3DDevice9Video value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Video(Ptr3D value) => new IDirect3DDevice9Video(value);
    /// <summary>casts <see cref = "IDirect3DDevice9Video"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DDevice9Video value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Video(Ptr<IDirect3DDevice9Video.Native> value) => new IDirect3DDevice9Video(value);
    /// <summary>casts <see cref = "IDirect3DDevice9Video"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DDevice9Video.Native>(IDirect3DDevice9Video value) => (Ptr<IDirect3DDevice9Video.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DDevice9Video(void*** value) => new IDirect3DDevice9Video((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DDevice9Video"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DDevice9Video value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Video(nuint value) => new IDirect3DDevice9Video((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DDevice9Video"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DDevice9Video value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateAuthenticatedChannel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, Handle* pChannelHandle) => LpVtbl->CreateAuthenticatedChannel(ChannelType, ppAuthenticatedChannel, pChannelHandle);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateAuthenticatedChannel(D3Dauthenticatedchanneltype ChannelType, Ref<IDirect3DAuthenticatedChannel9> ppAuthenticatedChannel, Ref<Handle> pChannelHandle)
    {
        fixed (Handle* __dsl_pChannelHandle = pChannelHandle)
        fixed (IDirect3DAuthenticatedChannel9* __dsl_ppAuthenticatedChannel = ppAuthenticatedChannel)
        {
            return (HResult)CreateAuthenticatedChannel(ChannelType, __dsl_ppAuthenticatedChannel, __dsl_pChannelHandle);
        }
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateCryptoSession"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9* ppCryptoSession, Handle* pCryptoHandle) => LpVtbl->CreateCryptoSession(pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCryptoSession([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<IDirect3DCryptoSession9> ppCryptoSession, Ref<Handle> pCryptoHandle)
    {
        fixed (Handle* __dsl_pCryptoHandle = pCryptoHandle)
        fixed (IDirect3DCryptoSession9* __dsl_ppCryptoSession = ppCryptoSession)
        fixed (Guid* __dsl_pDecodeProfile = pDecodeProfile)
        fixed (Guid* __dsl_pCryptoType = pCryptoType)
        {
            return (HResult)CreateCryptoSession(__dsl_pCryptoType, __dsl_pDecodeProfile, __dsl_ppCryptoSession, __dsl_pCryptoHandle);
        }
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.GetContentProtectionCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3Dcontentprotectioncaps* pCaps) => LpVtbl->GetContentProtectionCaps(pCryptoType, pDecodeProfile, pCaps);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetContentProtectionCaps([NativeTypeName("const GUID *")] Ref<Guid> pCryptoType, [NativeTypeName("const GUID *")] Ref<Guid> pDecodeProfile, Ref<D3Dcontentprotectioncaps> pCaps)
    {
        fixed (D3Dcontentprotectioncaps* __dsl_pCaps = pCaps)
        fixed (Guid* __dsl_pDecodeProfile = pDecodeProfile)
        fixed (Guid* __dsl_pCryptoType = pCryptoType)
        {
            return (HResult)GetContentProtectionCaps(__dsl_pCryptoType, __dsl_pDecodeProfile, __dsl_pCaps);
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
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand"]/*'/>
[Guid("554E41E8-AE8E-4A8C-B7D2-5B4F274A30E4")]
[NativeTypeName("struct ID3D12VideoExtensionCommand : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct ID3D12VideoExtensionCommand : ID3D12VideoExtensionCommand.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoExtensionCommand));

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(8)]
        D3D12VideoExtensionCommandDesc GetDesc();
        [VtblIndex(9)]
        HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession);
    }

    /// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand"]/*'/>
    [Guid("554E41E8-AE8E-4A8C-B7D2-5B4F274A30E4")]
    [NativeTypeName("struct ID3D12VideoExtensionCommand : ID3D12Pageable")]
    [NativeInheritance("ID3D12Pageable")]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoExtensionCommand));

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
            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, IUnknown.Native*, HResult> SetPrivateDataInterface;
            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, HResult> SetName;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetDevice;
            [NativeTypeName("D3D12_VIDEO_EXTENSION_COMMAND_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoExtensionCommandDesc*, D3D12VideoExtensionCommandDesc*> GetDesc;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetProtectedResourceSession;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, uint> )(lpVtbl[1]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D3D12VideoExtensionCommandDesc GetDesc()
        {
            D3D12VideoExtensionCommandDesc result;
            return *((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, D3D12VideoExtensionCommandDesc*, D3D12VideoExtensionCommandDesc*> )(lpVtbl[8]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
        {
            fixed (void** __dsl_ppvDevice = ppvDevice)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetDevice(__dsl_riid, __dsl_ppvDevice);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetDevice<TCom>(out TCom ppvDevice)
            where TCom : unmanaged, IComVtbl
        {
            ppvDevice = default;
            return GetDevice(TCom.NativeGuid, ppvDevice.GetAddressOf());
        }

        /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> pDataSize, Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            fixed (uint* __dsl_pDataSize = pDataSize)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)GetPrivateData(__dsl_guid, __dsl_pDataSize, __dsl_pData);
            }
        }

        /// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand.GetProtectedResourceSession"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession)
        {
            fixed (void** __dsl_ppProtectedSession = ppProtectedSession)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetProtectedResourceSession(__dsl_riid, __dsl_ppProtectedSession);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        public HResult GetProtectedResourceSession<TCom>(out TCom ppProtectedSession)
            where TCom : unmanaged, IComVtbl
        {
            ppProtectedSession = default;
            return GetProtectedResourceSession(TCom.NativeGuid, ppProtectedSession.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, uint> )(lpVtbl[2]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetName([NativeTypeName("LPCWSTR")] Ref<ushort> Name)
        {
            fixed (ushort* __dsl_Name = Name)
            {
                return (HResult)SetName(__dsl_Name);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint DataSize, [NativeTypeName("const void *")] Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateData(__dsl_guid, DataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
        {
            return ((delegate* unmanaged<ID3D12VideoExtensionCommand.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12VideoExtensionCommand.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
        {
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateDataInterface(__dsl_guid, pData);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoExtensionCommand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoExtensionCommand(Ptr3D vtbl) => LpVtbl = (ID3D12VideoExtensionCommand.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoExtensionCommand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoExtensionCommand(Ptr<ID3D12VideoExtensionCommand.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand.Native"/> to <see cref = "ID3D12VideoExtensionCommand"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VideoExtensionCommand(ID3D12VideoExtensionCommand.Native* value) => new ID3D12VideoExtensionCommand((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand"/> to <see cref = "ID3D12VideoExtensionCommand.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand"/> instance to be converted </param>
    public static implicit operator ID3D12VideoExtensionCommand.Native*(ID3D12VideoExtensionCommand value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VideoExtensionCommand"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VideoExtensionCommand(Ptr3D value) => new ID3D12VideoExtensionCommand(value);
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VideoExtensionCommand value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VideoExtensionCommand"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VideoExtensionCommand(Ptr<ID3D12VideoExtensionCommand.Native> value) => new ID3D12VideoExtensionCommand(value);
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VideoExtensionCommand.Native>(ID3D12VideoExtensionCommand value) => (Ptr<ID3D12VideoExtensionCommand.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VideoExtensionCommand"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VideoExtensionCommand(void*** value) => new ID3D12VideoExtensionCommand((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VideoExtensionCommand value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VideoExtensionCommand"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VideoExtensionCommand(nuint value) => new ID3D12VideoExtensionCommand((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VideoExtensionCommand"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoExtensionCommand"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VideoExtensionCommand value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D3D12VideoExtensionCommandDesc GetDesc() => LpVtbl->GetDesc();
    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice) => LpVtbl->GetDevice(riid, ppvDevice);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
    {
        fixed (void** __dsl_ppvDevice = ppvDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetDevice(__dsl_riid, __dsl_ppvDevice);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetDevice<TCom>(out TCom ppvDevice)
        where TCom : unmanaged, IComVtbl
    {
        ppvDevice = default;
        return GetDevice(TCom.NativeGuid, ppvDevice.GetAddressOf());
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData) => LpVtbl->GetPrivateData(guid, pDataSize, pData);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> pDataSize, Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        fixed (uint* __dsl_pDataSize = pDataSize)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)GetPrivateData(__dsl_guid, __dsl_pDataSize, __dsl_pData);
        }
    }

    /// <include file='ID3D12VideoExtensionCommand.xml' path='doc/member[@name="ID3D12VideoExtensionCommand.GetProtectedResourceSession"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession) => LpVtbl->GetProtectedResourceSession(riid, ppProtectedSession);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession)
    {
        fixed (void** __dsl_ppProtectedSession = ppProtectedSession)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetProtectedResourceSession(__dsl_riid, __dsl_ppProtectedSession);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    public HResult GetProtectedResourceSession<TCom>(out TCom ppProtectedSession)
        where TCom : unmanaged, IComVtbl
    {
        ppProtectedSession = default;
        return GetProtectedResourceSession(TCom.NativeGuid, ppProtectedSession.GetAddressOf());
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
    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name) => LpVtbl->SetName(Name);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetName([NativeTypeName("LPCWSTR")] Ref<ushort> Name)
    {
        fixed (ushort* __dsl_Name = Name)
        {
            return (HResult)SetName(__dsl_Name);
        }
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData) => LpVtbl->SetPrivateData(guid, DataSize, pData);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint DataSize, [NativeTypeName("const void *")] Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateData(__dsl_guid, DataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData) => LpVtbl->SetPrivateDataInterface(guid, pData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
    {
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateDataInterface(__dsl_guid, pData);
        }
    }
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory"]/*'/>
[Guid("78EE5945-C36E-4B13-A669-005DD11C0F06")]
[NativeTypeName("struct IDXCoreAdapterFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapterFactory : IDXCoreAdapterFactory.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapterFactory));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Ref<Guid> filterAttributes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapterList);
        [VtblIndex(4)]
        HResult GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetAdapterByLuid([NativeTypeName("const LUID &")] Ref<LUID> adapterLUID, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter);
        [VtblIndex(5)]
        bool IsNotificationTypeSupported(DXCoreNotificationType notificationType);
        [VtblIndex(7)]
        HResult UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie);
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory"]/*'/>
    [Guid("78EE5945-C36E-4B13-A669-005DD11C0F06")]
    [NativeTypeName("struct IDXCoreAdapterFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapterFactory));

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
            [NativeTypeName("HRESULT (uint32_t, const GUID *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, HResult> CreateAdapterList;
            [NativeTypeName("HRESULT (const LUID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, LUID*, Guid*, void**, HResult> GetAdapterByLuid;
            [NativeTypeName("bool (DXCoreNotificationType) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreNotificationType, byte> IsNotificationTypeSupported;
            [NativeTypeName("HRESULT (IUnknown *, DXCoreNotificationType, PFN_DXCORE_NOTIFICATION_CALLBACK, void *, uint32_t *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IUnknown.Native*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> , void*, uint*, HResult> RegisterEventNotification;
            [NativeTypeName("HRESULT (uint32_t) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> UnregisterEventNotification;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, uint> )(lpVtbl[1]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.CreateAdapterList"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, uint, Guid*, Guid*, void**, HResult> )(lpVtbl[3]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Ref<Guid> filterAttributes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapterList)
        {
            fixed (void** __dsl_ppvAdapterList = ppvAdapterList)
            fixed (Guid* __dsl_riid = riid)
            fixed (Guid* __dsl_filterAttributes = filterAttributes)
            {
                return (HResult)CreateAdapterList(numAttributes, __dsl_filterAttributes, __dsl_riid, __dsl_ppvAdapterList);
            }
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateAdapterList<TCom>([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Ref<Guid> filterAttributes, out TCom ppvAdapterList)
            where TCom : unmanaged, IComVtbl
        {
            fixed (Guid* __dsl_filterAttributes = filterAttributes)
            {
                ppvAdapterList = default;
                return CreateAdapterList(numAttributes, __dsl_filterAttributes, TCom.NativeGuid, ppvAdapterList.GetAddressOf());
            }
        }

        /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.GetAdapterByLuid"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, LUID*, Guid*, void**, HResult> )(lpVtbl[4]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterByLuid([NativeTypeName("const LUID &")] Ref<LUID> adapterLUID, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter)
        {
            fixed (void** __dsl_ppvAdapter = ppvAdapter)
            fixed (Guid* __dsl_riid = riid)
            fixed (LUID* __dsl_adapterLUID = adapterLUID)
            {
                return (HResult)GetAdapterByLuid(__dsl_adapterLUID, __dsl_riid, __dsl_ppvAdapter);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterByLuid<TCom>([NativeTypeName("const LUID &")] Ref<LUID> adapterLUID, out TCom ppvAdapter)
            where TCom : unmanaged, IComVtbl
        {
            fixed (LUID* __dsl_adapterLUID = adapterLUID)
            {
                ppvAdapter = default;
                return GetAdapterByLuid(__dsl_adapterLUID, TCom.NativeGuid, ppvAdapter.GetAddressOf());
            }
        }

        /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.IsNotificationTypeSupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, DXCoreNotificationType, byte> )(lpVtbl[5]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), notificationType) != 0;
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.RegisterEventNotification"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult RegisterEventNotification(IUnknown dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> callbackFunction, void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, IUnknown.Native*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> , void*, uint*, HResult> )(lpVtbl[6]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), dxCoreObject.lpVtbl, notificationType, callbackFunction, callbackContext, eventCookie);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult RegisterEventNotification(IUnknown dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> callbackFunction, Ref callbackContext, [NativeTypeName("uint32_t *")] Ref<uint> eventCookie)
        {
            fixed (uint* __dsl_eventCookie = eventCookie)
            fixed (void* __dsl_callbackContext = callbackContext)
            {
                return (HResult)RegisterEventNotification(dxCoreObject, notificationType, callbackFunction, __dsl_callbackContext, __dsl_eventCookie);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, uint> )(lpVtbl[2]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.UnregisterEventNotification"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
        {
            return ((delegate* unmanaged<IDXCoreAdapterFactory.Native*, uint, HResult> )(lpVtbl[7]))((IDXCoreAdapterFactory.Native*)Unsafe.AsPointer(ref this), eventCookie);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterFactory(Ptr3D vtbl) => LpVtbl = (IDXCoreAdapterFactory.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterFactory(Ptr<IDXCoreAdapterFactory.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDXCoreAdapterFactory.Native"/> to <see cref = "IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory.Native"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapterFactory(IDXCoreAdapterFactory.Native* value) => new IDXCoreAdapterFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapterFactory"/> to <see cref = "IDXCoreAdapterFactory.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapterFactory.Native*(IDXCoreAdapterFactory value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory(Ptr3D value) => new IDXCoreAdapterFactory(value);
    /// <summary>casts <see cref = "IDXCoreAdapterFactory"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDXCoreAdapterFactory value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory(Ptr<IDXCoreAdapterFactory.Native> value) => new IDXCoreAdapterFactory(value);
    /// <summary>casts <see cref = "IDXCoreAdapterFactory"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory"/> instance to be converted </param>
    public static implicit operator Ptr<IDXCoreAdapterFactory.Native>(IDXCoreAdapterFactory value) => (Ptr<IDXCoreAdapterFactory.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory(void*** value) => new IDXCoreAdapterFactory((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapterFactory"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory"/> instance to be converted </param>
    public static implicit operator void***(IDXCoreAdapterFactory value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory(nuint value) => new IDXCoreAdapterFactory((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDXCoreAdapterFactory"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory"/> instance to be converted </param>
    public static implicit operator nuint(IDXCoreAdapterFactory value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.CreateAdapterList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList) => LpVtbl->CreateAdapterList(numAttributes, filterAttributes, riid, ppvAdapterList);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Ref<Guid> filterAttributes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapterList)
    {
        fixed (void** __dsl_ppvAdapterList = ppvAdapterList)
        fixed (Guid* __dsl_riid = riid)
        fixed (Guid* __dsl_filterAttributes = filterAttributes)
        {
            return (HResult)CreateAdapterList(numAttributes, __dsl_filterAttributes, __dsl_riid, __dsl_ppvAdapterList);
        }
    }

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateAdapterList<TCom>([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Ref<Guid> filterAttributes, out TCom ppvAdapterList)
        where TCom : unmanaged, IComVtbl
    {
        fixed (Guid* __dsl_filterAttributes = filterAttributes)
        {
            ppvAdapterList = default;
            return CreateAdapterList(numAttributes, __dsl_filterAttributes, TCom.NativeGuid, ppvAdapterList.GetAddressOf());
        }
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.GetAdapterByLuid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter) => LpVtbl->GetAdapterByLuid(adapterLUID, riid, ppvAdapter);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterByLuid([NativeTypeName("const LUID &")] Ref<LUID> adapterLUID, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter)
    {
        fixed (void** __dsl_ppvAdapter = ppvAdapter)
        fixed (Guid* __dsl_riid = riid)
        fixed (LUID* __dsl_adapterLUID = adapterLUID)
        {
            return (HResult)GetAdapterByLuid(__dsl_adapterLUID, __dsl_riid, __dsl_ppvAdapter);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterByLuid<TCom>([NativeTypeName("const LUID &")] Ref<LUID> adapterLUID, out TCom ppvAdapter)
        where TCom : unmanaged, IComVtbl
    {
        fixed (LUID* __dsl_adapterLUID = adapterLUID)
        {
            ppvAdapter = default;
            return GetAdapterByLuid(__dsl_adapterLUID, TCom.NativeGuid, ppvAdapter.GetAddressOf());
        }
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.IsNotificationTypeSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType) => LpVtbl->IsNotificationTypeSupported(notificationType);
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

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.RegisterEventNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult RegisterEventNotification(IUnknown dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> callbackFunction, void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie) => LpVtbl->RegisterEventNotification(dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterEventNotification(IUnknown dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown.Native*, void*, void> callbackFunction, Ref callbackContext, [NativeTypeName("uint32_t *")] Ref<uint> eventCookie)
    {
        fixed (uint* __dsl_eventCookie = eventCookie)
        fixed (void* __dsl_callbackContext = callbackContext)
        {
            return (HResult)RegisterEventNotification(dxCoreObject, notificationType, callbackFunction, __dsl_callbackContext, __dsl_eventCookie);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.UnregisterEventNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie) => LpVtbl->UnregisterEventNotification(eventCookie);
}
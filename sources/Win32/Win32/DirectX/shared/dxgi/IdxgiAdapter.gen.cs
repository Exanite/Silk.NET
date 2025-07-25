// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter"]/*'/>
[Guid("2411E7E1-12AC-4CCF-BD14-9798E8534DC0")]
[NativeTypeName("struct IDXGIAdapter : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IdxgiAdapter : IdxgiAdapter.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiAdapter));

    public interface Interface : IdxgiObject.Interface
    {
        [VtblIndex(9)]
        HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Guid* InterfaceName,
            LargeInteger* pUMDVersion
        );

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Ref<Guid> InterfaceName,
            Ref<LargeInteger> pUMDVersion
        );

        [VtblIndex(7)]
        HResult EnumOutputs(uint Output, IdxgiOutput* ppOutput);

        [VtblIndex(7)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult EnumOutputs(uint Output, Ref<IdxgiOutput> ppOutput);

        [VtblIndex(8)]
        HResult GetDesc(DxgiAdapterDesc* pDesc);

        [VtblIndex(8)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDesc(Ref<DxgiAdapterDesc> pDesc);
    }

    /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter"]/*'/>

    [Guid("2411E7E1-12AC-4CCF-BD14-9798E8534DC0")]
    [NativeTypeName("struct IDXGIAdapter : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiAdapter));
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

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Guid*,
                IUnknown.Native*,
                HResult> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IdxgiOutput.Native**, HResult> EnumOutputs;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiAdapterDesc*, HResult> GetDesc;

            [NativeTypeName("HRESULT (const GUID &, LARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, LargeInteger*, HResult> CheckInterfaceSupport;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiAdapter.Native*, uint>)(lpVtbl[1]))(
                (IdxgiAdapter.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.CheckInterfaceSupport"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Guid* InterfaceName,
            LargeInteger* pUMDVersion
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, Guid*, LargeInteger*, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Ref<Guid> InterfaceName,
            Ref<LargeInteger> pUMDVersion
        )
        {
            fixed (LargeInteger* __dsl_pUMDVersion = pUMDVersion)
            fixed (Guid* __dsl_InterfaceName = InterfaceName)
            {
                return (HResult)CheckInterfaceSupport(__dsl_InterfaceName, __dsl_pUMDVersion);
            }
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.EnumOutputs"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumOutputs(uint Output, IdxgiOutput* ppOutput)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, uint, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), Output, &ppOutput->LpVtbl);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumOutputs(uint Output, Ref<IdxgiOutput> ppOutput)
        {
            fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
            {
                return (HResult)EnumOutputs(Output, __dsl_ppOutput);
            }
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.GetDesc"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDesc(DxgiAdapterDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, DxgiAdapterDesc*, HResult>)(lpVtbl[8])
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc(Ref<DxgiAdapterDesc> pDesc)
        {
            fixed (DxgiAdapterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IdxgiAdapter.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiAdapter.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppParent
            );
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
        {
            fixed (void** __dsl_ppParent = ppParent)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        public HResult GetParent<TCom>(out TCom ppParent)
            where TCom : unmanaged, IComVtbl
        {
            ppParent = default;
            return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint* pDataSize,
            void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            Ref<uint> pDataSize,
            Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (uint* __dsl_pDataSize = pDataSize)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IdxgiAdapter.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiAdapter.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
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
            return ((delegate* unmanaged<IdxgiAdapter.Native*, uint>)(lpVtbl[2]))(
                (IdxgiAdapter.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint DataSize,
            [NativeTypeName("const void *")] void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            uint DataSize,
            [NativeTypeName("const void *")] Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Guid* Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiAdapter.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiAdapter(Ptr3D vtbl) => LpVtbl = (IdxgiAdapter.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiAdapter(Ptr<IdxgiAdapter.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiAdapter.Native"/> to <see cref = "IdxgiAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter.Native"/> instance to be converted </param>

    public static implicit operator IdxgiAdapter(IdxgiAdapter.Native* value) =>
        new IdxgiAdapter((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiAdapter"/> to <see cref = "IdxgiAdapter.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter"/> instance to be converted </param>

    public static implicit operator IdxgiAdapter.Native*(IdxgiAdapter value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter(Ptr3D value) => new IdxgiAdapter(value);

    /// <summary>casts <see cref = "IdxgiAdapter"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiAdapter value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter(Ptr<IdxgiAdapter.Native> value) =>
        new IdxgiAdapter(value);

    /// <summary>casts <see cref = "IdxgiAdapter"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiAdapter.Native>(IdxgiAdapter value) =>
        (Ptr<IdxgiAdapter.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiAdapter"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiAdapter(void*** value) =>
        new IdxgiAdapter((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiAdapter"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter"/> instance to be converted </param>

    public static implicit operator void***(IdxgiAdapter value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter(nuint value) =>
        new IdxgiAdapter((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiAdapter"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiAdapter value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.CheckInterfaceSupport"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CheckInterfaceSupport(
        [NativeTypeName("const GUID &")] Guid* InterfaceName,
        LargeInteger* pUMDVersion
    ) => LpVtbl->CheckInterfaceSupport(InterfaceName, pUMDVersion);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckInterfaceSupport(
        [NativeTypeName("const GUID &")] Ref<Guid> InterfaceName,
        Ref<LargeInteger> pUMDVersion
    )
    {
        fixed (LargeInteger* __dsl_pUMDVersion = pUMDVersion)
        fixed (Guid* __dsl_InterfaceName = InterfaceName)
        {
            return (HResult)CheckInterfaceSupport(__dsl_InterfaceName, __dsl_pUMDVersion);
        }
    }

    /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.EnumOutputs"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult EnumOutputs(uint Output, IdxgiOutput* ppOutput) =>
        LpVtbl->EnumOutputs(Output, ppOutput);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumOutputs(uint Output, Ref<IdxgiOutput> ppOutput)
    {
        fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
        {
            return (HResult)EnumOutputs(Output, __dsl_ppOutput);
        }
    }

    /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.GetDesc"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDesc(DxgiAdapterDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<DxgiAdapterDesc> pDesc)
    {
        fixed (DxgiAdapterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.GetParent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent) =>
        LpVtbl->GetParent(riid, ppParent);

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
    {
        fixed (void** __dsl_ppParent = ppParent)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    public HResult GetParent<TCom>(out TCom ppParent)
        where TCom : unmanaged, IComVtbl
    {
        ppParent = default;
        return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    ) => LpVtbl->GetPrivateData(Name, pDataSize, pData);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        Ref<uint> pDataSize,
        Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (uint* __dsl_pDataSize = pDataSize)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
        }
    }

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

    /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    ) => LpVtbl->SetPrivateData(Name, DataSize, pData);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        uint DataSize,
        [NativeTypeName("const void *")] Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    ) => LpVtbl->SetPrivateDataInterface(Name, pUnknown);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
        }
    }
}

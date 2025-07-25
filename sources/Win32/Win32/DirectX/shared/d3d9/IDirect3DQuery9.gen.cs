// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9"]/*'/>
[Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
[NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DQuery9 : IDirect3DQuery9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DQuery9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(7)]
        HResult GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetData(Ref pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags);
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        uint GetDataSize();
        [VtblIndex(3)]
        HResult GetDevice(IDirect3DDevice9* ppDevice);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDevice(Ref<IDirect3DDevice9> ppDevice);
        [VtblIndex(4)]
        D3Dquerytype GetType();
        [VtblIndex(6)]
        HResult Issue([NativeTypeName("DWORD")] uint dwIssueFlags);
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9"]/*'/>
    [Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
    [NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DQuery9));

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
            [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DDevice9.Native**, HResult> GetDevice;
            [NativeTypeName("D3DQUERYTYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* unmanaged<TSelf*, D3Dquerytype> GetType;
            [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetDataSize;
            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> Issue;
            [NativeTypeName("HRESULT (void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, uint, HResult> GetData;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, uint> )(lpVtbl[1]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, void*, uint, uint, HResult> )(lpVtbl[7]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this), pData, dwSize, dwGetDataFlags);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetData(Ref pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)GetData(__dsl_pData, dwSize, dwGetDataFlags);
            }
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDataSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, uint> )(lpVtbl[5]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
        {
            fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
            {
                return (HResult)GetDevice(__dsl_ppDevice);
            }
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetType"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public new D3Dquerytype GetType()
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, D3Dquerytype> )(lpVtbl[4]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.Issue"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult Issue([NativeTypeName("DWORD")] uint dwIssueFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, uint, HResult> )(lpVtbl[6]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this), dwIssueFlags);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DQuery9.Native*, uint> )(lpVtbl[2]))((IDirect3DQuery9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DQuery9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DQuery9(Ptr3D vtbl) => LpVtbl = (IDirect3DQuery9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DQuery9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DQuery9(Ptr<IDirect3DQuery9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DQuery9.Native"/> to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DQuery9(IDirect3DQuery9.Native* value) => new IDirect3DQuery9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DQuery9"/> to <see cref = "IDirect3DQuery9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator IDirect3DQuery9.Native*(IDirect3DQuery9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DQuery9(Ptr3D value) => new IDirect3DQuery9(value);
    /// <summary>casts <see cref = "IDirect3DQuery9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DQuery9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DQuery9(Ptr<IDirect3DQuery9.Native> value) => new IDirect3DQuery9(value);
    /// <summary>casts <see cref = "IDirect3DQuery9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DQuery9.Native>(IDirect3DQuery9 value) => (Ptr<IDirect3DQuery9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DQuery9(void*** value) => new IDirect3DQuery9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DQuery9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DQuery9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DQuery9(nuint value) => new IDirect3DQuery9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DQuery9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DQuery9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags) => LpVtbl->GetData(pData, dwSize, dwGetDataFlags);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetData(Ref pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)GetData(__dsl_pData, dwSize, dwGetDataFlags);
        }
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDataSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("DWORD")]
    public uint GetDataSize() => LpVtbl->GetDataSize();
    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetDevice(IDirect3DDevice9* ppDevice) => LpVtbl->GetDevice(ppDevice);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
    {
        fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
        {
            return (HResult)GetDevice(__dsl_ppDevice);
        }
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public new D3Dquerytype GetType() => LpVtbl->GetType();
    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.Issue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Issue([NativeTypeName("DWORD")] uint dwIssueFlags) => LpVtbl->Issue(dwIssueFlags);
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
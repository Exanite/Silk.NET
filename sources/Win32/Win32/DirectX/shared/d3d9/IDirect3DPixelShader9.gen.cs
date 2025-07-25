// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9"]/*'/>
[Guid("6D3BDBDC-5B02-4415-B852-CE5E8BCCB289")]
[NativeTypeName("struct IDirect3DPixelShader9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DPixelShader9 : IDirect3DPixelShader9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DPixelShader9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetDevice(IDirect3DDevice9* ppDevice);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDevice(Ref<IDirect3DDevice9> ppDevice);
        [VtblIndex(4)]
        HResult GetFunction(void* param0, uint* pSizeOfData);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetFunction(Ref param0, Ref<uint> pSizeOfData);
    }

    /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9"]/*'/>
    [Guid("6D3BDBDC-5B02-4415-B852-CE5E8BCCB289")]
    [NativeTypeName("struct IDirect3DPixelShader9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DPixelShader9));

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
            [NativeTypeName("HRESULT (void *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint*, HResult> GetFunction;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9.Native*, uint> )(lpVtbl[1]))((IDirect3DPixelShader9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DPixelShader9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
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

        /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetFunction"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetFunction(void* param0, uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9.Native*, void*, uint*, HResult> )(lpVtbl[4]))((IDirect3DPixelShader9.Native*)Unsafe.AsPointer(ref this), param0, pSizeOfData);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetFunction(Ref param0, Ref<uint> pSizeOfData)
        {
            fixed (uint* __dsl_pSizeOfData = pSizeOfData)
            fixed (void* __dsl_param0 = param0)
            {
                return (HResult)GetFunction(__dsl_param0, __dsl_pSizeOfData);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DPixelShader9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DPixelShader9.Native*, uint> )(lpVtbl[2]))((IDirect3DPixelShader9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DPixelShader9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DPixelShader9(Ptr3D vtbl) => LpVtbl = (IDirect3DPixelShader9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DPixelShader9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DPixelShader9(Ptr<IDirect3DPixelShader9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DPixelShader9.Native"/> to <see cref = "IDirect3DPixelShader9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DPixelShader9(IDirect3DPixelShader9.Native* value) => new IDirect3DPixelShader9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DPixelShader9"/> to <see cref = "IDirect3DPixelShader9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9"/> instance to be converted </param>
    public static implicit operator IDirect3DPixelShader9.Native*(IDirect3DPixelShader9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DPixelShader9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DPixelShader9(Ptr3D value) => new IDirect3DPixelShader9(value);
    /// <summary>casts <see cref = "IDirect3DPixelShader9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DPixelShader9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DPixelShader9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DPixelShader9(Ptr<IDirect3DPixelShader9.Native> value) => new IDirect3DPixelShader9(value);
    /// <summary>casts <see cref = "IDirect3DPixelShader9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DPixelShader9.Native>(IDirect3DPixelShader9 value) => (Ptr<IDirect3DPixelShader9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DPixelShader9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DPixelShader9(void*** value) => new IDirect3DPixelShader9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DPixelShader9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DPixelShader9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DPixelShader9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DPixelShader9(nuint value) => new IDirect3DPixelShader9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DPixelShader9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DPixelShader9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DPixelShader9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetDevice"]/*'/>
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

    /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetFunction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetFunction(void* param0, uint* pSizeOfData) => LpVtbl->GetFunction(param0, pSizeOfData);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFunction(Ref param0, Ref<uint> pSizeOfData)
    {
        fixed (uint* __dsl_pSizeOfData = pSizeOfData)
        fixed (void* __dsl_param0 = param0)
        {
            return (HResult)GetFunction(__dsl_param0, __dsl_pSizeOfData);
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
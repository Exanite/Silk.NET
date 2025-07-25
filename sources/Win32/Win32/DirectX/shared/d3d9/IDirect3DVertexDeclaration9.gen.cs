// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9"]/*'/>
[Guid("DD13C59C-36FA-4098-A8FB-C7ED39DC8546")]
[NativeTypeName("struct IDirect3DVertexDeclaration9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DVertexDeclaration9 : IDirect3DVertexDeclaration9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DVertexDeclaration9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult GetDeclaration(D3Dvertexelement9* pElement, uint* pNumElements);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDeclaration(Ref<D3Dvertexelement9> pElement, Ref<uint> pNumElements);
        [VtblIndex(3)]
        HResult GetDevice(IDirect3DDevice9* ppDevice);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDevice(Ref<IDirect3DDevice9> ppDevice);
    }

    /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9"]/*'/>
    [Guid("DD13C59C-36FA-4098-A8FB-C7ED39DC8546")]
    [NativeTypeName("struct IDirect3DVertexDeclaration9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DVertexDeclaration9));

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
            [NativeTypeName("HRESULT (D3DVERTEXELEMENT9 *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dvertexelement9*, uint*, HResult> GetDeclaration;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9.Native*, uint> )(lpVtbl[1]))((IDirect3DVertexDeclaration9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDeclaration"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetDeclaration(D3Dvertexelement9* pElement, uint* pNumElements)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9.Native*, D3Dvertexelement9*, uint*, HResult> )(lpVtbl[4]))((IDirect3DVertexDeclaration9.Native*)Unsafe.AsPointer(ref this), pElement, pNumElements);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDeclaration(Ref<D3Dvertexelement9> pElement, Ref<uint> pNumElements)
        {
            fixed (uint* __dsl_pNumElements = pNumElements)
            fixed (D3Dvertexelement9* __dsl_pElement = pElement)
            {
                return (HResult)GetDeclaration(__dsl_pElement, __dsl_pNumElements);
            }
        }

        /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DVertexDeclaration9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DVertexDeclaration9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9.Native*, uint> )(lpVtbl[2]))((IDirect3DVertexDeclaration9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DVertexDeclaration9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DVertexDeclaration9(Ptr3D vtbl) => LpVtbl = (IDirect3DVertexDeclaration9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DVertexDeclaration9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DVertexDeclaration9(Ptr<IDirect3DVertexDeclaration9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9.Native"/> to <see cref = "IDirect3DVertexDeclaration9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DVertexDeclaration9(IDirect3DVertexDeclaration9.Native* value) => new IDirect3DVertexDeclaration9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9"/> to <see cref = "IDirect3DVertexDeclaration9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9"/> instance to be converted </param>
    public static implicit operator IDirect3DVertexDeclaration9.Native*(IDirect3DVertexDeclaration9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DVertexDeclaration9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DVertexDeclaration9(Ptr3D value) => new IDirect3DVertexDeclaration9(value);
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DVertexDeclaration9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DVertexDeclaration9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DVertexDeclaration9(Ptr<IDirect3DVertexDeclaration9.Native> value) => new IDirect3DVertexDeclaration9(value);
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DVertexDeclaration9.Native>(IDirect3DVertexDeclaration9 value) => (Ptr<IDirect3DVertexDeclaration9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DVertexDeclaration9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DVertexDeclaration9(void*** value) => new IDirect3DVertexDeclaration9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DVertexDeclaration9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DVertexDeclaration9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DVertexDeclaration9(nuint value) => new IDirect3DVertexDeclaration9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DVertexDeclaration9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DVertexDeclaration9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DVertexDeclaration9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDeclaration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetDeclaration(D3Dvertexelement9* pElement, uint* pNumElements) => LpVtbl->GetDeclaration(pElement, pNumElements);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDeclaration(Ref<D3Dvertexelement9> pElement, Ref<uint> pNumElements)
    {
        fixed (uint* __dsl_pNumElements = pNumElements)
        fixed (D3Dvertexelement9* __dsl_pElement = pElement)
        {
            return (HResult)GetDeclaration(__dsl_pElement, __dsl_pNumElements);
        }
    }

    /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDevice"]/*'/>
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
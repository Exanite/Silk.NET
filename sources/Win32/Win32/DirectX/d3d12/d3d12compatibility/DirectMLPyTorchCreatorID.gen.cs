// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='DirectMLPyTorchCreatorID.xml' path='doc/member[@name="DirectMLPyTorchCreatorID"]/*'/>
[Guid("AF029192-FBA1-4B05-9116-235E06560354")]
[NativeTypeName("struct DirectMLPyTorchCreatorID : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct DirectMLPyTorchCreatorID : DirectMLPyTorchCreatorID.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.DirectMLPyTorchCreatorID));

    public interface Interface : IUnknown.Interface
    {
    }

    /// <include file='DirectMLPyTorchCreatorID.xml' path='doc/member[@name="DirectMLPyTorchCreatorID"]/*'/>
    [Guid("AF029192-FBA1-4B05-9116-235E06560354")]
    [NativeTypeName("struct DirectMLPyTorchCreatorID : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.DirectMLPyTorchCreatorID));

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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<DirectMLPyTorchCreatorID.Native*, uint> )(lpVtbl[1]))((DirectMLPyTorchCreatorID.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<DirectMLPyTorchCreatorID.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((DirectMLPyTorchCreatorID.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<DirectMLPyTorchCreatorID.Native*, uint> )(lpVtbl[2]))((DirectMLPyTorchCreatorID.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "DirectMLPyTorchCreatorID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public DirectMLPyTorchCreatorID(Ptr3D vtbl) => LpVtbl = (DirectMLPyTorchCreatorID.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "DirectMLPyTorchCreatorID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public DirectMLPyTorchCreatorID(Ptr<DirectMLPyTorchCreatorID.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID.Native"/> to <see cref = "DirectMLPyTorchCreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID.Native"/> instance to be converted </param>
    public static implicit operator DirectMLPyTorchCreatorID(DirectMLPyTorchCreatorID.Native* value) => new DirectMLPyTorchCreatorID((Ptr<Native>)value);
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID"/> to <see cref = "DirectMLPyTorchCreatorID.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID"/> instance to be converted </param>
    public static implicit operator DirectMLPyTorchCreatorID.Native*(DirectMLPyTorchCreatorID value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "DirectMLPyTorchCreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator DirectMLPyTorchCreatorID(Ptr3D value) => new DirectMLPyTorchCreatorID(value);
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID"/> instance to be converted </param>
    public static implicit operator Ptr3D(DirectMLPyTorchCreatorID value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "DirectMLPyTorchCreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator DirectMLPyTorchCreatorID(Ptr<DirectMLPyTorchCreatorID.Native> value) => new DirectMLPyTorchCreatorID(value);
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID"/> instance to be converted </param>
    public static implicit operator Ptr<DirectMLPyTorchCreatorID.Native>(DirectMLPyTorchCreatorID value) => (Ptr<DirectMLPyTorchCreatorID.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "DirectMLPyTorchCreatorID"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator DirectMLPyTorchCreatorID(void*** value) => new DirectMLPyTorchCreatorID((Ptr<Native>)value);
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID"/> instance to be converted </param>
    public static implicit operator void***(DirectMLPyTorchCreatorID value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "DirectMLPyTorchCreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator DirectMLPyTorchCreatorID(nuint value) => new DirectMLPyTorchCreatorID((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "DirectMLPyTorchCreatorID"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "DirectMLPyTorchCreatorID"/> instance to be converted </param>
    public static implicit operator nuint(DirectMLPyTorchCreatorID value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
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
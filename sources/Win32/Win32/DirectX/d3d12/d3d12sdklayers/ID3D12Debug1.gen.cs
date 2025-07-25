// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1"]/*'/>
[Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
[NativeTypeName("struct ID3D12Debug1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Debug1 : ID3D12Debug1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Debug1));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void EnableDebugLayer();
        [VtblIndex(4)]
        void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable);
        [VtblIndex(5)]
        void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable);
    }

    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1"]/*'/>
    [Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
    [NativeTypeName("struct ID3D12Debug1 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Debug1));

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
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> EnableDebugLayer;
            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> SetEnableGPUBasedValidation;
            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> SetEnableSynchronizedCommandQueueValidation;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Debug1.Native*, uint> )(lpVtbl[1]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.EnableDebugLayer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void EnableDebugLayer()
        {
            ((delegate* unmanaged<ID3D12Debug1.Native*, void> )(lpVtbl[3]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Debug1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12Debug1.Native*, uint> )(lpVtbl[2]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableGPUBasedValidation"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            ((delegate* unmanaged<ID3D12Debug1.Native*, MaybeBool<int>, void> )(lpVtbl[4]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this), Enable);
        }

        /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableSynchronizedCommandQueueValidation"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            ((delegate* unmanaged<ID3D12Debug1.Native*, MaybeBool<int>, void> )(lpVtbl[5]))((ID3D12Debug1.Native*)Unsafe.AsPointer(ref this), Enable);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug1(Ptr3D vtbl) => LpVtbl = (ID3D12Debug1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug1(Ptr<ID3D12Debug1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Debug1.Native"/> to <see cref = "ID3D12Debug1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Debug1(ID3D12Debug1.Native* value) => new ID3D12Debug1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Debug1"/> to <see cref = "ID3D12Debug1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1"/> instance to be converted </param>
    public static implicit operator ID3D12Debug1.Native*(ID3D12Debug1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Debug1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Debug1(Ptr3D value) => new ID3D12Debug1(value);
    /// <summary>casts <see cref = "ID3D12Debug1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Debug1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Debug1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Debug1(Ptr<ID3D12Debug1.Native> value) => new ID3D12Debug1(value);
    /// <summary>casts <see cref = "ID3D12Debug1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Debug1.Native>(ID3D12Debug1 value) => (Ptr<ID3D12Debug1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Debug1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Debug1(void*** value) => new ID3D12Debug1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Debug1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Debug1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Debug1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Debug1(nuint value) => new ID3D12Debug1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Debug1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Debug1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.EnableDebugLayer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer() => LpVtbl->EnableDebugLayer();
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
    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableGPUBasedValidation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->SetEnableGPUBasedValidation(Enable);
    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableSynchronizedCommandQueueValidation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->SetEnableSynchronizedCommandQueueValidation(Enable);
}
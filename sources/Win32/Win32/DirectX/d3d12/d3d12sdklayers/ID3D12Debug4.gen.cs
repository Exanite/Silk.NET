// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Debug4.xml' path='doc/member[@name="ID3D12Debug4"]/*'/>
[Guid("014B816E-9EC5-4A2F-A845-FFBE441CE13A")]
[NativeTypeName("struct ID3D12Debug4 : ID3D12Debug3")]
[NativeInheritance("ID3D12Debug3")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12Debug4 : ID3D12Debug4.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Debug4));

    public interface Interface : ID3D12Debug3.Interface
    {
        [VtblIndex(7)]
        void DisableDebugLayer();
    }

    /// <include file='ID3D12Debug4.xml' path='doc/member[@name="ID3D12Debug4"]/*'/>
    [Guid("014B816E-9EC5-4A2F-A845-FFBE441CE13A")]
    [NativeTypeName("struct ID3D12Debug4 : ID3D12Debug3")]
    [NativeInheritance("ID3D12Debug3")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Debug4));

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
            [NativeTypeName("void (D3D12_GPU_BASED_VALIDATION_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12GpuBasedValidationFlags, void> SetGPUBasedValidationFlags;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> DisableDebugLayer;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Debug4.Native*, uint> )(lpVtbl[1]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Debug4.xml' path='doc/member[@name="ID3D12Debug4.DisableDebugLayer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void DisableDebugLayer()
        {
            ((delegate* unmanaged<ID3D12Debug4.Native*, void> )(lpVtbl[7]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Debug.EnableDebugLayer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void EnableDebugLayer()
        {
            ((delegate* unmanaged<ID3D12Debug4.Native*, void> )(lpVtbl[3]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Debug4.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12Debug4.Native*, uint> )(lpVtbl[2]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Debug3.SetEnableGPUBasedValidation"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            ((delegate* unmanaged<ID3D12Debug4.Native*, MaybeBool<int>, void> )(lpVtbl[4]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this), Enable);
        }

        /// <inheritdoc cref = "ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            ((delegate* unmanaged<ID3D12Debug4.Native*, MaybeBool<int>, void> )(lpVtbl[5]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this), Enable);
        }

        /// <inheritdoc cref = "ID3D12Debug3.SetGPUBasedValidationFlags"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetGPUBasedValidationFlags(D3D12GpuBasedValidationFlags Flags)
        {
            ((delegate* unmanaged<ID3D12Debug4.Native*, D3D12GpuBasedValidationFlags, void> )(lpVtbl[6]))((ID3D12Debug4.Native*)Unsafe.AsPointer(ref this), Flags);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug4(Ptr3D vtbl) => LpVtbl = (ID3D12Debug4.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug4(Ptr<ID3D12Debug4.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Debug4.Native"/> to <see cref = "ID3D12Debug4"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Debug4(ID3D12Debug4.Native* value) => new ID3D12Debug4((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Debug4"/> to <see cref = "ID3D12Debug4.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4"/> instance to be converted </param>
    public static implicit operator ID3D12Debug4.Native*(ID3D12Debug4 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Debug4"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Debug4(Ptr3D value) => new ID3D12Debug4(value);
    /// <summary>casts <see cref = "ID3D12Debug4"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Debug4 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Debug4"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Debug4(Ptr<ID3D12Debug4.Native> value) => new ID3D12Debug4(value);
    /// <summary>casts <see cref = "ID3D12Debug4"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Debug4.Native>(ID3D12Debug4 value) => (Ptr<ID3D12Debug4.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Debug4"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Debug4(void*** value) => new ID3D12Debug4((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Debug4"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Debug4 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Debug4"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Debug4(nuint value) => new ID3D12Debug4((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Debug4"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug4"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Debug4 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12Debug4.xml' path='doc/member[@name="ID3D12Debug4.DisableDebugLayer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void DisableDebugLayer() => LpVtbl->DisableDebugLayer();
    /// <inheritdoc cref = "ID3D12Debug.EnableDebugLayer"/>
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
    /// <inheritdoc cref = "ID3D12Debug3.SetEnableGPUBasedValidation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->SetEnableGPUBasedValidation(Enable);
    /// <inheritdoc cref = "ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->SetEnableSynchronizedCommandQueueValidation(Enable);
    /// <inheritdoc cref = "ID3D12Debug3.SetGPUBasedValidationFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetGPUBasedValidationFlags(D3D12GpuBasedValidationFlags Flags) => LpVtbl->SetGPUBasedValidationFlags(Flags);
}
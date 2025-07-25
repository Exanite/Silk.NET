// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties"]/*'/>
[Guid("DE5FA827-9BF9-4F26-89FF-D7F56FDE3860")]
[NativeTypeName("struct ID3D12StateObjectProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12StateObjectProperties : ID3D12StateObjectProperties.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12StateObjectProperties));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        [return: NativeTypeName("UINT64")]
        ulong GetPipelineStackSize();
        [VtblIndex(3)]
        void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        Ptr GetShaderIdentifier([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName);
        [VtblIndex(4)]
        [return: NativeTypeName("UINT64")]
        ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName);
        [VtblIndex(4)]
        [return: NativeTypeName("UINT64")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName);
        [VtblIndex(6)]
        void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes);
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties"]/*'/>
    [Guid("DE5FA827-9BF9-4F26-89FF-D7F56FDE3860")]
    [NativeTypeName("struct ID3D12StateObjectProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12StateObjectProperties));

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
            [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, void*> GetShaderIdentifier;
            [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, ulong> GetShaderStackSize;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetPipelineStackSize;
            [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, void> SetPipelineStackSize;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, uint> )(lpVtbl[1]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetPipelineStackSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("UINT64")]
        public ulong GetPipelineStackSize()
        {
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, ulong> )(lpVtbl[5]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderIdentifier"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, ushort*, void*> )(lpVtbl[3]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this), pExportName);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr GetShaderIdentifier([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName)
        {
            fixed (ushort* __dsl_pExportName = pExportName)
            {
                return (void*)GetShaderIdentifier(__dsl_pExportName);
            }
        }

        /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderStackSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("UINT64")]
        public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, ushort*, ulong> )(lpVtbl[4]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this), pExportName);
        }

        [VtblIndex(4)]
        [return: NativeTypeName("UINT64")]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName)
        {
            fixed (ushort* __dsl_pExportName = pExportName)
            {
                return (ulong)GetShaderStackSize(__dsl_pExportName);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, uint> )(lpVtbl[2]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.SetPipelineStackSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
        {
            ((delegate* unmanaged<ID3D12StateObjectProperties.Native*, ulong, void> )(lpVtbl[6]))((ID3D12StateObjectProperties.Native*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12StateObjectProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12StateObjectProperties(Ptr3D vtbl) => LpVtbl = (ID3D12StateObjectProperties.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12StateObjectProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12StateObjectProperties(Ptr<ID3D12StateObjectProperties.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12StateObjectProperties.Native"/> to <see cref = "ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties.Native"/> instance to be converted </param>
    public static implicit operator ID3D12StateObjectProperties(ID3D12StateObjectProperties.Native* value) => new ID3D12StateObjectProperties((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12StateObjectProperties"/> to <see cref = "ID3D12StateObjectProperties.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties"/> instance to be converted </param>
    public static implicit operator ID3D12StateObjectProperties.Native*(ID3D12StateObjectProperties value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties(Ptr3D value) => new ID3D12StateObjectProperties(value);
    /// <summary>casts <see cref = "ID3D12StateObjectProperties"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12StateObjectProperties value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties(Ptr<ID3D12StateObjectProperties.Native> value) => new ID3D12StateObjectProperties(value);
    /// <summary>casts <see cref = "ID3D12StateObjectProperties"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12StateObjectProperties.Native>(ID3D12StateObjectProperties value) => (Ptr<ID3D12StateObjectProperties.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties(void*** value) => new ID3D12StateObjectProperties((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12StateObjectProperties"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties"/> instance to be converted </param>
    public static implicit operator void***(ID3D12StateObjectProperties value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties(nuint value) => new ID3D12StateObjectProperties((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12StateObjectProperties"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12StateObjectProperties value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetPipelineStackSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPipelineStackSize() => LpVtbl->GetPipelineStackSize();
    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderIdentifier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName) => LpVtbl->GetShaderIdentifier(pExportName);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr GetShaderIdentifier([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName)
    {
        fixed (ushort* __dsl_pExportName = pExportName)
        {
            return (void*)GetShaderIdentifier(__dsl_pExportName);
        }
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderStackSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT64")]
    public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName) => LpVtbl->GetShaderStackSize(pExportName);
    [VtblIndex(4)]
    [return: NativeTypeName("UINT64")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] Ref<ushort> pExportName)
    {
        fixed (ushort* __dsl_pExportName = pExportName)
        {
            return (ulong)GetShaderStackSize(__dsl_pExportName);
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
    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.SetPipelineStackSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes) => LpVtbl->SetPipelineStackSize(PipelineStackSizeInBytes);
}
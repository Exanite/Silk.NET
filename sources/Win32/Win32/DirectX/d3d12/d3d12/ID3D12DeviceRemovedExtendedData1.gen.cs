// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1"]/*'/>
[Guid("9727A022-CF1D-4DDA-9EBA-EFFA653FC506")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData")]
[NativeInheritance("ID3D12DeviceRemovedExtendedData")]
public unsafe partial struct ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceRemovedExtendedData1));

    public interface Interface : ID3D12DeviceRemovedExtendedData.Interface
    {
        [VtblIndex(5)]
        HResult GetAutoBreadcrumbsOutput1(D3D12DredAutoBreadcrumbsOutput1* pOutput);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetAutoBreadcrumbsOutput1(Ref<D3D12DredAutoBreadcrumbsOutput1> pOutput);
        [VtblIndex(6)]
        HResult GetPageFaultAllocationOutput1(D3D12DredPageFaultOutput1* pOutput);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPageFaultAllocationOutput1(Ref<D3D12DredPageFaultOutput1> pOutput);
    }

    /// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1"]/*'/>
    [Guid("9727A022-CF1D-4DDA-9EBA-EFFA653FC506")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData")]
    [NativeInheritance("ID3D12DeviceRemovedExtendedData")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceRemovedExtendedData1));

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
            [NativeTypeName("HRESULT (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredAutoBreadcrumbsOutput*, HResult> GetAutoBreadcrumbsOutput;
            [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredPageFaultOutput*, HResult> GetPageFaultAllocationOutput;
            [NativeTypeName("HRESULT (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredAutoBreadcrumbsOutput1*, HResult> GetAutoBreadcrumbsOutput1;
            [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT1 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DredPageFaultOutput1*, HResult> GetPageFaultAllocationOutput1;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, uint> )(lpVtbl[1]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetAutoBreadcrumbsOutput"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetAutoBreadcrumbsOutput(D3D12DredAutoBreadcrumbsOutput* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, D3D12DredAutoBreadcrumbsOutput*, HResult> )(lpVtbl[3]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this), pOutput);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAutoBreadcrumbsOutput(Ref<D3D12DredAutoBreadcrumbsOutput> pOutput)
        {
            fixed (D3D12DredAutoBreadcrumbsOutput* __dsl_pOutput = pOutput)
            {
                return (HResult)GetAutoBreadcrumbsOutput(__dsl_pOutput);
            }
        }

        /// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1.GetAutoBreadcrumbsOutput1"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetAutoBreadcrumbsOutput1(D3D12DredAutoBreadcrumbsOutput1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, D3D12DredAutoBreadcrumbsOutput1*, HResult> )(lpVtbl[5]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this), pOutput);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAutoBreadcrumbsOutput1(Ref<D3D12DredAutoBreadcrumbsOutput1> pOutput)
        {
            fixed (D3D12DredAutoBreadcrumbsOutput1* __dsl_pOutput = pOutput)
            {
                return (HResult)GetAutoBreadcrumbsOutput1(__dsl_pOutput);
            }
        }

        /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetPageFaultAllocationOutput"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetPageFaultAllocationOutput(D3D12DredPageFaultOutput* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, D3D12DredPageFaultOutput*, HResult> )(lpVtbl[4]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this), pOutput);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPageFaultAllocationOutput(Ref<D3D12DredPageFaultOutput> pOutput)
        {
            fixed (D3D12DredPageFaultOutput* __dsl_pOutput = pOutput)
            {
                return (HResult)GetPageFaultAllocationOutput(__dsl_pOutput);
            }
        }

        /// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1.GetPageFaultAllocationOutput1"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetPageFaultAllocationOutput1(D3D12DredPageFaultOutput1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, D3D12DredPageFaultOutput1*, HResult> )(lpVtbl[6]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this), pOutput);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPageFaultAllocationOutput1(Ref<D3D12DredPageFaultOutput1> pOutput)
        {
            fixed (D3D12DredPageFaultOutput1* __dsl_pOutput = pOutput)
            {
                return (HResult)GetPageFaultAllocationOutput1(__dsl_pOutput);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1.Native*, uint> )(lpVtbl[2]))((ID3D12DeviceRemovedExtendedData1.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedData1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedData1(Ptr3D vtbl) => LpVtbl = (ID3D12DeviceRemovedExtendedData1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedData1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedData1(Ptr<ID3D12DeviceRemovedExtendedData1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1.Native"/> to <see cref = "ID3D12DeviceRemovedExtendedData1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceRemovedExtendedData1(ID3D12DeviceRemovedExtendedData1.Native* value) => new ID3D12DeviceRemovedExtendedData1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1"/> to <see cref = "ID3D12DeviceRemovedExtendedData1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceRemovedExtendedData1.Native*(ID3D12DeviceRemovedExtendedData1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DeviceRemovedExtendedData1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedData1(Ptr3D value) => new ID3D12DeviceRemovedExtendedData1(value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DeviceRemovedExtendedData1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DeviceRemovedExtendedData1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedData1(Ptr<ID3D12DeviceRemovedExtendedData1.Native> value) => new ID3D12DeviceRemovedExtendedData1(value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DeviceRemovedExtendedData1.Native>(ID3D12DeviceRemovedExtendedData1 value) => (Ptr<ID3D12DeviceRemovedExtendedData1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DeviceRemovedExtendedData1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedData1(void*** value) => new ID3D12DeviceRemovedExtendedData1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DeviceRemovedExtendedData1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DeviceRemovedExtendedData1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedData1(nuint value) => new ID3D12DeviceRemovedExtendedData1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DeviceRemovedExtendedData1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedData1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DeviceRemovedExtendedData1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetAutoBreadcrumbsOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetAutoBreadcrumbsOutput(D3D12DredAutoBreadcrumbsOutput* pOutput) => LpVtbl->GetAutoBreadcrumbsOutput(pOutput);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAutoBreadcrumbsOutput(Ref<D3D12DredAutoBreadcrumbsOutput> pOutput)
    {
        fixed (D3D12DredAutoBreadcrumbsOutput* __dsl_pOutput = pOutput)
        {
            return (HResult)GetAutoBreadcrumbsOutput(__dsl_pOutput);
        }
    }

    /// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1.GetAutoBreadcrumbsOutput1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetAutoBreadcrumbsOutput1(D3D12DredAutoBreadcrumbsOutput1* pOutput) => LpVtbl->GetAutoBreadcrumbsOutput1(pOutput);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAutoBreadcrumbsOutput1(Ref<D3D12DredAutoBreadcrumbsOutput1> pOutput)
    {
        fixed (D3D12DredAutoBreadcrumbsOutput1* __dsl_pOutput = pOutput)
        {
            return (HResult)GetAutoBreadcrumbsOutput1(__dsl_pOutput);
        }
    }

    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetPageFaultAllocationOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetPageFaultAllocationOutput(D3D12DredPageFaultOutput* pOutput) => LpVtbl->GetPageFaultAllocationOutput(pOutput);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPageFaultAllocationOutput(Ref<D3D12DredPageFaultOutput> pOutput)
    {
        fixed (D3D12DredPageFaultOutput* __dsl_pOutput = pOutput)
        {
            return (HResult)GetPageFaultAllocationOutput(__dsl_pOutput);
        }
    }

    /// <include file='ID3D12DeviceRemovedExtendedData1.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData1.GetPageFaultAllocationOutput1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetPageFaultAllocationOutput1(D3D12DredPageFaultOutput1* pOutput) => LpVtbl->GetPageFaultAllocationOutput1(pOutput);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPageFaultAllocationOutput1(Ref<D3D12DredPageFaultOutput1> pOutput)
    {
        fixed (D3D12DredPageFaultOutput1* __dsl_pOutput = pOutput)
        {
            return (HResult)GetPageFaultAllocationOutput1(__dsl_pOutput);
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
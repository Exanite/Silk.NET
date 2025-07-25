// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1"]/*'/>
[Guid("A0884F9A-D2BE-4355-AA5D-5901281AD1D2")]
[NativeTypeName("struct IDMLDevice1 : IDMLDevice")]
[NativeInheritance("IDMLDevice")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDMLDevice1 : IDMLDevice1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLDevice1));

    public interface Interface : IDMLDevice.Interface
    {
        [VtblIndex(17)]
        HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] DmlGraphDesc* desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(17)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] Ref<DmlGraphDesc> desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv);
    }

    /// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1"]/*'/>
    [Guid("A0884F9A-D2BE-4355-AA5D-5901281AD1D2")]
    [NativeTypeName("struct IDMLDevice1 : IDMLDevice")]
    [NativeInheritance("IDMLDevice")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLDevice1));

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
            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, IUnknown.Native*, HResult> SetPrivateDataInterface;
            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, HResult> SetName;
            [NativeTypeName("HRESULT (DML_FEATURE, UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlFeature, uint, void*, uint, void*, HResult> CheckFeatureSupport;
            [NativeTypeName("HRESULT (const DML_OPERATOR_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlOperatorDesc*, Guid*, void**, HResult> CreateOperator;
            [NativeTypeName("HRESULT (IDMLOperator *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDMLOperator.Native*, DmlExecutionFlags, Guid*, void**, HResult> CompileOperator;
            [NativeTypeName("HRESULT (UINT, IDMLCompiledOperator *const *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDMLCompiledOperator.Native**, Guid*, void**, HResult> CreateOperatorInitializer;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> CreateCommandRecorder;
            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlBindingTableDesc*, Guid*, void**, HResult> CreateBindingTable;
            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDMLPageable.Native**, HResult> Evict;
            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDMLPageable.Native**, HResult> MakeResident;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> GetDeviceRemovedReason;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetParentDevice;
            [NativeTypeName("HRESULT (const DML_GRAPH_DESC *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlGraphDesc*, DmlExecutionFlags, Guid*, void**, HResult> CompileGraph;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, uint> )(lpVtbl[1]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDMLDevice.CheckFeatureSupport"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult CheckFeatureSupport(DmlFeature feature, uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, uint featureSupportDataSize, void* featureSupportData)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, DmlFeature, uint, void*, uint, void*, HResult> )(lpVtbl[7]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckFeatureSupport(DmlFeature feature, uint featureQueryDataSize, [NativeTypeName("const void *")] Ref featureQueryData, uint featureSupportDataSize, Ref featureSupportData)
        {
            fixed (void* __dsl_featureSupportData = featureSupportData)
            fixed (void* __dsl_featureQueryData = featureQueryData)
            {
                return (HResult)CheckFeatureSupport(feature, featureQueryDataSize, __dsl_featureQueryData, featureSupportDataSize, __dsl_featureSupportData);
            }
        }

        /// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1.CompileGraph"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] DmlGraphDesc* desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, DmlGraphDesc*, DmlExecutionFlags, Guid*, void**, HResult> )(lpVtbl[17]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), desc, flags, riid, ppv);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] Ref<DmlGraphDesc> desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            fixed (DmlGraphDesc* __dsl_desc = desc)
            {
                return (HResult)CompileGraph(__dsl_desc, flags, __dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CompileGraph<TCom>([NativeTypeName("const DML_GRAPH_DESC *")] Ref<DmlGraphDesc> desc, DmlExecutionFlags flags, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            fixed (DmlGraphDesc* __dsl_desc = desc)
            {
                ppv = default;
                return CompileGraph(__dsl_desc, flags, TCom.NativeGuid, ppv.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IDMLDevice.CompileOperator"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CompileOperator(IDMLOperator op, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, IDMLOperator.Native*, DmlExecutionFlags, Guid*, void**, HResult> )(lpVtbl[9]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), op.LpVtbl, flags, riid, ppv);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CompileOperator(IDMLOperator op, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CompileOperator(op, flags, __dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        public HResult CompileOperator<TCom>(IDMLOperator op, DmlExecutionFlags flags, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            ppv = default;
            return CompileOperator(op, flags, TCom.NativeGuid, ppv.GetAddressOf());
        }

        /// <inheritdoc cref = "IDMLDevice.CreateBindingTable"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DmlBindingTableDesc* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, DmlBindingTableDesc*, Guid*, void**, HResult> )(lpVtbl[12]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            fixed (DmlBindingTableDesc* __dsl_desc = desc)
            {
                return (HResult)CreateBindingTable(__dsl_desc, __dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateBindingTable<TCom>([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            fixed (DmlBindingTableDesc* __dsl_desc = desc)
            {
                ppv = default;
                return CreateBindingTable(__dsl_desc, TCom.NativeGuid, ppv.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IDMLDevice.CreateCommandRecorder"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, void**, HResult> )(lpVtbl[11]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandRecorder([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateCommandRecorder(__dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(11)]
        [Transformed]
        public HResult CreateCommandRecorder<TCom>(out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            ppv = default;
            return CreateCommandRecorder(TCom.NativeGuid, ppv.GetAddressOf());
        }

        /// <inheritdoc cref = "IDMLDevice.CreateOperator"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DmlOperatorDesc* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, DmlOperatorDesc*, Guid*, void**, HResult> )(lpVtbl[8]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] Ref<DmlOperatorDesc> desc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            fixed (DmlOperatorDesc* __dsl_desc = desc)
            {
                return (HResult)CreateOperator(__dsl_desc, __dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOperator<TCom>([NativeTypeName("const DML_OPERATOR_DESC *")] Ref<DmlOperatorDesc> desc, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            fixed (DmlOperatorDesc* __dsl_desc = desc)
            {
                ppv = default;
                return CreateOperator(__dsl_desc, TCom.NativeGuid, ppv.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IDMLDevice.CreateOperatorInitializer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CreateOperatorInitializer(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator* operators, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, uint, IDMLCompiledOperator.Native**, Guid*, void**, HResult> )(lpVtbl[10]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), operatorCount, &operators->LpVtbl, riid, ppv);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOperatorInitializer(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] Ref<IDMLCompiledOperator> operators, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            fixed (IDMLCompiledOperator* __dsl_operators = operators)
            {
                return (HResult)CreateOperatorInitializer(operatorCount, __dsl_operators, __dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOperatorInitializer<TCom>(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] Ref<IDMLCompiledOperator> operators, out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            fixed (IDMLCompiledOperator* __dsl_operators = operators)
            {
                ppv = default;
                return CreateOperatorInitializer(operatorCount, __dsl_operators, TCom.NativeGuid, ppv.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IDMLDevice.Evict"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult Evict(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable* ppObjects)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, uint, IDMLPageable.Native**, HResult> )(lpVtbl[13]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), count, &ppObjects->LpVtbl);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Evict(uint count, [NativeTypeName("IDMLPageable *const *")] Ref<IDMLPageable> ppObjects)
        {
            fixed (IDMLPageable* __dsl_ppObjects = ppObjects)
            {
                return (HResult)Evict(count, __dsl_ppObjects);
            }
        }

        /// <inheritdoc cref = "IDMLDevice.GetDeviceRemovedReason"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, HResult> )(lpVtbl[15]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDMLDevice.GetParentDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult GetParentDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, void**, HResult> )(lpVtbl[16]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetParentDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetParentDevice(__dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(16)]
        [Transformed]
        public HResult GetParentDevice<TCom>(out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            ppv = default;
            return GetParentDevice(TCom.NativeGuid, ppv.GetAddressOf());
        }

        /// <inheritdoc cref = "IDMLObject.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> dataSize, Ref data)
        {
            fixed (void* __dsl_data = data)
            fixed (uint* __dsl_dataSize = dataSize)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)GetPrivateData(__dsl_guid, __dsl_dataSize, __dsl_data);
            }
        }

        /// <inheritdoc cref = "IDMLDevice.MakeResident"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult MakeResident(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable* ppObjects)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, uint, IDMLPageable.Native**, HResult> )(lpVtbl[14]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), count, &ppObjects->LpVtbl);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult MakeResident(uint count, [NativeTypeName("IDMLPageable *const *")] Ref<IDMLPageable> ppObjects)
        {
            fixed (IDMLPageable* __dsl_ppObjects = ppObjects)
            {
                return (HResult)MakeResident(count, __dsl_ppObjects);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDMLDevice1.Native*, uint> )(lpVtbl[2]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDMLObject.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, ushort*, HResult> )(lpVtbl[6]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), name);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetName([NativeTypeName("PCWSTR")] Ref<ushort> name)
        {
            fixed (ushort* __dsl_name = name)
            {
                return (HResult)SetName(__dsl_name);
            }
        }

        /// <inheritdoc cref = "IDMLObject.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint dataSize, [NativeTypeName("const void *")] Ref data)
        {
            fixed (void* __dsl_data = data)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateData(__dsl_guid, dataSize, __dsl_data);
            }
        }

        /// <inheritdoc cref = "IDMLObject.SetPrivateDataInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown data)
        {
            return ((delegate* unmanaged<IDMLDevice1.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((IDMLDevice1.Native*)Unsafe.AsPointer(ref this), guid, data.lpVtbl);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, IUnknown data)
        {
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateDataInterface(__dsl_guid, data);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMLDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLDevice1(Ptr3D vtbl) => LpVtbl = (IDMLDevice1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDMLDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLDevice1(Ptr<IDMLDevice1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDMLDevice1.Native"/> to <see cref = "IDMLDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1.Native"/> instance to be converted </param>
    public static implicit operator IDMLDevice1(IDMLDevice1.Native* value) => new IDMLDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLDevice1"/> to <see cref = "IDMLDevice1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1"/> instance to be converted </param>
    public static implicit operator IDMLDevice1.Native*(IDMLDevice1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDMLDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDMLDevice1(Ptr3D value) => new IDMLDevice1(value);
    /// <summary>casts <see cref = "IDMLDevice1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDMLDevice1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDMLDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDMLDevice1(Ptr<IDMLDevice1.Native> value) => new IDMLDevice1(value);
    /// <summary>casts <see cref = "IDMLDevice1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1"/> instance to be converted </param>
    public static implicit operator Ptr<IDMLDevice1.Native>(IDMLDevice1 value) => (Ptr<IDMLDevice1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDMLDevice1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDMLDevice1(void*** value) => new IDMLDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLDevice1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1"/> instance to be converted </param>
    public static implicit operator void***(IDMLDevice1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDMLDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDMLDevice1(nuint value) => new IDMLDevice1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDMLDevice1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDevice1"/> instance to be converted </param>
    public static implicit operator nuint(IDMLDevice1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDMLDevice.CheckFeatureSupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult CheckFeatureSupport(DmlFeature feature, uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, uint featureSupportDataSize, void* featureSupportData) => LpVtbl->CheckFeatureSupport(feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckFeatureSupport(DmlFeature feature, uint featureQueryDataSize, [NativeTypeName("const void *")] Ref featureQueryData, uint featureSupportDataSize, Ref featureSupportData)
    {
        fixed (void* __dsl_featureSupportData = featureSupportData)
        fixed (void* __dsl_featureQueryData = featureQueryData)
        {
            return (HResult)CheckFeatureSupport(feature, featureQueryDataSize, __dsl_featureQueryData, featureSupportDataSize, __dsl_featureSupportData);
        }
    }

    /// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1.CompileGraph"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] DmlGraphDesc* desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CompileGraph(desc, flags, riid, ppv);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] Ref<DmlGraphDesc> desc, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (DmlGraphDesc* __dsl_desc = desc)
        {
            return (HResult)CompileGraph(__dsl_desc, flags, __dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CompileGraph<TCom>([NativeTypeName("const DML_GRAPH_DESC *")] Ref<DmlGraphDesc> desc, DmlExecutionFlags flags, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        fixed (DmlGraphDesc* __dsl_desc = desc)
        {
            ppv = default;
            return CompileGraph(__dsl_desc, flags, TCom.NativeGuid, ppv.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "IDMLDevice.CompileOperator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CompileOperator(IDMLOperator op, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CompileOperator(op, flags, riid, ppv);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CompileOperator(IDMLOperator op, DmlExecutionFlags flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CompileOperator(op, flags, __dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    public HResult CompileOperator<TCom>(IDMLOperator op, DmlExecutionFlags flags, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return CompileOperator(op, flags, TCom.NativeGuid, ppv.GetAddressOf());
    }

    /// <inheritdoc cref = "IDMLDevice.CreateBindingTable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DmlBindingTableDesc* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CreateBindingTable(desc, riid, ppv);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (DmlBindingTableDesc* __dsl_desc = desc)
        {
            return (HResult)CreateBindingTable(__dsl_desc, __dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateBindingTable<TCom>([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        fixed (DmlBindingTableDesc* __dsl_desc = desc)
        {
            ppv = default;
            return CreateBindingTable(__dsl_desc, TCom.NativeGuid, ppv.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "IDMLDevice.CreateCommandRecorder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CreateCommandRecorder(riid, ppv);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandRecorder([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateCommandRecorder(__dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(11)]
    [Transformed]
    public HResult CreateCommandRecorder<TCom>(out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return CreateCommandRecorder(TCom.NativeGuid, ppv.GetAddressOf());
    }

    /// <inheritdoc cref = "IDMLDevice.CreateOperator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DmlOperatorDesc* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CreateOperator(desc, riid, ppv);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] Ref<DmlOperatorDesc> desc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (DmlOperatorDesc* __dsl_desc = desc)
        {
            return (HResult)CreateOperator(__dsl_desc, __dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOperator<TCom>([NativeTypeName("const DML_OPERATOR_DESC *")] Ref<DmlOperatorDesc> desc, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        fixed (DmlOperatorDesc* __dsl_desc = desc)
        {
            ppv = default;
            return CreateOperator(__dsl_desc, TCom.NativeGuid, ppv.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "IDMLDevice.CreateOperatorInitializer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CreateOperatorInitializer(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator* operators, [NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->CreateOperatorInitializer(operatorCount, operators, riid, ppv);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOperatorInitializer(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] Ref<IDMLCompiledOperator> operators, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (IDMLCompiledOperator* __dsl_operators = operators)
        {
            return (HResult)CreateOperatorInitializer(operatorCount, __dsl_operators, __dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOperatorInitializer<TCom>(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] Ref<IDMLCompiledOperator> operators, out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        fixed (IDMLCompiledOperator* __dsl_operators = operators)
        {
            ppv = default;
            return CreateOperatorInitializer(operatorCount, __dsl_operators, TCom.NativeGuid, ppv.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "IDMLDevice.Evict"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult Evict(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable* ppObjects) => LpVtbl->Evict(count, ppObjects);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Evict(uint count, [NativeTypeName("IDMLPageable *const *")] Ref<IDMLPageable> ppObjects)
    {
        fixed (IDMLPageable* __dsl_ppObjects = ppObjects)
        {
            return (HResult)Evict(count, __dsl_ppObjects);
        }
    }

    /// <inheritdoc cref = "IDMLDevice.GetDeviceRemovedReason"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult GetDeviceRemovedReason() => LpVtbl->GetDeviceRemovedReason();
    /// <inheritdoc cref = "IDMLDevice.GetParentDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult GetParentDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->GetParentDevice(riid, ppv);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetParentDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetParentDevice(__dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(16)]
    [Transformed]
    public HResult GetParentDevice<TCom>(out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return GetParentDevice(TCom.NativeGuid, ppv.GetAddressOf());
    }

    /// <inheritdoc cref = "IDMLObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data) => LpVtbl->GetPrivateData(guid, dataSize, data);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> dataSize, Ref data)
    {
        fixed (void* __dsl_data = data)
        fixed (uint* __dsl_dataSize = dataSize)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)GetPrivateData(__dsl_guid, __dsl_dataSize, __dsl_data);
        }
    }

    /// <inheritdoc cref = "IDMLDevice.MakeResident"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult MakeResident(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable* ppObjects) => LpVtbl->MakeResident(count, ppObjects);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult MakeResident(uint count, [NativeTypeName("IDMLPageable *const *")] Ref<IDMLPageable> ppObjects)
    {
        fixed (IDMLPageable* __dsl_ppObjects = ppObjects)
        {
            return (HResult)MakeResident(count, __dsl_ppObjects);
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
    /// <inheritdoc cref = "IDMLObject.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetName([NativeTypeName("PCWSTR")] ushort* name) => LpVtbl->SetName(name);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetName([NativeTypeName("PCWSTR")] Ref<ushort> name)
    {
        fixed (ushort* __dsl_name = name)
        {
            return (HResult)SetName(__dsl_name);
        }
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data) => LpVtbl->SetPrivateData(guid, dataSize, data);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint dataSize, [NativeTypeName("const void *")] Ref data)
    {
        fixed (void* __dsl_data = data)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateData(__dsl_guid, dataSize, __dsl_data);
        }
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown data) => LpVtbl->SetPrivateDataInterface(guid, data);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, IUnknown data)
    {
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateDataInterface(__dsl_guid, data);
        }
    }
}
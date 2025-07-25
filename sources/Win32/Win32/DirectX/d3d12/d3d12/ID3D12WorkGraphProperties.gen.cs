// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties"]/*'/>
[Guid("065ACF71-F863-4B89-82F4-02E4D5886757")]
[NativeTypeName("struct ID3D12WorkGraphProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12WorkGraphProperties : ID3D12WorkGraphProperties.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12WorkGraphProperties));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(11)]
        D3D12NodeId GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);
        [VtblIndex(12)]
        uint GetEntrypointIndex(uint WorkGraphIndex, D3D12NodeId NodeID);
        [VtblIndex(15)]
        uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex);
        [VtblIndex(13)]
        uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);
        [VtblIndex(7)]
        D3D12NodeId GetNodeID(uint WorkGraphIndex, uint NodeIndex);
        [VtblIndex(8)]
        uint GetNodeIndex(uint WorkGraphIndex, D3D12NodeId NodeID);
        [VtblIndex(9)]
        uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);
        [VtblIndex(10)]
        uint GetNumEntrypoints(uint WorkGraphIndex);
        [VtblIndex(6)]
        uint GetNumNodes(uint WorkGraphIndex);
        [VtblIndex(3)]
        uint GetNumWorkGraphs();
        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        Ptr<ushort> GetProgramName(uint WorkGraphIndex);
        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        ushort* GetProgramNameRaw(uint WorkGraphIndex);
        [VtblIndex(5)]
        uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] ushort* pProgramName);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] Ref<ushort> pProgramName);
        [VtblIndex(14)]
        void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, D3D12WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements);
        [VtblIndex(14)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, Ref<D3D12WorkGraphMemoryRequirements> pWorkGraphMemoryRequirements);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties"]/*'/>
    [Guid("065ACF71-F863-4B89-82F4-02E4D5886757")]
    [NativeTypeName("struct ID3D12WorkGraphProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12WorkGraphProperties));

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
            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetNumWorkGraphs;
            [NativeTypeName("LPCWSTR (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ushort*> GetProgramName;
            [NativeTypeName("UINT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, uint> GetWorkGraphIndex;
            [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint> GetNumNodes;
            [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12NodeId*, uint, uint, D3D12NodeId*> GetNodeID;
            [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12NodeId, uint> GetNodeIndex;
            [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint> GetNodeLocalRootArgumentsTableIndex;
            [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint> GetNumEntrypoints;
            [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12NodeId*, uint, uint, D3D12NodeId*> GetEntrypointID;
            [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12NodeId, uint> GetEntrypointIndex;
            [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint> GetEntrypointRecordSizeInBytes;
            [NativeTypeName("void (UINT, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12WorkGraphMemoryRequirements*, void> GetWorkGraphMemoryRequirements;
            [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint> GetEntrypointRecordAlignmentInBytes;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint> )(lpVtbl[1]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointID"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public D3D12NodeId GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex)
        {
            D3D12NodeId result;
            return *((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, D3D12NodeId*, uint, uint, D3D12NodeId*> )(lpVtbl[11]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), &result, WorkGraphIndex, EntrypointIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public uint GetEntrypointIndex(uint WorkGraphIndex, D3D12NodeId NodeID)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, D3D12NodeId, uint> )(lpVtbl[12]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordAlignmentInBytes"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, uint, uint> )(lpVtbl[15]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordSizeInBytes"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, uint, uint> )(lpVtbl[13]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeID"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public D3D12NodeId GetNodeID(uint WorkGraphIndex, uint NodeIndex)
        {
            D3D12NodeId result;
            return *((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, D3D12NodeId*, uint, uint, D3D12NodeId*> )(lpVtbl[7]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), &result, WorkGraphIndex, NodeIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public uint GetNodeIndex(uint WorkGraphIndex, D3D12NodeId NodeID)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, D3D12NodeId, uint> )(lpVtbl[8]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeLocalRootArgumentsTableIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, uint, uint> )(lpVtbl[9]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumEntrypoints"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public uint GetNumEntrypoints(uint WorkGraphIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, uint> )(lpVtbl[10]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumNodes"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public uint GetNumNodes(uint WorkGraphIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, uint> )(lpVtbl[6]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumWorkGraphs"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public uint GetNumWorkGraphs()
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint> )(lpVtbl[3]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this));
        }

        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr<ushort> GetProgramName(uint WorkGraphIndex) => (ushort*)GetProgramNameRaw(WorkGraphIndex);
        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetProgramName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        public ushort* GetProgramNameRaw(uint WorkGraphIndex)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, ushort*> )(lpVtbl[4]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex);
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] ushort* pProgramName)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, ushort*, uint> )(lpVtbl[5]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), pProgramName);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] Ref<ushort> pProgramName)
        {
            fixed (ushort* __dsl_pProgramName = pProgramName)
            {
                return (uint)GetWorkGraphIndex(__dsl_pProgramName);
            }
        }

        /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphMemoryRequirements"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, D3D12WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements)
        {
            ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint, D3D12WorkGraphMemoryRequirements*, void> )(lpVtbl[14]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), WorkGraphIndex, pWorkGraphMemoryRequirements);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, Ref<D3D12WorkGraphMemoryRequirements> pWorkGraphMemoryRequirements)
        {
            fixed (D3D12WorkGraphMemoryRequirements* __dsl_pWorkGraphMemoryRequirements = pWorkGraphMemoryRequirements)
            {
                GetWorkGraphMemoryRequirements(WorkGraphIndex, __dsl_pWorkGraphMemoryRequirements);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12WorkGraphProperties.Native*, uint> )(lpVtbl[2]))((ID3D12WorkGraphProperties.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12WorkGraphProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12WorkGraphProperties(Ptr3D vtbl) => LpVtbl = (ID3D12WorkGraphProperties.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12WorkGraphProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12WorkGraphProperties(Ptr<ID3D12WorkGraphProperties.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties.Native"/> to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties.Native"/> instance to be converted </param>
    public static implicit operator ID3D12WorkGraphProperties(ID3D12WorkGraphProperties.Native* value) => new ID3D12WorkGraphProperties((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties"/> to <see cref = "ID3D12WorkGraphProperties.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator ID3D12WorkGraphProperties.Native*(ID3D12WorkGraphProperties value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12WorkGraphProperties(Ptr3D value) => new ID3D12WorkGraphProperties(value);
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12WorkGraphProperties value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12WorkGraphProperties(Ptr<ID3D12WorkGraphProperties.Native> value) => new ID3D12WorkGraphProperties(value);
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12WorkGraphProperties.Native>(ID3D12WorkGraphProperties value) => (Ptr<ID3D12WorkGraphProperties.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12WorkGraphProperties(void*** value) => new ID3D12WorkGraphProperties((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator void***(ID3D12WorkGraphProperties value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12WorkGraphProperties(nuint value) => new ID3D12WorkGraphProperties((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12WorkGraphProperties"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12WorkGraphProperties value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12NodeId GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex) => LpVtbl->GetEntrypointID(WorkGraphIndex, EntrypointIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetEntrypointIndex(uint WorkGraphIndex, D3D12NodeId NodeID) => LpVtbl->GetEntrypointIndex(WorkGraphIndex, NodeID);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordAlignmentInBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex) => LpVtbl->GetEntrypointRecordAlignmentInBytes(WorkGraphIndex, EntrypointIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordSizeInBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex) => LpVtbl->GetEntrypointRecordSizeInBytes(WorkGraphIndex, EntrypointIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12NodeId GetNodeID(uint WorkGraphIndex, uint NodeIndex) => LpVtbl->GetNodeID(WorkGraphIndex, NodeIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeIndex(uint WorkGraphIndex, D3D12NodeId NodeID) => LpVtbl->GetNodeIndex(WorkGraphIndex, NodeID);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeLocalRootArgumentsTableIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex) => LpVtbl->GetNodeLocalRootArgumentsTableIndex(WorkGraphIndex, NodeIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumEntrypoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public uint GetNumEntrypoints(uint WorkGraphIndex) => LpVtbl->GetNumEntrypoints(WorkGraphIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetNumNodes(uint WorkGraphIndex) => LpVtbl->GetNumNodes(WorkGraphIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumWorkGraphs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetNumWorkGraphs() => LpVtbl->GetNumWorkGraphs();
    [VtblIndex(4)]
    [return: NativeTypeName("LPCWSTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr<ushort> GetProgramName(uint WorkGraphIndex) => (ushort*)GetProgramNameRaw(WorkGraphIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetProgramName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("LPCWSTR")]
    public ushort* GetProgramNameRaw(uint WorkGraphIndex) => LpVtbl->GetProgramNameRaw(WorkGraphIndex);
    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] ushort* pProgramName) => LpVtbl->GetWorkGraphIndex(pProgramName);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] Ref<ushort> pProgramName)
    {
        fixed (ushort* __dsl_pProgramName = pProgramName)
        {
            return (uint)GetWorkGraphIndex(__dsl_pProgramName);
        }
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphMemoryRequirements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, D3D12WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements) => LpVtbl->GetWorkGraphMemoryRequirements(WorkGraphIndex, pWorkGraphMemoryRequirements);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, Ref<D3D12WorkGraphMemoryRequirements> pWorkGraphMemoryRequirements)
    {
        fixed (D3D12WorkGraphMemoryRequirements* __dsl_pWorkGraphMemoryRequirements = pWorkGraphMemoryRequirements)
        {
            GetWorkGraphMemoryRequirements(WorkGraphIndex, __dsl_pWorkGraphMemoryRequirements);
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
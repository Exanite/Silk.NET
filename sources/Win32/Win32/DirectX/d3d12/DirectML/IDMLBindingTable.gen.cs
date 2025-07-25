// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable"]/*'/>
[Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
[NativeTypeName("struct IDMLBindingTable : IDMLDeviceChild")]
[NativeInheritance("IDMLDeviceChild")]
public unsafe partial struct IDMLBindingTable : IDMLBindingTable.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLBindingTable));

    public interface Interface : IDMLDeviceChild.Interface
    {
        [VtblIndex(8)]
        void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings);
        [VtblIndex(9)]
        void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings);
        [VtblIndex(11)]
        void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding);
        [VtblIndex(10)]
        void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding);
        [VtblIndex(10)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding);
        [VtblIndex(12)]
        HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DmlBindingTableDesc* desc);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable"]/*'/>
    [Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
    [NativeTypeName("struct IDMLBindingTable : IDMLDeviceChild")]
    [NativeInheritance("IDMLDeviceChild")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLBindingTable));

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
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetDevice;
            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, DmlBindingDesc*, void> BindInputs;
            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, DmlBindingDesc*, void> BindOutputs;
            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlBindingDesc*, void> BindTemporaryResource;
            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlBindingDesc*, void> BindPersistentResource;
            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlBindingTableDesc*, HResult> Reset;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, uint> )(lpVtbl[1]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindInputs"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings)
        {
            ((delegate* unmanaged<IDMLBindingTable.Native*, uint, DmlBindingDesc*, void> )(lpVtbl[8]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings)
        {
            fixed (DmlBindingDesc* __dsl_bindings = bindings)
            {
                BindInputs(bindingCount, __dsl_bindings);
            }
        }

        /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindOutputs"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings)
        {
            ((delegate* unmanaged<IDMLBindingTable.Native*, uint, DmlBindingDesc*, void> )(lpVtbl[9]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings)
        {
            fixed (DmlBindingDesc* __dsl_bindings = bindings)
            {
                BindOutputs(bindingCount, __dsl_bindings);
            }
        }

        /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindPersistentResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding)
        {
            ((delegate* unmanaged<IDMLBindingTable.Native*, DmlBindingDesc*, void> )(lpVtbl[11]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), binding);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding)
        {
            fixed (DmlBindingDesc* __dsl_binding = binding)
            {
                BindPersistentResource(__dsl_binding);
            }
        }

        /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindTemporaryResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding)
        {
            ((delegate* unmanaged<IDMLBindingTable.Native*, DmlBindingDesc*, void> )(lpVtbl[10]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), binding);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding)
        {
            fixed (DmlBindingDesc* __dsl_binding = binding)
            {
                BindTemporaryResource(__dsl_binding);
            }
        }

        /// <inheritdoc cref = "IDMLDeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetDevice(__dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetDevice<TCom>(out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            ppv = default;
            return GetDevice(TCom.NativeGuid, ppv.GetAddressOf());
        }

        /// <inheritdoc cref = "IDMLObject.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDMLBindingTable.Native*, uint> )(lpVtbl[2]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.Reset"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DmlBindingTableDesc* desc)
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, DmlBindingTableDesc*, HResult> )(lpVtbl[12]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), desc);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc)
        {
            fixed (DmlBindingTableDesc* __dsl_desc = desc)
            {
                return (HResult)Reset(__dsl_desc);
            }
        }

        /// <inheritdoc cref = "IDMLObject.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLBindingTable.Native*, ushort*, HResult> )(lpVtbl[6]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), name);
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
            return ((delegate* unmanaged<IDMLBindingTable.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
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
            return ((delegate* unmanaged<IDMLBindingTable.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((IDMLBindingTable.Native*)Unsafe.AsPointer(ref this), guid, data.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "IDMLBindingTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLBindingTable(Ptr3D vtbl) => LpVtbl = (IDMLBindingTable.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDMLBindingTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLBindingTable(Ptr<IDMLBindingTable.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDMLBindingTable.Native"/> to <see cref = "IDMLBindingTable"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable.Native"/> instance to be converted </param>
    public static implicit operator IDMLBindingTable(IDMLBindingTable.Native* value) => new IDMLBindingTable((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLBindingTable"/> to <see cref = "IDMLBindingTable.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable"/> instance to be converted </param>
    public static implicit operator IDMLBindingTable.Native*(IDMLBindingTable value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDMLBindingTable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDMLBindingTable(Ptr3D value) => new IDMLBindingTable(value);
    /// <summary>casts <see cref = "IDMLBindingTable"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDMLBindingTable value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDMLBindingTable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDMLBindingTable(Ptr<IDMLBindingTable.Native> value) => new IDMLBindingTable(value);
    /// <summary>casts <see cref = "IDMLBindingTable"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable"/> instance to be converted </param>
    public static implicit operator Ptr<IDMLBindingTable.Native>(IDMLBindingTable value) => (Ptr<IDMLBindingTable.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDMLBindingTable"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDMLBindingTable(void*** value) => new IDMLBindingTable((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLBindingTable"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable"/> instance to be converted </param>
    public static implicit operator void***(IDMLBindingTable value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDMLBindingTable"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDMLBindingTable(nuint value) => new IDMLBindingTable((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDMLBindingTable"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLBindingTable"/> instance to be converted </param>
    public static implicit operator nuint(IDMLBindingTable value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindInputs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings) => LpVtbl->BindInputs(bindingCount, bindings);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings)
    {
        fixed (DmlBindingDesc* __dsl_bindings = bindings)
        {
            BindInputs(bindingCount, __dsl_bindings);
        }
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindOutputs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* bindings) => LpVtbl->BindOutputs(bindingCount, bindings);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> bindings)
    {
        fixed (DmlBindingDesc* __dsl_bindings = bindings)
        {
            BindOutputs(bindingCount, __dsl_bindings);
        }
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindPersistentResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding) => LpVtbl->BindPersistentResource(binding);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding)
    {
        fixed (DmlBindingDesc* __dsl_binding = binding)
        {
            BindPersistentResource(__dsl_binding);
        }
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindTemporaryResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DmlBindingDesc* binding) => LpVtbl->BindTemporaryResource(binding);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] Ref<DmlBindingDesc> binding)
    {
        fixed (DmlBindingDesc* __dsl_binding = binding)
        {
            BindTemporaryResource(__dsl_binding);
        }
    }

    /// <inheritdoc cref = "IDMLDeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->GetDevice(riid, ppv);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetDevice(__dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetDevice<TCom>(out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return GetDevice(TCom.NativeGuid, ppv.GetAddressOf());
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
    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DmlBindingTableDesc* desc) => LpVtbl->Reset(desc);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] Ref<DmlBindingTableDesc> desc)
    {
        fixed (DmlBindingTableDesc* __dsl_desc = desc)
        {
            return (HResult)Reset(__dsl_desc);
        }
    }

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
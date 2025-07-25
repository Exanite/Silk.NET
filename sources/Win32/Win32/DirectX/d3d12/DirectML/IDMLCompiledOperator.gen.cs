// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDMLCompiledOperator.xml' path='doc/member[@name="IDMLCompiledOperator"]/*'/>
[Guid("6B15E56A-BF5C-4902-92D8-DA3A650AFEA4")]
[NativeTypeName("struct IDMLCompiledOperator : IDMLDispatchable")]
[NativeInheritance("IDMLDispatchable")]
public unsafe partial struct IDMLCompiledOperator : IDMLCompiledOperator.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLCompiledOperator));

    public interface Interface : IDMLDispatchable.Interface
    {
    }

    /// <include file='IDMLCompiledOperator.xml' path='doc/member[@name="IDMLCompiledOperator"]/*'/>
    [Guid("6B15E56A-BF5C-4902-92D8-DA3A650AFEA4")]
    [NativeTypeName("struct IDMLCompiledOperator : IDMLDispatchable")]
    [NativeInheritance("IDMLDispatchable")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLCompiledOperator));

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
            [NativeTypeName("DML_BINDING_PROPERTIES () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DmlBindingProperties*, DmlBindingProperties*> GetBindingProperties;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, uint> )(lpVtbl[1]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDMLDispatchable.GetBindingProperties"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public DmlBindingProperties GetBindingProperties()
        {
            DmlBindingProperties result;
            return *((delegate* unmanaged<IDMLCompiledOperator.Native*, DmlBindingProperties*, DmlBindingProperties*> )(lpVtbl[8]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "IDMLDeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), riid, ppv);
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
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
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
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, uint> )(lpVtbl[2]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDMLObject.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, ushort*, HResult> )(lpVtbl[6]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), name);
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
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), guid, dataSize, data);
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
            return ((delegate* unmanaged<IDMLCompiledOperator.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((IDMLCompiledOperator.Native*)Unsafe.AsPointer(ref this), guid, data.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "IDMLCompiledOperator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLCompiledOperator(Ptr3D vtbl) => LpVtbl = (IDMLCompiledOperator.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDMLCompiledOperator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLCompiledOperator(Ptr<IDMLCompiledOperator.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDMLCompiledOperator.Native"/> to <see cref = "IDMLCompiledOperator"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator.Native"/> instance to be converted </param>
    public static implicit operator IDMLCompiledOperator(IDMLCompiledOperator.Native* value) => new IDMLCompiledOperator((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLCompiledOperator"/> to <see cref = "IDMLCompiledOperator.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator"/> instance to be converted </param>
    public static implicit operator IDMLCompiledOperator.Native*(IDMLCompiledOperator value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDMLCompiledOperator"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDMLCompiledOperator(Ptr3D value) => new IDMLCompiledOperator(value);
    /// <summary>casts <see cref = "IDMLCompiledOperator"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDMLCompiledOperator value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDMLCompiledOperator"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDMLCompiledOperator(Ptr<IDMLCompiledOperator.Native> value) => new IDMLCompiledOperator(value);
    /// <summary>casts <see cref = "IDMLCompiledOperator"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator"/> instance to be converted </param>
    public static implicit operator Ptr<IDMLCompiledOperator.Native>(IDMLCompiledOperator value) => (Ptr<IDMLCompiledOperator.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDMLCompiledOperator"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDMLCompiledOperator(void*** value) => new IDMLCompiledOperator((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLCompiledOperator"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator"/> instance to be converted </param>
    public static implicit operator void***(IDMLCompiledOperator value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDMLCompiledOperator"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDMLCompiledOperator(nuint value) => new IDMLCompiledOperator((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDMLCompiledOperator"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLCompiledOperator"/> instance to be converted </param>
    public static implicit operator nuint(IDMLCompiledOperator value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDMLDispatchable.GetBindingProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DmlBindingProperties GetBindingProperties() => LpVtbl->GetBindingProperties();
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
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice"]/*'/>
[Guid("7D6F3AC9-394A-4AC3-92A7-390CC57A8217")]
[NativeTypeName("struct IDMLDebugDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDMLDebugDevice : IDMLDebugDevice.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLDebugDevice));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetMuteDebugOutput([NativeTypeName("BOOL")] MaybeBool<int> mute);
    }

    /// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice"]/*'/>
    [Guid("7D6F3AC9-394A-4AC3-92A7-390CC57A8217")]
    [NativeTypeName("struct IDMLDebugDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDMLDebugDevice));

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
            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> SetMuteDebugOutput;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDebugDevice.Native*, uint> )(lpVtbl[1]))((IDMLDebugDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDebugDevice.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDMLDebugDevice.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDMLDebugDevice.Native*, uint> )(lpVtbl[2]))((IDMLDebugDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice.SetMuteDebugOutput"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetMuteDebugOutput([NativeTypeName("BOOL")] MaybeBool<int> mute)
        {
            ((delegate* unmanaged<IDMLDebugDevice.Native*, MaybeBool<int>, void> )(lpVtbl[3]))((IDMLDebugDevice.Native*)Unsafe.AsPointer(ref this), mute);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMLDebugDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLDebugDevice(Ptr3D vtbl) => LpVtbl = (IDMLDebugDevice.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDMLDebugDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLDebugDevice(Ptr<IDMLDebugDevice.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDMLDebugDevice.Native"/> to <see cref = "IDMLDebugDevice"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice.Native"/> instance to be converted </param>
    public static implicit operator IDMLDebugDevice(IDMLDebugDevice.Native* value) => new IDMLDebugDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLDebugDevice"/> to <see cref = "IDMLDebugDevice.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice"/> instance to be converted </param>
    public static implicit operator IDMLDebugDevice.Native*(IDMLDebugDevice value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDMLDebugDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDMLDebugDevice(Ptr3D value) => new IDMLDebugDevice(value);
    /// <summary>casts <see cref = "IDMLDebugDevice"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDMLDebugDevice value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDMLDebugDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDMLDebugDevice(Ptr<IDMLDebugDevice.Native> value) => new IDMLDebugDevice(value);
    /// <summary>casts <see cref = "IDMLDebugDevice"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice"/> instance to be converted </param>
    public static implicit operator Ptr<IDMLDebugDevice.Native>(IDMLDebugDevice value) => (Ptr<IDMLDebugDevice.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDMLDebugDevice"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDMLDebugDevice(void*** value) => new IDMLDebugDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDMLDebugDevice"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice"/> instance to be converted </param>
    public static implicit operator void***(IDMLDebugDevice value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDMLDebugDevice"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDMLDebugDevice(nuint value) => new IDMLDebugDevice((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDMLDebugDevice"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDMLDebugDevice"/> instance to be converted </param>
    public static implicit operator nuint(IDMLDebugDevice value) => (nuint)value.LpVtbl;
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
    /// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice.SetMuteDebugOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetMuteDebugOutput([NativeTypeName("BOOL")] MaybeBool<int> mute) => LpVtbl->SetMuteDebugOutput(mute);
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*'/>
[Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
[NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DDestructionNotifier : ID3DDestructionNotifier.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3DDestructionNotifier));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult UnregisterDestructionCallback(uint callbackID);
    }

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*'/>
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    [NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3DDestructionNotifier));

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
            [NativeTypeName("HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, delegate* unmanaged<void*, void> , void*, uint*, HResult> RegisterDestructionCallback;
            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> UnregisterDestructionCallback;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint> )(lpVtbl[1]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, void* pData, uint* pCallbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, delegate* unmanaged<void*, void> , void*, uint*, HResult> )(lpVtbl[3]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, Ref pData, Ref<uint> pCallbackID)
        {
            fixed (uint* __dsl_pCallbackID = pCallbackID)
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)RegisterDestructionCallback(callbackFn, __dsl_pData, __dsl_pCallbackID);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint> )(lpVtbl[2]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult UnregisterDestructionCallback(uint callbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint, HResult> )(lpVtbl[4]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), callbackID);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DDestructionNotifier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DDestructionNotifier(Ptr3D vtbl) => LpVtbl = (ID3DDestructionNotifier.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3DDestructionNotifier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DDestructionNotifier(Ptr<ID3DDestructionNotifier.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3DDestructionNotifier.Native"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier.Native"/> instance to be converted </param>
    public static implicit operator ID3DDestructionNotifier(ID3DDestructionNotifier.Native* value) => new ID3DDestructionNotifier((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "ID3DDestructionNotifier.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator ID3DDestructionNotifier.Native*(ID3DDestructionNotifier value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(Ptr3D value) => new ID3DDestructionNotifier(value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3DDestructionNotifier value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(Ptr<ID3DDestructionNotifier.Native> value) => new ID3DDestructionNotifier(value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator Ptr<ID3DDestructionNotifier.Native>(ID3DDestructionNotifier value) => (Ptr<ID3DDestructionNotifier.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(void*** value) => new ID3DDestructionNotifier((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator void***(ID3DDestructionNotifier value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(nuint value) => new ID3DDestructionNotifier((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator nuint(ID3DDestructionNotifier value) => (nuint)value.LpVtbl;
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

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, void* pData, uint* pCallbackID) => LpVtbl->RegisterDestructionCallback(callbackFn, pData, pCallbackID);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, Ref pData, Ref<uint> pCallbackID)
    {
        fixed (uint* __dsl_pCallbackID = pCallbackID)
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)RegisterDestructionCallback(callbackFn, __dsl_pData, __dsl_pCallbackID);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult UnregisterDestructionCallback(uint callbackID) => LpVtbl->UnregisterDestructionCallback(callbackID);
}
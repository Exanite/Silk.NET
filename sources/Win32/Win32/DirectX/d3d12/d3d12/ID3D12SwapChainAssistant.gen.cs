// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant"]/*'/>
[Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
[NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SwapChainAssistant : ID3D12SwapChainAssistant.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SwapChainAssistant));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource, [NativeTypeName("const IID &")] Ref<Guid> riidQueue, Ref2D ppvQueue);
        [VtblIndex(3)]
        LUID GetLUID();
        [VtblIndex(4)]
        HResult GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetSwapChainObject([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv);
        [VtblIndex(6)]
        HResult InsertImplicitSync();
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant"]/*'/>
    [Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
    [NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12SwapChainAssistant));

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
            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, LUID*, LUID*> GetLUID;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetSwapChainObject;
            [NativeTypeName("HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, Guid*, void**, HResult> GetCurrentResourceAndCommandQueue;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> InsertImplicitSync;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, uint> )(lpVtbl[1]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetCurrentResourceAndCommandQueue"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, Guid*, void**, Guid*, void**, HResult> )(lpVtbl[5]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource, [NativeTypeName("const IID &")] Ref<Guid> riidQueue, Ref2D ppvQueue)
        {
            fixed (void** __dsl_ppvQueue = ppvQueue)
            fixed (Guid* __dsl_riidQueue = riidQueue)
            fixed (void** __dsl_ppvResource = ppvResource)
            fixed (Guid* __dsl_riidResource = riidResource)
            {
                return (HResult)GetCurrentResourceAndCommandQueue(__dsl_riidResource, __dsl_ppvResource, __dsl_riidQueue, __dsl_ppvQueue);
            }
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCurrentResourceAndCommandQueue<TCom>(out TCom ppvResource, [NativeTypeName("const IID &")] Ref<Guid> riidQueue, Ref2D ppvQueue)
            where TCom : unmanaged, IComVtbl
        {
            fixed (void** __dsl_ppvQueue = ppvQueue)
            fixed (Guid* __dsl_riidQueue = riidQueue)
            {
                ppvResource = default;
                return GetCurrentResourceAndCommandQueue(TCom.NativeGuid, ppvResource.GetAddressOf(), __dsl_riidQueue, __dsl_ppvQueue);
            }
        }

        /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetLUID"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public LUID GetLUID()
        {
            LUID result;
            return *((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, LUID*, LUID*> )(lpVtbl[3]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetSwapChainObject"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetSwapChainObject([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
        {
            fixed (void** __dsl_ppv = ppv)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetSwapChainObject(__dsl_riid, __dsl_ppv);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        public HResult GetSwapChainObject<TCom>(out TCom ppv)
            where TCom : unmanaged, IComVtbl
        {
            ppv = default;
            return GetSwapChainObject(TCom.NativeGuid, ppv.GetAddressOf());
        }

        /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.InsertImplicitSync"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult InsertImplicitSync()
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, HResult> )(lpVtbl[6]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12SwapChainAssistant.Native*, uint> )(lpVtbl[2]))((ID3D12SwapChainAssistant.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SwapChainAssistant"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SwapChainAssistant(Ptr3D vtbl) => LpVtbl = (ID3D12SwapChainAssistant.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12SwapChainAssistant"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SwapChainAssistant(Ptr<ID3D12SwapChainAssistant.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant.Native"/> to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant.Native"/> instance to be converted </param>
    public static implicit operator ID3D12SwapChainAssistant(ID3D12SwapChainAssistant.Native* value) => new ID3D12SwapChainAssistant((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant"/> to <see cref = "ID3D12SwapChainAssistant.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator ID3D12SwapChainAssistant.Native*(ID3D12SwapChainAssistant value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12SwapChainAssistant(Ptr3D value) => new ID3D12SwapChainAssistant(value);
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12SwapChainAssistant value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12SwapChainAssistant(Ptr<ID3D12SwapChainAssistant.Native> value) => new ID3D12SwapChainAssistant(value);
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12SwapChainAssistant.Native>(ID3D12SwapChainAssistant value) => (Ptr<ID3D12SwapChainAssistant.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12SwapChainAssistant(void*** value) => new ID3D12SwapChainAssistant((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator void***(ID3D12SwapChainAssistant value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12SwapChainAssistant(nuint value) => new ID3D12SwapChainAssistant((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12SwapChainAssistant"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12SwapChainAssistant value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetCurrentResourceAndCommandQueue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue) => LpVtbl->GetCurrentResourceAndCommandQueue(riidResource, ppvResource, riidQueue, ppvQueue);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource, [NativeTypeName("const IID &")] Ref<Guid> riidQueue, Ref2D ppvQueue)
    {
        fixed (void** __dsl_ppvQueue = ppvQueue)
        fixed (Guid* __dsl_riidQueue = riidQueue)
        fixed (void** __dsl_ppvResource = ppvResource)
        fixed (Guid* __dsl_riidResource = riidResource)
        {
            return (HResult)GetCurrentResourceAndCommandQueue(__dsl_riidResource, __dsl_ppvResource, __dsl_riidQueue, __dsl_ppvQueue);
        }
    }

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCurrentResourceAndCommandQueue<TCom>(out TCom ppvResource, [NativeTypeName("const IID &")] Ref<Guid> riidQueue, Ref2D ppvQueue)
        where TCom : unmanaged, IComVtbl
    {
        fixed (void** __dsl_ppvQueue = ppvQueue)
        fixed (Guid* __dsl_riidQueue = riidQueue)
        {
            ppvResource = default;
            return GetCurrentResourceAndCommandQueue(TCom.NativeGuid, ppvResource.GetAddressOf(), __dsl_riidQueue, __dsl_ppvQueue);
        }
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetLUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public LUID GetLUID() => LpVtbl->GetLUID();
    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetSwapChainObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv) => LpVtbl->GetSwapChainObject(riid, ppv);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSwapChainObject([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetSwapChainObject(__dsl_riid, __dsl_ppv);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    public HResult GetSwapChainObject<TCom>(out TCom ppv)
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return GetSwapChainObject(TCom.NativeGuid, ppv.GetAddressOf());
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.InsertImplicitSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult InsertImplicitSync() => LpVtbl->InsertImplicitSync();
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
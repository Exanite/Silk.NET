// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='OpenGLOn12CreatorID.xml' path='doc/member[@name="OpenGLOn12CreatorID"]/*'/>
[Guid("6BB3CD34-0D19-45AB-97ED-D720BA3DFC80")]
[NativeTypeName("struct OpenGLOn12CreatorID : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct OpenGLOn12CreatorID : OpenGLOn12CreatorID.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.OpenGLOn12CreatorID));

    public interface Interface : IUnknown.Interface
    {
    }

    /// <include file='OpenGLOn12CreatorID.xml' path='doc/member[@name="OpenGLOn12CreatorID"]/*'/>
    [Guid("6BB3CD34-0D19-45AB-97ED-D720BA3DFC80")]
    [NativeTypeName("struct OpenGLOn12CreatorID : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.OpenGLOn12CreatorID));

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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<OpenGLOn12CreatorID.Native*, uint> )(lpVtbl[1]))((OpenGLOn12CreatorID.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<OpenGLOn12CreatorID.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((OpenGLOn12CreatorID.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<OpenGLOn12CreatorID.Native*, uint> )(lpVtbl[2]))((OpenGLOn12CreatorID.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "OpenGLOn12CreatorID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public OpenGLOn12CreatorID(Ptr3D vtbl) => LpVtbl = (OpenGLOn12CreatorID.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "OpenGLOn12CreatorID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public OpenGLOn12CreatorID(Ptr<OpenGLOn12CreatorID.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "OpenGLOn12CreatorID.Native"/> to <see cref = "OpenGLOn12CreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID.Native"/> instance to be converted </param>
    public static implicit operator OpenGLOn12CreatorID(OpenGLOn12CreatorID.Native* value) => new OpenGLOn12CreatorID((Ptr<Native>)value);
    /// <summary>casts <see cref = "OpenGLOn12CreatorID"/> to <see cref = "OpenGLOn12CreatorID.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID"/> instance to be converted </param>
    public static implicit operator OpenGLOn12CreatorID.Native*(OpenGLOn12CreatorID value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "OpenGLOn12CreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator OpenGLOn12CreatorID(Ptr3D value) => new OpenGLOn12CreatorID(value);
    /// <summary>casts <see cref = "OpenGLOn12CreatorID"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID"/> instance to be converted </param>
    public static implicit operator Ptr3D(OpenGLOn12CreatorID value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "OpenGLOn12CreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator OpenGLOn12CreatorID(Ptr<OpenGLOn12CreatorID.Native> value) => new OpenGLOn12CreatorID(value);
    /// <summary>casts <see cref = "OpenGLOn12CreatorID"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID"/> instance to be converted </param>
    public static implicit operator Ptr<OpenGLOn12CreatorID.Native>(OpenGLOn12CreatorID value) => (Ptr<OpenGLOn12CreatorID.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "OpenGLOn12CreatorID"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator OpenGLOn12CreatorID(void*** value) => new OpenGLOn12CreatorID((Ptr<Native>)value);
    /// <summary>casts <see cref = "OpenGLOn12CreatorID"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID"/> instance to be converted </param>
    public static implicit operator void***(OpenGLOn12CreatorID value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "OpenGLOn12CreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator OpenGLOn12CreatorID(nuint value) => new OpenGLOn12CreatorID((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "OpenGLOn12CreatorID"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "OpenGLOn12CreatorID"/> instance to be converted </param>
    public static implicit operator nuint(OpenGLOn12CreatorID value) => (nuint)value.LpVtbl;
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
}
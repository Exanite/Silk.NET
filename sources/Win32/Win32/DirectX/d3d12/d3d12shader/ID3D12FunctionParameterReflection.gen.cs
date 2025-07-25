// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection"]/*'/>
[Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
public unsafe partial struct ID3D12FunctionParameterReflection : ID3D12FunctionParameterReflection.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12FunctionParameterReflection));

    public interface Interface
    {
        [VtblIndex(0)]
        HResult GetDesc(D3D12ParameterDesc* pDesc);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12ParameterDesc> pDesc);
    }

    /// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection"]/*'/>
    [Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12FunctionParameterReflection));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D12_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ParameterDesc*, HResult> GetDesc;
        }

        /// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult GetDesc(D3D12ParameterDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionParameterReflection.Native*, D3D12ParameterDesc*, HResult> )(lpVtbl[0]))((ID3D12FunctionParameterReflection.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12ParameterDesc> pDesc)
        {
            fixed (D3D12ParameterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12FunctionParameterReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12FunctionParameterReflection(Ptr3D vtbl) => LpVtbl = (ID3D12FunctionParameterReflection.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12FunctionParameterReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12FunctionParameterReflection(Ptr<ID3D12FunctionParameterReflection.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection.Native"/> to <see cref = "ID3D12FunctionParameterReflection"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection.Native"/> instance to be converted </param>
    public static implicit operator ID3D12FunctionParameterReflection(ID3D12FunctionParameterReflection.Native* value) => new ID3D12FunctionParameterReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection"/> to <see cref = "ID3D12FunctionParameterReflection.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection"/> instance to be converted </param>
    public static implicit operator ID3D12FunctionParameterReflection.Native*(ID3D12FunctionParameterReflection value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12FunctionParameterReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionParameterReflection(Ptr3D value) => new ID3D12FunctionParameterReflection(value);
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12FunctionParameterReflection value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12FunctionParameterReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionParameterReflection(Ptr<ID3D12FunctionParameterReflection.Native> value) => new ID3D12FunctionParameterReflection(value);
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12FunctionParameterReflection.Native>(ID3D12FunctionParameterReflection value) => (Ptr<ID3D12FunctionParameterReflection.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12FunctionParameterReflection"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12FunctionParameterReflection(void*** value) => new ID3D12FunctionParameterReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection"/> instance to be converted </param>
    public static implicit operator void***(ID3D12FunctionParameterReflection value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12FunctionParameterReflection"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionParameterReflection(nuint value) => new ID3D12FunctionParameterReflection((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12FunctionParameterReflection"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionParameterReflection"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12FunctionParameterReflection value) => (nuint)value.LpVtbl;
    /// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult GetDesc(D3D12ParameterDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12ParameterDesc> pDesc)
    {
        fixed (D3D12ParameterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }
}
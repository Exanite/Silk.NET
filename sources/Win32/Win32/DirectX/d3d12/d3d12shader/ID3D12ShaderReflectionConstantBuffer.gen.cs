// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer"]/*'/>
[Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7")]
public unsafe partial struct ID3D12ShaderReflectionConstantBuffer : ID3D12ShaderReflectionConstantBuffer.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionConstantBuffer));

    public interface Interface
    {
        [VtblIndex(0)]
        HResult GetDesc(D3D12ShaderBufferDesc* pDesc);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12ShaderBufferDesc> pDesc);
        [VtblIndex(1)]
        ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index);
        [VtblIndex(2)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(2)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
    }

    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer"]/*'/>
    [Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionConstantBuffer));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ShaderBufferDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionVariable.Native*> GetVariableByIndex;
            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionVariable.Native*> GetVariableByName;
        }

        /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult GetDesc(D3D12ShaderBufferDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer.Native*, D3D12ShaderBufferDesc*, HResult> )(lpVtbl[0]))((ID3D12ShaderReflectionConstantBuffer.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12ShaderBufferDesc> pDesc)
        {
            fixed (D3D12ShaderBufferDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index)
        {
            return (ID3D12ShaderReflectionVariable)((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer.Native*, uint, ID3D12ShaderReflectionVariable.Native*> )(lpVtbl[1]))((ID3D12ShaderReflectionConstantBuffer.Native*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionVariable)((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer.Native*, sbyte*, ID3D12ShaderReflectionVariable.Native*> )(lpVtbl[2]))((ID3D12ShaderReflectionConstantBuffer.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(2)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
        {
            fixed (sbyte* __dsl_Name = Name)
            {
                return (ID3D12ShaderReflectionVariable)GetVariableByName(__dsl_Name);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionConstantBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionConstantBuffer(Ptr3D vtbl) => LpVtbl = (ID3D12ShaderReflectionConstantBuffer.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionConstantBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionConstantBuffer(Ptr<ID3D12ShaderReflectionConstantBuffer.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer.Native"/> to <see cref = "ID3D12ShaderReflectionConstantBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionConstantBuffer(ID3D12ShaderReflectionConstantBuffer.Native* value) => new ID3D12ShaderReflectionConstantBuffer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer"/> to <see cref = "ID3D12ShaderReflectionConstantBuffer.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionConstantBuffer.Native*(ID3D12ShaderReflectionConstantBuffer value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ShaderReflectionConstantBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionConstantBuffer(Ptr3D value) => new ID3D12ShaderReflectionConstantBuffer(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ShaderReflectionConstantBuffer value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ShaderReflectionConstantBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionConstantBuffer(Ptr<ID3D12ShaderReflectionConstantBuffer.Native> value) => new ID3D12ShaderReflectionConstantBuffer(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ShaderReflectionConstantBuffer.Native>(ID3D12ShaderReflectionConstantBuffer value) => (Ptr<ID3D12ShaderReflectionConstantBuffer.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ShaderReflectionConstantBuffer"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionConstantBuffer(void*** value) => new ID3D12ShaderReflectionConstantBuffer((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ShaderReflectionConstantBuffer value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ShaderReflectionConstantBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionConstantBuffer(nuint value) => new ID3D12ShaderReflectionConstantBuffer((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ShaderReflectionConstantBuffer"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionConstantBuffer"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ShaderReflectionConstantBuffer value) => (nuint)value.LpVtbl;
    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult GetDesc(D3D12ShaderBufferDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12ShaderBufferDesc> pDesc)
    {
        fixed (D3D12ShaderBufferDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index) => LpVtbl->GetVariableByIndex(Index);
    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetVariableByName(Name);
    [VtblIndex(2)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
    {
        fixed (sbyte* __dsl_Name = Name)
        {
            return (ID3D12ShaderReflectionVariable)GetVariableByName(__dsl_Name);
        }
    }
}
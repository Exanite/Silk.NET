// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable"]/*'/>
[Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
public unsafe partial struct ID3D12ShaderReflectionVariable : ID3D12ShaderReflectionVariable.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionVariable));

    public interface Interface
    {
        [VtblIndex(2)]
        ID3D12ShaderReflectionConstantBuffer GetBuffer();
        [VtblIndex(0)]
        HResult GetDesc(D3D12ShaderVariableDesc* pDesc);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12ShaderVariableDesc> pDesc);
        [VtblIndex(3)]
        uint GetInterfaceSlot(uint uArrayIndex);
        [VtblIndex(1)]
        ID3D12ShaderReflectionType GetType();
    }

    /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable"]/*'/>
    [Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionVariable));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ShaderVariableDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*> GetType;
            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionConstantBuffer.Native*> GetBuffer;
            [NativeTypeName("UINT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint> GetInterfaceSlot;
        }

        /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetBuffer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionConstantBuffer GetBuffer()
        {
            return (ID3D12ShaderReflectionConstantBuffer)((delegate* unmanaged<ID3D12ShaderReflectionVariable.Native*, ID3D12ShaderReflectionConstantBuffer.Native*> )(lpVtbl[2]))((ID3D12ShaderReflectionVariable.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult GetDesc(D3D12ShaderVariableDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionVariable.Native*, D3D12ShaderVariableDesc*, HResult> )(lpVtbl[0]))((ID3D12ShaderReflectionVariable.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12ShaderVariableDesc> pDesc)
        {
            fixed (D3D12ShaderVariableDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetInterfaceSlot"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public uint GetInterfaceSlot(uint uArrayIndex)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionVariable.Native*, uint, uint> )(lpVtbl[3]))((ID3D12ShaderReflectionVariable.Native*)Unsafe.AsPointer(ref this), uArrayIndex);
        }

        /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetType"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public new ID3D12ShaderReflectionType GetType()
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionVariable.Native*, ID3D12ShaderReflectionType.Native*> )(lpVtbl[1]))((ID3D12ShaderReflectionVariable.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionVariable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionVariable(Ptr3D vtbl) => LpVtbl = (ID3D12ShaderReflectionVariable.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionVariable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionVariable(Ptr<ID3D12ShaderReflectionVariable.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable.Native"/> to <see cref = "ID3D12ShaderReflectionVariable"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionVariable(ID3D12ShaderReflectionVariable.Native* value) => new ID3D12ShaderReflectionVariable((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable"/> to <see cref = "ID3D12ShaderReflectionVariable.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionVariable.Native*(ID3D12ShaderReflectionVariable value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ShaderReflectionVariable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionVariable(Ptr3D value) => new ID3D12ShaderReflectionVariable(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ShaderReflectionVariable value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ShaderReflectionVariable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionVariable(Ptr<ID3D12ShaderReflectionVariable.Native> value) => new ID3D12ShaderReflectionVariable(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ShaderReflectionVariable.Native>(ID3D12ShaderReflectionVariable value) => (Ptr<ID3D12ShaderReflectionVariable.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ShaderReflectionVariable"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionVariable(void*** value) => new ID3D12ShaderReflectionVariable((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ShaderReflectionVariable value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ShaderReflectionVariable"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionVariable(nuint value) => new ID3D12ShaderReflectionVariable((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ShaderReflectionVariable"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionVariable"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ShaderReflectionVariable value) => (nuint)value.LpVtbl;
    /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionConstantBuffer GetBuffer() => LpVtbl->GetBuffer();
    /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult GetDesc(D3D12ShaderVariableDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12ShaderVariableDesc> pDesc)
    {
        fixed (D3D12ShaderVariableDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetInterfaceSlot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetInterfaceSlot(uint uArrayIndex) => LpVtbl->GetInterfaceSlot(uArrayIndex);
    /// <include file='ID3D12ShaderReflectionVariable.xml' path='doc/member[@name="ID3D12ShaderReflectionVariable.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public new ID3D12ShaderReflectionType GetType() => LpVtbl->GetType();
}
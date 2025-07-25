// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection"]/*'/>
[Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
public unsafe partial struct ID3D12FunctionReflection : ID3D12FunctionReflection.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12FunctionReflection));

    public interface Interface
    {
        [VtblIndex(1)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex);
        [VtblIndex(2)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(2)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
        [VtblIndex(0)]
        HResult GetDesc(D3D12FunctionDesc* pDesc);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12FunctionDesc> pDesc);
        [VtblIndex(6)]
        ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex);
        [VtblIndex(3)]
        HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc);
        [VtblIndex(5)]
        HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name, Ref<D3D12ShaderInputBindDesc> pDesc);
        [VtblIndex(4)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
    }

    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection"]/*'/>
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12FunctionReflection));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D12_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12FunctionDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionConstantBuffer.Native*> GetConstantBufferByIndex;
            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionConstantBuffer.Native*> GetConstantBufferByName;
            [NativeTypeName("HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12ShaderInputBindDesc*, HResult> GetResourceBindingDesc;
            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionVariable.Native*> GetVariableByName;
            [NativeTypeName("HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, D3D12ShaderInputBindDesc*, HResult> GetResourceBindingDescByName;
            [NativeTypeName("ID3D12FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int, ID3D12FunctionParameterReflection.Native*> GetFunctionParameter;
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetConstantBufferByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex)
        {
            return (ID3D12ShaderReflectionConstantBuffer)((delegate* unmanaged<ID3D12FunctionReflection.Native*, uint, ID3D12ShaderReflectionConstantBuffer.Native*> )(lpVtbl[1]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetConstantBufferByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionConstantBuffer)((delegate* unmanaged<ID3D12FunctionReflection.Native*, sbyte*, ID3D12ShaderReflectionConstantBuffer.Native*> )(lpVtbl[2]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(2)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
        {
            fixed (sbyte* __dsl_Name = Name)
            {
                return (ID3D12ShaderReflectionConstantBuffer)GetConstantBufferByName(__dsl_Name);
            }
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult GetDesc(D3D12FunctionDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection.Native*, D3D12FunctionDesc*, HResult> )(lpVtbl[0]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12FunctionDesc> pDesc)
        {
            fixed (D3D12FunctionDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetFunctionParameter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex)
        {
            return (ID3D12FunctionParameterReflection)((delegate* unmanaged<ID3D12FunctionReflection.Native*, int, ID3D12FunctionParameterReflection.Native*> )(lpVtbl[6]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetResourceBindingDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection.Native*, uint, D3D12ShaderInputBindDesc*, HResult> )(lpVtbl[3]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc)
        {
            fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetResourceBindingDesc(ResourceIndex, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetResourceBindingDescByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection.Native*, sbyte*, D3D12ShaderInputBindDesc*, HResult> )(lpVtbl[5]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name, Ref<D3D12ShaderInputBindDesc> pDesc)
        {
            fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
            fixed (sbyte* __dsl_Name = Name)
            {
                return (HResult)GetResourceBindingDescByName(__dsl_Name, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetVariableByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionVariable)((delegate* unmanaged<ID3D12FunctionReflection.Native*, sbyte*, ID3D12ShaderReflectionVariable.Native*> )(lpVtbl[4]))((ID3D12FunctionReflection.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(4)]
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

    /// <summary>Initializes a new instance of the <see cref = "ID3D12FunctionReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12FunctionReflection(Ptr3D vtbl) => LpVtbl = (ID3D12FunctionReflection.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12FunctionReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12FunctionReflection(Ptr<ID3D12FunctionReflection.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12FunctionReflection.Native"/> to <see cref = "ID3D12FunctionReflection"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection.Native"/> instance to be converted </param>
    public static implicit operator ID3D12FunctionReflection(ID3D12FunctionReflection.Native* value) => new ID3D12FunctionReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12FunctionReflection"/> to <see cref = "ID3D12FunctionReflection.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection"/> instance to be converted </param>
    public static implicit operator ID3D12FunctionReflection.Native*(ID3D12FunctionReflection value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12FunctionReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionReflection(Ptr3D value) => new ID3D12FunctionReflection(value);
    /// <summary>casts <see cref = "ID3D12FunctionReflection"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12FunctionReflection value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12FunctionReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionReflection(Ptr<ID3D12FunctionReflection.Native> value) => new ID3D12FunctionReflection(value);
    /// <summary>casts <see cref = "ID3D12FunctionReflection"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12FunctionReflection.Native>(ID3D12FunctionReflection value) => (Ptr<ID3D12FunctionReflection.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12FunctionReflection"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12FunctionReflection(void*** value) => new ID3D12FunctionReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12FunctionReflection"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection"/> instance to be converted </param>
    public static implicit operator void***(ID3D12FunctionReflection value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12FunctionReflection"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12FunctionReflection(nuint value) => new ID3D12FunctionReflection((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12FunctionReflection"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12FunctionReflection"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12FunctionReflection value) => (nuint)value.LpVtbl;
    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex) => LpVtbl->GetConstantBufferByIndex(BufferIndex);
    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetConstantBufferByName(Name);
    [VtblIndex(2)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
    {
        fixed (sbyte* __dsl_Name = Name)
        {
            return (ID3D12ShaderReflectionConstantBuffer)GetConstantBufferByName(__dsl_Name);
        }
    }

    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult GetDesc(D3D12FunctionDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12FunctionDesc> pDesc)
    {
        fixed (D3D12FunctionDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetFunctionParameter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex) => LpVtbl->GetFunctionParameter(ParameterIndex);
    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetResourceBindingDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc) => LpVtbl->GetResourceBindingDesc(ResourceIndex, pDesc);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc)
    {
        fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetResourceBindingDesc(ResourceIndex, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetResourceBindingDescByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc) => LpVtbl->GetResourceBindingDescByName(Name, pDesc);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name, Ref<D3D12ShaderInputBindDesc> pDesc)
    {
        fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
        fixed (sbyte* __dsl_Name = Name)
        {
            return (HResult)GetResourceBindingDescByName(__dsl_Name, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12FunctionReflection.xml' path='doc/member[@name="ID3D12FunctionReflection.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetVariableByName(Name);
    [VtblIndex(4)]
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
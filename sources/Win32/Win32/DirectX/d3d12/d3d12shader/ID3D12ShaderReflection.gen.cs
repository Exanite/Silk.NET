// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection"]/*'/>
[Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
[NativeTypeName("struct ID3D12ShaderReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ShaderReflection : ID3D12ShaderReflection.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflection));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(15)]
        uint GetBitwiseInstructionCount();
        [VtblIndex(4)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
        [VtblIndex(5)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
        [VtblIndex(14)]
        uint GetConversionInstructionCount();
        [VtblIndex(3)]
        HResult GetDesc(D3D12ShaderDesc* pDesc);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12ShaderDesc> pDesc);
        [VtblIndex(16)]
        D3DPrimitive GetGSInputPrimitive();
        [VtblIndex(7)]
        HResult GetInputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetInputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc);
        [VtblIndex(19)]
        HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3DFeatureLevel* pLevel);
        [VtblIndex(19)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] Ref<D3DFeatureLevel> pLevel);
        [VtblIndex(13)]
        uint GetMovcInstructionCount();
        [VtblIndex(12)]
        uint GetMovInstructionCount();
        [VtblIndex(18)]
        uint GetNumInterfaceSlots();
        [VtblIndex(8)]
        HResult GetOutputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetOutputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc);
        [VtblIndex(9)]
        HResult GetPatchConstantParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPatchConstantParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc);
        [VtblIndex(21)]
        [return: NativeTypeName("UINT64")]
        ulong GetRequiresFlags();
        [VtblIndex(6)]
        HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc);
        [VtblIndex(11)]
        HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name, Ref<D3D12ShaderInputBindDesc> pDesc);
        [VtblIndex(20)]
        uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ);
        [VtblIndex(20)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        uint GetThreadGroupSize(Ref<uint> pSizeX, Ref<uint> pSizeY, Ref<uint> pSizeZ);
        [VtblIndex(10)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(10)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> IsSampleFrequencyShader();
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection"]/*'/>
    [Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
    [NativeTypeName("struct ID3D12ShaderReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflection));

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
            [NativeTypeName("HRESULT (D3D12_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ShaderDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionConstantBuffer.Native*> GetConstantBufferByIndex;
            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionConstantBuffer.Native*> GetConstantBufferByName;
            [NativeTypeName("HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12ShaderInputBindDesc*, HResult> GetResourceBindingDesc;
            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12SignatureParameterDesc*, HResult> GetInputParameterDesc;
            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12SignatureParameterDesc*, HResult> GetOutputParameterDesc;
            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12SignatureParameterDesc*, HResult> GetPatchConstantParameterDesc;
            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionVariable.Native*> GetVariableByName;
            [NativeTypeName("HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, D3D12ShaderInputBindDesc*, HResult> GetResourceBindingDescByName;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetMovInstructionCount;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetMovcInstructionCount;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetConversionInstructionCount;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetBitwiseInstructionCount;
            [NativeTypeName("D3D_PRIMITIVE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DPrimitive> GetGSInputPrimitive;
            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> IsSampleFrequencyShader;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetNumInterfaceSlots;
            [NativeTypeName("HRESULT (enum D3D_FEATURE_LEVEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DFeatureLevel*, HResult> GetMinFeatureLevel;
            [NativeTypeName("UINT (UINT *, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint> GetThreadGroupSize;
            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetRequiresFlags;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[1]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetBitwiseInstructionCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetBitwiseInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[15]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConstantBufferByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index)
        {
            return (ID3D12ShaderReflectionConstantBuffer)((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint, ID3D12ShaderReflectionConstantBuffer.Native*> )(lpVtbl[4]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConstantBufferByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionConstantBuffer)((delegate* unmanaged<ID3D12ShaderReflection.Native*, sbyte*, ID3D12ShaderReflectionConstantBuffer.Native*> )(lpVtbl[5]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
        {
            fixed (sbyte* __dsl_Name = Name)
            {
                return (ID3D12ShaderReflectionConstantBuffer)GetConstantBufferByName(__dsl_Name);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConversionInstructionCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public uint GetConversionInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[14]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDesc(D3D12ShaderDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, D3D12ShaderDesc*, HResult> )(lpVtbl[3]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12ShaderDesc> pDesc)
        {
            fixed (D3D12ShaderDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetGSInputPrimitive"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public D3DPrimitive GetGSInputPrimitive()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, D3DPrimitive> )(lpVtbl[16]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetInputParameterDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetInputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint, D3D12SignatureParameterDesc*, HResult> )(lpVtbl[7]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetInputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
        {
            fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetInputParameterDesc(ParameterIndex, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMinFeatureLevel"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3DFeatureLevel* pLevel)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, D3DFeatureLevel*, HResult> )(lpVtbl[19]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), pLevel);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] Ref<D3DFeatureLevel> pLevel)
        {
            fixed (D3DFeatureLevel* __dsl_pLevel = pLevel)
            {
                return (HResult)GetMinFeatureLevel(__dsl_pLevel);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMovcInstructionCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public uint GetMovcInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[13]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMovInstructionCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public uint GetMovInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[12]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetNumInterfaceSlots"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public uint GetNumInterfaceSlots()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[18]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetOutputParameterDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetOutputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint, D3D12SignatureParameterDesc*, HResult> )(lpVtbl[8]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetOutputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
        {
            fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetOutputParameterDesc(ParameterIndex, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetPatchConstantParameterDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetPatchConstantParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint, D3D12SignatureParameterDesc*, HResult> )(lpVtbl[9]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPatchConstantParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
        {
            fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetPatchConstantParameterDesc(ParameterIndex, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetRequiresFlags"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, ulong> )(lpVtbl[21]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetResourceBindingDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint, D3D12ShaderInputBindDesc*, HResult> )(lpVtbl[6]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc)
        {
            fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetResourceBindingDesc(ResourceIndex, __dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetResourceBindingDescByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, sbyte*, D3D12ShaderInputBindDesc*, HResult> )(lpVtbl[11]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [VtblIndex(11)]
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

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetThreadGroupSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint*, uint*, uint*, uint> )(lpVtbl[20]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public uint GetThreadGroupSize(Ref<uint> pSizeX, Ref<uint> pSizeY, Ref<uint> pSizeZ)
        {
            fixed (uint* __dsl_pSizeZ = pSizeZ)
            fixed (uint* __dsl_pSizeY = pSizeY)
            fixed (uint* __dsl_pSizeX = pSizeX)
            {
                return (uint)GetThreadGroupSize(__dsl_pSizeX, __dsl_pSizeY, __dsl_pSizeZ);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetVariableByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionVariable)((delegate* unmanaged<ID3D12ShaderReflection.Native*, sbyte*, ID3D12ShaderReflectionVariable.Native*> )(lpVtbl[10]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
        {
            fixed (sbyte* __dsl_Name = Name)
            {
                return (ID3D12ShaderReflectionVariable)GetVariableByName(__dsl_Name);
            }
        }

        /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.IsSampleFrequencyShader"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsSampleFrequencyShader()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, MaybeBool<int>> )(lpVtbl[17]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12ShaderReflection.Native*, uint> )(lpVtbl[2]))((ID3D12ShaderReflection.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflection(Ptr3D vtbl) => LpVtbl = (ID3D12ShaderReflection.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflection(Ptr<ID3D12ShaderReflection.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ShaderReflection.Native"/> to <see cref = "ID3D12ShaderReflection"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflection(ID3D12ShaderReflection.Native* value) => new ID3D12ShaderReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflection"/> to <see cref = "ID3D12ShaderReflection.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflection.Native*(ID3D12ShaderReflection value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ShaderReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflection(Ptr3D value) => new ID3D12ShaderReflection(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflection"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ShaderReflection value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ShaderReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflection(Ptr<ID3D12ShaderReflection.Native> value) => new ID3D12ShaderReflection(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflection"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ShaderReflection.Native>(ID3D12ShaderReflection value) => (Ptr<ID3D12ShaderReflection.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ShaderReflection"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ShaderReflection(void*** value) => new ID3D12ShaderReflection((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflection"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ShaderReflection value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ShaderReflection"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflection(nuint value) => new ID3D12ShaderReflection((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ShaderReflection"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflection"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ShaderReflection value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetBitwiseInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetBitwiseInstructionCount() => LpVtbl->GetBitwiseInstructionCount();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index) => LpVtbl->GetConstantBufferByIndex(Index);
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetConstantBufferByName(Name);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
    {
        fixed (sbyte* __dsl_Name = Name)
        {
            return (ID3D12ShaderReflectionConstantBuffer)GetConstantBufferByName(__dsl_Name);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetConversionInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public uint GetConversionInstructionCount() => LpVtbl->GetConversionInstructionCount();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetDesc(D3D12ShaderDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12ShaderDesc> pDesc)
    {
        fixed (D3D12ShaderDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetGSInputPrimitive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public D3DPrimitive GetGSInputPrimitive() => LpVtbl->GetGSInputPrimitive();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetInputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetInputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc) => LpVtbl->GetInputParameterDesc(ParameterIndex, pDesc);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetInputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
    {
        fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetInputParameterDesc(ParameterIndex, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMinFeatureLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3DFeatureLevel* pLevel) => LpVtbl->GetMinFeatureLevel(pLevel);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] Ref<D3DFeatureLevel> pLevel)
    {
        fixed (D3DFeatureLevel* __dsl_pLevel = pLevel)
        {
            return (HResult)GetMinFeatureLevel(__dsl_pLevel);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMovcInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetMovcInstructionCount() => LpVtbl->GetMovcInstructionCount();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetMovInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetMovInstructionCount() => LpVtbl->GetMovInstructionCount();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetNumInterfaceSlots"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public uint GetNumInterfaceSlots() => LpVtbl->GetNumInterfaceSlots();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetOutputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetOutputParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc) => LpVtbl->GetOutputParameterDesc(ParameterIndex, pDesc);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetOutputParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
    {
        fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetOutputParameterDesc(ParameterIndex, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetPatchConstantParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetPatchConstantParameterDesc(uint ParameterIndex, D3D12SignatureParameterDesc* pDesc) => LpVtbl->GetPatchConstantParameterDesc(ParameterIndex, pDesc);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPatchConstantParameterDesc(uint ParameterIndex, Ref<D3D12SignatureParameterDesc> pDesc)
    {
        fixed (D3D12SignatureParameterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetPatchConstantParameterDesc(ParameterIndex, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetRequiresFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("UINT64")]
    public ulong GetRequiresFlags() => LpVtbl->GetRequiresFlags();
    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetResourceBindingDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetResourceBindingDesc(uint ResourceIndex, D3D12ShaderInputBindDesc* pDesc) => LpVtbl->GetResourceBindingDesc(ResourceIndex, pDesc);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetResourceBindingDesc(uint ResourceIndex, Ref<D3D12ShaderInputBindDesc> pDesc)
    {
        fixed (D3D12ShaderInputBindDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetResourceBindingDesc(ResourceIndex, __dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetResourceBindingDescByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12ShaderInputBindDesc* pDesc) => LpVtbl->GetResourceBindingDescByName(Name, pDesc);
    [VtblIndex(11)]
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

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetThreadGroupSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ) => LpVtbl->GetThreadGroupSize(pSizeX, pSizeY, pSizeZ);
    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint GetThreadGroupSize(Ref<uint> pSizeX, Ref<uint> pSizeY, Ref<uint> pSizeZ)
    {
        fixed (uint* __dsl_pSizeZ = pSizeZ)
        fixed (uint* __dsl_pSizeY = pSizeY)
        fixed (uint* __dsl_pSizeX = pSizeX)
        {
            return (uint)GetThreadGroupSize(__dsl_pSizeX, __dsl_pSizeY, __dsl_pSizeZ);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetVariableByName(Name);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ID3D12ShaderReflectionVariable GetVariableByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
    {
        fixed (sbyte* __dsl_Name = Name)
        {
            return (ID3D12ShaderReflectionVariable)GetVariableByName(__dsl_Name);
        }
    }

    /// <include file='ID3D12ShaderReflection.xml' path='doc/member[@name="ID3D12ShaderReflection.IsSampleFrequencyShader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsSampleFrequencyShader() => LpVtbl->IsSampleFrequencyShader();
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
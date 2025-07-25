// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType"]/*'/>
[Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
public unsafe partial struct ID3D12ShaderReflectionType : ID3D12ShaderReflectionType.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionType));

    public interface Interface
    {
        [VtblIndex(6)]
        ID3D12ShaderReflectionType GetBaseClass();
        [VtblIndex(0)]
        HResult GetDesc(D3D12ShaderTypeDesc* pDesc);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3D12ShaderTypeDesc> pDesc);
        [VtblIndex(8)]
        ID3D12ShaderReflectionType GetInterfaceByIndex(uint uIndex);
        [VtblIndex(1)]
        ID3D12ShaderReflectionType GetMemberTypeByIndex(uint Index);
        [VtblIndex(2)]
        ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(2)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name);
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        Ptr<sbyte> GetMemberTypeName(uint Index);
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberTypeNameRaw(uint Index);
        [VtblIndex(7)]
        uint GetNumInterfaces();
        [VtblIndex(5)]
        ID3D12ShaderReflectionType GetSubType();
        [VtblIndex(10)]
        HResult ImplementsInterface(ID3D12ShaderReflectionType pBase);
        [VtblIndex(4)]
        HResult IsEqual(ID3D12ShaderReflectionType pType);
        [VtblIndex(9)]
        HResult IsOfType(ID3D12ShaderReflectionType pType);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType"]/*'/>
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderReflectionType));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ShaderTypeDesc*, HResult> GetDesc;
            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionType.Native*> GetMemberTypeByIndex;
            [NativeTypeName("ID3D12ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionType.Native*> GetMemberTypeByName;
            [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberTypeName;
            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*, HResult> IsEqual;
            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*> GetSubType;
            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*> GetBaseClass;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetNumInterfaces;
            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionType.Native*> GetInterfaceByIndex;
            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*, HResult> IsOfType;
            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType.Native*, HResult> ImplementsInterface;
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetBaseClass"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D12ShaderReflectionType GetBaseClass()
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, ID3D12ShaderReflectionType.Native*> )(lpVtbl[6]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult GetDesc(D3D12ShaderTypeDesc* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, D3D12ShaderTypeDesc*, HResult> )(lpVtbl[0]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3D12ShaderTypeDesc> pDesc)
        {
            fixed (D3D12ShaderTypeDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetInterfaceByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ID3D12ShaderReflectionType GetInterfaceByIndex(uint uIndex)
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, uint, ID3D12ShaderReflectionType.Native*> )(lpVtbl[8]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), uIndex);
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByIndex"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D12ShaderReflectionType GetMemberTypeByIndex(uint Index)
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, uint, ID3D12ShaderReflectionType.Native*> )(lpVtbl[1]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, sbyte*, ID3D12ShaderReflectionType.Native*> )(lpVtbl[2]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(2)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
        {
            fixed (sbyte* __dsl_Name = Name)
            {
                return (ID3D12ShaderReflectionType)GetMemberTypeByName(__dsl_Name);
            }
        }

        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr<sbyte> GetMemberTypeName(uint Index) => (sbyte*)GetMemberTypeNameRaw(Index);
        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeNameRaw(uint Index)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, uint, sbyte*> )(lpVtbl[3]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetNumInterfaces"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetNumInterfaces()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, uint> )(lpVtbl[7]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetSubType"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D12ShaderReflectionType GetSubType()
        {
            return (ID3D12ShaderReflectionType)((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, ID3D12ShaderReflectionType.Native*> )(lpVtbl[5]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.ImplementsInterface"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult ImplementsInterface(ID3D12ShaderReflectionType pBase)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, ID3D12ShaderReflectionType.Native*, HResult> )(lpVtbl[10]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), pBase.LpVtbl);
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsEqual"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult IsEqual(ID3D12ShaderReflectionType pType)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, ID3D12ShaderReflectionType.Native*, HResult> )(lpVtbl[4]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), pType.LpVtbl);
        }

        /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsOfType"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult IsOfType(ID3D12ShaderReflectionType pType)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflectionType.Native*, ID3D12ShaderReflectionType.Native*, HResult> )(lpVtbl[9]))((ID3D12ShaderReflectionType.Native*)Unsafe.AsPointer(ref this), pType.LpVtbl);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionType"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionType(Ptr3D vtbl) => LpVtbl = (ID3D12ShaderReflectionType.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderReflectionType"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderReflectionType(Ptr<ID3D12ShaderReflectionType.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType.Native"/> to <see cref = "ID3D12ShaderReflectionType"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionType(ID3D12ShaderReflectionType.Native* value) => new ID3D12ShaderReflectionType((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType"/> to <see cref = "ID3D12ShaderReflectionType.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderReflectionType.Native*(ID3D12ShaderReflectionType value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ShaderReflectionType"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionType(Ptr3D value) => new ID3D12ShaderReflectionType(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ShaderReflectionType value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ShaderReflectionType"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionType(Ptr<ID3D12ShaderReflectionType.Native> value) => new ID3D12ShaderReflectionType(value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ShaderReflectionType.Native>(ID3D12ShaderReflectionType value) => (Ptr<ID3D12ShaderReflectionType.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ShaderReflectionType"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionType(void*** value) => new ID3D12ShaderReflectionType((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ShaderReflectionType value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ShaderReflectionType"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderReflectionType(nuint value) => new ID3D12ShaderReflectionType((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ShaderReflectionType"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderReflectionType"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ShaderReflectionType value) => (nuint)value.LpVtbl;
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetBaseClass"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D12ShaderReflectionType GetBaseClass() => LpVtbl->GetBaseClass();
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult GetDesc(D3D12ShaderTypeDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3D12ShaderTypeDesc> pDesc)
    {
        fixed (D3D12ShaderTypeDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetInterfaceByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D12ShaderReflectionType GetInterfaceByIndex(uint uIndex) => LpVtbl->GetInterfaceByIndex(uIndex);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionType GetMemberTypeByIndex(uint Index) => LpVtbl->GetMemberTypeByIndex(Index);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name) => LpVtbl->GetMemberTypeByName(Name);
    [VtblIndex(2)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ID3D12ShaderReflectionType GetMemberTypeByName([NativeTypeName("LPCSTR")] Ref<sbyte> Name)
    {
        fixed (sbyte* __dsl_Name = Name)
        {
            return (ID3D12ShaderReflectionType)GetMemberTypeByName(__dsl_Name);
        }
    }

    [VtblIndex(3)]
    [return: NativeTypeName("LPCSTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr<sbyte> GetMemberTypeName(uint Index) => (sbyte*)GetMemberTypeNameRaw(Index);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberTypeNameRaw(uint Index) => LpVtbl->GetMemberTypeNameRaw(Index);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetNumInterfaces"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNumInterfaces() => LpVtbl->GetNumInterfaces();
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetSubType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D12ShaderReflectionType GetSubType() => LpVtbl->GetSubType();
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.ImplementsInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult ImplementsInterface(ID3D12ShaderReflectionType pBase) => LpVtbl->ImplementsInterface(pBase);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsEqual"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult IsEqual(ID3D12ShaderReflectionType pType) => LpVtbl->IsEqual(pType);
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsOfType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult IsOfType(ID3D12ShaderReflectionType pType) => LpVtbl->IsOfType(pType);
}
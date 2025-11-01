// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "ICompileResult")]
    public unsafe partial struct ICompileResult : IComVtbl<ICompileResult>, IComVtbl<ISlangCastable>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangCastable(ICompileResult val)
            => Unsafe.As<ICompileResult, ISlangCastable>(ref val);

        public static implicit operator ISlangUnknown(ICompileResult val)
            => Unsafe.As<ICompileResult, ISlangUnknown>(ref val);

        public ICompileResult
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* guid)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID guid)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (SlangUUID* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetItemCount()
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetItemData(uint index, ISlangBlob** outblob)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint, ISlangBlob**, int>)@this->LpVtbl[5])(@this, index, outblob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetItemData(uint index, ref ISlangBlob* outblob)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outblobPtr = &outblob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint, ISlangBlob**, int>)@this->LpVtbl[5])(@this, index, outblobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadata(IMetadata** outMetadata)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, IMetadata**, int>)@this->LpVtbl[6])(@this, outMetadata);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadata(ref IMetadata* outMetadata)
        {
            var @this = (ICompileResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, IMetadata**, int>)@this->LpVtbl[6])(@this, outMetadataPtr);
            }
            return ret;
        }

    }
}

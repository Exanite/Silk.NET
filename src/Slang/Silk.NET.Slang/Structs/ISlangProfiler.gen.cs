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
    [NativeName("Name", "ISlangProfiler")]
    public unsafe partial struct ISlangProfiler : IComVtbl<ISlangProfiler>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(ISlangProfiler val)
            => Unsafe.As<ISlangProfiler, ISlangUnknown>(ref val);

        public ISlangProfiler
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
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetEntryCount()
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, nuint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetEntryName(uint index)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint, byte*>)@this->LpVtbl[4])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetEntryNameS(uint index)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint, string>)@this->LpVtbl[4])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEntryTimeMS(uint index)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint, int>)@this->LpVtbl[5])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetEntryInvocationTimes(uint index)
        {
            var @this = (ISlangProfiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangProfiler*, uint, uint>)@this->LpVtbl[6])(@this, index);
            return ret;
        }

    }
}

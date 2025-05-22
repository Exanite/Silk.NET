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
    [NativeName("Name", "ISlangClonable")]
    public unsafe partial struct ISlangClonable : IComVtbl<ISlangClonable>, IComVtbl<ISlangCastable>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangCastable(ISlangClonable val)
            => Unsafe.As<ISlangClonable, ISlangCastable>(ref val);

        public static implicit operator ISlangUnknown(ISlangClonable val)
            => Unsafe.As<ISlangClonable, ISlangUnknown>(ref val);

        public ISlangClonable
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
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* guid)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid guid)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (Uuid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Clone([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* guid)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void*>)@this->LpVtbl[4])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Clone([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid guid)
        {
            var @this = (ISlangClonable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (Uuid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangClonable*, Uuid*, void*>)@this->LpVtbl[4])(@this, guidPtr);
            }
            return ret;
        }

    }
}

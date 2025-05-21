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
    [NativeName("Name", "ISlangSharedLibrary")]
    public unsafe partial struct ISlangSharedLibrary : IComVtbl<ISlangSharedLibrary>, IComVtbl<ISlangCastable>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangCastable(ISlangSharedLibrary val)
            => Unsafe.As<ISlangSharedLibrary, ISlangCastable>(ref val);

        public static implicit operator ISlangUnknown(ISlangSharedLibrary val)
            => Unsafe.As<ISlangSharedLibrary, ISlangUnknown>(ref val);

        public ISlangSharedLibrary
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
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* guid)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID guid)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (SlangUUID* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* FindSymbolAddressByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, byte*, void*>)@this->LpVtbl[4])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* FindSymbolAddressByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, byte*, void*>)@this->LpVtbl[4])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* FindSymbolAddressByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (ISlangSharedLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibrary*, byte*, void*>)@this->LpVtbl[4])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

    }
}

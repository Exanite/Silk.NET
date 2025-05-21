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
    [NativeName("Name", "ISlangSharedLibraryLoader")]
    public unsafe partial struct ISlangSharedLibraryLoader : IComVtbl<ISlangSharedLibraryLoader>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(ISlangSharedLibraryLoader val)
            => Unsafe.As<ISlangSharedLibraryLoader, ISlangUnknown>(ref val);

        public ISlangSharedLibraryLoader
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
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangSharedLibrary** sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangSharedLibrary* sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangSharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangSharedLibrary** sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangSharedLibrary* sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangSharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangSharedLibrary** sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangSharedLibrary* sharedLibraryOut)
        {
            var @this = (ISlangSharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangSharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangSharedLibraryLoader*, byte*, ISlangSharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

    }
}

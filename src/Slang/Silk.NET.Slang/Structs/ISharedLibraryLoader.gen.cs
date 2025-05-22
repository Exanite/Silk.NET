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
    public unsafe partial struct ISharedLibraryLoader : IComVtbl<ISharedLibraryLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ISharedLibraryLoader val)
            => Unsafe.As<ISharedLibraryLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public ISharedLibraryLoader
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
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISharedLibrary** sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISharedLibrary* sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISharedLibrary** sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISharedLibrary* sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISharedLibrary** sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSharedLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISharedLibrary* sharedLibraryOut)
        {
            var @this = (ISharedLibraryLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

    }
}

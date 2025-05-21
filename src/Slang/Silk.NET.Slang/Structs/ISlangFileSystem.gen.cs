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
    [NativeName("Name", "ISlangFileSystem")]
    public unsafe partial struct ISlangFileSystem : IComVtbl<ISlangFileSystem>, IComVtbl<ISlangCastable>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangCastable(ISlangFileSystem val)
            => Unsafe.As<ISlangFileSystem, ISlangCastable>(ref val);

        public static implicit operator ISlangUnknown(ISlangFileSystem val)
            => Unsafe.As<ISlangFileSystem, ISlangUnknown>(ref val);

        public ISlangFileSystem
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
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* guid)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID guid)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (SlangUUID* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outBlobPtr = &outBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

    }
}

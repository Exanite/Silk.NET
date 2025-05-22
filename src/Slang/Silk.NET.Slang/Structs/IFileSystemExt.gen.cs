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
    [NativeName("Name", "ISlangFileSystemExt")]
    public unsafe partial struct IFileSystemExt : IComVtbl<IFileSystemExt>, IComVtbl<IFileSystem>, IComVtbl<ICastable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IFileSystem(IFileSystemExt val)
            => Unsafe.As<IFileSystemExt, IFileSystem>(ref val);

        public static implicit operator ICastable(IFileSystemExt val)
            => Unsafe.As<IFileSystemExt, ICastable>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IFileSystemExt val)
            => Unsafe.As<IFileSystemExt, Silk.NET.Core.Native.IUnknown>(ref val);

        public IFileSystemExt
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
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* guid)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid guid)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (Uuid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, Uuid*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, path, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, path, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outBlobPtr = &outBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outBlob)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentity);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outUniqueIdentity)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (IBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob** pathOutPtr = &pathOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                }
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PathType* pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref PathType pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PathType* pathTypeOutPtr = &pathTypeOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PathType* pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref PathType pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (PathType* pathTypeOutPtr = &pathTypeOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PathType* pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref PathType pathTypeOut)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (PathType* pathTypeOutPtr = &pathTypeOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outPathPtr = &outPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outPathPtr = &outPath)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outPath)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outPathPtr = &outPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearCache()
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IFileSystemExt*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (void* userDataPtr = &userData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OSPathKind GetOSPathKind()
        {
            var @this = (IFileSystemExt*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OSPathKind ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IFileSystemExt*, OSPathKind>)@this->LpVtbl[11])(@this);
            return ret;
        }

    }
}

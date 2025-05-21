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
    [NativeName("Name", "ISlangMutableFileSystem")]
    public unsafe partial struct ISlangMutableFileSystem : IComVtbl<ISlangMutableFileSystem>, IComVtbl<ISlangFileSystemExt>, IComVtbl<ISlangFileSystem>, IComVtbl<ISlangCastable>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangFileSystemExt(ISlangMutableFileSystem val)
            => Unsafe.As<ISlangMutableFileSystem, ISlangFileSystemExt>(ref val);

        public static implicit operator ISlangFileSystem(ISlangMutableFileSystem val)
            => Unsafe.As<ISlangMutableFileSystem, ISlangFileSystem>(ref val);

        public static implicit operator ISlangCastable(ISlangMutableFileSystem val)
            => Unsafe.As<ISlangMutableFileSystem, ISlangCastable>(ref val);

        public static implicit operator ISlangUnknown(ISlangMutableFileSystem val)
            => Unsafe.As<ISlangMutableFileSystem, ISlangUnknown>(ref val);

        public ISlangMutableFileSystem
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
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* guid)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* CastAs([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID guid)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (SlangUUID* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outBlobPtr = &outBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* outBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentity);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outUniqueIdentityPtr = &outUniqueIdentity)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outUniqueIdentityPtr = &outUniqueIdentity)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileUniqueIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* outUniqueIdentity)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outUniqueIdentityPtr = &outUniqueIdentity)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (ISlangBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob** pathOutPtr = &pathOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fromPathPtr = &fromPath)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                }
            }
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalcCombinedPath(SlangPathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* pathOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, SlangPathType, byte*, byte*, ISlangBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)fromPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, SlangPathType* pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref SlangPathType pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangPathType* pathTypeOutPtr = &pathTypeOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, SlangPathType* pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref SlangPathType pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (SlangPathType* pathTypeOutPtr = &pathTypeOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, SlangPathType* pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPathType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref SlangPathType pathTypeOut)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (SlangPathType* pathTypeOutPtr = &pathTypeOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, SlangPathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outPathPtr = &outPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outPathPtr = &outPath)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPath(PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* outPath)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outPathPtr = &outPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, PathKind, byte*, ISlangBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearCache()
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (void* userDataPtr = &userData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumeratePathContents([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, void* userData)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumeratePathContents<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OSPathKind GetOSPathKind()
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OSPathKind ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, OSPathKind>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, path, data, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFile<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, path, dataPtr, size);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, data, size);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveFile<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (void* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, dataPtr, size);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, data, size);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveFile<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, dataPtr, size);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, path, dataBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* dataBlobPtr = &dataBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, path, dataBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* dataBlobPtr = &dataBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlob);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveFileBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob dataBlob)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* dataBlobPtr = &dataBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, ISlangBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlobPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Remove([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Remove([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Remove([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, pathPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDirectory([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDirectory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDirectory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
        {
            var @this = (ISlangMutableFileSystem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, pathPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

    }
}

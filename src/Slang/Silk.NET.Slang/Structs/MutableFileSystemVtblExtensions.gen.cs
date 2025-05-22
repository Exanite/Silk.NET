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

namespace Silk.NET.Slang;

public unsafe static class MutableFileSystemVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMutableFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMutableFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void*>)@this->LpVtbl[3])(@this, guid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (Uuid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, Uuid*, void*>)@this->LpVtbl[3])(@this, guidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, path, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, path, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, path, outUniqueIdentityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentity);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob** outUniqueIdentityPtr = &outUniqueIdentity)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob**, int>)@this->LpVtbl[5])(@this, pathPtr, outUniqueIdentityPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** pathOutPtr = &pathOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, path, pathOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOut);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob** pathOutPtr = &pathOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPath, pathPtr, pathOutPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** pathOutPtr = &pathOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fromPathPtr = &fromPath)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOut);
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        fixed (IBlob** pathOutPtr = &pathOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, path, pathOutPtr);
        }
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
        }
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob** pathOutPtr = &pathOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
            }
        }
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOut);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fromPathPtr = (byte*) SilkMarshal.StringToPtr(fromPath, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob** pathOutPtr = &pathOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathType, byte*, byte*, IBlob**, int>)@this->LpVtbl[6])(@this, fromPathType, fromPathPtr, pathPtr, pathOutPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)fromPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PathType* pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref PathType pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PathType* pathTypeOutPtr = &pathTypeOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, path, pathTypeOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PathType* pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref PathType pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (PathType* pathTypeOutPtr = &pathTypeOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PathType* pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOut);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref PathType pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (PathType* pathTypeOutPtr = &pathTypeOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PathType*, int>)@this->LpVtbl[7])(@this, pathPtr, pathTypeOutPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outPathPtr = &outPath)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, path, outPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob** outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob* outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob** outPathPtr = &outPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPath);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* outPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob** outPathPtr = &outPath)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, PathKind, byte*, IBlob**, int>)@this->LpVtbl[8])(@this, kind, pathPtr, outPathPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearCache(this ComPtr<IMutableFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, void* userData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* userDataPtr = &userData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, path, callback, userDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, void* userData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, void* userData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userData);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, ref T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (void* userDataPtr = &userData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, PfnFileSystemContentsCallBack, void*, int>)@this->LpVtbl[10])(@this, pathPtr, callback, userDataPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OSPathKind GetOSPathKind(this ComPtr<IMutableFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        OSPathKind ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, OSPathKind>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, path, data, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, path, dataPtr, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, data, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, dataPtr, size);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, data, size);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (void* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, void*, nuint, int>)@this->LpVtbl[12])(@this, pathPtr, dataPtr, size);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, path, dataBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob* dataBlobPtr = &dataBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, path, dataBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob* dataBlobPtr = &dataBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlobPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlob);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob dataBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob* dataBlobPtr = &dataBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, IBlob*, int>)@this->LpVtbl[13])(@this, pathPtr, dataBlobPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Remove(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Remove(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Remove(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[14])(@this, pathPtr);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDirectory(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CreateDirectory(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CreateDirectory(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMutableFileSystem*, byte*, int>)@this->LpVtbl[15])(@this, pathPtr);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CastAs(in guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in path.GetPinnableReference(), outBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in path.GetPinnableReference(), ref outBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileUniqueIdentity(in path.GetPinnableReference(), outUniqueIdentity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileUniqueIdentity(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* outUniqueIdentity)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileUniqueIdentity(in path.GetPinnableReference(), ref outUniqueIdentity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, fromPath, in path.GetPinnableReference(), pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, fromPath, in path.GetPinnableReference(), ref pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), path, pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), path, ref pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), in path.GetPinnableReference(), pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), in path.GetPinnableReference(), ref pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), path, pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, in fromPath.GetPinnableReference(), path, ref pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, fromPath, in path.GetPinnableReference(), pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalcCombinedPath(this ComPtr<IMutableFileSystem> thisVtbl, PathType fromPathType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* pathOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalcCombinedPath(fromPathType, fromPath, in path.GetPinnableReference(), ref pathOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<PathType> pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPathType(path, ref pathTypeOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, PathType* pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPathType(in path.GetPinnableReference(), pathTypeOut);
    }

    /// <summary>To be documented.</summary>
    public static int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<PathType> pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPathType(in path.GetPinnableReference(), ref pathTypeOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPathType(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<PathType> pathTypeOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPathType(path, ref pathTypeOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob** outPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPath(kind, in path.GetPinnableReference(), outPath);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPath(this ComPtr<IMutableFileSystem> thisVtbl, PathKind kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref IBlob* outPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPath(kind, in path.GetPinnableReference(), ref outPath);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, PfnFileSystemContentsCallBack callback, Span<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumeratePathContents(path, callback, ref userData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumeratePathContents(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, PfnFileSystemContentsCallBack callback, void* userData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumeratePathContents(in path.GetPinnableReference(), callback, userData);
    }

    /// <summary>To be documented.</summary>
    public static int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, PfnFileSystemContentsCallBack callback, Span<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumeratePathContents(in path.GetPinnableReference(), callback, ref userData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumeratePathContents<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, PfnFileSystemContentsCallBack callback, Span<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumeratePathContents(path, callback, ref userData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFile(path, in data.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFile(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFile(in path.GetPinnableReference(), data, size);
    }

    /// <summary>To be documented.</summary>
    public static int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFile(in path.GetPinnableReference(), in data.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static int SaveFile<T0>(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFile(path, in data.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<IBlob> dataBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFileBlob(path, ref dataBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob* dataBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFileBlob(in path.GetPinnableReference(), dataBlob);
    }

    /// <summary>To be documented.</summary>
    public static int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<IBlob> dataBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFileBlob(in path.GetPinnableReference(), ref dataBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SaveFileBlob(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<IBlob> dataBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveFileBlob(path, ref dataBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Remove(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Remove(in path.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateDirectory(this ComPtr<IMutableFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDirectory(in path.GetPinnableReference());
    }

}

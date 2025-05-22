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

public unsafe static class SlangFileSystemVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISlangFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISlangFileSystem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void*>)@this->LpVtbl[3])(@this, guid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (Uuid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, Uuid*, void*>)@this->LpVtbl[3])(@this, guidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, path, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlob);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangFileSystem*, byte*, ISlangBlob**, int>)@this->LpVtbl[4])(@this, pathPtr, outBlobPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CastAs(in guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in path.GetPinnableReference(), outBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<ISlangFileSystem> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in path.GetPinnableReference(), ref outBlob);
    }

}

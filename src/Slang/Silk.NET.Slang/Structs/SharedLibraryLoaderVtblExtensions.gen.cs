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

public unsafe static class SharedLibraryLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<ISharedLibraryLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISharedLibraryLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISharedLibrary** sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISharedLibrary* sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, path, sharedLibraryOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISharedLibrary** sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISharedLibrary* sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISharedLibrary** sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOut);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISharedLibrary* sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISharedLibrary** sharedLibraryOutPtr = &sharedLibraryOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISharedLibraryLoader*, byte*, ISharedLibrary**, int>)@this->LpVtbl[3])(@this, pathPtr, sharedLibraryOutPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISharedLibrary** sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadSharedLibrary(in path.GetPinnableReference(), sharedLibraryOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSharedLibrary(this ComPtr<ISharedLibraryLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ref ISharedLibrary* sharedLibraryOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadSharedLibrary(in path.GetPinnableReference(), ref sharedLibraryOut);
    }

}

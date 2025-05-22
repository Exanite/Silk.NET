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

public unsafe static class GlobalSessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IGlobalSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IGlobalSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionDesc* desc, ISession** outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, desc, outSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionDesc* desc, ref ISession* outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISession** outSessionPtr = &outSession)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, desc, outSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionDesc desc, ISession** outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* descPtr = &desc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, descPtr, outSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionDesc desc, ref ISession* outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* descPtr = &desc)
        {
            fixed (ISession** outSessionPtr = &outSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, descPtr, outSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ProfileID FindProfile(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
    {
        var @this = thisVtbl.Handle;
        ProfileID ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, ProfileID>)@this->LpVtbl[4])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ProfileID FindProfile(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
    {
        var @this = thisVtbl.Handle;
        ProfileID ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, ProfileID>)@this->LpVtbl[4])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ProfileID FindProfile(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        ProfileID ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, ProfileID>)@this->LpVtbl[4])(@this, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDownstreamCompilerPath(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, path);
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPath(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, pathPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPath(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, pathPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* preludeText)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeText);
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte preludeText)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* preludeTextPtr = &preludeText)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeTextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string preludeText)
    {
        var @this = thisVtbl.Handle;
        var preludeTextPtr = (byte*) SilkMarshal.StringToPtr(preludeText, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeTextPtr);
        SilkMarshal.Free((nint)preludeTextPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, ISlangBlob** outPrelude)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, ISlangBlob**, void>)@this->LpVtbl[7])(@this, passThrough, outPrelude);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, ref ISlangBlob* outPrelude)
    {
        var @this = thisVtbl.Handle;
        fixed (ISlangBlob** outPreludePtr = &outPrelude)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, ISlangBlob**, void>)@this->LpVtbl[7])(@this, passThrough, outPreludePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetBuildTagString(this ComPtr<IGlobalSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetBuildTagStringS(this ComPtr<IGlobalSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, string>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDefaultDownstreamCompiler(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, PassThrough defaultCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, PassThrough, int>)@this->LpVtbl[9])(@this, sourceLanguage, defaultCompiler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PassThrough GetDefaultDownstreamCompiler(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage)
    {
        var @this = thisVtbl.Handle;
        PassThrough ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, PassThrough>)@this->LpVtbl[10])(@this, sourceLanguage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* preludeText)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeText);
    }

    /// <summary>To be documented.</summary>
    public static void SetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte preludeText)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* preludeTextPtr = &preludeText)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeTextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string preludeText)
    {
        var @this = thisVtbl.Handle;
        var preludeTextPtr = (byte*) SilkMarshal.StringToPtr(preludeText, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeTextPtr);
        SilkMarshal.Free((nint)preludeTextPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, ISlangBlob** outPrelude)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, ISlangBlob**, void>)@this->LpVtbl[12])(@this, sourceLanguage, outPrelude);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, ref ISlangBlob* outPrelude)
    {
        var @this = thisVtbl.Handle;
        fixed (ISlangBlob** outPreludePtr = &outPrelude)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SourceLanguage, ISlangBlob**, void>)@this->LpVtbl[12])(@this, sourceLanguage, outPreludePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompileRequest(this ComPtr<IGlobalSession> thisVtbl, ICompileRequest** outCompileRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ICompileRequest**, int>)@this->LpVtbl[13])(@this, outCompileRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompileRequest(this ComPtr<IGlobalSession> thisVtbl, ref ICompileRequest* outCompileRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileRequest** outCompileRequestPtr = &outCompileRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ICompileRequest**, int>)@this->LpVtbl[13])(@this, outCompileRequestPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceString);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourceStringPtr = &sourceString)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceStringPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
    {
        var @this = thisVtbl.Handle;
        var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceStringPtr);
        SilkMarshal.Free((nint)sourceStringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourcePathPtr = &sourcePath)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceString);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourcePathPtr = &sourcePath)
        {
            fixed (byte* sourceStringPtr = &sourceString)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourcePathPtr = &sourcePath)
        {
        var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
        SilkMarshal.Free((nint)sourceStringPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
    {
        var @this = thisVtbl.Handle;
        var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceString);
        SilkMarshal.Free((nint)sourcePathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString)
    {
        var @this = thisVtbl.Handle;
        var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
        fixed (byte* sourceStringPtr = &sourceString)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
        }
        SilkMarshal.Free((nint)sourcePathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
    {
        var @this = thisVtbl.Handle;
        var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
        var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
        SilkMarshal.Free((nint)sourceStringPtr);
        SilkMarshal.Free((nint)sourcePathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSharedLibraryLoader(this ComPtr<IGlobalSession> thisVtbl, ISlangSharedLibraryLoader* loader)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*, void>)@this->LpVtbl[15])(@this, loader);
    }

    /// <summary>To be documented.</summary>
    public static void SetSharedLibraryLoader(this ComPtr<IGlobalSession> thisVtbl, ref ISlangSharedLibraryLoader loader)
    {
        var @this = thisVtbl.Handle;
        fixed (ISlangSharedLibraryLoader* loaderPtr = &loader)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*, void>)@this->LpVtbl[15])(@this, loaderPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe ISlangSharedLibraryLoader* GetSharedLibraryLoader(this ComPtr<IGlobalSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ISlangSharedLibraryLoader* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckCompileTargetSupport(this ComPtr<IGlobalSession> thisVtbl, CompileTarget target)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, CompileTarget, int>)@this->LpVtbl[17])(@this, target);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckPassThroughSupport(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, PassThrough, int>)@this->LpVtbl[18])(@this, passThrough);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CompileCoreModule(this ComPtr<IGlobalSession> thisVtbl, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint, int>)@this->LpVtbl[19])(@this, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadCoreModule(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coreModule, nuint coreModuleSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, void*, nuint, int>)@this->LpVtbl[20])(@this, coreModule, coreModuleSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadCoreModule<T0>(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 coreModule, nuint coreModuleSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* coreModulePtr = &coreModule)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, void*, nuint, int>)@this->LpVtbl[20])(@this, coreModulePtr, coreModuleSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveCoreModule(this ComPtr<IGlobalSession> thisVtbl, ArchiveType archiveType, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ArchiveType, ISlangBlob**, int>)@this->LpVtbl[21])(@this, archiveType, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveCoreModule(this ComPtr<IGlobalSession> thisVtbl, ArchiveType archiveType, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ArchiveType, ISlangBlob**, int>)@this->LpVtbl[21])(@this, archiveType, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe CapabilityID FindCapability(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
    {
        var @this = thisVtbl.Handle;
        CapabilityID ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, CapabilityID>)@this->LpVtbl[22])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CapabilityID FindCapability(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
    {
        var @this = thisVtbl.Handle;
        CapabilityID ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, CapabilityID>)@this->LpVtbl[22])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CapabilityID FindCapability(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        CapabilityID ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, CapabilityID>)@this->LpVtbl[22])(@this, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerForTransition(this ComPtr<IGlobalSession> thisVtbl, CompileTarget source, CompileTarget target, PassThrough compiler)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, CompileTarget, CompileTarget, PassThrough, void>)@this->LpVtbl[23])(@this, source, target, compiler);
    }

    /// <summary>To be documented.</summary>
    public static PassThrough GetDownstreamCompilerForTransition(this ComPtr<IGlobalSession> thisVtbl, CompileTarget source, CompileTarget target)
    {
        var @this = thisVtbl.Handle;
        PassThrough ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, CompileTarget, CompileTarget, PassThrough>)@this->LpVtbl[24])(@this, source, target);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, double* outTotalTime, double* outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTime, outDownstreamTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, double* outTotalTime, ref double outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        fixed (double* outDownstreamTimePtr = &outDownstreamTime)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTime, outDownstreamTimePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, ref double outTotalTime, double* outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        fixed (double* outTotalTimePtr = &outTotalTime)
        {
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTimePtr, outDownstreamTime);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, ref double outTotalTime, ref double outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        fixed (double* outTotalTimePtr = &outTotalTime)
        {
            fixed (double* outDownstreamTimePtr = &outDownstreamTime)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTimePtr, outDownstreamTimePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSPIRVCoreGrammar(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* jsonPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSPIRVCoreGrammar(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte jsonPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* jsonPathPtr = &jsonPath)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSPIRVCoreGrammar(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string jsonPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jsonPathPtr = (byte*) SilkMarshal.StringToPtr(jsonPath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPathPtr);
        SilkMarshal.Free((nint)jsonPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDesc, outAuxAllocation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDesc, outAuxAllocationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDescPtr, outAuxAllocation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
        {
            fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDescPtr, outAuxAllocationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** argvPtr = &argv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDesc, outAuxAllocation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** argvPtr = &argv)
        {
            fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDesc, outAuxAllocationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** argvPtr = &argv)
        {
            fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDescPtr, outAuxAllocation);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** argvPtr = &argv)
        {
            fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
            {
                fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDescPtr, outAuxAllocationPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, SessionDesc* sessionDesc, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDesc, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, SessionDesc* sessionDesc, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDesc, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, ref SessionDesc sessionDesc, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* sessionDescPtr = &sessionDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDescPtr, outBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, ref SessionDesc sessionDesc, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SessionDesc* sessionDescPtr = &sessionDesc)
        {
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDescPtr, outBlobPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CompileBuiltinModule(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, uint, int>)@this->LpVtbl[29])(@this, module, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadBuiltinModule(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* moduleData, nuint sizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, void*, nuint, int>)@this->LpVtbl[30])(@this, module, moduleData, sizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadBuiltinModule<T0>(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 moduleData, nuint sizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* moduleDataPtr = &moduleData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, void*, nuint, int>)@this->LpVtbl[30])(@this, module, moduleDataPtr, sizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveBuiltinModule(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, ArchiveType archiveType, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, ArchiveType, ISlangBlob**, int>)@this->LpVtbl[31])(@this, module, archiveType, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveBuiltinModule(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, ArchiveType archiveType, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, ArchiveType, ISlangBlob**, int>)@this->LpVtbl[31])(@this, module, archiveType, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionDesc> desc, ISession** outSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(in desc.GetPinnableReference(), outSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionDesc> desc, ref ISession* outSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(in desc.GetPinnableReference(), ref outSession);
    }

    /// <summary>To be documented.</summary>
    public static ProfileID FindProfile(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindProfile(in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPath(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDownstreamCompilerPath(passThrough, in path.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDownstreamCompilerPrelude(this ComPtr<IGlobalSession> thisVtbl, PassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> preludeText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDownstreamCompilerPrelude(passThrough, in preludeText.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetLanguagePrelude(this ComPtr<IGlobalSession> thisVtbl, SourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> preludeText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetLanguagePrelude(sourceLanguage, in preludeText.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddBuiltins(sourcePath, in sourceString.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddBuiltins(in sourcePath.GetPinnableReference(), sourceString);
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddBuiltins(in sourcePath.GetPinnableReference(), in sourceString.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddBuiltins(in sourcePath.GetPinnableReference(), sourceString);
    }

    /// <summary>To be documented.</summary>
    public static void AddBuiltins(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddBuiltins(sourcePath, in sourceString.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetSharedLibraryLoader(this ComPtr<IGlobalSession> thisVtbl, Span<ISlangSharedLibraryLoader> loader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetSharedLibraryLoader(ref loader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int LoadCoreModule<T0>(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coreModule, nuint coreModuleSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadCoreModule(in coreModule.GetPinnableReference(), coreModuleSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static CapabilityID FindCapability(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindCapability(in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, double* outTotalTime, Span<double> outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCompilerElapsedTime(outTotalTime, ref outDownstreamTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, Span<double> outTotalTime, double* outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCompilerElapsedTime(ref outTotalTime.GetPinnableReference(), outDownstreamTime);
    }

    /// <summary>To be documented.</summary>
    public static void GetCompilerElapsedTime(this ComPtr<IGlobalSession> thisVtbl, Span<double> outTotalTime, Span<double> outDownstreamTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCompilerElapsedTime(ref outTotalTime.GetPinnableReference(), ref outDownstreamTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetSPIRVCoreGrammar(this ComPtr<IGlobalSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> jsonPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSPIRVCoreGrammar(in jsonPath.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
        var ret = @this->ParseCommandLineArguments(argc, argv, outSessionDesc, outAuxAllocation);
        SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
        SilkMarshal.Free((nint) argv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments<TI0>(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseCommandLineArguments(argc, argv, outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
        var ret = @this->ParseCommandLineArguments(argc, argv, outSessionDesc, ref outAuxAllocation);
        SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
        SilkMarshal.Free((nint) argv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
        var ret = @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, outAuxAllocation);
        SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
        SilkMarshal.Free((nint) argv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, Span<SessionDesc> outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc.GetPinnableReference(), outAuxAllocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments<TI0>(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
        var ret = @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, ref outAuxAllocation);
        SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
        SilkMarshal.Free((nint) argv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, Span<SessionDesc> outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc.GetPinnableReference(), ref outAuxAllocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments<TI0>(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, SessionDesc* outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseCommandLineArguments(argc, in argv, outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, Span<SessionDesc> outSessionDesc, ISlangUnknown** outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseCommandLineArguments(argc, in argv, ref outSessionDesc.GetPinnableReference(), outAuxAllocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments<TI0>(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, ref SessionDesc outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseCommandLineArguments(argc, in argv, ref outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseCommandLineArguments(this ComPtr<IGlobalSession> thisVtbl, int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* argv, Span<SessionDesc> outSessionDesc, ref ISlangUnknown* outAuxAllocation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseCommandLineArguments(argc, in argv, ref outSessionDesc.GetPinnableReference(), ref outAuxAllocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, Span<SessionDesc> sessionDesc, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSessionDescDigest(ref sessionDesc.GetPinnableReference(), outBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionDescDigest(this ComPtr<IGlobalSession> thisVtbl, Span<SessionDesc> sessionDesc, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSessionDescDigest(ref sessionDesc.GetPinnableReference(), ref outBlob);
    }

    /// <summary>To be documented.</summary>
    public static int LoadBuiltinModule<T0>(this ComPtr<IGlobalSession> thisVtbl, BuiltinModuleName module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> moduleData, nuint sizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadBuiltinModule(module, in moduleData.GetPinnableReference(), sizeInBytes);
    }

}

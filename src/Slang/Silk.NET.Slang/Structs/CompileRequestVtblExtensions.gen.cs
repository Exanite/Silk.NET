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

public unsafe static class CompileRequestVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetFileSystem(this ComPtr<ICompileRequest> thisVtbl, IFileSystem* fileSystem)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void>)@this->LpVtbl[3])(@this, fileSystem);
    }

    /// <summary>To be documented.</summary>
    public static void SetFileSystem(this ComPtr<ICompileRequest> thisVtbl, ref IFileSystem fileSystem)
    {
        var @this = thisVtbl.Handle;
        fixed (IFileSystem* fileSystemPtr = &fileSystem)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void>)@this->LpVtbl[3])(@this, fileSystemPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetCompileFlags(this ComPtr<ICompileRequest> thisVtbl, uint flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint, void>)@this->LpVtbl[4])(@this, flags);
    }

    /// <summary>To be documented.</summary>
    public static uint GetCompileFlags(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDumpIntermediates(this ComPtr<ICompileRequest> thisVtbl, int enable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, void>)@this->LpVtbl[6])(@this, enable);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDumpIntermediatePrefix(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* prefix)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefix);
    }

    /// <summary>To be documented.</summary>
    public static void SetDumpIntermediatePrefix(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte prefix)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* prefixPtr = &prefix)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefixPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDumpIntermediatePrefix(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string prefix)
    {
        var @this = thisVtbl.Handle;
        var prefixPtr = (byte*) SilkMarshal.StringToPtr(prefix, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefixPtr);
        SilkMarshal.Free((nint)prefixPtr);
    }

    /// <summary>To be documented.</summary>
    public static void SetLineDirectiveMode(this ComPtr<ICompileRequest> thisVtbl, LineDirectiveMode mode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, LineDirectiveMode, void>)@this->LpVtbl[8])(@this, mode);
    }

    /// <summary>To be documented.</summary>
    public static void SetCodeGenTarget(this ComPtr<ICompileRequest> thisVtbl, CompileTarget target)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, CompileTarget, void>)@this->LpVtbl[9])(@this, target);
    }

    /// <summary>To be documented.</summary>
    public static int AddCodeGenTarget(this ComPtr<ICompileRequest> thisVtbl, CompileTarget target)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, CompileTarget, int>)@this->LpVtbl[10])(@this, target);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetProfile(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, ProfileID profile)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ProfileID, void>)@this->LpVtbl[11])(@this, targetIndex, profile);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetFlags(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, uint flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, uint, void>)@this->LpVtbl[12])(@this, targetIndex, flags);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetFloatingPointMode(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, FloatingPointMode mode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, FloatingPointMode, void>)@this->LpVtbl[13])(@this, targetIndex, mode);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetMatrixLayoutMode(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, MatrixLayoutMode mode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, MatrixLayoutMode, void>)@this->LpVtbl[14])(@this, targetIndex, mode);
    }

    /// <summary>To be documented.</summary>
    public static void SetMatrixLayoutMode(this ComPtr<ICompileRequest> thisVtbl, MatrixLayoutMode mode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, MatrixLayoutMode, void>)@this->LpVtbl[15])(@this, mode);
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugInfoLevel(this ComPtr<ICompileRequest> thisVtbl, DebugInfoLevel level)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, DebugInfoLevel, void>)@this->LpVtbl[16])(@this, level);
    }

    /// <summary>To be documented.</summary>
    public static void SetOptimizationLevel(this ComPtr<ICompileRequest> thisVtbl, OptimizationLevel level)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, OptimizationLevel, void>)@this->LpVtbl[17])(@this, level);
    }

    /// <summary>To be documented.</summary>
    public static void SetOutputContainerFormat(this ComPtr<ICompileRequest> thisVtbl, ContainerFormat format)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, ContainerFormat, void>)@this->LpVtbl[18])(@this, format);
    }

    /// <summary>To be documented.</summary>
    public static void SetPassThrough(this ComPtr<ICompileRequest> thisVtbl, PassThrough passThrough)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, PassThrough, void>)@this->LpVtbl[19])(@this, passThrough);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDiagnosticCallback(this ComPtr<ICompileRequest> thisVtbl, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, PfnDiagnosticCallback, void*, void>)@this->LpVtbl[20])(@this, callback, userData);
    }

    /// <summary>To be documented.</summary>
    public static void SetDiagnosticCallback<T0>(this ComPtr<ICompileRequest> thisVtbl, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* userDataPtr = &userData)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, PfnDiagnosticCallback, void*, void>)@this->LpVtbl[20])(@this, callback, userDataPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetWriter(this ComPtr<ICompileRequest> thisVtbl, WriterChannel channel, IWriter* writer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*, void>)@this->LpVtbl[21])(@this, channel, writer);
    }

    /// <summary>To be documented.</summary>
    public static void SetWriter(this ComPtr<ICompileRequest> thisVtbl, WriterChannel channel, ref IWriter writer)
    {
        var @this = thisVtbl.Handle;
        fixed (IWriter* writerPtr = &writer)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*, void>)@this->LpVtbl[21])(@this, channel, writerPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe IWriter* GetWriter(this ComPtr<ICompileRequest> thisVtbl, WriterChannel channel)
    {
        var @this = thisVtbl.Handle;
        IWriter* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*>)@this->LpVtbl[22])(@this, channel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddSearchPath(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* searchDir)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDir);
    }

    /// <summary>To be documented.</summary>
    public static void AddSearchPath(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte searchDir)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* searchDirPtr = &searchDir)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDirPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddSearchPath(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string searchDir)
    {
        var @this = thisVtbl.Handle;
        var searchDirPtr = (byte*) SilkMarshal.StringToPtr(searchDir, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDirPtr);
        SilkMarshal.Free((nint)searchDirPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, value);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* valuePtr = &value)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, valuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, value);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, value);
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        fixed (byte* valuePtr = &value)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
        }
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessCommandLineArguments(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** args, int argCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte**, int, int>)@this->LpVtbl[25])(@this, args, argCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessCommandLineArguments(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* args, int argCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** argsPtr = &args)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte**, int, int>)@this->LpVtbl[25])(@this, argsPtr, argCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTranslationUnit(this ComPtr<ICompileRequest> thisVtbl, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddTranslationUnit(this ComPtr<ICompileRequest> thisVtbl, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddTranslationUnit(this ComPtr<ICompileRequest> thisVtbl, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDefaultModuleName(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* defaultModuleName)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleName);
    }

    /// <summary>To be documented.</summary>
    public static void SetDefaultModuleName(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte defaultModuleName)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* defaultModuleNamePtr = &defaultModuleName)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleNamePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDefaultModuleName(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string defaultModuleName)
    {
        var @this = thisVtbl.Handle;
        var defaultModuleNamePtr = (byte*) SilkMarshal.StringToPtr(defaultModuleName, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleNamePtr);
        SilkMarshal.Free((nint)defaultModuleNamePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, value);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* valuePtr = &value)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, valuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, value);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* keyPtr = &key)
        {
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, value);
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        fixed (byte* valuePtr = &value)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
        }
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        SilkMarshal.Free((nint)keyPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceFile(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, path);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceFile(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, pathPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceFile(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, pathPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, source);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourcePtr = &source)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, sourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
    {
        var @this = thisVtbl.Handle;
        var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, sourcePtr);
        SilkMarshal.Free((nint)sourcePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, source);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* sourcePtr = &source)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
        var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
        SilkMarshal.Free((nint)sourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, source);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* sourcePtr = &source)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
        SilkMarshal.Free((nint)sourcePtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePath, libData, libDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* libDataPtr = &libData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePath, libDataPtr, libDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* basePathPtr = &basePath)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libData, libDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* basePathPtr = &basePath)
        {
            fixed (void* libDataPtr = &libData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libDataPtr, libDataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var basePathPtr = (byte*) SilkMarshal.StringToPtr(basePath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libData, libDataSize);
        SilkMarshal.Free((nint)basePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var basePathPtr = (byte*) SilkMarshal.StringToPtr(basePath, NativeStringEncoding.UTF8);
        fixed (void* libDataPtr = &libData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libDataPtr, libDataSize);
        }
        SilkMarshal.Free((nint)basePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourceEndPtr = &sourceEnd)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEndPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEnd);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEnd);
        SilkMarshal.Free((nint)sourceBeginPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        fixed (byte* sourceEndPtr = &sourceEnd)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
        }
        SilkMarshal.Free((nint)sourceBeginPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        SilkMarshal.Free((nint)sourceBeginPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEnd);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                fixed (byte* sourceEndPtr = &sourceEnd)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
        SilkMarshal.Free((nint)sourceBeginPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            }
        SilkMarshal.Free((nint)sourceBeginPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        SilkMarshal.Free((nint)sourceBeginPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEnd);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* sourceEndPtr = &sourceEnd)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* sourceBeginPtr = &sourceBegin)
        {
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
        SilkMarshal.Free((nint)sourceBeginPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        fixed (byte* sourceEndPtr = &sourceEnd)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
        }
        SilkMarshal.Free((nint)sourceBeginPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
        var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
        SilkMarshal.Free((nint)sourceEndPtr);
        SilkMarshal.Free((nint)sourceBeginPtr);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* sourceBlob)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, path, sourceBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob sourceBlob)
    {
        var @this = thisVtbl.Handle;
        fixed (IBlob* sourceBlobPtr = &sourceBlob)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, path, sourceBlobPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* sourceBlob)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlob);
        }
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob sourceBlob)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pathPtr = &path)
        {
            fixed (IBlob* sourceBlobPtr = &sourceBlob)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlobPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* sourceBlob)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlob);
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob sourceBlob)
    {
        var @this = thisVtbl.Handle;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (IBlob* sourceBlobPtr = &sourceBlob)
        {
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlobPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPoint(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, name, stage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddEntryPoint(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, namePtr, stage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddEntryPoint(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, namePtr, stage);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, name, stage, genericArgCount, genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** genericArgsPtr = &genericArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, name, stage, genericArgCount, genericArgsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (byte** genericArgsPtr = &genericArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgs);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (byte** genericArgsPtr = &genericArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgsPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGlobalGenericArgs(this ComPtr<ICompileRequest> thisVtbl, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte**, int>)@this->LpVtbl[36])(@this, genericArgCount, genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGlobalGenericArgs(this ComPtr<ICompileRequest> thisVtbl, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** genericArgsPtr = &genericArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte**, int>)@this->LpVtbl[36])(@this, genericArgCount, genericArgsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypeNameForGlobalExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForGlobalExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* typeNamePtr = &typeName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForGlobalExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typeNamePtr = (byte*) SilkMarshal.StringToPtr(typeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeNamePtr);
        SilkMarshal.Free((nint)typeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypeNameForEntryPointExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForEntryPointExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* typeNamePtr = &typeName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForEntryPointExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typeNamePtr = (byte*) SilkMarshal.StringToPtr(typeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeNamePtr);
        SilkMarshal.Free((nint)typeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetAllowGLSLInput(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[39])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static int Compile(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[40])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetDiagnosticOutput(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*>)@this->LpVtbl[41])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetDiagnosticOutputS(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, string>)@this->LpVtbl[41])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDiagnosticOutputBlob(this ComPtr<ICompileRequest> thisVtbl, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[42])(@this, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDiagnosticOutputBlob(this ComPtr<ICompileRequest> thisVtbl, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[42])(@this, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDependencyFileCount(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetDependencyFilePath(this ComPtr<ICompileRequest> thisVtbl, int index)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*>)@this->LpVtbl[44])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetDependencyFilePathS(this ComPtr<ICompileRequest> thisVtbl, int index)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, string>)@this->LpVtbl[44])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTranslationUnitCount(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[45])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetEntryPointSource(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*>)@this->LpVtbl[46])(@this, entryPointIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetEntryPointSourceS(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, string>)@this->LpVtbl[46])(@this, entryPointIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetEntryPointCode(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, nuint* outSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, nuint*, void*>)@this->LpVtbl[47])(@this, entryPointIndex, outSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetEntryPointCode(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, ref nuint outSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (nuint* outSizePtr = &outSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, nuint*, void*>)@this->LpVtbl[47])(@this, entryPointIndex, outSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCodeBlob(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int targetIndex, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, IBlob**, int>)@this->LpVtbl[48])(@this, entryPointIndex, targetIndex, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCodeBlob(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int targetIndex, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, IBlob**, int>)@this->LpVtbl[48])(@this, entryPointIndex, targetIndex, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, ISharedLibrary**, int>)@this->LpVtbl[49])(@this, entryPointIndex, targetIndex, outSharedLibrary);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, ISharedLibrary**, int>)@this->LpVtbl[49])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCodeBlob(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, IBlob**, int>)@this->LpVtbl[50])(@this, targetIndex, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCodeBlob(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, IBlob**, int>)@this->LpVtbl[50])(@this, targetIndex, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetHostCallable(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, ISharedLibrary** outSharedLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ISharedLibrary**, int>)@this->LpVtbl[51])(@this, targetIndex, outSharedLibrary);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetHostCallable(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, ref ISharedLibrary* outSharedLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ISharedLibrary**, int>)@this->LpVtbl[51])(@this, targetIndex, outSharedLibraryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetCompileRequestCode(this ComPtr<ICompileRequest> thisVtbl, nuint* outSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, nuint*, void*>)@this->LpVtbl[52])(@this, outSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetCompileRequestCode(this ComPtr<ICompileRequest> thisVtbl, ref nuint outSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (nuint* outSizePtr = &outSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, nuint*, void*>)@this->LpVtbl[52])(@this, outSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IMutableFileSystem* GetCompileRequestResultAsFileSystem(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        IMutableFileSystem* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IMutableFileSystem*>)@this->LpVtbl[53])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerCode(this ComPtr<ICompileRequest> thisVtbl, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[54])(@this, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerCode(this ComPtr<ICompileRequest> thisVtbl, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[54])(@this, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro(this ComPtr<ICompileRequest> thisVtbl, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystem, data, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro<T0>(this ComPtr<ICompileRequest> thisVtbl, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystem, dataPtr, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro(this ComPtr<ICompileRequest> thisVtbl, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IFileSystem* fileSystemPtr = &fileSystem)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystemPtr, data, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadRepro<T0>(this ComPtr<ICompileRequest> thisVtbl, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IFileSystem* fileSystemPtr = &fileSystem)
        {
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystemPtr, dataPtr, size);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveRepro(this ComPtr<ICompileRequest> thisVtbl, IBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[56])(@this, outBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveRepro(this ComPtr<ICompileRequest> thisVtbl, ref IBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outBlobPtr = &outBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[56])(@this, outBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableReproCapture(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[57])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProgram(this ComPtr<ICompileRequest> thisVtbl, IComponentType** outProgram)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[58])(@this, outProgram);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProgram(this ComPtr<ICompileRequest> thisVtbl, ref IComponentType* outProgram)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outProgramPtr = &outProgram)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[58])(@this, outProgramPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IComponentType**, int>)@this->LpVtbl[59])(@this, entryPointIndex, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IComponentType**, int>)@this->LpVtbl[59])(@this, entryPointIndex, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModule(this ComPtr<ICompileRequest> thisVtbl, long translationUnitIndex, IModule** outModule)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IModule**, int>)@this->LpVtbl[60])(@this, translationUnitIndex, outModule);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModule(this ComPtr<ICompileRequest> thisVtbl, long translationUnitIndex, ref IModule* outModule)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IModule** outModulePtr = &outModule)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IModule**, int>)@this->LpVtbl[60])(@this, translationUnitIndex, outModulePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSession(this ComPtr<ICompileRequest> thisVtbl, ISession** outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ISession**, int>)@this->LpVtbl[61])(@this, outSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSession(this ComPtr<ICompileRequest> thisVtbl, ref ISession* outSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISession** outSessionPtr = &outSession)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ISession**, int>)@this->LpVtbl[61])(@this, outSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ProgramLayout* GetReflection(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ProgramLayout* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ProgramLayout*>)@this->LpVtbl[62])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCommandLineCompilerMode(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, void>)@this->LpVtbl[63])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int AddTargetCapability(this ComPtr<ICompileRequest> thisVtbl, long targetIndex, CapabilityID capability)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, CapabilityID, int>)@this->LpVtbl[64])(@this, targetIndex, capability);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProgramWithEntryPoints(this ComPtr<ICompileRequest> thisVtbl, IComponentType** outProgram)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[65])(@this, outProgram);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProgramWithEntryPoints(this ComPtr<ICompileRequest> thisVtbl, ref IComponentType* outProgram)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outProgramPtr = &outProgram)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[65])(@this, outProgramPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsParameterLocationUsed(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, bool* outUsed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, long, ParameterCategory, ulong, ulong, bool*, int>)@this->LpVtbl[66])(@this, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsParameterLocationUsed(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, ref bool outUsed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (bool* outUsedPtr = &outUsed)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, long, ParameterCategory, ulong, ulong, bool*, int>)@this->LpVtbl[66])(@this, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetLineDirectiveMode(this ComPtr<ICompileRequest> thisVtbl, long targetIndex, LineDirectiveMode mode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, LineDirectiveMode, void>)@this->LpVtbl[67])(@this, targetIndex, mode);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetForceGLSLScalarBufferLayout(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, bool forceScalarLayout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[68])(@this, targetIndex, forceScalarLayout);
    }

    /// <summary>To be documented.</summary>
    public static void OverrideDiagnosticSeverity(this ComPtr<ICompileRequest> thisVtbl, long messageID, Severity overrideSeverity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, Severity, void>)@this->LpVtbl[69])(@this, messageID, overrideSeverity);
    }

    /// <summary>To be documented.</summary>
    public static int GetDiagnosticFlags(this ComPtr<ICompileRequest> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[70])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDiagnosticFlags(this ComPtr<ICompileRequest> thisVtbl, int flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, void>)@this->LpVtbl[71])(@this, flags);
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugInfoFormat(this ComPtr<ICompileRequest> thisVtbl, DebugInfoFormat debugFormat)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, DebugInfoFormat, void>)@this->LpVtbl[72])(@this, debugFormat);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableEffectAnnotations(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[73])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetReportDownstreamTime(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[74])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetReportPerfBenchmark(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[75])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetSkipSPIRVValidation(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[76])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetUseMinimumSlangOptimization(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[77])(@this, targetIndex, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetIgnoreCapabilityCheck(this ComPtr<ICompileRequest> thisVtbl, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[78])(@this, value);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCompileTimeProfile(this ComPtr<ICompileRequest> thisVtbl, IProfiler** compileTimeProfile, bool shouldClear)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IProfiler**, bool, int>)@this->LpVtbl[79])(@this, compileTimeProfile, shouldClear);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCompileTimeProfile(this ComPtr<ICompileRequest> thisVtbl, ref IProfiler* compileTimeProfile, bool shouldClear)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IProfiler** compileTimeProfilePtr = &compileTimeProfile)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IProfiler**, bool, int>)@this->LpVtbl[79])(@this, compileTimeProfilePtr, shouldClear);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetGenerateWholeProgram(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[80])(@this, targetIndex, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetForceDXLayout(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[81])(@this, targetIndex, value);
    }

    /// <summary>To be documented.</summary>
    public static void SetTargetEmbedDownstreamIR(this ComPtr<ICompileRequest> thisVtbl, int targetIndex, bool value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[82])(@this, targetIndex, value);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static void SetFileSystem<TI0>(this ComPtr<ICompileRequest> thisVtbl, ComPtr<TI0> fileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetFileSystem((IFileSystem*) fileSystem.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetFileSystem(this ComPtr<ICompileRequest> thisVtbl, Span<IFileSystem> fileSystem)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetFileSystem(ref fileSystem.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDumpIntermediatePrefix(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> prefix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDumpIntermediatePrefix(in prefix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDiagnosticCallback<T0>(this ComPtr<ICompileRequest> thisVtbl, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDiagnosticCallback(callback, in userData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetWriter(this ComPtr<ICompileRequest> thisVtbl, WriterChannel channel, Span<IWriter> writer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetWriter(channel, ref writer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddSearchPath(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> searchDir)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddSearchPath(in searchDir.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddPreprocessorDefine(key, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddPreprocessorDefine(in key.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddPreprocessorDefine(in key.GetPinnableReference(), in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddPreprocessorDefine(in key.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void AddPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddPreprocessorDefine(key, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ProcessCommandLineArguments(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argsSa, int argCount)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var args = (byte**) SilkMarshal.StringArrayToPtr(argsSa);
        var ret = @this->ProcessCommandLineArguments(args, argCount);
        SilkMarshal.CopyPtrToStringArray((nint) args, argsSa);
        SilkMarshal.Free((nint) args);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddTranslationUnit(this ComPtr<ICompileRequest> thisVtbl, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTranslationUnit(language, in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDefaultModuleName(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> defaultModuleName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDefaultModuleName(in defaultModuleName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitPreprocessorDefine(translationUnitIndex, key, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitPreprocessorDefine(translationUnitIndex, in key.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitPreprocessorDefine(translationUnitIndex, in key.GetPinnableReference(), in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitPreprocessorDefine(translationUnitIndex, in key.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitPreprocessorDefine(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitPreprocessorDefine(translationUnitIndex, key, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceFile(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceFile(translationUnitIndex, in path.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceString(translationUnitIndex, path, in source.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceString(translationUnitIndex, in path.GetPinnableReference(), source);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceString(translationUnitIndex, in path.GetPinnableReference(), in source.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceString(translationUnitIndex, in path.GetPinnableReference(), source);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceString(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceString(translationUnitIndex, path, in source.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddLibraryReference(basePath, in libData.GetPinnableReference(), libDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddLibraryReference(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddLibraryReference(in basePath.GetPinnableReference(), libData, libDataSize);
    }

    /// <summary>To be documented.</summary>
    public static int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddLibraryReference(in basePath.GetPinnableReference(), in libData.GetPinnableReference(), libDataSize);
    }

    /// <summary>To be documented.</summary>
    public static int AddLibraryReference<T0>(this ComPtr<ICompileRequest> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddLibraryReference(basePath, in libData.GetPinnableReference(), libDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceStringSpan(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceStringSpan(translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<IBlob> sourceBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceBlob(translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob* sourceBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceBlob(translationUnitIndex, in path.GetPinnableReference(), sourceBlob);
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<IBlob> sourceBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceBlob(translationUnitIndex, in path.GetPinnableReference(), ref sourceBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AddTranslationUnitSourceBlob(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<IBlob> sourceBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AddTranslationUnitSourceBlob(translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddEntryPoint(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddEntryPoint(translationUnitIndex, in name.GetPinnableReference(), stage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
        var ret = @this->AddEntryPointEx(translationUnitIndex, name, stage, genericArgCount, genericArgs);
        SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
        SilkMarshal.Free((nint) genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
        var ret = @this->AddEntryPointEx(translationUnitIndex, in name, stage, genericArgCount, genericArgs);
        SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
        SilkMarshal.Free((nint) genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddEntryPointEx(translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, genericArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddEntryPointEx(translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, in genericArgs);
    }

    /// <summary>To be documented.</summary>
    public static int AddEntryPointEx(this ComPtr<ICompileRequest> thisVtbl, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
        var ret = @this->AddEntryPointEx(translationUnitIndex, name, stage, genericArgCount, genericArgs);
        SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
        SilkMarshal.Free((nint) genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGlobalGenericArgs(this ComPtr<ICompileRequest> thisVtbl, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
        var ret = @this->SetGlobalGenericArgs(genericArgCount, genericArgs);
        SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
        SilkMarshal.Free((nint) genericArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForGlobalExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTypeNameForGlobalExistentialTypeParam(slotIndex, in typeName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeNameForEntryPointExistentialTypeParam(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTypeNameForEntryPointExistentialTypeParam(entryPointIndex, slotIndex, in typeName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetEntryPointCode(this ComPtr<ICompileRequest> thisVtbl, int entryPointIndex, Span<nuint> outSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEntryPointCode(entryPointIndex, ref outSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetCompileRequestCode(this ComPtr<ICompileRequest> thisVtbl, Span<nuint> outSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCompileRequestCode(ref outSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro<TI0>(this ComPtr<ICompileRequest> thisVtbl, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadRepro((IFileSystem*) fileSystem.Handle, data, size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro<T0>(this ComPtr<ICompileRequest> thisVtbl, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadRepro(fileSystem, in data.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static int LoadRepro<T0, TI0>(this ComPtr<ICompileRequest> thisVtbl, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadRepro((IFileSystem*) fileSystem.Handle, in data, size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadRepro(this ComPtr<ICompileRequest> thisVtbl, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadRepro(ref fileSystem.GetPinnableReference(), data, size);
    }

    /// <summary>To be documented.</summary>
    public static int LoadRepro<T0>(this ComPtr<ICompileRequest> thisVtbl, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadRepro(ref fileSystem.GetPinnableReference(), in data.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static int GetProgram<TI0>(this ComPtr<ICompileRequest> thisVtbl, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetProgram((IComponentType**) outProgram.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetEntryPoint<TI0>(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEntryPoint(entryPointIndex, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetProgramWithEntryPoints<TI0>(this ComPtr<ICompileRequest> thisVtbl, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetProgramWithEntryPoints((IComponentType**) outProgram.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int IsParameterLocationUsed(this ComPtr<ICompileRequest> thisVtbl, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, Span<bool> outUsed)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsParameterLocationUsed(entryPointIndex, targetIndex, category, spaceIndex, registerIndex, ref outUsed.GetPinnableReference());
    }

}

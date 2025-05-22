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

public unsafe static class ModuleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ISession* GetSession(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ISession* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, ISession*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<IModule> thisVtbl, long targetIndex, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<IModule> thisVtbl, long targetIndex, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static long GetSpecializationParamCount(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        long ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IMutableFileSystem** outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IMutableFileSystem* outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMutableFileSystem** outFileSystemPtr = &outFileSystem)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outHash)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outHash)
    {
        var @this = thisVtbl.Handle;
        fixed (IBlob** outHashPtr = &outHash)
        {
            ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IModule> thisVtbl, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IModule> thisVtbl, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IModule> thisVtbl, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IModule> thisVtbl, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
        }
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IModule> thisVtbl, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IModule> thisVtbl, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IModule> thisVtbl, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IModule> thisVtbl, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IModule> thisVtbl, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IModule> thisVtbl, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IModule> thisVtbl, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IModule> thisVtbl, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IModule> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, IEntryPoint** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, name, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, ref IEntryPoint* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, name, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, IEntryPoint** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, ref IEntryPoint* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, IEntryPoint** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPoint);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref IEntryPoint* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPointPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDefinedEntryPointCount(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefinedEntryPoint(this ComPtr<IModule> thisVtbl, int index, IEntryPoint** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int, IEntryPoint**, int>)@this->LpVtbl[19])(@this, index, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefinedEntryPoint(this ComPtr<IModule> thisVtbl, int index, ref IEntryPoint* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, IEntryPoint**, int>)@this->LpVtbl[19])(@this, index, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<IModule> thisVtbl, IBlob** outSerializedBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<IModule> thisVtbl, ref IBlob* outSerializedBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outSerializedBlobPtr = &outSerializedBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToFile(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteToFile(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* fileNamePtr = &fileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteToFile(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fileNamePtr = (byte*) SilkMarshal.StringToPtr(fileName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileNamePtr);
        SilkMarshal.Free((nint)fileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetName(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetNameS(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetFilePath(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetFilePathS(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetUniqueIdentity(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetUniqueIdentityS(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDependencyFileCount(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetDependencyFilePath(this ComPtr<IModule> thisVtbl, int index)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int, byte*>)@this->LpVtbl[27])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string GetDependencyFilePathS(this ComPtr<IModule> thisVtbl, int index)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, int, string>)@this->LpVtbl[27])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe DeclReflection* GetModuleReflection(this ComPtr<IModule> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DeclReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, DeclReflection*>)@this->LpVtbl[28])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Disassemble(this ComPtr<IModule> thisVtbl, IBlob** outDisassembledBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Disassemble(this ComPtr<IModule> thisVtbl, ref IBlob* outDisassembledBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDisassembledBlobPtr = &outDisassembledBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), ref outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IModule> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IModule> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, IEntryPoint** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindEntryPointByName(in name.GetPinnableReference(), outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindEntryPointByName(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, ref IEntryPoint* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindEntryPointByName(in name.GetPinnableReference(), ref outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int WriteToFile(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fileName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteToFile(in fileName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindAndCheckEntryPoint(in name.GetPinnableReference(), stage, outEntryPoint, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindAndCheckEntryPoint(in name.GetPinnableReference(), stage, outEntryPoint, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindAndCheckEntryPoint(in name.GetPinnableReference(), stage, ref outEntryPoint, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindAndCheckEntryPoint(this ComPtr<IModule> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindAndCheckEntryPoint(in name.GetPinnableReference(), stage, ref outEntryPoint, ref outDiagnostics);
    }

}

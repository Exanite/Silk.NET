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

public unsafe static class TypeConformanceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeConformance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeConformance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ISession* GetSession(this ComPtr<ITypeConformance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ISession* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, ISession*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static long GetSpecializationParamCount(this ComPtr<ITypeConformance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        long ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ISlangMutableFileSystem** outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref ISlangMutableFileSystem* outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangMutableFileSystem** outFileSystemPtr = &outFileSystem)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ISlangBlob** outHash)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref ISlangBlob* outHash)
    {
        var @this = thisVtbl.Handle;
        fixed (ISlangBlob** outHashPtr = &outHash)
        {
            ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ITypeConformance> thisVtbl, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ITypeConformance> thisVtbl, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ITypeConformance> thisVtbl, int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<ITypeConformance> thisVtbl, int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
        }
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<ITypeConformance> thisVtbl, long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<ITypeConformance> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeConformance*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), ref outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<ITypeConformance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<ITypeConformance> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<ITypeConformance> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

}

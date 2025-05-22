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

public unsafe static class ComponentTypeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IComponentType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IComponentType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ISession* GetSession(this ComPtr<IComponentType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ISession* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, ISession*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<IComponentType> thisVtbl, long targetIndex, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ShaderReflection* GetLayout(this ComPtr<IComponentType> thisVtbl, long targetIndex, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        ShaderReflection* ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static long GetSpecializationParamCount(this ComPtr<IComponentType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        long ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCode(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IMutableFileSystem** outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResultAsFileSystem(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IMutableFileSystem* outFileSystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMutableFileSystem** outFileSystemPtr = &outFileSystem)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IBlob** outHash)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEntryPointHash(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IBlob* outHash)
    {
        var @this = thisVtbl.Handle;
        fixed (IBlob** outHashPtr = &outHash)
        {
            ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IComponentType> thisVtbl, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IComponentType> thisVtbl, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IComponentType> thisVtbl, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointHostCallable(this ComPtr<IComponentType> thisVtbl, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* newNamePtr = &newName)
        {
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
        fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
        }
        SilkMarshal.Free((nint)newNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
        {
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IComponentType> thisVtbl, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IComponentType> thisVtbl, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IComponentType> thisVtbl, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCode(this ComPtr<IComponentType> thisVtbl, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outCodePtr = &outCode)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IComponentType> thisVtbl, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IComponentType> thisVtbl, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IComponentType> thisVtbl, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetMetadata(this ComPtr<IComponentType> thisVtbl, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointMetadata(this ComPtr<IComponentType> thisVtbl, long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Specialize(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Specialize(in specializationArgs.GetPinnableReference(), specializationArgCount, ref outSpecializedComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, IComponentType** outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameEntryPoint(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> newName, ref IComponentType* outEntryPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameEntryPoint(in newName.GetPinnableReference(), ref outEntryPoint);
    }

    /// <summary>To be documented.</summary>
    public static int RenameEntryPoint<TI0>(this ComPtr<IComponentType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions<TI0>(this ComPtr<IComponentType> thisVtbl, ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, IBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LinkWithOptions(this ComPtr<IComponentType> thisVtbl, ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, Span<CompilerOptionEntry> compilerOptionEntries, ref IBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LinkWithOptions(ref outLinkedComponentType, compilerOptionEntryCount, ref compilerOptionEntries.GetPinnableReference(), ref outDiagnostics);
    }

}

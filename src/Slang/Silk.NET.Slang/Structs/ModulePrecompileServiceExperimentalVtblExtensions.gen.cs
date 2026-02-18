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

public unsafe static class ModulePrecompileServiceExperimentalVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PrecompileForTarget(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, int>)@this->LpVtbl[3])(@this, target, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PrecompileForTarget(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, int>)@this->LpVtbl[3])(@this, target, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledTargetCode(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, target, outCode, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledTargetCode(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, target, outCode, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledTargetCode(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, target, outCodePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledTargetCode(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, SlangCompileTarget target, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outCodePtr = &outCode)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, SlangCompileTarget, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, target, outCodePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static long GetModuleDependencyCount(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        long ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModuleDependency(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, long dependencyIndex, IModule** outModule, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModule, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModuleDependency(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, long dependencyIndex, IModule** outModule, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModule, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModuleDependency(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, long dependencyIndex, ref IModule* outModule, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IModule** outModulePtr = &outModule)
        {
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModulePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetModuleDependency(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, long dependencyIndex, ref IModule* outModule, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IModule** outModulePtr = &outModule)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModulePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IModulePrecompileServiceExperimental> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

}

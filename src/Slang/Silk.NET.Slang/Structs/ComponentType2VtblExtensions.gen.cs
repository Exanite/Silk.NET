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

public unsafe static class ComponentType2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IComponentType2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IComponentType2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCompileResult(this ComPtr<IComponentType2> thisVtbl, long targetIndex, ICompileResult** outCompileResult, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResult, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCompileResult(this ComPtr<IComponentType2> thisVtbl, long targetIndex, ICompileResult** outCompileResult, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResult, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCompileResult(this ComPtr<IComponentType2> thisVtbl, long targetIndex, ref ICompileResult* outCompileResult, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResultPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetCompileResult(this ComPtr<IComponentType2> thisVtbl, long targetIndex, ref ICompileResult* outCompileResult, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResultPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCompileResult(this ComPtr<IComponentType2> thisVtbl, long entryPointIndex, long targetIndex, ICompileResult** outCompileResult, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResult, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCompileResult(this ComPtr<IComponentType2> thisVtbl, long entryPointIndex, long targetIndex, ICompileResult** outCompileResult, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResult, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCompileResult(this ComPtr<IComponentType2> thisVtbl, long entryPointIndex, long targetIndex, ref ICompileResult* outCompileResult, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResultPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPointCompileResult(this ComPtr<IComponentType2> thisVtbl, long entryPointIndex, long targetIndex, ref ICompileResult* outCompileResult, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, ISlangBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResultPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComponentType2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

}

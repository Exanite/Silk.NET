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

public unsafe static class CompileResultVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ICompileResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ICompileResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID guid)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (SlangUUID* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, SlangUUID*, void*>)@this->LpVtbl[3])(@this, guidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetItemCount(this ComPtr<ICompileResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetItemData(this ComPtr<ICompileResult> thisVtbl, uint index, ISlangBlob** outblob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint, ISlangBlob**, int>)@this->LpVtbl[5])(@this, index, outblob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetItemData(this ComPtr<ICompileResult> thisVtbl, uint index, ref ISlangBlob* outblob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outblobPtr = &outblob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, uint, ISlangBlob**, int>)@this->LpVtbl[5])(@this, index, outblobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadata(this ComPtr<ICompileResult> thisVtbl, IMetadata** outMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, IMetadata**, int>)@this->LpVtbl[6])(@this, outMetadata);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadata(this ComPtr<ICompileResult> thisVtbl, ref IMetadata* outMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMetadata** outMetadataPtr = &outMetadata)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICompileResult*, IMetadata**, int>)@this->LpVtbl[6])(@this, outMetadataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* CastAs(this ComPtr<ICompileResult> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CastAs(in guid.GetPinnableReference());
    }

}

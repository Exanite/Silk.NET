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

public unsafe static class SlangBlobVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISlangBlob> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISlangBlob> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetBufferPointer(this ComPtr<ISlangBlob> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, void*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetBufferSize(this ComPtr<ISlangBlob> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangBlob*, nuint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangBlob> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

}

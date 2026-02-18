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

public unsafe static class ByteCodeRunnerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IByteCodeRunner> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IByteCodeRunner> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadModule(this ComPtr<IByteCodeRunner> thisVtbl, ISlangBlob* moduleBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, ISlangBlob*, int>)@this->LpVtbl[3])(@this, moduleBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadModule(this ComPtr<IByteCodeRunner> thisVtbl, ref ISlangBlob moduleBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob* moduleBlobPtr = &moduleBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, ISlangBlob*, int>)@this->LpVtbl[3])(@this, moduleBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SelectFunctionByIndex(this ComPtr<IByteCodeRunner> thisVtbl, uint functionIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, int>)@this->LpVtbl[4])(@this, functionIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFunctionByName(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFunctionByName(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFunctionByName(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFunctionInfo(this ComPtr<IByteCodeRunner> thisVtbl, uint index, ByteCodeFuncInfo* outInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, ByteCodeFuncInfo*, int>)@this->LpVtbl[6])(@this, index, outInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFunctionInfo(this ComPtr<IByteCodeRunner> thisVtbl, uint index, ref ByteCodeFuncInfo outInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ByteCodeFuncInfo* outInfoPtr = &outInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, ByteCodeFuncInfo*, int>)@this->LpVtbl[6])(@this, index, outInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetCurrentWorkingSet(this ComPtr<IByteCodeRunner> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Execute(this ComPtr<IByteCodeRunner> thisVtbl, void* argumentData, nuint argumentSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, nuint, int>)@this->LpVtbl[8])(@this, argumentData, argumentSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Execute<T0>(this ComPtr<IByteCodeRunner> thisVtbl, ref T0 argumentData, nuint argumentSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* argumentDataPtr = &argumentData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, nuint, int>)@this->LpVtbl[8])(@this, argumentDataPtr, argumentSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetErrorString(this ComPtr<IByteCodeRunner> thisVtbl, ISlangBlob** outBlob)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, ISlangBlob**, void>)@this->LpVtbl[9])(@this, outBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetErrorString(this ComPtr<IByteCodeRunner> thisVtbl, ref ISlangBlob* outBlob)
    {
        var @this = thisVtbl.Handle;
        fixed (ISlangBlob** outBlobPtr = &outBlob)
        {
            ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, ISlangBlob**, void>)@this->LpVtbl[9])(@this, outBlobPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetReturnValue(this ComPtr<IByteCodeRunner> thisVtbl, nuint* outValueSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, nuint*, void*>)@this->LpVtbl[10])(@this, outValueSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetReturnValue(this ComPtr<IByteCodeRunner> thisVtbl, ref nuint outValueSize)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (nuint* outValueSizePtr = &outValueSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, nuint*, void*>)@this->LpVtbl[10])(@this, outValueSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetExtInstHandlerUserData(this ComPtr<IByteCodeRunner> thisVtbl, void* userData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, void>)@this->LpVtbl[11])(@this, userData);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtInstHandlerUserData<T0>(this ComPtr<IByteCodeRunner> thisVtbl, ref T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* userDataPtr = &userData)
        {
            ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, void>)@this->LpVtbl[11])(@this, userDataPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterExtCall(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnVMExtFunction functionPtr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, name, functionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterExtCall(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, PfnVMExtFunction functionPtr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, namePtr, functionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterExtCall(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PfnVMExtFunction functionPtr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, namePtr, functionPtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrintCallback(this ComPtr<IByteCodeRunner> thisVtbl, PfnVMPrintFunc callback, void* userData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, PfnVMPrintFunc, void*, int>)@this->LpVtbl[13])(@this, callback, userData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrintCallback<T0>(this ComPtr<IByteCodeRunner> thisVtbl, PfnVMPrintFunc callback, ref T0 userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* userDataPtr = &userData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, PfnVMPrintFunc, void*, int>)@this->LpVtbl[13])(@this, callback, userDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangUUID> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static int LoadModule(this ComPtr<IByteCodeRunner> thisVtbl, Span<ISlangBlob> moduleBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModule(ref moduleBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindFunctionByName(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFunctionByName(in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFunctionInfo(this ComPtr<IByteCodeRunner> thisVtbl, uint index, Span<ByteCodeFuncInfo> outInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFunctionInfo(index, ref outInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Execute<T0>(this ComPtr<IByteCodeRunner> thisVtbl, Span<T0> argumentData, nuint argumentSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Execute(ref argumentData.GetPinnableReference(), argumentSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetReturnValue(this ComPtr<IByteCodeRunner> thisVtbl, Span<nuint> outValueSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReturnValue(ref outValueSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetExtInstHandlerUserData<T0>(this ComPtr<IByteCodeRunner> thisVtbl, Span<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetExtInstHandlerUserData(ref userData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterExtCall(this ComPtr<IByteCodeRunner> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, PfnVMExtFunction functionPtr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterExtCall(in name.GetPinnableReference(), functionPtr);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrintCallback<T0>(this ComPtr<IByteCodeRunner> thisVtbl, PfnVMPrintFunc callback, Span<T0> userData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrintCallback(callback, ref userData.GetPinnableReference());
    }

}

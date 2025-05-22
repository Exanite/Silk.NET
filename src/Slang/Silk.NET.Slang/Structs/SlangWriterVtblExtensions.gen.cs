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

public unsafe static class SlangWriterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISlangWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISlangWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* BeginAppendBuffer(this ComPtr<ISlangWriter> thisVtbl, nuint maxNumChars)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, nuint, byte*>)@this->LpVtbl[3])(@this, maxNumChars);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
    public static string BeginAppendBufferS(this ComPtr<ISlangWriter> thisVtbl, nuint maxNumChars)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, nuint, string>)@this->LpVtbl[3])(@this, maxNumChars);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndAppendBuffer(this ComPtr<ISlangWriter> thisVtbl, byte* buffer, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, buffer, numChars);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndAppendBuffer(this ComPtr<ISlangWriter> thisVtbl, ref byte buffer, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufferPtr = &buffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, bufferPtr, numChars);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndAppendBuffer(this ComPtr<ISlangWriter> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, bufferPtr, numChars);
        SilkMarshal.Free((nint)bufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* chars, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, chars, numChars);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte chars, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* charsPtr = &chars)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, charsPtr, numChars);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string chars, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var charsPtr = (byte*) SilkMarshal.StringToPtr(chars, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, charsPtr, numChars);
        SilkMarshal.Free((nint)charsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Flush(this ComPtr<ISlangWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ISlangWriter*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static bool IsConsole(this ComPtr<ISlangWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, bool>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMode(this ComPtr<ISlangWriter> thisVtbl, WriterMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, WriterMode, int>)@this->LpVtbl[8])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static int EndAppendBuffer(this ComPtr<ISlangWriter> thisVtbl, Span<byte> buffer, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndAppendBuffer(ref buffer.GetPinnableReference(), numChars);
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<ISlangWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> chars, nuint numChars)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in chars.GetPinnableReference(), numChars);
    }

}

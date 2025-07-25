// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr XAPOAlloc(nuint size) => (void*)XAPOAllocRaw(size);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOAlloc"]/*'/>

    public static void* XAPOAllocRaw(nuint size) => CoTaskMemAlloc(size);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOFree"]/*'/>

    public static void XAPOFree(void* p) => CoTaskMemFree(p);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void XAPOFree(Ref p)
    {
        fixed (void* __dsl_p = p)
        {
            XAPOFree(__dsl_p);
        }
    }
}

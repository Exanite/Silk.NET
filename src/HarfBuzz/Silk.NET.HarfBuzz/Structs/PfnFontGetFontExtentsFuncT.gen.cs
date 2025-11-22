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

namespace Silk.NET.HarfBuzz
{
    public unsafe readonly struct PfnFontGetFontExtentsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int>) _handle;
        public PfnFontGetFontExtentsFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetFontExtentsFuncT
        (
             FontGetFontExtentsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetFontExtentsFuncT From(FontGetFontExtentsFuncT proc) => new PfnFontGetFontExtentsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetFontExtentsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetFontExtentsFuncT(nint pfn)
            => new PfnFontGetFontExtentsFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int>) pfn);

        public static implicit operator PfnFontGetFontExtentsFuncT(FontGetFontExtentsFuncT proc)
            => new PfnFontGetFontExtentsFuncT(proc);

        public static explicit operator FontGetFontExtentsFuncT(PfnFontGetFontExtentsFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetFontExtentsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int>(PfnFontGetFontExtentsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetFontExtentsFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, FontExtentsT*, void*, int> ptr) => new PfnFontGetFontExtentsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetFontExtentsFuncT(FontT* arg0, void* arg1, FontExtentsT* arg2, void* arg3);
}


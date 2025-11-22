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
    public unsafe readonly struct PfnColorLineGetColorStopsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint> Handle => (delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint>) _handle;
        public PfnColorLineGetColorStopsFuncT
        (
            delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint> ptr
        ) => _handle = ptr;

        public PfnColorLineGetColorStopsFuncT
        (
             ColorLineGetColorStopsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnColorLineGetColorStopsFuncT From(ColorLineGetColorStopsFuncT proc) => new PfnColorLineGetColorStopsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnColorLineGetColorStopsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnColorLineGetColorStopsFuncT(nint pfn)
            => new PfnColorLineGetColorStopsFuncT((delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint>) pfn);

        public static implicit operator PfnColorLineGetColorStopsFuncT(ColorLineGetColorStopsFuncT proc)
            => new PfnColorLineGetColorStopsFuncT(proc);

        public static explicit operator ColorLineGetColorStopsFuncT(PfnColorLineGetColorStopsFuncT pfn)
            => SilkMarshal.PtrToDelegate<ColorLineGetColorStopsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint>(PfnColorLineGetColorStopsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnColorLineGetColorStopsFuncT(delegate* unmanaged[Cdecl]<ColorLineT*, void*, uint, uint*, ColorStopT*, void*, uint> ptr) => new PfnColorLineGetColorStopsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint ColorLineGetColorStopsFuncT(ColorLineT* arg0, void* arg1, uint arg2, uint* arg3, ColorStopT* arg4, void* arg5);
}


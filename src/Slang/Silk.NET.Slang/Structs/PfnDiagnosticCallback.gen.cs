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

namespace Silk.NET.Slang
{
    public unsafe readonly struct PfnDiagnosticCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<byte*, void*, void>) _handle;
        public PfnDiagnosticCallback
        (
            delegate* unmanaged[Cdecl]<byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnDiagnosticCallback
        (
             DiagnosticCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDiagnosticCallback From(DiagnosticCallback proc) => new PfnDiagnosticCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDiagnosticCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDiagnosticCallback(nint pfn)
            => new PfnDiagnosticCallback((delegate* unmanaged[Cdecl]<byte*, void*, void>) pfn);

        public static implicit operator PfnDiagnosticCallback(DiagnosticCallback proc)
            => new PfnDiagnosticCallback(proc);

        public static explicit operator DiagnosticCallback(PfnDiagnosticCallback pfn)
            => SilkMarshal.PtrToDelegate<DiagnosticCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<byte*, void*, void>(PfnDiagnosticCallback pfn) => pfn.Handle;
        public static implicit operator PfnDiagnosticCallback(delegate* unmanaged[Cdecl]<byte*, void*, void> ptr) => new PfnDiagnosticCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DiagnosticCallback(byte* arg0, void* arg1);
}


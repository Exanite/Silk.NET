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
    public unsafe readonly struct PfnFileSystemContentsCallBack : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void>) _handle;
        public PfnFileSystemContentsCallBack
        (
            delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnFileSystemContentsCallBack
        (
             FileSystemContentsCallBack proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileSystemContentsCallBack From(FileSystemContentsCallBack proc) => new PfnFileSystemContentsCallBack(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileSystemContentsCallBack pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileSystemContentsCallBack(nint pfn)
            => new PfnFileSystemContentsCallBack((delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void>) pfn);

        public static implicit operator PfnFileSystemContentsCallBack(FileSystemContentsCallBack proc)
            => new PfnFileSystemContentsCallBack(proc);

        public static explicit operator FileSystemContentsCallBack(PfnFileSystemContentsCallBack pfn)
            => SilkMarshal.PtrToDelegate<FileSystemContentsCallBack>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void>(PfnFileSystemContentsCallBack pfn) => pfn.Handle;
        public static implicit operator PfnFileSystemContentsCallBack(delegate* unmanaged[Cdecl]<SlangPathType, byte*, void*, void> ptr) => new PfnFileSystemContentsCallBack(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void FileSystemContentsCallBack(SlangPathType arg0, byte* arg1, void* arg2);
}


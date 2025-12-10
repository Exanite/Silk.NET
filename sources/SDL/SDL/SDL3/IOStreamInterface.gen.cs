// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct IOStreamInterface
{
    [NativeTypeName("Uint32")]
    public uint Version;

    [NativeTypeName("Sint64 (*)(void *) __attribute__((cdecl))")]
    public IOStreamInterfaceSize Size;

    [NativeTypeName("Sint64 (*)(void *, Sint64, SDL_IOWhence) __attribute__((cdecl))")]
    public IOStreamInterfaceSeek Seek;

    [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *) __attribute__((cdecl))")]
    public IOStreamInterfaceRead Read;

    [NativeTypeName(
        "size_t (*)(void *, const void *, size_t, SDL_IOStatus *) __attribute__((cdecl))"
    )]
    public IOStreamInterfaceWrite Write;

    [NativeTypeName("bool (*)(void *, SDL_IOStatus *) __attribute__((cdecl))")]
    public IOStreamInterfaceFlush Flush;

    [NativeTypeName("bool (*)(void *) __attribute__((cdecl))")]
    public IOStreamInterfaceClose Close;
}

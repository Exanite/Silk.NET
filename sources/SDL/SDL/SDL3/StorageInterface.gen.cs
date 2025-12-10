// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct StorageInterface
{
    [NativeTypeName("Uint32")]
    public uint Version;

    [NativeTypeName("bool (*)(void *) __attribute__((cdecl))")]
    public StorageInterfaceClose Close;

    [NativeTypeName("bool (*)(void *) __attribute__((cdecl))")]
    public StorageInterfaceReady Ready;

    [NativeTypeName(
        "bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *) __attribute__((cdecl))"
    )]
    public StorageInterfaceEnumerate Enumerate;

    [NativeTypeName("bool (*)(void *, const char *, SDL_PathInfo *) __attribute__((cdecl))")]
    public StorageInterfaceInfo Info;

    [NativeTypeName("bool (*)(void *, const char *, void *, Uint64) __attribute__((cdecl))")]
    public StorageInterfaceReadFile ReadFile;

    [NativeTypeName("bool (*)(void *, const char *, const void *, Uint64) __attribute__((cdecl))")]
    public StorageInterfaceWriteFile WriteFile;

    [NativeTypeName("bool (*)(void *, const char *) __attribute__((cdecl))")]
    public StorageInterfaceMkdir Mkdir;

    [NativeTypeName("bool (*)(void *, const char *) __attribute__((cdecl))")]
    public StorageInterfaceRemove Remove;

    [NativeTypeName("bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
    public StorageInterfaceRename Rename;

    [NativeTypeName("bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
    public StorageInterfaceCopy Copy;

    [NativeTypeName("Uint64 (*)(void *) __attribute__((cdecl))")]
    public StorageInterfaceSpaceRemaining SpaceRemaining;
}

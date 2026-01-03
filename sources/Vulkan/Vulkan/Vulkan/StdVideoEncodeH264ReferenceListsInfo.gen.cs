// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
{
    public StdVideoEncodeH264ReferenceListsInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL0ActiveMinus1;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL1ActiveMinus1;

    [NativeTypeName("uint8_t[32]")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList0 RefPicList0;

    [NativeTypeName("uint8_t[32]")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList1 RefPicList1;

    [NativeTypeName("uint8_t")]
    public byte RefList0ModOpCount;

    [NativeTypeName("uint8_t")]
    public byte RefList1ModOpCount;

    [NativeTypeName("uint8_t")]
    public byte RefPicMarkingOpCount;

    [NativeTypeName("uint8_t[7]")]
    public StdVideoEncodeH264ReferenceListsInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeH264RefListModEntry *")]
    public StdVideoEncodeH264RefListModEntry* PRefList0ModOperations;

    [NativeTypeName("const StdVideoEncodeH264RefListModEntry *")]
    public StdVideoEncodeH264RefListModEntry* PRefList1ModOperations;

    [NativeTypeName("const StdVideoEncodeH264RefPicMarkingEntry *")]
    public StdVideoEncodeH264RefPicMarkingEntry* PRefPicMarkingOperations;
}

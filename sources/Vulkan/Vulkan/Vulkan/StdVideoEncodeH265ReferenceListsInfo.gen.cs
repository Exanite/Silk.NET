// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoEncodeH265ReferenceListsInfo
{
    public StdVideoEncodeH265ReferenceListsInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL0ActiveMinus1;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL1ActiveMinus1;

    [NativeTypeName("uint8_t[15]")]
    public StdVideoEncodeH265ReferenceListsInfoRefPicList0 RefPicList0;

    [NativeTypeName("uint8_t[15]")]
    public StdVideoEncodeH265ReferenceListsInfoRefPicList1 RefPicList1;

    [NativeTypeName("uint8_t[15]")]
    public StdVideoEncodeH265ReferenceListsInfoListEntryL0 ListEntryL0;

    [NativeTypeName("uint8_t[15]")]
    public StdVideoEncodeH265ReferenceListsInfoListEntryL1 ListEntryL1;
}

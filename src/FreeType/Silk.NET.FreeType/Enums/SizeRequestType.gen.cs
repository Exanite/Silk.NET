// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Size_Request_Type_")]
    public enum SizeRequestType : int
    {
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_NOMINAL")]
        Nominal = 0x0,
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_REAL_DIM")]
        RealDim = 0x1,
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_BBOX")]
        Bbox = 0x2,
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_CELL")]
        Cell = 0x3,
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_SCALES")]
        Scales = 0x4,
        [NativeName("Name", "FT_SIZE_REQUEST_TYPE_MAX")]
        Max = 0x5,
    }
}

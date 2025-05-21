// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangScalarType")]
    public enum SlangScalarType : uint
    {
        [NativeName("Name", "SLANG_SCALAR_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_SCALAR_TYPE_VOID")]
        Void = 0x1,
        [NativeName("Name", "SLANG_SCALAR_TYPE_BOOL")]
        Bool = 0x2,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT32")]
        Int32 = 0x3,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT32")]
        Uint32 = 0x4,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT64")]
        Int64 = 0x5,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT64")]
        Uint64 = 0x6,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT16")]
        Float16 = 0x7,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT32")]
        Float32 = 0x8,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT64")]
        Float64 = 0x9,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT8")]
        Int8 = 0xA,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT8")]
        Uint8 = 0xB,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT16")]
        Int16 = 0xC,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT16")]
        Uint16 = 0xD,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INTPTR")]
        Intptr = 0xE,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINTPTR")]
        Uintptr = 0xF,
    }
}

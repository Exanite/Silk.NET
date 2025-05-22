// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangScalarType")]
    public enum ScalarType : uint
    {
        [NativeName("Name", "SLANG_SCALAR_TYPE_NONE")]
        ScalarTypeNone = 0x0,
        [NativeName("Name", "SLANG_SCALAR_TYPE_VOID")]
        ScalarTypeVoid = 0x1,
        [NativeName("Name", "SLANG_SCALAR_TYPE_BOOL")]
        ScalarTypeBool = 0x2,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT32")]
        ScalarTypeInt32 = 0x3,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT32")]
        ScalarTypeUint32 = 0x4,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT64")]
        ScalarTypeInt64 = 0x5,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT64")]
        ScalarTypeUint64 = 0x6,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT16")]
        ScalarTypeFloat16 = 0x7,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT32")]
        ScalarTypeFloat32 = 0x8,
        [NativeName("Name", "SLANG_SCALAR_TYPE_FLOAT64")]
        ScalarTypeFloat64 = 0x9,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT8")]
        ScalarTypeInt8 = 0xA,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT8")]
        ScalarTypeUint8 = 0xB,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INT16")]
        ScalarTypeInt16 = 0xC,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINT16")]
        ScalarTypeUint16 = 0xD,
        [NativeName("Name", "SLANG_SCALAR_TYPE_INTPTR")]
        ScalarTypeIntptr = 0xE,
        [NativeName("Name", "SLANG_SCALAR_TYPE_UINTPTR")]
        ScalarTypeUintptr = 0xF,
        [NativeName("Name", "None")]
        None = 0x0,
        [NativeName("Name", "Void")]
        Void = 0x1,
        [NativeName("Name", "Bool")]
        Bool = 0x2,
        [NativeName("Name", "Int32")]
        Int32 = 0x3,
        [NativeName("Name", "UInt32")]
        UInt32 = 0x4,
        [NativeName("Name", "Int64")]
        Int64 = 0x5,
        [NativeName("Name", "UInt64")]
        UInt64 = 0x6,
        [NativeName("Name", "Float16")]
        Float16 = 0x7,
        [NativeName("Name", "Float32")]
        Float32 = 0x8,
        [NativeName("Name", "Float64")]
        Float64 = 0x9,
        [NativeName("Name", "Int8")]
        Int8 = 0xA,
        [NativeName("Name", "UInt8")]
        UInt8 = 0xB,
        [NativeName("Name", "Int16")]
        Int16 = 0xC,
        [NativeName("Name", "UInt16")]
        UInt16 = 0xD,
    }
}

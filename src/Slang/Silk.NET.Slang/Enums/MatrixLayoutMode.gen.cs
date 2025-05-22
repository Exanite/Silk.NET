// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangMatrixLayoutMode")]
    public enum MatrixLayoutMode : uint
    {
        [NativeName("Name", "SLANG_MATRIX_LAYOUT_MODE_UNKNOWN")]
        ModeUnknown = 0x0,
        [NativeName("Name", "SLANG_MATRIX_LAYOUT_ROW_MAJOR")]
        RowMajor = 0x1,
        [NativeName("Name", "SLANG_MATRIX_LAYOUT_COLUMN_MAJOR")]
        ColumnMajor = 0x2,
    }
}

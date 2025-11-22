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

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Outline_Funcs_")]
    public unsafe partial struct OutlineFuncs
    {
        public OutlineFuncs
        (
            PfnOutlineMoveToFunc? moveTo = null,
            PfnOutlineMoveToFunc? lineTo = null,
            PfnOutlineConicToFunc? conicTo = null,
            PfnOutlineCubicToFunc? cubicTo = null,
            int? shift = null,
            int? delta = null
        ) : this()
        {
            if (moveTo is not null)
            {
                MoveTo = moveTo.Value;
            }

            if (lineTo is not null)
            {
                LineTo = lineTo.Value;
            }

            if (conicTo is not null)
            {
                ConicTo = conicTo.Value;
            }

            if (cubicTo is not null)
            {
                CubicTo = cubicTo.Value;
            }

            if (shift is not null)
            {
                Shift = shift.Value;
            }

            if (delta is not null)
            {
                Delta = delta.Value;
            }
        }


        [NativeName("Type", "FT_Outline_MoveToFunc")]
        [NativeName("Type.Name", "FT_Outline_MoveToFunc")]
        [NativeName("Name", "move_to")]
        public PfnOutlineMoveToFunc MoveTo;

        [NativeName("Type", "FT_Outline_LineToFunc")]
        [NativeName("Type.Name", "FT_Outline_LineToFunc")]
        [NativeName("Name", "line_to")]
        public PfnOutlineMoveToFunc LineTo;

        [NativeName("Type", "FT_Outline_ConicToFunc")]
        [NativeName("Type.Name", "FT_Outline_ConicToFunc")]
        [NativeName("Name", "conic_to")]
        public PfnOutlineConicToFunc ConicTo;

        [NativeName("Type", "FT_Outline_CubicToFunc")]
        [NativeName("Type.Name", "FT_Outline_CubicToFunc")]
        [NativeName("Name", "cubic_to")]
        public PfnOutlineCubicToFunc CubicTo;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "shift")]
        public int Shift;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "delta")]
        public int Delta;
    }
}

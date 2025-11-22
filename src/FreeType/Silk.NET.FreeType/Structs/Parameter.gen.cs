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
    [NativeName("Name", "FT_Parameter_")]
    public unsafe partial struct Parameter
    {
        public Parameter
        (
            uint? tag = null,
            void* data = null
        ) : this()
        {
            if (tag is not null)
            {
                Tag = tag.Value;
            }

            if (data is not null)
            {
                Data = data;
            }
        }


        [NativeName("Type", "FT_ULong")]
        [NativeName("Type.Name", "FT_ULong")]
        [NativeName("Name", "tag")]
        public uint Tag;

        [NativeName("Type", "FT_Pointer")]
        [NativeName("Type.Name", "FT_Pointer")]
        [NativeName("Name", "data")]
        public void* Data;
    }
}

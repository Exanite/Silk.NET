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
    [NativeName("Name", "FT_Size_RequestRec_")]
    public unsafe partial struct SizeRequestRec
    {
        public SizeRequestRec
        (
            SizeRequestType? type = null,
            int? width = null,
            int? height = null,
            uint? horiResolution = null,
            uint? vertResolution = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (horiResolution is not null)
            {
                HoriResolution = horiResolution.Value;
            }

            if (vertResolution is not null)
            {
                VertResolution = vertResolution.Value;
            }
        }


        [NativeName("Type", "FT_Size_Request_Type")]
        [NativeName("Type.Name", "FT_Size_Request_Type")]
        [NativeName("Name", "type")]
        public SizeRequestType Type;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "width")]
        public int Width;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "height")]
        public int Height;

        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "horiResolution")]
        public uint HoriResolution;

        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "vertResolution")]
        public uint VertResolution;
    }
}

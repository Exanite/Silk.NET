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
    [NativeName("Name", "FT_CharMapRec_")]
    public unsafe partial struct CharMapRec
    {
        public CharMapRec
        (
            FaceRec* face = null,
            Encoding? encoding = null,
            ushort? platformId = null,
            ushort? encodingId = null
        ) : this()
        {
            if (face is not null)
            {
                Face = face;
            }

            if (encoding is not null)
            {
                Encoding = encoding.Value;
            }

            if (platformId is not null)
            {
                PlatformId = platformId.Value;
            }

            if (encodingId is not null)
            {
                EncodingId = encodingId.Value;
            }
        }


        [NativeName("Type", "FT_Face")]
        [NativeName("Type.Name", "FT_Face")]
        [NativeName("Name", "face")]
        public FaceRec* Face;

        [NativeName("Type", "FT_Encoding")]
        [NativeName("Type.Name", "FT_Encoding")]
        [NativeName("Name", "encoding")]
        public Encoding Encoding;

        [NativeName("Type", "FT_UShort")]
        [NativeName("Type.Name", "FT_UShort")]
        [NativeName("Name", "platform_id")]
        public ushort PlatformId;

        [NativeName("Type", "FT_UShort")]
        [NativeName("Type.Name", "FT_UShort")]
        [NativeName("Name", "encoding_id")]
        public ushort EncodingId;
    }
}

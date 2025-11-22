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
    [NativeName("Name", "FT_StreamRec_")]
    public unsafe partial struct StreamRec
    {
        public StreamRec
        (
            byte* @base = null,
            uint? size = null,
            uint? pos = null,
            StreamDesc? descriptor = null,
            StreamDesc? pathname = null,
            PfnStreamIoFunc? read = null,
            PfnStreamCloseFunc? close = null,
            MemoryRec* memory = null,
            byte* cursor = null,
            byte* limit = null
        ) : this()
        {
            if (@base is not null)
            {
                Base = @base;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pos is not null)
            {
                Pos = pos.Value;
            }

            if (descriptor is not null)
            {
                Descriptor = descriptor.Value;
            }

            if (pathname is not null)
            {
                Pathname = pathname.Value;
            }

            if (read is not null)
            {
                Read = read.Value;
            }

            if (close is not null)
            {
                Close = close.Value;
            }

            if (memory is not null)
            {
                Memory = memory;
            }

            if (cursor is not null)
            {
                Cursor = cursor;
            }

            if (limit is not null)
            {
                Limit = limit;
            }
        }


        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "base")]
        public byte* Base;

        [NativeName("Type", "unsigned long")]
        [NativeName("Type.Name", "unsigned long")]
        [NativeName("Name", "size")]
        public uint Size;

        [NativeName("Type", "unsigned long")]
        [NativeName("Type.Name", "unsigned long")]
        [NativeName("Name", "pos")]
        public uint Pos;

        [NativeName("Type", "FT_StreamDesc")]
        [NativeName("Type.Name", "FT_StreamDesc")]
        [NativeName("Name", "descriptor")]
        public StreamDesc Descriptor;

        [NativeName("Type", "FT_StreamDesc")]
        [NativeName("Type.Name", "FT_StreamDesc")]
        [NativeName("Name", "pathname")]
        public StreamDesc Pathname;

        [NativeName("Type", "FT_Stream_IoFunc")]
        [NativeName("Type.Name", "FT_Stream_IoFunc")]
        [NativeName("Name", "read")]
        public PfnStreamIoFunc Read;

        [NativeName("Type", "FT_Stream_CloseFunc")]
        [NativeName("Type.Name", "FT_Stream_CloseFunc")]
        [NativeName("Name", "close")]
        public PfnStreamCloseFunc Close;

        [NativeName("Type", "FT_Memory")]
        [NativeName("Type.Name", "FT_Memory")]
        [NativeName("Name", "memory")]
        public MemoryRec* Memory;

        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "cursor")]
        public byte* Cursor;

        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "limit")]
        public byte* Limit;
    }
}

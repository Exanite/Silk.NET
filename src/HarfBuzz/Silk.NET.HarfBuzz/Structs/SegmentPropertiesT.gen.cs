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

namespace Silk.NET.HarfBuzz
{
    [NativeName("Name", "hb_segment_properties_t")]
    public unsafe partial struct SegmentPropertiesT
    {
        public SegmentPropertiesT
        (
            DirectionT? direction = null,
            ScriptT? script = null,
            LanguageImplT* language = null,
            void* reserved1 = null,
            void* reserved2 = null
        ) : this()
        {
            if (direction is not null)
            {
                Direction = direction.Value;
            }

            if (script is not null)
            {
                Script = script.Value;
            }

            if (language is not null)
            {
                Language = language;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2;
            }
        }


        [NativeName("Type", "hb_direction_t")]
        [NativeName("Type.Name", "hb_direction_t")]
        [NativeName("Name", "direction")]
        public DirectionT Direction;

        [NativeName("Type", "hb_script_t")]
        [NativeName("Type.Name", "hb_script_t")]
        [NativeName("Name", "script")]
        public ScriptT Script;

        [NativeName("Type", "hb_language_t")]
        [NativeName("Type.Name", "hb_language_t")]
        [NativeName("Name", "language")]
        public LanguageImplT* Language;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved1")]
        public void* Reserved1;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved2")]
        public void* Reserved2;
    }
}

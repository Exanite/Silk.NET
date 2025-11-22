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
    [NativeName("Name", "hb_color_line_t")]
    public unsafe partial struct ColorLineT
    {
        public ColorLineT
        (
            void* data = null,
            PfnColorLineGetColorStopsFuncT? getColorStops = null,
            void* getColorStopsUserData = null,
            PfnColorLineGetExtendFuncT? getExtend = null,
            void* getExtendUserData = null,
            void* reserved0 = null,
            void* reserved1 = null,
            void* reserved2 = null,
            void* reserved3 = null,
            void* reserved5 = null,
            void* reserved6 = null,
            void* reserved7 = null,
            void* reserved8 = null
        ) : this()
        {
            if (data is not null)
            {
                Data = data;
            }

            if (getColorStops is not null)
            {
                GetColorStops = getColorStops.Value;
            }

            if (getColorStopsUserData is not null)
            {
                GetColorStopsUserData = getColorStopsUserData;
            }

            if (getExtend is not null)
            {
                GetExtend = getExtend.Value;
            }

            if (getExtendUserData is not null)
            {
                GetExtendUserData = getExtendUserData;
            }

            if (reserved0 is not null)
            {
                Reserved0 = reserved0;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3;
            }

            if (reserved5 is not null)
            {
                Reserved5 = reserved5;
            }

            if (reserved6 is not null)
            {
                Reserved6 = reserved6;
            }

            if (reserved7 is not null)
            {
                Reserved7 = reserved7;
            }

            if (reserved8 is not null)
            {
                Reserved8 = reserved8;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;

        [NativeName("Type", "hb_color_line_get_color_stops_func_t")]
        [NativeName("Type.Name", "hb_color_line_get_color_stops_func_t")]
        [NativeName("Name", "get_color_stops")]
        public PfnColorLineGetColorStopsFuncT GetColorStops;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "get_color_stops_user_data")]
        public void* GetColorStopsUserData;

        [NativeName("Type", "hb_color_line_get_extend_func_t")]
        [NativeName("Type.Name", "hb_color_line_get_extend_func_t")]
        [NativeName("Name", "get_extend")]
        public PfnColorLineGetExtendFuncT GetExtend;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "get_extend_user_data")]
        public void* GetExtendUserData;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved0")]
        public void* Reserved0;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved1")]
        public void* Reserved1;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved2")]
        public void* Reserved2;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved3")]
        public void* Reserved3;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved5")]
        public void* Reserved5;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved6")]
        public void* Reserved6;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved7")]
        public void* Reserved7;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved8")]
        public void* Reserved8;
    }
}

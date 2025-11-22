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
    [NativeName("Name", "hb_draw_state_t")]
    public unsafe partial struct DrawStateT
    {
        public DrawStateT
        (
            int? pathOpen = null,
            float? pathStartX = null,
            float? pathStartY = null,
            float? currentX = null,
            float? currentY = null,
            VarNumT? reserved1 = null,
            VarNumT? reserved2 = null,
            VarNumT? reserved3 = null,
            VarNumT? reserved4 = null,
            VarNumT? reserved5 = null,
            VarNumT? reserved6 = null,
            VarNumT? reserved7 = null
        ) : this()
        {
            if (pathOpen is not null)
            {
                PathOpen = pathOpen.Value;
            }

            if (pathStartX is not null)
            {
                PathStartX = pathStartX.Value;
            }

            if (pathStartY is not null)
            {
                PathStartY = pathStartY.Value;
            }

            if (currentX is not null)
            {
                CurrentX = currentX.Value;
            }

            if (currentY is not null)
            {
                CurrentY = currentY.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (reserved4 is not null)
            {
                Reserved4 = reserved4.Value;
            }

            if (reserved5 is not null)
            {
                Reserved5 = reserved5.Value;
            }

            if (reserved6 is not null)
            {
                Reserved6 = reserved6.Value;
            }

            if (reserved7 is not null)
            {
                Reserved7 = reserved7.Value;
            }
        }


        [NativeName("Type", "hb_bool_t")]
        [NativeName("Type.Name", "hb_bool_t")]
        [NativeName("Name", "path_open")]
        public int PathOpen;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "path_start_x")]
        public float PathStartX;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "path_start_y")]
        public float PathStartY;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "current_x")]
        public float CurrentX;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "current_y")]
        public float CurrentY;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved1")]
        public VarNumT Reserved1;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved2")]
        public VarNumT Reserved2;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved3")]
        public VarNumT Reserved3;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved4")]
        public VarNumT Reserved4;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved5")]
        public VarNumT Reserved5;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved6")]
        public VarNumT Reserved6;

        [NativeName("Type", "hb_var_num_t")]
        [NativeName("Type.Name", "hb_var_num_t")]
        [NativeName("Name", "reserved7")]
        public VarNumT Reserved7;
    }
}

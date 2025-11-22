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
    [NativeName("Name", "FT_Raster_Funcs_")]
    public unsafe partial struct RasterFuncs
    {
        public RasterFuncs
        (
            GlyphFormat? glyphFormat = null,
            PfnRasterNewFunc? rasterNew = null,
            PfnRasterResetFunc? rasterReset = null,
            PfnRasterSetModeFunc? rasterSetMode = null,
            PfnRasterRenderFunc? rasterRender = null,
            PfnRasterDoneFunc? rasterDone = null
        ) : this()
        {
            if (glyphFormat is not null)
            {
                GlyphFormat = glyphFormat.Value;
            }

            if (rasterNew is not null)
            {
                RasterNew = rasterNew.Value;
            }

            if (rasterReset is not null)
            {
                RasterReset = rasterReset.Value;
            }

            if (rasterSetMode is not null)
            {
                RasterSetMode = rasterSetMode.Value;
            }

            if (rasterRender is not null)
            {
                RasterRender = rasterRender.Value;
            }

            if (rasterDone is not null)
            {
                RasterDone = rasterDone.Value;
            }
        }


        [NativeName("Type", "FT_Glyph_Format")]
        [NativeName("Type.Name", "FT_Glyph_Format")]
        [NativeName("Name", "glyph_format")]
        public GlyphFormat GlyphFormat;

        [NativeName("Type", "FT_Raster_NewFunc")]
        [NativeName("Type.Name", "FT_Raster_NewFunc")]
        [NativeName("Name", "raster_new")]
        public PfnRasterNewFunc RasterNew;

        [NativeName("Type", "FT_Raster_ResetFunc")]
        [NativeName("Type.Name", "FT_Raster_ResetFunc")]
        [NativeName("Name", "raster_reset")]
        public PfnRasterResetFunc RasterReset;

        [NativeName("Type", "FT_Raster_SetModeFunc")]
        [NativeName("Type.Name", "FT_Raster_SetModeFunc")]
        [NativeName("Name", "raster_set_mode")]
        public PfnRasterSetModeFunc RasterSetMode;

        [NativeName("Type", "FT_Raster_RenderFunc")]
        [NativeName("Type.Name", "FT_Raster_RenderFunc")]
        [NativeName("Name", "raster_render")]
        public PfnRasterRenderFunc RasterRender;

        [NativeName("Type", "FT_Raster_DoneFunc")]
        [NativeName("Type.Name", "FT_Raster_DoneFunc")]
        [NativeName("Name", "raster_done")]
        public PfnRasterDoneFunc RasterDone;
    }
}

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

namespace Silk.NET.Tracy
{
    [NativeName("Name", "___tracy_gpu_zone_begin_data")]
    public unsafe partial struct TracyGpuZoneBeginData
    {
        public TracyGpuZoneBeginData
        (
            ulong? srcloc = null,
            ushort? queryId = null,
            byte? context = null
        ) : this()
        {
            if (srcloc is not null)
            {
                Srcloc = srcloc.Value;
            }

            if (queryId is not null)
            {
                QueryId = queryId.Value;
            }

            if (context is not null)
            {
                Context = context.Value;
            }
        }


        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "srcloc")]
        public ulong Srcloc;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "queryId")]
        public ushort QueryId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "context")]
        public byte Context;
    }
}

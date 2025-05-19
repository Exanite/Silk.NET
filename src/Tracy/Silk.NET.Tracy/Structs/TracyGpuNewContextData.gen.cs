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
    [NativeName("Name", "___tracy_gpu_new_context_data")]
    public unsafe partial struct TracyGpuNewContextData
    {
        public TracyGpuNewContextData
        (
            long? gpuTime = null,
            float? period = null,
            byte? context = null,
            byte? flags = null,
            byte? type = null
        ) : this()
        {
            if (gpuTime is not null)
            {
                GpuTime = gpuTime.Value;
            }

            if (period is not null)
            {
                Period = period.Value;
            }

            if (context is not null)
            {
                Context = context.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "gpuTime")]
        public long GpuTime;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "period")]
        public float Period;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "context")]
        public byte Context;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "flags")]
        public byte Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "type")]
        public byte Type;
    }
}

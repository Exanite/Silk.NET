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
    [NativeName("Name", "___tracy_gpu_calibration_data")]
    public unsafe partial struct TracyGpuCalibrationData
    {
        public TracyGpuCalibrationData
        (
            long? gpuTime = null,
            long? cpuDelta = null,
            byte? context = null
        ) : this()
        {
            if (gpuTime is not null)
            {
                GpuTime = gpuTime.Value;
            }

            if (cpuDelta is not null)
            {
                CpuDelta = cpuDelta.Value;
            }

            if (context is not null)
            {
                Context = context.Value;
            }
        }


        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "gpuTime")]
        public long GpuTime;

        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "cpuDelta")]
        public long CpuDelta;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "context")]
        public byte Context;
    }
}

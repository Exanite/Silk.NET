// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangStage")]
    public enum SlangStage : uint
    {
        [NativeName("Name", "SLANG_STAGE_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_STAGE_VERTEX")]
        Vertex = 0x1,
        [NativeName("Name", "SLANG_STAGE_HULL")]
        Hull = 0x2,
        [NativeName("Name", "SLANG_STAGE_DOMAIN")]
        Domain = 0x3,
        [NativeName("Name", "SLANG_STAGE_GEOMETRY")]
        Geometry = 0x4,
        [NativeName("Name", "SLANG_STAGE_FRAGMENT")]
        Fragment = 0x5,
        [NativeName("Name", "SLANG_STAGE_COMPUTE")]
        Compute = 0x6,
        [NativeName("Name", "SLANG_STAGE_RAY_GENERATION")]
        RayGeneration = 0x7,
        [NativeName("Name", "SLANG_STAGE_INTERSECTION")]
        Intersection = 0x8,
        [NativeName("Name", "SLANG_STAGE_ANY_HIT")]
        AnyHit = 0x9,
        [NativeName("Name", "SLANG_STAGE_CLOSEST_HIT")]
        ClosestHit = 0xA,
        [NativeName("Name", "SLANG_STAGE_MISS")]
        Miss = 0xB,
        [NativeName("Name", "SLANG_STAGE_CALLABLE")]
        Callable = 0xC,
        [NativeName("Name", "SLANG_STAGE_MESH")]
        Mesh = 0xD,
        [NativeName("Name", "SLANG_STAGE_AMPLIFICATION")]
        Amplification = 0xE,
        [NativeName("Name", "SLANG_STAGE_DISPATCH")]
        Dispatch = 0xF,
        [NativeName("Name", "SLANG_STAGE_COUNT")]
        Count = 0x10,
        [NativeName("Name", "SLANG_STAGE_PIXEL")]
        Pixel = 0x5,
    }
}

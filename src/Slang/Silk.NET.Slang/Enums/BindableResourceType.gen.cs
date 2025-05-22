// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangBindableResourceType")]
    public enum BindableResourceType : int
    {
        [NativeName("Name", "SLANG_NON_BINDABLE")]
        NonBindable = 0x0,
        [NativeName("Name", "SLANG_TEXTURE")]
        Texture = 0x1,
        [NativeName("Name", "SLANG_SAMPLER")]
        Sampler = 0x2,
        [NativeName("Name", "SLANG_UNIFORM_BUFFER")]
        UniformBuffer = 0x3,
        [NativeName("Name", "SLANG_STORAGE_BUFFER")]
        StorageBuffer = 0x4,
    }
}

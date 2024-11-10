// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER")]
    public enum ShaderAccessRestrictedResourceTier : int
    {
        [Obsolete("Deprecated in favour of \"Tier0\"")]
        [NativeName("Name", "D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER_0")]
        ShaderAccessRestrictedResourceTier0 = 0x0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER_1")]
        ShaderAccessRestrictedResourceTier1 = 0x1,
        [NativeName("Name", "D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER_0")]
        Tier0 = 0x0,
        [NativeName("Name", "D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER_1")]
        Tier1 = 0x1,
    }
}

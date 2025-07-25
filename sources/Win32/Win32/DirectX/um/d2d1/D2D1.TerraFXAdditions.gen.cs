// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class D2D1
{
    public const ulong InvalidTag = ulong.MaxValue;
    public const uint InterpolationModeDefinitionNearestNeighbor = 0;
    public const uint InterpolationModeDefinitionLinear = 1;
    public const uint InterpolationModeDefinitionCubic = 2;
    public const uint InterpolationModeDefinitionMultiSampleLinear = 3;
    public const uint InterpolationModeDefinitionAnisotropic = 4;
    public const uint InterpolationModeDefinitionHighQualityCubic = 5;
    public const uint InterpolationModeDefinitionFant = 6;
    public const uint InterpolationModeDefinitionMipmapLinear = 7;
}

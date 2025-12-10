// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum DriverId : uint
{
    AmdProprietary = 1,
    AmdOpenSource = 2,
    MesaRadv = 3,
    NvidiaProprietary = 4,
    IntelProprietaryWindows = 5,
    IntelOpenSourceMESA = 6,
    ImaginationProprietary = 7,
    QualcommProprietary = 8,
    ArmProprietary = 9,
    GoogleSwiftshader = 10,
    GgpProprietary = 11,
    BroadcomProprietary = 12,
    MesaLlvmpipe = 13,
    Moltenvk = 14,
    CoreaviProprietary = 15,
    JuiceProprietary = 16,
    VerisiliconProprietary = 17,
    MesaTurnip = 18,
    MesaV3Dv = 19,
    MesaPanvk = 20,
    SamsungProprietary = 21,
    MesaVenus = 22,
    MesaDozen = 23,
    MesaNvk = 24,
    ImaginationOpenSourceMESA = 25,
    MesaHoneykrisp = 26,
    VulkanScEmulationOnVulkan = 27,
    MesaKosmickrisp = 28,
    AmdProprietaryKHR = AmdProprietary,
    AmdOpenSourceKHR = AmdOpenSource,
    MesaRadvKHR = MesaRadv,
    NvidiaProprietaryKHR = NvidiaProprietary,
    IntelProprietaryWindowsKHR = IntelProprietaryWindows,
    IntelOpenSourceMesaKHR = IntelOpenSourceMESA,
    ImaginationProprietaryKHR = ImaginationProprietary,
    QualcommProprietaryKHR = QualcommProprietary,
    ArmProprietaryKHR = ArmProprietary,
    GoogleSwiftshaderKHR = GoogleSwiftshader,
    GgpProprietaryKHR = GgpProprietary,
    BroadcomProprietaryKHR = BroadcomProprietary,
}

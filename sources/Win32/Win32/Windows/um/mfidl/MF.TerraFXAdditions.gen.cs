// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class MF
{
    public const int ResolutionMediasource = 0x1;
    public const int ResolutionBytestream = 0x2;
    public const int ResolutionContentDoesNotHaveToMatchExtensionOrMimeType = 0x10;
    public const int ResolutionKeepByteStreamAliveOnFail = 0x20;
    public const int ResolutionDisableLocalPlugins = 0x40;
    public const int ResolutionPluginControlPolicyApprovedOnly = 0x80;
    public const int ResolutionPluginControlPolicyWebOnly = 0x100;
    public const int ResolutionPluginControlPolicyWebOnlyEdgemode = 0x200;
    public const int ResolutionEnableStorePlugins = 0x400;
    public const int ResolutionRead = 0x10000;
    public const int ResolutionWrite = 0x20000;
    public const int ActivateCustomMixerAllowfail = 0x1;
    public const int ActivateCustomPresenterAllowfail = 0x1;
}

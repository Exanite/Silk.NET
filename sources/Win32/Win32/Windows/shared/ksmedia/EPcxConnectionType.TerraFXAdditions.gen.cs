// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public enum EPcxConnectionType
{
    ConnTypeUnknown,
    ConnType3Point5Mm,
    ConnTypeQuarter,
    ConnTypeAtapiInternal,
    ConnTypeRCA,
    ConnTypeOptical,
    ConnTypeOtherDigital,
    ConnTypeOtherAnalog,
    ConnTypeMultichannelAnalogDIN,
    ConnTypeXlrProfessional,
    ConnTypeRJ11Modem,
    ConnTypeCombination,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE"]/*'/>
public enum D3Dbustype
{
    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_OTHER"]/*'/>

    TypeOther = 0x00000000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCI"]/*'/>

    TypePci = 0x00000001,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIX"]/*'/>

    TypePcix = 0x00000002,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIEXPRESS"]/*'/>

    TypePciexpress = 0x00000003,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_AGP"]/*'/>

    TypeAgp = 0x00000004,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET"]/*'/>

    ImplModifierInsideOfChipset = 0x00010000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP"]/*'/>

    ImplModifierTracksOnMotherBoardToChip = 0x00020000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET"]/*'/>

    ImplModifierTracksOnMotherBoardToSocket = 0x00030000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR"]/*'/>

    ImplModifierDaughterBoardConnector = 0x00040000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE"]/*'/>

    ImplModifierDaughterBoardConnectorInsideOfNuae = 0x00050000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_NON_STANDARD"]/*'/>

    ImplModifierNonStandard = unchecked((int)(0x80000000)),
}

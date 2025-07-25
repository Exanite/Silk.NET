// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID"]/*'/>
public enum D3D12MessageId
{
    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_STRING_FROM_APPLICATION"]/*'/>

    StringFromApplication = 1,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_THIS"]/*'/>

    CorruptedThis = 2,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER1"]/*'/>

    CorruptedParameter1 = 3,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER2"]/*'/>

    CorruptedParameter2 = 4,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER3"]/*'/>

    CorruptedParameter3 = 5,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER4"]/*'/>

    CorruptedParameter4 = 6,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER5"]/*'/>

    CorruptedParameter5 = 7,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER6"]/*'/>

    CorruptedParameter6 = 8,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER7"]/*'/>

    CorruptedParameter7 = 9,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER8"]/*'/>

    CorruptedParameter8 = 10,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER9"]/*'/>

    CorruptedParameter9 = 11,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER10"]/*'/>

    CorruptedParameter10 = 12,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER11"]/*'/>

    CorruptedParameter11 = 13,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER12"]/*'/>

    CorruptedParameter12 = 14,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER13"]/*'/>

    CorruptedParameter13 = 15,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER14"]/*'/>

    CorruptedParameter14 = 16,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_PARAMETER15"]/*'/>

    CorruptedParameter15 = 17,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CORRUPTED_MULTITHREADING"]/*'/>

    CorruptedMultithreading = 18,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY"]/*'/>

    MessageReportingOutofmemory = 19,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETPRIVATEDATA_MOREDATA"]/*'/>

    GetprivatedataMoredata = 20,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA"]/*'/>

    SetprivatedataInvalidfreedata = 21,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS"]/*'/>

    SetprivatedataChangingparams = 24,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY"]/*'/>

    SetprivatedataOutofmemory = 25,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT"]/*'/>

    CreateshaderresourceviewUnrecognizedformat = 26,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC"]/*'/>

    CreateshaderresourceviewInvaliddesc = 27,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT"]/*'/>

    CreateshaderresourceviewInvalidformat = 28,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANESLICE"]/*'/>

    CreateshaderresourceviewInvalidvideoplaneslice = 29,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANESLICE"]/*'/>

    CreateshaderresourceviewInvalidplaneslice = 30,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS"]/*'/>

    CreateshaderresourceviewInvaliddimensions = 31,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE"]/*'/>

    CreateshaderresourceviewInvalidresource = 32,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT"]/*'/>

    CreaterendertargetviewUnrecognizedformat = 35,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT"]/*'/>

    CreaterendertargetviewUnsupportedformat = 36,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC"]/*'/>

    CreaterendertargetviewInvaliddesc = 37,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT"]/*'/>

    CreaterendertargetviewInvalidformat = 38,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANESLICE"]/*'/>

    CreaterendertargetviewInvalidvideoplaneslice = 39,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANESLICE"]/*'/>

    CreaterendertargetviewInvalidplaneslice = 40,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS"]/*'/>

    CreaterendertargetviewInvaliddimensions = 41,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE"]/*'/>

    CreaterendertargetviewInvalidresource = 42,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT"]/*'/>

    CreatedepthstencilviewUnrecognizedformat = 45,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC"]/*'/>

    CreatedepthstencilviewInvaliddesc = 46,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT"]/*'/>

    CreatedepthstencilviewInvalidformat = 47,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS"]/*'/>

    CreatedepthstencilviewInvaliddimensions = 48,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE"]/*'/>

    CreatedepthstencilviewInvalidresource = 49,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY"]/*'/>

    CreateinputlayoutOutofmemory = 52,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS"]/*'/>

    CreateinputlayoutToomanyelements = 53,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT"]/*'/>

    CreateinputlayoutInvalidformat = 54,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT"]/*'/>

    CreateinputlayoutIncompatibleformat = 55,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT"]/*'/>

    CreateinputlayoutInvalidslot = 56,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS"]/*'/>

    CreateinputlayoutInvalidinputslotclass = 57,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH"]/*'/>

    CreateinputlayoutSteprateslotclassmismatch = 58,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE"]/*'/>

    CreateinputlayoutInvalidslotclasschange = 59,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE"]/*'/>

    CreateinputlayoutInvalidstepratechange = 60,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT"]/*'/>

    CreateinputlayoutInvalidalignment = 61,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC"]/*'/>

    CreateinputlayoutDuplicatesemantic = 62,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE"]/*'/>

    CreateinputlayoutUnparseableinputsignature = 63,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC"]/*'/>

    CreateinputlayoutNullsemantic = 64,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT"]/*'/>

    CreateinputlayoutMissingelement = 65,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY"]/*'/>

    CreatevertexshaderOutofmemory = 66,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatevertexshaderInvalidshaderbytecode = 67,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE"]/*'/>

    CreatevertexshaderInvalidshadertype = 68,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY"]/*'/>

    CreategeometryshaderOutofmemory = 69,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreategeometryshaderInvalidshaderbytecode = 70,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE"]/*'/>

    CreategeometryshaderInvalidshadertype = 71,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY"]/*'/>

    CreategeometryshaderwithstreamoutputOutofmemory = 72,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidshaderbytecode = 73,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidshadertype = 74,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidnumentries = 75,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED"]/*'/>

    CreategeometryshaderwithstreamoutputOutputstreamstrideunused = 76,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED"]/*'/>

    CreategeometryshaderwithstreamoutputOutputslot0Expected = 79,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidoutputslot = 80,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT"]/*'/>

    CreategeometryshaderwithstreamoutputOnlyoneelementperslot = 81,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidcomponentcount = 82,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 83,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidgapdefinition = 84,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT"]/*'/>

    CreategeometryshaderwithstreamoutputRepeatedoutput = 85,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 86,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC"]/*'/>

    CreategeometryshaderwithstreamoutputMissingsemantic = 87,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH"]/*'/>

    CreategeometryshaderwithstreamoutputMaskmismatch = 88,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS"]/*'/>

    CreategeometryshaderwithstreamoutputCanthaveonlygaps = 89,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX"]/*'/>

    CreategeometryshaderwithstreamoutputDecltoocomplex = 90,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE"]/*'/>

    CreategeometryshaderwithstreamoutputMissingoutputsignature = 91,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY"]/*'/>

    CreatepixelshaderOutofmemory = 92,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatepixelshaderInvalidshaderbytecode = 93,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE"]/*'/>

    CreatepixelshaderInvalidshadertype = 94,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE"]/*'/>

    CreaterasterizerstateInvalidfillmode = 95,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE"]/*'/>

    CreaterasterizerstateInvalidcullmode = 96,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP"]/*'/>

    CreaterasterizerstateInvaliddepthbiasclamp = 97,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS"]/*'/>

    CreaterasterizerstateInvalidslopescaleddepthbias = 98,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK"]/*'/>

    CreatedepthstencilstateInvaliddepthwritemask = 100,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC"]/*'/>

    CreatedepthstencilstateInvaliddepthfunc = 101,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP"]/*'/>

    CreatedepthstencilstateInvalidfrontfacestencilfailop = 102,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP"]/*'/>

    CreatedepthstencilstateInvalidfrontfacestencilzfailop = 103,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP"]/*'/>

    CreatedepthstencilstateInvalidfrontfacestencilpassop = 104,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC"]/*'/>

    CreatedepthstencilstateInvalidfrontfacestencilfunc = 105,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP"]/*'/>

    CreatedepthstencilstateInvalidbackfacestencilfailop = 106,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP"]/*'/>

    CreatedepthstencilstateInvalidbackfacestencilzfailop = 107,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP"]/*'/>

    CreatedepthstencilstateInvalidbackfacestencilpassop = 108,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC"]/*'/>

    CreatedepthstencilstateInvalidbackfacestencilfunc = 109,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND"]/*'/>

    CreateblendstateInvalidsrcblend = 111,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND"]/*'/>

    CreateblendstateInvaliddestblend = 112,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP"]/*'/>

    CreateblendstateInvalidblendop = 113,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA"]/*'/>

    CreateblendstateInvalidsrcblendalpha = 114,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA"]/*'/>

    CreateblendstateInvaliddestblendalpha = 115,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA"]/*'/>

    CreateblendstateInvalidblendopalpha = 116,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK"]/*'/>

    CreateblendstateInvalidrendertargetwritemask = 117,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_PROGRAM_IDENTIFIER_ERROR"]/*'/>

    GetProgramIdentifierError = 118,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_WORK_GRAPH_PROPERTIES_ERROR"]/*'/>

    GetWorkGraphPropertiesError = 119,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_PROGRAM_ERROR"]/*'/>

    SetProgramError = 120,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID"]/*'/>

    CleardepthstencilviewInvalid = 135,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_NOT_SET"]/*'/>

    CommandListDrawRootSignatureNotSet = 200,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CommandListDrawRootSignatureMismatch = 201,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_NOT_SET"]/*'/>

    CommandListDrawVertexBufferNotSet = 202,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL"]/*'/>

    CommandListDrawVertexBufferStrideTooSmall = 209,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_TOO_SMALL"]/*'/>

    CommandListDrawVertexBufferTooSmall = 210,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_NOT_SET"]/*'/>

    CommandListDrawIndexBufferNotSet = 211,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_FORMAT_INVALID"]/*'/>

    CommandListDrawIndexBufferFormatInvalid = 212,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_TOO_SMALL"]/*'/>

    CommandListDrawIndexBufferTooSmall = 213,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INVALID_PRIMITIVETOPOLOGY"]/*'/>

    CommandListDrawInvalidPrimitivetopology = 219,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_STRIDE_UNALIGNED"]/*'/>

    CommandListDrawVertexStrideUnaligned = 221,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_OFFSET_UNALIGNED"]/*'/>

    CommandListDrawIndexOffsetUnaligned = 222,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT"]/*'/>

    DeviceRemovalProcessAtFault = 232,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT"]/*'/>

    DeviceRemovalProcessPossiblyAtFault = 233,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT"]/*'/>

    DeviceRemovalProcessNotAtFault = 234,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC"]/*'/>

    CreateinputlayoutTrailingDigitInSemantic = 239,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC"]/*'/>

    CreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 240,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH"]/*'/>

    CreateinputlayoutTypeMismatch = 245,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT"]/*'/>

    CreateinputlayoutEmptyLayout = 253,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_OBJECT_SUMMARY"]/*'/>

    LiveObjectSummary = 255,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_DEVICE"]/*'/>

    LiveDevice = 274,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_SWAPCHAIN"]/*'/>

    LiveSwapchain = 275,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS"]/*'/>

    CreatedepthstencilviewInvalidflags = 276,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreatevertexshaderInvalidclasslinkage = 277,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreategeometryshaderInvalidclasslinkage = 278,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 280,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreatepixelshaderInvalidclasslinkage = 283,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidstream = 284,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES"]/*'/>

    CreategeometryshaderwithstreamoutputUnexpectedentries = 285,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES"]/*'/>

    CreategeometryshaderwithstreamoutputUnexpectedstrides = 286,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES"]/*'/>

    CreategeometryshaderwithstreamoutputInvalidnumstrides = 287,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY"]/*'/>

    CreatehullshaderOutofmemory = 289,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatehullshaderInvalidshaderbytecode = 290,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE"]/*'/>

    CreatehullshaderInvalidshadertype = 291,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreatehullshaderInvalidclasslinkage = 292,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY"]/*'/>

    CreatedomainshaderOutofmemory = 294,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatedomainshaderInvalidshaderbytecode = 295,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE"]/*'/>

    CreatedomainshaderInvalidshadertype = 296,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreatedomainshaderInvalidclasslinkage = 297,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED"]/*'/>

    ResourceUnmapNotmapped = 310,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE"]/*'/>

    DeviceCheckfeaturesupportMismatchedDataSize = 318,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY"]/*'/>

    CreatecomputeshaderOutofmemory = 321,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatecomputeshaderInvalidshaderbytecode = 322,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE"]/*'/>

    CreatecomputeshaderInvalidclasslinkage = 323,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreatevertexshaderDoublefloatopsnotsupported = 331,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreatehullshaderDoublefloatopsnotsupported = 332,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreatedomainshaderDoublefloatopsnotsupported = 333,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderDoublefloatopsnotsupported = 334,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 335,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreatepixelshaderDoublefloatopsnotsupported = 336,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED"]/*'/>

    DeviceCreatecomputeshaderDoublefloatopsnotsupported = 337,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE"]/*'/>

    CreateunorderedaccessviewInvalidresource = 340,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC"]/*'/>

    CreateunorderedaccessviewInvaliddesc = 341,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT"]/*'/>

    CreateunorderedaccessviewInvalidformat = 342,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANESLICE"]/*'/>

    CreateunorderedaccessviewInvalidvideoplaneslice = 343,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANESLICE"]/*'/>

    CreateunorderedaccessviewInvalidplaneslice = 344,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS"]/*'/>

    CreateunorderedaccessviewInvaliddimensions = 345,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT"]/*'/>

    CreateunorderedaccessviewUnrecognizedformat = 346,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS"]/*'/>

    CreateunorderedaccessviewInvalidflags = 354,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT"]/*'/>

    CreaterasterizerstateInvalidforcedsamplecount = 401,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS"]/*'/>

    CreateblendstateInvalidlogicops = 403,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreatevertexshaderDoubleextensionsnotsupported = 410,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreatehullshaderDoubleextensionsnotsupported = 412,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreatedomainshaderDoubleextensionsnotsupported = 414,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderDoubleextensionsnotsupported = 416,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 418,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreatepixelshaderDoubleextensionsnotsupported = 420,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED"]/*'/>

    DeviceCreatecomputeshaderDoubleextensionsnotsupported = 422,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreatevertexshaderUavsnotsupported = 425,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreatehullshaderUavsnotsupported = 426,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreatedomainshaderUavsnotsupported = 427,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderUavsnotsupported = 428,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 429,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreatepixelshaderUavsnotsupported = 430,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED"]/*'/>

    DeviceCreatecomputeshaderUavsnotsupported = 431,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT"]/*'/>

    DeviceClearviewInvalidsourcerect = 447,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT"]/*'/>

    DeviceClearviewEmptyrect = 448,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER"]/*'/>

    UpdatetilemappingsInvalidParameter = 493,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER"]/*'/>

    CopytilemappingsInvalidParameter = 494,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEVICE_INVALIDARGS"]/*'/>

    CreatedeviceInvalidargs = 506,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEVICE_WARNING"]/*'/>

    CreatedeviceWarning = 507,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_TYPE"]/*'/>

    ResourceBarrierInvalidType = 519,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_NULL_POINTER"]/*'/>

    ResourceBarrierNullPointer = 520,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SUBRESOURCE"]/*'/>

    ResourceBarrierInvalidSubresource = 521,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_RESERVED_BITS"]/*'/>

    ResourceBarrierReservedBits = 522,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISSING_BIND_FLAGS"]/*'/>

    ResourceBarrierMissingBindFlags = 523,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_MISC_FLAGS"]/*'/>

    ResourceBarrierMismatchingMiscFlags = 524,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_MATCHING_STATES"]/*'/>

    ResourceBarrierMatchingStates = 525,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINATION"]/*'/>

    ResourceBarrierInvalidCombination = 526,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_BEFORE_AFTER_MISMATCH"]/*'/>

    ResourceBarrierBeforeAfterMismatch = 527,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_RESOURCE"]/*'/>

    ResourceBarrierInvalidResource = 528,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_SAMPLE_COUNT"]/*'/>

    ResourceBarrierSampleCount = 529,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS"]/*'/>

    ResourceBarrierInvalidFlags = 530,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINED_FLAGS"]/*'/>

    ResourceBarrierInvalidCombinedFlags = 531,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS_FOR_FORMAT"]/*'/>

    ResourceBarrierInvalidFlagsForFormat = 532,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SPLIT_BARRIER"]/*'/>

    ResourceBarrierInvalidSplitBarrier = 533,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_END"]/*'/>

    ResourceBarrierUnmatchedEnd = 534,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_BEGIN"]/*'/>

    ResourceBarrierUnmatchedBegin = 535,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAG"]/*'/>

    ResourceBarrierInvalidFlag = 536,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMMAND_LIST_TYPE"]/*'/>

    ResourceBarrierInvalidCommandListType = 537,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_SUBRESOURCE_STATE"]/*'/>

    InvalidSubresourceState = 538,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CONTENTION"]/*'/>

    CommandAllocatorContention = 540,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET"]/*'/>

    CommandAllocatorReset = 541,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET_BUNDLE"]/*'/>

    CommandAllocatorResetBundle = 542,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CANNOT_RESET"]/*'/>

    CommandAllocatorCannotReset = 543,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_OPEN"]/*'/>

    CommandListOpen = 544,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_BUNDLE_API"]/*'/>

    InvalidBundleApi = 546,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_CLOSED"]/*'/>

    CommandListClosed = 547,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRONG_COMMAND_ALLOCATOR_TYPE"]/*'/>

    WrongCommandAllocatorType = 549,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_SYNC"]/*'/>

    CommandAllocatorSync = 552,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_SYNC"]/*'/>

    CommandListSync = 553,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_DESCRIPTOR_HEAP_INVALID"]/*'/>

    SetDescriptorHeapInvalid = 554,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDQUEUE"]/*'/>

    CreateCommandqueue = 557,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDALLOCATOR"]/*'/>

    CreateCommandallocator = 558,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_PIPELINESTATE"]/*'/>

    CreatePipelinestate = 559,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDLIST12"]/*'/>

    CreateCommandlist12 = 560,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_RESOURCE"]/*'/>

    CreateResource = 562,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_DESCRIPTORHEAP"]/*'/>

    CreateDescriptorheap = 563,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOTSIGNATURE"]/*'/>

    CreateRootsignature = 564,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_LIBRARY"]/*'/>

    CreateLibrary = 565,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_HEAP"]/*'/>

    CreateHeap = 566,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_MONITOREDFENCE"]/*'/>

    CreateMonitoredfence = 567,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_QUERYHEAP"]/*'/>

    CreateQueryheap = 568,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDSIGNATURE"]/*'/>

    CreateCommandsignature = 569,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDQUEUE"]/*'/>

    LiveCommandqueue = 570,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDALLOCATOR"]/*'/>

    LiveCommandallocator = 571,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_PIPELINESTATE"]/*'/>

    LivePipelinestate = 572,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDLIST12"]/*'/>

    LiveCommandlist12 = 573,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_RESOURCE"]/*'/>

    LiveResource = 575,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_DESCRIPTORHEAP"]/*'/>

    LiveDescriptorheap = 576,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_ROOTSIGNATURE"]/*'/>

    LiveRootsignature = 577,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_LIBRARY"]/*'/>

    LiveLibrary = 578,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_HEAP"]/*'/>

    LiveHeap = 579,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_MONITOREDFENCE"]/*'/>

    LiveMonitoredfence = 580,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_QUERYHEAP"]/*'/>

    LiveQueryheap = 581,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDSIGNATURE"]/*'/>

    LiveCommandsignature = 582,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDQUEUE"]/*'/>

    DestroyCommandqueue = 583,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDALLOCATOR"]/*'/>

    DestroyCommandallocator = 584,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_PIPELINESTATE"]/*'/>

    DestroyPipelinestate = 585,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDLIST12"]/*'/>

    DestroyCommandlist12 = 586,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_RESOURCE"]/*'/>

    DestroyResource = 588,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_DESCRIPTORHEAP"]/*'/>

    DestroyDescriptorheap = 589,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_ROOTSIGNATURE"]/*'/>

    DestroyRootsignature = 590,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_LIBRARY"]/*'/>

    DestroyLibrary = 591,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_HEAP"]/*'/>

    DestroyHeap = 592,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_MONITOREDFENCE"]/*'/>

    DestroyMonitoredfence = 593,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_QUERYHEAP"]/*'/>

    DestroyQueryheap = 594,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDSIGNATURE"]/*'/>

    DestroyCommandsignature = 595,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONS"]/*'/>

    CreateresourceInvaliddimensions = 597,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMISCFLAGS"]/*'/>

    CreateresourceInvalidmiscflags = 599,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDARG_RETURN"]/*'/>

    CreateresourceInvalidargReturn = 602,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_OUTOFMEMORY_RETURN"]/*'/>

    CreateresourceOutofmemoryReturn = 603,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDESC"]/*'/>

    CreateresourceInvaliddesc = 604,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_POSSIBLY_INVALID_SUBRESOURCE_STATE"]/*'/>

    PossiblyInvalidSubresourceState = 607,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_USE_OF_NON_RESIDENT_RESOURCE"]/*'/>

    InvalidUseOfNonResidentResource = 608,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_POSSIBLE_INVALID_USE_OF_NON_RESIDENT_RESOURCE"]/*'/>

    PossibleInvalidUseOfNonResidentResource = 609,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BUNDLE_PIPELINE_STATE_MISMATCH"]/*'/>

    BundlePipelineStateMismatch = 610,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_MISMATCH_PIPELINE_STATE"]/*'/>

    PrimitiveTopologyMismatchPipelineState = 611,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_TARGET_FORMAT_MISMATCH_PIPELINE_STATE"]/*'/>

    RenderTargetFormatMismatchPipelineState = 613,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_TARGET_SAMPLE_DESC_MISMATCH_PIPELINE_STATE"]/*'/>

    RenderTargetSampleDescMismatchPipelineState = 614,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEPTH_STENCIL_FORMAT_MISMATCH_PIPELINE_STATE"]/*'/>

    DepthStencilFormatMismatchPipelineState = 615,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEPTH_STENCIL_SAMPLE_DESC_MISMATCH_PIPELINE_STATE"]/*'/>

    DepthStencilSampleDescMismatchPipelineState = 616,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADER_INVALIDBYTECODE"]/*'/>

    CreateshaderInvalidbytecode = 622,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_NULLDESC"]/*'/>

    CreateheapNulldesc = 623,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDSIZE"]/*'/>

    CreateheapInvalidsize = 624,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDHEAPTYPE"]/*'/>

    CreateheapUnrecognizedheaptype = 625,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES"]/*'/>

    CreateheapUnrecognizedcpupageproperties = 626,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMEMORYPOOL"]/*'/>

    CreateheapUnrecognizedmemorypool = 627,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDPROPERTIES"]/*'/>

    CreateheapInvalidproperties = 628,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDALIGNMENT"]/*'/>

    CreateheapInvalidalignment = 629,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMISCFLAGS"]/*'/>

    CreateheapUnrecognizedmiscflags = 630,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDMISCFLAGS"]/*'/>

    CreateheapInvalidmiscflags = 631,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDARG_RETURN"]/*'/>

    CreateheapInvalidargReturn = 632,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_OUTOFMEMORY_RETURN"]/*'/>

    CreateheapOutofmemoryReturn = 633,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAPPROPERTIES"]/*'/>

    CreateresourceandheapNullheapproperties = 634,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPTYPE"]/*'/>

    CreateresourceandheapUnrecognizedheaptype = 635,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES"]/*'/>

    CreateresourceandheapUnrecognizedcpupageproperties = 636,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDMEMORYPOOL"]/*'/>

    CreateresourceandheapUnrecognizedmemorypool = 637,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPPROPERTIES"]/*'/>

    CreateresourceandheapInvalidheapproperties = 638,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPMISCFLAGS"]/*'/>

    CreateresourceandheapUnrecognizedheapmiscflags = 639,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPMISCFLAGS"]/*'/>

    CreateresourceandheapInvalidheapmiscflags = 640,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDARG_RETURN"]/*'/>

    CreateresourceandheapInvalidargReturn = 641,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_OUTOFMEMORY_RETURN"]/*'/>

    CreateresourceandheapOutofmemoryReturn = 642,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_UNRECOGNIZEDHEAPTYPE"]/*'/>

    GetcustomheappropertiesUnrecognizedheaptype = 643,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_INVALIDHEAPTYPE"]/*'/>

    GetcustomheappropertiesInvalidheaptype = 644,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_INVALID_DESC"]/*'/>

    CreateDescriptorHeapInvalidDesc = 645,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_DESCRIPTOR_HANDLE"]/*'/>

    InvalidDescriptorHandle = 646,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE"]/*'/>

    CreaterasterizerstateInvalidConservativerastermode = 647,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_RESOURCE"]/*'/>

    CreateConstantBufferViewInvalidResource = 649,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_DESC"]/*'/>

    CreateConstantBufferViewInvalidDesc = 650,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_UNORDEREDACCESS_VIEW_INVALID_COUNTER_USAGE"]/*'/>

    CreateUnorderedaccessViewInvalidCounterUsage = 652,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPY_DESCRIPTORS_INVALID_RANGES"]/*'/>

    CopyDescriptorsInvalidRanges = 653,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPY_DESCRIPTORS_WRITE_ONLY_DESCRIPTOR"]/*'/>

    CopyDescriptorsWriteOnlyDescriptor = 654,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RTV_FORMAT_NOT_UNKNOWN"]/*'/>

    CreategraphicspipelinestateRtvFormatNotUnknown = 655,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_RENDER_TARGET_COUNT"]/*'/>

    CreategraphicspipelinestateInvalidRenderTargetCount = 656,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VERTEX_SHADER_NOT_SET"]/*'/>

    CreategraphicspipelinestateVertexShaderNotSet = 657,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_NOT_SET"]/*'/>

    CreategraphicspipelinestateInputlayoutNotSet = 658,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_HS_DS_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateShaderLinkageHsDsSignatureMismatch = 659,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERINDEX"]/*'/>

    CreategraphicspipelinestateShaderLinkageRegisterindex = 660,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_COMPONENTTYPE"]/*'/>

    CreategraphicspipelinestateShaderLinkageComponenttype = 661,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERMASK"]/*'/>

    CreategraphicspipelinestateShaderLinkageRegistermask = 662,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SYSTEMVALUE"]/*'/>

    CreategraphicspipelinestateShaderLinkageSystemvalue = 663,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS"]/*'/>

    CreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads = 664,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_MINPRECISION"]/*'/>

    CreategraphicspipelinestateShaderLinkageMinprecision = 665,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND"]/*'/>

    CreategraphicspipelinestateShaderLinkageSemanticnameNotFound = 666,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_XOR_DS_MISMATCH"]/*'/>

    CreategraphicspipelinestateHsXorDsMismatch = 667,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH"]/*'/>

    CreategraphicspipelinestateHullShaderInputTopologyMismatch = 668,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_CONTROL_POINT_COUNT_MISMATCH"]/*'/>

    CreategraphicspipelinestateHsDsControlPointCountMismatch = 669,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_TESSELLATOR_DOMAIN_MISMATCH"]/*'/>

    CreategraphicspipelinestateHsDsTessellatorDomainMismatch = 670,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN"]/*'/>

    CreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern = 671,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_FORCED_SAMPLE_COUNT"]/*'/>

    CreategraphicspipelinestateInvalidUseOfForcedSampleCount = 672,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_PRIMITIVETOPOLOGY"]/*'/>

    CreategraphicspipelinestateInvalidPrimitivetopology = 673,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SYSTEMVALUE"]/*'/>

    CreategraphicspipelinestateInvalidSystemvalue = 674,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0"]/*'/>

    CreategraphicspipelinestateOmDualSourceBlendingCanOnlyHaveRenderTarget0 = 675,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING"]/*'/>

    CreategraphicspipelinestateOmRenderTargetDoesNotSupportBlending = 676,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_TYPE_MISMATCH"]/*'/>

    CreategraphicspipelinestatePsOutputTypeMismatch = 677,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS"]/*'/>

    CreategraphicspipelinestateOmRenderTargetDoesNotSupportLogicOps = 678,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDERTARGETVIEW_NOT_SET"]/*'/>

    CreategraphicspipelinestateRendertargetviewNotSet = 679,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DEPTHSTENCILVIEW_NOT_SET"]/*'/>

    CreategraphicspipelinestateDepthstencilviewNotSet = 680,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_INPUT_PRIMITIVE_MISMATCH"]/*'/>

    CreategraphicspipelinestateGsInputPrimitiveMismatch = 681,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_POSITION_NOT_PRESENT"]/*'/>

    CreategraphicspipelinestatePositionNotPresent = 682,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE_FLAGS"]/*'/>

    CreategraphicspipelinestateMissingRootSignatureFlags = 683,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_INDEX_BUFFER_PROPERTIES"]/*'/>

    CreategraphicspipelinestateInvalidIndexBufferProperties = 684,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SAMPLE_DESC"]/*'/>

    CreategraphicspipelinestateInvalidSampleDesc = 685,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateHsRootSignatureMismatch = 686,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateDsRootSignatureMismatch = 687,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateVsRootSignatureMismatch = 688,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateGsRootSignatureMismatch = 689,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestatePsRootSignatureMismatch = 690,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE"]/*'/>

    CreategraphicspipelinestateMissingRootSignature = 691,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_BUNDLE_OPEN_BUNDLE"]/*'/>

    ExecuteBundleOpenBundle = 692,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_BUNDLE_DESCRIPTOR_HEAP_MISMATCH"]/*'/>

    ExecuteBundleDescriptorHeapMismatch = 693,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_BUNDLE_TYPE"]/*'/>

    ExecuteBundleType = 694,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DRAW_EMPTY_SCISSOR_RECTANGLE"]/*'/>

    DrawEmptyScissorRectangle = 695,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_BLOB_NOT_FOUND"]/*'/>

    CreateRootSignatureBlobNotFound = 696,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_DESERIALIZE_FAILED"]/*'/>

    CreateRootSignatureDeserializeFailed = 697,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_INVALID_CONFIGURATION"]/*'/>

    CreateRootSignatureInvalidConfiguration = 698,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_SUPPORTED_ON_DEVICE"]/*'/>

    CreateRootSignatureNotSupportedOnDevice = 699,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLRESOURCEPROPERTIES"]/*'/>

    CreateresourceandheapNullresourceproperties = 700,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAP"]/*'/>

    CreateresourceandheapNullheap = 701,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETRESOURCEALLOCATIONINFO_INVALIDRDESCS"]/*'/>

    GetresourceallocationinfoInvalidrdescs = 702,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAKERESIDENT_NULLOBJECTARRAY"]/*'/>

    MakeresidentNullobjectarray = 703,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EVICT_NULLOBJECTARRAY"]/*'/>

    EvictNullobjectarray = 705,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_DESCRIPTOR_TABLE_INVALID"]/*'/>

    SetDescriptorTableInvalid = 708,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_INVALID"]/*'/>

    SetRootConstantInvalid = 709,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_BUFFER_VIEW_INVALID"]/*'/>

    SetRootConstantBufferViewInvalid = 710,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_ROOT_SHADER_RESOURCE_VIEW_INVALID"]/*'/>

    SetRootShaderResourceViewInvalid = 711,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_ROOT_UNORDERED_ACCESS_VIEW_INVALID"]/*'/>

    SetRootUnorderedAccessViewInvalid = 712,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID_DESC"]/*'/>

    SetVertexBuffersInvalidDesc = 713,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID_DESC"]/*'/>

    SetIndexBufferInvalidDesc = 715,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID_DESC"]/*'/>

    SetStreamOutputBuffersInvalidDesc = 717,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDDIMENSIONALITY"]/*'/>

    CreateresourceUnrecognizeddimensionality = 718,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDLAYOUT"]/*'/>

    CreateresourceUnrecognizedlayout = 719,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONALITY"]/*'/>

    CreateresourceInvaliddimensionality = 720,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT"]/*'/>

    CreateresourceInvalidalignment = 721,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMIPLEVELS"]/*'/>

    CreateresourceInvalidmiplevels = 722,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDSAMPLEDESC"]/*'/>

    CreateresourceInvalidsampledesc = 723,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDLAYOUT"]/*'/>

    CreateresourceInvalidlayout = 724,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID"]/*'/>

    SetIndexBufferInvalid = 725,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID"]/*'/>

    SetVertexBuffersInvalid = 726,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID"]/*'/>

    SetStreamOutputBuffersInvalid = 727,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_RENDER_TARGETS_INVALID"]/*'/>

    SetRenderTargetsInvalid = 728,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEQUERY_HEAP_INVALID_PARAMETERS"]/*'/>

    CreatequeryHeapInvalidParameters = 729,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BEGIN_END_QUERY_INVALID_PARAMETERS"]/*'/>

    BeginEndQueryInvalidParameters = 731,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLOSE_COMMAND_LIST_OPEN_QUERY"]/*'/>

    CloseCommandListOpenQuery = 732,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_QUERY_DATA_INVALID_PARAMETERS"]/*'/>

    ResolveQueryDataInvalidParameters = 733,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_PREDICATION_INVALID_PARAMETERS"]/*'/>

    SetPredicationInvalidParameters = 734,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_TIMESTAMPS_NOT_SUPPORTED"]/*'/>

    TimestampsNotSupported = 735,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDFORMAT"]/*'/>

    CreateresourceUnrecognizedformat = 737,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDFORMAT"]/*'/>

    CreateresourceInvalidformat = 738,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDSUBRESOURCERANGE"]/*'/>

    GetcopyablefootprintsInvalidsubresourcerange = 739,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDBASEOFFSET"]/*'/>

    GetcopyablefootprintsInvalidbaseoffset = 740,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDSUBRESOURCERANGE"]/*'/>

    GetcopyablelayoutInvalidsubresourcerange = 739,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDBASEOFFSET"]/*'/>

    GetcopyablelayoutInvalidbaseoffset = 740,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_HEAP"]/*'/>

    ResourceBarrierInvalidHeap = 741,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_SAMPLER_INVALID"]/*'/>

    CreateSamplerInvalid = 742,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMMANDSIGNATURE_INVALID"]/*'/>

    CreatecommandsignatureInvalid = 743,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_INDIRECT_INVALID_PARAMETERS"]/*'/>

    ExecuteIndirectInvalidParameters = 744,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_RESOURCE_DIMENSION"]/*'/>

    GetgpuvirtualaddressInvalidResourceDimension = 745,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUE"]/*'/>

    CreateresourceInvalidclearvalue = 815,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDCLEARVALUEFORMAT"]/*'/>

    CreateresourceUnrecognizedclearvalueformat = 816,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUEFORMAT"]/*'/>

    CreateresourceInvalidclearvalueformat = 817,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_CLEARVALUEDENORMFLUSH"]/*'/>

    CreateresourceClearvaluedenormflush = 818,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE"]/*'/>

    ClearrendertargetviewMismatchingclearvalue = 820,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_MISMATCHINGCLEARVALUE"]/*'/>

    CleardepthstencilviewMismatchingclearvalue = 821,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDHEAP"]/*'/>

    MapInvalidheap = 822,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALIDHEAP"]/*'/>

    UnmapInvalidheap = 823,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDRESOURCE"]/*'/>

    MapInvalidresource = 824,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALIDRESOURCE"]/*'/>

    UnmapInvalidresource = 825,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDSUBRESOURCE"]/*'/>

    MapInvalidsubresource = 826,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALIDSUBRESOURCE"]/*'/>

    UnmapInvalidsubresource = 827,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDRANGE"]/*'/>

    MapInvalidrange = 828,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALIDRANGE"]/*'/>

    UnmapInvalidrange = 829,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDDATAPOINTER"]/*'/>

    MapInvaliddatapointer = 832,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALIDARG_RETURN"]/*'/>

    MapInvalidargReturn = 833,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_OUTOFMEMORY_RETURN"]/*'/>

    MapOutofmemoryReturn = 834,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_BUNDLENOTSUPPORTED"]/*'/>

    ExecutecommandlistsBundlenotsupported = 835,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_COMMANDLISTMISMATCH"]/*'/>

    ExecutecommandlistsCommandlistmismatch = 836,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_OPENCOMMANDLIST"]/*'/>

    ExecutecommandlistsOpencommandlist = 837,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_FAILEDCOMMANDLIST"]/*'/>

    ExecutecommandlistsFailedcommandlist = 838,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLDST"]/*'/>

    CopybufferregionNulldst = 839,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDDSTRESOURCEDIMENSION"]/*'/>

    CopybufferregionInvaliddstresourcedimension = 840,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_DSTRANGEOUTOFBOUNDS"]/*'/>

    CopybufferregionDstrangeoutofbounds = 841,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLSRC"]/*'/>

    CopybufferregionNullsrc = 842,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDSRCRESOURCEDIMENSION"]/*'/>

    CopybufferregionInvalidsrcresourcedimension = 843,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_SRCRANGEOUTOFBOUNDS"]/*'/>

    CopybufferregionSrcrangeoutofbounds = 844,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDCOPYFLAGS"]/*'/>

    CopybufferregionInvalidcopyflags = 845,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLDST"]/*'/>

    CopytextureregionNulldst = 846,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTTYPE"]/*'/>

    CopytextureregionUnrecognizeddsttype = 847,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCEDIMENSION"]/*'/>

    CopytextureregionInvaliddstresourcedimension = 848,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCE"]/*'/>

    CopytextureregionInvaliddstresource = 849,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTSUBRESOURCE"]/*'/>

    CopytextureregionInvaliddstsubresource = 850,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTOFFSET"]/*'/>

    CopytextureregionInvaliddstoffset = 851,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTFORMAT"]/*'/>

    CopytextureregionUnrecognizeddstformat = 852,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTFORMAT"]/*'/>

    CopytextureregionInvaliddstformat = 853,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDIMENSIONS"]/*'/>

    CopytextureregionInvaliddstdimensions = 854,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTROWPITCH"]/*'/>

    CopytextureregionInvaliddstrowpitch = 855,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTPLACEMENT"]/*'/>

    CopytextureregionInvaliddstplacement = 856,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDSPLACEDFOOTPRINTFORMAT"]/*'/>

    CopytextureregionInvaliddstdsplacedfootprintformat = 857,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_DSTREGIONOUTOFBOUNDS"]/*'/>

    CopytextureregionDstregionoutofbounds = 858,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLSRC"]/*'/>

    CopytextureregionNullsrc = 859,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCTYPE"]/*'/>

    CopytextureregionUnrecognizedsrctype = 860,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCEDIMENSION"]/*'/>

    CopytextureregionInvalidsrcresourcedimension = 861,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCE"]/*'/>

    CopytextureregionInvalidsrcresource = 862,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCSUBRESOURCE"]/*'/>

    CopytextureregionInvalidsrcsubresource = 863,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCOFFSET"]/*'/>

    CopytextureregionInvalidsrcoffset = 864,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCFORMAT"]/*'/>

    CopytextureregionUnrecognizedsrcformat = 865,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCFORMAT"]/*'/>

    CopytextureregionInvalidsrcformat = 866,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDIMENSIONS"]/*'/>

    CopytextureregionInvalidsrcdimensions = 867,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCROWPITCH"]/*'/>

    CopytextureregionInvalidsrcrowpitch = 868,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCPLACEMENT"]/*'/>

    CopytextureregionInvalidsrcplacement = 869,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDSPLACEDFOOTPRINTFORMAT"]/*'/>

    CopytextureregionInvalidsrcdsplacedfootprintformat = 870,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_SRCREGIONOUTOFBOUNDS"]/*'/>

    CopytextureregionSrcregionoutofbounds = 871,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTCOORDINATES"]/*'/>

    CopytextureregionInvaliddstcoordinates = 872,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCBOX"]/*'/>

    CopytextureregionInvalidsrcbox = 873,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_FORMATMISMATCH"]/*'/>

    CopytextureregionFormatmismatch = 874,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_EMPTYBOX"]/*'/>

    CopytextureregionEmptybox = 875,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDCOPYFLAGS"]/*'/>

    CopytextureregionInvalidcopyflags = 876,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SUBRESOURCE_INDEX"]/*'/>

    ResolvesubresourceInvalidSubresourceIndex = 877,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_FORMAT"]/*'/>

    ResolvesubresourceInvalidFormat = 878,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_MISMATCH"]/*'/>

    ResolvesubresourceResourceMismatch = 879,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SAMPLE_COUNT"]/*'/>

    ResolvesubresourceInvalidSampleCount = 880,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_INVALID_SHADER"]/*'/>

    CreatecomputepipelinestateInvalidShader = 881,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_CS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreatecomputepipelinestateCsRootSignatureMismatch = 882,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_MISSING_ROOT_SIGNATURE"]/*'/>

    CreatecomputepipelinestateMissingRootSignature = 883,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALIDCACHEDBLOB"]/*'/>

    CreatepipelinestateInvalidcachedblob = 884,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBADAPTERMISMATCH"]/*'/>

    CreatepipelinestateCachedblobadaptermismatch = 885,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDRIVERVERSIONMISMATCH"]/*'/>

    CreatepipelinestateCachedblobdriverversionmismatch = 886,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDESCMISMATCH"]/*'/>

    CreatepipelinestateCachedblobdescmismatch = 887,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBIGNORED"]/*'/>

    CreatepipelinestateCachedblobignored = 888,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDHEAP"]/*'/>

    WritetosubresourceInvalidheap = 889,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDRESOURCE"]/*'/>

    WritetosubresourceInvalidresource = 890,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDBOX"]/*'/>

    WritetosubresourceInvalidbox = 891,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDSUBRESOURCE"]/*'/>

    WritetosubresourceInvalidsubresource = 892,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_EMPTYBOX"]/*'/>

    WritetosubresourceEmptybox = 893,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDHEAP"]/*'/>

    ReadfromsubresourceInvalidheap = 894,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDRESOURCE"]/*'/>

    ReadfromsubresourceInvalidresource = 895,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDBOX"]/*'/>

    ReadfromsubresourceInvalidbox = 896,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDSUBRESOURCE"]/*'/>

    ReadfromsubresourceInvalidsubresource = 897,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_READFROMSUBRESOURCE_EMPTYBOX"]/*'/>

    ReadfromsubresourceEmptybox = 898,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_TOO_MANY_NODES_SPECIFIED"]/*'/>

    TooManyNodesSpecified = 899,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_NODE_INDEX"]/*'/>

    InvalidNodeIndex = 900,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETHEAPPROPERTIES_INVALIDRESOURCE"]/*'/>

    GetheappropertiesInvalidresource = 901,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NODE_MASK_MISMATCH"]/*'/>

    NodeMaskMismatch = 902,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_OUTOFMEMORY"]/*'/>

    CommandListOutofmemory = 903,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_MULTIPLE_SWAPCHAIN_BUFFER_REFERENCES"]/*'/>

    CommandListMultipleSwapchainBufferReferences = 904,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_TOO_MANY_SWAPCHAIN_REFERENCES"]/*'/>

    CommandListTooManySwapchainReferences = 905,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_QUEUE_TOO_MANY_SWAPCHAIN_REFERENCES"]/*'/>

    CommandQueueTooManySwapchainReferences = 906,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_WRONGSWAPCHAINBUFFERREFERENCE"]/*'/>

    ExecutecommandlistsWrongswapchainbufferreference = 907,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_SETRENDERTARGETS_INVALIDNUMRENDERTARGETS"]/*'/>

    CommandListSetrendertargetsInvalidnumrendertargets = 908,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_TYPE"]/*'/>

    CreateQueueInvalidType = 909,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_FLAGS"]/*'/>

    CreateQueueInvalidFlags = 910,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFLAGS"]/*'/>

    CreatesharedresourceInvalidflags = 911,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFORMAT"]/*'/>

    CreatesharedresourceInvalidformat = 912,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHAREDHEAP_INVALIDFLAGS"]/*'/>

    CreatesharedheapInvalidflags = 913,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_UNRECOGNIZEDPROPERTIES"]/*'/>

    ReflectsharedpropertiesUnrecognizedproperties = 914,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDSIZE"]/*'/>

    ReflectsharedpropertiesInvalidsize = 915,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDOBJECT"]/*'/>

    ReflectsharedpropertiesInvalidobject = 916,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDOBJECT"]/*'/>

    KeyedmutexInvalidobject = 917,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDKEY"]/*'/>

    KeyedmutexInvalidkey = 918,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_KEYEDMUTEX_WRONGSTATE"]/*'/>

    KeyedmutexWrongstate = 919,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_PRIORITY"]/*'/>

    CreateQueueInvalidPriority = 920,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OBJECT_DELETED_WHILE_STILL_IN_USE"]/*'/>

    ObjectDeletedWhileStillInUse = 921,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_FLAGS"]/*'/>

    CreatepipelinestateInvalidFlags = 922,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_HAS_NO_RESOURCE"]/*'/>

    HeapAddressRangeHasNoResource = 923,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_RENDER_TARGET_DELETED"]/*'/>

    CommandListDrawRenderTargetDeleted = 924,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_ALL_RENDER_TARGETS_HAVE_UNKNOWN_FORMAT"]/*'/>

    CreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat = 925,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_INTERSECTS_MULTIPLE_BUFFERS"]/*'/>

    HeapAddressRangeIntersectsMultipleBuffers = 926,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_GPU_WRITTEN_READBACK_RESOURCE_MAPPED"]/*'/>

    ExecutecommandlistsGpuWrittenReadbackResourceMapped = 927,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_RANGE_NOT_EMPTY"]/*'/>

    UnmapRangeNotEmpty = 929,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE"]/*'/>

    MapInvalidNullrange = 930,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE"]/*'/>

    UnmapInvalidNullrange = 931,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NO_GRAPHICS_API_SUPPORT"]/*'/>

    NoGraphicsApiSupport = 932,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NO_COMPUTE_API_SUPPORT"]/*'/>

    NoComputeApiSupport = 933,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_FLAGS_NOT_SUPPORTED"]/*'/>

    ResolvesubresourceResourceFlagsNotSupported = 934,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_ARGUMENT_UNINITIALIZED"]/*'/>

    GpuBasedValidationRootArgumentUninitialized = 935,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_HEAP_INDEX_OUT_OF_BOUNDS"]/*'/>

    GpuBasedValidationDescriptorHeapIndexOutOfBounds = 936,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TABLE_REGISTER_INDEX_OUT_OF_BOUNDS"]/*'/>

    GpuBasedValidationDescriptorTableRegisterIndexOutOfBounds = 937,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_UNINITIALIZED"]/*'/>

    GpuBasedValidationDescriptorUninitialized = 938,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TYPE_MISMATCH"]/*'/>

    GpuBasedValidationDescriptorTypeMismatch = 939,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SRV_RESOURCE_DIMENSION_MISMATCH"]/*'/>

    GpuBasedValidationSrvResourceDimensionMismatch = 940,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UAV_RESOURCE_DIMENSION_MISMATCH"]/*'/>

    GpuBasedValidationUavResourceDimensionMismatch = 941,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_RESOURCE_STATE"]/*'/>

    GpuBasedValidationIncompatibleResourceState = 942,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_NULLDST"]/*'/>

    CopyresourceNulldst = 943,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDDSTRESOURCE"]/*'/>

    CopyresourceInvaliddstresource = 944,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_NULLSRC"]/*'/>

    CopyresourceNullsrc = 945,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDSRCRESOURCE"]/*'/>

    CopyresourceInvalidsrcresource = 946,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLDST"]/*'/>

    ResolvesubresourceNulldst = 947,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDDSTRESOURCE"]/*'/>

    ResolvesubresourceInvaliddstresource = 948,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLSRC"]/*'/>

    ResolvesubresourceNullsrc = 949,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDSRCRESOURCE"]/*'/>

    ResolvesubresourceInvalidsrcresource = 950,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PIPELINE_STATE_TYPE_MISMATCH"]/*'/>

    PipelineStateTypeMismatch = 951,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_NOT_SET"]/*'/>

    CommandListDispatchRootSignatureNotSet = 952,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CommandListDispatchRootSignatureMismatch = 953,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_ZERO_BARRIERS"]/*'/>

    ResourceBarrierZeroBarriers = 954,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BEGIN_END_EVENT_MISMATCH"]/*'/>

    BeginEndEventMismatch = 955,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_POSSIBLE_BEFORE_AFTER_MISMATCH"]/*'/>

    ResourceBarrierPossibleBeforeAfterMismatch = 956,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_BEGIN_END"]/*'/>

    ResourceBarrierMismatchingBeginEnd = 957,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INVALID_RESOURCE"]/*'/>

    GpuBasedValidationInvalidResource = 958,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT"]/*'/>

    UseOfZeroRefcountObject = 959,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OBJECT_EVICTED_WHILE_STILL_IN_USE"]/*'/>

    ObjectEvictedWhileStillInUse = 960,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_DESCRIPTOR_ACCESS_OUT_OF_BOUNDS"]/*'/>

    GpuBasedValidationRootDescriptorAccessOutOfBounds = 961,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_INVALIDLIBRARYBLOB"]/*'/>

    CreatepipelinelibraryInvalidlibraryblob = 962,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_DRIVERVERSIONMISMATCH"]/*'/>

    CreatepipelinelibraryDriverversionmismatch = 963,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_ADAPTERVERSIONMISMATCH"]/*'/>

    CreatepipelinelibraryAdapterversionmismatch = 964,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_UNSUPPORTED"]/*'/>

    CreatepipelinelibraryUnsupported = 965,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_PIPELINELIBRARY"]/*'/>

    CreatePipelinelibrary = 966,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_PIPELINELIBRARY"]/*'/>

    LivePipelinelibrary = 967,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_PIPELINELIBRARY"]/*'/>

    DestroyPipelinelibrary = 968,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_STOREPIPELINE_NONAME"]/*'/>

    StorepipelineNoname = 969,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_STOREPIPELINE_DUPLICATENAME"]/*'/>

    StorepipelineDuplicatename = 970,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LOADPIPELINE_NAMENOTFOUND"]/*'/>

    LoadpipelineNamenotfound = 971,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LOADPIPELINE_INVALIDDESC"]/*'/>

    LoadpipelineInvaliddesc = 972,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PIPELINELIBRARY_SERIALIZE_NOTENOUGHMEMORY"]/*'/>

    PipelinelibrarySerializeNotenoughmemory = 973,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_RT_OUTPUT_MISMATCH"]/*'/>

    CreategraphicspipelinestatePsOutputRtOutputMismatch = 974,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETEVENTONMULTIPLEFENCECOMPLETION_INVALIDFLAGS"]/*'/>

    SeteventonmultiplefencecompletionInvalidflags = 975,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_QUEUE_VIDEO_NOT_SUPPORTED"]/*'/>

    CreateQueueVideoNotSupported = 976,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_ALLOCATOR_VIDEO_NOT_SUPPORTED"]/*'/>

    CreateCommandAllocatorVideoNotSupported = 977,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEQUERY_HEAP_VIDEO_DECODE_STATISTICS_NOT_SUPPORTED"]/*'/>

    CreatequeryHeapVideoDecodeStatisticsNotSupported = 978,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDLIST"]/*'/>

    CreateVideodecodecommandlist = 979,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEODECODER"]/*'/>

    CreateVideodecoder = 980,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEODECODESTREAM"]/*'/>

    CreateVideodecodestream = 981,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDLIST"]/*'/>

    LiveVideodecodecommandlist = 982,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEODECODER"]/*'/>

    LiveVideodecoder = 983,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEODECODESTREAM"]/*'/>

    LiveVideodecodestream = 984,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDLIST"]/*'/>

    DestroyVideodecodecommandlist = 985,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEODECODER"]/*'/>

    DestroyVideodecoder = 986,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEODECODESTREAM"]/*'/>

    DestroyVideodecodestream = 987,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DECODE_FRAME_INVALID_PARAMETERS"]/*'/>

    DecodeFrameInvalidParameters = 988,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEPRECATED_API"]/*'/>

    DeprecatedApi = 989,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_COMMAND_LIST_TYPE"]/*'/>

    ResourceBarrierMismatchingCommandListType = 990,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DESCRIPTOR_TABLE_NOT_SET"]/*'/>

    CommandListDescriptorTableNotSet = 991,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_CONSTANT_BUFFER_VIEW_NOT_SET"]/*'/>

    CommandListRootConstantBufferViewNotSet = 992,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_SHADER_RESOURCE_VIEW_NOT_SET"]/*'/>

    CommandListRootShaderResourceViewNotSet = 993,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_UNORDERED_ACCESS_VIEW_NOT_SET"]/*'/>

    CommandListRootUnorderedAccessViewNotSet = 994,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DISCARD_INVALID_SUBRESOURCE_RANGE"]/*'/>

    DiscardInvalidSubresourceRange = 995,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DISCARD_ONE_SUBRESOURCE_FOR_MIPS_WITH_RECTS"]/*'/>

    DiscardOneSubresourceForMipsWithRects = 996,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DISCARD_NO_RECTS_FOR_NON_TEXTURE2D"]/*'/>

    DiscardNoRectsForNonTexture2D = 997,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPY_ON_SAME_SUBRESOURCE"]/*'/>

    CopyOnSameSubresource = 998,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PAGEABLE"]/*'/>

    SetresidencypriorityInvalidPageable = 999,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UNSUPPORTED"]/*'/>

    GpuBasedValidationUnsupported = 1000,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_STATIC_DESCRIPTOR_INVALID_DESCRIPTOR_CHANGE"]/*'/>

    StaticDescriptorInvalidDescriptorChange = 1001,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DATA_STATIC_DESCRIPTOR_INVALID_DATA_CHANGE"]/*'/>

    DataStaticDescriptorInvalidDataChange = 1002,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DATA_STATIC_WHILE_SET_AT_EXECUTE_DESCRIPTOR_INVALID_DATA_CHANGE"]/*'/>

    DataStaticWhileSetAtExecuteDescriptorInvalidDataChange = 1003,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_BUNDLE_STATIC_DESCRIPTOR_DATA_STATIC_NOT_SET"]/*'/>

    ExecuteBundleStaticDescriptorDataStaticNotSet = 1004,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_ACCESS_OUT_OF_BOUNDS"]/*'/>

    GpuBasedValidationResourceAccessOutOfBounds = 1005,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SAMPLER_MODE_MISMATCH"]/*'/>

    GpuBasedValidationSamplerModeMismatch = 1006,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_FENCE_INVALID_FLAGS"]/*'/>

    CreateFenceInvalidFlags = 1007,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_BARRIER_DUPLICATE_SUBRESOURCE_TRANSITIONS"]/*'/>

    ResourceBarrierDuplicateSubresourceTransitions = 1008,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PRIORITY"]/*'/>

    SetresidencypriorityInvalidPriority = 1009,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_LARGE_NUM_DESCRIPTORS"]/*'/>

    CreateDescriptorHeapLargeNumDescriptors = 1013,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BEGIN_EVENT"]/*'/>

    BeginEvent = 1014,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_END_EVENT"]/*'/>

    EndEvent = 1015,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEVICE_DEBUG_LAYER_STARTUP_OPTIONS"]/*'/>

    CreatedeviceDebugLayerStartupOptions = 1016,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_DEPTHBOUNDSTEST_UNSUPPORTED"]/*'/>

    CreatedepthstencilstateDepthboundstestUnsupported = 1017,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_DUPLICATE_SUBOBJECT"]/*'/>

    CreatepipelinestateDuplicateSubobject = 1018,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_UNKNOWN_SUBOBJECT"]/*'/>

    CreatepipelinestateUnknownSubobject = 1019,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_ZERO_SIZE_STREAM"]/*'/>

    CreatepipelinestateZeroSizeStream = 1020,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_STREAM"]/*'/>

    CreatepipelinestateInvalidStream = 1021,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CANNOT_DEDUCE_TYPE"]/*'/>

    CreatepipelinestateCannotDeduceType = 1022,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_RESOURCE_DIMENSION_MISMATCH"]/*'/>

    CommandListStaticDescriptorResourceDimensionMismatch = 1023,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_PRIVILEGE_FOR_GLOBAL_REALTIME"]/*'/>

    CreateCommandQueueInsufficientPrivilegeForGlobalRealtime = 1024,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_HARDWARE_SUPPORT_FOR_GLOBAL_REALTIME"]/*'/>

    CreateCommandQueueInsufficientHardwareSupportForGlobalRealtime = 1025,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_ARCHITECTURE"]/*'/>

    AtomiccopybufferInvalidArchitecture = 1026,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DST"]/*'/>

    AtomiccopybufferNullDst = 1027,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE_DIMENSION"]/*'/>

    AtomiccopybufferInvalidDstResourceDimension = 1028,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DST_RANGE_OUT_OF_BOUNDS"]/*'/>

    AtomiccopybufferDstRangeOutOfBounds = 1029,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_SRC"]/*'/>

    AtomiccopybufferNullSrc = 1030,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE_DIMENSION"]/*'/>

    AtomiccopybufferInvalidSrcResourceDimension = 1031,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_SRC_RANGE_OUT_OF_BOUNDS"]/*'/>

    AtomiccopybufferSrcRangeOutOfBounds = 1032,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_OFFSET_ALIGNMENT"]/*'/>

    AtomiccopybufferInvalidOffsetAlignment = 1033,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_RESOURCES"]/*'/>

    AtomiccopybufferNullDependentResources = 1034,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_SUBRESOURCE_RANGES"]/*'/>

    AtomiccopybufferNullDependentSubresourceRanges = 1035,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_RESOURCE"]/*'/>

    AtomiccopybufferInvalidDependentResource = 1036,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_SUBRESOURCE_RANGE"]/*'/>

    AtomiccopybufferInvalidDependentSubresourceRange = 1037,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_SUBRESOURCE_OUT_OF_BOUNDS"]/*'/>

    AtomiccopybufferDependentSubresourceOutOfBounds = 1038,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_RANGE_OUT_OF_BOUNDS"]/*'/>

    AtomiccopybufferDependentRangeOutOfBounds = 1039,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_ZERO_DEPENDENCIES"]/*'/>

    AtomiccopybufferZeroDependencies = 1040,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_CREATE_SHARED_HANDLE_INVALIDARG"]/*'/>

    DeviceCreateSharedHandleInvalidarg = 1041,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESCRIPTOR_HANDLE_WITH_INVALID_RESOURCE"]/*'/>

    DescriptorHandleWithInvalidResource = 1042,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETDEPTHBOUNDS_INVALIDARGS"]/*'/>

    SetdepthboundsInvalidargs = 1043,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_STATE_IMPRECISE"]/*'/>

    GpuBasedValidationResourceStateImprecise = 1044,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_PIPELINE_STATE_NOT_SET"]/*'/>

    CommandListPipelineStateNotSet = 1045,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_MODEL_MISMATCH"]/*'/>

    CreategraphicspipelinestateShaderModelMismatch = 1046,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OBJECT_ACCESSED_WHILE_STILL_IN_USE"]/*'/>

    ObjectAccessedWhileStillInUse = 1047,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PROGRAMMABLE_MSAA_UNSUPPORTED"]/*'/>

    ProgrammableMsaaUnsupported = 1048,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETSAMPLEPOSITIONS_INVALIDARGS"]/*'/>

    SetsamplepositionsInvalidargs = 1049,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCEREGION_INVALID_RECT"]/*'/>

    ResolvesubresourceregionInvalidRect = 1050,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDQUEUE"]/*'/>

    CreateVideodecodecommandqueue = 1051,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDLIST"]/*'/>

    CreateVideoprocesscommandlist = 1052,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDQUEUE"]/*'/>

    CreateVideoprocesscommandqueue = 1053,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDQUEUE"]/*'/>

    LiveVideodecodecommandqueue = 1054,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDLIST"]/*'/>

    LiveVideoprocesscommandlist = 1055,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDQUEUE"]/*'/>

    LiveVideoprocesscommandqueue = 1056,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDQUEUE"]/*'/>

    DestroyVideodecodecommandqueue = 1057,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDLIST"]/*'/>

    DestroyVideoprocesscommandlist = 1058,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDQUEUE"]/*'/>

    DestroyVideoprocesscommandqueue = 1059,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSOR"]/*'/>

    CreateVideoprocessor = 1060,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSSTREAM"]/*'/>

    CreateVideoprocessstream = 1061,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSOR"]/*'/>

    LiveVideoprocessor = 1062,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSSTREAM"]/*'/>

    LiveVideoprocessstream = 1063,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSOR"]/*'/>

    DestroyVideoprocessor = 1064,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSSTREAM"]/*'/>

    DestroyVideoprocessstream = 1065,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PROCESS_FRAME_INVALID_PARAMETERS"]/*'/>

    ProcessFrameInvalidParameters = 1066,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPY_INVALIDLAYOUT"]/*'/>

    CopyInvalidlayout = 1067,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION"]/*'/>

    CreateCryptoSession = 1068,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION_POLICY"]/*'/>

    CreateCryptoSessionPolicy = 1069,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION"]/*'/>

    CreateProtectedResourceSession = 1070,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION"]/*'/>

    LiveCryptoSession = 1071,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION_POLICY"]/*'/>

    LiveCryptoSessionPolicy = 1072,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_PROTECTED_RESOURCE_SESSION"]/*'/>

    LiveProtectedResourceSession = 1073,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION"]/*'/>

    DestroyCryptoSession = 1074,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION_POLICY"]/*'/>

    DestroyCryptoSessionPolicy = 1075,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_PROTECTED_RESOURCE_SESSION"]/*'/>

    DestroyProtectedResourceSession = 1076,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PROTECTED_RESOURCE_SESSION_UNSUPPORTED"]/*'/>

    ProtectedResourceSessionUnsupported = 1077,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_FENCE_INVALIDOPERATION"]/*'/>

    FenceInvalidoperation = 1078,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEQUERY_HEAP_COPY_QUEUE_TIMESTAMPS_NOT_SUPPORTED"]/*'/>

    CreatequeryHeapCopyQueueTimestampsNotSupported = 1079,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_DEFERRED"]/*'/>

    SamplepositionsMismatchDeferred = 1080,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMFIRSTUSE"]/*'/>

    SamplepositionsMismatchRecordtimeAssumedfromfirstuse = 1081,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMCLEAR"]/*'/>

    SamplepositionsMismatchRecordtimeAssumedfromclear = 1082,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEODECODERHEAP"]/*'/>

    CreateVideodecoderheap = 1083,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEODECODERHEAP"]/*'/>

    LiveVideodecoderheap = 1084,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEODECODERHEAP"]/*'/>

    DestroyVideodecoderheap = 1085,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDARG_RETURN"]/*'/>

    OpenexistingheapInvalidargReturn = 1086,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OPENEXISTINGHEAP_OUTOFMEMORY_RETURN"]/*'/>

    OpenexistingheapOutofmemoryReturn = 1087,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDADDRESS"]/*'/>

    OpenexistingheapInvalidaddress = 1088,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDHANDLE"]/*'/>

    OpenexistingheapInvalidhandle = 1089,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_DEST"]/*'/>

    WritebufferimmediateInvalidDest = 1090,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_MODE"]/*'/>

    WritebufferimmediateInvalidMode = 1091,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_ALIGNMENT"]/*'/>

    WritebufferimmediateInvalidAlignment = 1092,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_NOT_SUPPORTED"]/*'/>

    WritebufferimmediateNotSupported = 1093,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETVIEWINSTANCEMASK_INVALIDARGS"]/*'/>

    SetviewinstancemaskInvalidargs = 1094,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIEW_INSTANCING_UNSUPPORTED"]/*'/>

    ViewInstancingUnsupported = 1095,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIEW_INSTANCING_INVALIDARGS"]/*'/>

    ViewInstancingInvalidargs = 1096,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_DECODE_REFERENCE_ONLY_FLAG"]/*'/>

    CopytextureregionMismatchDecodeReferenceOnlyFlag = 1097,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_DECODE_REFERENCE_ONLY_FLAG"]/*'/>

    CopyresourceMismatchDecodeReferenceOnlyFlag = 1098,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_FAILURE"]/*'/>

    CreateVideoDecodeHeapCapsFailure = 1099,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_UNSUPPORTED"]/*'/>

    CreateVideoDecodeHeapCapsUnsupported = 1100,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_INVALID_INPUT"]/*'/>

    VideoDecodeSupportInvalidInput = 1101,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_DECODER_UNSUPPORTED"]/*'/>

    CreateVideoDecoderUnsupported = 1102,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_METADATA_ERROR"]/*'/>

    CreategraphicspipelinestateMetadataError = 1103,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VIEW_INSTANCING_VERTEX_SIZE_EXCEEDED"]/*'/>

    CreategraphicspipelinestateViewInstancingVertexSizeExceeded = 1104,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RUNTIME_INTERNAL_ERROR"]/*'/>

    CreategraphicspipelinestateRuntimeInternalError = 1105,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NO_VIDEO_API_SUPPORT"]/*'/>

    NoVideoApiSupport = 1106,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_INVALID_INPUT"]/*'/>

    VideoProcessSupportInvalidInput = 1107,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_PROCESSOR_CAPS_FAILURE"]/*'/>

    CreateVideoProcessorCapsFailure = 1108,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_UNSUPPORTED_FORMAT"]/*'/>

    VideoProcessSupportUnsupportedFormat = 1109,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_DECODE_FRAME_INVALID_ARGUMENT"]/*'/>

    VideoDecodeFrameInvalidArgument = 1110,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ENQUEUE_MAKE_RESIDENT_INVALID_FLAGS"]/*'/>

    EnqueueMakeResidentInvalidFlags = 1111,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OPENEXISTINGHEAP_UNSUPPORTED"]/*'/>

    OpenexistingheapUnsupported = 1112,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_PROCESS_FRAMES_INVALID_ARGUMENT"]/*'/>

    VideoProcessFramesInvalidArgument = 1113,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_UNSUPPORTED"]/*'/>

    VideoDecodeSupportUnsupported = 1114,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDRECORDER"]/*'/>

    CreateCommandrecorder = 1115,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDRECORDER"]/*'/>

    LiveCommandrecorder = 1116,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDRECORDER"]/*'/>

    DestroyCommandrecorder = 1117,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_VIDEO_NOT_SUPPORTED"]/*'/>

    CreateCommandRecorderVideoNotSupported = 1118,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_SUPPORT_FLAGS"]/*'/>

    CreateCommandRecorderInvalidSupportFlags = 1119,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_FLAGS"]/*'/>

    CreateCommandRecorderInvalidFlags = 1120,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_MORE_RECORDERS_THAN_LOGICAL_PROCESSORS"]/*'/>

    CreateCommandRecorderMoreRecordersThanLogicalProcessors = 1121,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMANDPOOL"]/*'/>

    CreateCommandpool = 1122,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_COMMANDPOOL"]/*'/>

    LiveCommandpool = 1123,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_COMMANDPOOL"]/*'/>

    DestroyCommandpool = 1124,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_POOL_INVALID_FLAGS"]/*'/>

    CreateCommandPoolInvalidFlags = 1125,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_VIDEO_NOT_SUPPORTED"]/*'/>

    CreateCommandListVideoNotSupported = 1126,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_RECORDER_SUPPORT_FLAGS_MISMATCH"]/*'/>

    CommandRecorderSupportFlagsMismatch = 1127,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_RECORDER_CONTENTION"]/*'/>

    CommandRecorderContention = 1128,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_RECORDER_USAGE_WITH_CREATECOMMANDLIST_COMMAND_LIST"]/*'/>

    CommandRecorderUsageWithCreatecommandlistCommandList = 1129,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_USAGE_WITH_CREATECOMMANDLIST1_COMMAND_LIST"]/*'/>

    CommandAllocatorUsageWithCreatecommandlist1CommandList = 1130,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_EXECUTE_EMPTY_COMMAND_LIST"]/*'/>

    CannotExecuteEmptyCommandList = 1131,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_RESET_COMMAND_POOL_WITH_OPEN_COMMAND_LISTS"]/*'/>

    CannotResetCommandPoolWithOpenCommandLists = 1132,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_USE_COMMAND_RECORDER_WITHOUT_CURRENT_TARGET"]/*'/>

    CannotUseCommandRecorderWithoutCurrentTarget = 1133,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_CHANGE_COMMAND_RECORDER_TARGET_WHILE_RECORDING"]/*'/>

    CannotChangeCommandRecorderTargetWhileRecording = 1134,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_POOL_SYNC"]/*'/>

    CommandPoolSync = 1135,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EVICT_UNDERFLOW"]/*'/>

    EvictUnderflow = 1136,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_META_COMMAND"]/*'/>

    CreateMetaCommand = 1137,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_META_COMMAND"]/*'/>

    LiveMetaCommand = 1138,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_META_COMMAND"]/*'/>

    DestroyMetaCommand = 1139,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_DST_RESOURCE"]/*'/>

    CopybufferregionInvalidDstResource = 1140,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_SRC_RESOURCE"]/*'/>

    CopybufferregionInvalidSrcResource = 1141,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE"]/*'/>

    AtomiccopybufferInvalidDstResource = 1142,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE"]/*'/>

    AtomiccopybufferInvalidSrcResource = 1143,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_BUFFER"]/*'/>

    CreateplacedresourceonbufferNullBuffer = 1144,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_RESOURCE_DESC"]/*'/>

    CreateplacedresourceonbufferNullResourceDesc = 1145,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_UNSUPPORTED"]/*'/>

    CreateplacedresourceonbufferUnsupported = 1146,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_DIMENSION"]/*'/>

    CreateplacedresourceonbufferInvalidBufferDimension = 1147,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_FLAGS"]/*'/>

    CreateplacedresourceonbufferInvalidBufferFlags = 1148,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_OFFSET"]/*'/>

    CreateplacedresourceonbufferInvalidBufferOffset = 1149,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_DIMENSION"]/*'/>

    CreateplacedresourceonbufferInvalidResourceDimension = 1150,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_FLAGS"]/*'/>

    CreateplacedresourceonbufferInvalidResourceFlags = 1151,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_OUTOFMEMORY_RETURN"]/*'/>

    CreateplacedresourceonbufferOutofmemoryReturn = 1152,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_CREATE_GRAPHICS_AND_VIDEO_COMMAND_RECORDER"]/*'/>

    CannotCreateGraphicsAndVideoCommandRecorder = 1153,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_POSSIBLY_MISMATCHING_PROPERTIES"]/*'/>

    UpdatetilemappingsPossiblyMismatchingProperties = 1154,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE"]/*'/>

    CreateCommandListInvalidCommandListType = 1155,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INCOMPATIBLE_WITH_STRUCTURED_BUFFERS"]/*'/>

    ClearunorderedaccessviewIncompatibleWithStructuredBuffers = 1156,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMPUTE_ONLY_DEVICE_OPERATION_UNSUPPORTED"]/*'/>

    ComputeOnlyDeviceOperationUnsupported = 1157,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INVALID"]/*'/>

    BuildRaytracingAccelerationStructureInvalid = 1158,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_INVALID"]/*'/>

    EmitRaytracingAccelerationStructurePostbuildInfoInvalid = 1159,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPY_RAYTRACING_ACCELERATION_STRUCTURE_INVALID"]/*'/>

    CopyRaytracingAccelerationStructureInvalid = 1160,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DISPATCH_RAYS_INVALID"]/*'/>

    DispatchRaysInvalid = 1161,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO_INVALID"]/*'/>

    GetRaytracingAccelerationStructurePrebuildInfoInvalid = 1162,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_LIFETIMETRACKER"]/*'/>

    CreateLifetimetracker = 1163,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_LIFETIMETRACKER"]/*'/>

    LiveLifetimetracker = 1164,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_LIFETIMETRACKER"]/*'/>

    DestroyLifetimetracker = 1165,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROYOWNEDOBJECT_OBJECTNOTOWNED"]/*'/>

    DestroyownedobjectObjectnotowned = 1166,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_TRACKEDWORKLOAD"]/*'/>

    CreateTrackedworkload = 1167,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_TRACKEDWORKLOAD"]/*'/>

    LiveTrackedworkload = 1168,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD"]/*'/>

    DestroyTrackedworkload = 1169,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_ERROR"]/*'/>

    RenderPassError = 1170,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_META_COMMAND_ID_INVALID"]/*'/>

    MetaCommandIdInvalid = 1171,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_META_COMMAND_UNSUPPORTED_PARAMS"]/*'/>

    MetaCommandUnsupportedParams = 1172,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_META_COMMAND_FAILED_ENUMERATION"]/*'/>

    MetaCommandFailedEnumeration = 1173,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_META_COMMAND_PARAMETER_SIZE_MISMATCH"]/*'/>

    MetaCommandParameterSizeMismatch = 1174,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNINITIALIZED_META_COMMAND"]/*'/>

    UninitializedMetaCommand = 1175,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_META_COMMAND_INVALID_GPU_VIRTUAL_ADDRESS"]/*'/>

    MetaCommandInvalidGpuVirtualAddress = 1176,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDLIST"]/*'/>

    CreateVideoencodecommandlist = 1177,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDLIST"]/*'/>

    LiveVideoencodecommandlist = 1178,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDLIST"]/*'/>

    DestroyVideoencodecommandlist = 1179,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDQUEUE"]/*'/>

    CreateVideoencodecommandqueue = 1180,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDQUEUE"]/*'/>

    LiveVideoencodecommandqueue = 1181,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDQUEUE"]/*'/>

    DestroyVideoencodecommandqueue = 1182,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONESTIMATOR"]/*'/>

    CreateVideomotionestimator = 1183,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONESTIMATOR"]/*'/>

    LiveVideomotionestimator = 1184,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONESTIMATOR"]/*'/>

    DestroyVideomotionestimator = 1185,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONVECTORHEAP"]/*'/>

    CreateVideomotionvectorheap = 1186,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONVECTORHEAP"]/*'/>

    LiveVideomotionvectorheap = 1187,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONVECTORHEAP"]/*'/>

    DestroyVideomotionvectorheap = 1188,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS"]/*'/>

    MultipleTrackedWorkloads = 1189,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS"]/*'/>

    MultipleTrackedWorkloadPairs = 1190,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR"]/*'/>

    OutOfOrderTrackedWorkloadPair = 1191,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD"]/*'/>

    CannotAddTrackedWorkload = 1192,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR"]/*'/>

    IncompleteTrackedWorkloadPair = 1193,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_ERROR"]/*'/>

    CreateStateObjectError = 1194,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_ERROR"]/*'/>

    GetShaderIdentifierError = 1195,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_SHADER_STACK_SIZE_ERROR"]/*'/>

    GetShaderStackSizeError = 1196,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_PIPELINE_STACK_SIZE_ERROR"]/*'/>

    GetPipelineStackSizeError = 1197,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_PIPELINE_STACK_SIZE_ERROR"]/*'/>

    SetPipelineStackSizeError = 1198,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_SIZE_INVALID"]/*'/>

    GetShaderIdentifierSizeInvalid = 1199,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_INVALID"]/*'/>

    CheckDriverMatchingIdentifierInvalid = 1200,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_DRIVER_REPORTED_ISSUE"]/*'/>

    CheckDriverMatchingIdentifierDriverReportedIssue = 1201,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_INVALID_RESOURCE_BARRIER"]/*'/>

    RenderPassInvalidResourceBarrier = 1202,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_DISALLOWED_API_CALLED"]/*'/>

    RenderPassDisallowedApiCalled = 1203,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_NEST_RENDER_PASSES"]/*'/>

    RenderPassCannotNestRenderPasses = 1204,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_END_WITHOUT_BEGIN"]/*'/>

    RenderPassCannotEndWithoutBegin = 1205,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_CLOSE_COMMAND_LIST"]/*'/>

    RenderPassCannotCloseCommandList = 1206,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_GPU_WORK_WHILE_SUSPENDED"]/*'/>

    RenderPassGpuWorkWhileSuspended = 1207,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_SUSPEND_RESUME"]/*'/>

    RenderPassMismatchingSuspendResume = 1208,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_NO_PRIOR_SUSPEND_WITHIN_EXECUTECOMMANDLISTS"]/*'/>

    RenderPassNoPriorSuspendWithinExecutecommandlists = 1209,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_NO_SUBSEQUENT_RESUME_WITHIN_EXECUTECOMMANDLISTS"]/*'/>

    RenderPassNoSubsequentResumeWithinExecutecommandlists = 1210,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_TRACKED_WORKLOAD_COMMAND_QUEUE_MISMATCH"]/*'/>

    TrackedWorkloadCommandQueueMismatch = 1211,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED"]/*'/>

    TrackedWorkloadNotSupported = 1212,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_NO_ACCESS"]/*'/>

    RenderPassMismatchingNoAccess = 1213,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_UNSUPPORTED_RESOLVE"]/*'/>

    RenderPassUnsupportedResolve = 1214,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INVALID_RESOURCE_PTR"]/*'/>

    ClearunorderedaccessviewInvalidResourcePtr = 1215,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_SIGNAL"]/*'/>

    Windows7FenceOutoforderSignal = 1216,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_WAIT"]/*'/>

    Windows7FenceOutoforderWait = 1217,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_ESTIMATOR_INVALID_ARGUMENT"]/*'/>

    VideoCreateMotionEstimatorInvalidArgument = 1218,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT"]/*'/>

    VideoCreateMotionVectorHeapInvalidArgument = 1219,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ESTIMATE_MOTION_INVALID_ARGUMENT"]/*'/>

    EstimateMotionInvalidArgument = 1220,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT"]/*'/>

    ResolveMotionVectorHeapInvalidArgument = 1221,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_HEAP_TYPE"]/*'/>

    GetgpuvirtualaddressInvalidHeapType = 1222,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_BACKGROUND_PROCESSING_MODE_INVALID_ARGUMENT"]/*'/>

    SetBackgroundProcessingModeInvalidArgument = 1223,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE_FOR_FEATURE_LEVEL"]/*'/>

    CreateCommandListInvalidCommandListTypeForFeatureLevel = 1224,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOEXTENSIONCOMMAND"]/*'/>

    CreateVideoextensioncommand = 1225,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOEXTENSIONCOMMAND"]/*'/>

    LiveVideoextensioncommand = 1226,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOEXTENSIONCOMMAND"]/*'/>

    DestroyVideoextensioncommand = 1227,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_VIDEO_EXTENSION_COMMAND_ID"]/*'/>

    InvalidVideoExtensionCommandId = 1228,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VIDEO_EXTENSION_COMMAND_INVALID_ARGUMENT"]/*'/>

    VideoExtensionCommandInvalidArgument = 1229,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_UNIQUE_IN_DXIL_LIBRARY"]/*'/>

    CreateRootSignatureNotUniqueInDxilLibrary = 1230,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VARIABLE_SHADING_RATE_NOT_ALLOWED_WITH_TIR"]/*'/>

    VariableShadingRateNotAllowedWithTir = 1231,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GEOMETRY_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE"]/*'/>

    GeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1232,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_SHADING_RATE"]/*'/>

    RssetshadingRateInvalidShadingRate = 1233,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RSSETSHADING_RATE_SHADING_RATE_NOT_PERMITTED_BY_CAP"]/*'/>

    RssetshadingRateShadingRateNotPermittedByCap = 1234,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_COMBINER"]/*'/>

    RssetshadingRateInvalidCombiner = 1235,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RSSETSHADINGRATEIMAGE_REQUIRES_TIER_2"]/*'/>

    RssetshadingrateimageRequiresTier2 = 1236,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RSSETSHADINGRATE_REQUIRES_TIER_1"]/*'/>

    RssetshadingrateRequiresTier1 = 1237,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_FORMAT"]/*'/>

    ShadingRateImageIncorrectFormat = 1238,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_ARRAY_SIZE"]/*'/>

    ShadingRateImageIncorrectArraySize = 1239,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_MIP_LEVEL"]/*'/>

    ShadingRateImageIncorrectMipLevel = 1240,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_COUNT"]/*'/>

    ShadingRateImageIncorrectSampleCount = 1241,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_QUALITY"]/*'/>

    ShadingRateImageIncorrectSampleQuality = 1242,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NON_RETAIL_SHADER_MODEL_WONT_VALIDATE"]/*'/>

    NonRetailShaderModelWontValidate = 1243,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateAsRootSignatureMismatch = 1244,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_ROOT_SIGNATURE_MISMATCH"]/*'/>

    CreategraphicspipelinestateMsRootSignatureMismatch = 1245,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ADD_TO_STATE_OBJECT_ERROR"]/*'/>

    AddToStateObjectError = 1246,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION_INVALID_ARGUMENT"]/*'/>

    CreateProtectedResourceSessionInvalidArgument = 1247,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_PSO_DESC_MISMATCH"]/*'/>

    CreategraphicspipelinestateMsPsoDescMismatch = 1248,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEPIPELINESTATE_MS_INCOMPLETE_TYPE"]/*'/>

    CreatepipelinestateMsIncompleteType = 1249,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_NOT_MS_MISMATCH"]/*'/>

    CreategraphicspipelinestateAsNotMsMismatch = 1250,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_NOT_PS_MISMATCH"]/*'/>

    CreategraphicspipelinestateMsNotPsMismatch = 1251,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NONZERO_SAMPLER_FEEDBACK_MIP_REGION_WITH_INCOMPATIBLE_FORMAT"]/*'/>

    NonzeroSamplerFeedbackMipRegionWithIncompatibleFormat = 1252,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_SHADER_MISMATCH"]/*'/>

    CreategraphicspipelinestateInputlayoutShaderMismatch = 1253,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EMPTY_DISPATCH"]/*'/>

    EmptyDispatch = 1254,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOURCE_FORMAT_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY"]/*'/>

    ResourceFormatRequiresSamplerFeedbackCapability = 1255,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_MIP_REGION"]/*'/>

    SamplerFeedbackMapInvalidMipRegion = 1256,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_DIMENSION"]/*'/>

    SamplerFeedbackMapInvalidDimension = 1257,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_COUNT"]/*'/>

    SamplerFeedbackMapInvalidSampleCount = 1258,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_QUALITY"]/*'/>

    SamplerFeedbackMapInvalidSampleQuality = 1259,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_LAYOUT"]/*'/>

    SamplerFeedbackMapInvalidLayout = 1260,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_REQUIRES_UNORDERED_ACCESS_FLAG"]/*'/>

    SamplerFeedbackMapRequiresUnorderedAccessFlag = 1261,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_NULL_ARGUMENTS"]/*'/>

    SamplerFeedbackCreateUavNullArguments = 1262,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_UAV_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY"]/*'/>

    SamplerFeedbackUavRequiresSamplerFeedbackCapability = 1263,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_REQUIRES_FEEDBACK_MAP_FORMAT"]/*'/>

    SamplerFeedbackCreateUavRequiresFeedbackMapFormat = 1264,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreatemeshshaderInvalidshaderbytecode = 1265,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTOFMEMORY"]/*'/>

    CreatemeshshaderOutofmemory = 1266,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE"]/*'/>

    CreatemeshshaderwithstreamoutputInvalidshadertype = 1267,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_INVALID_FORMAT"]/*'/>

    ResolvesubresourceSamplerFeedbackTranscodeInvalidFormat = 1268,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_INVALID_MIP_LEVEL_COUNT"]/*'/>

    ResolvesubresourceSamplerFeedbackInvalidMipLevelCount = 1269,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_ARRAY_SIZE_MISMATCH"]/*'/>

    ResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch = 1270,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_MISMATCHING_TARGETED_RESOURCE"]/*'/>

    SamplerFeedbackCreateUavMismatchingTargetedResource = 1271,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTPUTEXCEEDSMAXSIZE"]/*'/>

    CreatemeshshaderOutputexceedsmaxsize = 1272,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_GROUPSHAREDEXCEEDSMAXSIZE"]/*'/>

    CreatemeshshaderGroupsharedexceedsmaxsize = 1273,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VERTEX_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE"]/*'/>

    VertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1274,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MESH_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE"]/*'/>

    MeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1275,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_MISMATCHEDASMSPAYLOADSIZE"]/*'/>

    CreatemeshshaderMismatchedasmspayloadsize = 1276,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_UNBOUNDED_STATIC_DESCRIPTORS"]/*'/>

    CreateRootSignatureUnboundedStaticDescriptors = 1277,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_INVALIDSHADERBYTECODE"]/*'/>

    CreateamplificationshaderInvalidshaderbytecode = 1278,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_OUTOFMEMORY"]/*'/>

    CreateamplificationshaderOutofmemory = 1279,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_SHADERCACHESESSION"]/*'/>

    CreateShadercachesession = 1280,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_SHADERCACHESESSION"]/*'/>

    LiveShadercachesession = 1281,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_SHADERCACHESESSION"]/*'/>

    DestroyShadercachesession = 1282,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_INVALIDARGS"]/*'/>

    CreateshadercachesessionInvalidargs = 1283,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_DISABLED"]/*'/>

    CreateshadercachesessionDisabled = 1284,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_ALREADYOPEN"]/*'/>

    CreateshadercachesessionAlreadyopen = 1285,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHECONTROL_DEVELOPERMODE"]/*'/>

    ShadercachecontrolDevelopermode = 1286,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHECONTROL_INVALIDFLAGS"]/*'/>

    ShadercachecontrolInvalidflags = 1287,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHECONTROL_STATEALREADYSET"]/*'/>

    ShadercachecontrolStatealreadyset = 1288,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHECONTROL_IGNOREDFLAG"]/*'/>

    ShadercachecontrolIgnoredflag = 1289,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_ALREADYPRESENT"]/*'/>

    ShadercachesessionStorevalueAlreadypresent = 1290,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_HASHCOLLISION"]/*'/>

    ShadercachesessionStorevalueHashcollision = 1291,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_CACHEFULL"]/*'/>

    ShadercachesessionStorevalueCachefull = 1292,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_FINDVALUE_NOTFOUND"]/*'/>

    ShadercachesessionFindvalueNotfound = 1293,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_CORRUPT"]/*'/>

    ShadercachesessionCorrupt = 1294,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_DISABLED"]/*'/>

    ShadercachesessionDisabled = 1295,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OVERSIZED_DISPATCH"]/*'/>

    OversizedDispatch = 1296,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOENCODER"]/*'/>

    CreateVideoencoder = 1297,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOENCODER"]/*'/>

    LiveVideoencoder = 1298,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOENCODER"]/*'/>

    DestroyVideoencoder = 1299,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEOENCODERHEAP"]/*'/>

    CreateVideoencoderheap = 1300,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LIVE_VIDEOENCODERHEAP"]/*'/>

    LiveVideoencoderheap = 1301,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESTROY_VIDEOENCODERHEAP"]/*'/>

    DestroyVideoencoderheap = 1302,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG"]/*'/>

    CopytextureregionMismatchEncodeReferenceOnlyFlag = 1303,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG"]/*'/>

    CopyresourceMismatchEncodeReferenceOnlyFlag = 1304,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ENCODE_FRAME_INVALID_PARAMETERS"]/*'/>

    EncodeFrameInvalidParameters = 1305,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ENCODE_FRAME_UNSUPPORTED_PARAMETERS"]/*'/>

    EncodeFrameUnsupportedParameters = 1306,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_INVALID_PARAMETERS"]/*'/>

    ResolveEncoderOutputMetadataInvalidParameters = 1307,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_UNSUPPORTED_PARAMETERS"]/*'/>

    ResolveEncoderOutputMetadataUnsupportedParameters = 1308,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_INVALID_PARAMETERS"]/*'/>

    CreateVideoEncoderInvalidParameters = 1309,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_UNSUPPORTED_PARAMETERS"]/*'/>

    CreateVideoEncoderUnsupportedParameters = 1310,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_INVALID_PARAMETERS"]/*'/>

    CreateVideoEncoderHeapInvalidParameters = 1311,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_UNSUPPORTED_PARAMETERS"]/*'/>

    CreateVideoEncoderHeapUnsupportedParameters = 1312,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATECOMMANDLIST_NULL_COMMANDALLOCATOR"]/*'/>

    CreatecommandlistNullCommandallocator = 1313,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEAR_UNORDERED_ACCESS_VIEW_INVALID_DESCRIPTOR_HANDLE"]/*'/>

    ClearUnorderedAccessViewInvalidDescriptorHandle = 1314,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SHADER_VISIBLE"]/*'/>

    DescriptorHeapNotShaderVisible = 1315,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOP_WARNING"]/*'/>

    CreateblendstateBlendopWarning = 1316,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOPALPHA_WARNING"]/*'/>

    CreateblendstateBlendopalphaWarning = 1317,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_WRITE_COMBINE_PERFORMANCE_WARNING"]/*'/>

    WriteCombinePerformanceWarning = 1318,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_QUERY_INVALID_QUERY_STATE"]/*'/>

    ResolveQueryInvalidQueryState = 1319,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETPRIVATEDATA_NO_ACCESS"]/*'/>

    SetprivatedataNoAccess = 1320,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_SAMPLER_MODE_MISMATCH"]/*'/>

    CommandListStaticDescriptorSamplerModeMismatch = 1321,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_UNSUPPORTED_BUFFER_WIDTH"]/*'/>

    GetcopyablefootprintsUnsupportedBufferWidth = 1322,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEMESHSHADER_TOPOLOGY_MISMATCH"]/*'/>

    CreatemeshshaderTopologyMismatch = 1323,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_VRS_SUM_COMBINER_REQUIRES_CAPABILITY"]/*'/>

    VrsSumCombinerRequiresCapability = 1324,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SETTING_SHADING_RATE_FROM_MS_REQUIRES_CAPABILITY"]/*'/>

    SettingShadingRateFromMsRequiresCapability = 1325,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHESESSION_SHADERCACHEDELETE_NOTSUPPORTED"]/*'/>

    ShadercachesessionShadercachedeleteNotsupported = 1326,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADERCACHECONTROL_SHADERCACHECLEAR_NOTSUPPORTED"]/*'/>

    ShadercachecontrolShadercacheclearNotsupported = 1327,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_STATE_IGNORED"]/*'/>

    CreateresourceStateIgnored = 1328,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNUSED_CROSS_EXECUTE_SPLIT_BARRIER"]/*'/>

    UnusedCrossExecuteSplitBarrier = 1329,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DEVICE_OPEN_SHARED_HANDLE_ACCESS_DENIED"]/*'/>

    DeviceOpenSharedHandleAccessDenied = 1330,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_VALUES"]/*'/>

    IncompatibleBarrierValues = 1331,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_ACCESS"]/*'/>

    IncompatibleBarrierAccess = 1332,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_SYNC"]/*'/>

    IncompatibleBarrierSync = 1333,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_LAYOUT"]/*'/>

    IncompatibleBarrierLayout = 1334,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_TYPE"]/*'/>

    IncompatibleBarrierType = 1335,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_OUT_OF_BOUNDS_BARRIER_SUBRESOURCE_RANGE"]/*'/>

    OutOfBoundsBarrierSubresourceRange = 1336,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_RESOURCE_DIMENSION"]/*'/>

    IncompatibleBarrierResourceDimension = 1337,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SET_SCISSOR_RECTS_INVALID_RECT"]/*'/>

    SetScissorRectsInvalidRect = 1338,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_SHADING_RATE_SOURCE_REQUIRES_DIMENSION_TEXTURE2D"]/*'/>

    ShadingRateSourceRequiresDimensionTexture2D = 1339,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BUFFER_BARRIER_SUBREGION_OUT_OF_BOUNDS"]/*'/>

    BufferBarrierSubregionOutOfBounds = 1340,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNSUPPORTED_BARRIER_LAYOUT"]/*'/>

    UnsupportedBarrierLayout = 1341,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALID_PARAMETERS"]/*'/>

    CreateresourceandheapInvalidParameters = 1342,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ENHANCED_BARRIERS_NOT_SUPPORTED"]/*'/>

    EnhancedBarriersNotSupported = 1343,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_LEGACY_BARRIER_VALIDATION_FORCED_ON"]/*'/>

    LegacyBarrierValidationForcedOn = 1346,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EMPTY_ROOT_DESCRIPTOR_TABLE"]/*'/>

    EmptyRootDescriptorTable = 1347,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ELEMENT_OFFSET_UNALIGNED"]/*'/>

    CommandListDrawElementOffsetUnaligned = 1348,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_ALPHA_BLEND_FACTOR_NOT_SUPPORTED"]/*'/>

    AlphaBlendFactorNotSupported = 1349,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_LAYOUT"]/*'/>

    BarrierInteropInvalidLayout = 1350,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_STATE"]/*'/>

    BarrierInteropInvalidState = 1351,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GRAPHICS_PIPELINE_STATE_DESC_ZERO_SAMPLE_MASK"]/*'/>

    GraphicsPipelineStateDescZeroSampleMask = 1352,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INDEPENDENT_STENCIL_REF_NOT_SUPPORTED"]/*'/>

    IndependentStencilRefNotSupported = 1353,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INDEPENDENT_MASKS_UNSUPPORTED"]/*'/>

    CreatedepthstencilstateIndependentMasksUnsupported = 1354,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_TEXTURE_BARRIER_SUBRESOURCES_OUT_OF_BOUNDS"]/*'/>

    TextureBarrierSubresourcesOutOfBounds = 1355,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NON_OPTIMAL_BARRIER_ONLY_EXECUTE_COMMAND_LISTS"]/*'/>

    NonOptimalBarrierOnlyExecuteCommandLists = 1356,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_EXECUTE_INDIRECT_ZERO_COMMAND_COUNT"]/*'/>

    ExecuteIndirectZeroCommandCount = 1357,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_TEXTURE_LAYOUT"]/*'/>

    GpuBasedValidationIncompatibleTextureLayout = 1358,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NOT_SUPPORTED"]/*'/>

    DynamicIndexBufferStripCutNotSupported = 1359,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_TRIANGLE_FANS_NOT_SUPPORTED"]/*'/>

    PrimitiveTopologyTriangleFansNotSupported = 1360,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_SAMPLER_COMPARISON_FUNC_IGNORED"]/*'/>

    CreateSamplerComparisonFuncIgnored = 1361,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEHEAP_INVALIDHEAPTYPE"]/*'/>

    CreateheapInvalidheaptype = 1362,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPTYPE"]/*'/>

    CreateresourceandheapInvalidheaptype = 1363,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NOT_SUPPORTED"]/*'/>

    DynamicDepthBiasNotSupported = 1364,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_NON_WHOLE_DYNAMIC_DEPTH_BIAS"]/*'/>

    CreaterasterizerstateNonWholeDynamicDepthBias = 1365,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_FLAG_MISSING"]/*'/>

    DynamicDepthBiasFlagMissing = 1366,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NO_PIPELINE"]/*'/>

    DynamicDepthBiasNoPipeline = 1367,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_FLAG_MISSING"]/*'/>

    DynamicIndexBufferStripCutFlagMissing = 1368,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NO_PIPELINE"]/*'/>

    DynamicIndexBufferStripCutNoPipeline = 1369,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_NONNORMALIZED_COORDINATE_SAMPLING_NOT_SUPPORTED"]/*'/>

    NonnormalizedCoordinateSamplingNotSupported = 1370,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_CAST_TARGET"]/*'/>

    InvalidCastTarget = 1371,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_END_STATE"]/*'/>

    RenderPassCommandlistInvalidEndState = 1372,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_START_STATE"]/*'/>

    RenderPassCommandlistInvalidStartState = 1373,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_ACCESS"]/*'/>

    RenderPassMismatchingAccess = 1374,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_LOCAL_PRESERVE_PARAMETERS"]/*'/>

    RenderPassMismatchingLocalPreserveParameters = 1375,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_PRESERVE_RENDER_PARAMETERS_ERROR"]/*'/>

    RenderPassLocalPreserveRenderParametersError = 1376,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_DEPTH_STENCIL_ERROR"]/*'/>

    RenderPassLocalDepthStencilError = 1377,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DRAW_POTENTIALLY_OUTSIDE_OF_VALID_RENDER_AREA"]/*'/>

    DrawPotentiallyOutsideOfValidRenderArea = 1378,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_LINERASTERIZATIONMODE"]/*'/>

    CreaterasterizerstateInvalidLinerasterizationmode = 1379,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT_SMALLRESOURCE"]/*'/>

    CreateresourceInvalidalignmentSmallresource = 1380,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GENERIC_DEVICE_OPERATION_UNSUPPORTED"]/*'/>

    GenericDeviceOperationUnsupported = 1381,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDER_TARGET_WRONG_WRITE_MASK"]/*'/>

    CreategraphicspipelinestateRenderTargetWrongWriteMask = 1382,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PROBABLE_PIX_EVENT_LEAK"]/*'/>

    ProbablePixEventLeak = 1383,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_PIX_EVENT_UNDERFLOW"]/*'/>

    PixEventUnderflow = 1384,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RECREATEAT_INVALID_TARGET"]/*'/>

    RecreateatInvalidTarget = 1385,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RECREATEAT_INSUFFICIENT_SUPPORT"]/*'/>

    RecreateatInsufficientSupport = 1386,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_STRUCTURED_BUFFER_STRIDE_MISMATCH"]/*'/>

    GpuBasedValidationStructuredBufferStrideMismatch = 1387,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DISPATCH_GRAPH_INVALID"]/*'/>

    DispatchGraphInvalid = 1388,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_TARGET_FORMAT_INVALID"]/*'/>

    DirectsrSuperresTargetFormatInvalid = 1389,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_TARGET_DIMENSION_INVALID"]/*'/>

    DirectsrSuperresTargetDimensionInvalid = 1390,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_SOURCE_COLOR_FORMAT_INVALID"]/*'/>

    DirectsrSuperresSourceColorFormatInvalid = 1391,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_SOURCE_DEPTH_FORMAT_INVALID"]/*'/>

    DirectsrSuperresSourceDepthFormatInvalid = 1392,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_EXPOSURE_SCALE_FORMAT_INVALID"]/*'/>

    DirectsrSuperresExposureScaleFormatInvalid = 1393,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_ENGINE_CREATE_FLAGS_INVALID"]/*'/>

    DirectsrSuperresEngineCreateFlagsInvalid = 1394,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_EXTENSION_INTERNAL_LOAD_FAILURE"]/*'/>

    DirectsrSuperresExtensionInternalLoadFailure = 1395,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_EXTENSION_INTERNAL_ENGINE_CREATION_ERROR"]/*'/>

    DirectsrSuperresExtensionInternalEngineCreationError = 1396,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_EXTENSION_INTERNAL_UPSCALER_CREATION_ERROR"]/*'/>

    DirectsrSuperresExtensionInternalUpscalerCreationError = 1397,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_EXTENSION_INTERNAL_UPSCALER_EXECUTION_ERROR"]/*'/>

    DirectsrSuperresExtensionInternalUpscalerExecutionError = 1398,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_REGION_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteRegionInvalid = 1399,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_TIME_DELTA_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteTimeDeltaInvalid = 1400,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_REQUIRED_TEXTURE_IS_NULL"]/*'/>

    DirectsrSuperresUpscalerExecuteRequiredTextureIsNull = 1401,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_MOTION_VECTORS_FORMAT_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteMotionVectorsFormatInvalid = 1402,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_FLAGS_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteFlagsInvalid = 1403,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_FORMAT_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteFormatInvalid = 1404,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_EXPOSURE_SCALE_TEXTURE_SIZE_INVALID"]/*'/>

    DirectsrSuperresUpscalerExecuteExposureScaleTextureSizeInvalid = 1405,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_VARIANT_INDEX_OUT_OF_BOUNDS"]/*'/>

    DirectsrSuperresVariantIndexOutOfBounds = 1406,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_VARIANT_ID_NOT_FOUND"]/*'/>

    DirectsrSuperresVariantIdNotFound = 1407,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_DUPLICATE_VARIANT_ID"]/*'/>

    DirectsrSuperresDuplicateVariantId = 1408,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_OUT_OF_MEMORY"]/*'/>

    DirectsrOutOfMemory = 1409,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_UNEXPECTED_TEXTURE_IS_IGNORED"]/*'/>

    DirectsrSuperresUpscalerExecuteUnexpectedTextureIsIgnored = 1410,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EVICT_UNDERFLOW"]/*'/>

    DirectsrSuperresUpscalerEvictUnderflow = 1411,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_OPTIONAL_TEXTURE_IS_NULL"]/*'/>

    DirectsrSuperresUpscalerExecuteOptionalTextureIsNull = 1412,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIRECTSR_SUPERRES_UPSCALER_EXECUTE_INVALID_CAMERA_JITTER"]/*'/>

    DirectsrSuperresUpscalerExecuteInvalidCameraJitter = 1413,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_WARNING"]/*'/>

    CreateStateObjectWarning = 1414,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_GUID_TEXTURE_LAYOUT_UNSUPPORTED"]/*'/>

    GuidTextureLayoutUnsupported = 1415,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_RESOLVE_ENCODER_INPUT_PARAM_LAYOUT_INVALID_PARAMETERS"]/*'/>

    ResolveEncoderInputParamLayoutInvalidParameters = 1416,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_INVALID_BARRIER_ACCESS"]/*'/>

    InvalidBarrierAccess = 1417,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INSTANCE_COUNT_ZERO"]/*'/>

    CommandListDrawInstanceCountZero = 1418,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SET_BEFORE_ROOT_SIGNATURE_WITH_DIRECTLY_INDEXED_FLAG"]/*'/>

    DescriptorHeapNotSetBeforeRootSignatureWithDirectlyIndexedFlag = 1419,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_DIFFERENT_DESCRIPTOR_HEAP_SET_AFTER_ROOT_SIGNATURE_WITH_DIRECTLY_INDEXED_FLAG"]/*'/>

    DifferentDescriptorHeapSetAfterRootSignatureWithDirectlyIndexedFlag = 1420,

    /// <include file='D3D12_MESSAGE_ID.xml' path='doc/member[@name="D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_D3D12_MESSAGES_END"]/*'/>

    D3D12MessagesEnd = (DifferentDescriptorHeapSetAfterRootSignatureWithDirectlyIndexedFlag + 1),
}

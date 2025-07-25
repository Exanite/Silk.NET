// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP"]/*'/>
public enum D3D12AutoBreadcrumbOp
{
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETMARKER"]/*'/>

    Setmarker = 0,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT"]/*'/>

    Beginevent = 1,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENDEVENT"]/*'/>

    Endevent = 2,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED"]/*'/>

    Drawinstanced = 3,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED"]/*'/>

    Drawindexedinstanced = 4,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT"]/*'/>

    Executeindirect = 5,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCH"]/*'/>

    Dispatch = 6,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION"]/*'/>

    Copybufferregion = 7,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION"]/*'/>

    Copytextureregion = 8,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE"]/*'/>

    Copyresource = 9,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYTILES"]/*'/>

    Copytiles = 10,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE"]/*'/>

    Resolvesubresource = 11,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW"]/*'/>

    Clearrendertargetview = 12,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW"]/*'/>

    Clearunorderedaccessview = 13,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW"]/*'/>

    Cleardepthstencilview = 14,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER"]/*'/>

    Resourcebarrier = 15,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE"]/*'/>

    Executebundle = 16,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PRESENT"]/*'/>

    Present = 17,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA"]/*'/>

    Resolvequerydata = 18,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION"]/*'/>

    Beginsubmission = 19,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION"]/*'/>

    Endsubmission = 20,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME"]/*'/>

    Decodeframe = 21,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES"]/*'/>

    Processframes = 22,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT"]/*'/>

    Atomiccopybufferuint = 23,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64"]/*'/>

    Atomiccopybufferuint64 = 24,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION"]/*'/>

    Resolvesubresourceregion = 25,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE"]/*'/>

    Writebufferimmediate = 26,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1"]/*'/>

    Decodeframe1 = 27,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION"]/*'/>

    Setprotectedresourcesession = 28,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2"]/*'/>

    Decodeframe2 = 29,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1"]/*'/>

    Processframes1 = 30,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE"]/*'/>

    Buildraytracingaccelerationstructure = 31,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO"]/*'/>

    Emitraytracingaccelerationstructurepostbuildinfo = 32,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE"]/*'/>

    Copyraytracingaccelerationstructure = 33,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS"]/*'/>

    Dispatchrays = 34,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND"]/*'/>

    Initializemetacommand = 35,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND"]/*'/>

    Executemetacommand = 36,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION"]/*'/>

    Estimatemotion = 37,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP"]/*'/>

    Resolvemotionvectorheap = 38,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1"]/*'/>

    Setpipelinestate1 = 39,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND"]/*'/>

    Initializeextensioncommand = 40,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND"]/*'/>

    Executeextensioncommand = 41,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH"]/*'/>

    Dispatchmesh = 42,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME"]/*'/>

    Encodeframe = 43,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA"]/*'/>

    Resolveencoderoutputmetadata = 44,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BARRIER"]/*'/>

    Barrier = 45,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BEGIN_COMMAND_LIST"]/*'/>

    BeginCommandList = 46,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCHGRAPH"]/*'/>

    Dispatchgraph = 47,

    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETPROGRAM"]/*'/>

    Setprogram = 48,
}

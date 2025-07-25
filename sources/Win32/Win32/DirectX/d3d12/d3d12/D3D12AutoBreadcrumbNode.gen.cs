// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE"]/*'/>
public unsafe partial struct D3D12AutoBreadcrumbNode
{
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandListDebugNameA"]/*'/>

    [NativeTypeName("const char *")]
    public sbyte* PCommandListDebugNameA;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandListDebugNameW"]/*'/>

    [NativeTypeName("const wchar_t *")]
    public ushort* PCommandListDebugNameW;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueueDebugNameA"]/*'/>

    [NativeTypeName("const char *")]
    public sbyte* PCommandQueueDebugNameA;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueueDebugNameW"]/*'/>

    [NativeTypeName("const wchar_t *")]
    public ushort* PCommandQueueDebugNameW;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandList"]/*'/>

    public ID3D12GraphicsCommandList PCommandList;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueue"]/*'/>

    public ID3D12CommandQueue PCommandQueue;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.BreadcrumbCount"]/*'/>

    [NativeTypeName("UINT32")]
    public uint BreadcrumbCount;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pLastBreadcrumbValue"]/*'/>

    [NativeTypeName("const UINT32 *")]
    public uint* PLastBreadcrumbValue;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandHistory"]/*'/>

    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_OP *")]
    public D3D12AutoBreadcrumbOp* PCommandHistory;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pNext"]/*'/>

    [NativeTypeName("const struct D3D12_AUTO_BREADCRUMB_NODE *")]
    public D3D12AutoBreadcrumbNode* PNext;
}

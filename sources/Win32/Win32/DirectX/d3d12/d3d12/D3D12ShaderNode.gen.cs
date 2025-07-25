// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_NODE.xml' path='doc/member[@name="D3D12_SHADER_NODE"]/*'/>
public unsafe partial struct D3D12ShaderNode
{
    /// <include file='D3D12_SHADER_NODE.xml' path='doc/member[@name="D3D12_SHADER_NODE.Shader"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* Shader;

    /// <include file='D3D12_SHADER_NODE.xml' path='doc/member[@name="D3D12_SHADER_NODE.OverridesType"]/*'/>

    public D3D12NodeOverridesType OverridesType;

    /// <include file='D3D12_SHADER_NODE.xml' path='doc/member[@name="D3D12_SHADER_NODE.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_d3d12_L14422_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBroadcastingLaunchOverrides"]/*'/>

    [UnscopedRef]
    public ref D3D12BroadcastingLaunchOverrides* pBroadcastingLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pBroadcastingLaunchOverrides; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCoalescingLaunchOverrides"]/*'/>

    [UnscopedRef]
    public ref D3D12CoalescingLaunchOverrides* pCoalescingLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCoalescingLaunchOverrides; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pThreadLaunchOverrides"]/*'/>

    [UnscopedRef]
    public ref D3D12ThreadLaunchOverrides* pThreadLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pThreadLaunchOverrides; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCommonComputeNodeOverrides"]/*'/>

    [UnscopedRef]
    public ref D3D12CommonComputeNodeOverrides* pCommonComputeNodeOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCommonComputeNodeOverrides; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBroadcastingLaunchOverrides"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_BROADCASTING_LAUNCH_OVERRIDES *")]
        public D3D12BroadcastingLaunchOverrides* pBroadcastingLaunchOverrides;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCoalescingLaunchOverrides"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_COALESCING_LAUNCH_OVERRIDES *")]
        public D3D12CoalescingLaunchOverrides* pCoalescingLaunchOverrides;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pThreadLaunchOverrides"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_THREAD_LAUNCH_OVERRIDES *")]
        public D3D12ThreadLaunchOverrides* pThreadLaunchOverrides;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCommonComputeNodeOverrides"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_COMMON_COMPUTE_NODE_OVERRIDES *")]
        public D3D12CommonComputeNodeOverrides* pCommonComputeNodeOverrides;
    }
}

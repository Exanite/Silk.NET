// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC"]/*'/>
public partial struct D3D12RaytracingGeometryDesc
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Type"]/*'/>

    public D3D12RaytracingGeometryType Type;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Flags"]/*'/>

    public D3D12RaytracingGeometryFlags Flags;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_d3d12_L14690_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*'/>

    [UnscopedRef]
    public ref D3D12RaytracingGeometryTrianglesDesc Triangles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Triangles; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*'/>

    [UnscopedRef]
    public ref D3D12RaytracingGeometryAabbsDesc AABBs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.AABBs; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*'/>

        [FieldOffset(0)]
        public D3D12RaytracingGeometryTrianglesDesc Triangles;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*'/>

        [FieldOffset(0)]
        public D3D12RaytracingGeometryAabbsDesc AABBs;
    }
}

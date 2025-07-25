// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS"]/*'/>
public partial struct DmlScaleBias
{
    /// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS.Scale"]/*'/>

    public float Scale;

    /// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS.Bias"]/*'/>

    public float Bias;
}

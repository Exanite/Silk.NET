// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE"]/*'/>
public enum DmlConvolutionMode
{
    /// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE.DML_CONVOLUTION_MODE_CONVOLUTION"]/*'/>

    Convolution,

    /// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE.DML_CONVOLUTION_MODE_CROSS_CORRELATION"]/*'/>

    CrossCorrelation,
}

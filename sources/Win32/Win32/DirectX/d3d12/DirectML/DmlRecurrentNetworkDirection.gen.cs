// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION"]/*'/>
public enum DmlRecurrentNetworkDirection
{
    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_FORWARD"]/*'/>

    Forward,

    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BACKWARD"]/*'/>

    Backward,

    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BIDIRECTIONAL"]/*'/>

    Bidirectional,
}

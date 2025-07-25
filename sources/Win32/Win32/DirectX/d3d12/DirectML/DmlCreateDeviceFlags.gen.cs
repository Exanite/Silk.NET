// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS"]/*'/>
[Flags]
public enum DmlCreateDeviceFlags
{
    /// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS.DML_CREATE_DEVICE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS.DML_CREATE_DEVICE_FLAG_DEBUG"]/*'/>

    Debug = 0x1,
}

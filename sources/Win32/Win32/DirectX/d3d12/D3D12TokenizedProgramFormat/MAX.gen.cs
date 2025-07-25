// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class MAX
{
    [NativeTypeName("#define MAX_D3D10_SB_TOKENIZED_PROGRAM_LENGTH (0xffffffff)")]
    public const uint D3D10SbTokenizedProgramLength = (0xffffffff);

    [NativeTypeName("#define MAX_D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH 127")]
    public const int D3D10SbTokenizedInstructionLength = 127;
}

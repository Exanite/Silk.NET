// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "VMExecInstHeader")]
    public unsafe partial struct VMExecInstHeader
    {
        public VMExecInstHeader
        (
            PfnVMExtFunction? functionPtr = null,
            uint? opcodeExtension = null,
            uint? operandCount = null
        ) : this()
        {
            if (functionPtr is not null)
            {
                FunctionPtr = functionPtr.Value;
            }

            if (opcodeExtension is not null)
            {
                OpcodeExtension = opcodeExtension.Value;
            }

            if (operandCount is not null)
            {
                OperandCount = operandCount.Value;
            }
        }


        [NativeName("Type", "slang::VMExtFunction")]
        [NativeName("Type.Name", "slang::VMExtFunction")]
        [NativeName("Name", "functionPtr")]
        public PfnVMExtFunction FunctionPtr;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "opcodeExtension")]
        public uint OpcodeExtension;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "operandCount")]
        public uint OperandCount;
    }
}

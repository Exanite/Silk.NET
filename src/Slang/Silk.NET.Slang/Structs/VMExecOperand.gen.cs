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
    [NativeName("Name", "VMExecOperand")]
    public unsafe partial struct VMExecOperand
    {
        public VMExecOperand
        (
            byte** section = null,
            uint? type = null,
            uint? size = null,
            uint? offset = null
        ) : this()
        {
            if (section is not null)
            {
                Section = section;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }
        }


        [NativeName("Type", "uint8_t **")]
        [NativeName("Type.Name", "uint8_t **")]
        [NativeName("Name", "section")]
        public byte** Section;

        private uint _bitfield1;

        public uint Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFu) | (uint)((uint)(value) & 0xFFu));
        }

        public uint Size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFFFFFu << 8)) | (uint)(((uint)(value) & 0xFFFFFFu) << 8));
        }

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;
    }
}

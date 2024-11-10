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

namespace Silk.NET.Vulkan.Vma
{
    [NativeName("Name", "VmaTotalStatistics")]
    public unsafe partial struct TotalStatistics
    {
        public TotalStatistics
        (
            DetailedStatistics? total = null
        ) : this()
        {
            if (total is not null)
            {
                Total = total.Value;
            }
        }

        
        [NativeName("Type", "VmaDetailedStatistics[32]")]
        [NativeName("Type.Name", "VmaDetailedStatistics[32]")]
        [NativeName("Name", "memoryType")]
        public MemoryTypeBuffer MemoryType;

        public struct MemoryTypeBuffer
        {
            public DetailedStatistics Element0;
            public DetailedStatistics Element1;
            public DetailedStatistics Element2;
            public DetailedStatistics Element3;
            public DetailedStatistics Element4;
            public DetailedStatistics Element5;
            public DetailedStatistics Element6;
            public DetailedStatistics Element7;
            public DetailedStatistics Element8;
            public DetailedStatistics Element9;
            public DetailedStatistics Element10;
            public DetailedStatistics Element11;
            public DetailedStatistics Element12;
            public DetailedStatistics Element13;
            public DetailedStatistics Element14;
            public DetailedStatistics Element15;
            public DetailedStatistics Element16;
            public DetailedStatistics Element17;
            public DetailedStatistics Element18;
            public DetailedStatistics Element19;
            public DetailedStatistics Element20;
            public DetailedStatistics Element21;
            public DetailedStatistics Element22;
            public DetailedStatistics Element23;
            public DetailedStatistics Element24;
            public DetailedStatistics Element25;
            public DetailedStatistics Element26;
            public DetailedStatistics Element27;
            public DetailedStatistics Element28;
            public DetailedStatistics Element29;
            public DetailedStatistics Element30;
            public DetailedStatistics Element31;
            public ref DetailedStatistics this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (DetailedStatistics* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<DetailedStatistics> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

        
        [NativeName("Type", "VmaDetailedStatistics[16]")]
        [NativeName("Type.Name", "VmaDetailedStatistics[16]")]
        [NativeName("Name", "memoryHeap")]
        public MemoryHeapBuffer MemoryHeap;

        public struct MemoryHeapBuffer
        {
            public DetailedStatistics Element0;
            public DetailedStatistics Element1;
            public DetailedStatistics Element2;
            public DetailedStatistics Element3;
            public DetailedStatistics Element4;
            public DetailedStatistics Element5;
            public DetailedStatistics Element6;
            public DetailedStatistics Element7;
            public DetailedStatistics Element8;
            public DetailedStatistics Element9;
            public DetailedStatistics Element10;
            public DetailedStatistics Element11;
            public DetailedStatistics Element12;
            public DetailedStatistics Element13;
            public DetailedStatistics Element14;
            public DetailedStatistics Element15;
            public ref DetailedStatistics this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (DetailedStatistics* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<DetailedStatistics> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }


        [NativeName("Type", "VmaDetailedStatistics")]
        [NativeName("Type.Name", "VmaDetailedStatistics")]
        [NativeName("Name", "total")]
        public DetailedStatistics Total;
    }
}

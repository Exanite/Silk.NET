// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan.Vma
{
    /// <summary>
    /// Contains the library name of VulkanMemoryAllocator.
    /// </summary>
    internal class VulkanMemoryAllocatorLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libvma.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libvma.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libvma.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libvma.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "vma.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "vma.dll" };
    }
}

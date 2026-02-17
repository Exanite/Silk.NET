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
        public override string[] Linux => new[] { "libExaniteVma.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libExaniteVma.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libExaniteVma.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libExaniteVma.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "ExaniteVma.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "ExaniteVma.dll" };
    }
}

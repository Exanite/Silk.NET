// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Tracy
{
    /// <summary>
    /// Contains the library name of Tracy.
    /// </summary>
    internal class TracyLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libTracyClient.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libTracyClient.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libTracyClient.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libTracyClient.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "TracyClient.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "TracyClient.dll" };
    }
}

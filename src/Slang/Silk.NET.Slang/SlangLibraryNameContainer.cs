// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Slang
{
    /// <summary>
    /// Contains the library name of Slang.
    /// </summary>
    internal class SlangLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libshaderslang.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libshaderslang.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libshaderslang.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libshaderslang.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "shaderslang.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "shaderslang.dll" };
    }
}

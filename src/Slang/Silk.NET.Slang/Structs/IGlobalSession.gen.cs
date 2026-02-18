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
    [NativeName("Name", "IGlobalSession")]
    public unsafe partial struct IGlobalSession : IComVtbl<IGlobalSession>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(IGlobalSession val)
            => Unsafe.As<IGlobalSession, ISlangUnknown>(ref val);

        public IGlobalSession
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, void** outObject)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionDesc* desc, ISession** outSession)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, desc, outSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionDesc* desc, ref ISession* outSession)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISession** outSessionPtr = &outSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, desc, outSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SessionDesc desc, ISession** outSession)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* descPtr = &desc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, descPtr, outSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SessionDesc desc, ref ISession* outSession)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* descPtr = &desc)
            {
                fixed (ISession** outSessionPtr = &outSession)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISession**, int>)@this->LpVtbl[3])(@this, descPtr, outSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe SlangProfileID FindProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangProfileID ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangProfileID>)@this->LpVtbl[4])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SlangProfileID FindProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangProfileID ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangProfileID>)@this->LpVtbl[4])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SlangProfileID FindProfile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangProfileID ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangProfileID>)@this->LpVtbl[4])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDownstreamCompilerPath(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, path);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDownstreamCompilerPath(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte path)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, pathPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDownstreamCompilerPath(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[5])(@this, passThrough, pathPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDownstreamCompilerPrelude(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeText);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDownstreamCompilerPrelude(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* preludeTextPtr = &preludeText)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeTextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDownstreamCompilerPrelude(SlangPassThrough passThrough, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var preludeTextPtr = (byte*) SilkMarshal.StringToPtr(preludeText, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, byte*, void>)@this->LpVtbl[6])(@this, passThrough, preludeTextPtr);
            SilkMarshal.Free((nint)preludeTextPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDownstreamCompilerPrelude(SlangPassThrough passThrough, ISlangBlob** outPrelude)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, ISlangBlob**, void>)@this->LpVtbl[7])(@this, passThrough, outPrelude);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDownstreamCompilerPrelude(SlangPassThrough passThrough, ref ISlangBlob* outPrelude)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ISlangBlob** outPreludePtr = &outPrelude)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, ISlangBlob**, void>)@this->LpVtbl[7])(@this, passThrough, outPreludePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetBuildTagString()
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetBuildTagStringS()
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, string>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDefaultDownstreamCompiler(SlangSourceLanguage sourceLanguage, SlangPassThrough defaultCompiler)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, SlangPassThrough, int>)@this->LpVtbl[9])(@this, sourceLanguage, defaultCompiler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SlangPassThrough GetDefaultDownstreamCompiler(SlangSourceLanguage sourceLanguage)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangPassThrough ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, SlangPassThrough>)@this->LpVtbl[10])(@this, sourceLanguage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetLanguagePrelude(SlangSourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeText);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetLanguagePrelude(SlangSourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* preludeTextPtr = &preludeText)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeTextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetLanguagePrelude(SlangSourceLanguage sourceLanguage, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string preludeText)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var preludeTextPtr = (byte*) SilkMarshal.StringToPtr(preludeText, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, byte*, void>)@this->LpVtbl[11])(@this, sourceLanguage, preludeTextPtr);
            SilkMarshal.Free((nint)preludeTextPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLanguagePrelude(SlangSourceLanguage sourceLanguage, ISlangBlob** outPrelude)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, ISlangBlob**, void>)@this->LpVtbl[12])(@this, sourceLanguage, outPrelude);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLanguagePrelude(SlangSourceLanguage sourceLanguage, ref ISlangBlob* outPrelude)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ISlangBlob** outPreludePtr = &outPrelude)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangSourceLanguage, ISlangBlob**, void>)@this->LpVtbl[12])(@this, sourceLanguage, outPreludePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompileRequest(ICompileRequest** outCompileRequest)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ICompileRequest**, int>)@this->LpVtbl[13])(@this, outCompileRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompileRequest(ref ICompileRequest* outCompileRequest)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileRequest** outCompileRequestPtr = &outCompileRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ICompileRequest**, int>)@this->LpVtbl[13])(@this, outCompileRequestPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceString);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourceStringPtr = &sourceString)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceStringPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePath, sourceStringPtr);
            SilkMarshal.Free((nint)sourceStringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourcePathPtr = &sourcePath)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceString);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourcePathPtr = &sourcePath)
            {
                fixed (byte* sourceStringPtr = &sourceString)
                {
                    ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourcePathPtr = &sourcePath)
            {
            var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
            SilkMarshal.Free((nint)sourceStringPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceString);
            SilkMarshal.Free((nint)sourcePathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
            fixed (byte* sourceStringPtr = &sourceString)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
            }
            SilkMarshal.Free((nint)sourcePathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddBuiltins([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourcePathPtr = (byte*) SilkMarshal.StringToPtr(sourcePath, NativeStringEncoding.UTF8);
            var sourceStringPtr = (byte*) SilkMarshal.StringToPtr(sourceString, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, byte*, void>)@this->LpVtbl[14])(@this, sourcePathPtr, sourceStringPtr);
            SilkMarshal.Free((nint)sourceStringPtr);
            SilkMarshal.Free((nint)sourcePathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetSharedLibraryLoader(ISlangSharedLibraryLoader* loader)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*, void>)@this->LpVtbl[15])(@this, loader);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetSharedLibraryLoader(ref ISlangSharedLibraryLoader loader)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ISlangSharedLibraryLoader* loaderPtr = &loader)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*, void>)@this->LpVtbl[15])(@this, loaderPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ISlangSharedLibraryLoader* GetSharedLibraryLoader()
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ISlangSharedLibraryLoader* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, ISlangSharedLibraryLoader*>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCompileTargetSupport(SlangCompileTarget target)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangCompileTarget, int>)@this->LpVtbl[17])(@this, target);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckPassThroughSupport(SlangPassThrough passThrough)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangPassThrough, int>)@this->LpVtbl[18])(@this, passThrough);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileCoreModule(uint flags)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, uint, int>)@this->LpVtbl[19])(@this, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadCoreModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coreModule, nuint coreModuleSizeInBytes)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, void*, nuint, int>)@this->LpVtbl[20])(@this, coreModule, coreModuleSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadCoreModule<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coreModule, nuint coreModuleSizeInBytes) where T0 : unmanaged
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* coreModulePtr = &coreModule)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, void*, nuint, int>)@this->LpVtbl[20])(@this, coreModulePtr, coreModuleSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveCoreModule(SlangArchiveType archiveType, ISlangBlob** outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangArchiveType, ISlangBlob**, int>)@this->LpVtbl[21])(@this, archiveType, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveCoreModule(SlangArchiveType archiveType, ref ISlangBlob* outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangArchiveType, ISlangBlob**, int>)@this->LpVtbl[21])(@this, archiveType, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe SlangCapabilityID FindCapability([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangCapabilityID ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangCapabilityID>)@this->LpVtbl[22])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SlangCapabilityID FindCapability([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangCapabilityID ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangCapabilityID>)@this->LpVtbl[22])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SlangCapabilityID FindCapability([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangCapabilityID ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, SlangCapabilityID>)@this->LpVtbl[22])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDownstreamCompilerForTransition(SlangCompileTarget source, SlangCompileTarget target, SlangPassThrough compiler)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangCompileTarget, SlangCompileTarget, SlangPassThrough, void>)@this->LpVtbl[23])(@this, source, target, compiler);
        }

        /// <summary>To be documented.</summary>
        public readonly SlangPassThrough GetDownstreamCompilerForTransition(SlangCompileTarget source, SlangCompileTarget target)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SlangPassThrough ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SlangCompileTarget, SlangCompileTarget, SlangPassThrough>)@this->LpVtbl[24])(@this, source, target);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCompilerElapsedTime(double* outTotalTime, double* outDownstreamTime)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTime, outDownstreamTime);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCompilerElapsedTime(double* outTotalTime, ref double outDownstreamTime)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (double* outDownstreamTimePtr = &outDownstreamTime)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTime, outDownstreamTimePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCompilerElapsedTime(ref double outTotalTime, double* outDownstreamTime)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (double* outTotalTimePtr = &outTotalTime)
            {
                ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTimePtr, outDownstreamTime);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCompilerElapsedTime(ref double outTotalTime, ref double outDownstreamTime)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (double* outTotalTimePtr = &outTotalTime)
            {
                fixed (double* outDownstreamTimePtr = &outDownstreamTime)
                {
                    ((delegate* unmanaged[Cdecl]<IGlobalSession*, double*, double*, void>)@this->LpVtbl[25])(@this, outTotalTimePtr, outDownstreamTimePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSPIRVCoreGrammar([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* jsonPath)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSPIRVCoreGrammar([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte jsonPath)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* jsonPathPtr = &jsonPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSPIRVCoreGrammar([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string jsonPath)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jsonPathPtr = (byte*) SilkMarshal.StringToPtr(jsonPath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, byte*, int>)@this->LpVtbl[26])(@this, jsonPathPtr);
            SilkMarshal.Free((nint)jsonPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDesc, outAuxAllocation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDesc, outAuxAllocationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDescPtr, outAuxAllocation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
            {
                fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argv, outSessionDescPtr, outAuxAllocationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** argvPtr = &argv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDesc, outAuxAllocation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** argvPtr = &argv)
            {
                fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDesc, outAuxAllocationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** argvPtr = &argv)
            {
                fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDescPtr, outAuxAllocation);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** argvPtr = &argv)
            {
                fixed (SessionDesc* outSessionDescPtr = &outSessionDesc)
                {
                    fixed (ISlangUnknown** outAuxAllocationPtr = &outAuxAllocation)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, int, byte**, SessionDesc*, ISlangUnknown**, int>)@this->LpVtbl[27])(@this, argc, argvPtr, outSessionDescPtr, outAuxAllocationPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionDescDigest(SessionDesc* sessionDesc, ISlangBlob** outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDesc, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionDescDigest(SessionDesc* sessionDesc, ref ISlangBlob* outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDesc, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionDescDigest(ref SessionDesc sessionDesc, ISlangBlob** outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* sessionDescPtr = &sessionDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDescPtr, outBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionDescDigest(ref SessionDesc sessionDesc, ref ISlangBlob* outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SessionDesc* sessionDescPtr = &sessionDesc)
            {
                fixed (ISlangBlob** outBlobPtr = &outBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, SessionDesc*, ISlangBlob**, int>)@this->LpVtbl[28])(@this, sessionDescPtr, outBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileBuiltinModule(BuiltinModuleName module, uint flags)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, uint, int>)@this->LpVtbl[29])(@this, module, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadBuiltinModule(BuiltinModuleName module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* moduleData, nuint sizeInBytes)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, void*, nuint, int>)@this->LpVtbl[30])(@this, module, moduleData, sizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadBuiltinModule<T0>(BuiltinModuleName module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 moduleData, nuint sizeInBytes) where T0 : unmanaged
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* moduleDataPtr = &moduleData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, void*, nuint, int>)@this->LpVtbl[30])(@this, module, moduleDataPtr, sizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveBuiltinModule(BuiltinModuleName module, SlangArchiveType archiveType, ISlangBlob** outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, SlangArchiveType, ISlangBlob**, int>)@this->LpVtbl[31])(@this, module, archiveType, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveBuiltinModule(BuiltinModuleName module, SlangArchiveType archiveType, ref ISlangBlob* outBlob)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalSession*, BuiltinModuleName, SlangArchiveType, ISlangBlob**, int>)@this->LpVtbl[31])(@this, module, archiveType, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, SessionDesc* outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
            var ret = @this->ParseCommandLineArguments(argc, argv, outSessionDesc, outAuxAllocation);
            SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
            SilkMarshal.Free((nint) argv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments<TI0>(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, SessionDesc* outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseCommandLineArguments(argc, argv, outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, SessionDesc* outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
            var ret = @this->ParseCommandLineArguments(argc, argv, outSessionDesc, ref outAuxAllocation);
            SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
            SilkMarshal.Free((nint) argv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, ref SessionDesc outSessionDesc, ISlangUnknown** outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
            var ret = @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, outAuxAllocation);
            SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
            SilkMarshal.Free((nint) argv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments<TI0>(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** argv, ref SessionDesc outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argvSa, ref SessionDesc outSessionDesc, ref ISlangUnknown* outAuxAllocation)
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
            var ret = @this->ParseCommandLineArguments(argc, argv, ref outSessionDesc, ref outAuxAllocation);
            SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
            SilkMarshal.Free((nint) argv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments<TI0>(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, SessionDesc* outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseCommandLineArguments(argc, in argv, outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseCommandLineArguments<TI0>(int argc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* argv, ref SessionDesc outSessionDesc, ref ComPtr<TI0> outAuxAllocation) where TI0 : unmanaged, IComVtbl<ISlangUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseCommandLineArguments(argc, in argv, ref outSessionDesc, (ISlangUnknown**) outAuxAllocation.GetAddressOf());
        }

    }
}

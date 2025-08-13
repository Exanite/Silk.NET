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
    [NativeName("Name", "ICompileRequest")]
    public unsafe partial struct ICompileRequest : IComVtbl<ICompileRequest>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ICompileRequest val)
            => Unsafe.As<ICompileRequest, Silk.NET.Core.Native.IUnknown>(ref val);

        public ICompileRequest
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
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetFileSystem(IFileSystem* fileSystem)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void>)@this->LpVtbl[3])(@this, fileSystem);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetFileSystem(ref IFileSystem fileSystem)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IFileSystem* fileSystemPtr = &fileSystem)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void>)@this->LpVtbl[3])(@this, fileSystemPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCompileFlags(uint flags)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint, void>)@this->LpVtbl[4])(@this, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCompileFlags()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDumpIntermediates(int enable)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, void>)@this->LpVtbl[6])(@this, enable);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDumpIntermediatePrefix([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* prefix)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefix);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDumpIntermediatePrefix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte prefix)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* prefixPtr = &prefix)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefixPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDumpIntermediatePrefix([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string prefix)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var prefixPtr = (byte*) SilkMarshal.StringToPtr(prefix, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[7])(@this, prefixPtr);
            SilkMarshal.Free((nint)prefixPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetLineDirectiveMode(LineDirectiveMode mode)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, LineDirectiveMode, void>)@this->LpVtbl[8])(@this, mode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCodeGenTarget(CompileTarget target)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, CompileTarget, void>)@this->LpVtbl[9])(@this, target);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddCodeGenTarget(CompileTarget target)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, CompileTarget, int>)@this->LpVtbl[10])(@this, target);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetProfile(int targetIndex, ProfileID profile)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ProfileID, void>)@this->LpVtbl[11])(@this, targetIndex, profile);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetFlags(int targetIndex, uint flags)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, uint, void>)@this->LpVtbl[12])(@this, targetIndex, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetFloatingPointMode(int targetIndex, FloatingPointMode mode)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, FloatingPointMode, void>)@this->LpVtbl[13])(@this, targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetMatrixLayoutMode(int targetIndex, MatrixLayoutMode mode)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, MatrixLayoutMode, void>)@this->LpVtbl[14])(@this, targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMatrixLayoutMode(MatrixLayoutMode mode)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, MatrixLayoutMode, void>)@this->LpVtbl[15])(@this, mode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugInfoLevel(DebugInfoLevel level)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, DebugInfoLevel, void>)@this->LpVtbl[16])(@this, level);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOptimizationLevel(OptimizationLevel level)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, OptimizationLevel, void>)@this->LpVtbl[17])(@this, level);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOutputContainerFormat(ContainerFormat format)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, ContainerFormat, void>)@this->LpVtbl[18])(@this, format);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPassThrough(PassThrough passThrough)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, PassThrough, void>)@this->LpVtbl[19])(@this, passThrough);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDiagnosticCallback(PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userData)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, PfnDiagnosticCallback, void*, void>)@this->LpVtbl[20])(@this, callback, userData);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDiagnosticCallback<T0>(PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 userData) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* userDataPtr = &userData)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, PfnDiagnosticCallback, void*, void>)@this->LpVtbl[20])(@this, callback, userDataPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetWriter(WriterChannel channel, IWriter* writer)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*, void>)@this->LpVtbl[21])(@this, channel, writer);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetWriter(WriterChannel channel, ref IWriter writer)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IWriter* writerPtr = &writer)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*, void>)@this->LpVtbl[21])(@this, channel, writerPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IWriter* GetWriter(WriterChannel channel)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IWriter* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, WriterChannel, IWriter*>)@this->LpVtbl[22])(@this, channel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddSearchPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* searchDir)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDir);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddSearchPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte searchDir)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* searchDirPtr = &searchDir)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDirPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddSearchPath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string searchDir)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var searchDirPtr = (byte*) SilkMarshal.StringToPtr(searchDir, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[23])(@this, searchDirPtr);
            SilkMarshal.Free((nint)searchDirPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, value);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, valuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, key, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, value);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
                fixed (byte* valuePtr = &value)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, value);
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
            }
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddPreprocessorDefine([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, byte*, void>)@this->LpVtbl[24])(@this, keyPtr, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessCommandLineArguments([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** args, int argCount)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte**, int, int>)@this->LpVtbl[25])(@this, args, argCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessCommandLineArguments([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* args, int argCount)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** argsPtr = &args)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte**, int, int>)@this->LpVtbl[25])(@this, argsPtr, argCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTranslationUnit(SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTranslationUnit(SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTranslationUnit(SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, SourceLanguage, byte*, int>)@this->LpVtbl[26])(@this, language, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDefaultModuleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* defaultModuleName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleName);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDefaultModuleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte defaultModuleName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* defaultModuleNamePtr = &defaultModuleName)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleNamePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDefaultModuleName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string defaultModuleName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var defaultModuleNamePtr = (byte*) SilkMarshal.StringToPtr(defaultModuleName, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void>)@this->LpVtbl[27])(@this, defaultModuleNamePtr);
            SilkMarshal.Free((nint)defaultModuleNamePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, value);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, valuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, key, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, value);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
                fixed (byte* valuePtr = &value)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* keyPtr = &key)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, value);
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            fixed (byte* valuePtr = &value)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
            }
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitPreprocessorDefine(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[28])(@this, translationUnitIndex, keyPtr, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)keyPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceFile(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, path);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceFile(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, pathPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceFile(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, void>)@this->LpVtbl[29])(@this, translationUnitIndex, pathPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, source);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourcePtr = &source)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, sourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, path, sourcePtr);
            SilkMarshal.Free((nint)sourcePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, source);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* sourcePtr = &source)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
            var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
            SilkMarshal.Free((nint)sourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, source);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* sourcePtr = &source)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceString(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var sourcePtr = (byte*) SilkMarshal.StringToPtr(source, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, void>)@this->LpVtbl[30])(@this, translationUnitIndex, pathPtr, sourcePtr);
            SilkMarshal.Free((nint)sourcePtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddLibraryReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePath, libData, libDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddLibraryReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* libDataPtr = &libData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePath, libDataPtr, libDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddLibraryReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* basePathPtr = &basePath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libData, libDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddLibraryReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* basePathPtr = &basePath)
            {
                fixed (void* libDataPtr = &libData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libDataPtr, libDataSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddLibraryReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var basePathPtr = (byte*) SilkMarshal.StringToPtr(basePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libData, libDataSize);
            SilkMarshal.Free((nint)basePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddLibraryReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var basePathPtr = (byte*) SilkMarshal.StringToPtr(basePath, NativeStringEncoding.UTF8);
            fixed (void* libDataPtr = &libData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*, void*, nuint, int>)@this->LpVtbl[31])(@this, basePathPtr, libDataPtr, libDataSize);
            }
            SilkMarshal.Free((nint)basePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEndPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBegin, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEnd);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                fixed (byte* sourceEndPtr = &sourceEnd)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEnd);
            SilkMarshal.Free((nint)sourceBeginPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
            }
            SilkMarshal.Free((nint)sourceBeginPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, path, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            SilkMarshal.Free((nint)sourceBeginPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEnd);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* sourceEndPtr = &sourceEnd)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* sourceBeginPtr = &sourceBegin)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* sourceBeginPtr = &sourceBegin)
                {
                    fixed (byte* sourceEndPtr = &sourceEnd)
                    {
                        ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* sourceBeginPtr = &sourceBegin)
                {
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
            SilkMarshal.Free((nint)sourceBeginPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
                fixed (byte* sourceEndPtr = &sourceEnd)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
                }
            SilkMarshal.Free((nint)sourceBeginPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            SilkMarshal.Free((nint)sourceBeginPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEnd);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBegin, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
                fixed (byte* sourceEndPtr = &sourceEnd)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* sourceBeginPtr = &sourceBegin)
            {
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEnd);
            SilkMarshal.Free((nint)sourceBeginPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            fixed (byte* sourceEndPtr = &sourceEnd)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            }
            SilkMarshal.Free((nint)sourceBeginPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceStringSpan(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var sourceBeginPtr = (byte*) SilkMarshal.StringToPtr(sourceBegin, NativeStringEncoding.UTF8);
            var sourceEndPtr = (byte*) SilkMarshal.StringToPtr(sourceEnd, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, byte*, byte*, void>)@this->LpVtbl[32])(@this, translationUnitIndex, pathPtr, sourceBeginPtr, sourceEndPtr);
            SilkMarshal.Free((nint)sourceEndPtr);
            SilkMarshal.Free((nint)sourceBeginPtr);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, path, sourceBlob);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IBlob* sourceBlobPtr = &sourceBlob)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, path, sourceBlobPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlob);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourceBlobPtr = &sourceBlob)
                {
                    ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlobPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlob);
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddTranslationUnitSourceBlob(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob sourceBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourceBlobPtr = &sourceBlob)
            {
                ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, IBlob*, void>)@this->LpVtbl[33])(@this, translationUnitIndex, pathPtr, sourceBlobPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPoint(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, name, stage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddEntryPoint(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, namePtr, stage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddEntryPoint(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int>)@this->LpVtbl[34])(@this, translationUnitIndex, namePtr, stage);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, name, stage, genericArgCount, genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** genericArgsPtr = &genericArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, name, stage, genericArgCount, genericArgsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (byte** genericArgsPtr = &genericArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgs);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (byte** genericArgsPtr = &genericArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, Stage, int, byte**, int>)@this->LpVtbl[35])(@this, translationUnitIndex, namePtr, stage, genericArgCount, genericArgsPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGlobalGenericArgs(int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte**, int>)@this->LpVtbl[36])(@this, genericArgCount, genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGlobalGenericArgs(int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** genericArgsPtr = &genericArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte**, int>)@this->LpVtbl[36])(@this, genericArgCount, genericArgsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypeNameForGlobalExistentialTypeParam(int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeNameForGlobalExistentialTypeParam(int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* typeNamePtr = &typeName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeNameForGlobalExistentialTypeParam(int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typeNamePtr = (byte*) SilkMarshal.StringToPtr(typeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*, int>)@this->LpVtbl[37])(@this, slotIndex, typeNamePtr);
            SilkMarshal.Free((nint)typeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypeNameForEntryPointExistentialTypeParam(int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeNameForEntryPointExistentialTypeParam(int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* typeNamePtr = &typeName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeNameForEntryPointExistentialTypeParam(int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typeNamePtr = (byte*) SilkMarshal.StringToPtr(typeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, byte*, int>)@this->LpVtbl[38])(@this, entryPointIndex, slotIndex, typeNamePtr);
            SilkMarshal.Free((nint)typeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetAllowGLSLInput(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[39])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly int Compile()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[40])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetDiagnosticOutput()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, byte*>)@this->LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetDiagnosticOutputS()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, string>)@this->LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDiagnosticOutputBlob(IBlob** outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[42])(@this, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDiagnosticOutputBlob(ref IBlob* outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[42])(@this, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDependencyFileCount()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[43])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetDependencyFilePath(int index)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*>)@this->LpVtbl[44])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetDependencyFilePathS(int index)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, string>)@this->LpVtbl[44])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTranslationUnitCount()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[45])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetEntryPointSource(int entryPointIndex)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, byte*>)@this->LpVtbl[46])(@this, entryPointIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetEntryPointSourceS(int entryPointIndex)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, string>)@this->LpVtbl[46])(@this, entryPointIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetEntryPointCode(int entryPointIndex, nuint* outSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, nuint*, void*>)@this->LpVtbl[47])(@this, entryPointIndex, outSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetEntryPointCode(int entryPointIndex, ref nuint outSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (nuint* outSizePtr = &outSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, nuint*, void*>)@this->LpVtbl[47])(@this, entryPointIndex, outSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCodeBlob(int entryPointIndex, int targetIndex, IBlob** outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, IBlob**, int>)@this->LpVtbl[48])(@this, entryPointIndex, targetIndex, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCodeBlob(int entryPointIndex, int targetIndex, ref IBlob* outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, IBlob**, int>)@this->LpVtbl[48])(@this, entryPointIndex, targetIndex, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, ISharedLibrary**, int>)@this->LpVtbl[49])(@this, entryPointIndex, targetIndex, outSharedLibrary);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, int, ISharedLibrary**, int>)@this->LpVtbl[49])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCodeBlob(int targetIndex, IBlob** outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, IBlob**, int>)@this->LpVtbl[50])(@this, targetIndex, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCodeBlob(int targetIndex, ref IBlob* outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, IBlob**, int>)@this->LpVtbl[50])(@this, targetIndex, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetHostCallable(int targetIndex, ISharedLibrary** outSharedLibrary)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ISharedLibrary**, int>)@this->LpVtbl[51])(@this, targetIndex, outSharedLibrary);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetHostCallable(int targetIndex, ref ISharedLibrary* outSharedLibrary)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, ISharedLibrary**, int>)@this->LpVtbl[51])(@this, targetIndex, outSharedLibraryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetCompileRequestCode(nuint* outSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, nuint*, void*>)@this->LpVtbl[52])(@this, outSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetCompileRequestCode(ref nuint outSize)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (nuint* outSizePtr = &outSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, nuint*, void*>)@this->LpVtbl[52])(@this, outSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IMutableFileSystem* GetCompileRequestResultAsFileSystem()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IMutableFileSystem* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IMutableFileSystem*>)@this->LpVtbl[53])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerCode(IBlob** outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[54])(@this, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerCode(ref IBlob* outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[54])(@this, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadRepro(IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystem, data, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadRepro<T0>(IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystem, dataPtr, size);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadRepro(ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IFileSystem* fileSystemPtr = &fileSystem)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystemPtr, data, size);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadRepro<T0>(ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IFileSystem* fileSystemPtr = &fileSystem)
            {
                fixed (void* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IFileSystem*, void*, nuint, int>)@this->LpVtbl[55])(@this, fileSystemPtr, dataPtr, size);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveRepro(IBlob** outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[56])(@this, outBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveRepro(ref IBlob* outBlob)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IBlob**, int>)@this->LpVtbl[56])(@this, outBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableReproCapture()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[57])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProgram(IComponentType** outProgram)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[58])(@this, outProgram);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProgram(ref IComponentType* outProgram)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outProgramPtr = &outProgram)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[58])(@this, outProgramPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(long entryPointIndex, IComponentType** outEntryPoint)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IComponentType**, int>)@this->LpVtbl[59])(@this, entryPointIndex, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(long entryPointIndex, ref IComponentType* outEntryPoint)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IComponentType**, int>)@this->LpVtbl[59])(@this, entryPointIndex, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModule(long translationUnitIndex, IModule** outModule)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IModule**, int>)@this->LpVtbl[60])(@this, translationUnitIndex, outModule);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModule(long translationUnitIndex, ref IModule* outModule)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IModule** outModulePtr = &outModule)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, IModule**, int>)@this->LpVtbl[60])(@this, translationUnitIndex, outModulePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSession(ISession** outSession)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ISession**, int>)@this->LpVtbl[61])(@this, outSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSession(ref ISession* outSession)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISession** outSessionPtr = &outSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ISession**, int>)@this->LpVtbl[61])(@this, outSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ProgramLayout* GetReflection()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramLayout* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, ProgramLayout*>)@this->LpVtbl[62])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCommandLineCompilerMode()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, void>)@this->LpVtbl[63])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTargetCapability(long targetIndex, CapabilityID capability)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, CapabilityID, int>)@this->LpVtbl[64])(@this, targetIndex, capability);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProgramWithEntryPoints(IComponentType** outProgram)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[65])(@this, outProgram);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProgramWithEntryPoints(ref IComponentType* outProgram)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outProgramPtr = &outProgram)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IComponentType**, int>)@this->LpVtbl[65])(@this, outProgramPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsParameterLocationUsed(long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, bool* outUsed)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, long, ParameterCategory, ulong, ulong, bool*, int>)@this->LpVtbl[66])(@this, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsParameterLocationUsed(long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, ref bool outUsed)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (bool* outUsedPtr = &outUsed)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, long, ParameterCategory, ulong, ulong, bool*, int>)@this->LpVtbl[66])(@this, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetLineDirectiveMode(long targetIndex, LineDirectiveMode mode)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, LineDirectiveMode, void>)@this->LpVtbl[67])(@this, targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetForceGLSLScalarBufferLayout(int targetIndex, bool forceScalarLayout)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[68])(@this, targetIndex, forceScalarLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly void OverrideDiagnosticSeverity(long messageID, Severity overrideSeverity)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, long, Severity, void>)@this->LpVtbl[69])(@this, messageID, overrideSeverity);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDiagnosticFlags()
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, int>)@this->LpVtbl[70])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDiagnosticFlags(int flags)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, void>)@this->LpVtbl[71])(@this, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugInfoFormat(DebugInfoFormat debugFormat)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, DebugInfoFormat, void>)@this->LpVtbl[72])(@this, debugFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEnableEffectAnnotations(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[73])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetReportDownstreamTime(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[74])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetReportPerfBenchmark(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[75])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetSkipSPIRVValidation(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[76])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetUseMinimumSlangOptimization(int targetIndex, bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[77])(@this, targetIndex, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetIgnoreCapabilityCheck(bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, bool, void>)@this->LpVtbl[78])(@this, value);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCompileTimeProfile(IProfiler** compileTimeProfile, bool shouldClear)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IProfiler**, bool, int>)@this->LpVtbl[79])(@this, compileTimeProfile, shouldClear);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCompileTimeProfile(ref IProfiler* compileTimeProfile, bool shouldClear)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IProfiler** compileTimeProfilePtr = &compileTimeProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICompileRequest*, IProfiler**, bool, int>)@this->LpVtbl[79])(@this, compileTimeProfilePtr, shouldClear);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetGenerateWholeProgram(int targetIndex, bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[80])(@this, targetIndex, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetForceDXLayout(int targetIndex, bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[81])(@this, targetIndex, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTargetEmbedDownstreamIR(int targetIndex, bool value)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ICompileRequest*, int, bool, void>)@this->LpVtbl[82])(@this, targetIndex, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetFileSystem<TI0>(ComPtr<TI0> fileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetFileSystem((IFileSystem*) fileSystem.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessCommandLineArguments([Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argsSa, int argCount)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var args = (byte**) SilkMarshal.StringArrayToPtr(argsSa);
            var ret = @this->ProcessCommandLineArguments(args, argCount);
            SilkMarshal.CopyPtrToStringArray((nint) args, argsSa);
            SilkMarshal.Free((nint) args);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = @this->AddEntryPointEx(translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = @this->AddEntryPointEx(translationUnitIndex, in name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddEntryPointEx(int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = @this->AddEntryPointEx(translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGlobalGenericArgs(int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = @this->SetGlobalGenericArgs(genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadRepro<TI0>(ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadRepro((IFileSystem*) fileSystem.Handle, data, size);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadRepro<T0, TI0>(ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadRepro((IFileSystem*) fileSystem.Handle, in data, size);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProgram<TI0>(ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetProgram((IComponentType**) outProgram.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEntryPoint<TI0>(long entryPointIndex, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEntryPoint(entryPointIndex, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProgramWithEntryPoints<TI0>(ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ICompileRequest*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetProgramWithEntryPoints((IComponentType**) outProgram.GetAddressOf());
        }

    }
}

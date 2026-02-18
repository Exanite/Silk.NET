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
    [NativeName("Name", "IModule")]
    public unsafe partial struct IModule : IComVtbl<IModule>, IComVtbl<IComponentType>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IComponentType(IModule val)
            => Unsafe.As<IModule, IComponentType>(ref val);

        public static implicit operator ISlangUnknown(IModule val)
            => Unsafe.As<IModule, ISlangUnknown>(ref val);

        public IModule
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
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, void** outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SlangUUID uuid, ref void* outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ISession* GetSession()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ISession* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, ISession*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly long GetSpecializationParamCount()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            long ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ISlangMutableFileSystem** outFileSystem)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ref ISlangMutableFileSystem* outFileSystem)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangMutableFileSystem** outFileSystemPtr = &outFileSystem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ISlangBlob** outHash)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ref ISlangBlob* outHash)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ISlangBlob** outHashPtr = &outHash)
            {
                ((delegate* unmanaged[Cdecl]<IModule*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISlangSharedLibrary**, ISlangBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte newName, IComponentType** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, IEntryPoint** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, name, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, ref IEntryPoint* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, name, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, IEntryPoint** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, ref IEntryPoint* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, IEntryPoint** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPoint);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref IEntryPoint* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, IEntryPoint**, int>)@this->LpVtbl[17])(@this, namePtr, outEntryPointPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefinedEntryPointCount()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefinedEntryPoint(int index, IEntryPoint** outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, IEntryPoint**, int>)@this->LpVtbl[19])(@this, index, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefinedEntryPoint(int index, ref IEntryPoint* outEntryPoint)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, IEntryPoint**, int>)@this->LpVtbl[19])(@this, index, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(ISlangBlob** outSerializedBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, ISlangBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(ref ISlangBlob* outSerializedBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outSerializedBlobPtr = &outSerializedBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, ISlangBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteToFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fileName)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteToFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte fileName)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* fileNamePtr = &fileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteToFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fileName)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fileNamePtr = (byte*) SilkMarshal.StringToPtr(fileName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, int>)@this->LpVtbl[21])(@this, fileNamePtr);
            SilkMarshal.Free((nint)fileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetName()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetNameS()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetFilePath()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetFilePathS()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetUniqueIdentity()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetUniqueIdentityS()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, string>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, SlangStage stage, IEntryPoint** outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, SlangStage stage, IEntryPoint** outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, SlangStage stage, ref IEntryPoint* outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, SlangStage stage, ref IEntryPoint* outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, SlangStage stage, IEntryPoint** outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, SlangStage stage, IEntryPoint** outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, SlangStage stage, ref IEntryPoint* outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, SlangStage stage, ref IEntryPoint* outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SlangStage stage, IEntryPoint** outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SlangStage stage, IEntryPoint** outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SlangStage stage, ref IEntryPoint* outEntryPoint, ISlangBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SlangStage stage, ref IEntryPoint* outEntryPoint, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, SlangStage, IEntryPoint**, ISlangBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDependencyFileCount()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetDependencyFilePath(int index)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, byte*>)@this->LpVtbl[27])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string GetDependencyFilePathS(int index)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, string>)@this->LpVtbl[27])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe DeclReflection* GetModuleReflection()
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeclReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, DeclReflection*>)@this->LpVtbl[28])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(ISlangBlob** outDisassembledBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, ISlangBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(ref ISlangBlob* outDisassembledBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDisassembledBlobPtr = &outDisassembledBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, ISlangBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
        }

    }
}

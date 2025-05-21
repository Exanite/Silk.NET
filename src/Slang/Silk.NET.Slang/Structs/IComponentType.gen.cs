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
    [NativeName("Name", "IComponentType")]
    public unsafe partial struct IComponentType : IComVtbl<IComponentType>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(IComponentType val)
            => Unsafe.As<IComponentType, ISlangUnknown>(ref val);

        public IComponentType
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
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ISession* GetSession()
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ISession* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, ISession*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly long GetSpecializationParamCount()
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            long ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ISlangMutableFileSystem** outFileSystem)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ref ISlangMutableFileSystem* outFileSystem)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangMutableFileSystem** outFileSystemPtr = &outFileSystem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ISlangBlob** outHash)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ref ISlangBlob* outHash)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ISlangBlob** outHashPtr = &outHash)
            {
                ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, ISlangBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, SpecializationArg*, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISlangSharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISlangSharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISlangSharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISlangSharedLibrary* outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangSharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, int, int, ISlangSharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IComponentType*, IComponentType**, uint, CompilerOptionEntry*, ISlangBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ISlangBlob** outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ISlangBlob** outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref ISlangBlob* outCode, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref ISlangBlob* outCode, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outCodePtr = &outCode)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, ISlangBlob**, ISlangBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ISlangBlob** outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref ISlangBlob* outDiagnostics)
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType*, long, long, IMetadata**, ISlangBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IComponentType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
        }

    }
}

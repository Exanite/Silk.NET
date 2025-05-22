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
    public unsafe partial struct IModule : IComVtbl<IModule>, IComVtbl<IComponentType>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IComponentType(IModule val)
            => Unsafe.As<IModule, IComponentType>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IModule val)
            => Unsafe.As<IModule, Silk.NET.Core.Native.IUnknown>(ref val);

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
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
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
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
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
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, IMutableFileSystem** outFileSystem)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ref IMutableFileSystem* outFileSystem)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMutableFileSystem** outFileSystemPtr = &outFileSystem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, IBlob** outHash)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ref IBlob* outHash)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IBlob** outHashPtr = &outHash)
            {
                ((delegate* unmanaged[Cdecl]<IModule*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
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
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
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
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
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
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
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
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, IEntryPoint** outEntryPoint)
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
        public readonly unsafe int FindEntryPointByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, ref IEntryPoint* outEntryPoint)
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
        public readonly unsafe int Serialize(IBlob** outSerializedBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(ref IBlob* outSerializedBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outSerializedBlobPtr = &outSerializedBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[20])(@this, outSerializedBlobPtr);
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
        public readonly int WriteToFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte fileName)
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
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPoint, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, name, stage, outEntryPointPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, IEntryPoint** outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnostics);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, IEntryPoint** outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPoint, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, ref IEntryPoint* outEntryPoint, IBlob** outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindAndCheckEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, ref IEntryPoint* outEntryPoint, ref IBlob* outDiagnostics)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (IEntryPoint** outEntryPointPtr = &outEntryPoint)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModule*, byte*, Stage, IEntryPoint**, IBlob**, int>)@this->LpVtbl[25])(@this, namePtr, stage, outEntryPointPtr, outDiagnosticsPtr);
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
        public readonly unsafe int Disassemble(IBlob** outDisassembledBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(ref IBlob* outDisassembledBlob)
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDisassembledBlobPtr = &outDisassembledBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModule*, IBlob**, int>)@this->LpVtbl[29])(@this, outDisassembledBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
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
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
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
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IModule*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
        }

    }
}

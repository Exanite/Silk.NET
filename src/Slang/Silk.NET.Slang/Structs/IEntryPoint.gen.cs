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
    [NativeName("Name", "IEntryPoint")]
    public unsafe partial struct IEntryPoint : IComVtbl<IEntryPoint>, IComVtbl<IComponentType>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IComponentType(IEntryPoint val)
            => Unsafe.As<IEntryPoint, IComponentType>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IEntryPoint val)
            => Unsafe.As<IEntryPoint, Silk.NET.Core.Native.IUnknown>(ref val);

        public IEntryPoint
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
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ISession* GetSession()
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ISession* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, ISession*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ShaderReflection* GetLayout(long targetIndex, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderReflection* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, ShaderReflection*>)@this->LpVtbl[4])(@this, targetIndex, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly long GetSpecializationParamCount()
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            long ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCode(long entryPointIndex, long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, IBlob**, int>)@this->LpVtbl[6])(@this, entryPointIndex, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, IMutableFileSystem** outFileSystem)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResultAsFileSystem(long entryPointIndex, long targetIndex, ref IMutableFileSystem* outFileSystem)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMutableFileSystem** outFileSystemPtr = &outFileSystem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMutableFileSystem**, int>)@this->LpVtbl[7])(@this, entryPointIndex, targetIndex, outFileSystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, IBlob** outHash)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHash);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEntryPointHash(long entryPointIndex, long targetIndex, ref IBlob* outHash)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IBlob** outHashPtr = &outHash)
            {
                ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IBlob**, void>)@this->LpVtbl[8])(@this, entryPointIndex, targetIndex, outHashPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgs, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IComponentType** outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IComponentType* outSpecializedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IComponentType** outSpecializedComponentTypePtr = &outSpecializedComponentType)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, SpecializationArg*, long, IComponentType**, IBlob**, int>)@this->LpVtbl[9])(@this, specializationArgsPtr, specializationArgCount, outSpecializedComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(IComponentType** outLinkedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref IComponentType* outLinkedComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, IBlob**, int>)@this->LpVtbl[10])(@this, outLinkedComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibrary, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointHostCallable(int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISharedLibrary** outSharedLibraryPtr = &outSharedLibrary)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, int, int, ISharedLibrary**, IBlob**, int>)@this->LpVtbl[11])(@this, entryPointIndex, targetIndex, outSharedLibraryPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, IComponentType** outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newName, outEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, IComponentType** outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* newNamePtr = &newName)
            {
                fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, IComponentType** outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPoint);
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref IComponentType* outEntryPoint)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var newNamePtr = (byte*) SilkMarshal.StringToPtr(newName, NativeStringEncoding.UTF8);
            fixed (IComponentType** outEntryPointPtr = &outEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, byte*, IComponentType**, int>)@this->LpVtbl[12])(@this, newNamePtr, outEntryPointPtr);
            }
            SilkMarshal.Free((nint)newNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(IComponentType** outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntries, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions(ref IComponentType* outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outLinkedComponentTypePtr = &outLinkedComponentType)
            {
                fixed (CompilerOptionEntry* compilerOptionEntriesPtr = &compilerOptionEntries)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, IComponentType**, uint, CompilerOptionEntry*, IBlob**, int>)@this->LpVtbl[13])(@this, outLinkedComponentTypePtr, compilerOptionEntryCount, compilerOptionEntriesPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, IBlob** outCode, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, IBlob** outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref IBlob* outCode, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCode(long targetIndex, ref IBlob* outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IBlob**, IBlob**, int>)@this->LpVtbl[14])(@this, targetIndex, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetMetadata(long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, IMetadata**, IBlob**, int>)@this->LpVtbl[15])(@this, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, IMetadata** outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadata, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, IBlob** outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointMetadata(long entryPointIndex, long targetIndex, ref IMetadata* outMetadata, ref IBlob* outDiagnostics)
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMetadata** outMetadataPtr = &outMetadata)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, long, long, IMetadata**, IBlob**, int>)@this->LpVtbl[16])(@this, entryPointIndex, targetIndex, outMetadataPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe FunctionReflection* GetFunctionReflection()
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FunctionReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEntryPoint*, FunctionReflection*>)@this->LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Specialize<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ComPtr<TI0> outSpecializedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Specialize(in specializationArgs, specializationArgCount, (IComponentType**) outSpecializedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ComPtr<TI0> outLinkedComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((IComponentType**) outLinkedComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(in newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RenameEntryPoint<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string newName, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RenameEntryPoint(newName, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, CompilerOptionEntry* compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, compilerOptionEntries, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LinkWithOptions<TI0>(ref ComPtr<TI0> outLinkedComponentType, uint compilerOptionEntryCount, ref CompilerOptionEntry compilerOptionEntries, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (IEntryPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LinkWithOptions((IComponentType**) outLinkedComponentType.GetAddressOf(), compilerOptionEntryCount, ref compilerOptionEntries, ref outDiagnostics);
        }

    }
}

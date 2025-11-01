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
    [NativeName("Name", "ISession")]
    public unsafe partial struct ISession : IComVtbl<ISession>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(ISession val)
            => Unsafe.As<ISession, ISlangUnknown>(ref val);

        public ISession
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
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangUUID* uuid, ref void* outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, void** outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangUUID uuid, ref void* outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SlangUUID* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, SlangUUID*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IGlobalSession* GetGlobalSession()
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IGlobalSession* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IGlobalSession*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob* sourcePtr = &source)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob* sourcePtr = &source)
                    {
                        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeLayoutReflection* GetTypeLayout(TypeReflection* type, long targetIndex, LayoutRules rules, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeLayoutReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, ISlangBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeLayoutReflection* GetTypeLayout(TypeReflection* type, long targetIndex, LayoutRules rules, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeLayoutReflection* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, ISlangBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* GetContainerType(TypeReflection* elementType, ContainerType containerType, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, ISlangBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* GetContainerType(TypeReflection* elementType, ContainerType containerType, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, ISlangBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* GetDynamicType()
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeRTTIMangledName(TypeReflection* type, ISlangBlob** outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeRTTIMangledName(TypeReflection* type, ref ISlangBlob* outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outNameBlobPtr = &outNameBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessMangledName(TypeReflection* type, TypeReflection* interfaceType, ISlangBlob** outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessMangledName(TypeReflection* type, TypeReflection* interfaceType, ref ISlangBlob* outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outNameBlobPtr = &outNameBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessSequentialID(TypeReflection* type, TypeReflection* interfaceType, uint* outId)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, int>)@this->LpVtbl[13])(@this, type, interfaceType, outId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessSequentialID(TypeReflection* type, TypeReflection* interfaceType, ref uint outId)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* outIdPtr = &outId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, int>)@this->LpVtbl[13])(@this, type, interfaceType, outIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompileRequest(ICompileRequest** outCompileRequest)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, ICompileRequest**, int>)@this->LpVtbl[14])(@this, outCompileRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompileRequest(ref ICompileRequest* outCompileRequest)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileRequest** outCompileRequestPtr = &outCompileRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, ICompileRequest**, int>)@this->LpVtbl[14])(@this, outCompileRequestPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeConformance** outConformancePtr = &outConformance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeConformance** outConformancePtr = &outConformance)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob* sourcePtr = &source)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob* sourcePtr = &source)
                    {
                        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly long GetLoadedModuleCount()
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            long ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, long>)@this->LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* GetLoadedModule(long index)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, long, IModule*>)@this->LpVtbl[18])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, ISlangBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, ref ISlangBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, ISlangBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (byte* modulePathPtr = &modulePath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, ref ISlangBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (byte* modulePathPtr = &modulePath)
            {
                fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, ISlangBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
            SilkMarshal.Free((nint)modulePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, ref ISlangBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
            }
            SilkMarshal.Free((nint)modulePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (byte* @stringPtr = &@string)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (byte* @stringPtr = &@string)
                    {
                        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
            SilkMarshal.Free((nint)@stringPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDynamicObjectRTTIBytes(TypeReflection* type, TypeReflection* interfaceType, uint* outRTTIDataBuffer, uint bufferSizeInBytes)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, uint, int>)@this->LpVtbl[21])(@this, type, interfaceType, outRTTIDataBuffer, bufferSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDynamicObjectRTTIBytes(TypeReflection* type, TypeReflection* interfaceType, ref uint outRTTIDataBuffer, uint bufferSizeInBytes)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* outRTTIDataBufferPtr = &outRTTIDataBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, uint, int>)@this->LpVtbl[21])(@this, type, interfaceType, outRTTIDataBufferPtr, bufferSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersion, outModuleCompilerVersion, outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** outModuleNamePtr = &outModuleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersion, outModuleCompilerVersion, outModuleNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersion, outModuleCompilerVersionPtr, outModuleName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
            {
                fixed (byte** outModuleNamePtr = &outModuleName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersion, outModuleCompilerVersionPtr, outModuleNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* outModuleVersionPtr = &outModuleVersion)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersionPtr, outModuleCompilerVersion, outModuleName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* outModuleVersionPtr = &outModuleVersion)
            {
                fixed (byte** outModuleNamePtr = &outModuleName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersionPtr, outModuleCompilerVersion, outModuleNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* outModuleVersionPtr = &outModuleVersion)
            {
                fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersionPtr, outModuleCompilerVersionPtr, outModuleName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* outModuleVersionPtr = &outModuleVersion)
            {
                fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                {
                    fixed (byte** outModuleNamePtr = &outModuleName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, source, outModuleVersionPtr, outModuleCompilerVersionPtr, outModuleNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersion, outModuleCompilerVersion, outModuleName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (byte** outModuleNamePtr = &outModuleName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersion, outModuleCompilerVersion, outModuleNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersion, outModuleCompilerVersionPtr, outModuleName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                {
                    fixed (byte** outModuleNamePtr = &outModuleName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersion, outModuleCompilerVersionPtr, outModuleNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (long* outModuleVersionPtr = &outModuleVersion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersionPtr, outModuleCompilerVersion, outModuleName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (long* outModuleVersionPtr = &outModuleVersion)
                {
                    fixed (byte** outModuleNamePtr = &outModuleName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersionPtr, outModuleCompilerVersion, outModuleNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (long* outModuleVersionPtr = &outModuleVersion)
                {
                    fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersionPtr, outModuleCompilerVersionPtr, outModuleName);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (long* outModuleVersionPtr = &outModuleVersion)
                {
                    fixed (byte** outModuleCompilerVersionPtr = &outModuleCompilerVersion)
                    {
                        fixed (byte** outModuleNamePtr = &outModuleName)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, ISlangBlob*, long*, byte**, byte**, int>)@this->LpVtbl[22])(@this, sourcePtr, outModuleVersionPtr, outModuleCompilerVersionPtr, outModuleNamePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, outModuleVersion, outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, outModuleVersion, outModuleCompilerVersion, in outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, outModuleVersion, in outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, ref outModuleVersion, outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, ref outModuleVersion, outModuleCompilerVersion, in outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ISlangBlob* source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(source, ref outModuleVersion, in outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, outModuleVersion, outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, outModuleVersion, outModuleCompilerVersion, in outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, outModuleVersion, in outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, ref outModuleVersion, outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleCompilerVersionSa, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleName)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleCompilerVersion = (byte**) SilkMarshal.StringArrayToPtr(outModuleCompilerVersionSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, ref outModuleVersion, outModuleCompilerVersion, in outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleCompilerVersion, outModuleCompilerVersionSa);
            SilkMarshal.Free((nint) outModuleCompilerVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModuleInfoFromIRBlob(ref ISlangBlob source, ref long outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] outModuleNameSa)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var outModuleName = (byte**) SilkMarshal.StringArrayToPtr(outModuleNameSa);
            var ret = @this->LoadModuleInfoFromIRBlob(ref source, ref outModuleVersion, in outModuleCompilerVersion, outModuleName);
            SilkMarshal.CopyPtrToStringArray((nint) outModuleName, outModuleNameSa);
            SilkMarshal.Free((nint) outModuleName);
            return ret;
        }

    }
}

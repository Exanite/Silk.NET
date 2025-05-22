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
    public unsafe partial struct ISession : IComVtbl<ISession>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ISession val)
            => Unsafe.As<ISession, Silk.NET.Core.Native.IUnknown>(ref val);

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
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
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
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob* sourcePtr = &source)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob* sourcePtr = &source)
                    {
                        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IComponentType** componentTypesPtr = &componentTypes)
            {
                fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, IBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, IBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, IBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, IBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* SpecializeType(TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, IBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeLayoutReflection* GetTypeLayout(TypeReflection* type, long targetIndex, LayoutRules rules, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeLayoutReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, IBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeLayoutReflection* GetTypeLayout(TypeReflection* type, long targetIndex, LayoutRules rules, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeLayoutReflection* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, IBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* GetContainerType(TypeReflection* elementType, ContainerType containerType, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, IBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe TypeReflection* GetContainerType(TypeReflection* elementType, ContainerType containerType, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TypeReflection* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, IBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnosticsPtr);
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
        public readonly unsafe int GetTypeRTTIMangledName(TypeReflection* type, IBlob** outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, IBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeRTTIMangledName(TypeReflection* type, ref IBlob* outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outNameBlobPtr = &outNameBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, IBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessMangledName(TypeReflection* type, TypeReflection* interfaceType, IBlob** outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, IBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeConformanceWitnessMangledName(TypeReflection* type, TypeReflection* interfaceType, ref IBlob* outNameBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outNameBlobPtr = &outNameBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, IBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlobPtr);
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
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, IBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, IBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeConformance** outConformancePtr = &outConformance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, IBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeConformanceComponentType(TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeConformance** outConformancePtr = &outConformance)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, IBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob* sourcePtr = &source)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob* sourcePtr = &source)
                    {
                        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob* sourcePtr = &source)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromIRBlob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob source, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob* sourcePtr = &source)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, IBlob*, IBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
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
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, IBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, ref IBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (IBlob* binaryModuleBlobPtr = &binaryModuleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, IBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (byte* modulePathPtr = &modulePath)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, ref IBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            fixed (byte* modulePathPtr = &modulePath)
            {
                fixed (IBlob* binaryModuleBlobPtr = &binaryModuleBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, IBlob* binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
            SilkMarshal.Free((nint)modulePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly bool IsBinaryModuleUpToDate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, ref IBlob binaryModuleBlob)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
            fixed (IBlob* binaryModuleBlobPtr = &binaryModuleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, IBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
            }
            SilkMarshal.Free((nint)modulePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* @stringPtr = &@string)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (byte* @stringPtr = &@string)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
                    fixed (byte* @stringPtr = &@string)
                    {
                        fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
                fixed (byte* pathPtr = &path)
                {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
            SilkMarshal.Free((nint)@stringPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            fixed (byte* moduleNamePtr = &moduleName)
            {
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            fixed (byte* pathPtr = &path)
            {
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            SilkMarshal.Free((nint)@stringPtr);
            }
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, IBlob** outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IModule* LoadModuleFromSourceString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref IBlob* outDiagnostics)
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IModule* ret = default;
            var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, IBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            SilkMarshal.Free((nint)pathPtr);
            SilkMarshal.Free((nint)moduleNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, IBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeComponentType<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, ref IBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            var @this = (ISession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
        }

    }
}

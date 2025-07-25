// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/strsafe.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyExA"]/*'/>

    public static HResult StringCbCopyExA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc,
        [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        nuint cchDest = cbDest / 1;
        hr = StringExValidateDestA(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (Succeeded(hr))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            hr = StringExValidateSrcA(&pszSrc, null, STRSAFE_MAX_CCH, dwFlags);
            if (Succeeded(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (*pszSrc != (sbyte)('\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;
                    hr = StringCopyWorkerA(
                        pszDest,
                        cchDest,
                        &cchCopied,
                        pszSrc,
                        (STRSAFE_MAX_CCH - 1)
                    );
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (
                        Succeeded(hr)
                        && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0
                        && unchecked(cchRemaining > 1)
                    )
                    {
                        nuint cbRemaining;
                        cbRemaining = unchecked(
                            (cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte))
                        );
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }
            if (
                Failed(hr)
                && (
                    dwFlags
                    & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)
                ) != 0
                && (cbDest != 0)
            )
            {
                _ = StringExHandleOtherFlagsA(
                    pszDest,
                    cbDest,
                    0,
                    &pszDestEnd,
                    &cchRemaining,
                    dwFlags
                );
            }
            if (Succeeded(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }
                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked(
                        (cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte))
                    );
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = (sbyte)('\0');
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCbCopyExA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_LPCSTR")] Ref<sbyte> pszSrc,
        [NativeTypeName("STRSAFE_LPSTR *")] Ref2D<sbyte> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcbRemaining = pcbRemaining)
        fixed (sbyte** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (sbyte* __dsl_pszSrc = pszSrc)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCbCopyExA(
                __dsl_pszDest,
                cbDest,
                __dsl_pszSrc,
                __dsl_ppszDestEnd,
                __dsl_pcbRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyExW"]/*'/>

    public static HResult StringCbCopyExW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc,
        [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        nuint cchDest = cbDest / 2;
        hr = StringExValidateDestW(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (Succeeded(hr))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            hr = StringExValidateSrcW(&pszSrc, null, STRSAFE_MAX_CCH, dwFlags);
            if (Succeeded(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (*pszSrc != '\0')
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;
                    hr = StringCopyWorkerW(
                        pszDest,
                        cchDest,
                        &cchCopied,
                        pszSrc,
                        (STRSAFE_MAX_CCH - 1)
                    );
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (Succeeded(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0)
                    {
                        nuint cbRemaining;
                        cbRemaining = unchecked(
                            (cchRemaining * sizeof(char)) + (cbDest % sizeof(char))
                        );
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = '\0';
                }
            }
            if (
                Failed(hr)
                && (
                    dwFlags
                    & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)
                ) != 0
                && (cbDest != 0)
            )
            {
                _ = StringExHandleOtherFlagsW(
                    pszDest,
                    cbDest,
                    0,
                    &pszDestEnd,
                    &cchRemaining,
                    dwFlags
                );
            }
            if (Succeeded(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }
                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked(
                        (cchRemaining * sizeof(char)) + (cbDest % sizeof(char))
                    );
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = '\0';
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCbCopyExW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_LPCWSTR")] Ref<char> pszSrc,
        [NativeTypeName("STRSAFE_LPWSTR *")] Ref2D<char> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcbRemaining = pcbRemaining)
        fixed (char** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (char* __dsl_pszSrc = pszSrc)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCbCopyExW(
                __dsl_pszDest,
                cbDest,
                __dsl_pszSrc,
                __dsl_ppszDestEnd,
                __dsl_pcbRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyNExA"]/*'/>

    public static HResult StringCbCopyNExA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc,
        [NativeTypeName("size_t")] nuint cbToCopy,
        [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        nuint cchDest = cbDest / 1;
        hr = StringExValidateDestA(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (Succeeded(hr))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            nuint cchToCopy = cbToCopy / 1;
            hr = StringExValidateSrcA(&pszSrc, &cchToCopy, STRSAFE_MAX_CCH, dwFlags);
            if (Succeeded(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (unchecked(cchToCopy != 0) && (*pszSrc != (sbyte)('\0')))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;
                    hr = StringCopyWorkerA(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (
                        Succeeded(hr)
                        && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0
                        && unchecked(cchRemaining > 1)
                    )
                    {
                        nuint cbRemaining;
                        cbRemaining = unchecked(
                            (cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte))
                        );
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }
            if (
                Failed(hr)
                && (
                    dwFlags
                    & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)
                ) != 0
                && (cbDest != 0)
            )
            {
                _ = StringExHandleOtherFlagsA(
                    pszDest,
                    cbDest,
                    0,
                    &pszDestEnd,
                    &cchRemaining,
                    dwFlags
                );
            }
            if (Succeeded(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }
                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked(
                        (cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte))
                    );
                }
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCbCopyNExA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_PCNZCH")] Ref<sbyte> pszSrc,
        [NativeTypeName("size_t")] nuint cbToCopy,
        [NativeTypeName("STRSAFE_LPSTR *")] Ref2D<sbyte> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcbRemaining = pcbRemaining)
        fixed (sbyte** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (sbyte* __dsl_pszSrc = pszSrc)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCbCopyNExA(
                __dsl_pszDest,
                cbDest,
                __dsl_pszSrc,
                cbToCopy,
                __dsl_ppszDestEnd,
                __dsl_pcbRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyNExW"]/*'/>

    public static HResult StringCbCopyNExW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc,
        [NativeTypeName("size_t")] nuint cbToCopy,
        [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        nuint cchDest = cbDest / 2;
        hr = StringExValidateDestW(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (Succeeded(hr))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            nuint cchToCopy = cbToCopy / 2;
            hr = StringExValidateSrcW(&pszSrc, &cchToCopy, STRSAFE_MAX_CCH, dwFlags);
            if (Succeeded(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (unchecked(cchToCopy != 0) && (*pszSrc != '\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;
                    hr = StringCopyWorkerW(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (Succeeded(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0)
                    {
                        nuint cbRemaining;
                        cbRemaining = unchecked(
                            (cchRemaining * sizeof(char)) + (cbDest % sizeof(char))
                        );
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = '\0';
                }
            }
            if (
                Failed(hr)
                && (
                    dwFlags
                    & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)
                ) != 0
                && (cbDest != 0)
            )
            {
                _ = StringExHandleOtherFlagsW(
                    pszDest,
                    cbDest,
                    0,
                    &pszDestEnd,
                    &cchRemaining,
                    dwFlags
                );
            }
            if (Succeeded(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }
                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked(
                        (cchRemaining * sizeof(char)) + (cbDest % sizeof(char))
                    );
                }
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCbCopyNExW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("STRSAFE_PCNZWCH")] Ref<char> pszSrc,
        [NativeTypeName("size_t")] nuint cbToCopy,
        [NativeTypeName("STRSAFE_LPWSTR *")] Ref2D<char> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcbRemaining = pcbRemaining)
        fixed (char** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (char* __dsl_pszSrc = pszSrc)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCbCopyNExW(
                __dsl_pszDest,
                cbDest,
                __dsl_pszSrc,
                cbToCopy,
                __dsl_ppszDestEnd,
                __dsl_pcbRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCopyWorkerA"]/*'/>

    public static HResult StringCopyWorkerA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchNewDestLength,
        [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc,
        [NativeTypeName("size_t")] nuint cchToCopy
    )
    {
        HResult hr = S_OK;
        nuint cchNewDestLength = 0;
        while ((cchDest) != 0 && (cchToCopy) != 0 && (*pszSrc != '\0'))
        {
            *pszDest++ = *pszSrc++;
            cchDest--;
            cchToCopy--;
            cchNewDestLength++;
        }
        if (cchDest == 0)
        {
            pszDest--;
            cchNewDestLength--;
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        *pszDest = (sbyte)('\0');
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCopyWorkerA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchNewDestLength,
        [NativeTypeName("STRSAFE_PCNZCH")] Ref<sbyte> pszSrc,
        [NativeTypeName("size_t")] nuint cchToCopy
    )
    {
        fixed (sbyte* __dsl_pszSrc = pszSrc)
        fixed (nuint* __dsl_pcchNewDestLength = pcchNewDestLength)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCopyWorkerA(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchNewDestLength,
                __dsl_pszSrc,
                cchToCopy
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCopyWorkerW"]/*'/>

    public static HResult StringCopyWorkerW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchNewDestLength,
        [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc,
        [NativeTypeName("size_t")] nuint cchToCopy
    )
    {
        HResult hr = S_OK;
        nuint cchNewDestLength = 0;
        while ((cchDest) != 0 && (cchToCopy) != 0 && (*pszSrc != '\0'))
        {
            *pszDest++ = *pszSrc++;
            cchDest--;
            cchToCopy--;
            cchNewDestLength++;
        }
        if (cchDest == 0)
        {
            pszDest--;
            cchNewDestLength--;
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        *pszDest = '\0';
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringCopyWorkerW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchNewDestLength,
        [NativeTypeName("STRSAFE_PCNZWCH")] Ref<char> pszSrc,
        [NativeTypeName("size_t")] nuint cchToCopy
    )
    {
        fixed (char* __dsl_pszSrc = pszSrc)
        fixed (nuint* __dsl_pcchNewDestLength = pcchNewDestLength)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringCopyWorkerW(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchNewDestLength,
                __dsl_pszSrc,
                cchToCopy
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExHandleFillBehindNullA"]/*'/>

    public static HResult StringExHandleFillBehindNullA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDestEnd,
        [NativeTypeName("size_t")] nuint cbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        if (cbRemaining > unchecked(sizeof(sbyte)))
        {
            NativeMemory.Fill(
                pszDestEnd + 1,
                cbRemaining - sizeof(sbyte),
                unchecked((byte)(dwFlags & 0x000000FF))
            );
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExHandleFillBehindNullA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDestEnd,
        [NativeTypeName("size_t")] nuint cbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (sbyte* __dsl_pszDestEnd = pszDestEnd)
        {
            return (HResult)StringExHandleFillBehindNullA(__dsl_pszDestEnd, cbRemaining, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExHandleFillBehindNullW"]/*'/>

    public static HResult StringExHandleFillBehindNullW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDestEnd,
        [NativeTypeName("size_t")] nuint cbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        if (cbRemaining > unchecked(sizeof(char)))
        {
            NativeMemory.Fill(
                pszDestEnd + 1,
                cbRemaining - sizeof(char),
                unchecked((byte)(dwFlags & 0x000000FF))
            );
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExHandleFillBehindNullW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDestEnd,
        [NativeTypeName("size_t")] nuint cbRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (char* __dsl_pszDestEnd = pszDestEnd)
        {
            return (HResult)StringExHandleFillBehindNullW(__dsl_pszDestEnd, cbRemaining, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExHandleOtherFlagsA"]/*'/>

    public static HResult StringExHandleOtherFlagsA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("size_t")] nuint cchOriginalDestLength,
        [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcchRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        nuint cchDest = cbDest / 1;
        Debug.Assert(
            (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE))
                != 0
        );
        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NO_TRUNCATION) != 0)
        {
            sbyte* pszOriginalDestEnd;
            pszOriginalDestEnd = pszDest + cchOriginalDestLength;
            *ppszDestEnd = pszOriginalDestEnd;
            *pcchRemaining = unchecked(cchDest - cchOriginalDestLength);
            *pszOriginalDestEnd = (sbyte)('\0');
        }
        if ((dwFlags & STRSAFE_FILL_ON_FAILURE) != 0)
        {
            NativeMemory.Fill(pszDest, cbDest, unchecked((byte)(dwFlags & 0x000000FF)));
            if (((byte)(dwFlags & 0x000000FF)) == 0)
            {
                *ppszDestEnd = pszDest;
                *pcchRemaining = unchecked(cchDest);
                Debug.Assert(*pszDest == '\0');
            }
            else if (unchecked(cchDest) > 0)
            {
                sbyte* pszDestEnd;
                pszDestEnd = pszDest + cchDest - 1;
                *ppszDestEnd = pszDestEnd;
                *pcchRemaining = 1;
                *pszDestEnd = (sbyte)('\0');
            }
        }
        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NULL_ON_FAILURE) != 0)
        {
            *ppszDestEnd = pszDest;
            *pcchRemaining = unchecked(cchDest);
            *pszDest = (sbyte)('\0');
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExHandleOtherFlagsA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("size_t")] nuint cchOriginalDestLength,
        [NativeTypeName("STRSAFE_LPSTR *")] Ref2D<sbyte> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcchRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchRemaining = pcchRemaining)
        fixed (sbyte** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExHandleOtherFlagsA(
                __dsl_pszDest,
                cbDest,
                cchOriginalDestLength,
                __dsl_ppszDestEnd,
                __dsl_pcchRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExHandleOtherFlagsW"]/*'/>

    public static HResult StringExHandleOtherFlagsW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("size_t")] nuint cchOriginalDestLength,
        [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd,
        [NativeTypeName("size_t *")] nuint* pcchRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        nuint cchDest = cbDest / 2;
        Debug.Assert(
            (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE))
                != 0
        );
        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NO_TRUNCATION) != 0)
        {
            char* pszOriginalDestEnd;
            pszOriginalDestEnd = pszDest + cchOriginalDestLength;
            *ppszDestEnd = pszOriginalDestEnd;
            *pcchRemaining = unchecked(cchDest - cchOriginalDestLength);
            *pszOriginalDestEnd = '\0';
        }
        if ((dwFlags & STRSAFE_FILL_ON_FAILURE) != 0)
        {
            NativeMemory.Fill(pszDest, cbDest, unchecked((byte)(dwFlags & 0x000000FF)));
            if (((byte)(dwFlags & 0x000000FF)) == 0)
            {
                *ppszDestEnd = pszDest;
                *pcchRemaining = unchecked(cchDest);
                Debug.Assert(cchDest == 0 || *pszDest == '\0');
            }
            else if (unchecked(cchDest) > 0)
            {
                char* pszDestEnd;
                pszDestEnd = pszDest + cchDest - 1;
                *ppszDestEnd = pszDestEnd;
                *pcchRemaining = 1;
                *pszDestEnd = '\0';
            }
        }
        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NULL_ON_FAILURE) != 0)
        {
            *ppszDestEnd = pszDest;
            *pcchRemaining = unchecked(cchDest);
            *pszDest = '\0';
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExHandleOtherFlagsW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cbDest,
        [NativeTypeName("size_t")] nuint cchOriginalDestLength,
        [NativeTypeName("STRSAFE_LPWSTR *")] Ref2D<char> ppszDestEnd,
        [NativeTypeName("size_t *")] Ref<nuint> pcchRemaining,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchRemaining = pcchRemaining)
        fixed (char** __dsl_ppszDestEnd = ppszDestEnd)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExHandleOtherFlagsW(
                __dsl_pszDest,
                cbDest,
                cchOriginalDestLength,
                __dsl_ppszDestEnd,
                __dsl_pcchRemaining,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateDestA"]/*'/>

    public static HResult StringExValidateDestA(
        [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr = S_OK;
        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            if (((pszDest == null) && (cchDest != 0)) || (cchDest > cchMax))
            {
                hr = STRSAFE_E_INVALID_PARAMETER;
            }
        }
        else
        {
            hr = StringValidateDestA(pszDest, cchDest, cchMax);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateDestA(
        [NativeTypeName("STRSAFE_PCNZCH")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExValidateDestA(__dsl_pszDest, cchDest, cchMax, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateDestAndLengthA"]/*'/>

    public static HResult StringExValidateDestAndLengthA(
        [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            hr = StringExValidateDestA(pszDest, cchDest, cchMax, dwFlags);
            if (Failed(hr) || (cchDest == 0))
            {
                *pcchDestLength = 0;
            }
            else
            {
                hr = StringLengthWorkerA(pszDest, cchDest, pcchDestLength);
            }
        }
        else
        {
            hr = StringValidateDestAndLengthA(pszDest, cchDest, pcchDestLength, cchMax);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateDestAndLengthA(
        [NativeTypeName("STRSAFE_LPCSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchDestLength = pcchDestLength)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExValidateDestAndLengthA(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchDestLength,
                cchMax,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateDestAndLengthW"]/*'/>

    public static HResult StringExValidateDestAndLengthW(
        [NativeTypeName("STRSAFE_LPCWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr;
        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            hr = StringExValidateDestW(pszDest, cchDest, cchMax, dwFlags);
            if (Failed(hr) || (cchDest == 0))
            {
                *pcchDestLength = 0;
            }
            else
            {
                hr = StringLengthWorkerW(pszDest, cchDest, pcchDestLength);
            }
        }
        else
        {
            hr = StringValidateDestAndLengthW(pszDest, cchDest, pcchDestLength, cchMax);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateDestAndLengthW(
        [NativeTypeName("STRSAFE_LPCWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchDestLength = pcchDestLength)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExValidateDestAndLengthW(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchDestLength,
                cchMax,
                dwFlags
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateDestW"]/*'/>

    public static HResult StringExValidateDestW(
        [NativeTypeName("STRSAFE_PCNZWCH")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr = S_OK;
        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            if (((pszDest == null) && (cchDest != 0)) || (cchDest > cchMax))
            {
                hr = STRSAFE_E_INVALID_PARAMETER;
            }
        }
        else
        {
            hr = StringValidateDestW(pszDest, cchDest, cchMax);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateDestW(
        [NativeTypeName("STRSAFE_PCNZWCH")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringExValidateDestW(__dsl_pszDest, cchDest, cchMax, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateSrcA"]/*'/>

    public static HResult StringExValidateSrcA(
        [NativeTypeName("STRSAFE_PCNZCH *")] sbyte** ppszSrc,
        [NativeTypeName("size_t *")] nuint* pcchToRead,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr = S_OK;
        if ((pcchToRead) != null && (*pcchToRead >= cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        else if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0 && (*ppszSrc == null))
        {
            *ppszSrc = (sbyte*)(Unsafe.AsPointer(ref MemoryMarshal.GetReference(""u8)));
            if ((pcchToRead) != null)
            {
                *pcchToRead = 0;
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateSrcA(
        [NativeTypeName("STRSAFE_PCNZCH *")] Ref2D<sbyte> ppszSrc,
        [NativeTypeName("size_t *")] Ref<nuint> pcchToRead,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchToRead = pcchToRead)
        fixed (sbyte** __dsl_ppszSrc = ppszSrc)
        {
            return (HResult)StringExValidateSrcA(__dsl_ppszSrc, __dsl_pcchToRead, cchMax, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringExValidateSrcW"]/*'/>

    public static HResult StringExValidateSrcW(
        [NativeTypeName("STRSAFE_PCNZWCH *")] char** ppszSrc,
        [NativeTypeName("size_t *")] nuint* pcchToRead,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        HResult hr = S_OK;
        if ((pcchToRead) != null && (*pcchToRead >= cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        else if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0 && (*ppszSrc == null))
        {
            *ppszSrc = (char*)(Unsafe.AsPointer(ref MemoryMarshal.GetReference(['\0'])));
            if ((pcchToRead) != null)
            {
                *pcchToRead = 0;
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringExValidateSrcW(
        [NativeTypeName("STRSAFE_PCNZWCH *")] Ref2D<char> ppszSrc,
        [NativeTypeName("size_t *")] Ref<nuint> pcchToRead,
        [NativeTypeName("const size_t")] nuint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        fixed (nuint* __dsl_pcchToRead = pcchToRead)
        fixed (char** __dsl_ppszSrc = ppszSrc)
        {
            return (HResult)StringExValidateSrcW(__dsl_ppszSrc, __dsl_pcchToRead, cchMax, dwFlags);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringGetsWorkerA"]/*'/>

    public static HResult StringGetsWorkerA(
        [NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchNewDestLength
    )
    {
        HResult hr = S_OK;
        nuint cchNewDestLength = 0;
        if (cchDest == 1)
        {
            *pszDest = (sbyte)('\0');
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        else
        {
            while (cchDest > 1)
            {
                sbyte ch;
                int i = Console.Read();
                if (i == (-1))
                {
                    if (cchNewDestLength == 0)
                    {
                        hr = STRSAFE_E_END_OF_FILE;
                    }
                    break;
                }
                ch = (sbyte)(i);
                if (ch == '\n')
                {
                    break;
                }
                *pszDest++ = ch;
                cchDest--;
                cchNewDestLength++;
            }
            *pszDest = (sbyte)('\0');
        }
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringGetsWorkerA(
        [NativeTypeName("STRSAFE_LPSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchNewDestLength
    )
    {
        fixed (nuint* __dsl_pcchNewDestLength = pcchNewDestLength)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringGetsWorkerA(__dsl_pszDest, cchDest, __dsl_pcchNewDestLength);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringGetsWorkerW"]/*'/>

    public static HResult StringGetsWorkerW(
        [NativeTypeName("STRSAFE_LPWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchNewDestLength
    )
    {
        HResult hr = S_OK;
        nuint cchNewDestLength = 0;
        if (cchDest == 1)
        {
            *pszDest = '\0';
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        else
        {
            while (cchDest > 1)
            {
                char ch = (char)(Console.Read());
                if (ch == unchecked((ushort)(0xFFFF)))
                {
                    if (cchNewDestLength == 0)
                    {
                        hr = STRSAFE_E_END_OF_FILE;
                    }
                    break;
                }
                if (ch == '\n')
                {
                    break;
                }
                *pszDest++ = ch;
                cchDest--;
                cchNewDestLength++;
            }
            *pszDest = '\0';
        }
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringGetsWorkerW(
        [NativeTypeName("STRSAFE_LPWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchNewDestLength
    )
    {
        fixed (nuint* __dsl_pcchNewDestLength = pcchNewDestLength)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringGetsWorkerW(__dsl_pszDest, cchDest, __dsl_pcchNewDestLength);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringLengthWorkerA"]/*'/>

    public static HRESULT StringLengthWorkerA(
        [NativeTypeName("STRSAFE_PCNZCH")] sbyte* psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] nuint* pcchLength
    )
    {
        HResult hr = S_OK;
        nuint cchOriginalMax = cchMax;
        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }
        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        if ((pcchLength) != null)
        {
            if (Succeeded(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT StringLengthWorkerA(
        [NativeTypeName("STRSAFE_PCNZCH")] Ref<sbyte> psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] Ref<nuint> pcchLength
    )
    {
        fixed (nuint* __dsl_pcchLength = pcchLength)
        fixed (sbyte* __dsl_psz = psz)
        {
            return (HRESULT)StringLengthWorkerA(__dsl_psz, cchMax, __dsl_pcchLength);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringLengthWorkerW"]/*'/>

    public static HResult StringLengthWorkerW(
        [NativeTypeName("STRSAFE_PCNZWCH")] char* psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] nuint* pcchLength
    )
    {
        HResult hr = S_OK;
        nuint cchOriginalMax = cchMax;
        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }
        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        if ((pcchLength) != null)
        {
            if (Succeeded(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringLengthWorkerW(
        [NativeTypeName("STRSAFE_PCNZWCH")] Ref<char> psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] Ref<nuint> pcchLength
    )
    {
        fixed (nuint* __dsl_pcchLength = pcchLength)
        fixed (char* __dsl_psz = psz)
        {
            return (HResult)StringLengthWorkerW(__dsl_psz, cchMax, __dsl_pcchLength);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringValidateDestA"]/*'/>

    public static HResult StringValidateDestA(
        [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        HResult hr = S_OK;
        if ((cchDest == 0) || (cchDest > cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringValidateDestA(
        [NativeTypeName("STRSAFE_PCNZCH")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringValidateDestA(__dsl_pszDest, cchDest, cchMax);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringValidateDestAndLengthA"]/*'/>

    public static HResult StringValidateDestAndLengthA(
        [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        HResult hr;
        hr = StringValidateDestA(pszDest, cchDest, cchMax);
        if (Succeeded(hr))
        {
            hr = StringLengthWorkerA(pszDest, cchDest, pcchDestLength);
        }
        else
        {
            *pcchDestLength = 0;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringValidateDestAndLengthA(
        [NativeTypeName("STRSAFE_LPCSTR")] Ref<sbyte> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        fixed (nuint* __dsl_pcchDestLength = pcchDestLength)
        fixed (sbyte* __dsl_pszDest = pszDest)
        {
            return (HResult)StringValidateDestAndLengthA(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchDestLength,
                cchMax
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringValidateDestAndLengthW"]/*'/>

    public static HResult StringValidateDestAndLengthW(
        [NativeTypeName("STRSAFE_LPCWSTR")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] nuint* pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        HResult hr;
        hr = StringValidateDestW(pszDest, cchDest, cchMax);
        if (Succeeded(hr))
        {
            hr = StringLengthWorkerW(pszDest, cchDest, pcchDestLength);
        }
        else
        {
            *pcchDestLength = 0;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringValidateDestAndLengthW(
        [NativeTypeName("STRSAFE_LPCWSTR")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("size_t *")] Ref<nuint> pcchDestLength,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        fixed (nuint* __dsl_pcchDestLength = pcchDestLength)
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringValidateDestAndLengthW(
                __dsl_pszDest,
                cchDest,
                __dsl_pcchDestLength,
                cchMax
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringValidateDestW"]/*'/>

    public static HResult StringValidateDestW(
        [NativeTypeName("STRSAFE_PCNZWCH")] char* pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        HResult hr = S_OK;
        if ((cchDest == 0) || (cchDest > cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult StringValidateDestW(
        [NativeTypeName("STRSAFE_PCNZWCH")] Ref<char> pszDest,
        [NativeTypeName("size_t")] nuint cchDest,
        [NativeTypeName("const size_t")] nuint cchMax
    )
    {
        fixed (char* __dsl_pszDest = pszDest)
        {
            return (HResult)StringValidateDestW(__dsl_pszDest, cchDest, cchMax);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnalignedStringLengthWorkerW"]/*'/>

    public static HResult UnalignedStringLengthWorkerW(
        [NativeTypeName("STRSAFE_PCUNZWCH")] char* psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] nuint* pcchLength
    )
    {
        HResult hr = S_OK;
        nuint cchOriginalMax = cchMax;
        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }
        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        if ((pcchLength) != null)
        {
            if (Succeeded(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult UnalignedStringLengthWorkerW(
        [NativeTypeName("STRSAFE_PCUNZWCH")] Ref<char> psz,
        [NativeTypeName("size_t")] nuint cchMax,
        [NativeTypeName("size_t *")] Ref<nuint> pcchLength
    )
    {
        fixed (nuint* __dsl_pcchLength = pcchLength)
        fixed (char* __dsl_psz = psz)
        {
            return (HResult)UnalignedStringLengthWorkerW(__dsl_psz, cchMax, __dsl_pcchLength);
        }
    }
}

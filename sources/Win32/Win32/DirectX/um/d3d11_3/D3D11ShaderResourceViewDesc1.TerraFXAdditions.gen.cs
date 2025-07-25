// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11ShaderResourceViewDesc1
{
    public D3D11_SHADER_RESOURCE_VIEW_DESC1(
        D3DSrvDimension viewDimension,
        DxgiFormat format = DxgiFormat.FormatUnknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint flags = 0,
        uint planeSlice = 0
    )
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3DSrvDimension.D11SrvDimensionBuffer:
            {
                Anonymous.Buffer.Anonymous1.FirstElement = mostDetailedMip;
                Anonymous.Buffer.Anonymous2.NumElements = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture1D:
            {
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture1Darray:
            {
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2D:
            {
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                Anonymous.Texture2D.PlaneSlice = planeSlice;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Darray:
            {
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                Anonymous.Texture2DArray.PlaneSlice = planeSlice;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Dms:
            {
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Dmsarray:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture3D:
            {
                Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture3D.MipLevels = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexturecube:
            {
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexturecubearray:
            {
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionBufferex:
            {
                Anonymous.BufferEx.FirstElement = mostDetailedMip;
                Anonymous.BufferEx.NumElements = mipLevels;
                Anonymous.BufferEx.Flags = flags;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC1(
        ID3D11Buffer* param0,
        DxgiFormat format,
        uint firstElement,
        uint numElements,
        uint flags = 0
    )
    {
        Format = format;
        ViewDimension = D3DSrvDimension.D11SrvDimensionBufferex;
        Anonymous = default;
        Anonymous.BufferEx.FirstElement = firstElement;
        Anonymous.BufferEx.NumElements = numElements;
        Anonymous.BufferEx.Flags = flags;
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC1(
        ID3D11Texture1D* pTex1D,
        D3DSrvDimension viewDimension,
        DxgiFormat format = DxgiFormat.FormatUnknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1)
    )
    {
        ViewDimension = viewDimension;
        if (
            (DxgiFormat.FormatUnknown == format)
            || (unchecked((uint)-1) == mipLevels)
            || (
                (unchecked((uint)-1) == arraySize)
                && (D3DSrvDimension.D11SrvDimensionTexture1Darray == viewDimension)
            )
        )
        {
            D3D11Texture1DDesc TexDesc;
            pTex1D->GetDesc(&TexDesc);
            if (DxgiFormat.FormatUnknown == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3DSrvDimension.D11SrvDimensionTexture1D:
            {
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture1Darray:
            {
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC1(
        ID3D11Texture2D* pTex2D,
        D3DSrvDimension viewDimension,
        DxgiFormat format = DxgiFormat.FormatUnknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint planeSlice = 0
    )
    {
        ViewDimension = viewDimension;
        if (
            (DxgiFormat.FormatUnknown == format)
            || (
                (unchecked((uint)-1) == mipLevels)
                && (D3DSrvDimension.D11SrvDimensionTexture2Dms != viewDimension)
                && (D3DSrvDimension.D11SrvDimensionTexture2Dmsarray != viewDimension)
            )
            || (
                (unchecked((uint)-1) == arraySize)
                && (
                    (D3DSrvDimension.D11SrvDimensionTexture2Darray == viewDimension)
                    || (D3DSrvDimension.D11SrvDimensionTexture2Dmsarray == viewDimension)
                    || (D3DSrvDimension.D11SrvDimensionTexturecubearray == viewDimension)
                )
            )
        )
        {
            D3D11Texture2DDesc TexDesc;
            pTex2D->GetDesc(&TexDesc);
            if (DxgiFormat.FormatUnknown == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
                if (D3DSrvDimension.D11SrvDimensionTexturecubearray == viewDimension)
                {
                    arraySize /= 6;
                }
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3DSrvDimension.D11SrvDimensionTexture2D:
            {
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                Anonymous.Texture2D.PlaneSlice = planeSlice;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Darray:
            {
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                Anonymous.Texture2DArray.PlaneSlice = planeSlice;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Dms:
            {
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexture2Dmsarray:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexturecube:
            {
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            }
            case D3DSrvDimension.D11SrvDimensionTexturecubearray:
            {
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC1(
        ID3D11Texture3D* pTex3D,
        DxgiFormat format = DxgiFormat.FormatUnknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1)
    )
    {
        ViewDimension = D3DSrvDimension.D11SrvDimensionTexture3D;
        if ((DxgiFormat.FormatUnknown == format) || (unchecked((uint)-1) == mipLevels))
        {
            D3D11Texture3DDesc TexDesc;
            pTex3D->GetDesc(&TexDesc);
            if (DxgiFormat.FormatUnknown == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
        }
        Format = format;
        Anonymous = default;
        Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
        Anonymous.Texture3D.MipLevels = mipLevels;
    }
}

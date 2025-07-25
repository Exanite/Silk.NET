// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE"]/*'/>
public enum DmlOperatorType
{
    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_INVALID"]/*'/>

    Invalid,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IDENTITY"]/*'/>

    ElementWiseIdentity,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ABS"]/*'/>

    ElementWiseAbs,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ACOS"]/*'/>

    ElementWiseAcos,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ADD"]/*'/>

    ElementWiseAdd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ASIN"]/*'/>

    ElementWiseAsin,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ATAN"]/*'/>

    ElementWiseAtan,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CEIL"]/*'/>

    ElementWiseCeil,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CLIP"]/*'/>

    ElementWiseClip,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_COS"]/*'/>

    ElementWiseCos,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_DIVIDE"]/*'/>

    ElementWiseDivide,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_EXP"]/*'/>

    ElementWiseExp,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_FLOOR"]/*'/>

    ElementWiseFloor,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOG"]/*'/>

    ElementWiseLog,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_AND"]/*'/>

    ElementWiseLogicalAnd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_EQUALS"]/*'/>

    ElementWiseLogicalEquals,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN"]/*'/>

    ElementWiseLogicalGreaterThan,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN"]/*'/>

    ElementWiseLogicalLessThan,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_NOT"]/*'/>

    ElementWiseLogicalNot,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_OR"]/*'/>

    ElementWiseLogicalOr,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_XOR"]/*'/>

    ElementWiseLogicalXor,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MAX"]/*'/>

    ElementWiseMax,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MEAN"]/*'/>

    ElementWiseMean,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MIN"]/*'/>

    ElementWiseMin,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MULTIPLY"]/*'/>

    ElementWiseMultiply,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_POW"]/*'/>

    ElementWisePow,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CONSTANT_POW"]/*'/>

    ElementWiseConstantPow,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_RECIP"]/*'/>

    ElementWiseRecip,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SIN"]/*'/>

    ElementWiseSin,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SQRT"]/*'/>

    ElementWiseSqrt,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SUBTRACT"]/*'/>

    ElementWiseSubtract,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_TAN"]/*'/>

    ElementWiseTan,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_THRESHOLD"]/*'/>

    ElementWiseThreshold,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_QUANTIZE_LINEAR"]/*'/>

    ElementWiseQuantizeLinear,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_DEQUANTIZE_LINEAR"]/*'/>

    ElementWiseDequantizeLinear,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_ELU"]/*'/>

    ActivationElu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_HARDMAX"]/*'/>

    ActivationHardmax,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_HARD_SIGMOID"]/*'/>

    ActivationHardSigmoid,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_IDENTITY"]/*'/>

    ActivationIdentity,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LEAKY_RELU"]/*'/>

    ActivationLeakyRelu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LINEAR"]/*'/>

    ActivationLinear,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LOG_SOFTMAX"]/*'/>

    ActivationLogSoftmax,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_PARAMETERIZED_RELU"]/*'/>

    ActivationParameterizedRelu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_PARAMETRIC_SOFTPLUS"]/*'/>

    ActivationParametricSoftplus,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_RELU"]/*'/>

    ActivationRelu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SCALED_ELU"]/*'/>

    ActivationScaledElu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SCALED_TANH"]/*'/>

    ActivationScaledTanh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SIGMOID"]/*'/>

    ActivationSigmoid,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTMAX"]/*'/>

    ActivationSoftmax,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTPLUS"]/*'/>

    ActivationSoftplus,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTSIGN"]/*'/>

    ActivationSoftsign,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_TANH"]/*'/>

    ActivationTanh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_THRESHOLDED_RELU"]/*'/>

    ActivationThresholdedRelu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CONVOLUTION"]/*'/>

    Convolution,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GEMM"]/*'/>

    Gemm,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_REDUCE"]/*'/>

    Reduce,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_AVERAGE_POOLING"]/*'/>

    AveragePooling,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LP_POOLING"]/*'/>

    LpPooling,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING"]/*'/>

    MaxPooling,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_POOLING"]/*'/>

    RoiPooling,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE"]/*'/>

    Slice,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CAST"]/*'/>

    Cast,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPLIT"]/*'/>

    Split,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_JOIN"]/*'/>

    Join,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_PADDING"]/*'/>

    Padding,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_VALUE_SCALE_2D"]/*'/>

    ValueScale2D,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_UPSAMPLE_2D"]/*'/>

    Upsample2D,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER"]/*'/>

    Gather,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPACE_TO_DEPTH"]/*'/>

    SpaceToDepth,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DEPTH_TO_SPACE"]/*'/>

    DepthToSpace,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TILE"]/*'/>

    Tile,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TOP_K"]/*'/>

    TopK,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_BATCH_NORMALIZATION"]/*'/>

    BatchNormalization,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION"]/*'/>

    MeanVarianceNormalization,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LOCAL_RESPONSE_NORMALIZATION"]/*'/>

    LocalResponseNormalization,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LP_NORMALIZATION"]/*'/>

    LpNormalization,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RNN"]/*'/>

    Rnn,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LSTM"]/*'/>

    Lstm,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GRU"]/*'/>

    Gru,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SIGN"]/*'/>

    ElementWiseSign,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IS_NAN"]/*'/>

    ElementWiseIsNan,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ERF"]/*'/>

    ElementWiseErf,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SINH"]/*'/>

    ElementWiseSinh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_COSH"]/*'/>

    ElementWiseCosh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_TANH"]/*'/>

    ElementWiseTanh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ASINH"]/*'/>

    ElementWiseAsinh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ACOSH"]/*'/>

    ElementWiseAcosh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ATANH"]/*'/>

    ElementWiseAtanh,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IF"]/*'/>

    ElementWiseIf,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ADD1"]/*'/>

    ElementWiseAdd1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SHRINK"]/*'/>

    ActivationShrink,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING1"]/*'/>

    MaxPooling1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_UNPOOLING"]/*'/>

    MaxUnpooling,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DIAGONAL_MATRIX"]/*'/>

    DiagonalMatrix,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER_ELEMENTS"]/*'/>

    ScatterElements,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER"]/*'/>

    Scatter = ScatterElements,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ONE_HOT"]/*'/>

    OneHot,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE"]/*'/>

    Resample,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_LEFT"]/*'/>

    ElementWiseBitShiftLeft,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_RIGHT"]/*'/>

    ElementWiseBitShiftRight,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ROUND"]/*'/>

    ElementWiseRound,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IS_INFINITY"]/*'/>

    ElementWiseIsInfinity,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MODULUS_TRUNCATE"]/*'/>

    ElementWiseModulusTruncate,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MODULUS_FLOOR"]/*'/>

    ElementWiseModulusFloor,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_FILL_VALUE_CONSTANT"]/*'/>

    FillValueConstant,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_FILL_VALUE_SEQUENCE"]/*'/>

    FillValueSequence,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CUMULATIVE_SUMMATION"]/*'/>

    CumulativeSummation,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_REVERSE_SUBSEQUENCES"]/*'/>

    ReverseSubsequences,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ELEMENTS"]/*'/>

    GatherElements,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ND"]/*'/>

    GatherNd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER_ND"]/*'/>

    ScatterNd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING2"]/*'/>

    MaxPooling2,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE1"]/*'/>

    Slice1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TOP_K1"]/*'/>

    TopK1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DEPTH_TO_SPACE1"]/*'/>

    DepthToSpace1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPACE_TO_DEPTH1"]/*'/>

    SpaceToDepth1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION1"]/*'/>

    MeanVarianceNormalization1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE1"]/*'/>

    Resample1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MATRIX_MULTIPLY_INTEGER"]/*'/>

    MatrixMultiplyInteger,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_QUANTIZED_LINEAR_MATRIX_MULTIPLY"]/*'/>

    QuantizedLinearMatrixMultiply,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CONVOLUTION_INTEGER"]/*'/>

    ConvolutionInteger,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_QUANTIZED_LINEAR_CONVOLUTION"]/*'/>

    QuantizedLinearConvolution,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_AND"]/*'/>

    ElementWiseBitAnd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_OR"]/*'/>

    ElementWiseBitOr,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_XOR"]/*'/>

    ElementWiseBitXor,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_NOT"]/*'/>

    ElementWiseBitNot,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_COUNT"]/*'/>

    ElementWiseBitCount,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN_OR_EQUAL"]/*'/>

    ElementWiseLogicalGreaterThanOrEqual,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN_OR_EQUAL"]/*'/>

    ElementWiseLogicalLessThanOrEqual,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_CELU"]/*'/>

    ActivationCelu,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_RELU_GRAD"]/*'/>

    ActivationReluGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_AVERAGE_POOLING_GRAD"]/*'/>

    AveragePoolingGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING_GRAD"]/*'/>

    MaxPoolingGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RANDOM_GENERATOR"]/*'/>

    RandomGenerator,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_NONZERO_COORDINATES"]/*'/>

    NonzeroCoordinates,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE_GRAD"]/*'/>

    ResampleGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE_GRAD"]/*'/>

    SliceGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ADAM_OPTIMIZER"]/*'/>

    AdamOptimizer,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ARGMIN"]/*'/>

    Argmin,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ARGMAX"]/*'/>

    Argmax,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_ALIGN"]/*'/>

    RoiAlign,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ND1"]/*'/>

    GatherNd1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ATAN_YX"]/*'/>

    ElementWiseAtanYx,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CLIP_GRAD"]/*'/>

    ElementWiseClipGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_DIFFERENCE_SQUARE"]/*'/>

    ElementWiseDifferenceSquare,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LOCAL_RESPONSE_NORMALIZATION_GRAD"]/*'/>

    LocalResponseNormalizationGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CUMULATIVE_PRODUCT"]/*'/>

    CumulativeProduct,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_BATCH_NORMALIZATION_GRAD"]/*'/>

    BatchNormalizationGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_QUANTIZED_LINEAR_ADD"]/*'/>

    ElementWiseQuantizedLinearAdd,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DYNAMIC_QUANTIZE_LINEAR"]/*'/>

    DynamicQuantizeLinear,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_ALIGN1"]/*'/>

    RoiAlign1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_ALIGN_GRAD"]/*'/>

    RoiAlignGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_BATCH_NORMALIZATION_TRAINING"]/*'/>

    BatchNormalizationTraining,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_BATCH_NORMALIZATION_TRAINING_GRAD"]/*'/>

    BatchNormalizationTrainingGrad,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CLIP1"]/*'/>

    ElementWiseClip1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CLIP_GRAD1"]/*'/>

    ElementWiseClipGrad1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_PADDING1"]/*'/>

    Padding1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_NEGATE"]/*'/>

    ElementWiseNegate,
}

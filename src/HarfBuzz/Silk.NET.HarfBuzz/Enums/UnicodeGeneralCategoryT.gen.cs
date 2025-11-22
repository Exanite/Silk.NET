// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-unicode_L91_C9")]
    [NativeName("Name", "hb_unicode_general_category_t")]
    public enum UnicodeGeneralCategoryT : int
    {
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_CONTROL")]
        Control = 0x0,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_FORMAT")]
        Format = 0x1,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_UNASSIGNED")]
        Unassigned = 0x2,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_PRIVATE_USE")]
        PrivateUse = 0x3,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_SURROGATE")]
        Surrogate = 0x4,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_LOWERCASE_LETTER")]
        LowercaseLetter = 0x5,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_MODIFIER_LETTER")]
        ModifierLetter = 0x6,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_OTHER_LETTER")]
        OtherLetter = 0x7,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_TITLECASE_LETTER")]
        TitlecaseLetter = 0x8,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_UPPERCASE_LETTER")]
        UppercaseLetter = 0x9,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_SPACING_MARK")]
        SpacingMark = 0xA,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_ENCLOSING_MARK")]
        EnclosingMark = 0xB,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_NON_SPACING_MARK")]
        NonSpacingMark = 0xC,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_DECIMAL_NUMBER")]
        DecimalNumber = 0xD,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_LETTER_NUMBER")]
        LetterNumber = 0xE,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_OTHER_NUMBER")]
        OtherNumber = 0xF,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_CONNECT_PUNCTUATION")]
        ConnectPunctuation = 0x10,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_DASH_PUNCTUATION")]
        DashPunctuation = 0x11,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_CLOSE_PUNCTUATION")]
        ClosePunctuation = 0x12,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_FINAL_PUNCTUATION")]
        FinalPunctuation = 0x13,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_INITIAL_PUNCTUATION")]
        InitialPunctuation = 0x14,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_OTHER_PUNCTUATION")]
        OtherPunctuation = 0x15,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_OPEN_PUNCTUATION")]
        OpenPunctuation = 0x16,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_CURRENCY_SYMBOL")]
        CurrencySymbol = 0x17,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_MODIFIER_SYMBOL")]
        ModifierSymbol = 0x18,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_MATH_SYMBOL")]
        MathSymbol = 0x19,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_OTHER_SYMBOL")]
        OtherSymbol = 0x1A,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_LINE_SEPARATOR")]
        LineSeparator = 0x1B,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_PARAGRAPH_SEPARATOR")]
        ParagraphSeparator = 0x1C,
        [NativeName("Name", "HB_UNICODE_GENERAL_CATEGORY_SPACE_SEPARATOR")]
        SpaceSeparator = 0x1D,
    }
}

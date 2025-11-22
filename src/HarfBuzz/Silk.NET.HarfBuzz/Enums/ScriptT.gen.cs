// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-script-list_L240_C9")]
    [NativeName("Name", "hb_script_t")]
    public enum ScriptT : int
    {
        [NativeName("Name", "HB_SCRIPT_COMMON")]
        ScriptCommon = 0x5A797979,
        [NativeName("Name", "HB_SCRIPT_INHERITED")]
        ScriptInherited = 0x5A696E68,
        [NativeName("Name", "HB_SCRIPT_UNKNOWN")]
        ScriptUnknown = 0x5A7A7A7A,
        [NativeName("Name", "HB_SCRIPT_ARABIC")]
        ScriptArabic = 0x41726162,
        [NativeName("Name", "HB_SCRIPT_ARMENIAN")]
        ScriptArmenian = 0x41726D6E,
        [NativeName("Name", "HB_SCRIPT_BENGALI")]
        ScriptBengali = 0x42656E67,
        [NativeName("Name", "HB_SCRIPT_CYRILLIC")]
        ScriptCyrillic = 0x4379726C,
        [NativeName("Name", "HB_SCRIPT_DEVANAGARI")]
        ScriptDevanagari = 0x44657661,
        [NativeName("Name", "HB_SCRIPT_GEORGIAN")]
        ScriptGeorgian = 0x47656F72,
        [NativeName("Name", "HB_SCRIPT_GREEK")]
        ScriptGreek = 0x4772656B,
        [NativeName("Name", "HB_SCRIPT_GUJARATI")]
        ScriptGujarati = 0x47756A72,
        [NativeName("Name", "HB_SCRIPT_GURMUKHI")]
        ScriptGurmukhi = 0x47757275,
        [NativeName("Name", "HB_SCRIPT_HANGUL")]
        ScriptHangul = 0x48616E67,
        [NativeName("Name", "HB_SCRIPT_HAN")]
        ScriptHan = 0x48616E69,
        [NativeName("Name", "HB_SCRIPT_HEBREW")]
        ScriptHebrew = 0x48656272,
        [NativeName("Name", "HB_SCRIPT_HIRAGANA")]
        ScriptHiragana = 0x48697261,
        [NativeName("Name", "HB_SCRIPT_KANNADA")]
        ScriptKannada = 0x4B6E6461,
        [NativeName("Name", "HB_SCRIPT_KATAKANA")]
        ScriptKatakana = 0x4B616E61,
        [NativeName("Name", "HB_SCRIPT_LAO")]
        ScriptLao = 0x4C616F6F,
        [NativeName("Name", "HB_SCRIPT_LATIN")]
        ScriptLatin = 0x4C61746E,
        [NativeName("Name", "HB_SCRIPT_MALAYALAM")]
        ScriptMalayalam = 0x4D6C796D,
        [NativeName("Name", "HB_SCRIPT_ORIYA")]
        ScriptOriya = 0x4F727961,
        [NativeName("Name", "HB_SCRIPT_TAMIL")]
        ScriptTamil = 0x54616D6C,
        [NativeName("Name", "HB_SCRIPT_TELUGU")]
        ScriptTelugu = 0x54656C75,
        [NativeName("Name", "HB_SCRIPT_THAI")]
        ScriptThai = 0x54686169,
        [NativeName("Name", "HB_SCRIPT_TIBETAN")]
        ScriptTibetan = 0x54696274,
        [NativeName("Name", "HB_SCRIPT_BOPOMOFO")]
        ScriptBopomofo = 0x426F706F,
        [NativeName("Name", "HB_SCRIPT_BRAILLE")]
        ScriptBraille = 0x42726169,
        [NativeName("Name", "HB_SCRIPT_CANADIAN_SYLLABICS")]
        ScriptCanadianSyllabics = 0x43616E73,
        [NativeName("Name", "HB_SCRIPT_CHEROKEE")]
        ScriptCherokee = 0x43686572,
        [NativeName("Name", "HB_SCRIPT_ETHIOPIC")]
        ScriptEthiopic = 0x45746869,
        [NativeName("Name", "HB_SCRIPT_KHMER")]
        ScriptKhmer = 0x4B686D72,
        [NativeName("Name", "HB_SCRIPT_MONGOLIAN")]
        ScriptMongolian = 0x4D6F6E67,
        [NativeName("Name", "HB_SCRIPT_MYANMAR")]
        ScriptMyanmar = 0x4D796D72,
        [NativeName("Name", "HB_SCRIPT_OGHAM")]
        ScriptOgham = 0x4F67616D,
        [NativeName("Name", "HB_SCRIPT_RUNIC")]
        ScriptRunic = 0x52756E72,
        [NativeName("Name", "HB_SCRIPT_SINHALA")]
        ScriptSinhala = 0x53696E68,
        [NativeName("Name", "HB_SCRIPT_SYRIAC")]
        ScriptSyriac = 0x53797263,
        [NativeName("Name", "HB_SCRIPT_THAANA")]
        ScriptThaana = 0x54686161,
        [NativeName("Name", "HB_SCRIPT_YI")]
        ScriptYI = 0x59696969,
        [NativeName("Name", "HB_SCRIPT_DESERET")]
        ScriptDeseret = 0x44737274,
        [NativeName("Name", "HB_SCRIPT_GOTHIC")]
        ScriptGothic = 0x476F7468,
        [NativeName("Name", "HB_SCRIPT_OLD_ITALIC")]
        ScriptOldItalic = 0x4974616C,
        [NativeName("Name", "HB_SCRIPT_BUHID")]
        ScriptBuhid = 0x42756864,
        [NativeName("Name", "HB_SCRIPT_HANUNOO")]
        ScriptHanunoo = 0x48616E6F,
        [NativeName("Name", "HB_SCRIPT_TAGALOG")]
        ScriptTagalog = 0x54676C67,
        [NativeName("Name", "HB_SCRIPT_TAGBANWA")]
        ScriptTagbanwa = 0x54616762,
        [NativeName("Name", "HB_SCRIPT_CYPRIOT")]
        ScriptCypriot = 0x43707274,
        [NativeName("Name", "HB_SCRIPT_LIMBU")]
        ScriptLimbu = 0x4C696D62,
        [NativeName("Name", "HB_SCRIPT_LINEAR_B")]
        ScriptLinearB = 0x4C696E62,
        [NativeName("Name", "HB_SCRIPT_OSMANYA")]
        ScriptOsmanya = 0x4F736D61,
        [NativeName("Name", "HB_SCRIPT_SHAVIAN")]
        ScriptShavian = 0x53686177,
        [NativeName("Name", "HB_SCRIPT_TAI_LE")]
        ScriptTaiLE = 0x54616C65,
        [NativeName("Name", "HB_SCRIPT_UGARITIC")]
        ScriptUgaritic = 0x55676172,
        [NativeName("Name", "HB_SCRIPT_BUGINESE")]
        ScriptBuginese = 0x42756769,
        [NativeName("Name", "HB_SCRIPT_COPTIC")]
        ScriptCoptic = 0x436F7074,
        [NativeName("Name", "HB_SCRIPT_GLAGOLITIC")]
        ScriptGlagolitic = 0x476C6167,
        [NativeName("Name", "HB_SCRIPT_KHAROSHTHI")]
        ScriptKharoshthi = 0x4B686172,
        [NativeName("Name", "HB_SCRIPT_NEW_TAI_LUE")]
        ScriptNewTaiLue = 0x54616C75,
        [NativeName("Name", "HB_SCRIPT_OLD_PERSIAN")]
        ScriptOldPersian = 0x5870656F,
        [NativeName("Name", "HB_SCRIPT_SYLOTI_NAGRI")]
        ScriptSylotiNagri = 0x53796C6F,
        [NativeName("Name", "HB_SCRIPT_TIFINAGH")]
        ScriptTifinagh = 0x54666E67,
        [NativeName("Name", "HB_SCRIPT_BALINESE")]
        ScriptBalinese = 0x42616C69,
        [NativeName("Name", "HB_SCRIPT_CUNEIFORM")]
        ScriptCuneiform = 0x58737578,
        [NativeName("Name", "HB_SCRIPT_NKO")]
        ScriptNko = 0x4E6B6F6F,
        [NativeName("Name", "HB_SCRIPT_PHAGS_PA")]
        ScriptPhagsPA = 0x50686167,
        [NativeName("Name", "HB_SCRIPT_PHOENICIAN")]
        ScriptPhoenician = 0x50686E78,
        [NativeName("Name", "HB_SCRIPT_CARIAN")]
        ScriptCarian = 0x43617269,
        [NativeName("Name", "HB_SCRIPT_CHAM")]
        ScriptCham = 0x4368616D,
        [NativeName("Name", "HB_SCRIPT_KAYAH_LI")]
        ScriptKayahLI = 0x4B616C69,
        [NativeName("Name", "HB_SCRIPT_LEPCHA")]
        ScriptLepcha = 0x4C657063,
        [NativeName("Name", "HB_SCRIPT_LYCIAN")]
        ScriptLycian = 0x4C796369,
        [NativeName("Name", "HB_SCRIPT_LYDIAN")]
        ScriptLydian = 0x4C796469,
        [NativeName("Name", "HB_SCRIPT_OL_CHIKI")]
        ScriptOLChiki = 0x4F6C636B,
        [NativeName("Name", "HB_SCRIPT_REJANG")]
        ScriptRejang = 0x526A6E67,
        [NativeName("Name", "HB_SCRIPT_SAURASHTRA")]
        ScriptSaurashtra = 0x53617572,
        [NativeName("Name", "HB_SCRIPT_SUNDANESE")]
        ScriptSundanese = 0x53756E64,
        [NativeName("Name", "HB_SCRIPT_VAI")]
        ScriptVai = 0x56616969,
        [NativeName("Name", "HB_SCRIPT_AVESTAN")]
        ScriptAvestan = 0x41767374,
        [NativeName("Name", "HB_SCRIPT_BAMUM")]
        ScriptBamum = 0x42616D75,
        [NativeName("Name", "HB_SCRIPT_EGYPTIAN_HIEROGLYPHS")]
        ScriptEgyptianHieroglyphs = 0x45677970,
        [NativeName("Name", "HB_SCRIPT_IMPERIAL_ARAMAIC")]
        ScriptImperialAramaic = 0x41726D69,
        [NativeName("Name", "HB_SCRIPT_INSCRIPTIONAL_PAHLAVI")]
        ScriptInscriptionalPahlavi = 0x50686C69,
        [NativeName("Name", "HB_SCRIPT_INSCRIPTIONAL_PARTHIAN")]
        ScriptInscriptionalParthian = 0x50727469,
        [NativeName("Name", "HB_SCRIPT_JAVANESE")]
        ScriptJavanese = 0x4A617661,
        [NativeName("Name", "HB_SCRIPT_KAITHI")]
        ScriptKaithi = 0x4B746869,
        [NativeName("Name", "HB_SCRIPT_LISU")]
        ScriptLisu = 0x4C697375,
        [NativeName("Name", "HB_SCRIPT_MEETEI_MAYEK")]
        ScriptMeeteiMayek = 0x4D746569,
        [NativeName("Name", "HB_SCRIPT_OLD_SOUTH_ARABIAN")]
        ScriptOldSouthArabian = 0x53617262,
        [NativeName("Name", "HB_SCRIPT_OLD_TURKIC")]
        ScriptOldTurkic = 0x4F726B68,
        [NativeName("Name", "HB_SCRIPT_SAMARITAN")]
        ScriptSamaritan = 0x53616D72,
        [NativeName("Name", "HB_SCRIPT_TAI_THAM")]
        ScriptTaiTham = 0x4C616E61,
        [NativeName("Name", "HB_SCRIPT_TAI_VIET")]
        ScriptTaiViet = 0x54617674,
        [NativeName("Name", "HB_SCRIPT_BATAK")]
        ScriptBatak = 0x4261746B,
        [NativeName("Name", "HB_SCRIPT_BRAHMI")]
        ScriptBrahmi = 0x42726168,
        [NativeName("Name", "HB_SCRIPT_MANDAIC")]
        ScriptMandaic = 0x4D616E64,
        [NativeName("Name", "HB_SCRIPT_CHAKMA")]
        ScriptChakma = 0x43616B6D,
        [NativeName("Name", "HB_SCRIPT_MEROITIC_CURSIVE")]
        ScriptMeroiticCursive = 0x4D657263,
        [NativeName("Name", "HB_SCRIPT_MEROITIC_HIEROGLYPHS")]
        ScriptMeroiticHieroglyphs = 0x4D65726F,
        [NativeName("Name", "HB_SCRIPT_MIAO")]
        ScriptMiao = 0x506C7264,
        [NativeName("Name", "HB_SCRIPT_SHARADA")]
        ScriptSharada = 0x53687264,
        [NativeName("Name", "HB_SCRIPT_SORA_SOMPENG")]
        ScriptSoraSompeng = 0x536F7261,
        [NativeName("Name", "HB_SCRIPT_TAKRI")]
        ScriptTakri = 0x54616B72,
        [NativeName("Name", "HB_SCRIPT_BASSA_VAH")]
        ScriptBassaVah = 0x42617373,
        [NativeName("Name", "HB_SCRIPT_CAUCASIAN_ALBANIAN")]
        ScriptCaucasianAlbanian = 0x41676862,
        [NativeName("Name", "HB_SCRIPT_DUPLOYAN")]
        ScriptDuployan = 0x4475706C,
        [NativeName("Name", "HB_SCRIPT_ELBASAN")]
        ScriptElbasan = 0x456C6261,
        [NativeName("Name", "HB_SCRIPT_GRANTHA")]
        ScriptGrantha = 0x4772616E,
        [NativeName("Name", "HB_SCRIPT_KHOJKI")]
        ScriptKhojki = 0x4B686F6A,
        [NativeName("Name", "HB_SCRIPT_KHUDAWADI")]
        ScriptKhudawadi = 0x53696E64,
        [NativeName("Name", "HB_SCRIPT_LINEAR_A")]
        ScriptLinearA = 0x4C696E61,
        [NativeName("Name", "HB_SCRIPT_MAHAJANI")]
        ScriptMahajani = 0x4D61686A,
        [NativeName("Name", "HB_SCRIPT_MANICHAEAN")]
        ScriptManichaean = 0x4D616E69,
        [NativeName("Name", "HB_SCRIPT_MENDE_KIKAKUI")]
        ScriptMendeKikakui = 0x4D656E64,
        [NativeName("Name", "HB_SCRIPT_MODI")]
        ScriptModi = 0x4D6F6469,
        [NativeName("Name", "HB_SCRIPT_MRO")]
        ScriptMro = 0x4D726F6F,
        [NativeName("Name", "HB_SCRIPT_NABATAEAN")]
        ScriptNabataean = 0x4E626174,
        [NativeName("Name", "HB_SCRIPT_OLD_NORTH_ARABIAN")]
        ScriptOldNorthArabian = 0x4E617262,
        [NativeName("Name", "HB_SCRIPT_OLD_PERMIC")]
        ScriptOldPermic = 0x5065726D,
        [NativeName("Name", "HB_SCRIPT_PAHAWH_HMONG")]
        ScriptPahawhHmong = 0x486D6E67,
        [NativeName("Name", "HB_SCRIPT_PALMYRENE")]
        ScriptPalmyrene = 0x50616C6D,
        [NativeName("Name", "HB_SCRIPT_PAU_CIN_HAU")]
        ScriptPauCinHau = 0x50617563,
        [NativeName("Name", "HB_SCRIPT_PSALTER_PAHLAVI")]
        ScriptPsalterPahlavi = 0x50686C70,
        [NativeName("Name", "HB_SCRIPT_SIDDHAM")]
        ScriptSiddham = 0x53696464,
        [NativeName("Name", "HB_SCRIPT_TIRHUTA")]
        ScriptTirhuta = 0x54697268,
        [NativeName("Name", "HB_SCRIPT_WARANG_CITI")]
        ScriptWarangCiti = 0x57617261,
        [NativeName("Name", "HB_SCRIPT_AHOM")]
        ScriptAhom = 0x41686F6D,
        [NativeName("Name", "HB_SCRIPT_ANATOLIAN_HIEROGLYPHS")]
        ScriptAnatolianHieroglyphs = 0x486C7577,
        [NativeName("Name", "HB_SCRIPT_HATRAN")]
        ScriptHatran = 0x48617472,
        [NativeName("Name", "HB_SCRIPT_MULTANI")]
        ScriptMultani = 0x4D756C74,
        [NativeName("Name", "HB_SCRIPT_OLD_HUNGARIAN")]
        ScriptOldHungarian = 0x48756E67,
        [NativeName("Name", "HB_SCRIPT_SIGNWRITING")]
        ScriptSignwriting = 0x53676E77,
        [NativeName("Name", "HB_SCRIPT_ADLAM")]
        ScriptAdlam = 0x41646C6D,
        [NativeName("Name", "HB_SCRIPT_BHAIKSUKI")]
        ScriptBhaiksuki = 0x42686B73,
        [NativeName("Name", "HB_SCRIPT_MARCHEN")]
        ScriptMarchen = 0x4D617263,
        [NativeName("Name", "HB_SCRIPT_OSAGE")]
        ScriptOsage = 0x4F736765,
        [NativeName("Name", "HB_SCRIPT_TANGUT")]
        ScriptTangut = 0x54616E67,
        [NativeName("Name", "HB_SCRIPT_NEWA")]
        ScriptNewa = 0x4E657761,
        [NativeName("Name", "HB_SCRIPT_MASARAM_GONDI")]
        ScriptMasaramGondi = 0x476F6E6D,
        [NativeName("Name", "HB_SCRIPT_NUSHU")]
        ScriptNushu = 0x4E736875,
        [NativeName("Name", "HB_SCRIPT_SOYOMBO")]
        ScriptSoyombo = 0x536F796F,
        [NativeName("Name", "HB_SCRIPT_ZANABAZAR_SQUARE")]
        ScriptZanabazarSquare = 0x5A616E62,
        [NativeName("Name", "HB_SCRIPT_DOGRA")]
        ScriptDogra = 0x446F6772,
        [NativeName("Name", "HB_SCRIPT_GUNJALA_GONDI")]
        ScriptGunjalaGondi = 0x476F6E67,
        [NativeName("Name", "HB_SCRIPT_HANIFI_ROHINGYA")]
        ScriptHanifiRohingya = 0x526F6867,
        [NativeName("Name", "HB_SCRIPT_MAKASAR")]
        ScriptMakasar = 0x4D616B61,
        [NativeName("Name", "HB_SCRIPT_MEDEFAIDRIN")]
        ScriptMedefaidrin = 0x4D656466,
        [NativeName("Name", "HB_SCRIPT_OLD_SOGDIAN")]
        ScriptOldSogdian = 0x536F676F,
        [NativeName("Name", "HB_SCRIPT_SOGDIAN")]
        ScriptSogdian = 0x536F6764,
        [NativeName("Name", "HB_SCRIPT_ELYMAIC")]
        ScriptElymaic = 0x456C796D,
        [NativeName("Name", "HB_SCRIPT_NANDINAGARI")]
        ScriptNandinagari = 0x4E616E64,
        [NativeName("Name", "HB_SCRIPT_NYIAKENG_PUACHUE_HMONG")]
        ScriptNyiakengPuachueHmong = 0x486D6E70,
        [NativeName("Name", "HB_SCRIPT_WANCHO")]
        ScriptWancho = 0x5763686F,
        [NativeName("Name", "HB_SCRIPT_CHORASMIAN")]
        ScriptChorasmian = 0x43687273,
        [NativeName("Name", "HB_SCRIPT_DIVES_AKURU")]
        ScriptDivesAkuru = 0x4469616B,
        [NativeName("Name", "HB_SCRIPT_KHITAN_SMALL_SCRIPT")]
        ScriptKhitanSmallScript = 0x4B697473,
        [NativeName("Name", "HB_SCRIPT_YEZIDI")]
        ScriptYezidi = 0x59657A69,
        [NativeName("Name", "HB_SCRIPT_CYPRO_MINOAN")]
        ScriptCyproMinoan = 0x43706D6E,
        [NativeName("Name", "HB_SCRIPT_OLD_UYGHUR")]
        ScriptOldUyghur = 0x4F756772,
        [NativeName("Name", "HB_SCRIPT_TANGSA")]
        ScriptTangsa = 0x546E7361,
        [NativeName("Name", "HB_SCRIPT_TOTO")]
        ScriptToto = 0x546F746F,
        [NativeName("Name", "HB_SCRIPT_VITHKUQI")]
        ScriptVithkuqi = 0x56697468,
        [NativeName("Name", "HB_SCRIPT_MATH")]
        ScriptMath = 0x5A6D7468,
        [NativeName("Name", "HB_SCRIPT_KAWI")]
        ScriptKawi = 0x4B617769,
        [NativeName("Name", "HB_SCRIPT_NAG_MUNDARI")]
        ScriptNagMundari = 0x4E61676D,
        [NativeName("Name", "HB_SCRIPT_GARAY")]
        ScriptGaray = 0x47617261,
        [NativeName("Name", "HB_SCRIPT_GURUNG_KHEMA")]
        ScriptGurungKhema = 0x47756B68,
        [NativeName("Name", "HB_SCRIPT_KIRAT_RAI")]
        ScriptKiratRai = 0x4B726169,
        [NativeName("Name", "HB_SCRIPT_OL_ONAL")]
        ScriptOLOnal = 0x4F6E616F,
        [NativeName("Name", "HB_SCRIPT_SUNUWAR")]
        ScriptSunuwar = 0x53756E75,
        [NativeName("Name", "HB_SCRIPT_TODHRI")]
        ScriptTodhri = 0x546F6472,
        [NativeName("Name", "HB_SCRIPT_TULU_TIGALARI")]
        ScriptTuluTigalari = 0x54757467,
        [NativeName("Name", "HB_SCRIPT_BERIA_ERFE")]
        ScriptBeriaErfe = 0x42657266,
        [NativeName("Name", "HB_SCRIPT_SIDETIC")]
        ScriptSidetic = 0x53696474,
        [NativeName("Name", "HB_SCRIPT_TAI_YO")]
        ScriptTaiYO = 0x5461796F,
        [NativeName("Name", "HB_SCRIPT_TOLONG_SIKI")]
        ScriptTolongSiki = 0x546F6C73,
        [NativeName("Name", "HB_SCRIPT_INVALID")]
        ScriptInvalid = 0x0,
        [NativeName("Name", "_HB_SCRIPT_MAX_VALUE")]
        ScriptMaxValue = 0x7FFFFFFF,
        [NativeName("Name", "_HB_SCRIPT_MAX_VALUE_SIGNED")]
        ScriptMaxValueSigned = 0x7FFFFFFF,
    }
}

// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace GameFrameX.Localization.Runtime
{
    /// <summary>
    /// 本地化语言代码常量类
    /// </summary>
    /// <remarks>
    /// 此类包含了各种语言的标准化语言代码常量。
    /// 语言代码遵循 ISO 639-1 语言代码标准和 ISO 3166-1 国家/地区代码标准。
    /// 格式为: [语言代码]_[国家/地区代码]，例如 "zh_CN" 表示中国大陆简体中文。
    /// </remarks>
    public static class LocalizationCode
    {
        #region 东亚地区语言代码

        /// <summary>
        /// 中文(简体)语言代码
        /// </summary>
        public const string Chinese = "zh_CN";

        /// <summary>
        /// 中文(简体)语言代码
        /// </summary>
        public const string ChineseSimplified = "zh_CN";

        /// <summary>
        /// 中文(繁体-台湾)语言代码
        /// </summary>
        public const string ChineseTraditionalTW = "zh_TW";

        /// <summary>
        /// 中文(繁体-香港)语言代码
        /// </summary>
        public const string ChineseTraditionalHK = "zh_HK";

        /// <summary>
        /// 中文(繁体-澳门)语言代码
        /// </summary>
        public const string ChineseTraditionalMO = "zh_MO";

        /// <summary>
        /// 日语语言代码
        /// </summary>
        public const string Japanese = "ja_JP";

        /// <summary>
        /// 韩语语言代码
        /// </summary>
        public const string Korean = "ko_KR";

        /// <summary>
        /// 蒙古语语言代码
        /// </summary>
        public const string Mongolian = "mn_MN";

        #endregion

        #region 英语变体语言代码

        /// <summary>
        /// 英语(美国)语言代码
        /// </summary>
        public const string English = "en_US";

        /// <summary>
        /// 英语(英国)语言代码
        /// </summary>
        public const string EnglishUK = "en_GB";

        /// <summary>
        /// 英语(澳大利亚)语言代码
        /// </summary>
        public const string EnglishAU = "en_AU";

        /// <summary>
        /// 英语(加拿大)语言代码
        /// </summary>
        public const string EnglishCA = "en_CA";

        /// <summary>
        /// 英语(爱尔兰)语言代码
        /// </summary>
        public const string EnglishIE = "en_IE";

        /// <summary>
        /// 英语(印度)语言代码
        /// </summary>
        public const string EnglishIN = "en_IN";

        /// <summary>
        /// 英语(新西兰)语言代码
        /// </summary>
        public const string EnglishNZ = "en_NZ";

        /// <summary>
        /// 英语(新加坡)语言代码
        /// </summary>
        public const string EnglishSG = "en_SG";

        /// <summary>
        /// 英语(南非)语言代码
        /// </summary>
        public const string EnglishZA = "en_ZA";

        /// <summary>
        /// 英语(菲律宾)语言代码
        /// </summary>
        public const string EnglishPH = "en_PH";

        /// <summary>
        /// 英语(马来西亚)语言代码
        /// </summary>
        public const string EnglishMY = "en_MY";

        #endregion

        #region 欧洲语言代码

        /// <summary>
        /// 法语(法国)语言代码
        /// </summary>
        public const string French = "fr_FR";

        /// <summary>
        /// 法语(比利时)语言代码
        /// </summary>
        public const string FrenchBE = "fr_BE";

        /// <summary>
        /// 法语(加拿大)语言代码
        /// </summary>
        public const string FrenchCA = "fr_CA";

        /// <summary>
        /// 法语(瑞士)语言代码
        /// </summary>
        public const string FrenchCH = "fr_CH";

        /// <summary>
        /// 法语(卢森堡)语言代码
        /// </summary>
        public const string FrenchLU = "fr_LU";

        /// <summary>
        /// 法语(摩纳哥)语言代码
        /// </summary>
        public const string FrenchMC = "fr_MC";

        /// <summary>
        /// 德语(德国)语言代码
        /// </summary>
        public const string German = "de_DE";

        /// <summary>
        /// 德语(奥地利)语言代码
        /// </summary>
        public const string GermanAT = "de_AT";

        /// <summary>
        /// 德语(瑞士)语言代码
        /// </summary>
        public const string GermanCH = "de_CH";

        /// <summary>
        /// 德语(卢森堡)语言代码
        /// </summary>
        public const string GermanLU = "de_LU";

        /// <summary>
        /// 德语(列支敦士登)语言代码
        /// </summary>
        public const string GermanLI = "de_LI";

        /// <summary>
        /// 意大利语语言代码
        /// </summary>
        public const string Italian = "it_IT";

        /// <summary>
        /// 意大利语(瑞士)语言代码
        /// </summary>
        public const string ItalianCH = "it_CH";

        /// <summary>
        /// 意大利语(圣马力诺)语言代码
        /// </summary>
        public const string ItalianSM = "it_SM";

        /// <summary>
        /// 意大利语(梵蒂冈)语言代码
        /// </summary>
        public const string ItalianVA = "it_VA";

        /// <summary>
        /// 西班牙语语言代码
        /// </summary>
        /// <summary>
        /// 西班牙语(阿根廷)语言代码
        /// </summary>
        public const string SpanishAR = "es_AR";

        /// <summary>
        /// 西班牙语(玻利维亚)语言代码
        /// </summary>
        public const string SpanishBO = "es_BO";

        /// <summary>
        /// 西班牙语(智利)语言代码
        /// </summary>
        public const string SpanishCL = "es_CL";

        /// <summary>
        /// 西班牙语(哥伦比亚)语言代码
        /// </summary>
        public const string SpanishCO = "es_CO";

        /// <summary>
        /// 西班牙语(哥斯达黎加)语言代码
        /// </summary>
        public const string SpanishCR = "es_CR";

        /// <summary>
        /// 西班牙语(多米尼加)语言代码
        /// </summary>
        public const string SpanishDO = "es_DO";

        /// <summary>
        /// 西班牙语(厄瓜多尔)语言代码
        /// </summary>
        public const string SpanishEC = "es_EC";

        /// <summary>
        /// 西班牙语(危地马拉)语言代码
        /// </summary>
        public const string SpanishGT = "es_GT";

        /// <summary>
        /// 西班牙语(洪都拉斯)语言代码
        /// </summary>
        public const string SpanishHN = "es_HN";

        /// <summary>
        /// 西班牙语(墨西哥)语言代码
        /// </summary>
        public const string SpanishMX = "es_MX";

        /// <summary>
        /// 西班牙语(尼加拉瓜)语言代码
        /// </summary>
        public const string SpanishNI = "es_NI";

        /// <summary>
        /// 西班牙语(巴拿马)语言代码
        /// </summary>
        public const string SpanishPA = "es_PA";

        /// <summary>
        /// 西班牙语(秘鲁)语言代码
        /// </summary>
        public const string SpanishPE = "es_PE";

        /// <summary>
        /// 西班牙语(波多黎各)语言代码
        /// </summary>
        public const string SpanishPR = "es_PR";

        /// <summary>
        /// 西班牙语(巴拉圭)语言代码
        /// </summary>
        public const string SpanishPY = "es_PY";

        /// <summary>
        /// 西班牙语(萨尔瓦多)语言代码
        /// </summary>
        public const string SpanishSV = "es_SV";

        /// <summary>
        /// 西班牙语(乌拉圭)语言代码
        /// </summary>
        public const string SpanishUY = "es_UY";

        /// <summary>
        /// 西班牙语(委内瑞拉)语言代码
        /// </summary>
        public const string SpanishVE = "es_VE";

        /// <summary>
        /// 西班牙语(赤道几内亚)语言代码
        /// </summary>
        public const string SpanishGQ = "es_GQ";

        /// <summary>
        /// 葡萄牙语语言代码
        /// </summary>
        public const string Portuguese = "pt_PT";

        /// <summary>
        /// 葡萄牙语(巴西)语言代码
        /// </summary>
        public const string PortugueseBR = "pt_BR";

        /// <summary>
        /// 葡萄牙语(安哥拉)语言代码
        /// </summary>
        public const string PortugueseAO = "pt_AO";

        /// <summary>
        /// 葡萄牙语(莫桑比克)语言代码
        /// </summary>
        public const string PortugueseMZ = "pt_MZ";

        /// <summary>
        /// 葡萄牙语(佛得角)语言代码
        /// </summary>
        public const string PortugueseCV = "pt_CV";

        /// <summary>
        /// 葡萄牙语(几内亚比绍)语言代码
        /// </summary>
        public const string PortugueseGW = "pt_GW";
        /// <summary>
        /// 圣多美和普林西比葡萄牙语语言代码
        /// </summary>
        public const string PortugueseST = "pt_ST";

        /// <summary>
        /// 东帝汶葡萄牙语语言代码
        /// </summary>
        public const string PortugueseTL = "pt_TL";

        /// <summary>
        /// 荷兰语(荷兰)语言代码
        /// </summary>
        public const string Dutch = "nl_NL";

        /// <summary>
        /// 荷兰语(比利时)语言代码
        /// </summary>
        public const string DutchBE = "nl_BE";

        /// <summary>
        /// 荷兰语(苏里南)语言代码
        /// </summary>
        public const string DutchSR = "nl_SR";

        /// <summary>
        /// 波兰语语言代码
        /// </summary>
        public const string Polish = "pl_PL";

        /// <summary>
        /// 捷克语语言代码
        /// </summary>
        public const string Czech = "cs_CZ";

        /// <summary>
        /// 斯洛伐克语语言代码
        /// </summary>
        public const string Slovak = "sk_SK";

        /// <summary>
        /// 匈牙利语语言代码
        /// </summary>
        public const string Hungarian = "hu_HU";

        /// <summary>
        /// 罗马尼亚语(罗马尼亚)语言代码
        /// </summary>
        public const string Romanian = "ro_RO";

        /// <summary>
        /// 罗马尼亚语(摩尔多瓦)语言代码
        /// </summary>
        public const string RomanianMD = "ro_MD";

        /// <summary>
        /// 保加利亚语语言代码
        /// </summary>
        public const string Bulgarian = "bg_BG";

        /// <summary>
        /// 克罗地亚语(克罗地亚)语言代码
        /// </summary>
        public const string Croatian = "hr_HR";

        /// <summary>
        /// 克罗地亚语(波黑)语言代码
        /// </summary>
        public const string CroatianBA = "hr_BA";

        /// <summary>
        /// 塞尔维亚语(塞尔维亚)语言代码
        /// </summary>
        public const string Serbian = "sr_RS";

        /// <summary>
        /// 塞尔维亚语(黑山)语言代码
        /// </summary>
        public const string SerbianME = "sr_ME";

        /// <summary>
        /// 斯洛文尼亚语语言代码
        /// </summary>
        public const string Slovenian = "sl_SI";

        /// <summary>
        /// 阿尔巴尼亚语(阿尔巴尼亚)语言代码
        /// </summary>
        public const string Albanian = "sq_AL";

        /// <summary>
        /// 阿尔巴尼亚语(科索沃)语言代码
        /// </summary>
        public const string AlbanianXK = "sq_XK";

        /// <summary>
        /// 马其顿语语言代码
        /// </summary>
        public const string Macedonian = "mk_MK";

        /// <summary>
        /// 波斯尼亚语语言代码
        /// </summary>
        public const string Bosnian = "bs_BA";
        #endregion

        #region 北欧语言
        /// <summary>
        /// 瑞典语(瑞典)语言代码
        /// </summary>
        public const string Swedish = "sv_SE";

        /// <summary>
        /// 瑞典语(芬兰)语言代码
        /// </summary>
        public const string SwedishFI = "sv_FI";

        /// <summary>
        /// 瑞典语(奥兰群岛)语言代码
        /// </summary>
        public const string SwedishAX = "sv_AX";

        /// <summary>
        /// 丹麦语(丹麦)语言代码
        /// </summary>
        public const string Danish = "da_DK";

        /// <summary>
        /// 丹麦语(格陵兰)语言代码
        /// </summary>
        public const string DanishGL = "da_GL";

        /// <summary>
        /// 丹麦语(法罗群岛)语言代码
        /// </summary>
        public const string DanishFO = "da_FO";

        /// <summary>
        /// 芬兰语(芬兰)语言代码
        /// </summary>
        public const string Finnish = "fi_FI";

        /// <summary>
        /// 挪威语(书面挪威语)语言代码
        /// </summary>
        public const string Norwegian = "nb_NO";

        /// <summary>
        /// 挪威语(新挪威语)语言代码
        /// </summary>
        public const string NorwegianNN = "nn_NO";

        /// <summary>
        /// 冰岛语(冰岛)语言代码
        /// </summary>
        public const string Icelandic = "is_IS";

        /// <summary>
        /// 法罗语(法罗群岛)语言代码
        /// </summary>
        public const string Faroese = "fo_FO";
        #endregion

        #region 其他欧洲语言

        /// <summary>
        /// 希腊语(希腊)语言代码
        /// </summary>
        public const string Greek = "el_GR";

        /// <summary>
        /// 希腊语(塞浦路斯)语言代码
        /// </summary>
        public const string GreekCY = "el_CY";

        /// <summary>
        /// 土耳其语(土耳其)语言代码
        /// </summary>
        public const string Turkish = "tr_TR";

        /// <summary>
        /// 土耳其语(北塞浦路斯)语言代码
        /// </summary>
        public const string TurkishCY = "tr_CY";

        /// <summary>
        /// 俄语(俄罗斯)语言代码
        /// </summary>
        public const string Russian = "ru_RU";

        /// <summary>
        /// 俄语(白俄罗斯)语言代码
        /// </summary>
        public const string RussianBY = "ru_BY";

        /// <summary>
        /// 俄语(哈萨克斯坦)语言代码
        /// </summary>
        public const string RussianKZ = "ru_KZ";

        /// <summary>
        /// 俄语(吉尔吉斯斯坦)语言代码
        /// </summary>
        public const string RussianKG = "ru_KG";

        /// <summary>
        /// 乌克兰语语言代码
        /// </summary>
        public const string Ukrainian = "uk_UA";

        /// <summary>
        /// 白俄罗斯语语言代码
        /// </summary>
        public const string Belarusian = "be_BY";

        /// <summary>
        /// 爱沙尼亚语语言代码
        /// </summary>
        public const string Estonian = "et_EE";

        /// <summary>
        /// 拉脱维亚语语言代码
        /// </summary>
        public const string Latvian = "lv_LV";

        /// <summary>
        /// 立陶宛语语言代码
        /// </summary>
        public const string Lithuanian = "lt_LT";

        /// <summary>
        /// 格鲁吉亚语语言代码
        /// </summary>
        public const string Georgian = "ka_GE";

        /// <summary>
        /// 亚美尼亚语语言代码
        /// </summary>
        public const string Armenian = "hy_AM";

        /// <summary>
        /// 阿塞拜疆语语言代码
        /// </summary>
        public const string Azerbaijani = "az_AZ";

        #endregion

        #region 中东和西亚语言

        /// <summary>
        /// 阿拉伯语(沙特阿拉伯)语言代码
        /// </summary>
        public const string Arabic = "ar_SA";

        /// <summary>
        /// 阿拉伯语(阿联酋)语言代码
        /// </summary>
        public const string ArabicAE = "ar_AE";

        /// <summary>
        /// 阿拉伯语(巴林)语言代码
        /// </summary>
        public const string ArabicBH = "ar_BH";

        /// <summary>
        /// 阿拉伯语(阿尔及利亚)语言代码
        /// </summary>
        public const string ArabicDZ = "ar_DZ";

        /// <summary>
        /// 阿拉伯语(埃及)语言代码
        /// </summary>
        public const string ArabicEG = "ar_EG";

        /// <summary>
        /// 阿拉伯语(伊拉克)语言代码
        /// </summary>
        public const string ArabicIQ = "ar_IQ";

        /// <summary>
        /// 阿拉伯语(约旦)语言代码
        /// </summary>
        public const string ArabicJO = "ar_JO";

        /// <summary>
        /// 阿拉伯语(科威特)语言代码
        /// </summary>
        public const string ArabicKW = "ar_KW";

        /// <summary>
        /// 阿拉伯语(黎巴嫩)语言代码
        /// </summary>
        public const string ArabicLB = "ar_LB";

        /// <summary>
        /// 阿拉伯语(摩洛哥)语言代码
        /// </summary>
        public const string ArabicMA = "ar_MA";

        /// <summary>
        /// 阿拉伯语(阿曼)语言代码
        /// </summary>
        public const string ArabicOM = "ar_OM";

        /// <summary>
        /// 阿拉伯语(卡塔尔)语言代码
        /// </summary>
        public const string ArabicQA = "ar_QA";

        /// <summary>
        /// 阿拉伯语(突尼斯)语言代码
        /// </summary>
        public const string ArabicTN = "ar_TN";

        /// <summary>
        /// 阿拉伯语(也门)语言代码
        /// </summary>
        public const string ArabicYE = "ar_YE";

        /// <summary>
        /// 阿拉伯语(巴勒斯坦)语言代码
        /// </summary>
        public const string ArabicPS = "ar_PS";

        /// <summary>
        /// 阿拉伯语(利比亚)语言代码
        /// </summary>
        public const string ArabicLY = "ar_LY";

        /// <summary>
        /// 希伯来语(以色列)语言代码
        /// </summary>
        public const string Hebrew = "he_IL";

        /// <summary>
        /// 希伯来语语言代码
        /// </summary>
        public const string HebrewIL = "he_IL";
        /// <summary>
        /// 波斯语(伊朗)语言代码
        /// </summary>
        public const string Persian = "fa_IR";
        /// <summary>
        /// 波斯语语言代码
        /// </summary>
        public const string PersianAF = "fa_AF";

        /// <summary>
        /// 库尔德语语言代码
        /// </summary>
        public const string Kurdish = "ku_TR";

        /// <summary>
        /// 哈萨克语语言代码
        /// </summary>
        public const string Kazakh = "kk_KZ";

        /// <summary>
        /// 波斯语语言代码
        /// </summary>
        public const string PersianPS = "fa_PS";

        /// <summary>
        /// 维吾尔语语言代码
        /// </summary>
        public const string UzbekBE = "uz_BE";

        /// <summary>
        /// 土库曼语语言代码
        /// </summary>
        public const string Turkmen = "tk_TM";

        /// <summary>
        /// 吉尔吉斯语语言代码
        /// </summary>
        public const string Kyrgyz = "ky_KG";

        /// <summary>
        /// 塔吉克语语言代码
        /// </summary>
        public const string Tajik = "tg_TJ";

        #endregion

        #region 南亚语言

        /// <summary>
        /// 印度语语言代码
        /// </summary>
        public const string Hindi = "hi_IN";

        /// <summary>
        /// 孟加拉语语言代码
        /// </summary>
        public const string Bengali = "bn_IN";

        /// <summary>
        /// 孟加拉语语言代码
        /// </summary>
        public const string BengaliBD = "bn_BD";

        /// <summary>
        /// 泰米尔语语言代码
        /// </summary>
        public const string Tamil = "ta_IN";

        /// <summary>
        /// 斯里兰卡泰米尔语语言代码
        /// </summary>
        public const string TamilLK = "ta_LK";

        /// <summary>
        /// 泰米尔语语言代码
        /// </summary>
        public const string TamilSG = "ta_SG";

        /// <summary>
        /// 泰卢固语语言代码
        /// </summary>
        public const string Telugu = "te_IN";

        /// <summary>
        /// 卡纳达语语言代码
        /// </summary>
        public const string Kannada = "kn_IN";

        /// <summary>
        /// 马拉雅拉姆语语言代码
        /// </summary>
        public const string Malayalam = "ml_IN";

        /// <summary>
        /// 马拉地语语言代码
        /// </summary>
        public const string Marathi = "mr_IN";

        /// <summary>
        /// 古吉拉特语语言代码
        /// </summary>
        public const string Gujarati = "gu_IN";

        /// <summary>
        /// 乌尔都语语言代码
        /// </summary>
        public const string Urdu = "ur_PK";

        /// <summary>
        /// 乌尔都语语言代码
        /// </summary>
        public const string UrduIN = "ur_IN";

        /// <summary>
        /// 旁遮普语语言代码
        /// </summary>
        public const string Punjabi = "pa_IN";

        /// <summary>
        /// 旁遮普语语言代码
        /// </summary>
        public const string PunjabiPK = "pa_PK";

        /// <summary>
        /// 僧伽罗语语言代码
        /// </summary>
        public const string Sinhala = "si_LK";

        /// <summary>
        /// 尼泊尔语语言代码
        /// </summary>
        public const string Nepali = "ne_NP";

        /// <summary>
        /// 阿萨姆语语言代码
        /// </summary>
        public const string Assamese = "as_IN";

        /// <summary>
        /// 奥里亚语语言代码
        /// </summary>
        public const string Odia = "or_IN";

        /// <summary>
        /// 泰国语语言代码
        /// </summary>
        public const string Thai = "th_TH";

        /// <summary>
        /// 越南语语言代码
        /// </summary>
        public const string Vietnamese = "vi_VN";

        /// <summary>
        /// 印尼语语言代码
        /// </summary>
        public const string Indonesian = "id_ID";

        /// <summary>
        /// 菲律宾语语言代码
        /// </summary>
        public const string Filipino = "tl_PH";

        /// <summary>
        /// 马来西亚语语言代码
        /// </summary>
        public const string Malaysia = "ms_MY";

        /// <summary>
        /// 文莱马来语语言代码
        /// </summary>
        public const string MalayBN = "ms_BN";

        /// <summary>
        /// 新加坡马来语语言代码
        /// </summary>
        public const string MalaySG = "ms_SG";

        /// <summary>
        /// 菲律宾语语言代码
        /// </summary>
        public const string Tagalog = "tl_PH";

        /// <summary>
        /// 缅甸语语言代码
        /// </summary>
        public const string Burmese = "my_MM";

        /// <summary>
        /// 柬埔寨语语言代码
        /// </summary>
        public const string Khmer = "km_KH";

        /// <summary>
        /// 老挝语语言代码
        /// </summary>
        public const string Lao = "lo_LA";

        /// <summary>
        /// 藏语语言代码
        /// </summary>
        public const string Tibetan = "bo_CN";

        /// <summary>
        /// 维吾尔语语言代码
        /// </summary>
        public const string Uyghur = "ug_CN";

        #endregion

        #region 非洲语言

        /// <summary>
        /// 坦桑尼亚斯瓦希里语语言代码
        /// </summary>
        public const string Swahili = "sw_TZ";

        /// <summary>
        /// 肯尼亚斯瓦希里语语言代码
        /// </summary>
        public const string SwahiliKE = "sw_KE";

        /// <summary>
        /// 阿姆哈拉语语言代码
        /// </summary>
        public const string Amharic = "am_ET";

        /// <summary>
        /// 索马里语语言代码
        /// </summary>
        public const string Somali = "so_SO";

        /// <summary>
        /// 约鲁巴语语言代码
        /// </summary>
        public const string Yoruba = "yo_NG";

        /// <summary>
        /// 伊博语语言代码
        /// </summary>
        public const string Igbo = "ig_NG";

        /// <summary>
        /// 豪萨语语言代码
        /// </summary>
        public const string Hausa = "ha_NG";

        /// <summary>
        /// 祖鲁语语言代码
        /// </summary>
        public const string Zulu = "zu_ZA";

        /// <summary>
        /// 科萨语语言代码
        /// </summary>
        public const string Xhosa = "xh_ZA";

        #endregion

        #region 大洋洲语言

        /// <summary>
        /// 毛利语语言代码
        /// </summary>
        public const string Maori = "mi_NZ";

        /// <summary>
        /// 夏威夷语语言代码
        /// </summary>
        public const string Hawaiian = "haw_US";

        /// <summary>
        /// 萨摩亚语语言代码
        /// </summary>
        public const string Samoan = "sm_WS";

        /// <summary>
        /// 汤加语语言代码
        /// </summary>
        public const string Tongan = "to_TO";

        /// <summary>
        /// 斐济语语言代码
        /// </summary>
        public const string Fijian = "fj_FJ";

        #endregion
    }
}
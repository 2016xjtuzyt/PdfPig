﻿namespace UglyToad.PdfPig.Tokenization.Tokens
{
    using System.Collections.Concurrent;

    internal partial class NameToken
    {
        private static readonly ConcurrentDictionary<string, NameToken> NameMap = new ConcurrentDictionary<string, NameToken>();

        #region A
        public static readonly NameToken A = new NameToken("A");
        public static readonly NameToken Aa = new NameToken("AA");
        public static readonly NameToken AcroForm = new NameToken("AcroForm");
        public static readonly NameToken ActualText = new NameToken("ActualText");
        public static readonly NameToken AdbePkcs7Detached = new NameToken("adbe.pkcs7.detached");
        public static readonly NameToken AdbePkcs7Sha1 = new NameToken("adbe.pkcs7.sha1");
        public static readonly NameToken AdbeX509RsaSha1 = new NameToken("adbe.x509.rsa_sha1");
        public static readonly NameToken AdobePpklite = new NameToken("Adobe.PPKLite");
        public static readonly NameToken Aesv2 = new NameToken("AESV2");
        public static readonly NameToken Aesv3 = new NameToken("AESV3");
        public static readonly NameToken After = new NameToken("After");
        public static readonly NameToken Ais = new NameToken("AIS");
        public static readonly NameToken Alt = new NameToken("Alt");
        public static readonly NameToken Alpha = new NameToken("Alpha");
        public static readonly NameToken Alternate = new NameToken("Alternate");
        public static readonly NameToken Annot = new NameToken("Annot");
        public static readonly NameToken Annots = new NameToken("Annots");
        public static readonly NameToken AntiAlias = new NameToken("AntiAlias");
        public static readonly NameToken Ap = new NameToken("AP");
        public static readonly NameToken ApRef = new NameToken("APRef");
        public static readonly NameToken App = new NameToken("App");
        public static readonly NameToken ArtBox = new NameToken("ArtBox");
        public static readonly NameToken Artifact = new NameToken("Artifact");
        public static readonly NameToken As = new NameToken("AS");
        public static readonly NameToken Ascent = new NameToken("Ascent");
        public static readonly NameToken AsciiHexDecode = new NameToken("ASCIIHexDecode");
        public static readonly NameToken AsciiHexDecodeAbbreviation = new NameToken("AHx");
        public static readonly NameToken Ascii85Decode = new NameToken("ASCII85Decode");
        public static readonly NameToken Ascii85DecodeAbbreviation = new NameToken("A85");
        public static readonly NameToken Attached = new NameToken("Attached");
        public static readonly NameToken Author = new NameToken("Author");
        public static readonly NameToken AvgWidth = new NameToken("AvgWidth");
        #endregion

        #region B

        public static readonly NameToken B = new NameToken("B");
        public static readonly NameToken Background = new NameToken("Background");
        public static readonly NameToken BaseEncoding = new NameToken("BaseEncoding");
        public static readonly NameToken BaseFont = new NameToken("BaseFont");
        public static readonly NameToken BaseState = new NameToken("BaseState");
        public static readonly NameToken Bbox = new NameToken("BBox");
        public static readonly NameToken Bc = new NameToken("BC");
        public static readonly NameToken Be = new NameToken("BE");
        public static readonly NameToken Before = new NameToken("Before");
        public static readonly NameToken Bg = new NameToken("BG");
        public static readonly NameToken BitsPerComponent = new NameToken("BitsPerComponent");
        public static readonly NameToken BitsPerCoordinate = new NameToken("BitsPerCoordinate");
        public static readonly NameToken BitsPerFlag = new NameToken("BitsPerFlag");
        public static readonly NameToken BitsPerSample = new NameToken("BitsPerSample");
        public static readonly NameToken BlackIs1 = new NameToken("BlackIs1");
        public static readonly NameToken BlackPoint = new NameToken("BlackPoint");
        public static readonly NameToken BleedBox = new NameToken("BleedBox");
        public static readonly NameToken Bm = new NameToken("BM");
        public static readonly NameToken Border = new NameToken("Border");
        public static readonly NameToken Bounds = new NameToken("Bounds");
        public static readonly NameToken Bpc = new NameToken("BPC");
        public static readonly NameToken Bs = new NameToken("BS");
        //** Acro form field type for button fields.
        public static readonly NameToken Btn = new NameToken("Btn");
        public static readonly NameToken Byterange = new NameToken("ByteRange");

        #endregion
        
        // C
        public static readonly NameToken C = new NameToken("C");
        public static readonly NameToken C0 = new NameToken("C0");
        public static readonly NameToken C1 = new NameToken("C1");
        public static readonly NameToken Ca = new NameToken("CA");
        public static readonly NameToken CaNs = new NameToken("ca");
        public static readonly NameToken Calgray = new NameToken("CalGray");
        public static readonly NameToken Calrgb = new NameToken("CalRGB");
        public static readonly NameToken Cap = new NameToken("Cap");
        public static readonly NameToken CapHeight = new NameToken("CapHeight");
        public static readonly NameToken Catalog = new NameToken("Catalog");
        public static readonly NameToken CcittfaxDecode = new NameToken("CCITTFaxDecode");
        public static readonly NameToken CcittfaxDecodeAbbreviation = new NameToken("CCF");
        public static readonly NameToken CenterWindow = new NameToken("CenterWindow");
        public static readonly NameToken Cf = new NameToken("CF");
        public static readonly NameToken Cfm = new NameToken("CFM");
        //** Acro form field type for choice fields.
        public static readonly NameToken Ch = new NameToken("Ch");
        public static readonly NameToken CharProcs = new NameToken("CharProcs");
        public static readonly NameToken CharSet = new NameToken("CharSet");
        public static readonly NameToken CiciSignit = new NameToken("CICI.SignIt");
        public static readonly NameToken CidFontType0 = new NameToken("CIDFontType0");
        public static readonly NameToken CidFontType2 = new NameToken("CIDFontType2");
        public static readonly NameToken CidToGidMap = new NameToken("CIDToGIDMap");
        public static readonly NameToken CidSet = new NameToken("CIDSet");
        public static readonly NameToken CidSystemInfo = new NameToken("CIDSystemInfo");
        public static readonly NameToken Cl = new NameToken("CL");
        public static readonly NameToken ClrF = new NameToken("ClrF");
        public static readonly NameToken ClrFf = new NameToken("ClrFf");
        public static readonly NameToken Cmap = new NameToken("CMap");
        public static readonly NameToken Cmapname = new NameToken("CMapName");
        public static readonly NameToken Cmyk = new NameToken("CMYK");
        public static readonly NameToken Co = new NameToken("CO");
        public static readonly NameToken ColorBurn = new NameToken("ColorBurn");
        public static readonly NameToken ColorDodge = new NameToken("ColorDodge");
        public static readonly NameToken Colorants = new NameToken("Colorants");
        public static readonly NameToken Colors = new NameToken("Colors");
        public static readonly NameToken Colorspace = new NameToken("ColorSpace");
        public static readonly NameToken Columns = new NameToken("Columns");
        public static readonly NameToken Compatible = new NameToken("Compatible");
        public static readonly NameToken Components = new NameToken("Components");
        public static readonly NameToken ContactInfo = new NameToken("ContactInfo");
        public static readonly NameToken Contents = new NameToken("Contents");
        public static readonly NameToken Coords = new NameToken("Coords");
        public static readonly NameToken Count = new NameToken("Count");
        public static readonly NameToken Cp = new NameToken("CP");
        public static readonly NameToken CreationDate = new NameToken("CreationDate");
        public static readonly NameToken Creator = new NameToken("Creator");
        public static readonly NameToken CropBox = new NameToken("CropBox");
        public static readonly NameToken Crypt = new NameToken("Crypt");
        public static readonly NameToken Cs = new NameToken("CS");
        // D
        public static readonly NameToken D = new NameToken("D");
        public static readonly NameToken Da = new NameToken("DA");
        public static readonly NameToken Darken = new NameToken("Darken");
        public static readonly NameToken Date = new NameToken("Date");
        public static readonly NameToken DctDecode = new NameToken("DCTDecode");
        public static readonly NameToken DctDecodeAbbreviation = new NameToken("DCT");
        public static readonly NameToken Decode = new NameToken("Decode");
        public static readonly NameToken DecodeParms = new NameToken("DecodeParms");
        public static readonly NameToken Default = new NameToken("default");
        public static readonly NameToken DefaultCmyk = new NameToken("DefaultCMYK");
        public static readonly NameToken DefaultGray = new NameToken("DefaultGray");
        public static readonly NameToken DefaultRgb = new NameToken("DefaultRGB");
        public static readonly NameToken Desc = new NameToken("Desc");
        public static readonly NameToken DescendantFonts = new NameToken("DescendantFonts");
        public static readonly NameToken Descent = new NameToken("Descent");
        public static readonly NameToken Dest = new NameToken("Dest");
        public static readonly NameToken DestOutputProfile = new NameToken("DestOutputProfile");
        public static readonly NameToken Dests = new NameToken("Dests");
        public static readonly NameToken Devicecmyk = new NameToken("DeviceCMYK");
        public static readonly NameToken Devicegray = new NameToken("DeviceGray");
        public static readonly NameToken Devicen = new NameToken("DeviceN");
        public static readonly NameToken Devicergb = new NameToken("DeviceRGB");
        public static readonly NameToken Di = new NameToken("Di");
        public static readonly NameToken Difference = new NameToken("Difference");
        public static readonly NameToken Differences = new NameToken("Differences");
        public static readonly NameToken DigestMethod = new NameToken("DigestMethod");
        public static readonly NameToken DigestRipemd160 = new NameToken("RIPEMD160");
        public static readonly NameToken DigestSha1 = new NameToken("SHA1");
        public static readonly NameToken DigestSha256 = new NameToken("SHA256");
        public static readonly NameToken DigestSha384 = new NameToken("SHA384");
        public static readonly NameToken DigestSha512 = new NameToken("SHA512");
        public static readonly NameToken Direction = new NameToken("Direction");
        public static readonly NameToken DisplayDocTitle = new NameToken("DisplayDocTitle");
        public static readonly NameToken Dl = new NameToken("DL");
        public static readonly NameToken Dm = new NameToken("Dm");
        public static readonly NameToken Doc = new NameToken("Doc");
        public static readonly NameToken DocChecksum = new NameToken("DocChecksum");
        public static readonly NameToken DocTimeStamp = new NameToken("DocTimeStamp");
        public static readonly NameToken Docmdp = new NameToken("DocMDP");
        public static readonly NameToken Domain = new NameToken("Domain");
        public static readonly NameToken Dos = new NameToken("DOS");
        public static readonly NameToken Dp = new NameToken("DP");
        public static readonly NameToken Dr = new NameToken("DR");
        public static readonly NameToken Ds = new NameToken("DS");
        public static readonly NameToken Duplex = new NameToken("Duplex");
        public static readonly NameToken Dur = new NameToken("Dur");
        public static readonly NameToken Dv = new NameToken("DV");
        public static readonly NameToken Dw = new NameToken("DW");
        public static readonly NameToken Dw2 = new NameToken("DW2");
        // E
        public static readonly NameToken E = new NameToken("E");
        public static readonly NameToken EarlyChange = new NameToken("EarlyChange");
        public static readonly NameToken Ef = new NameToken("EF");
        public static readonly NameToken EmbeddedFdfs = new NameToken("EmbeddedFDFs");
        public static readonly NameToken EmbeddedFiles = new NameToken("EmbeddedFiles");
        public static readonly NameToken Empty = new NameToken("");
        public static readonly NameToken Encode = new NameToken("Encode");
        public static readonly NameToken EncodedByteAlign = new NameToken("EncodedByteAlign");
        public static readonly NameToken Encoding = new NameToken("Encoding");
        public static readonly NameToken Encoding90MsRksjH = new NameToken("90ms-RKSJ-H");
        public static readonly NameToken Encoding90MsRksjV = new NameToken("90ms-RKSJ-V");
        public static readonly NameToken EncodingEtenB5H = new NameToken("ETen-B5-H");
        public static readonly NameToken EncodingEtenB5V = new NameToken("ETen-B5-V");
        public static readonly NameToken Encrypt = new NameToken("Encrypt");
        public static readonly NameToken EncryptMetaData = new NameToken("EncryptMetadata");
        public static readonly NameToken EndOfLine = new NameToken("EndOfLine");
        public static readonly NameToken EntrustPpkef = new NameToken("Entrust.PPKEF");
        public static readonly NameToken Exclusion = new NameToken("Exclusion");
        public static readonly NameToken ExtGState = new NameToken("ExtGState");
        public static readonly NameToken Extend = new NameToken("Extend");
        public static readonly NameToken Extends = new NameToken("Extends");
        // F
        public static readonly NameToken F = new NameToken("F");
        public static readonly NameToken FDecodeParms = new NameToken("FDecodeParms");
        public static readonly NameToken FFilter = new NameToken("FFilter");
        public static readonly NameToken Fb = new NameToken("FB");
        public static readonly NameToken Fdf = new NameToken("FDF");
        public static readonly NameToken Ff = new NameToken("Ff");
        public static readonly NameToken Fields = new NameToken("Fields");
        public static readonly NameToken Filespec = new NameToken("Filespec");
        public static readonly NameToken Filter = new NameToken("Filter");
        public static readonly NameToken First = new NameToken("First");
        public static readonly NameToken FirstChar = new NameToken("FirstChar");
        public static readonly NameToken FitWindow = new NameToken("FitWindow");
        public static readonly NameToken Fl = new NameToken("FL");
        public static readonly NameToken Flags = new NameToken("Flags");
        public static readonly NameToken FlateDecode = new NameToken("FlateDecode");
        public static readonly NameToken FlateDecodeAbbreviation = new NameToken("Fl");
        public static readonly NameToken Font = new NameToken("Font");
        public static readonly NameToken FontBbox = new NameToken("FontBBox");
        public static readonly NameToken FontDesc = new NameToken("FontDescriptor");
        public static readonly NameToken FontFamily = new NameToken("FontFamily");
        public static readonly NameToken FontFile = new NameToken("FontFile");
        public static readonly NameToken FontFile2 = new NameToken("FontFile2");
        public static readonly NameToken FontFile3 = new NameToken("FontFile3");
        public static readonly NameToken FontMatrix = new NameToken("FontMatrix");
        public static readonly NameToken FontName = new NameToken("FontName");
        public static readonly NameToken FontStretch = new NameToken("FontStretch");
        public static readonly NameToken FontWeight = new NameToken("FontWeight");
        public static readonly NameToken Form = new NameToken("Form");
        public static readonly NameToken Formtype = new NameToken("FormType");
        public static readonly NameToken Frm = new NameToken("FRM");
        public static readonly NameToken Ft = new NameToken("FT");
        public static readonly NameToken Function = new NameToken("Function");
        public static readonly NameToken FunctionType = new NameToken("FunctionType");
        public static readonly NameToken Functions = new NameToken("Functions");
        // G
        public static readonly NameToken G = new NameToken("G");
        public static readonly NameToken Gamma = new NameToken("Gamma");
        public static readonly NameToken Group = new NameToken("Group");
        public static readonly NameToken GtsPdfa1 = new NameToken("GTS_PDFA1");
        // H
        public static readonly NameToken H = new NameToken("H");
        public static readonly NameToken HardLight = new NameToken("HardLight");
        public static readonly NameToken Height = new NameToken("Height");
        public static readonly NameToken HideMenubar = new NameToken("HideMenubar");
        public static readonly NameToken HideToolbar = new NameToken("HideToolbar");
        public static readonly NameToken HideWindowui = new NameToken("HideWindowUI");
        // I
        public static readonly NameToken I = new NameToken("I");
        public static readonly NameToken Ic = new NameToken("IC");
        public static readonly NameToken Iccbased = new NameToken("ICCBased");
        public static readonly NameToken Id = new NameToken("ID");
        public static readonly NameToken IdTree = new NameToken("IDTree");
        public static readonly NameToken Identity = new NameToken("Identity");
        public static readonly NameToken IdentityH = new NameToken("Identity-H");
        public static readonly NameToken IdentityV = new NameToken("Identity-V");
        public static readonly NameToken If = new NameToken("IF");
        public static readonly NameToken Im = new NameToken("IM");
        public static readonly NameToken Image = new NameToken("Image");
        public static readonly NameToken ImageMask = new NameToken("ImageMask");
        public static readonly NameToken Index = new NameToken("Index");
        public static readonly NameToken Indexed = new NameToken("Indexed");
        public static readonly NameToken Info = new NameToken("Info");
        public static readonly NameToken Inklist = new NameToken("InkList");
        public static readonly NameToken Interpolate = new NameToken("Interpolate");
        public static readonly NameToken It = new NameToken("IT");
        public static readonly NameToken ItalicAngle = new NameToken("ItalicAngle");
        // J
        public static readonly NameToken JavaScript = new NameToken("JavaScript");
        public static readonly NameToken Jbig2Decode = new NameToken("JBIG2Decode");
        public static readonly NameToken Jbig2Globals = new NameToken("JBIG2Globals");
        public static readonly NameToken JpxDecode = new NameToken("JPXDecode");
        public static readonly NameToken Js = new NameToken("JS");
        // K
        public static readonly NameToken K = new NameToken("K");
        public static readonly NameToken Keywords = new NameToken("Keywords");
        public static readonly NameToken Kids = new NameToken("Kids");
        // L
        public static readonly NameToken L = new NameToken("L");
        public static readonly NameToken Lab = new NameToken("Lab");
        public static readonly NameToken Lang = new NameToken("Lang");
        public static readonly NameToken Last = new NameToken("Last");
        public static readonly NameToken LastChar = new NameToken("LastChar");
        public static readonly NameToken LastModified = new NameToken("LastModified");
        public static readonly NameToken Lc = new NameToken("LC");
        public static readonly NameToken Le = new NameToken("LE");
        public static readonly NameToken Leading = new NameToken("Leading");
        public static readonly NameToken LegalAttestation = new NameToken("LegalAttestation");
        public static readonly NameToken Length = new NameToken("Length");
        public static readonly NameToken Length1 = new NameToken("Length1");
        public static readonly NameToken Length2 = new NameToken("Length2");
        public static readonly NameToken Lighten = new NameToken("Lighten");
        public static readonly NameToken Limits = new NameToken("Limits");
        public static readonly NameToken Lj = new NameToken("LJ");
        public static readonly NameToken Ll = new NameToken("LL");
        public static readonly NameToken Lle = new NameToken("LLE");
        public static readonly NameToken Llo = new NameToken("LLO");
        public static readonly NameToken Location = new NameToken("Location");
        public static readonly NameToken Luminosity = new NameToken("Luminosity");
        public static readonly NameToken Lw = new NameToken("LW");
        public static readonly NameToken LzwDecode = new NameToken("LZWDecode");
        public static readonly NameToken LzwDecodeAbbreviation = new NameToken("LZW");
        // M
        public static readonly NameToken M = new NameToken("M");
        public static readonly NameToken Mac = new NameToken("Mac");
        public static readonly NameToken MacExpertEncoding = new NameToken("MacExpertEncoding");
        public static readonly NameToken MacRomanEncoding = new NameToken("MacRomanEncoding");
        public static readonly NameToken MarkInfo = new NameToken("MarkInfo");
        public static readonly NameToken Mask = new NameToken("Mask");
        public static readonly NameToken Matrix = new NameToken("Matrix");
        public static readonly NameToken MaxLen = new NameToken("MaxLen");
        public static readonly NameToken MaxWidth = new NameToken("MaxWidth");
        public static readonly NameToken Mcid = new NameToken("MCID");
        public static readonly NameToken Mdp = new NameToken("MDP");
        public static readonly NameToken MediaBox = new NameToken("MediaBox");
        public static readonly NameToken Metadata = new NameToken("Metadata");
        public static readonly NameToken MissingWidth = new NameToken("MissingWidth");
        public static readonly NameToken Mix = new NameToken("Mix");
        public static readonly NameToken Mk = new NameToken("MK");
        public static readonly NameToken Ml = new NameToken("ML");
        public static readonly NameToken MmType1 = new NameToken("MMType1");
        public static readonly NameToken ModDate = new NameToken("ModDate");
        public static readonly NameToken Multiply = new NameToken("Multiply");
        // N
        public static readonly NameToken N = new NameToken("N");
        public static readonly NameToken Name = new NameToken("Name");
        public static readonly NameToken Names = new NameToken("Names");
        public static readonly NameToken NeedAppearances = new NameToken("NeedAppearances");
        public static readonly NameToken Next = new NameToken("Next");
        public static readonly NameToken Nm = new NameToken("NM");
        public static readonly NameToken NonEfontNoWarn = new NameToken("NonEFontNoWarn");
        public static readonly NameToken NonFullScreenPageMode = new NameToken("NonFullScreenPageMode");
        public static readonly NameToken None = new NameToken("None");
        public static readonly NameToken Normal = new NameToken("Normal");
        public static readonly NameToken Nums = new NameToken("Nums");
        // O
        public static readonly NameToken O = new NameToken("O");
        public static readonly NameToken Obj = new NameToken("Obj");
        public static readonly NameToken ObjStm = new NameToken("ObjStm");
        public static readonly NameToken Oc = new NameToken("OC");
        public static readonly NameToken Ocg = new NameToken("OCG");
        public static readonly NameToken Ocgs = new NameToken("OCGs");
        public static readonly NameToken Ocproperties = new NameToken("OCProperties");
        public static readonly NameToken Oe = new NameToken("OE");

        /**
         * "OFF", to be used for OCGs, not for Acroform
         */
        public static readonly NameToken Off = new NameToken("OFF");

        /**
         * "Off", to be used for Acroform, not for OCGs
         */
        public static readonly NameToken OffAcroform = new NameToken("Off");

        public static readonly NameToken On = new NameToken("ON");
        public static readonly NameToken Op = new NameToken("OP");
        public static readonly NameToken OpNs = new NameToken("op");
        public static readonly NameToken OpenAction = new NameToken("OpenAction");
        public static readonly NameToken OpenType = new NameToken("OpenType");
        public static readonly NameToken Opm = new NameToken("OPM");
        public static readonly NameToken Opt = new NameToken("Opt");
        public static readonly NameToken Order = new NameToken("Order");
        public static readonly NameToken Ordering = new NameToken("Ordering");
        public static readonly NameToken Os = new NameToken("OS");
        public static readonly NameToken Outlines = new NameToken("Outlines");
        public static readonly NameToken OutputCondition = new NameToken("OutputCondition");
        public static readonly NameToken OutputConditionIdentifier = new NameToken("OutputConditionIdentifier");
        public static readonly NameToken OutputIntent = new NameToken("OutputIntent");
        public static readonly NameToken OutputIntents = new NameToken("OutputIntents");
        public static readonly NameToken Overlay = new NameToken("Overlay");
        // P
        public static readonly NameToken P = new NameToken("P");
        public static readonly NameToken Page = new NameToken("Page");
        public static readonly NameToken PageLabels = new NameToken("PageLabels");
        public static readonly NameToken PageLayout = new NameToken("PageLayout");
        public static readonly NameToken PageMode = new NameToken("PageMode");
        public static readonly NameToken Pages = new NameToken("Pages");
        public static readonly NameToken PaintType = new NameToken("PaintType");
        public static readonly NameToken Panose = new NameToken("Panose");
        public static readonly NameToken Params = new NameToken("Params");
        public static readonly NameToken Parent = new NameToken("Parent");
        public static readonly NameToken ParentTree = new NameToken("ParentTree");
        public static readonly NameToken ParentTreeNextKey = new NameToken("ParentTreeNextKey");
        public static readonly NameToken Pattern = new NameToken("Pattern");
        public static readonly NameToken PatternType = new NameToken("PatternType");
        public static readonly NameToken PdfDocEncoding = new NameToken("PDFDocEncoding");
        public static readonly NameToken Perms = new NameToken("Perms");
        public static readonly NameToken Pg = new NameToken("Pg");
        public static readonly NameToken PreRelease = new NameToken("PreRelease");
        public static readonly NameToken Predictor = new NameToken("Predictor");
        public static readonly NameToken Prev = new NameToken("Prev");
        public static readonly NameToken PrintArea = new NameToken("PrintArea");
        public static readonly NameToken PrintClip = new NameToken("PrintClip");
        public static readonly NameToken PrintScaling = new NameToken("PrintScaling");
        public static readonly NameToken ProcSet = new NameToken("ProcSet");
        public static readonly NameToken Process = new NameToken("Process");
        public static readonly NameToken Producer = new NameToken("Producer");
        public static readonly NameToken PropBuild = new NameToken("Prop_Build");
        public static readonly NameToken Properties = new NameToken("Properties");
        public static readonly NameToken Ps = new NameToken("PS");
        public static readonly NameToken PubSec = new NameToken("PubSec");
        // Q
        public static readonly NameToken Q = new NameToken("Q");
        public static readonly NameToken Quadpoints = new NameToken("QuadPoints");
        // R
        public static readonly NameToken R = new NameToken("R");
        public static readonly NameToken Range = new NameToken("Range");
        public static readonly NameToken Rc = new NameToken("RC");
        public static readonly NameToken Rd = new NameToken("RD");
        public static readonly NameToken Reason = new NameToken("Reason");
        public static readonly NameToken Reasons = new NameToken("Reasons");
        public static readonly NameToken Repeat = new NameToken("Repeat");
        public static readonly NameToken Recipients = new NameToken("Recipients");
        public static readonly NameToken Rect = new NameToken("Rect");
        public static readonly NameToken Registry = new NameToken("Registry");
        public static readonly NameToken RegistryName = new NameToken("RegistryName");
        public static readonly NameToken Rename = new NameToken("Rename");
        public static readonly NameToken Resources = new NameToken("Resources");
        public static readonly NameToken Rgb = new NameToken("RGB");
        public static readonly NameToken Ri = new NameToken("RI");
        public static readonly NameToken RoleMap = new NameToken("RoleMap");
        public static readonly NameToken Root = new NameToken("Root");
        public static readonly NameToken Rotate = new NameToken("Rotate");
        public static readonly NameToken Rows = new NameToken("Rows");
        public static readonly NameToken RunLengthDecode = new NameToken("RunLengthDecode");
        public static readonly NameToken RunLengthDecodeAbbreviation = new NameToken("RL");
        public static readonly NameToken Rv = new NameToken("RV");
        // S
        public static readonly NameToken S = new NameToken("S");
        public static readonly NameToken Sa = new NameToken("SA");
        public static readonly NameToken Screen = new NameToken("Screen");
        public static readonly NameToken Se = new NameToken("SE");
        public static readonly NameToken Separation = new NameToken("Separation");
        public static readonly NameToken SetF = new NameToken("SetF");
        public static readonly NameToken SetFf = new NameToken("SetFf");
        public static readonly NameToken Shading = new NameToken("Shading");
        public static readonly NameToken ShadingType = new NameToken("ShadingType");
        public static readonly NameToken Sig = new NameToken("Sig");
        public static readonly NameToken SigFlags = new NameToken("SigFlags");
        public static readonly NameToken Size = new NameToken("Size");
        public static readonly NameToken Sm = new NameToken("SM");
        public static readonly NameToken Smask = new NameToken("SMask");
        public static readonly NameToken SoftLight = new NameToken("SoftLight");
        public static readonly NameToken Sound = new NameToken("Sound");
        public static readonly NameToken Ss = new NameToken("SS");
        public static readonly NameToken St = new NameToken("St");
        public static readonly NameToken StandardEncoding = new NameToken("StandardEncoding");
        public static readonly NameToken State = new NameToken("State");
        public static readonly NameToken StateModel = new NameToken("StateModel");
        public static readonly NameToken Status = new NameToken("Status");
        public static readonly NameToken StdCf = new NameToken("StdCF");
        public static readonly NameToken StemH = new NameToken("StemH");
        public static readonly NameToken StemV = new NameToken("StemV");
        public static readonly NameToken StmF = new NameToken("StmF");
        public static readonly NameToken StrF = new NameToken("StrF");
        public static readonly NameToken StructParent = new NameToken("StructParent");
        public static readonly NameToken StructParents = new NameToken("StructParents");
        public static readonly NameToken StructTreeRoot = new NameToken("StructTreeRoot");
        public static readonly NameToken Style = new NameToken("Style");
        public static readonly NameToken SubFilter = new NameToken("SubFilter");
        public static readonly NameToken Subj = new NameToken("Subj");
        public static readonly NameToken Subject = new NameToken("Subject");
        public static readonly NameToken Subtype = new NameToken("Subtype");
        public static readonly NameToken Supplement = new NameToken("Supplement");
        public static readonly NameToken Sv = new NameToken("SV");
        public static readonly NameToken Sw = new NameToken("SW");
        public static readonly NameToken Sy = new NameToken("Sy");
        public static readonly NameToken Synchronous = new NameToken("Synchronous");
        // T
        public static readonly NameToken T = new NameToken("T");
        public static readonly NameToken Target = new NameToken("Target");
        public static readonly NameToken Templates = new NameToken("Templates");
        public static readonly NameToken Threads = new NameToken("Threads");
        public static readonly NameToken Thumb = new NameToken("Thumb");
        public static readonly NameToken Ti = new NameToken("TI");
        public static readonly NameToken TilingType = new NameToken("TilingType");
        public static readonly NameToken TimeStamp = new NameToken("TimeStamp");
        public static readonly NameToken Title = new NameToken("Title");
        public static readonly NameToken Tk = new NameToken("TK");
        public static readonly NameToken Tm = new NameToken("TM");
        public static readonly NameToken ToUnicode = new NameToken("ToUnicode");
        public static readonly NameToken Tr = new NameToken("TR");
        public static readonly NameToken Tr2 = new NameToken("TR2");
        public static readonly NameToken Trapped = new NameToken("Trapped");
        public static readonly NameToken Trans = new NameToken("Trans");
        public static readonly NameToken Transparency = new NameToken("Transparency");
        public static readonly NameToken Tref = new NameToken("TRef");
        public static readonly NameToken TrimBox = new NameToken("TrimBox");
        public static readonly NameToken TrueType = new NameToken("TrueType");
        public static readonly NameToken TrustedMode = new NameToken("TrustedMode");
        public static readonly NameToken Tu = new NameToken("TU");
        /** Acro form field type for text field. */
        public static readonly NameToken Tx = new NameToken("Tx");
        public static readonly NameToken Type = new NameToken("Type");
        public static readonly NameToken Type0 = new NameToken("Type0");
        public static readonly NameToken Type1 = new NameToken("Type1");
        public static readonly NameToken Type3 = new NameToken("Type3");
        // U
        public static readonly NameToken U = new NameToken("U");
        public static readonly NameToken Ue = new NameToken("UE");
        public static readonly NameToken Uf = new NameToken("UF");
        public static readonly NameToken Unchanged = new NameToken("Unchanged");
        public static readonly NameToken Unix = new NameToken("Unix");
        public static readonly NameToken Uri = new NameToken("URI");
        public static readonly NameToken Url = new NameToken("URL");
        public static readonly NameToken UserUnit = new NameToken("UserUnit");
        // V
        public static readonly NameToken V = new NameToken("V");
        public static readonly NameToken VerisignPpkvs = new NameToken("VeriSign.PPKVS");
        public static readonly NameToken Version = new NameToken("Version");
        public static readonly NameToken Vertices = new NameToken("Vertices");
        public static readonly NameToken VerticesPerRow = new NameToken("VerticesPerRow");
        public static readonly NameToken ViewArea = new NameToken("ViewArea");
        public static readonly NameToken ViewClip = new NameToken("ViewClip");
        public static readonly NameToken ViewerPreferences = new NameToken("ViewerPreferences");
        public static readonly NameToken Volume = new NameToken("Volume");
        // W
        public static readonly NameToken W = new NameToken("W");
        public static readonly NameToken W2 = new NameToken("W2");
        public static readonly NameToken WhitePoint = new NameToken("WhitePoint");
        public static readonly NameToken Widget = new NameToken("Widget");
        public static readonly NameToken Width = new NameToken("Width");
        public static readonly NameToken Widths = new NameToken("Widths");
        public static readonly NameToken WinAnsiEncoding = new NameToken("WinAnsiEncoding");
        // X
        public static readonly NameToken Xfa = new NameToken("XFA");
        public static readonly NameToken XStep = new NameToken("XStep");
        public static readonly NameToken Xheight = new NameToken("XHeight");
        public static readonly NameToken Xobject = new NameToken("XObject");
        public static readonly NameToken Xref = new NameToken("XRef");
        public static readonly NameToken XrefStm = new NameToken("XRefStm");
        // Y
        public static readonly NameToken YStep = new NameToken("YStep");
        public static readonly NameToken Yes = new NameToken("Yes");

    }
}

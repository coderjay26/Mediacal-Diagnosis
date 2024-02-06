; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [164 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 5
	i64 196720943101637631, ; 1: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 60
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 25
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 46
	i64 295915112840604065, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 47
	i64 634308326490598313, ; 5: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 38
	i64 702024105029695270, ; 6: System.Drawing.Common => 0x9be17343c0e7726 => 57
	i64 720058930071658100, ; 7: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 34
	i64 872800313462103108, ; 8: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 31
	i64 1000557547492888992, ; 9: Mono.Security.dll => 0xde2b1c9cba651a0 => 80
	i64 1120440138749646132, ; 10: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 55
	i64 1143956366812863936, ; 11: Mediacal Diagnosis => 0xfe02641326d5dc0 => 0
	i64 1315114680217950157, ; 12: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 20
	i64 1425944114962822056, ; 13: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 71
	i64 1624659445732251991, ; 14: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 18
	i64 1628611045998245443, ; 15: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 40
	i64 1636321030536304333, ; 16: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 35
	i64 1731380447121279447, ; 17: Newtonsoft.Json => 0x18071957e9b889d7 => 7
	i64 1795316252682057001, ; 18: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 19
	i64 1836611346387731153, ; 19: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 46
	i64 1875917498431009007, ; 20: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 17
	i64 1981742497975770890, ; 21: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 39
	i64 2133195048986300728, ; 22: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 7
	i64 2136356949452311481, ; 23: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 43
	i64 2165725771938924357, ; 24: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 23
	i64 2262844636196693701, ; 25: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 31
	i64 2329709569556905518, ; 26: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 37
	i64 2470498323731680442, ; 27: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 26
	i64 2479423007379663237, ; 28: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 50
	i64 2497223385847772520, ; 29: System.Runtime => 0x22a7eb7046413568 => 14
	i64 2533093556786285544, ; 30: Mediacal Diagnosis.dll => 0x23275b2b4313cbe8 => 0
	i64 2541787113603107559, ; 31: Lottie.Android.dll => 0x23463de9b0fa8ae7 => 4
	i64 2547086958574651984, ; 32: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 16
	i64 2592350477072141967, ; 33: System.Xml.dll => 0x23f9e10627330e8f => 15
	i64 2624866290265602282, ; 34: mscorlib.dll => 0x246d65fbde2db8ea => 6
	i64 3017704767998173186, ; 35: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 55
	i64 3171992396844006720, ; 36: Square.OkIO => 0x2c052e476c207d40 => 8
	i64 3289520064315143713, ; 37: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 36
	i64 3311221304742556517, ; 38: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 13
	i64 3522470458906976663, ; 39: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 48
	i64 3531994851595924923, ; 40: System.Numerics => 0x31042a9aade235bb => 12
	i64 3571415421602489686, ; 41: System.Runtime.dll => 0x319037675df7e556 => 14
	i64 3647754201059316852, ; 42: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 66
	i64 3727469159507183293, ; 43: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 45
	i64 3869649043256705283, ; 44: System.Diagnostics.Tools => 0x35b3c14d74bf0103 => 2
	i64 4009997192427317104, ; 45: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 70
	i64 4187479170553454871, ; 46: System.Linq.Expressions => 0x3a1cea1e912fa117 => 60
	i64 4525561845656915374, ; 47: System.ServiceModel.Internals => 0x3ece06856b710dae => 72
	i64 4636684751163556186, ; 48: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 52
	i64 4782108999019072045, ; 49: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 22
	i64 4794310189461587505, ; 50: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 16
	i64 4795410492532947900, ; 51: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 48
	i64 5203618020066742981, ; 52: Xamarin.Essentials => 0x4836f704f0e652c5 => 54
	i64 5205316157927637098, ; 53: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 42
	i64 5376510917114486089, ; 54: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 50
	i64 5408338804355907810, ; 55: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 49
	i64 5446034149219586269, ; 56: System.Diagnostics.Debug => 0x4b94333452e150dd => 78
	i64 5507995362134886206, ; 57: System.Core.dll => 0x4c705499688c873e => 9
	i64 6319713645133255417, ; 58: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 38
	i64 6401687960814735282, ; 59: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 37
	i64 6504860066809920875, ; 60: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 23
	i64 6548213210057960872, ; 61: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 29
	i64 6659513131007730089, ; 62: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 34
	i64 6814185388980153342, ; 63: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 67
	i64 6876862101832370452, ; 64: System.Xml.Linq => 0x5f6f85a57d108914 => 68
	i64 6894844156784520562, ; 65: System.Numerics.Vectors => 0x5faf683aead1ad72 => 13
	i64 7103753931438454322, ; 66: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 33
	i64 7270811800166795866, ; 67: System.Linq => 0x64e71ccf51a90a5a => 76
	i64 7338192458477945005, ; 68: System.Reflection => 0x65d67f295d0740ad => 73
	i64 7488575175965059935, ; 69: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 68
	i64 7489048572193775167, ; 70: System.ObjectModel => 0x67ee71ff6b419e3f => 59
	i64 7637365915383206639, ; 71: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 54
	i64 7654504624184590948, ; 72: System.Net.Http => 0x6a3a4366801b8264 => 11
	i64 7735176074855944702, ; 73: Microsoft.CSharp => 0x6b58dda848e391fe => 79
	i64 7836164640616011524, ; 74: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 18
	i64 8044118961405839122, ; 75: System.ComponentModel.Composition => 0x6fa2739369944712 => 81
	i64 8064050204834738623, ; 76: System.Collections.dll => 0x6fe942efa61731bf => 64
	i64 8083354569033831015, ; 77: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 36
	i64 8113615946733131500, ; 78: System.Reflection.Extensions => 0x70995ab73cf916ec => 1
	i64 8167236081217502503, ; 79: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 3
	i64 8185542183669246576, ; 80: System.Collections => 0x7198e33f4794aa70 => 64
	i64 8290740647658429042, ; 81: System.Runtime.Extensions => 0x730ea0b15c929a72 => 74
	i64 8601935802264776013, ; 82: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 49
	i64 8609060182490045521, ; 83: Square.OkIO.dll => 0x7779869f8b475c51 => 8
	i64 8626175481042262068, ; 84: Java.Interop => 0x77b654e585b55834 => 3
	i64 8638972117149407195, ; 85: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 79
	i64 8941376889969657626, ; 86: System.Xml.XDocument => 0x7c1626e87187471a => 67
	i64 9324707631942237306, ; 87: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 19
	i64 9584643793929893533, ; 88: System.IO.dll => 0x85037ebfbbd7f69d => 62
	i64 9659729154652888475, ; 89: System.Text.RegularExpressions => 0x860e407c9991dd9b => 65
	i64 9662334977499516867, ; 90: System.Numerics.dll => 0x8617827802b0cfc3 => 12
	i64 9678050649315576968, ; 91: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 26
	i64 9808709177481450983, ; 92: Mono.Android.dll => 0x881f890734e555e7 => 5
	i64 9998632235833408227, ; 93: Mono.Security => 0x8ac2470b209ebae3 => 80
	i64 10038780035334861115, ; 94: System.Net.Http.dll => 0x8b50e941206af13b => 11
	i64 10229024438826829339, ; 95: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 29
	i64 10360651442923773544, ; 96: System.Text.Encoding => 0x8fc86d98211c1e68 => 61
	i64 10430153318873392755, ; 97: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 27
	i64 10566960649245365243, ; 98: System.Globalization.dll => 0x92a562b96dcd13fb => 63
	i64 10714184849103829812, ; 99: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 74
	i64 10847732767863316357, ; 100: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 20
	i64 11023048688141570732, ; 101: System.Core => 0x98f9bc61168392ac => 9
	i64 11037814507248023548, ; 102: System.Xml => 0x992e31d0412bf7fc => 15
	i64 11162124722117608902, ; 103: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 53
	i64 11340910727871153756, ; 104: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 28
	i64 11392833485892708388, ; 105: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 44
	i64 11529969570048099689, ; 106: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 53
	i64 11580057168383206117, ; 107: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 17
	i64 11672361001936329215, ; 108: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 33
	i64 11743665907891708234, ; 109: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 69
	i64 12123043025855404482, ; 110: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 1
	i64 12137774235383566651, ; 111: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 51
	i64 12201331334810686224, ; 112: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 70
	i64 12451044538927396471, ; 113: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 32
	i64 12466513435562512481, ; 114: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 41
	i64 12487638416075308985, ; 115: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 30
	i64 12488608402635344228, ; 116: Lottie.Android => 0xad50732cba09c964 => 4
	i64 12538491095302438457, ; 117: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 24
	i64 12700543734426720211, ; 118: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 25
	i64 12708238894395270091, ; 119: System.IO => 0xb05cbbf17d3ba3cb => 62
	i64 12708922737231849740, ; 120: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 75
	i64 12963446364377008305, ; 121: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 57
	i64 13370592475155966277, ; 122: System.Runtime.Serialization => 0xb98de304062ea945 => 71
	i64 13401370062847626945, ; 123: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 51
	i64 13454009404024712428, ; 124: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 56
	i64 13491513212026656886, ; 125: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 21
	i64 13572454107664307259, ; 126: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 45
	i64 13702626353344114072, ; 127: System.Diagnostics.Tools.dll => 0xbe29821198fb6d98 => 2
	i64 13713329104121190199, ; 128: System.Dynamic.Runtime => 0xbe4f8829f32b5737 => 58
	i64 13959074834287824816, ; 129: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 32
	i64 14124974489674258913, ; 130: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 24
	i64 14125464355221830302, ; 131: System.Threading.dll => 0xc407bafdbc707a9e => 77
	i64 14172845254133543601, ; 132: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 43
	i64 14254574811015963973, ; 133: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 75
	i64 14261073672896646636, ; 134: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 44
	i64 14327695147300244862, ; 135: System.Reflection.dll => 0xc6d632d338eb4d7e => 73
	i64 14644440854989303794, ; 136: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 42
	i64 14792063746108907174, ; 137: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 56
	i64 14852515768018889994, ; 138: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 28
	i64 14988210264188246988, ; 139: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 30
	i64 15076659072870671916, ; 140: System.ObjectModel.dll => 0xd13b0d8c1620662c => 59
	i64 15133485256822086103, ; 141: System.Linq.dll => 0xd204f0a9127dd9d7 => 76
	i64 15234786388537674379, ; 142: System.Dynamic.Runtime.dll => 0xd36cd580c5be8a8b => 58
	i64 15370334346939861994, ; 143: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 27
	i64 15526743539506359484, ; 144: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 61
	i64 15582737692548360875, ; 145: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 40
	i64 15609085926864131306, ; 146: System.dll => 0xd89e9cf3334914ea => 10
	i64 15661133872274321916, ; 147: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 66
	i64 15777549416145007739, ; 148: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 47
	i64 15817206913877585035, ; 149: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 69
	i64 16154507427712707110, ; 150: System => 0xe03056ea4e39aa26 => 10
	i64 16565028646146589191, ; 151: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 81
	i64 16833383113903931215, ; 152: mscorlib => 0xe99c30c1484d7f4f => 6
	i64 16890310621557459193, ; 153: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 65
	i64 17037200463775726619, ; 154: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 35
	i64 17544493274320527064, ; 155: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 22
	i64 17627500474728259406, ; 156: System.Globalization => 0xf4a176498a351f4e => 63
	i64 17685921127322830888, ; 157: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 78
	i64 17704177640604968747, ; 158: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 41
	i64 17710060891934109755, ; 159: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 39
	i64 18025913125965088385, ; 160: System.Threading => 0xfa28e87b91334681 => 77
	i64 18116111925905154859, ; 161: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 21
	i64 18129453464017766560, ; 162: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 72
	i64 18380184030268848184 ; 163: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 52
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [164 x i32] [
	i32 5, i32 60, i32 25, i32 46, i32 47, i32 38, i32 57, i32 34, ; 0..7
	i32 31, i32 80, i32 55, i32 0, i32 20, i32 71, i32 18, i32 40, ; 8..15
	i32 35, i32 7, i32 19, i32 46, i32 17, i32 39, i32 7, i32 43, ; 16..23
	i32 23, i32 31, i32 37, i32 26, i32 50, i32 14, i32 0, i32 4, ; 24..31
	i32 16, i32 15, i32 6, i32 55, i32 8, i32 36, i32 13, i32 48, ; 32..39
	i32 12, i32 14, i32 66, i32 45, i32 2, i32 70, i32 60, i32 72, ; 40..47
	i32 52, i32 22, i32 16, i32 48, i32 54, i32 42, i32 50, i32 49, ; 48..55
	i32 78, i32 9, i32 38, i32 37, i32 23, i32 29, i32 34, i32 67, ; 56..63
	i32 68, i32 13, i32 33, i32 76, i32 73, i32 68, i32 59, i32 54, ; 64..71
	i32 11, i32 79, i32 18, i32 81, i32 64, i32 36, i32 1, i32 3, ; 72..79
	i32 64, i32 74, i32 49, i32 8, i32 3, i32 79, i32 67, i32 19, ; 80..87
	i32 62, i32 65, i32 12, i32 26, i32 5, i32 80, i32 11, i32 29, ; 88..95
	i32 61, i32 27, i32 63, i32 74, i32 20, i32 9, i32 15, i32 53, ; 96..103
	i32 28, i32 44, i32 53, i32 17, i32 33, i32 69, i32 1, i32 51, ; 104..111
	i32 70, i32 32, i32 41, i32 30, i32 4, i32 24, i32 25, i32 62, ; 112..119
	i32 75, i32 57, i32 71, i32 51, i32 56, i32 21, i32 45, i32 2, ; 120..127
	i32 58, i32 32, i32 24, i32 77, i32 43, i32 75, i32 44, i32 73, ; 128..135
	i32 42, i32 56, i32 28, i32 30, i32 59, i32 76, i32 58, i32 27, ; 136..143
	i32 61, i32 40, i32 10, i32 66, i32 47, i32 69, i32 10, i32 81, ; 144..151
	i32 6, i32 65, i32 35, i32 22, i32 63, i32 78, i32 41, i32 39, ; 152..159
	i32 77, i32 21, i32 72, i32 52 ; 160..163
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}

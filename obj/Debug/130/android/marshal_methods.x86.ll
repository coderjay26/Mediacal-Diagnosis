; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [164 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 38
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 56
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 7
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 47
	i32 120558881, ; 4: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 47
	i32 165246403, ; 5: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 25
	i32 182336117, ; 6: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 48
	i32 209399409, ; 7: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 23
	i32 220171995, ; 8: System.Diagnostics.Debug => 0xd1f8edb => 78
	i32 230216969, ; 9: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 35
	i32 230752869, ; 10: Microsoft.CSharp.dll => 0xdc10265 => 79
	i32 231814094, ; 11: System.Globalization => 0xdd133ce => 63
	i32 280482487, ; 12: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 33
	i32 318968648, ; 13: Xamarin.AndroidX.Activity.dll => 0x13031348 => 16
	i32 321597661, ; 14: System.Numerics => 0x132b30dd => 12
	i32 342366114, ; 15: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 36
	i32 381722425, ; 16: Mediacal Diagnosis.dll => 0x16c09f39 => 0
	i32 442521989, ; 17: Xamarin.Essentials => 0x1a605985 => 54
	i32 442565967, ; 18: System.Collections => 0x1a61054f => 64
	i32 450948140, ; 19: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 32
	i32 459347974, ; 20: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 70
	i32 465846621, ; 21: mscorlib => 0x1bc4415d => 6
	i32 469710990, ; 22: System.dll => 0x1bff388e => 10
	i32 476646585, ; 23: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 33
	i32 486930444, ; 24: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 42
	i32 498788369, ; 25: System.ObjectModel => 0x1dbae811 => 59
	i32 545304856, ; 26: System.Runtime.Extensions => 0x2080b118 => 74
	i32 627609679, ; 27: Xamarin.AndroidX.CustomView => 0x2568904f => 29
	i32 663517072, ; 28: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 52
	i32 666292255, ; 29: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 20
	i32 690569205, ; 30: System.Xml.Linq.dll => 0x29293ff5 => 68
	i32 809851609, ; 31: System.Drawing.Common.dll => 0x30455ad9 => 57
	i32 843511501, ; 32: Xamarin.AndroidX.Print => 0x3246f6cd => 44
	i32 877678880, ; 33: System.Globalization.dll => 0x34505120 => 63
	i32 928116545, ; 34: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 56
	i32 955402788, ; 35: Newtonsoft.Json => 0x38f24a24 => 7
	i32 961995525, ; 36: Square.OkIO.dll => 0x3956e305 => 8
	i32 967690846, ; 37: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 36
	i32 975874589, ; 38: System.Xml.XDocument => 0x3a2aaa1d => 67
	i32 987214855, ; 39: System.Diagnostics.Tools => 0x3ad7b407 => 2
	i32 992768348, ; 40: System.Collections.dll => 0x3b2c715c => 64
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 46
	i32 1035644815, ; 42: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 19
	i32 1044663988, ; 43: System.Linq.Expressions.dll => 0x3e444eb4 => 60
	i32 1052210849, ; 44: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 39
	i32 1098259244, ; 45: System => 0x41761b2c => 10
	i32 1175144683, ; 46: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 50
	i32 1204270330, ; 47: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 20
	i32 1267360935, ; 48: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 51
	i32 1293217323, ; 49: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 31
	i32 1324164729, ; 50: System.Linq => 0x4eed2679 => 76
	i32 1364015309, ; 51: System.IO => 0x514d38cd => 62
	i32 1365406463, ; 52: System.ServiceModel.Internals.dll => 0x516272ff => 72
	i32 1376866003, ; 53: Xamarin.AndroidX.SavedState => 0x52114ed3 => 46
	i32 1406073936, ; 54: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 26
	i32 1453312822, ; 55: System.Diagnostics.Tools.dll => 0x569fcb36 => 2
	i32 1457743152, ; 56: System.Runtime.Extensions.dll => 0x56e36530 => 74
	i32 1469204771, ; 57: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 18
	i32 1543031311, ; 58: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 65
	i32 1550322496, ; 59: System.Reflection.Extensions.dll => 0x5c680b40 => 1
	i32 1582372066, ; 60: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 30
	i32 1592978981, ; 61: System.Runtime.Serialization.dll => 0x5ef2ee25 => 71
	i32 1622152042, ; 62: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 41
	i32 1622358360, ; 63: System.Dynamic.Runtime => 0x60b33958 => 58
	i32 1636350590, ; 64: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 28
	i32 1639515021, ; 65: System.Net.Http.dll => 0x61b9038d => 11
	i32 1639986890, ; 66: System.Text.RegularExpressions => 0x61c036ca => 65
	i32 1657153582, ; 67: System.Runtime => 0x62c6282e => 14
	i32 1658251792, ; 68: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 55
	i32 1701541528, ; 69: System.Diagnostics.Debug.dll => 0x656b7698 => 78
	i32 1726116996, ; 70: System.Reflection.dll => 0x66e27484 => 73
	i32 1729485958, ; 71: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 24
	i32 1765942094, ; 72: System.Reflection.Extensions => 0x6942234e => 1
	i32 1766324549, ; 73: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 48
	i32 1776026572, ; 74: System.Core.dll => 0x69dc03cc => 9
	i32 1788241197, ; 75: Xamarin.AndroidX.Fragment => 0x6a96652d => 32
	i32 1808609942, ; 76: Xamarin.AndroidX.Loader => 0x6bcd3296 => 41
	i32 1813201214, ; 77: Xamarin.Google.Android.Material => 0x6c13413e => 55
	i32 1824175904, ; 78: System.Text.Encoding.Extensions => 0x6cbab720 => 75
	i32 1858542181, ; 79: System.Linq.Expressions => 0x6ec71a65 => 60
	i32 1867746548, ; 80: Xamarin.Essentials.dll => 0x6f538cf4 => 54
	i32 1885316902, ; 81: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 21
	i32 1919157823, ; 82: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 43
	i32 2019465201, ; 83: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 39
	i32 2055257422, ; 84: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 37
	i32 2079903147, ; 85: System.Runtime.dll => 0x7bf8cdab => 14
	i32 2090596640, ; 86: System.Numerics.Vectors => 0x7c9bf920 => 13
	i32 2097448633, ; 87: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 34
	i32 2193016926, ; 88: System.ObjectModel.dll => 0x82b6c85e => 59
	i32 2201231467, ; 89: System.Net.Http => 0x8334206b => 11
	i32 2217644978, ; 90: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 50
	i32 2244775296, ; 91: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 42
	i32 2256548716, ; 92: Xamarin.AndroidX.MultiDex => 0x8680336c => 43
	i32 2279755925, ; 93: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 45
	i32 2315684594, ; 94: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 17
	i32 2368005991, ; 95: System.Xml.ReaderWriter.dll => 0x8d24e767 => 66
	i32 2402030976, ; 96: Mediacal Diagnosis => 0x8f2c1580 => 0
	i32 2454642406, ; 97: System.Text.Encoding.dll => 0x924edee6 => 61
	i32 2475788418, ; 98: Java.Interop.dll => 0x93918882 => 3
	i32 2505896520, ; 99: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 38
	i32 2562349572, ; 100: Microsoft.CSharp => 0x98ba5a04 => 79
	i32 2581819634, ; 101: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 51
	i32 2585220780, ; 102: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 75
	i32 2620871830, ; 103: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 28
	i32 2664396074, ; 104: System.Xml.XDocument.dll => 0x9ecf752a => 67
	i32 2693849962, ; 105: System.IO.dll => 0xa090e36a => 62
	i32 2715334215, ; 106: System.Threading.Tasks.dll => 0xa1d8b647 => 69
	i32 2732626843, ; 107: Xamarin.AndroidX.Activity => 0xa2e0939b => 16
	i32 2737747696, ; 108: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 18
	i32 2778768386, ; 109: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 53
	i32 2810250172, ; 110: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 26
	i32 2819470561, ; 111: System.Xml.dll => 0xa80db4e1 => 15
	i32 2843355708, ; 112: Lottie.Android.dll => 0xa97a2a3c => 4
	i32 2853208004, ; 113: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 53
	i32 2855708567, ; 114: Xamarin.AndroidX.Transition => 0xaa36a797 => 49
	i32 2900621748, ; 115: System.Dynamic.Runtime.dll => 0xace3f9b4 => 58
	i32 2901442782, ; 116: System.Reflection => 0xacf080de => 73
	i32 2903344695, ; 117: System.ComponentModel.Composition => 0xad0d8637 => 81
	i32 2905242038, ; 118: mscorlib.dll => 0xad2a79b6 => 6
	i32 2919462931, ; 119: System.Numerics.Vectors.dll => 0xae037813 => 13
	i32 2943219317, ; 120: Square.OkIO => 0xaf6df675 => 8
	i32 2978675010, ; 121: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 31
	i32 3024354802, ; 122: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 35
	i32 3075834255, ; 123: System.Threading.Tasks => 0xb755818f => 69
	i32 3111772706, ; 124: System.Runtime.Serialization => 0xb979e222 => 71
	i32 3211777861, ; 125: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 30
	i32 3220365878, ; 126: System.Threading => 0xbff2e236 => 77
	i32 3247949154, ; 127: Mono.Security => 0xc197c562 => 80
	i32 3258312781, ; 128: Xamarin.AndroidX.CardView => 0xc235e84d => 24
	i32 3267021929, ; 129: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 22
	i32 3299363146, ; 130: System.Text.Encoding => 0xc4a8494a => 61
	i32 3317135071, ; 131: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 29
	i32 3340431453, ; 132: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 21
	i32 3353484488, ; 133: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 34
	i32 3362522851, ; 134: Xamarin.AndroidX.Core => 0xc86c06e3 => 27
	i32 3366347497, ; 135: Java.Interop => 0xc8a662e9 => 3
	i32 3374999561, ; 136: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 45
	i32 3404865022, ; 137: System.ServiceModel.Internals => 0xcaf21dfe => 72
	i32 3429136800, ; 138: System.Xml => 0xcc6479a0 => 15
	i32 3476120550, ; 139: Mono.Android => 0xcf3163e6 => 5
	i32 3501239056, ; 140: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 22
	i32 3509114376, ; 141: System.Xml.Linq => 0xd128d608 => 68
	i32 3567349600, ; 142: System.ComponentModel.Composition.dll => 0xd4a16f60 => 81
	i32 3608519521, ; 143: System.Linq.dll => 0xd715a361 => 76
	i32 3627220390, ; 144: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 44
	i32 3639449509, ; 145: Lottie.Android => 0xd8ed97a5 => 4
	i32 3641597786, ; 146: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 37
	i32 3672681054, ; 147: Mono.Android.dll => 0xdae8aa5e => 5
	i32 3682565725, ; 148: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 23
	i32 3689375977, ; 149: System.Drawing.Common => 0xdbe768e9 => 57
	i32 3718780102, ; 150: Xamarin.AndroidX.Annotation => 0xdda814c6 => 17
	i32 3786282454, ; 151: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 25
	i32 3829621856, ; 152: System.Numerics.dll => 0xe4436460 => 12
	i32 3885922214, ; 153: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 49
	i32 3896760992, ; 154: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 27
	i32 3921031405, ; 155: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 52
	i32 3928044579, ; 156: System.Xml.ReaderWriter => 0xea213423 => 66
	i32 3955647286, ; 157: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 19
	i32 4073602200, ; 158: System.Threading.dll => 0xf2ce3c98 => 77
	i32 4105002889, ; 159: Mono.Security.dll => 0xf4ad5f89 => 80
	i32 4151237749, ; 160: System.Core => 0xf76edc75 => 9
	i32 4181436372, ; 161: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 70
	i32 4182413190, ; 162: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 40
	i32 4292120959 ; 163: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 40
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [164 x i32] [
	i32 38, i32 56, i32 7, i32 47, i32 47, i32 25, i32 48, i32 23, ; 0..7
	i32 78, i32 35, i32 79, i32 63, i32 33, i32 16, i32 12, i32 36, ; 8..15
	i32 0, i32 54, i32 64, i32 32, i32 70, i32 6, i32 10, i32 33, ; 16..23
	i32 42, i32 59, i32 74, i32 29, i32 52, i32 20, i32 68, i32 57, ; 24..31
	i32 44, i32 63, i32 56, i32 7, i32 8, i32 36, i32 67, i32 2, ; 32..39
	i32 64, i32 46, i32 19, i32 60, i32 39, i32 10, i32 50, i32 20, ; 40..47
	i32 51, i32 31, i32 76, i32 62, i32 72, i32 46, i32 26, i32 2, ; 48..55
	i32 74, i32 18, i32 65, i32 1, i32 30, i32 71, i32 41, i32 58, ; 56..63
	i32 28, i32 11, i32 65, i32 14, i32 55, i32 78, i32 73, i32 24, ; 64..71
	i32 1, i32 48, i32 9, i32 32, i32 41, i32 55, i32 75, i32 60, ; 72..79
	i32 54, i32 21, i32 43, i32 39, i32 37, i32 14, i32 13, i32 34, ; 80..87
	i32 59, i32 11, i32 50, i32 42, i32 43, i32 45, i32 17, i32 66, ; 88..95
	i32 0, i32 61, i32 3, i32 38, i32 79, i32 51, i32 75, i32 28, ; 96..103
	i32 67, i32 62, i32 69, i32 16, i32 18, i32 53, i32 26, i32 15, ; 104..111
	i32 4, i32 53, i32 49, i32 58, i32 73, i32 81, i32 6, i32 13, ; 112..119
	i32 8, i32 31, i32 35, i32 69, i32 71, i32 30, i32 77, i32 80, ; 120..127
	i32 24, i32 22, i32 61, i32 29, i32 21, i32 34, i32 27, i32 3, ; 128..135
	i32 45, i32 72, i32 15, i32 5, i32 22, i32 68, i32 81, i32 76, ; 136..143
	i32 44, i32 4, i32 37, i32 5, i32 23, i32 57, i32 17, i32 25, ; 144..151
	i32 12, i32 49, i32 27, i32 52, i32 66, i32 19, i32 77, i32 80, ; 152..159
	i32 9, i32 70, i32 40, i32 40 ; 160..163
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}

; ModuleID = 'obj\Release\130\android\compressed_assemblies.arm64-v8a.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [166400 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [492544 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [141824 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [1233920 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [109568 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [121344 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [54784 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [212480 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [25600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [386048 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [327168 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [31232 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [152576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [8704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [40960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [152576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [14848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [15872 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [16384 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [36352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [12800 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [22528 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [35328 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [18072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [1873920 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [26 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 166400, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([166400 x i8], [166400 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 492544, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([492544 x i8], [492544 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 141824, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([141824 x i8], [141824 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 1233920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1233920 x i8], [1233920 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 109568, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([109568 x i8], [109568 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 121344, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([121344 x i8], [121344 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 54784, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([54784 x i8], [54784 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 212480, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([212480 x i8], [212480 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25600 x i8], [25600 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 386048, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([386048 x i8], [386048 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 327168, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([327168 x i8], [327168 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 31232, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([31232 x i8], [31232 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 152576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152576 x i8], [152576 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 40960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40960 x i8], [40960 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 152576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152576 x i8], [152576 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15872 x i8], [15872 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16384 x i8], [16384 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 36352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36352 x i8], [36352 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12800 x i8], [12800 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 22528, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([22528 x i8], [22528 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 35328, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([35328 x i8], [35328 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 18072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18072 x i8], [18072 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 1873920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1873920 x i8], [1873920 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}
], align 8; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 26, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([26 x %struct.CompressedAssemblyDescriptor], [26 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}

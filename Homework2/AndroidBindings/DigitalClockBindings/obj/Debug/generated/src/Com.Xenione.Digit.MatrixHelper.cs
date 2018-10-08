using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xenione.Digit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']"
	[global::Android.Runtime.Register ("com/xenione/digit/MatrixHelper", DoNotGenerateAcw=true)]
	public partial class MatrixHelper : global::Java.Lang.Object {


		static IntPtr ROTATE_X_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/field[@name='ROTATE_X_0']"
		[Register ("ROTATE_X_0")]
		public static global::Android.Graphics.Matrix RotateX0 {
			get {
				if (ROTATE_X_0_jfieldId == IntPtr.Zero)
					ROTATE_X_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROTATE_X_0", "Landroid/graphics/Matrix;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROTATE_X_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROTATE_X_90_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/field[@name='ROTATE_X_90']"
		[Register ("ROTATE_X_90")]
		public static global::Android.Graphics.Matrix RotateX90 {
			get {
				if (ROTATE_X_90_jfieldId == IntPtr.Zero)
					ROTATE_X_90_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROTATE_X_90", "Landroid/graphics/Matrix;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROTATE_X_90_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr camera_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/field[@name='camera']"
		[Register ("camera")]
		public static global::Android.Graphics.Camera Camera {
			get {
				if (camera_jfieldId == IntPtr.Zero)
					camera_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "camera", "Landroid/graphics/Camera;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, camera_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Camera> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xenione/digit/MatrixHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatrixHelper); }
		}

		protected MatrixHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/constructor[@name='MatrixHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatrixHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MatrixHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_mirrorX_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/method[@name='mirrorX' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("mirrorX", "(Landroid/graphics/Matrix;)V", "")]
		public static unsafe void MirrorX (global::Android.Graphics.Matrix p0)
		{
			if (id_mirrorX_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_mirrorX_Landroid_graphics_Matrix_ = JNIEnv.GetStaticMethodID (class_ref, "mirrorX", "(Landroid/graphics/Matrix;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mirrorX_Landroid_graphics_Matrix_, __args);
			} finally {
			}
		}

		static IntPtr id_rotateX_Landroid_graphics_Matrix_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/method[@name='rotateX' and count(parameter)=2 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='int']]"
		[Register ("rotateX", "(Landroid/graphics/Matrix;I)V", "")]
		public static unsafe void RotateX (global::Android.Graphics.Matrix p0, int p1)
		{
			if (id_rotateX_Landroid_graphics_Matrix_I == IntPtr.Zero)
				id_rotateX_Landroid_graphics_Matrix_I = JNIEnv.GetStaticMethodID (class_ref, "rotateX", "(Landroid/graphics/Matrix;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rotateX_Landroid_graphics_Matrix_I, __args);
			} finally {
			}
		}

		static IntPtr id_rotateZ_Landroid_graphics_Matrix_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/method[@name='rotateZ' and count(parameter)=2 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='int']]"
		[Register ("rotateZ", "(Landroid/graphics/Matrix;I)V", "")]
		public static unsafe void RotateZ (global::Android.Graphics.Matrix p0, int p1)
		{
			if (id_rotateZ_Landroid_graphics_Matrix_I == IntPtr.Zero)
				id_rotateZ_Landroid_graphics_Matrix_I = JNIEnv.GetStaticMethodID (class_ref, "rotateZ", "(Landroid/graphics/Matrix;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rotateZ_Landroid_graphics_Matrix_I, __args);
			} finally {
			}
		}

		static IntPtr id_translate_Landroid_graphics_Matrix_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/method[@name='translate' and count(parameter)=4 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("translate", "(Landroid/graphics/Matrix;FFF)V", "")]
		public static unsafe void Translate (global::Android.Graphics.Matrix p0, float p1, float p2, float p3)
		{
			if (id_translate_Landroid_graphics_Matrix_FFF == IntPtr.Zero)
				id_translate_Landroid_graphics_Matrix_FFF = JNIEnv.GetStaticMethodID (class_ref, "translate", "(Landroid/graphics/Matrix;FFF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_translate_Landroid_graphics_Matrix_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_translateY_Landroid_graphics_Matrix_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='MatrixHelper']/method[@name='translateY' and count(parameter)=2 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='float']]"
		[Register ("translateY", "(Landroid/graphics/Matrix;F)V", "")]
		public static unsafe void TranslateY (global::Android.Graphics.Matrix p0, float p1)
		{
			if (id_translateY_Landroid_graphics_Matrix_F == IntPtr.Zero)
				id_translateY_Landroid_graphics_Matrix_F = JNIEnv.GetStaticMethodID (class_ref, "translateY", "(Landroid/graphics/Matrix;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_translateY_Landroid_graphics_Matrix_F, __args);
			} finally {
			}
		}

	}
}

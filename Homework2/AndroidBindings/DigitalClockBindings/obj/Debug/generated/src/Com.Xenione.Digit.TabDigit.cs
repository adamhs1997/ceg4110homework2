using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xenione.Digit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']"
	[global::Android.Runtime.Register ("com/xenione/digit/TabDigit", DoNotGenerateAcw=true)]
	public partial class TabDigit : global::Android.Views.View, global::Java.Lang.IRunnable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']"
		[global::Android.Runtime.Register ("com/xenione/digit/TabDigit$Tab", DoNotGenerateAcw=true)]
		public partial class Tab : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/xenione/digit/TabDigit$Tab", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tab); }
			}

			protected Tab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_xenione_digit_TabDigit_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/constructor[@name='TabDigit.Tab' and count(parameter)=1 and parameter[1][@type='com.xenione.digit.TabDigit']]"
			[Register (".ctor", "(Lcom/xenione/digit/TabDigit;)V", "")]
			public unsafe Tab (global::Com.Xenione.Digit.TabDigit __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (Tab)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_xenione_digit_TabDigit_ == IntPtr.Zero)
						id_ctor_Lcom_xenione_digit_TabDigit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/xenione/digit/TabDigit;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_xenione_digit_TabDigit_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_xenione_digit_TabDigit_, __args);
				} finally {
				}
			}

			static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
			static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
			{
				if (cb_draw_Landroid_graphics_Canvas_ == null)
					cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
				return cb_draw_Landroid_graphics_Canvas_;
			}

			static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Draw (p0);
			}
#pragma warning restore 0169

			static IntPtr id_draw_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
			[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
			public virtual unsafe void Draw (global::Android.Graphics.Canvas p0)
			{
				if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
					id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_maxHeight;
#pragma warning disable 0169
			static Delegate GetMaxHeightHandler ()
			{
				if (cb_maxHeight == null)
					cb_maxHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxHeight);
				return cb_maxHeight;
			}

			static int n_MaxHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxHeight ();
			}
#pragma warning restore 0169

			static IntPtr id_maxHeight;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='maxHeight' and count(parameter)=0]"
			[Register ("maxHeight", "()I", "GetMaxHeightHandler")]
			public virtual unsafe int MaxHeight ()
			{
				if (id_maxHeight == IntPtr.Zero)
					id_maxHeight = JNIEnv.GetMethodID (class_ref, "maxHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxHeight", "()I"));
				} finally {
				}
			}

			static Delegate cb_maxWith;
#pragma warning disable 0169
			static Delegate GetMaxWithHandler ()
			{
				if (cb_maxWith == null)
					cb_maxWith = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxWith);
				return cb_maxWith;
			}

			static int n_MaxWith (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxWith ();
			}
#pragma warning restore 0169

			static IntPtr id_maxWith;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='maxWith' and count(parameter)=0]"
			[Register ("maxWith", "()I", "GetMaxWithHandler")]
			public virtual unsafe int MaxWith ()
			{
				if (id_maxWith == IntPtr.Zero)
					id_maxWith = JNIEnv.GetMethodID (class_ref, "maxWith", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxWith);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxWith", "()I"));
				} finally {
				}
			}

			static Delegate cb_measure_II;
#pragma warning disable 0169
			static Delegate GetMeasure_IIHandler ()
			{
				if (cb_measure_II == null)
					cb_measure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Measure_II);
				return cb_measure_II;
			}

			static void n_Measure_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Measure (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_measure_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='measure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("measure", "(II)V", "GetMeasure_IIHandler")]
			public virtual unsafe void Measure (int p0, int p1)
			{
				if (id_measure_II == IntPtr.Zero)
					id_measure_II = JNIEnv.GetMethodID (class_ref, "measure", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_measure_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "measure", "(II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static void n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Next ();
			}
#pragma warning restore 0169

			static IntPtr id_next;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()V", "GetNextHandler")]
			public virtual unsafe void Next ()
			{
				if (id_next == IntPtr.Zero)
					id_next = JNIEnv.GetMethodID (class_ref, "next", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_next);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "()V"));
				} finally {
				}
			}

			static Delegate cb_rotate_I;
#pragma warning disable 0169
			static Delegate GetRotate_IHandler ()
			{
				if (cb_rotate_I == null)
					cb_rotate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Rotate_I);
				return cb_rotate_I;
			}

			static void n_Rotate_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Rotate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_rotate_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("rotate", "(I)V", "GetRotate_IHandler")]
			public virtual unsafe void Rotate (int p0)
			{
				if (id_rotate_I == IntPtr.Zero)
					id_rotate_I = JNIEnv.GetMethodID (class_ref, "rotate", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rotate_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotate", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setChar_I;
#pragma warning disable 0169
			static Delegate GetSetChar_IHandler ()
			{
				if (cb_setChar_I == null)
					cb_setChar_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChar_I);
				return cb_setChar_I;
			}

			static void n_SetChar_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Xenione.Digit.TabDigit.Tab __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetChar (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setChar_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit.Tab']/method[@name='setChar' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setChar", "(I)V", "GetSetChar_IHandler")]
			public virtual unsafe void SetChar (int p0)
			{
				if (id_setChar_I == IntPtr.Zero)
					id_setChar_I = JNIEnv.GetMethodID (class_ref, "setChar", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChar_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChar", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xenione/digit/TabDigit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TabDigit); }
		}

		protected TabDigit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/constructor[@name='TabDigit' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe TabDigit (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (TabDigit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/constructor[@name='TabDigit' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TabDigit (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (TabDigit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/constructor[@name='TabDigit' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TabDigit (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TabDigit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/constructor[@name='TabDigit' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TabDigit (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TabDigit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundColor;
		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCornerSize;
#pragma warning disable 0169
		static Delegate GetGetCornerSizeHandler ()
		{
			if (cb_getCornerSize == null)
				cb_getCornerSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCornerSize);
			return cb_getCornerSize;
		}

		static int n_GetCornerSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CornerSize;
		}
#pragma warning restore 0169

		static Delegate cb_setCornerSize_I;
#pragma warning disable 0169
		static Delegate GetSetCornerSize_IHandler ()
		{
			if (cb_setCornerSize_I == null)
				cb_setCornerSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCornerSize_I);
			return cb_setCornerSize_I;
		}

		static void n_SetCornerSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CornerSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCornerSize;
		static IntPtr id_setCornerSize_I;
		public virtual unsafe int CornerSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getCornerSize' and count(parameter)=0]"
			[Register ("getCornerSize", "()I", "GetGetCornerSizeHandler")]
			get {
				if (id_getCornerSize == IntPtr.Zero)
					id_getCornerSize = JNIEnv.GetMethodID (class_ref, "getCornerSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCornerSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCornerSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setCornerSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerSize", "(I)V", "GetSetCornerSize_IHandler")]
			set {
				if (id_setCornerSize_I == IntPtr.Zero)
					id_setCornerSize_I = JNIEnv.GetMethodID (class_ref, "setCornerSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCornerSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCornerSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPadding;
#pragma warning disable 0169
		static Delegate GetGetPaddingHandler ()
		{
			if (cb_getPadding == null)
				cb_getPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPadding);
			return cb_getPadding;
		}

		static int n_GetPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		static Delegate cb_setPadding_I;
#pragma warning disable 0169
		static Delegate GetSetPadding_IHandler ()
		{
			if (cb_setPadding_I == null)
				cb_setPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPadding_I);
			return cb_setPadding_I;
		}

		static void n_SetPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPadding;
		static IntPtr id_setPadding_I;
		public virtual unsafe int Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()I", "GetGetPaddingHandler")]
			get {
				if (id_getPadding == IntPtr.Zero)
					id_getPadding = JNIEnv.GetMethodID (class_ref, "getPadding", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPadding", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPadding", "(I)V", "GetSetPadding_IHandler")]
			set {
				if (id_setPadding_I == IntPtr.Zero)
					id_setPadding_I = JNIEnv.GetMethodID (class_ref, "setPadding", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPadding_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPadding", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextColor);
			return cb_getTextColor;
		}

		static int n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		static IntPtr id_setTextColor_I;
		public virtual unsafe int TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()I", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
			set {
				if (id_setTextColor_I == IntPtr.Zero)
					id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextSize);
			return cb_getTextSize;
		}

		static int n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetTextSize_IHandler ()
		{
			if (cb_setTextSize_I == null)
				cb_setTextSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextSize_I);
			return cb_setTextSize_I;
		}

		static void n_SetTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextSize;
		static IntPtr id_setTextSize_I;
		public virtual unsafe int TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()I", "GetGetTextSizeHandler")]
			get {
				if (id_getTextSize == IntPtr.Zero)
					id_getTextSize = JNIEnv.GetMethodID (class_ref, "getTextSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSize", "(I)V", "GetSetTextSize_IHandler")]
			set {
				if (id_setTextSize_I == IntPtr.Zero)
					id_setTextSize_I = JNIEnv.GetMethodID (class_ref, "setTextSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_elapsedTime_F;
#pragma warning disable 0169
		static Delegate GetElapsedTime_FHandler ()
		{
			if (cb_elapsedTime_F == null)
				cb_elapsedTime_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ElapsedTime_F);
			return cb_elapsedTime_F;
		}

		static void n_ElapsedTime_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ElapsedTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_elapsedTime_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='elapsedTime' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("elapsedTime", "(F)V", "GetElapsedTime_FHandler")]
		public virtual unsafe void ElapsedTime (float p0)
		{
			if (id_elapsedTime_F == IntPtr.Zero)
				id_elapsedTime_F = JNIEnv.GetMethodID (class_ref, "elapsedTime", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_elapsedTime_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "elapsedTime", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getChars;
#pragma warning disable 0169
		static Delegate GetGetCharsHandler ()
		{
			if (cb_getChars == null)
				cb_getChars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChars);
			return cb_getChars;
		}

		static IntPtr n_GetChars (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetChars ());
		}
#pragma warning restore 0169

		static IntPtr id_getChars;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='getChars' and count(parameter)=0]"
		[Register ("getChars", "()[C", "GetGetCharsHandler")]
		public virtual unsafe char[] GetChars ()
		{
			if (id_getChars == IntPtr.Zero)
				id_getChars = JNIEnv.GetMethodID (class_ref, "getChars", "()[C");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChars), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChars", "()[C")), JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_init_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_init_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_init_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static void n_Init_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet p1 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("init", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "GetInit_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
		{
			if (id_init_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setChar_I;
#pragma warning disable 0169
		static Delegate GetSetChar_IHandler ()
		{
			if (cb_setChar_I == null)
				cb_setChar_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChar_I);
			return cb_setChar_I;
		}

		static void n_SetChar_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setChar' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChar", "(I)V", "GetSetChar_IHandler")]
		public virtual unsafe void SetChar (int p0)
		{
			if (id_setChar_I == IntPtr.Zero)
				id_setChar_I = JNIEnv.GetMethodID (class_ref, "setChar", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChar_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChar", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setChars_arrayC;
#pragma warning disable 0169
		static Delegate GetSetChars_arrayCHandler ()
		{
			if (cb_setChars_arrayC == null)
				cb_setChars_arrayC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChars_arrayC);
			return cb_setChars_arrayC;
		}

		static void n_SetChars_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] p0 = (char[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.SetChars (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChars_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setChars' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("setChars", "([C)V", "GetSetChars_arrayCHandler")]
		public virtual unsafe void SetChars (char[] p0)
		{
			if (id_setChars_arrayC == IntPtr.Zero)
				id_setChars_arrayC = JNIEnv.GetMethodID (class_ref, "setChars", "([C)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChars_arrayC, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChars", "([C)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDividerColor_I;
#pragma warning disable 0169
		static Delegate GetSetDividerColor_IHandler ()
		{
			if (cb_setDividerColor_I == null)
				cb_setDividerColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerColor_I);
			return cb_setDividerColor_I;
		}

		static void n_SetDividerColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDividerColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDividerColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='setDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDividerColor", "(I)V", "GetSetDividerColor_IHandler")]
		public virtual unsafe void SetDividerColor (int p0)
		{
			if (id_setDividerColor_I == IntPtr.Zero)
				id_setDividerColor_I = JNIEnv.GetMethodID (class_ref, "setDividerColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_sync;
#pragma warning disable 0169
		static Delegate GetSyncHandler ()
		{
			if (cb_sync == null)
				cb_sync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Sync);
			return cb_sync;
		}

		static void n_Sync (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xenione.Digit.TabDigit __this = global::Java.Lang.Object.GetObject<global::Com.Xenione.Digit.TabDigit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sync ();
		}
#pragma warning restore 0169

		static IntPtr id_sync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xenione.digit']/class[@name='TabDigit']/method[@name='sync' and count(parameter)=0]"
		[Register ("sync", "()V", "GetSyncHandler")]
		public virtual unsafe void Sync ()
		{
			if (id_sync == IntPtr.Zero)
				id_sync = JNIEnv.GetMethodID (class_ref, "sync", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sync);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sync", "()V"));
			} finally {
			}
		}

	}
}

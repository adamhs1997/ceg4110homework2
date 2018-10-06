using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Turki.Vectoranalogclockview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']"
	[global::Android.Runtime.Register ("com/turki/vectoranalogclockview/VectorAnalogClock", DoNotGenerateAcw=true)]
	public abstract partial class VectorAnalogClock : global::Android.Widget.RelativeLayout {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/turki/vectoranalogclockview/VectorAnalogClock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VectorAnalogClock); }
		}

		protected VectorAnalogClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/constructor[@name='VectorAnalogClock' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe VectorAnalogClock (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
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
				if (((object) this).GetType () != typeof (VectorAnalogClock)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/constructor[@name='VectorAnalogClock' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe VectorAnalogClock (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (VectorAnalogClock)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/constructor[@name='VectorAnalogClock' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe VectorAnalogClock (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (VectorAnalogClock)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/constructor[@name='VectorAnalogClock' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VectorAnalogClock (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VectorAnalogClock)) {
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

		static Delegate cb_getCalendar;
#pragma warning disable 0169
		static Delegate GetGetCalendarHandler ()
		{
			if (cb_getCalendar == null)
				cb_getCalendar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalendar);
			return cb_getCalendar;
		}

		static IntPtr n_GetCalendar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		static IntPtr id_getCalendar;
		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "GetGetCalendarHandler")]
			get {
				if (id_getCalendar == IntPtr.Zero)
					id_getCalendar = JNIEnv.GetMethodID (class_ref, "getCalendar", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendar", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDiameterInDp;
#pragma warning disable 0169
		static Delegate GetGetDiameterInDpHandler ()
		{
			if (cb_getDiameterInDp == null)
				cb_getDiameterInDp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDiameterInDp);
			return cb_getDiameterInDp;
		}

		static float n_GetDiameterInDp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiameterInDp;
		}
#pragma warning restore 0169

		static IntPtr id_getDiameterInDp;
		public virtual unsafe float DiameterInDp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getDiameterInDp' and count(parameter)=0]"
			[Register ("getDiameterInDp", "()F", "GetGetDiameterInDpHandler")]
			get {
				if (id_getDiameterInDp == IntPtr.Zero)
					id_getDiameterInDp = JNIEnv.GetMethodID (class_ref, "getDiameterInDp", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDiameterInDp);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiameterInDp", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getDiameterInPixels;
#pragma warning disable 0169
		static Delegate GetGetDiameterInPixelsHandler ()
		{
			if (cb_getDiameterInPixels == null)
				cb_getDiameterInPixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDiameterInPixels);
			return cb_getDiameterInPixels;
		}

		static int n_GetDiameterInPixels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiameterInPixels;
		}
#pragma warning restore 0169

		static IntPtr id_getDiameterInPixels;
		public virtual unsafe int DiameterInPixels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getDiameterInPixels' and count(parameter)=0]"
			[Register ("getDiameterInPixels", "()I", "GetGetDiameterInPixelsHandler")]
			get {
				if (id_getDiameterInPixels == IntPtr.Zero)
					id_getDiameterInPixels = JNIEnv.GetMethodID (class_ref, "getDiameterInPixels", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDiameterInPixels);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiameterInPixels", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowingSeconds;
#pragma warning disable 0169
		static Delegate GetIsShowingSecondsHandler ()
		{
			if (cb_isShowingSeconds == null)
				cb_isShowingSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowingSeconds);
			return cb_isShowingSeconds;
		}

		static bool n_IsShowingSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowingSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_isShowingSeconds;
		public virtual unsafe bool IsShowingSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='isShowingSeconds' and count(parameter)=0]"
			[Register ("isShowingSeconds", "()Z", "GetIsShowingSecondsHandler")]
			get {
				if (id_isShowingSeconds == IntPtr.Zero)
					id_isShowingSeconds = JNIEnv.GetMethodID (class_ref, "isShowingSeconds", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowingSeconds);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowingSeconds", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOpacity);
			return cb_getOpacity;
		}

		static float n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public virtual unsafe float Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()F", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		public virtual unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_initializeCustom_IIII;
#pragma warning disable 0169
		static Delegate GetInitializeCustom_IIIIHandler ()
		{
			if (cb_initializeCustom_IIII == null)
				cb_initializeCustom_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_InitializeCustom_IIII);
			return cb_initializeCustom_IIII;
		}

		static void n_InitializeCustom_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeCustom (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_initializeCustom_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='initializeCustom' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("initializeCustom", "(IIII)V", "GetInitializeCustom_IIIIHandler")]
		public virtual unsafe void InitializeCustom (int p0, int p1, int p2, int p3)
		{
			if (id_initializeCustom_IIII == IntPtr.Zero)
				id_initializeCustom_IIII = JNIEnv.GetMethodID (class_ref, "initializeCustom", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeCustom_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeCustom", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initializeSimple;
#pragma warning disable 0169
		static Delegate GetInitializeSimpleHandler ()
		{
			if (cb_initializeSimple == null)
				cb_initializeSimple = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeSimple);
			return cb_initializeSimple;
		}

		static void n_InitializeSimple (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeSimple ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeSimple;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='initializeSimple' and count(parameter)=0]"
		[Register ("initializeSimple", "()V", "GetInitializeSimpleHandler")]
		public virtual unsafe void InitializeSimple ()
		{
			if (id_initializeSimple == IntPtr.Zero)
				id_initializeSimple = JNIEnv.GetMethodID (class_ref, "initializeSimple", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeSimple);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeSimple", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCalendar_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetCalendar_Ljava_util_Calendar_Handler ()
		{
			if (cb_setCalendar_Ljava_util_Calendar_ == null)
				cb_setCalendar_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCalendar_Ljava_util_Calendar_);
			return cb_setCalendar_Ljava_util_Calendar_;
		}

		static IntPtr n_SetCalendar_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCalendar (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCalendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setCalendar' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setCalendar", "(Ljava/util/Calendar;)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetCalendar_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetCalendar (global::Java.Util.Calendar p0)
		{
			if (id_setCalendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_setCalendar_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setCalendar", "(Ljava/util/Calendar;)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCalendar_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalendar", "(Ljava/util/Calendar;)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetColor_I);
			return cb_setColor_I;
		}

		static IntPtr n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetColor_IHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetColor (int p0)
		{
			if (id_setColor_I == IntPtr.Zero)
				id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDiameterInDp_F;
#pragma warning disable 0169
		static Delegate GetSetDiameterInDp_FHandler ()
		{
			if (cb_setDiameterInDp_F == null)
				cb_setDiameterInDp_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetDiameterInDp_F);
			return cb_setDiameterInDp_F;
		}

		static IntPtr n_SetDiameterInDp_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDiameterInDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDiameterInDp_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setDiameterInDp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDiameterInDp", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetDiameterInDp_FHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetDiameterInDp (float p0)
		{
			if (id_setDiameterInDp_F == IntPtr.Zero)
				id_setDiameterInDp_F = JNIEnv.GetMethodID (class_ref, "setDiameterInDp", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDiameterInDp_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiameterInDp", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDiameterInPixels_I;
#pragma warning disable 0169
		static Delegate GetSetDiameterInPixels_IHandler ()
		{
			if (cb_setDiameterInPixels_I == null)
				cb_setDiameterInPixels_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDiameterInPixels_I);
			return cb_setDiameterInPixels_I;
		}

		static IntPtr n_SetDiameterInPixels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDiameterInPixels (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDiameterInPixels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setDiameterInPixels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDiameterInPixels", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetDiameterInPixels_IHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetDiameterInPixels (int p0)
		{
			if (id_setDiameterInPixels_I == IntPtr.Zero)
				id_setDiameterInPixels_I = JNIEnv.GetMethodID (class_ref, "setDiameterInPixels", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDiameterInPixels_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiameterInPixels", "(I)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOpacity_F;
#pragma warning disable 0169
		static Delegate GetSetOpacity_FHandler ()
		{
			if (cb_setOpacity_F == null)
				cb_setOpacity_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetOpacity_F);
			return cb_setOpacity_F;
		}

		static IntPtr n_SetOpacity_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOpacity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOpacity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setOpacity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setOpacity", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetOpacity_FHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetOpacity (float p0)
		{
			if (id_setOpacity_F == IntPtr.Zero)
				id_setOpacity_F = JNIEnv.GetMethodID (class_ref, "setOpacity", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOpacity_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOpacity", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetScale_F);
			return cb_setScale_F;
		}

		static IntPtr n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetScale (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScale", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetScale_FHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetScale (float p0)
		{
			if (id_setScale_F == IntPtr.Zero)
				id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setShowSeconds_Z;
#pragma warning disable 0169
		static Delegate GetSetShowSeconds_ZHandler ()
		{
			if (cb_setShowSeconds_Z == null)
				cb_setShowSeconds_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShowSeconds_Z);
			return cb_setShowSeconds_Z;
		}

		static IntPtr n_SetShowSeconds_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Turki.Vectoranalogclockview.VectorAnalogClock __this = global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShowSeconds (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setShowSeconds_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.turki.vectoranalogclockview']/class[@name='VectorAnalogClock']/method[@name='setShowSeconds' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowSeconds", "(Z)Lcom/turki/vectoranalogclockview/VectorAnalogClock;", "GetSetShowSeconds_ZHandler")]
		public virtual unsafe global::Com.Turki.Vectoranalogclockview.VectorAnalogClock SetShowSeconds (bool p0)
		{
			if (id_setShowSeconds_Z == IntPtr.Zero)
				id_setShowSeconds_Z = JNIEnv.GetMethodID (class_ref, "setShowSeconds", "(Z)Lcom/turki/vectoranalogclockview/VectorAnalogClock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShowSeconds_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Turki.Vectoranalogclockview.VectorAnalogClock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowSeconds", "(Z)Lcom/turki/vectoranalogclockview/VectorAnalogClock;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/turki/vectoranalogclockview/VectorAnalogClock", DoNotGenerateAcw=true)]
	internal partial class VectorAnalogClockInvoker : VectorAnalogClock {

		public VectorAnalogClockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (VectorAnalogClockInvoker); }
		}

	}

}

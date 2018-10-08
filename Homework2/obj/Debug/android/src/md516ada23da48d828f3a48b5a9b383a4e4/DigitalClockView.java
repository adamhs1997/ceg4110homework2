package md516ada23da48d828f3a48b5a9b383a4e4;


public class DigitalClockView
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Homework2.DigitalClockView, Homework2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DigitalClockView.class, __md_methods);
	}


	public DigitalClockView ()
	{
		super ();
		if (getClass () == DigitalClockView.class)
			mono.android.TypeManager.Activate ("Homework2.DigitalClockView, Homework2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

package mono.com.google.android.play.core.tasks;


public class OnSuccessListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.play.core.tasks.OnSuccessListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSuccess:(Ljava/lang/Object;)V:GetOnSuccess_Ljava_lang_Object_Handler:Com.Google.Android.Play.Core.Tasks.IOnSuccessListenerInvoker, PlayCore\n" +
			"";
		mono.android.Runtime.register ("Com.Google.Android.Play.Core.Tasks.IOnSuccessListenerImplementor, PlayCore", OnSuccessListenerImplementor.class, __md_methods);
	}


	public OnSuccessListenerImplementor ()
	{
		super ();
		if (getClass () == OnSuccessListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Google.Android.Play.Core.Tasks.IOnSuccessListenerImplementor, PlayCore", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSuccess (java.lang.Object p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (java.lang.Object p0);

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

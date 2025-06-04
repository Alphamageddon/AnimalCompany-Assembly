namespace UnityEngine.InputSystem.Controls;

public class KeyControl : ButtonControl
{
	[CompilerGenerated]
	private Key <keyCode>k__BackingField; //Field offset: 0x130
	private int m_ScanCode; //Field offset: 0x134

	public Key keyCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int scanCode
	{
		 get { } //Length: 28
	}

	public KeyControl() { }

	[CompilerGenerated]
	public Key get_keyCode() { }

	public int get_scanCode() { }

	protected virtual void RefreshConfiguration() { }

	[CompilerGenerated]
	public void set_keyCode(Key value) { }

}


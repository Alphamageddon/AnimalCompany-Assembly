namespace UnityEngine;

public struct LazyLoadReference
{
	[SerializeField]
	private int m_InstanceID; //Field offset: 0x0

	public T asset
	{
		 get { } //Length: 196
	}

	public bool isBroken
	{
		 get { } //Length: 116
	}

	public bool isSet
	{
		 get { } //Length: 16
	}

	public T get_asset() { }

	public bool get_isBroken() { }

	public bool get_isSet() { }

}


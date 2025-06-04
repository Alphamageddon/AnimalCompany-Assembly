namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer
{
	private int m_Id; //Field offset: 0x0

	public int id
	{
		 get { } //Length: 8
	}

	public static SortingLayer[] layers
	{
		 get { } //Length: 192
	}

	public int value
	{
		 get { } //Length: 60
	}

	public int get_id() { }

	public static SortingLayer[] get_layers() { }

	public int get_value() { }

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	public static int GetLayerValueFromID(int id) { }

	[FreeFunction("GetTagManager().GetSortingLayerIDs")]
	private static Int32[] GetSortingLayerIDsInternal() { }

	[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
	public static string IDToName(int id) { }

}


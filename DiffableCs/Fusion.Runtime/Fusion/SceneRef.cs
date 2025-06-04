namespace Fusion;

[NetworkStructWeaved(1)]
public struct SceneRef : INetworkStruct, IEquatable<SceneRef>
{
	public const int SIZE = 4; //Field offset: 0x0
	public const uint FLAG_ADDRESSABLE = 2147483648; //Field offset: 0x0
	public uint RawValue; //Field offset: 0x0

	public int AsIndex
	{
		 get { } //Length: 144
	}

	public uint AsPathHash
	{
		 get { } //Length: 144
	}

	public bool IsIndex
	{
		 get { } //Length: 16
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	public static SceneRef None
	{
		 get { } //Length: 8
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(SceneRef other) { }

	public static SceneRef FromIndex(int index) { }

	public static SceneRef FromPath(string path) { }

	public static SceneRef FromRaw(uint rawValue) { }

	public int get_AsIndex() { }

	public uint get_AsPathHash() { }

	public bool get_IsIndex() { }

	public bool get_IsValid() { }

	public static SceneRef get_None() { }

	public virtual int GetHashCode() { }

	public bool IsPath(string path) { }

	public static bool op_Equality(SceneRef a, SceneRef b) { }

	public static bool op_Inequality(SceneRef a, SceneRef b) { }

	public virtual string ToString() { }

	public string ToString(bool brackets, bool prefix) { }

}


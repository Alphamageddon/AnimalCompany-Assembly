namespace Fusion;

[IsReadOnly]
public struct NetworkLoadSceneParameters : IEquatable<NetworkLoadSceneParameters>
{
	public readonly NetworkSceneLoadId LoadId; //Field offset: 0x0
	private readonly NetworkLoadSceneParametersFlags _flags; //Field offset: 0x1

	public bool IsActiveOnLoad
	{
		 get { } //Length: 12
	}

	public bool IsLocalPhysics2D
	{
		 get { } //Length: 12
	}

	public bool IsLocalPhysics3D
	{
		 get { } //Length: 12
	}

	public bool IsSingleLoad
	{
		 get { } //Length: 12
	}

	public LoadSceneMode LoadSceneMode
	{
		 get { } //Length: 16
	}

	public LoadSceneParameters LoadSceneParameters
	{
		 get { } //Length: 48
	}

	public LocalPhysicsMode LocalPhysicsMode
	{
		 get { } //Length: 12
	}

	internal NetworkLoadSceneParameters(NetworkSceneLoadId loadId, NetworkLoadSceneParametersFlags flags) { }

	public override bool Equals(NetworkLoadSceneParameters other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsActiveOnLoad() { }

	public bool get_IsLocalPhysics2D() { }

	public bool get_IsLocalPhysics3D() { }

	public bool get_IsSingleLoad() { }

	public LoadSceneMode get_LoadSceneMode() { }

	public LoadSceneParameters get_LoadSceneParameters() { }

	public LocalPhysicsMode get_LocalPhysicsMode() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkLoadSceneParameters left, NetworkLoadSceneParameters right) { }

	public static bool op_Inequality(NetworkLoadSceneParameters left, NetworkLoadSceneParameters right) { }

	public virtual string ToString() { }

}


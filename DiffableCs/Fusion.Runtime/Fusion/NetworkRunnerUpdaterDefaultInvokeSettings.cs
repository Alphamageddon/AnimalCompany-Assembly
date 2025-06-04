namespace Fusion;

public struct NetworkRunnerUpdaterDefaultInvokeSettings : IEquatable<NetworkRunnerUpdaterDefaultInvokeSettings>
{
	public Type ReferencePlayerLoopSystem; //Field offset: 0x0
	public UnityPlayerLoopSystemAddMode AddMode; //Field offset: 0x8

	public override bool Equals(NetworkRunnerUpdaterDefaultInvokeSettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkRunnerUpdaterDefaultInvokeSettings left, NetworkRunnerUpdaterDefaultInvokeSettings right) { }

	public static bool op_Inequality(NetworkRunnerUpdaterDefaultInvokeSettings left, NetworkRunnerUpdaterDefaultInvokeSettings right) { }

	public virtual string ToString() { }

}


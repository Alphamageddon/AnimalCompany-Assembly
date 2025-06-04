namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands;

[IsReadOnly]
internal struct HandExpressionName : IEquatable<HandExpressionName>
{
	public static readonly HandExpressionName Default; //Field offset: 0x0
	private readonly InternedString m_InternedString; //Field offset: 0x0

	private static HandExpressionName() { }

	public HandExpressionName(string value) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(HandExpressionName other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HandExpressionName lhs, HandExpressionName rhs) { }

	public static string op_Implicit(HandExpressionName value) { }

	public static HandExpressionName op_Implicit(string value) { }

	public static bool op_Inequality(HandExpressionName lhs, HandExpressionName rhs) { }

	public virtual string ToString() { }

}


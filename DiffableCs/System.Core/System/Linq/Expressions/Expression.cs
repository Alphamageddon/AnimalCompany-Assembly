namespace System.Linq.Expressions;

public abstract class Expression
{
	private class ExtensionInfo
	{
		internal readonly ExpressionType NodeType; //Field offset: 0x10

	}

	public class LambdaExpressionProxy
	{

	}

	public class MemberExpressionProxy
	{

	}

	public class UnaryExpressionProxy
	{

	}

	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; //Field offset: 0x0
	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable; //Field offset: 0x8

	public override ExpressionType NodeType
	{
		 get { } //Length: 240
	}

	private static Expression() { }

	public override ExpressionType get_NodeType() { }

}


namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{

	public MemberInfo Member
	{
		 get { } //Length: 12
	}

	public MemberInfo get_Member() { }

	[ExcludeFromCodeCoverage]
	internal override MemberInfo GetMember() { }

}


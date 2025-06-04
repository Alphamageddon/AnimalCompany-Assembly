namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression
{
	private readonly Expression _body; //Field offset: 0x10

	public Expression Body
	{
		 get { } //Length: 8
	}

	public Expression get_Body() { }

}


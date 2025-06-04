namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class CallContext
{

	private CallContext() { }

	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}


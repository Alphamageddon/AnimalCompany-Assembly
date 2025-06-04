namespace Unity.XR.CoreUtils.Bindings.Variables;

public class BindableVariable : BindableVariableBase<T>
{

	public BindableVariable`1(T initialValue = null, bool checkEquality = true, Func<T, T, Boolean> equalityMethod = null, bool startInitialized = false) { }

	public virtual bool ValueEquals(T other) { }

}


namespace Unity.XR.CoreUtils.Bindings.Variables;

public class BindableVariableAlloc : BindableVariableBase<T>
{

	public BindableVariableAlloc`1(T initialValue = null, bool checkEquality = true, Func<T, T, Boolean> equalityMethod = null, bool startInitialized = false) { }

}


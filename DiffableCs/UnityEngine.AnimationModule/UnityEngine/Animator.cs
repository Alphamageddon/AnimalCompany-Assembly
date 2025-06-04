namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		 get { } //Length: 60
	}

	public int layerCount
	{
		 get { } //Length: 60
	}

	public int parameterCount
	{
		 get { } //Length: 60
	}

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		 get { } //Length: 60
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 set { } //Length: 68
	}

	[NativeMethod("HasBoundPlayables")]
	public bool get_hasBoundPlayables() { }

	public int get_layerCount() { }

	public int get_parameterCount() { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	public AnimatorControllerParameter[] get_parameters() { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public bool GetBool(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	private bool GetBoolID(int id) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public float GetFloat(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	private float GetFloatID(int id) { }

	public int GetInteger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	private int GetIntegerID(int id) { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public bool IsParameterControlledByCurve(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void ResetTrigger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	private void ResetTriggerString(string name) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public void SetBool(int id, bool value) { }

	public void SetBool(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	private void SetBoolString(string name, bool value) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	private void SetFloatString(string name, float value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	private void SetIntegerString(string name, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	private void SetTriggerString(string name) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	public static int StringToHash(string name) { }

}


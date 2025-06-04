namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 60
	}

	public string tag
	{
		 get { } //Length: 112
	}

	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 60
	}

	public Component() { }

	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public bool CompareTag(string tag) { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	public string get_tag() { }

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	public T GetComponent() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInParent() { }

	public T GetComponentInParent(bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	public T[] GetComponents() { }

	public void GetComponents(Type type, List<Component> results) { }

	public void GetComponents(List<T> results) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent() { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

	public bool TryGetComponent(out T component) { }

}


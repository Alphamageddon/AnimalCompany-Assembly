namespace UnityEngine.ProBuilder;

[DisallowMultipleComponent]
internal sealed class ColliderBehaviour : EntityBehaviour
{

	public ColliderBehaviour() { }

	public virtual void Initialize() { }

	public virtual void OnEnterPlayMode() { }

	public virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

}


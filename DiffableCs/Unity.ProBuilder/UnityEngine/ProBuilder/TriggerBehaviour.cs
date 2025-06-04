namespace UnityEngine.ProBuilder;

[DisallowMultipleComponent]
internal sealed class TriggerBehaviour : EntityBehaviour
{

	public TriggerBehaviour() { }

	public virtual void Initialize() { }

	public virtual void OnEnterPlayMode() { }

	public virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

}


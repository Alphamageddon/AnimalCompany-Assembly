namespace UnityEngine.Animations.Rigging;

internal class RigSyncSceneToStreamJobBinder : AnimationJobBinder<RigSyncSceneToStreamJob, T>
{
	internal static String[] s_PropertyElementNames; //Field offset: 0x0

	private static RigSyncSceneToStreamJobBinder`1() { }

	public RigSyncSceneToStreamJobBinder`1() { }

	public virtual RigSyncSceneToStreamJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(RigSyncSceneToStreamJob job) { }

	public virtual void Update(RigSyncSceneToStreamJob job, ref T data) { }

}


namespace UnityEngine;

[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup : IDisposable
{
	internal sealed class StateChanged : MulticastDelegate
	{

		public StateChanged(object object, IntPtr method) { }

		public override void Invoke(CullingGroupEvent sphere) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	private StateChanged m_OnStateChanged; //Field offset: 0x18

	public Camera targetCamera
	{
		 set { } //Length: 68
	}

	public CullingGroup() { }

	public override void Dispose() { }

	[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = True)]
	private void DisposeInternal() { }

	protected virtual void Finalize() { }

	[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = True, IsThreadSafe = True)]
	private void FinalizerFailure() { }

	[FreeFunction("CullingGroup_Bindings::Init")]
	private static IntPtr Init(object scripting) { }

	public int QueryIndices(bool visible, Int32[] result, int firstIndex) { }

	[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = True)]
	[NativeThrows]
	private int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Int32[] result, int firstIndex) { }

	[RequiredByNativeCode]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	public void set_targetCamera(Camera value) { }

	[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = True)]
	public void SetBoundingDistances(Single[] distances) { }

	public void SetBoundingSphereCount(int count) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

	public void SetDistanceReferencePoint(Vector3 point) { }

	[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = True)]
	private void SetDistanceReferencePoint_InternalVector3(Vector3 point) { }

	private void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point) { }

}


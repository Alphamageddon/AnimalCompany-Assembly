namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRRayProvider
{

	public Vector3 rayEndPoint
	{
		 get { } //Length: 0
	}

	public Transform rayEndTransform
	{
		 get { } //Length: 0
	}

	public Vector3 get_rayEndPoint() { }

	public Transform get_rayEndTransform() { }

	public Transform GetOrCreateAttachTransform() { }

	public Transform GetOrCreateRayOrigin() { }

	public void SetAttachTransform(Transform newAttach) { }

	public void SetRayOrigin(Transform newOrigin) { }

}


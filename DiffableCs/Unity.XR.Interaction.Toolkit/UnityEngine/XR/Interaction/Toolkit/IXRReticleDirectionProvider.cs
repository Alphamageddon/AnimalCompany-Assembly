namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRReticleDirectionProvider
{

	public void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Nullable<Vector3>& optionalReticleForward) { }

}


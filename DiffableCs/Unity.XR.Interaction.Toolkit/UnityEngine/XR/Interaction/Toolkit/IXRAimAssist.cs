namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRAimAssist
{

	public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity) { }

	public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity, float maxAngle) { }

}


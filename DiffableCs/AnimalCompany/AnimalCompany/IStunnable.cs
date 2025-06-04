namespace AnimalCompany;

public interface IStunnable
{
	internal enum AttenuationType
	{
		SharpQuadratic = 0,
		SoftLinear = 1,
	}


	public static float GetAttenuation(AttenuationType type, Vector3 stunSourcePos, float stunRange, Vector3 viewPos, Vector3 viewDir) { }

	public static float GetAttenuationSimple(Vector3 stunSourcePos, float stunRange, Vector3 viewPos) { }

	public void Stun(Vector3 position, float stunRange, float duration = 3, string hitName = "", NetworkBehaviourId source = null, AttenuationType attenType = 0) { }

}


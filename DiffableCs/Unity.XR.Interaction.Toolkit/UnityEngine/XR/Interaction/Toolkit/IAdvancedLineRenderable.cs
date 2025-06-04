namespace UnityEngine.XR.Interaction.Toolkit;

public interface IAdvancedLineRenderable : ILineRenderable
{

	public void GetLineOriginAndDirection(out Vector3 origin, out Vector3 direction) { }

	public bool GetLinePoints(ref NativeArray<Vector3>& linePoints, out int numPoints, Nullable<Ray> rayOriginOverride = null) { }

}


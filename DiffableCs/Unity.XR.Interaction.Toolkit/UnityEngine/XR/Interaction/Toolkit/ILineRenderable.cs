namespace UnityEngine.XR.Interaction.Toolkit;

public interface ILineRenderable
{

	public bool GetLinePoints(ref Vector3[] linePoints, out int numPoints) { }

	public bool TryGetHitInfo(out Vector3 position, out Vector3 normal, out int positionInLine, out bool isValidTarget) { }

}


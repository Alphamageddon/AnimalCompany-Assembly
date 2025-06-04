namespace Fusion.XR.Host.Rig;

public interface IHandRepresentation
{

	public GameObject gameObject
	{
		 get { } //Length: 0
	}

	public bool IsMeshDisplayed
	{
		 get { } //Length: 0
	}

	public Material SharedHandMaterial
	{
		 get { } //Length: 0
	}

	public void DisplayMesh(bool shouldDisplay) { }

	public GameObject get_gameObject() { }

	public bool get_IsMeshDisplayed() { }

	public Material get_SharedHandMaterial() { }

	public void SetHandColor(Color color) { }

	public void SetHandCommand(HandCommand command) { }

	public void SetHandMaterial(Material material) { }

}


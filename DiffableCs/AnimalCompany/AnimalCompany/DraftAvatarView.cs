namespace AnimalCompany;

public class DraftAvatarView : MonoBehaviour
{
	public AvatarView draftAvatarView; //Field offset: 0x20
	public AvatarArmature draftArmature; //Field offset: 0x28
	private AvatarArmature _localAramatureCache; //Field offset: 0x30

	private AvatarArmature _localArmature
	{
		private get { } //Length: 264
	}

	public DraftAvatarView() { }

	private AvatarArmature get__localArmature() { }

	private void OnDisable() { }

	private void OnDraftAvatarChanged(StateChangedEventArgs args) { }

	private void OnEnable() { }

	private void Update() { }

}


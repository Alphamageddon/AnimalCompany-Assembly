namespace AnimalCompany;

public class SetDraftAvatarColorAction : BaseAction
{
	private Color _color; //Field offset: 0x14

	public SetDraftAvatarColorAction(Color color) { }

	public virtual void Execute(AppState state) { }

}


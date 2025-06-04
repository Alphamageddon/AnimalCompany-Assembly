namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

[Preserve]
public abstract class FallbackComposite : InputBindingComposite<TValue>
{
	public struct QuaternionCompositeComparer : IComparer<Quaternion>
	{

		public override int Compare(Quaternion x, Quaternion y) { }

	}


	protected FallbackComposite`1() { }

}


namespace UnityEngine.Animations.Rigging;

public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform>
{
	public Transform transform; //Field offset: 0x0
	public float weight; //Field offset: 0x8

	private override Transform UnityEngine.Animations.Rigging.ITransformProvider.transform
	{
		private get { } //Length: 8
		private set { } //Length: 8
	}

	private override float UnityEngine.Animations.Rigging.IWeightProvider.weight
	{
		private get { } //Length: 8
		private set { } //Length: 28
	}

	public WeightedTransform(Transform transform, float weight) { }

	public static WeightedTransform Default(float weight) { }

	public override bool Equals(WeightedTransform other) { }

	private override Transform UnityEngine.Animations.Rigging.ITransformProvider.get_transform() { }

	private override void UnityEngine.Animations.Rigging.ITransformProvider.set_transform(Transform value) { }

	private override float UnityEngine.Animations.Rigging.IWeightProvider.get_weight() { }

	private override void UnityEngine.Animations.Rigging.IWeightProvider.set_weight(float value) { }

}


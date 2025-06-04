namespace UnityEngine.Animations.Rigging;

public class WeightedTransformArrayBinder
{

	public WeightedTransformArrayBinder() { }

	public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle>& transforms) { }

	public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle>& transforms) { }

	public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle>& weights) { }

}


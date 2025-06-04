namespace UnityEngine.Animations.Rigging;

[BurstCompile]
internal struct RigSyncSceneToStreamJob : IAnimationJob
{
	public struct PropertySyncer : IDisposable
	{
		public NativeArray<PropertySceneHandle> sceneHandles; //Field offset: 0x0
		public NativeArray<PropertyStreamHandle> streamHandles; //Field offset: 0x10
		public NativeArray<Single> buffer; //Field offset: 0x20

		public void BindAt(int index, Animator animator, Component component, string property) { }

		public static PropertySyncer Create(int size) { }

		public override void Dispose() { }

		public NativeArray<Single> StreamValues(ref AnimationStream stream) { }

		public void Sync(ref AnimationStream stream) { }

	}

	internal struct TransformSyncer : IDisposable
	{
		public NativeArray<TransformSceneHandle> sceneHandles; //Field offset: 0x0
		public NativeArray<TransformStreamHandle> streamHandles; //Field offset: 0x10

		public void BindAt(int index, Animator animator, Transform transform) { }

		public static TransformSyncer Create(int size) { }

		public override void Dispose() { }

		public void Sync(ref AnimationStream stream) { }

	}

	public TransformSyncer transformSyncer; //Field offset: 0x0
	public PropertySyncer propertySyncer; //Field offset: 0x20
	public PropertySyncer rigWeightSyncer; //Field offset: 0x50
	public PropertySyncer constraintWeightSyncer; //Field offset: 0x80
	public NativeArray<Single> rigStates; //Field offset: 0xB0
	public NativeArray<Int32> rigConstraintEndIdx; //Field offset: 0xC0
	public NativeArray<PropertyStreamHandle> modulatedConstraintWeights; //Field offset: 0xD0

	public override void ProcessAnimation(AnimationStream stream) { }

	public override void ProcessRootMotion(AnimationStream stream) { }

}


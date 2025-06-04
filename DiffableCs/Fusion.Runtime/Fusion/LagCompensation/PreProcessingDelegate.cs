namespace Fusion.LagCompensation;

public sealed class PreProcessingDelegate : MulticastDelegate
{

	public PreProcessingDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Query query, HashSet<HitboxRoot> rootCandidates, HashSet<Int32> processedColliderIndices, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Query query, HashSet<HitboxRoot> rootCandidates, HashSet<Int32> processedColliderIndices) { }

}


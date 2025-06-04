namespace Unity.XR.CoreUtils;

public class CachedComponentFilter : IDisposable
{
	private static readonly List<TFilterType> k_TempComponentList; //Field offset: 0x0
	private static readonly List<IComponentHost`1<TFilterType>> k_TempHostComponentList; //Field offset: 0x0
	private readonly List<TFilterType> m_MasterComponentStorage; //Field offset: 0x0
	private bool m_DisposedValue; //Field offset: 0x0

	private static CachedComponentFilter`2() { }

	public CachedComponentFilter`2(TRootType componentRoot, CachedSearchType cachedSearchType = 3, bool includeDisabled = true) { }

	public CachedComponentFilter`2(TFilterType[] componentList, bool includeDisabled = true) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	private void FilteredCopyToMaster(bool includeDisabled) { }

	private void FilteredCopyToMaster(bool includeDisabled, TRootType requiredRoot) { }

	public TChildType[] GetMatchingComponents() { }

	public void StoreMatchingComponents(List<TChildType> outputList) { }

}


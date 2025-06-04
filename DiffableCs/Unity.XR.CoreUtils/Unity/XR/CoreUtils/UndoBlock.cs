namespace Unity.XR.CoreUtils;

public class UndoBlock : IDisposable
{
	private int m_UndoGroup; //Field offset: 0x10
	private bool m_DisposedValue; //Field offset: 0x14

	public UndoBlock(string undoLabel, bool testMode = false) { }

	public T AddComponent(GameObject gameObject) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public void RecordObject(object objectToUndo) { }

	public void RegisterCreatedObject(object objectToUndo) { }

	public void SetTransformParent(Transform transform, Transform newParent) { }

}


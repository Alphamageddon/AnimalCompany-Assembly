namespace UnityEngine.Animations.Rigging;

internal interface IRigSyncSceneToStreamData
{

	public Boolean[] rigStates
	{
		 get { } //Length: 0
	}

	public SyncableProperties[] syncableProperties
	{
		 get { } //Length: 0
	}

	public Transform[] syncableTransforms
	{
		 get { } //Length: 0
	}

	public Boolean[] get_rigStates() { }

	public SyncableProperties[] get_syncableProperties() { }

	public Transform[] get_syncableTransforms() { }

}


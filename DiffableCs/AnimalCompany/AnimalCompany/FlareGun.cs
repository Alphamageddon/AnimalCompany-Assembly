namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class FlareGun : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <Shoot>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlareGun <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <Shoot>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private Transform _barrelTip; //Field offset: 0x88
	[SerializeField]
	private RandomSFX _sfxShoot; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _sfxShootEmpty; //Field offset: 0x98
	[SerializeField]
	private float _shootForce; //Field offset: 0xA0
	[SerializeField]
	private GameObject _projectilePrefab; //Field offset: 0xA8
	[DefaultForProperty("hasAmmo", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _hasAmmo; //Field offset: 0xB0

	[Networked]
	[NetworkedWeaved(0, 1)]
	public bool hasAmmo
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public FlareGun() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public bool get_hasAmmo() { }

	private void HandleRespawned() { }

	private void HandleUse() { }

	private void OnDestroy() { }

	public void set_hasAmmo(bool value) { }

	[IteratorStateMachine(typeof(<Shoot>d__14))]
	private IEnumerator Shoot() { }

}


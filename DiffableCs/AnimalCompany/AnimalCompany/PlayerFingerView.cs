namespace AnimalCompany;

public class PlayerFingerView : MonoBehaviour
{
	[Header("Smoothing")]
	public bool smoothingValues; //Field offset: 0x20
	private float _targetThumbValue; //Field offset: 0x24
	private float _targetIndexValue; //Field offset: 0x28
	private float _targetMiddleValue; //Field offset: 0x2C
	private float _thumbValue; //Field offset: 0x30
	private float _indexValue; //Field offset: 0x34
	private float _middleValue; //Field offset: 0x38
	private bool _isSmoothingThumb; //Field offset: 0x3C
	private bool _isSmoothingIndex; //Field offset: 0x3D
	private bool _isSmoothingMiddle; //Field offset: 0x3E
	[Header("Bones")]
	[SerializeField]
	private Transform[] _thumbBones; //Field offset: 0x40
	[SerializeField]
	private Transform[] _indexBones; //Field offset: 0x48
	[SerializeField]
	private Transform[] _middleBones; //Field offset: 0x50
	[SerializeField]
	private Transform[] _ringBones; //Field offset: 0x58
	[SerializeField]
	private Transform[] _pinkyBones; //Field offset: 0x60
	[Header("Reference to copy values")]
	[SerializeField]
	private PlayerFingerView _fingerViewOtherSide; //Field offset: 0x68
	[Header("Store values")]
	public Single[] _thumbStretchValues; //Field offset: 0x70
	public Single[] _indexStretchValues; //Field offset: 0x78
	public Single[] _middleStretchValues; //Field offset: 0x80
	public Single[] _ringStretchValues; //Field offset: 0x88
	public Single[] _pinkyStretchValues; //Field offset: 0x90
	public Single[] _thumbBentValues; //Field offset: 0x98
	public Single[] _indexBentValues; //Field offset: 0xA0
	public Single[] _middleBentValues; //Field offset: 0xA8
	public Single[] _ringBentValues; //Field offset: 0xB0
	public Single[] _pinkyBentValues; //Field offset: 0xB8
	[Header("Debug")]
	[SerializeField]
	private bool _testInEditor; //Field offset: 0xC0
	[Range(0, 1)]
	[SerializeField]
	private float _thumbValueDebug; //Field offset: 0xC4
	[Range(0, 1)]
	[SerializeField]
	private float _indexValueDebug; //Field offset: 0xC8
	[Range(0, 1)]
	[SerializeField]
	private float _middleValueDebug; //Field offset: 0xCC

	private float _smoothingSpeed
	{
		private get { } //Length: 28
	}

	public PlayerFingerView() { }

	private void ApplyIndexValues(float value) { }

	private void ApplyMiddleValues(float value) { }

	private void ApplyThumbValues(float value) { }

	private float get__smoothingSpeed() { }

	private float GetInterpolatedValue(float stretch, float bent, float value) { }

	public void SetIndexValues(float value) { }

	public void SetMiddleValues(float value) { }

	public void SetThumbValues(float value) { }

	private void Update() { }

}


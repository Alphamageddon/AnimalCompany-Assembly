namespace AnimalCompany;

public class PlayerFingerValueReceiver : MonoBehaviour
{
	internal class FingerValues
	{
		public bool isThumbTouched; //Field offset: 0x10
		public bool isThumbPressed; //Field offset: 0x11
		public float triggerValue; //Field offset: 0x14
		public float gripValue; //Field offset: 0x18

		public float indexValue
		{
			 get { } //Length: 8
		}

		public float middleValue
		{
			 get { } //Length: 8
		}

		public float thumbValue
		{
			 get { } //Length: 44
		}

		public FingerValues() { }

		public float get_indexValue() { }

		public float get_middleValue() { }

		public float get_thumbValue() { }

	}

	public Dictionary<HandSide, FingerValues> handValues; //Field offset: 0x20
	public Action<Single[]> onAnyFingerValuesChanged; //Field offset: 0x28

	public PlayerFingerValueReceiver() { }

	private void Awake() { }

	private Single[] GetFingerValues() { }

	private void HandleLeftGripValueChanged(float value) { }

	private void HandleLeftThumbPressed() { }

	private void HandleLeftThumbReleased() { }

	private void HandleLeftThumbTouched() { }

	private void HandleLeftThumbUntouched() { }

	private void HandleLeftTriggerValueChanged(float value) { }

	private void HandleRightGripValueChanged(float value) { }

	private void HandleRightThumbPressed() { }

	private void HandleRightThumbReleased() { }

	private void HandleRightThumbTouched() { }

	private void HandleRightThumbUntouched() { }

	private void HandleRightTriggerValueChanged(float value) { }

	private void OnDestroy() { }

}


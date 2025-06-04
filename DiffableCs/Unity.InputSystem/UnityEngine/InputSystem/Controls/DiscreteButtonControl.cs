namespace UnityEngine.InputSystem.Controls;

public class DiscreteButtonControl : ButtonControl
{
	internal enum WriteMode
	{
		WriteDisabled = 0,
		WriteNullAndMaxValue = 1,
	}

	public int minValue; //Field offset: 0x130
	public int maxValue; //Field offset: 0x134
	public int wrapAtValue; //Field offset: 0x138
	public int nullValue; //Field offset: 0x13C
	public WriteMode writeMode; //Field offset: 0x140

	public DiscreteButtonControl() { }

	protected virtual void FinishSetup() { }

	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}


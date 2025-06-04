namespace Fusion;

internal class VariableFeedback : IFeedbackController
{
	private readonly double _Kp; //Field offset: 0x10
	private readonly double _Ki; //Field offset: 0x18
	private readonly double _Kd; //Field offset: 0x20
	private readonly double _outputMin; //Field offset: 0x28
	private readonly double _outputMax; //Field offset: 0x30
	private double _lastSample; //Field offset: 0x38
	private double _sum; //Field offset: 0x40
	private double _output; //Field offset: 0x48

	public VariableFeedback(double Kp, double Ki, double Kd, double outputMin, double outputMax) { }

	private override double Fusion.IFeedbackController.Output() { }

	private override void Fusion.IFeedbackController.Reset() { }

	private override void Fusion.IFeedbackController.ResetOutput() { }

	private override void Fusion.IFeedbackController.Update(double sample, double target, double dt) { }

}


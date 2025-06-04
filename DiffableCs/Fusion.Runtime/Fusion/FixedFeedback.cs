namespace Fusion;

internal class FixedFeedback : IFeedbackController
{
	private readonly double _outputMin; //Field offset: 0x10
	private readonly double _outputMax; //Field offset: 0x18
	private readonly double _deadzoneMin; //Field offset: 0x20
	private readonly double _deadzoneMax; //Field offset: 0x28
	private double _output; //Field offset: 0x30

	public FixedFeedback(double outputMin, double outputMax, double deadzoneMin, double deadzoneMax) { }

	private override double Fusion.IFeedbackController.Output() { }

	private override void Fusion.IFeedbackController.Reset() { }

	private override void Fusion.IFeedbackController.ResetOutput() { }

	private override void Fusion.IFeedbackController.Update(double sample, double target, double dt) { }

}


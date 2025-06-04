namespace Fusion;

internal interface IFeedbackController
{

	public double Output() { }

	public void Reset() { }

	public void ResetOutput() { }

	public void Update(double sample, double target, double dt) { }

}


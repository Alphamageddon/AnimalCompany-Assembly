namespace UnityEngine.XR.Interaction.Toolkit;

public static class XRInteractionUpdateOrder
{
	internal enum UpdatePhase
	{
		Fixed = 0,
		Dynamic = 1,
		Late = 2,
		OnBeforeRender = 3,
	}

	public const int k_ControllerRecorder = -30000; //Field offset: 0x0
	public const int k_BeforeRenderGazeAssistance = 95; //Field offset: 0x0
	public const int k_LineVisual = 100; //Field offset: 0x0
	public const int k_Interactables = -98; //Field offset: 0x0
	public const int k_InteractableSnapVolume = -99; //Field offset: 0x0
	public const int k_Interactors = -99; //Field offset: 0x0
	public const int k_InteractionGroups = -100; //Field offset: 0x0
	public const int k_BeforeRenderOrder = 100; //Field offset: 0x0
	public const int k_InteractionManager = -105; //Field offset: 0x0
	public const int k_TwoHandedGrabMoveProviders = -209; //Field offset: 0x0
	public const int k_LocomotionProviders = -210; //Field offset: 0x0
	public const int k_GazeAssistance = -29980; //Field offset: 0x0
	public const int k_TransformStabilizer = -29985; //Field offset: 0x0
	public const int k_Controllers = -29990; //Field offset: 0x0
	public const int k_DeviceSimulator = -29991; //Field offset: 0x0
	public const int k_UIInputModule = -200; //Field offset: 0x0
	public const int k_BeforeRenderLineVisual = 101; //Field offset: 0x0

}


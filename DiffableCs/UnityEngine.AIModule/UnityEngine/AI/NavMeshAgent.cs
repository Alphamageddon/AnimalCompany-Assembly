namespace UnityEngine.AI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshAgent.html")]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public sealed class NavMeshAgent : Behaviour
{

	public float angularSpeed
	{
		 set { } //Length: 76
	}

	public Vector3 destination
	{
		 get { } //Length: 92
	}

	public bool isOnNavMesh
	{
		[NativeName("InCrowdSystem")]
		 get { } //Length: 60
	}

	public bool isOnOffMeshLink
	{
		[NativeName("IsOnOffMeshLink")]
		 get { } //Length: 60
	}

	public bool isStopped
	{
		[FreeFunction("NavMeshAgentScriptBindings::GetIsStopped", HasExplicitThis = True)]
		 get { } //Length: 60
		[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = True)]
		 set { } //Length: 68
	}

	public bool pathPending
	{
		[NativeName("PathPending")]
		 get { } //Length: 60
	}

	public float speed
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public bool updatePosition
	{
		 set { } //Length: 68
	}

	public bool updateRotation
	{
		 set { } //Length: 68
	}

	public Vector3 velocity
	{
		 set { } //Length: 84
	}

	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path) { }

	[FreeFunction("NavMeshAgentScriptBindings::CalculatePathInternal", HasExplicitThis = True)]
	private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path) { }

	private bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path) { }

	public Vector3 get_destination() { }

	private void get_destination_Injected(out Vector3 ret) { }

	[NativeName("InCrowdSystem")]
	public bool get_isOnNavMesh() { }

	[NativeName("IsOnOffMeshLink")]
	public bool get_isOnOffMeshLink() { }

	[FreeFunction("NavMeshAgentScriptBindings::GetIsStopped", HasExplicitThis = True)]
	public bool get_isStopped() { }

	[NativeName("PathPending")]
	public bool get_pathPending() { }

	public float get_speed() { }

	public void Move(Vector3 offset) { }

	private void Move_Injected(ref Vector3 offset) { }

	public void ResetPath() { }

	public void set_angularSpeed(float value) { }

	[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = True)]
	public void set_isStopped(bool value) { }

	public void set_speed(float value) { }

	public void set_updatePosition(bool value) { }

	public void set_updateRotation(bool value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

	public bool SetDestination(Vector3 target) { }

	private bool SetDestination_Injected(ref Vector3 target) { }

	public bool Warp(Vector3 newPosition) { }

	private bool Warp_Injected(ref Vector3 newPosition) { }

}


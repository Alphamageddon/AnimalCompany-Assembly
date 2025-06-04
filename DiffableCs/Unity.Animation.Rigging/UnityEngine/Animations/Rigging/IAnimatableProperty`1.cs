namespace UnityEngine.Animations.Rigging;

public interface IAnimatableProperty
{

	public T Get(AnimationStream stream) { }

	public void Set(AnimationStream stream, T value) { }

}


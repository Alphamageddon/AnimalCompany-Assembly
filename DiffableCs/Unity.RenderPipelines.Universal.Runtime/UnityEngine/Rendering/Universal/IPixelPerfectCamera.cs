namespace UnityEngine.Rendering.Universal;

internal interface IPixelPerfectCamera
{

	public int assetsPPU
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool cropFrameX
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool cropFrameY
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool pixelSnapping
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int refResolutionX
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int refResolutionY
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool stretchFill
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool upscaleRT
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int get_assetsPPU() { }

	public bool get_cropFrameX() { }

	public bool get_cropFrameY() { }

	public bool get_pixelSnapping() { }

	public int get_refResolutionX() { }

	public int get_refResolutionY() { }

	public bool get_stretchFill() { }

	public bool get_upscaleRT() { }

	public void set_assetsPPU(int value) { }

	public void set_cropFrameX(bool value) { }

	public void set_cropFrameY(bool value) { }

	public void set_pixelSnapping(bool value) { }

	public void set_refResolutionX(int value) { }

	public void set_refResolutionY(int value) { }

	public void set_stretchFill(bool value) { }

	public void set_upscaleRT(bool value) { }

}


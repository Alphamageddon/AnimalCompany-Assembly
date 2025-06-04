namespace Fusion;

public class HeapConfiguration
{
	[InlineHelp]
	public PageSizes PageShift; //Field offset: 0x10
	[InlineHelp]
	[Range(16, 4096)]
	public int PageCount; //Field offset: 0x14
	[HideInInspector]
	[InlineHelp]
	public int GlobalsSize; //Field offset: 0x18

	public HeapConfiguration() { }

	public HeapConfiguration Init(int globalsSize) { }

	internal Config ToAllocatorConfig() { }

	public virtual string ToString() { }

}


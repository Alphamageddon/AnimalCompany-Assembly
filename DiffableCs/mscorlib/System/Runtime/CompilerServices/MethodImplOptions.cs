namespace System.Runtime.CompilerServices;

[ComVisible(True)]
[Flags]
public enum MethodImplOptions
{
	Unmanaged = 4,
	ForwardRef = 16,
	PreserveSig = 128,
	InternalCall = 4096,
	Synchronized = 32,
	NoInlining = 8,
	AggressiveInlining = 256,
	NoOptimization = 64,
	SecurityMitigations = 1024,
}



using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory.DynamicFunctions;

namespace ExecutesPlugin.Memory
{
	public static class SmokeFunctions
	{
		public static MemoryFunctionWithReturn<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int> CSmokeGrenadeProjectile_CreateFunc = new(@"\x55\x4c\x89\xc1\x48\x89\xe5\x41\x57\x41\x56\x49\x89\xd6\x48\x89\xf2\x48\x89\xfe\x41\x55\x45\x89\xcd\x41\x54\x4d\x89\xc4\x53\x48\x83\xec\x28\x48\x89\x7d\xb8\x48");
		public static MemoryFunctionWithReturn<string, float, float, int> EmitSound = new(@"\x55\x48\x89\xe5\x41\x57\x41\x56\x41\x55\x41\x54\x53\x48\x81\xec\xa8\x00\x00\x00\x48\x85\xd2\x74\x08\x80\x3a\x00\x48\x89\xd3\x75\x1f\x49\xbc\x00\x00\x00\x00\xff\xff\xff\xff");
	}
}
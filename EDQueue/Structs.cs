using System;
using ObjCRuntime;

namespace EDQueues
{


	// => Enums attributed with[NativeAttribute] must have an underlying type of `long` or `ulong`
	[Native]
	public enum EDQueueResult : long
	{
		Success = 0,
		Fail,
		Critical
	}

}






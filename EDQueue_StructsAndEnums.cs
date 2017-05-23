using System;
using ObjCRuntime;

[Native]
public enum EDQueueResult : nint
{
	Success = 0,
	Fail,
	Critical
}

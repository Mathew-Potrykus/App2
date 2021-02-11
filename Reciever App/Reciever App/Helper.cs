using System;

namespace Reciever_App
{
	public static class Helper
	{
		public static Action<string> Return { get; internal set; }

		public static void SetReturn(Action<string> returnMethod)
		{
			if (Return == null)
			{
				Return = returnMethod;
			}
		}
	}
}

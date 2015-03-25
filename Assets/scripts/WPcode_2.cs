using UnityEngine;
using System.Collections;
using System;

public class WPcode_2 {

	public static event EventHandler extratask_2;
	public static void _action_2()
	{
		if (extratask_2 != null)
		{
			extratask_2(null, null);
		}
	}
}

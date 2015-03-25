using UnityEngine;
using System.Collections;
using System;

public class WPcode {

	public static event EventHandler extratask;
	public static void _action()
	{
		if (extratask != null)
		{
			extratask(null, null);
		}
	}
}
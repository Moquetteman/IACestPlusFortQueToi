using UnityEngine;
using System.Collections;

public static class IAScript{
	public static int decision()
	{
		int dec = Random.Range(1, 101);
		if (dec == 1) {
			return 1;		
		}
		return 0;
	}
}

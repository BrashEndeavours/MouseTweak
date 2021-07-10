using HarmonyLib;
using UnityEngine;

namespace MouseTweak {
	[HarmonyPatch(typeof(Cursor3D))]
	[HarmonyPatch("NormalCursorLock")]
	[HarmonyPatch(new[] {typeof(bool)})]
	internal class MouseLock {
		public static bool Prefix(bool isLocked)
		{
			Cursor.lockState = CursorLockMode.Confined;
			if (isLocked)
			{
				Cursor.visible = false;
				return false;
			}

			Cursor.lockState = CursorLockMode.None;
			return false;
		}
	}
}
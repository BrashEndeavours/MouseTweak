using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace MouseTweak.Patches
{
	[HarmonyPatch(typeof(FPSCamera))]
	[HarmonyPatch("LoadData")]
	internal class FPSMouse
	{
		private static void Postfix(ref Vector2 ___MouseLookSensitivity, ref int ___MouseLookSmoothSteps)
		{
			___MouseLookSensitivity *= Settings.fpsMouseSensitivity.Value;
			___MouseLookSmoothSteps = Settings.fpsMouseSmoothingSteps.Value;
		}
	}

	[HarmonyPatch(typeof(Cursor3D))]
	[HarmonyPatch("LoadData")]
	internal class RegularMouse
	{
		private static void Postfix(ref Vector2 ___MouseLookSensitivity, ref int ___MouseLookSmoothSteps)
		{
			___MouseLookSensitivity *= Settings.regularMouseSensitivity.Value;
			___MouseLookSmoothSteps = Settings.regularMouseSmoothingSteps.Value;
		}
	}
}
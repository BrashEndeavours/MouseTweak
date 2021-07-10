using HarmonyLib;
using UnityEngine;

namespace MouseTweak.Patches {
	[HarmonyPatch(typeof(IntroPlayer))]
	[HarmonyPatch("Awake")]
	internal class BackgroundExecution {
		private static void Prefix() {
			Application.runInBackground = true;
		}
	}
}
using BepInEx;
using HarmonyLib;

using MouseTweak.Patches;

namespace MouseTweak {

	[BepInPlugin("com.brash.cms.mousetweak", "MouseTweak", "1.0.0")]
	[BepInProcess("cms2018.exe")]
	public class MouseTweak : BaseUnityPlugin {
		#region Unity events
		private void Awake() {
			LoadConfig();
			Patch();
		}
		private void OnDestroy() {
			Unpatch();
		}
		#endregion

		#region Patching
		private Harmony harmonyInstance;
		private bool patched;

		private void Patch() {
			if (patched)
				return;

			harmonyInstance = new Harmony("com.brash.cms.mousetweak");
			PatchBackgroundExecution();
			PatchMouseMovementAndMouseLock();
			patched = true;
			Logger.LogInfo("Patching done!");
		}

		private void PatchBackgroundExecution() {
			if (Settings.backgroundExecution.Value) {
				harmonyInstance.PatchAll(typeof(BackgroundExecution));
				Logger.LogInfo("Applying BackgroundExecution patch");
			}
		}

		private void PatchMouseMovementAndMouseLock() {
			if (Settings.mouseEnhancements.Value) {
				harmonyInstance.PatchAll(typeof(MouseLock));
				harmonyInstance.PatchAll(typeof(RegularMouse));
				harmonyInstance.PatchAll(typeof(FPSMouse));
				Logger.LogInfo("Applying MouseMovement and MouseLock patches");
			}
		}

		private void Unpatch() {
			if (!patched)
				return;

			harmonyInstance.UnpatchAll();
			patched = false;
		}
		#endregion

		#region Config
		private void LoadConfig()
		{
			Settings.backgroundExecution = Config.Bind("General",
				"BackgroundExecution",
				true,
				"Enables or disables background execution.");

			Settings.mouseEnhancements = Config.Bind("General",
				"MouseEnhancements",
				true,
				"Enables or disables mouse enhancements.\n" +
				"Cursor movement is fixed and cursor is not locked in game window when in UI mode");

			Settings.fpsMouseSensitivity = Config.Bind("General",
					"FPSMouseSensitivity",
					0.5f,
					"Set the sensitivity of the mouse while in FPS mode.");

			Settings.fpsMouseSmoothingSteps = Config.Bind("General",
					"FPSMouseSmoothingSteps",
					1,
					"Set the maximum number of smoothing steps of the mouse when in FPS mode.\n" +
					"A value of 1 is a single step, and eliminates mouse lag.");
		
			Settings.regularMouseSensitivity = Config.Bind("General",
					"RegularMouseSensitivity",
					1.2f,
					"Set the sensitivity of the mouse while in menus.");

			Settings.regularMouseSmoothingSteps = Config.Bind("General",
					"RegularMouseSmoothingSteps",
					1,
					"Set the maximum number of smoothing steps of the mouse when in menus.\n" +
					"A value of 1 is a single step, and eliminates mouse lag.");

		#endregion
		}	
	}
}
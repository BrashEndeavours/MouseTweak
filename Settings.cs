using BepInEx.Configuration;

namespace MouseTweak {
	public static class Settings {
		public static ConfigEntry<bool> backgroundExecution;
		public static ConfigEntry<bool> mouseEnhancements;
		public static ConfigEntry<float> fpsMouseSensitivity;
		public static ConfigEntry<int> fpsMouseSmoothingSteps;
		public static ConfigEntry<float> regularMouseSensitivity;
		public static ConfigEntry<int> regularMouseSmoothingSteps;
	}
}
# MouseFix
Mod that fixes mouse behaviour in Car Mechanic Simulator 2018. 

### Features:
- Game can run in the background
- Mouse lock is disabled in UI mode
- Can set mouse sensitivities for both regular and FPS cameras.
- Can set mouse smoothing steps for a smoother (but delayed mouse).

### How to use
1. Install [BepInEx](https://bepinex.github.io/bepinex_docs/master/articles/user_guide/installation/index.html#installing-bepinex-1) if you don't have it already (use x64 version).
2. Download the latest build from the [Releases](https://github.com/brashendeavours/MouseTweak/releases/latest) page.
3. Copy MouseTweak.dll file into ```BepInEx\plugins``` folder in game directory.
4. Done!

### Configuration file
Config file can be found at ```BepInEx\config\com.brash.cms.mousetweak.cfg``` in game directory.

| Setting             | Default value |               Description                |
| :------------------ |:------------- | :--------------------------------------- |
| BackgroundExecution | true          | Enables or disables background execution. |
| MouseEnhancements	  | true          | Enables or disables mouse enhancements.<br> Cursor movement is fixed and cursor is not locked in game window when in UI mode   |
| FPSMouseSensitivity | 0.5f          | Set the sensitivity of the mouse while in menus. |
| FPSMouseSmoothingSteps | 1         | Set the maximum number of smoothing steps of the mouse when in FPS mode.<br> A value of 1 is a single step, and eliminates mouse lag. |
| RegularMouseSensitivity | 1.2f      | Set the sensitivity of the mouse while in FPS mode. |
| RegularMouseSmoothingSteps | 1     | Set the maximum number of smoothing steps of the mouse when in menus.<br> A value of 1 is a single step, and eliminates mouse lag. |

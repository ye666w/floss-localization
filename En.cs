using System.Collections.Generic;

namespace UnityWrappers.Localization.Resources
{
	public class En : TextResource
	{
		protected override Dictionary<TextKey, string> texts => textsTranslate;

		private readonly Dictionary<TextKey, string> textsTranslate;
		protected sealed override Dictionary<TextKey, string> keywords { get; } = new()
		{
			{ TextKey.WordPistol, "pistol" },
			{ TextKey.WordBow, "bow" },
			{ TextKey.WordSword, "sword" },
			{ TextKey.WordMine, "mine" },
			{ TextKey.WordShield, "shield" },
			{ TextKey.WordStaticShield, "aura" }
		};

		public En()
		{
			textsTranslate = new Dictionary<TextKey, string>
			{
				{ TextKey.WordPistol, P(TextKey.WordPistol) },
				{ TextKey.WordX5, "cooldown" },
				{ TextKey.WordSword, P(TextKey.WordSword) },
				{ TextKey.WordShield, P(TextKey.WordShield) },
				{ TextKey.WordDash, "dash" },
				{ TextKey.WordBow, P(TextKey.WordBow) },
				{ TextKey.WordX3, "power" },
				{ TextKey.WordMine, P(TextKey.WordMine) },
				{ TextKey.WordStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.MenuPause, "pause" },
				
				{ TextKey.MenuSkillsTab, "skills" },
				{ TextKey.MenuSettingsTab, "settings" },
				
				{ TextKey.MenuSkillsPistolDescription, "high fire rate, but low range" },
				{ TextKey.MenuSkillsPistolX5, "increases fire rate" },
				{ TextKey.MenuSkillsPistolX3, "turns into a shotgun" },
				{ TextKey.MenuSkillsPistolFeatures, "" },

				{ TextKey.MenuSkillsBowDescription, "low fire rate, but unlimited range" },
				{ TextKey.MenuSkillsBowX5, "increases charge speed" },
				{ TextKey.MenuSkillsBowX3, "pierces white shields" },
				{ TextKey.MenuSkillsBowFeatures, "- charges by 1/3 for each kill with any weapon\n- pierces up to three enemies" },

				{ TextKey.MenuSkillsSwordDescription, "melee combat" },
				{ TextKey.MenuSkillsSwordX5, "increases attack speed" },
				{ TextKey.MenuSkillsSwordX3, "increases hit radius" },
				{ TextKey.MenuSkillsSwordFeatures, "" },

				{ TextKey.MenuSkillsMineDescription, "activates on enemy contact" },
				{ TextKey.MenuSkillsMineX5, "increases activation speed" },
				{ TextKey.MenuSkillsMineX3, "increases explosion radius" },
				{ TextKey.MenuSkillsMineFeatures, $"- can be thrown with the {T("sword", ColorType.Blue)}\n- can be triggered with a {T("shot", ColorType.Red)}" },

				{ TextKey.MenuSkillsShieldDescription, $"blocks {T("bullets", ColorType.Yellow)} and destroys {T("enemies", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsShieldX5, "faster charge recovery" },
				{ TextKey.MenuSkillsShieldX3, "radius increases" },
				{ TextKey.MenuSkillsShieldFeatures, "- can be used during dash\n- restores charge for each kill with any weapon" },

				{ TextKey.MenuSkillsAuraDescription, $"blocks {T("bullets", ColorType.Yellow)} and {T("enemies", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsAuraX5, "faster charge recovery" },
				{ TextKey.MenuSkillsAuraX3, "radius increases" },
				{ TextKey.MenuSkillsAuraFeatures, "- grants one mana charge when used" },

				{ TextKey.MenuSkillsX5Description, "increases weapon fire rate" },
				{ TextKey.MenuSkillsX5Getting, "quickly kill five enemies" },

				{ TextKey.MenuSkillsX3Description, "empowers weapons" },
				{ TextKey.MenuSkillsX3Getting, "kill three enemies with a single projectile" },

				{ TextKey.MenuSettingsLanguagePage, "language" },
				{ TextKey.MenuSettingsColorsPage, "colors" },
				{ TextKey.MenuSettingsSoundPage, "sound" },
				{ TextKey.MenuSettingsVideoPage, "video" },
				{ TextKey.MenuSettingsMousePage, "mouse" },
				{ TextKey.MenuSettingsControlsPage, "controls" },
				{ TextKey.MenuSettingsSavesPage, "saves" },
				{ TextKey.MenuSettingsCreditsPage, "credits" },
				{ TextKey.MenuSettingsGameExit, $"{T("exit the game", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsSoundMasterVolume, "master" },
				{ TextKey.MenuSettingsSoundMusicVolume, "music" },
				{ TextKey.MenuSettingsSoundEffectsVolume, "effects" },
				{ TextKey.MenuSettingsSoundUIVolume, "ui" },
				
				{ TextKey.MenuSettingsVideoFullscreen, "fullscreen" },
				{ TextKey.MenuSettingsVideoMotionBlur, "motion blur" },
				{ TextKey.MenuSettingsVideoScreenShake, "screen shake" },
				
				{ TextKey.MenuSettingsMouseSensitivity, "mouse sensitivity" },
				{ TextKey.MenuSettingsControlsWheelCooldown, "mouse wheel cooldown" },
				
				{ TextKey.MenuSettingsControlBindingsPage, "bindings" },
				{ TextKey.MenuSettingsControlSchemePage, "scheme" },
				{ TextKey.MenuSettingsControlPause, "pause" },
				{ TextKey.MenuSettingsControlMovement, "movement" },
				{ TextKey.MenuSettingsControlUp, "up" },
				{ TextKey.MenuSettingsControlLeft, "left" },
				{ TextKey.MenuSettingsControlDown, "down" },
				{ TextKey.MenuSettingsControlRight, "right" },
				{ TextKey.MenuSettingsControlToHub, "return to hub" },
				{ TextKey.MenuSettingsControlRedWeapon, $"{T("fire", ColorType.Red)}" },
				{ TextKey.MenuSettingsControlBlueWeapon, $"{T("fire", ColorType.Blue)}" },
				{ TextKey.MenuSettingsControlYellowWeapon, $"{T("fire", ColorType.Yellow)}" },
				{ TextKey.MenuSettingsControlDash, "dash" },
				{ TextKey.MenuSettingsControlWeaponModifer, "weapons modifer" },
				
				{ TextKey.MenuSettingsSavesImport, $"{T("import saves", ColorType.Red)}" },
				{ TextKey.MenuSettingsSavesExport, "export saves" },
				{ TextKey.MenuSettingsSavesUnlockAll, $"{T("unlock all content", ColorType.Red)}"},
				{ TextKey.MenuSettingsSavesReset, $"{T("reset saves", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsCreditsTwitter, "twitter" },
				{ TextKey.MenuSettingsCreditsItch, "itch" },
				
				{ TextKey.UnlockBow, P(TextKey.WordBow) },
				{ TextKey.UnlockMine, P(TextKey.WordMine) },
				{ TextKey.UnlockStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.TutorialThisIsMana, "this is dash charge" },
				{ TextKey.TutorialManaDisplay, "dash charges" },
				{ TextKey.TutorialMoveHere, "stand here" },
				{ TextKey.TutorialDash, "dash to cursor position" },
				{ TextKey.TutorialMouseWheel, "scroll mouse wheel" },
				{ TextKey.TutorialDashWithShield, $"make dash with {T("shield", ColorType.Yellow)}" },
				{ TextKey.TutorialPortalIsBroken, "the developer broke the portal\nyou’ll have to get back to the hub yourself" },
				{ TextKey.TutorialPortalIsBrokenAgain, "portal is broken again" },
				{ TextKey.TutorialX3, "killing THREE enemies with a SINGLE shot\nempowers your guns" },

				{ TextKey.TextReset, "reset" },
				{ TextKey.TextRedReset, $"{T("reset", ColorType.Red)}" },
				{ TextKey.TextBack, "back" },
				{ TextKey.TextResume, "resume" },
				{ TextKey.TextSuccess, "success" },
				{ TextKey.TextError, "error" },
				{ TextKey.TextYes, "yes" },
				{ TextKey.TextNo, "no" },
				{ TextKey.TextMovement, "movement" },
				{ TextKey.TextDefend, "defend this" },
				{ TextKey.TextDescription, "description:" },
				{ TextKey.TextX5, "x5:" },
				{ TextKey.TextX3, "x3:" },
				{ TextKey.TextFeatures, "features:" },
				{ TextKey.TextGetting, "getting:" },
				{ TextKey.TextMoreInfo, $"press {T("TAB", ColorType.Red)} for details" },
				
				{ TextKey.SetupGuideHaveMouse, "Mouse or Touchpad?" },
				{ TextKey.SetupGuideMouse, "Mouse" },
				{ TextKey.SetupGuideTouchpad, "Touchpad" },
				{ TextKey.SetupGuideSideButtons, "click the side mouse button if it works" },
				{ TextKey.SetupGuideNoSideButtons, "I don't have side buttons" },
				{ TextKey.SetupGuideWheelScroll, "scroll the mouse wheel if it works" },
				{ TextKey.SetupGuideNoWheelScroll, "the scroll wheel doesn't work" },
				{ TextKey.SetupGuideMenuHint, "you can open the menu with Tab\nit contains many settings and useful information" },

				{ TextKey.BindingLMB, "left mouse button" },
				{ TextKey.BindingRMB, "right mouse button" },
				{ TextKey.BindingMMB, "middle mouse button" },
				{ TextKey.BindingSMB, "mouse side button" },
				{ TextKey.BindingSMBF, "mouse forward button" },
				{ TextKey.BindingSMBB, "mouse back button" },
			};
		}
	}
}
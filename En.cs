using System.Collections.Generic;

namespace UnityWrappers.Localization.TextResources
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
				{ TextKey.WordX5, "x5" },
				{ TextKey.WordSword, P(TextKey.WordSword) },
				{ TextKey.WordShield, P(TextKey.WordShield) },
				{ TextKey.WordDash, "dash" },
				{ TextKey.WordBow, P(TextKey.WordBow) },
				{ TextKey.WordX3, "x3" },
				{ TextKey.WordMine, P(TextKey.WordMine) },
				{ TextKey.WordStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.MenuPause, "pause" },
				
				{ TextKey.MenuSkillsTab, "skills" },
				{ TextKey.MenuSettingsTab, "settings" },
				
				{ TextKey.MenuSkillToHub, "return to hub" },
				
				{ TextKey.MenuSkillsPistolDescription, "High fire rate, but low range" },
				{ TextKey.MenuSkillsPistolX5, "Increases fire rate" },
				{ TextKey.MenuSkillsPistolX3, "Turns into a shotgun" },
				{ TextKey.MenuSkillsPistolFeatures, "" },

				{ TextKey.MenuSkillsBowDescription, "Low fire rate, but unlimited range" },
				{ TextKey.MenuSkillsBowX5, "Increases charge speed" },
				{ TextKey.MenuSkillsBowX3, "Pierces white shields" },
				{ TextKey.MenuSkillsBowFeatures, "• Charges by 1/3 for each kill with any weapon\n• Pierces up to three enemies" },

				{ TextKey.MenuSkillsSwordDescription, "Melee combat" },
				{ TextKey.MenuSkillsSwordX5, "Increases attack speed" },
				{ TextKey.MenuSkillsSwordX3, "Increases hit radius" },
				{ TextKey.MenuSkillsSwordFeatures, "" },

				{ TextKey.MenuSkillsMineDescription, "Activates on enemy contact" },
				{ TextKey.MenuSkillsMineX5, "Increases activation speed" },
				{ TextKey.MenuSkillsMineX3, "Increases explosion radius" },
				{ TextKey.MenuSkillsMineFeatures, $"• Can be thrown with the {T("sword", ColorType.Blue)}\n• Can be triggered with a {T("shot", ColorType.Red)}" },

				{ TextKey.MenuSkillsShieldDescription, $"Blocks {T("bullets", ColorType.Yellow)} and destroys {T("enemies", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsShieldX5, "Faster charge recovery" },
				{ TextKey.MenuSkillsShieldX3, "Radius increases" },
				{ TextKey.MenuSkillsShieldFeatures, "• Restores charge for each kill with any weapon" },

				{ TextKey.MenuSkillsAuraDescription, $"Blocks {T("bullets", ColorType.Yellow)} and {T("enemies", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsAuraX5, "Faster charge recovery" },
				{ TextKey.MenuSkillsAuraX3, "Radius increases" },
				{ TextKey.MenuSkillsAuraFeatures, "• Grants one dash charge when used" },

				{ TextKey.MenuSkillsX5Description, "Increases weapon fire rate" },
				{ TextKey.MenuSkillsX5Getting, "Quickly kill five enemies" },

				{ TextKey.MenuSkillsX3Description, "Empowers weapons" },
				{ TextKey.MenuSkillsX3Getting, "Kill three enemies with a single projectile" },

				{ TextKey.MenuSettingsLanguagePage, "language" },
				{ TextKey.MenuSettingsSoundPage, "sound" },
				{ TextKey.MenuSettingsVideoPage, "video" },
				{ TextKey.MenuSettingsMousePage, "mouse" },
				{ TextKey.MenuSettingsControlsPage, "controls" },
				{ TextKey.MenuSettingsConnectToServer, "online" },
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
				{ TextKey.MenuSettingsVideoVSync, "vSync" },
				{ TextKey.MenuSettingsVideoAntiAliasing, "anti aliasing" },
				{ TextKey.MenuSettingsVideoZeroQueuedFrames, "zero queued frames" },
				
				{ TextKey.MenuSettingsMouseSensitivity, "mouse sensitivity" },
				{ TextKey.MenuSettingsMouseHardwareCursor, "hardware cursor" },
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
				{ TextKey.MenuSettingsControlRestart, "restart" },
				
				{ TextKey.MenuSettingsSavesImport, $"{T("import saves", ColorType.Red)}" },
				{ TextKey.MenuSettingsSavesExport, "export saves" },
				{ TextKey.MenuSettingsSavesUnlockAll, $"{T("unlock all content", ColorType.Red)}"},
				{ TextKey.MenuSettingsSavesReset, $"{T("reset saves", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsCreditsTwitter, $"{T("link", ColorType.Blue)}" },
				
				{ TextKey.UnlockBow, P(TextKey.WordBow) },
				{ TextKey.UnlockMine, P(TextKey.WordMine) },
				{ TextKey.UnlockStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.TutorialThisIsMana, "kill to gain a dash charge" },
				{ TextKey.TutorialManaDisplay, "dash charges" },
				{ TextKey.TutorialMoveHere, "stand here" },
				{ TextKey.TutorialDash, "dash to cursor position" },
				{ TextKey.TutorialMouseWheel, "scroll mouse wheel" },
				{ TextKey.TutorialDashWithShield, $"make dash with {T("shield", ColorType.Yellow)}" },
				{ TextKey.TutorialPortalIsBroken, "return to the hub at any time" },
				{ TextKey.TutorialPortalIsBrokenAgain, "return to the hub" },
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
				{ TextKey.TextX5, "x5" },
				{ TextKey.TextX3, "x3" },
				{ TextKey.TextFeatures, "Features:" },
				{ TextKey.TextGetting, "Getting:" },
				{ TextKey.TextMoreInfo, $"press {T("ESC", ColorType.Green)} for details" },
				{ TextKey.TextApply, "apply" },
				
				{ TextKey.SetupGuideAnalytics, "allow analytics collection?" },
				{ TextKey.SetupGuideHaveMouse, "mouse or touchpad?" },
				{ TextKey.SetupGuideMouse, "mouse" },
				{ TextKey.SetupGuideTouchpad, "touchpad" },
				{ TextKey.SetupGuideSideButtons, "click the side mouse button if it works" },
				{ TextKey.SetupGuideNoSideButtons, "I don't have side buttons" },
				{ TextKey.SetupGuideWheelScroll, "scroll the mouse wheel if it works" },
				{ TextKey.SetupGuideNoWheelScroll, "the scroll wheel doesn't work" },

				{ TextKey.BindingLMB, "left mouse button" },
				{ TextKey.BindingRMB, "right mouse button" },
				{ TextKey.BindingMMB, "middle mouse button" },
				{ TextKey.BindingSMB, "mouse side button" },
				{ TextKey.BindingSMBF, "mouse forward button" },
				{ TextKey.BindingSMBB, "mouse back button" },
				{ TextKey.BindingLeftShift, "shift" },
				{ TextKey.BindingSpace, "space" },
				
				{ TextKey.ServerConnectFailed, $"server status: {T("offline", ColorType.Red)}" },
				{ TextKey.ServerConnectSuccess, $"server status: {T("online", ColorType.Green)}" },
				{ TextKey.ServerScoreUpdateFailed, $"score {T("not updated", ColorType.Red)}" },
				{ TextKey.ServerScoreUpdated, $"score {T("updated", ColorType.Green)}" },
				{ TextKey.ServerConnecting, "connecting" },
				{ TextKey.ServerLoading, "loading" },
				{ TextKey.ServerNoRecords, "no records" },

				{ TextKey.LeaderboardPlace, "#" },
				{ TextKey.LeaderboardPlayer, "player" },
				{ TextKey.LeaderboardSeed, "seed" },
				{ TextKey.LeaderboardScore, "score" },
				{ TextKey.LeaderboardPortalsCount, "portals" },
				{ TextKey.LeaderboardRandomSeed, "random" },
				{ TextKey.LeaderboardInvalidSeedMessage, $"{T("seed must be 'random' or a valid integer", ColorType.Red)}" }
			};
		}
	}
}
using System.Collections.Generic;

namespace UnityWrappers.Localization.Resources
{
	public class Ru : TextResource
	{
		protected override Dictionary<TextKey, string> texts => textsTranslate;

		private readonly Dictionary<TextKey, string> textsTranslate;
		protected sealed override Dictionary<TextKey, string> keywords { get; } = new()
		{
			{ TextKey.WordPistol, "пистолет" },
			{ TextKey.WordBow, "лук" },
			{ TextKey.WordSword, "меч" },
			{ TextKey.WordMine, "мина" },
			{ TextKey.WordShield, "щит" },
			{ TextKey.WordStaticShield, "аура" }
		};

		public Ru()
		{
			textsTranslate = new Dictionary<TextKey, string>
			{
				{ TextKey.WordPistol, P(TextKey.WordPistol) },
				{ TextKey.WordX5, "кулдаун" },
				{ TextKey.WordSword, P(TextKey.WordSword) },
				{ TextKey.WordShield, P(TextKey.WordShield) },
				{ TextKey.WordDash, "рывок" },
				{ TextKey.WordBow, P(TextKey.WordBow) },
				{ TextKey.WordX3, "сила" },
				{ TextKey.WordMine, P(TextKey.WordMine) },
				{ TextKey.WordStaticShield, P(TextKey.WordStaticShield) },

				{ TextKey.MenuPause, "пауза" },
				
				{ TextKey.MenuSkillsTab, "навыки" },
				{ TextKey.MenuSettingsTab, "настройки" },
				
				{ TextKey.MenuSkillToHub, "хаб" },
				
				{ TextKey.MenuSkillsPistolDescription, "высокая скорострельность, но малая дальность" },
				{ TextKey.MenuSkillsPistolX5, "повышается скорострельность" },
				{ TextKey.MenuSkillsPistolX3, "превращается в дробовик" },
				{ TextKey.MenuSkillsPistolFeatures, "" },
				
				{ TextKey.MenuSkillsBowDescription, "низкая скорострельность, но неограниченная дальность" },
				{ TextKey.MenuSkillsBowX5, "повышается скорость зарядки" },
				{ TextKey.MenuSkillsBowX3, "пробивает белые щиты" },
				{ TextKey.MenuSkillsBowFeatures, "- заряжается на 1/3 за каждое убийство любым оружием\n- пробивает до трех противников" },
				
				{ TextKey.MenuSkillsSwordDescription, "ближний бой" },
				{ TextKey.MenuSkillsSwordX5, "повышается скорость удара" },
				{ TextKey.MenuSkillsSwordX3, "увеличивается дальность поражения" },
				{ TextKey.MenuSkillsSwordFeatures, "" },
				
				{ TextKey.MenuSkillsMineDescription, "активируется при касании врага" },
				{ TextKey.MenuSkillsMineX5, "повышается скорострельность" },
				{ TextKey.MenuSkillsMineX3, "увеличивается радиус поражения" },
				{ TextKey.MenuSkillsMineFeatures, $"- можно метнуть {T("мечом", ColorType.Blue)}\n- можно активировать {T("выстрелом", ColorType.Red)}" },
				
				{ TextKey.MenuSkillsShieldDescription, $"защищает от {T("пуль", ColorType.Yellow)} и {T("врагов", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsShieldX5, "ускоряется восстановление заряда" },
				{ TextKey.MenuSkillsShieldX3, "увеличивается" },
				{ TextKey.MenuSkillsShieldFeatures, "- можно использовать во время рывка\n- восстанавливает заряд за каждое убийство любым оружием" },
				
				{ TextKey.MenuSkillsAuraDescription, $"защищает от {T("пуль", ColorType.Yellow)} и {T("врагов", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsAuraX5, "ускоряется восстановление заряда" },
				{ TextKey.MenuSkillsAuraX3, "увеличивается радиус" },
				{ TextKey.MenuSkillsAuraFeatures, "- дает один заряд рывка при установке" },
				
				{ TextKey.MenuSkillsX5Description, "увеличивает скорострельность пушек" },
				{ TextKey.MenuSkillsX5Getting, "быстро убить пятерых противников" },
				
				{ TextKey.MenuSkillsX3Description, "усиливает пушки" },
				{ TextKey.MenuSkillsX3Getting, "убить трёх противников одним снарядом" },
				
				{ TextKey.MenuSettingsLanguagePage, "язык" },
				{ TextKey.MenuSettingsSoundPage, "звук" },
				{ TextKey.MenuSettingsVideoPage, "видео" },
				{ TextKey.MenuSettingsMousePage, "мышь" },
				{ TextKey.MenuSettingsControlsPage, "управление" },
				{ TextKey.MenuSettingsSavesPage, "сохранения" },
				{ TextKey.MenuSettingsCreditsPage, "авторы" },
				{ TextKey.MenuSettingsGameExit, $"{T("выйти из игры", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsSoundMusicVolume, "музыка" },
				{ TextKey.MenuSettingsSoundMasterVolume, "мастер" },
				{ TextKey.MenuSettingsSoundEffectsVolume, "эффекты" },
				{ TextKey.MenuSettingsSoundUIVolume, "интерфейс" },
				
				{ TextKey.MenuSettingsVideoFullscreen, "на весь экран" },
				{ TextKey.MenuSettingsVideoMotionBlur, "размытие" },
				{ TextKey.MenuSettingsVideoScreenShake, "тряска экрана" },
				
				{ TextKey.MenuSettingsMouseSensitivity, "чувствительность мыши" },
				{ TextKey.MenuSettingsControlsWheelCooldown, "кулдаун колеса мыши" },
				
				{ TextKey.MenuSettingsControlBindingsPage, "бинды" },
				{ TextKey.MenuSettingsControlSchemePage, "схема" },
				{ TextKey.MenuSettingsControlPause, "пауза" },
				{ TextKey.MenuSettingsControlMovement, "передвижение" },
				{ TextKey.MenuSettingsControlUp, "вверх" },
				{ TextKey.MenuSettingsControlLeft, "лево" },
				{ TextKey.MenuSettingsControlDown, "вниз" },
				{ TextKey.MenuSettingsControlRight, "право" },
				{ TextKey.MenuSettingsControlToHub, "возврат в хаб" },
				{ TextKey.MenuSettingsControlRedWeapon, $"{T("выстрел", ColorType.Red)}" },
				{ TextKey.MenuSettingsControlBlueWeapon, $"{T("выстрел", ColorType.Blue)}" },
				{ TextKey.MenuSettingsControlYellowWeapon, $"{T("выстрел", ColorType.Yellow)}" },
				{ TextKey.MenuSettingsControlDash, "рывок" },
				{ TextKey.MenuSettingsControlWeaponModifer, "модификатор пушек" },
				
				{ TextKey.MenuSettingsSavesImport, $"{T("импортировать сохранения", ColorType.Red)}" },
				{ TextKey.MenuSettingsSavesExport, "экспорт сохранения" },
				{ TextKey.MenuSettingsSavesUnlockAll, $"{T("разблокировать весь контент", ColorType.Red)}"},
				{ TextKey.MenuSettingsSavesReset, $"{T("сбросить сохранения", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsCreditsTwitter, "twitter" },
				{ TextKey.MenuSettingsCreditsItch, "itch" },
				
				{ TextKey.UnlockBow, P(TextKey.WordBow) },
				{ TextKey.UnlockMine, P(TextKey.WordMine) },
				{ TextKey.UnlockStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.TutorialThisIsMana, "это заряд для рывка" },
				{ TextKey.TutorialManaDisplay, "заряды рывка" },
				{ TextKey.TutorialMoveHere, "встань тут" },
				{ TextKey.TutorialDash, "рывок в позицию курсора" },
				{ TextKey.TutorialMouseWheel, "прокрути колесо мыши" },
				{ TextKey.TutorialDashWithShield, $"сделай рывок с {T("щитом", ColorType.Yellow)}" },
				{ TextKey.TutorialPortalIsBroken, "разработчик сломал портал\nпридется вернуться в хаб самому" },
				{ TextKey.TutorialPortalIsBrokenAgain, "портал опять сломан" },
				{ TextKey.TutorialX3, "убийство ТРЕХ противников ОДНИМ выстрелом\nусиливает пушки" },
				
				{ TextKey.TextReset, "сброс" },
				{ TextKey.TextRedReset, $"{T("сброс", ColorType.Red)}" },
				{ TextKey.TextBack, "назад" },
				{ TextKey.TextResume, "продолжить" },
				{ TextKey.TextSuccess, "успех" },
				{ TextKey.TextError, "ошибка" },
				{ TextKey.TextYes, "да" },
				{ TextKey.TextNo, "нет" },
				{ TextKey.TextMovement, "передвижение" },
				{ TextKey.TextDefend, "защищай" },
				{ TextKey.TextDescription, "описание:" },
				{ TextKey.TextX5, "x5:" },
				{ TextKey.TextX3, "x3:" },
				{ TextKey.TextFeatures, "особенности:" },
				{ TextKey.TextGetting, "получение:" },
				{ TextKey.TextMoreInfo, $"подробности - {T("TAB", ColorType.Red)}" },
				{ TextKey.TextApply, "применить" },
				
				{ TextKey.SetupGuideAnalytics, "разрешить сбор аналитики?" },
				{ TextKey.SetupGuideHaveMouse, "мышь или тачпад?" },
				{ TextKey.SetupGuideMouse, "мышь" },
				{ TextKey.SetupGuideTouchpad, "тачпад" },
				{ TextKey.SetupGuideSideButtons, "нажми боковую кнопку мыши, если она есть" },
				{ TextKey.SetupGuideNoSideButtons, "у меня нет боковых кнопок" },
				{ TextKey.SetupGuideWheelScroll, "покрути колесо мыши, если оно работает" },
				{ TextKey.SetupGuideNoWheelScroll, "колесо мыши не работает" },
				{ TextKey.SetupGuideMenuHint, "меню можно открыть на Tab\nв нем много настроек и полезной информации" },
				
				{ TextKey.BindingLMB, "левая кнопка мыши" },
				{ TextKey.BindingRMB, "правая кнопка мыши" },
				{ TextKey.BindingMMB, "средняя кнопка мыши" },
				{ TextKey.BindingSMB, "боковая кнопка мыши" },
				{ TextKey.BindingSMBF, "боковая кнопка мыши" },
				{ TextKey.BindingSMBB, "боковая кнопка мыши" },
				{ TextKey.BindingLeftShift, "шифт" },
				{ TextKey.BindingSpace, "пробел" }
			};
		}
	}
}
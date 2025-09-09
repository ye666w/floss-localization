using System.Collections.Generic;

namespace UnityWrappers.Localization.Resources
{
	public class ZhHans : TextResource
	{
		protected override Dictionary<TextKey, string> texts => textsTranslate;

		private readonly Dictionary<TextKey, string> textsTranslate;
		protected sealed override Dictionary<TextKey, string> keywords { get; } = new()
		{
			{ TextKey.WordPistol, "手枪" },
			{ TextKey.WordBow, "弓" },
			{ TextKey.WordSword, "剑" },
			{ TextKey.WordMine, "地雷" },
			{ TextKey.WordShield, "盾牌" },
			{ TextKey.WordStaticShield, "光环" }
		};

		public ZhHans()
		{
			textsTranslate = new Dictionary<TextKey, string>
			{
				{ TextKey.WordPistol, P(TextKey.WordPistol) },
				{ TextKey.WordX5, "冷却时间" },
				{ TextKey.WordSword, P(TextKey.WordSword) },
				{ TextKey.WordShield, P(TextKey.WordShield) },
				{ TextKey.WordDash, "冲刺" },
				{ TextKey.WordBow, P(TextKey.WordBow) },
				{ TextKey.WordX3, "力量" },
				{ TextKey.WordMine, P(TextKey.WordMine) },
				{ TextKey.WordStaticShield, P(TextKey.WordStaticShield) },

				{ TextKey.MenuPause, "暂停" },
				
				{ TextKey.MenuSkillsTab, "技能" },
				{ TextKey.MenuSettingsTab, "设置" },
				
				{ TextKey.MenuSkillToHub, "中心" },
				
				{ TextKey.MenuSkillsPistolDescription, "射速高，但射程短" },
				{ TextKey.MenuSkillsPistolX5, "射速提升" },
				{ TextKey.MenuSkillsPistolX3, "变成霰弹枪" },
				{ TextKey.MenuSkillsPistolFeatures, "" },
				
				{ TextKey.MenuSkillsBowDescription, "射速低，但射程无限" },
				{ TextKey.MenuSkillsBowX5, "充能速度提升" },
				{ TextKey.MenuSkillsBowX3, "可穿透白色护盾" },
				{ TextKey.MenuSkillsBowFeatures, "- 每次击杀任意敌人可获得1/3的充能\n- 最多可穿透三名敌人" },
				
				{ TextKey.MenuSkillsSwordDescription, "近战武器" },
				{ TextKey.MenuSkillsSwordX5, "攻击速度提升" },
				{ TextKey.MenuSkillsSwordX3, "攻击范围增加" },
				{ TextKey.MenuSkillsSwordFeatures, "" },
				
				{ TextKey.MenuSkillsMineDescription, "敌人触碰后触发" },
				{ TextKey.MenuSkillsMineX5, "投掷速度提升" },
				{ TextKey.MenuSkillsMineX3, "爆炸范围增加" },
				{ TextKey.MenuSkillsMineFeatures, $"- 可用 {T("剑", ColorType.Blue)} 投掷\n- 可用 {T("射击", ColorType.Red)} 引爆" },
				
				{ TextKey.MenuSkillsShieldDescription, $"可防御 {T("子弹", ColorType.Yellow)} 和 {T("敌人", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsShieldX5, "充能恢复更快" },
				{ TextKey.MenuSkillsShieldX3, "防御范围增加" },
				{ TextKey.MenuSkillsShieldFeatures, "- 冲刺时可使用\n- 每次击杀都会恢复充能" },
				
				{ TextKey.MenuSkillsAuraDescription, $"可防御 {T("子弹", ColorType.Yellow)} 和 {T("敌人", ColorType.Yellow)}" },
				{ TextKey.MenuSkillsAuraX5, "充能恢复更快" },
				{ TextKey.MenuSkillsAuraX3, "光环范围增加" },
				{ TextKey.MenuSkillsAuraFeatures, "- 放置时增加1点冲刺次数" },
				
				{ TextKey.MenuSkillsX5Description, "提升所有武器的射速" },
				{ TextKey.MenuSkillsX5Getting, "快速击杀 5 名敌人" },
				
				{ TextKey.MenuSkillsX3Description, "强化武器" },
				{ TextKey.MenuSkillsX3Getting, "用一发子弹击杀 3 名敌人" },
				
				{ TextKey.MenuSettingsLanguagePage, "语言" },
				{ TextKey.MenuSettingsSoundPage, "音效" },
				{ TextKey.MenuSettingsVideoPage, "画面" },
				{ TextKey.MenuSettingsMousePage, "鼠标" },
				{ TextKey.MenuSettingsControlsPage, "操作" },
				{ TextKey.MenuSettingsSavesPage, "存档" },
				{ TextKey.MenuSettingsCreditsPage, "制作人员" },
				{ TextKey.MenuSettingsGameExit, $"{T("退出游戏", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsSoundMusicVolume, "音乐" },
				{ TextKey.MenuSettingsSoundMasterVolume, "主音量" },
				{ TextKey.MenuSettingsSoundEffectsVolume, "效果" },
				{ TextKey.MenuSettingsSoundUIVolume, "界面" },
				
				{ TextKey.MenuSettingsVideoFullscreen, "全屏" },
				{ TextKey.MenuSettingsVideoMotionBlur, "动态模糊" },
				{ TextKey.MenuSettingsVideoScreenShake, "屏幕震动" },
				
				{ TextKey.MenuSettingsMouseSensitivity, "鼠标灵敏度" },
				{ TextKey.MenuSettingsControlsWheelCooldown, "滚轮冷却时间" },
				
				{ TextKey.MenuSettingsControlBindingsPage, "按键绑定" },
				{ TextKey.MenuSettingsControlSchemePage, "操作方案" },
				{ TextKey.MenuSettingsControlPause, "暂停" },
				{ TextKey.MenuSettingsControlMovement, "移动" },
				{ TextKey.MenuSettingsControlUp, "上" },
				{ TextKey.MenuSettingsControlLeft, "左" },
				{ TextKey.MenuSettingsControlDown, "下" },
				{ TextKey.MenuSettingsControlRight, "右" },
				{ TextKey.MenuSettingsControlToHub, "返回中心" },
				{ TextKey.MenuSettingsControlRedWeapon, $"{T("射击", ColorType.Red)}" },
				{ TextKey.MenuSettingsControlBlueWeapon, $"{T("射击", ColorType.Blue)}" },
				{ TextKey.MenuSettingsControlYellowWeapon, $"{T("射击", ColorType.Yellow)}" },
				{ TextKey.MenuSettingsControlDash, "冲刺" },
				{ TextKey.MenuSettingsControlWeaponModifer, "武器切换" },
				
				{ TextKey.MenuSettingsSavesImport, $"{T("导入存档", ColorType.Red)}" },
				{ TextKey.MenuSettingsSavesExport, "导出存档" },
				{ TextKey.MenuSettingsSavesUnlockAll, $"{T("解锁所有内容", ColorType.Red)}"},
				{ TextKey.MenuSettingsSavesReset, $"{T("重置存档", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsCreditsTwitter, "推特" },
				{ TextKey.MenuSettingsCreditsItch, "itch" },
				
				{ TextKey.UnlockBow, P(TextKey.WordBow) },
				{ TextKey.UnlockMine, P(TextKey.WordMine) },
				{ TextKey.UnlockStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.TutorialThisIsMana, "这是冲刺能量" },
				{ TextKey.TutorialManaDisplay, "冲刺能量" },
				{ TextKey.TutorialMoveHere, "站在这里" },
				{ TextKey.TutorialDash, "朝鼠标位置冲刺" },
				{ TextKey.TutorialMouseWheel, "滚动鼠标滚轮" },
				{ TextKey.TutorialDashWithShield, $"使用 {T("盾牌", ColorType.Yellow)} 冲刺" },
				{ TextKey.TutorialPortalIsBroken, "传送门坏了\n只能回中心" },
				{ TextKey.TutorialPortalIsBrokenAgain, "传送门又坏了" },
				{ TextKey.TutorialX3, "一次射击击杀三名敌人\n可强化武器" },
				
				{ TextKey.TextReset, "重置" },
				{ TextKey.TextRedReset, $"{T("重置", ColorType.Red)}" },
				{ TextKey.TextBack, "返回" },
				{ TextKey.TextResume, "继续" },
				{ TextKey.TextSuccess, "成功" },
				{ TextKey.TextError, "错误" },
				{ TextKey.TextYes, "是" },
				{ TextKey.TextNo, "否" },
				{ TextKey.TextMovement, "移动" },
				{ TextKey.TextDefend, "防御" },
				{ TextKey.TextDescription, "说明:" },
				{ TextKey.TextX5, "x5:" },
				{ TextKey.TextX3, "x3:" },
				{ TextKey.TextFeatures, "特性:" },
				{ TextKey.TextGetting, "获得方式:" },
				{ TextKey.TextMoreInfo, $"详情 - {T("TAB", ColorType.Red)}" },
				{ TextKey.TextApply, "应用" },
				
				{ TextKey.SetupGuideAnalytics, "允许收集数据吗？" },
				{ TextKey.SetupGuideHaveMouse, "鼠标还是触控板？" },
				{ TextKey.SetupGuideMouse, "鼠标" },
				{ TextKey.SetupGuideTouchpad, "触控板" },
				{ TextKey.SetupGuideSideButtons, "如果有，请按一下鼠标侧键" },
				{ TextKey.SetupGuideNoSideButtons, "我没有鼠标侧键" },
				{ TextKey.SetupGuideWheelScroll, "如果可以，请滚动一下鼠标滚轮" },
				{ TextKey.SetupGuideNoWheelScroll, "滚轮不可用" },
				{ TextKey.SetupGuideMenuHint, "按 Tab 打开菜单\n里面有很多设置和信息" },
				
				{ TextKey.BindingLMB, "鼠标左键" },
				{ TextKey.BindingRMB, "鼠标右键" },
				{ TextKey.BindingMMB, "鼠标中键" },
				{ TextKey.BindingSMB, "鼠标侧键" },
				{ TextKey.BindingSMBF, "鼠标前进键" },
				{ TextKey.BindingSMBB, "鼠标后退键" },
				{ TextKey.BindingLeftShift, "Shift" },
				{ TextKey.BindingSpace, "空白" }
			};
		}
	}
}

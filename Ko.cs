using System.Collections.Generic;

namespace UnityWrappers.Localization.TextResources
{
	public class Ko : TextResource
	{
		protected override Dictionary<TextKey, string> texts => textsTranslate;

		private readonly Dictionary<TextKey, string> textsTranslate;
		protected sealed override Dictionary<TextKey, string> keywords { get; } = new()
		{
			{ TextKey.WordPistol, "총" },
			{ TextKey.WordBow, "활" },
			{ TextKey.WordSword, "검" },
			{ TextKey.WordMine, "지뢰" },
			{ TextKey.WordShield, "방패" },
			{ TextKey.WordStaticShield, "아우라" }
		};

		public Ko()
		{
			textsTranslate = new Dictionary<TextKey, string>
			{
				{ TextKey.WordPistol, P(TextKey.WordPistol) },
				{ TextKey.WordX5, "x5" },
				{ TextKey.WordSword, P(TextKey.WordSword) },
				{ TextKey.WordShield, P(TextKey.WordShield) },
				{ TextKey.WordDash, "대쉬" },
				{ TextKey.WordBow, P(TextKey.WordBow) },
				{ TextKey.WordX3, "x3" },
				{ TextKey.WordMine, P(TextKey.WordMine) },
				{ TextKey.WordStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.MenuPause, "일시정지" },
				
				{ TextKey.MenuSkillsTab, "스킬" },
				{ TextKey.MenuSettingsTab, "설정" },
				
				{ TextKey.MenuSkillToHub, "허브로 돌아가기" },
				
				{ TextKey.MenuSkillsPistolDescription, "높은 발사 속도와 짧은 사거리" },
				{ TextKey.MenuSkillsPistolX5, "발사 속도 증가" },
				{ TextKey.MenuSkillsPistolX3, "샷건으로 전환" },
				{ TextKey.MenuSkillsPistolFeatures, "" },

				{ TextKey.MenuSkillsBowDescription, "낮은 발사 속도와 무제한 사거리" },
				{ TextKey.MenuSkillsBowX5, "충전 속도 증가" },
				{ TextKey.MenuSkillsBowX3, "방패 관통" },
				{ TextKey.MenuSkillsBowFeatures, "• 모든 무기로 적을 처치할 때마다 1/3씩 충전됩니다\n• 최대 셋의 적을 관통합니다" },

				{ TextKey.MenuSkillsSwordDescription, "근접 무기" },
				{ TextKey.MenuSkillsSwordX5, "공격 속도 증가" },
				{ TextKey.MenuSkillsSwordX3, "공격 범위 증가" },
				{ TextKey.MenuSkillsSwordFeatures, "" },

				{ TextKey.MenuSkillsMineDescription, "적과 접촉 시 활성화" },
				{ TextKey.MenuSkillsMineX5, "발동 속도 증가" },
				{ TextKey.MenuSkillsMineX3, "폭발 범위 증가" },
				{ TextKey.MenuSkillsMineFeatures, $"• {T("검", ColorType.Blue)}과 함께 던질 수 있습니다\n• {T("총", ColorType.Red)}으로 쏘면 발동시킬 수 있습니다" },

				{ TextKey.MenuSkillsShieldDescription, $"{T("총알", ColorType.Yellow)} 차단 및 {T("적", ColorType.Yellow)} 파괴" },
				{ TextKey.MenuSkillsShieldX5, "게이지 회복 속도 증가" },
				{ TextKey.MenuSkillsShieldX3, "범위 증가" },
				{ TextKey.MenuSkillsShieldFeatures, "• 대시 중에도 사용할 수 있습니다\n• 어떤 무기로든 적 처치 시 게이지가 회복됩니다" },

				{ TextKey.MenuSkillsAuraDescription, $"{T("총알", ColorType.Yellow)}과 {T("적", ColorType.Yellow)} 차단" },
				{ TextKey.MenuSkillsAuraX5, "게이지 회복 속도 증가" },
				{ TextKey.MenuSkillsAuraX3, "범위 증가" },
				{ TextKey.MenuSkillsAuraFeatures, "• 사용 시 대시가 1회가 충전됩니다" },

				{ TextKey.MenuSkillsX5Description, "무기 발사 속도 증가" },
				{ TextKey.MenuSkillsX5Getting, "빠르게 적 다섯 처치" },

				{ TextKey.MenuSkillsX3Description, "무기 강화" },
				{ TextKey.MenuSkillsX3Getting, "한 발의 투사체로 적 셋 처치" },

				{ TextKey.MenuSettingsLanguagePage, "언어" },
				{ TextKey.MenuSettingsSoundPage, "오디오" },
				{ TextKey.MenuSettingsVideoPage, "비디오" },
				{ TextKey.MenuSettingsMousePage, "마우스" },
				{ TextKey.MenuSettingsControlsPage, "조작" },
				{ TextKey.MenuSettingsConnectToServer, "online" },
				{ TextKey.MenuSettingsSavesPage, "세이브" },
				{ TextKey.MenuSettingsCreditsPage, "크레딧" },
				{ TextKey.MenuSettingsGameExit, $"{T("게임 나가기", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsSoundMasterVolume, "전체 음량" },
				{ TextKey.MenuSettingsSoundMusicVolume, "음악" },
				{ TextKey.MenuSettingsSoundEffectsVolume, "효과음" },
				{ TextKey.MenuSettingsSoundUIVolume, "UI" },
				
				{ TextKey.MenuSettingsVideoFullscreen, "전체화면" },
				{ TextKey.MenuSettingsVideoMotionBlur, "모션 블러" },
				{ TextKey.MenuSettingsVideoScreenShake, "화면 흔들림" },
				{ TextKey.MenuSettingsVideoVSync, "vSync" },
				{ TextKey.MenuSettingsVideoAntiAliasing, "anti aliasing" },
				{ TextKey.MenuSettingsVideoZeroQueuedFrames, "zero queued frames" },
				
				{ TextKey.MenuSettingsMouseSensitivity, "마우스 민감도" },
				{ TextKey.MenuSettingsMouseHardwareCursor, "hardware cursor" },
				{ TextKey.MenuSettingsControlsWheelCooldown, "마우스 휠 쿨타임" },
				
				{ TextKey.MenuSettingsControlBindingsPage, "키 설정" },
				{ TextKey.MenuSettingsControlSchemePage, "조작 방식" },
				{ TextKey.MenuSettingsControlPause, "일시정지" },
				{ TextKey.MenuSettingsControlMovement, "이동" },
				{ TextKey.MenuSettingsControlUp, "위" },
				{ TextKey.MenuSettingsControlLeft, "왼쪽" },
				{ TextKey.MenuSettingsControlDown, "아래" },
				{ TextKey.MenuSettingsControlRight, "오른쪽" },
				{ TextKey.MenuSettingsControlToHub, "허브로 돌아가기" },
				{ TextKey.MenuSettingsControlRedWeapon, $"{T("발사", ColorType.Red)}" },
				{ TextKey.MenuSettingsControlBlueWeapon, $"{T("발사", ColorType.Blue)}" },
				{ TextKey.MenuSettingsControlYellowWeapon, $"{T("발사", ColorType.Yellow)}" },
				{ TextKey.MenuSettingsControlDash, "대시" },
				{ TextKey.MenuSettingsControlWeaponModifer, "무기 모드 전환" },
				
				{ TextKey.MenuSettingsSavesImport, $"{T("세이브 가져오기", ColorType.Red)}" },
				{ TextKey.MenuSettingsSavesExport, "세이브 내보내기" },
				{ TextKey.MenuSettingsSavesUnlockAll, $"{T("모든 콘텐츠 잠금 해제", ColorType.Red)}"},
				{ TextKey.MenuSettingsSavesReset, $"{T("세이브 리셋", ColorType.Red)}" },
				
				{ TextKey.MenuSettingsCreditsTwitter, $"{T("링크", ColorType.Blue)}" },
				
				{ TextKey.UnlockBow, P(TextKey.WordBow) },
				{ TextKey.UnlockMine, P(TextKey.WordMine) },
				{ TextKey.UnlockStaticShield, P(TextKey.WordStaticShield) },
				
				{ TextKey.TutorialThisIsMana, "적을 처치하면 대시가 충전됩니다" },
				{ TextKey.TutorialManaDisplay, "대시 게이지" },
				{ TextKey.TutorialMoveHere, "여기에 서세요" },
				{ TextKey.TutorialDash, "커서 위치로 대시하세요" },
				{ TextKey.TutorialMouseWheel, "마우스 휠로 스크롤하세요" },
				{ TextKey.TutorialDashWithShield, $"{T("방패", ColorType.Yellow)}와 함께 대시하세요" },
				{ TextKey.TutorialPortalIsBroken, "개발자가 포탈을 고장 내버렸네요\n직접 허브로 돌아가야 합니다" },
				{ TextKey.TutorialPortalIsBrokenAgain, "포탈이 또다시 작동하지 않습니다" },
				{ TextKey.TutorialX3, "한 발로 적 셋을 처치하면\n무기가 강화됩니다" },

				{ TextKey.TextReset, "리셋" },
				{ TextKey.TextRedReset, $"{T("리셋", ColorType.Red)}" },
				{ TextKey.TextBack, "뒤로가기" },
				{ TextKey.TextResume, "계속하기" },
				{ TextKey.TextSuccess, "성공" },
				{ TextKey.TextError, "에러" },
				{ TextKey.TextYes, "네" },
				{ TextKey.TextNo, "아니요" },
				{ TextKey.TextMovement, "이동" },
				{ TextKey.TextDefend, "이 지점을 방어하세요" },
				{ TextKey.TextDescription, "상세 설명:" },
				{ TextKey.TextX5, "x5" },
				{ TextKey.TextX3, "x3" },
				{ TextKey.TextFeatures, "기능:" },
				{ TextKey.TextGetting, "조건:" },
				{ TextKey.TextMoreInfo, $"자세한 정보는 {T("ESC", ColorType.Red)} 키를 눌러 확인하세요" },
				{ TextKey.TextApply, "적용" },
				
				{ TextKey.SetupGuideAnalytics, "분석 데이터 수집을 허용하시겠습니까?" },
				{ TextKey.SetupGuideHaveMouse, "입력 장치를 선택하세요: 마우스 또는 터치패드" },
				{ TextKey.SetupGuideMouse, "마우스" },
				{ TextKey.SetupGuideTouchpad, "터치패드" },
				{ TextKey.SetupGuideSideButtons, "측면 마우스 버튼이 작동한다면 클릭하세요" },
				{ TextKey.SetupGuideNoSideButtons, "측면 버튼이 없습니다" },
				{ TextKey.SetupGuideWheelScroll, "마우스 휠이 작동한다면 스크롤하세요" },
				{ TextKey.SetupGuideNoWheelScroll, "스크롤 휠이 작동하지 않습니다" },
				{ TextKey.SetupGuideMenuHint, "한때 하얀 광휘가 모든 것을 휩쓸었으나...\n\n그 광휘는 결국 스스로의 심연 속으로 떨어지고,\n\n남은 것은 어둠과 흩어진 빛의 메아리뿐이었다" },

				{ TextKey.BindingLMB, "왼쪽 버튼" },
				{ TextKey.BindingRMB, "오른쪽 버튼" },
				{ TextKey.BindingMMB, "가운데 버튼" },
				{ TextKey.BindingSMB, "측면 버튼" },
				{ TextKey.BindingSMBF, "앞으로 가기 버튼" },
				{ TextKey.BindingSMBB, "뒤로 가기 버튼" },
				{ TextKey.BindingLeftShift, "shift" },
				{ TextKey.BindingSpace, "space" },

				{ TextKey.ServerConnectFailed, "server status: offline" },
				{ TextKey.ServerConnectSuccess, "server status: online" }
			};
		}
	}
}
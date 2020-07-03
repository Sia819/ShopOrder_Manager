using System;
using System.Windows.Forms;

namespace ShopOrder_Manager
{
    /// <summary>
    /// 메뉴 모델 클래스입니다.
    /// </summary>
    class MenuItems
    {
        private Control menuName_Control;   // 제일 중요한 정보가 stirng
        private Control menuPrice_Control;  // 제일 중요한 정보가 int
        private Control menuAmount_Control; // 제일 중요한 정보가 int

        public MenuItems(Control MenuName_Control, Control MenuPrice_Control, Control MenuAmount_Control)
        {
            // TextBox가 int형 인지 확인하며, int형이 아닌경우 오류메시지를 띄웁니다.

            if (!int.TryParse(MenuPrice_Control.Text, out int temp1)) // temp는 저장되어도 나중에 컨트롤 내용이 변경되면 기본값과 달라지므로 따로 저장할 필요없음.
            {
#if DEBUG
                throw new Exception($"{MenuPrice_Control.Text}는 사용 가능한 숫자가 아닙니다!");
#else
                // TODO - 디버그가 아닌 경우 MessageBox로 처리
                throw new Exception($"{MenuPrice_Control.Text}는 사용 가능한 숫자가 아닙니다!");
#endif
            }

            if (!int.TryParse(MenuAmount_Control.Text, out int temp2))
            {
#if DEBUG
                throw new Exception($"{MenuAmount_Control.Text}는 사용 가능한 숫자가 아닙니다!");
#else
                // TODO - 디버그가 아닌 경우 MessageBox로 처리
                throw new Exception($"{MenuAmount_Control.Text}는 사용 가능한 숫자가 아닙니다!");
#endif
            }
            menuName_Control = MenuName_Control;
            menuPrice_Control = MenuPrice_Control;
            menuAmount_Control = MenuAmount_Control;
        }

        public string GetMenuName()
        {
            return menuName_Control.Text;
        }

        public int GetMenuPrice()
        {
            try
            {
                return int.Parse(menuPrice_Control.Text);
            }
            catch (System.FormatException)
            {
                // TODO - 수정바람 의도치않게 Control.Text가 int형이 아닌경우
                throw new Exception("의도치않은 가격 Control.Text가 int형이 아니었습니다.");
            }
        }

        public int GetMenuAmount()
        {
            try
            {
                return int.Parse(menuAmount_Control.Text);
            }
            catch (System.FormatException)
            {
                // TODO - 수정바람 의도치않게 Control.Text가 int형이 아닌경우
                throw new Exception("의도치않은 가격 Control.Text가 int형이 아니었습니다.");
            }
        }

        /// <summary>
        /// 현재 메뉴판의 선택사항을 체크합니다.
        /// </summary>
        public void SelectControl(Type ControlType)
        {
            if (menuName_Control is CheckBox)
                (menuName_Control as CheckBox).Checked = true;
            else
                throw new Exception($"현재 컨트롤인 {menuName_Control.Text}는 {menuName_Control.GetType().Name}이며, 아직 구현되지 않았습니다.");
        }

        /// <summary>
        /// 현재 메뉴판의 선택사항을 언체크합니다.
        /// </summary>
        public void UnSelectControl()
        {
            if (menuName_Control is CheckBox)
                (menuName_Control as CheckBox).Checked = false;
            else
                throw new Exception($"현재 컨트롤인 {menuName_Control.Text}는 {menuName_Control.GetType().Name}이며, 아직 구현되지 않았습니다.");
        }

        /// <summary>
        /// 현재 메뉴판의 선택사항을 반환합니다.
        /// </summary>
        /// <returns></returns>
        public bool IsSelected()
        {
            if (menuName_Control is CheckBox)
                return (menuName_Control as CheckBox).Checked;
            else
                throw new Exception($"현재 컨트롤인 {menuName_Control.Text}는 {menuName_Control.GetType().Name}이며, 아직 구현되지 않았습니다.");
        }


    }
}

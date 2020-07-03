using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOrder_Manager
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 카페메뉴 들
        /// </summary>
        private List<MenuItems> cafeMenus = new List<MenuItems>();
        /// <summary>
        /// 레스토랑 메뉴들
        /// </summary>
        private List<MenuItems> restMenus = new List<MenuItems>();
        /// <summary>
        /// 오늘 주문한 모든 메뉴
        /// </summary>
        private List<OrderedMenu> todayOrdered = new List<OrderedMenu>();

        public MainForm()
        {
            // Init by the designer
            InitializeComponent();
            // Controls Init

            Admin_CafeOrderPrice_TB.Text        = "0";
            Admin_CafeTotalAmount_TB.Text       = "0";
            Admin_RestOrderPrice_TB.Text        = "0";
            Admin_RestAllAmount_TB.Text         = "0";
            Admin_Americano_TB.Text             = "0";
            Admin_Cappuccino_TB.Text            = "0";
            Admin_Latte_TB.Text                 = "0";
            Admin_Ade_TB.Text                   = "0";
            Admin_Salad_TB.Text                 = "0";
            Admin_Steak_TB.Text                 = "0";
            Admin_Pizza_TB.Text                 = "0";
            Admin_Pasta_TB.Text                 = "0";
            Admin_TodayAllCafeMoney_TB.Text     = "0";
            Admin_TodayAllRestMoney_TB.Text     = "0";
            TodayMoney.Text                     = "0";


            // Add All Cafe Menus
            cafeMenus.Add(new MenuItems(Americano_CheckBox,     textBox1, numericUpDown1));
            cafeMenus.Add(new MenuItems(Cappuccino_CheckBox,    textBox2, numericUpDown2));
            cafeMenus.Add(new MenuItems(Latte_CheckBox,         textBox3, numericUpDown3));
            cafeMenus.Add(new MenuItems(Ade_CheckBox,           textBox4, numericUpDown4));
            // Add All Restaurant Menus
            restMenus.Add(new MenuItems(Salad_CheckBox,         textBox5, numericUpDown5));
            restMenus.Add(new MenuItems(Steak_CheckBox,         textBox6, numericUpDown6));
            restMenus.Add(new MenuItems(Pizza_CheckBox,         textBox7, numericUpDown7));
            restMenus.Add(new MenuItems(Pasta_CheckBox,         textBox8, numericUpDown8));
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            AddTodayOrderStatus(todayOrdered, cafeMenus); // 현재 주문상태를 넘겨, todayOrdered에 통계를 냅니다.
            AddTodayOrderStatus(todayOrdered, restMenus);

            // todayOrdered(일일통계)에 "해당마켓 판매량"을 일종의 메뉴로 만들어 같이 통계를 관리합니다. 이로써 카페 판매량을 객체를 따로 만들지 않아도 됩니다.
            AddMenuAmount(todayOrdered, new OrderedMenu("restTotal", CheckedMenuGetPrice(restMenus), CheckedMenuGetAmount(restMenus)));
            AddMenuAmount(todayOrdered, new OrderedMenu("allTotal", CheckedMenuGetPrice(cafeMenus) + CheckedMenuGetPrice(restMenus), CheckedMenuGetAmount(cafeMenus) + CheckedMenuGetAmount(restMenus)));
            UpdateData(); // 통계 데이터를 기반으로 Gui 업데이트합니다.
        }

        /// <summary>
        /// 카페 메뉴선택이 변경 되었을 때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CafeMenu_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int myOrderPrice = CheckedMenuGetPrice(cafeMenus);   // 내가 선택한 메뉴로, 주문 총액을 가져옵니다.
            Admin_CafeOrderPrice_TB.Text = myOrderPrice.ToString();       // 총 주문금액
        }

        /// <summary>
        /// 레스토랑 메뉴선택이 변경 되었을 때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestMenu_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int myOrderPrice = CheckedMenuGetPrice(restMenus);   // 내가 선택한 메뉴로, 주문 총액을 가져옵니다.
            Admin_RestOrderPrice_TB.Text = myOrderPrice.ToString();       // 총 주문금액
        }

        #region CostomFunctions

        /// <summary>
        /// 마켓의 메뉴를 받아, 선택 된 여부에 따른 가격을 리턴합니다.
        /// </summary>
        /// <param name="MarketMenus"></param>
        /// <returns> 총 주문 금액 입니다. </returns>
        private int CheckedMenuGetPrice(List<MenuItems> MarketMenus)
        {
            int PriceCount = 0;
            foreach (var i in MarketMenus)
            {
                if (i.IsSelected())
                {
                    PriceCount += i.GetMenuPrice() * i.GetMenuAmount();
                }
            }
            return PriceCount;
        }

        /// <summary>
        /// 마켓의 메뉴를 받아, 선택 된 여부에 따른 가격을 리턴합니다.
        /// </summary>
        /// <param name="MarketMenus"></param>
        /// <returns> 총 주문 금액 입니다. </returns>
        private int CheckedMenuGetAmount(List<MenuItems> MarketMenus)
        {
            int PriceAmount = 0;
            foreach (var i in MarketMenus)
            {
                if (i.IsSelected())
                {
                    PriceAmount += i.GetMenuAmount();
                }
            }
            return PriceAmount;
        }

        /// <summary>
        /// 지금 주문될 메뉴들의 상태를 받아, 금일 매출 통계에 적용합니다.
        /// </summary>
        /// <param name="StatisticsList"> 통계를 담당하는 리스트 </param>
        /// <param name="orderedMarketMenu"> 통계에 추가할 메뉴 </param>
        private void AddTodayOrderStatus(List<OrderedMenu> StatisticsList, List<MenuItems> orderedMarketMenu)
        {
            foreach (var i in orderedMarketMenu)
            {
                // 선택 한 메뉴만 가격을 더합니다.
                if (i.IsSelected())
                {
                    AddMenuAmount(StatisticsList, new OrderedMenu(i.GetMenuName(), i.GetMenuPrice(), i.GetMenuAmount()));
                }
            }
        }

        /// <summary>
        /// newMenuItem을 기존 baseMenuItem에 집어넣으며, 중복되지않게 추가합니다.
        /// </summary>
        /// <param name="ToAddList"> 추가 할 리스트 </param>
        /// <param name="newMenuItem"> 중복을 회피하며 추가 할 메뉴 </param>
        private void AddMenuAmount(List<OrderedMenu> ToAddList, OrderedMenu newMenuItem)
        {
            var baseMenuItem = ToAddList.FirstOrDefault(x => x.MenuName == newMenuItem.MenuName);
            if (baseMenuItem == null)
            {
                ToAddList.Add(new OrderedMenu(newMenuItem.MenuName, newMenuItem.Price, newMenuItem.Amount));
            }
            else
            {
                baseMenuItem.Price += newMenuItem.Price; // 중복인 경우 판매액을 더합니다. (예를들어 통계의 아메리카노 가격은 개수 당 총 가격)
                baseMenuItem.Amount += newMenuItem.Amount; // 중복인 경우 판매개수를 1 더합니다.
            }
        }

        private void UpdateData()
        {
            foreach (var menu in todayOrdered)
            {
                switch (menu.MenuName)
                {
                    case "Americano":
                        this.Admin_Americano_TB.Text = menu.Amount.ToString(); // 표시 할 항목은 개수입니다.
                        break;
                    case "Cappuccino":
                        this.Admin_Cappuccino_TB.Text = menu.Amount.ToString();
                        break;
                    case "Latte":
                        this.Admin_Latte_TB.Text = menu.Amount.ToString();
                        break;
                    case "Ade":
                        this.Admin_Ade_TB.Text = menu.Amount.ToString();
                        break;
                    case "Salad":
                        this.Admin_Salad_TB.Text = menu.Amount.ToString();
                        break;
                    case "Steak":
                        this.Admin_Steak_TB.Text = menu.Amount.ToString();
                        break;
                    case "Pizza":
                        this.Admin_Pizza_TB.Text = menu.Amount.ToString();
                        break;
                    case "Pasta":
                        this.Admin_Pasta_TB.Text = menu.Amount.ToString();
                        break;
                    case "cafeTotal":
                        this.Admin_CafeTotalAmount_TB.Text = menu.Amount.ToString();
                        this.Admin_TodayAllCafeMoney_TB.Text = menu.Price.ToString(); // 표시 할 항목은 금액입니다.
                        break;
                    case "restTotal":
                        this.Admin_RestAllAmount_TB.Text = menu.Amount.ToString();
                        this.Admin_TodayAllRestMoney_TB.Text = menu.Price.ToString();
                        break;
                    case "allTotal":
                        this.TodayMoney.Text = menu.Price.ToString();
                        break;
                    default:
                        MessageBox.Show($"처리되지않은 메뉴\"{menu.MenuName}\"가 포함되어 있습니다.");
                        break;
                }
            }
        }


        #endregion CostomFunctions

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString();
        }


    }
}

namespace ShopOrder_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Americano_CheckBox = new System.Windows.Forms.CheckBox();
            this.Cappuccino_CheckBox = new System.Windows.Forms.CheckBox();
            this.Latte_CheckBox = new System.Windows.Forms.CheckBox();
            this.Ade_CheckBox = new System.Windows.Forms.CheckBox();
            this.Pasta_CheckBox = new System.Windows.Forms.CheckBox();
            this.Pizza_CheckBox = new System.Windows.Forms.CheckBox();
            this.Steak_CheckBox = new System.Windows.Forms.CheckBox();
            this.Salad_CheckBox = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Admin_CafeOrderPrice_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TodayMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Admin_RestAllAmount_TB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Admin_Salad_TB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Admin_Steak_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Admin_Pizza_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Admin_Pasta_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Admin_CafeTotalAmount_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Admin_Ade_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Admin_Latte_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Admin_Cappuccino_TB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Admin_Americano_TB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.Admin_RestOrderPrice_TB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Admin_TodayAllCafeMoney_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Admin_TodayAllRestMoney_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Americano_CheckBox
            // 
            this.Americano_CheckBox.AutoSize = true;
            this.Americano_CheckBox.Location = new System.Drawing.Point(18, 20);
            this.Americano_CheckBox.Name = "Americano_CheckBox";
            this.Americano_CheckBox.Size = new System.Drawing.Size(85, 16);
            this.Americano_CheckBox.TabIndex = 4;
            this.Americano_CheckBox.Text = "Americano";
            this.Americano_CheckBox.UseVisualStyleBackColor = true;
            this.Americano_CheckBox.CheckedChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // Cappuccino_CheckBox
            // 
            this.Cappuccino_CheckBox.AutoSize = true;
            this.Cappuccino_CheckBox.Location = new System.Drawing.Point(18, 56);
            this.Cappuccino_CheckBox.Name = "Cappuccino_CheckBox";
            this.Cappuccino_CheckBox.Size = new System.Drawing.Size(92, 16);
            this.Cappuccino_CheckBox.TabIndex = 5;
            this.Cappuccino_CheckBox.Text = "Cappuccino";
            this.Cappuccino_CheckBox.UseVisualStyleBackColor = true;
            this.Cappuccino_CheckBox.CheckedChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // Latte_CheckBox
            // 
            this.Latte_CheckBox.AutoSize = true;
            this.Latte_CheckBox.Location = new System.Drawing.Point(18, 94);
            this.Latte_CheckBox.Name = "Latte_CheckBox";
            this.Latte_CheckBox.Size = new System.Drawing.Size(51, 16);
            this.Latte_CheckBox.TabIndex = 6;
            this.Latte_CheckBox.Text = "Latte";
            this.Latte_CheckBox.UseVisualStyleBackColor = true;
            this.Latte_CheckBox.CheckedChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // Ade_CheckBox
            // 
            this.Ade_CheckBox.AutoSize = true;
            this.Ade_CheckBox.Location = new System.Drawing.Point(18, 135);
            this.Ade_CheckBox.Name = "Ade_CheckBox";
            this.Ade_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.Ade_CheckBox.TabIndex = 7;
            this.Ade_CheckBox.Text = "Ade";
            this.Ade_CheckBox.UseVisualStyleBackColor = true;
            this.Ade_CheckBox.CheckedChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // Pasta_CheckBox
            // 
            this.Pasta_CheckBox.AutoSize = true;
            this.Pasta_CheckBox.Location = new System.Drawing.Point(15, 139);
            this.Pasta_CheckBox.Name = "Pasta_CheckBox";
            this.Pasta_CheckBox.Size = new System.Drawing.Size(56, 16);
            this.Pasta_CheckBox.TabIndex = 8;
            this.Pasta_CheckBox.Text = "Pasta";
            this.Pasta_CheckBox.UseVisualStyleBackColor = true;
            this.Pasta_CheckBox.CheckedChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // Pizza_CheckBox
            // 
            this.Pizza_CheckBox.AutoSize = true;
            this.Pizza_CheckBox.Location = new System.Drawing.Point(16, 98);
            this.Pizza_CheckBox.Name = "Pizza_CheckBox";
            this.Pizza_CheckBox.Size = new System.Drawing.Size(56, 16);
            this.Pizza_CheckBox.TabIndex = 9;
            this.Pizza_CheckBox.Text = "Pizza";
            this.Pizza_CheckBox.UseVisualStyleBackColor = true;
            this.Pizza_CheckBox.CheckedChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // Steak_CheckBox
            // 
            this.Steak_CheckBox.AutoSize = true;
            this.Steak_CheckBox.Location = new System.Drawing.Point(16, 57);
            this.Steak_CheckBox.Name = "Steak_CheckBox";
            this.Steak_CheckBox.Size = new System.Drawing.Size(55, 16);
            this.Steak_CheckBox.TabIndex = 10;
            this.Steak_CheckBox.Text = "Steak";
            this.Steak_CheckBox.UseVisualStyleBackColor = true;
            this.Steak_CheckBox.CheckedChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // Salad_CheckBox
            // 
            this.Salad_CheckBox.AutoSize = true;
            this.Salad_CheckBox.Location = new System.Drawing.Point(16, 20);
            this.Salad_CheckBox.Name = "Salad_CheckBox";
            this.Salad_CheckBox.Size = new System.Drawing.Size(56, 16);
            this.Salad_CheckBox.TabIndex = 11;
            this.Salad_CheckBox.Text = "Salad";
            this.Salad_CheckBox.UseVisualStyleBackColor = true;
            this.Salad_CheckBox.CheckedChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(203, 274);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 39);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.Order_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(57, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "1500";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(57, 21);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "2500";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(57, 21);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "2500";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(57, 21);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "3000";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(57, 21);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "10000";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(57, 21);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "10000";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(108, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(57, 21);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "10000";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(107, 133);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(57, 21);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "7000";
            // 
            // CafeOrderPrice
            // 
            this.Admin_CafeOrderPrice_TB.Location = new System.Drawing.Point(113, 225);
            this.Admin_CafeOrderPrice_TB.Name = "CafeOrderPrice";
            this.Admin_CafeOrderPrice_TB.ReadOnly = true;
            this.Admin_CafeOrderPrice_TB.Size = new System.Drawing.Size(57, 21);
            this.Admin_CafeOrderPrice_TB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "총 주문 금액";
            // 
            // TodayMoney
            // 
            this.TodayMoney.Location = new System.Drawing.Point(404, 271);
            this.TodayMoney.Name = "TodayMoney";
            this.TodayMoney.ReadOnly = true;
            this.TodayMoney.Size = new System.Drawing.Size(100, 21);
            this.TodayMoney.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "금일 판매 총액";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("굴림", 10F);
            this.Time.Location = new System.Drawing.Point(403, 18);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(143, 48);
            this.Time.TabIndex = 28;
            this.Time.Text = "날짜";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 48);
            this.label3.TabIndex = 29;
            this.label3.Text = "Order System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 12);
            this.label14.TabIndex = 76;
            this.label14.Text = "식당 판매량";
            // 
            // RestTotalAmount
            // 
            this.Admin_RestAllAmount_TB.Location = new System.Drawing.Point(404, 146);
            this.Admin_RestAllAmount_TB.Name = "RestTotalAmount";
            this.Admin_RestAllAmount_TB.ReadOnly = true;
            this.Admin_RestAllAmount_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_RestAllAmount_TB.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 74;
            this.label13.Text = "샐러드";
            // 
            // Sa
            // 
            this.Admin_Salad_TB.Location = new System.Drawing.Point(404, 105);
            this.Admin_Salad_TB.Name = "Sa";
            this.Admin_Salad_TB.ReadOnly = true;
            this.Admin_Salad_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Salad_TB.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 72;
            this.label12.Text = "스테이크";
            // 
            // St
            // 
            this.Admin_Steak_TB.Location = new System.Drawing.Point(404, 78);
            this.Admin_Steak_TB.Name = "St";
            this.Admin_Steak_TB.ReadOnly = true;
            this.Admin_Steak_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Steak_TB.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 70;
            this.label11.Text = "피자";
            // 
            // Pi
            // 
            this.Admin_Pizza_TB.Location = new System.Drawing.Point(404, 51);
            this.Admin_Pizza_TB.Name = "Pi";
            this.Admin_Pizza_TB.ReadOnly = true;
            this.Admin_Pizza_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Pizza_TB.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 68;
            this.label10.Text = "파스타";
            // 
            // Pa
            // 
            this.Admin_Pasta_TB.Location = new System.Drawing.Point(404, 24);
            this.Admin_Pasta_TB.Name = "Pa";
            this.Admin_Pasta_TB.ReadOnly = true;
            this.Admin_Pasta_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Pasta_TB.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 66;
            this.label9.Text = "카페 판매량";
            // 
            // CafeTotalAmount
            // 
            this.Admin_CafeTotalAmount_TB.Location = new System.Drawing.Point(100, 148);
            this.Admin_CafeTotalAmount_TB.Name = "CafeTotalAmount";
            this.Admin_CafeTotalAmount_TB.ReadOnly = true;
            this.Admin_CafeTotalAmount_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_CafeTotalAmount_TB.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 64;
            this.label8.Text = "에이드";
            // 
            // Ad
            // 
            this.Admin_Ade_TB.Location = new System.Drawing.Point(100, 108);
            this.Admin_Ade_TB.Name = "Ad";
            this.Admin_Ade_TB.ReadOnly = true;
            this.Admin_Ade_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Ade_TB.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 62;
            this.label7.Text = "라떼";
            // 
            // La
            // 
            this.Admin_Latte_TB.Location = new System.Drawing.Point(100, 81);
            this.Admin_Latte_TB.Name = "La";
            this.Admin_Latte_TB.ReadOnly = true;
            this.Admin_Latte_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Latte_TB.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 60;
            this.label6.Text = "카푸치노";
            // 
            // Ca
            // 
            this.Admin_Cappuccino_TB.Location = new System.Drawing.Point(100, 54);
            this.Admin_Cappuccino_TB.Name = "Ca";
            this.Admin_Cappuccino_TB.ReadOnly = true;
            this.Admin_Cappuccino_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Cappuccino_TB.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 58;
            this.label15.Text = "아메리카노";
            // 
            // Am
            // 
            this.Admin_Americano_TB.Location = new System.Drawing.Point(100, 26);
            this.Admin_Americano_TB.Name = "Am";
            this.Admin_Americano_TB.ReadOnly = true;
            this.Admin_Americano_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_Americano_TB.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(21, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 333);
            this.panel1.TabIndex = 77;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.Americano_CheckBox);
            this.groupBox2.Controls.Add(this.Cappuccino_CheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Latte_CheckBox);
            this.groupBox2.Controls.Add(this.Admin_CafeOrderPrice_TB);
            this.groupBox2.Controls.Add(this.Ade_CheckBox);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 263);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cafe";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(188, 139);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown4.TabIndex = 25;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(188, 98);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown3.TabIndex = 25;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(188, 55);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(188, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.CafeMenu_CheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown8);
            this.groupBox3.Controls.Add(this.numericUpDown7);
            this.groupBox3.Controls.Add(this.numericUpDown6);
            this.groupBox3.Controls.Add(this.numericUpDown5);
            this.groupBox3.Controls.Add(this.Pasta_CheckBox);
            this.groupBox3.Controls.Add(this.Salad_CheckBox);
            this.groupBox3.Controls.Add(this.Pizza_CheckBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Steak_CheckBox);
            this.groupBox3.Controls.Add(this.Admin_RestOrderPrice_TB);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Location = new System.Drawing.Point(264, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 263);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Restaurant";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(180, 135);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown8.TabIndex = 25;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(180, 94);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown7.TabIndex = 25;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(180, 57);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown6.TabIndex = 25;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(180, 21);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown5.TabIndex = 25;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.RestMenu_CheckBox_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "총 주문 금액";
            // 
            // RestOrderPrice
            // 
            this.Admin_RestOrderPrice_TB.Location = new System.Drawing.Point(118, 225);
            this.Admin_RestOrderPrice_TB.Name = "RestOrderPrice";
            this.Admin_RestOrderPrice_TB.ReadOnly = true;
            this.Admin_RestOrderPrice_TB.Size = new System.Drawing.Size(57, 21);
            this.Admin_RestOrderPrice_TB.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TodayMoney);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Admin_RestAllAmount_TB);
            this.groupBox1.Controls.Add(this.Admin_TodayAllCafeMoney_TB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Admin_Salad_TB);
            this.groupBox1.Controls.Add(this.Admin_TodayAllRestMoney_TB);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Admin_Steak_TB);
            this.groupBox1.Controls.Add(this.Admin_Americano_TB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Admin_Pizza_TB);
            this.groupBox1.Controls.Add(this.Admin_Cappuccino_TB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Admin_Pasta_TB);
            this.groupBox1.Controls.Add(this.Admin_Latte_TB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Admin_CafeTotalAmount_TB);
            this.groupBox1.Controls.Add(this.Admin_Ade_TB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(21, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 312);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "금일 매출 통계";
            // 
            // TotalCafeMoney
            // 
            this.Admin_TodayAllCafeMoney_TB.Location = new System.Drawing.Point(404, 199);
            this.Admin_TodayAllCafeMoney_TB.Name = "TotalCafeMoney";
            this.Admin_TodayAllCafeMoney_TB.ReadOnly = true;
            this.Admin_TodayAllCafeMoney_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_TodayAllCafeMoney_TB.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "금일 카페 판매 총액";
            // 
            // TotalRestaurantMoney
            // 
            this.Admin_TodayAllRestMoney_TB.Location = new System.Drawing.Point(404, 226);
            this.Admin_TodayAllRestMoney_TB.Name = "TotalRestaurantMoney";
            this.Admin_TodayAllRestMoney_TB.ReadOnly = true;
            this.Admin_TodayAllRestMoney_TB.Size = new System.Drawing.Size(100, 21);
            this.Admin_TodayAllRestMoney_TB.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "금일 식당 판매 총액";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(567, 781);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Time);
            this.Name = "MainWindow";
            this.Text = "주문 시스템";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox Americano_CheckBox;
        private System.Windows.Forms.CheckBox Cappuccino_CheckBox;
        private System.Windows.Forms.CheckBox Latte_CheckBox;
        private System.Windows.Forms.CheckBox Ade_CheckBox;
        private System.Windows.Forms.CheckBox Pasta_CheckBox;
        private System.Windows.Forms.CheckBox Pizza_CheckBox;
        private System.Windows.Forms.CheckBox Steak_CheckBox;
        private System.Windows.Forms.CheckBox Salad_CheckBox;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox Admin_CafeOrderPrice_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TodayMoney;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Admin_RestAllAmount_TB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Admin_Salad_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Admin_Steak_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Admin_Pizza_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Admin_Pasta_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Admin_CafeTotalAmount_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Admin_Ade_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Admin_Latte_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Admin_Cappuccino_TB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Admin_Americano_TB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Admin_RestOrderPrice_TB;
        public System.Windows.Forms.TextBox Admin_TodayAllCafeMoney_TB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Admin_TodayAllRestMoney_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
    }
}


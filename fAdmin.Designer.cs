namespace QuanLy
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcBill = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            txbFoodName = new TextBox();
            panel7 = new Panel();
            label1 = new Label();
            txbFoodID = new TextBox();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            panel3 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            tpFoodCategory = new TabPage();
            panel12 = new Panel();
            panel15 = new Panel();
            label7 = new Label();
            textBox2 = new TextBox();
            panel16 = new Panel();
            label8 = new Label();
            txbCategoryID = new TextBox();
            panel17 = new Panel();
            dtgvCategory = new DataGridView();
            panel18 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel11 = new Panel();
            panel20 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel13 = new Panel();
            label5 = new Label();
            panel14 = new Panel();
            label6 = new Label();
            textBox3 = new TextBox();
            panel19 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            dtgvTable = new DataGridView();
            tpAccount = new TabPage();
            panel21 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            dtgvAccount = new DataGridView();
            panel22 = new Panel();
            btnResetPass = new Button();
            panel24 = new Panel();
            cbAccountType = new ComboBox();
            label11 = new Label();
            panel25 = new Panel();
            label12 = new Label();
            txbDisplayName = new TextBox();
            panel26 = new Panel();
            label13 = new Label();
            txbUserName = new TextBox();
            textBox1 = new TextBox();
            tcBill.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel3.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel18.SuspendLayout();
            tpTable.SuspendLayout();
            panel11.SuspendLayout();
            panel20.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            tpAccount.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel22.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            SuspendLayout();
            // 
            // tcBill
            // 
            tcBill.Controls.Add(tpBill);
            tcBill.Controls.Add(tpFood);
            tcBill.Controls.Add(tpFoodCategory);
            tcBill.Controls.Add(tpTable);
            tcBill.Controls.Add(tpAccount);
            tcBill.Location = new Point(12, 12);
            tcBill.Name = "tcBill";
            tcBill.SelectedIndex = 0;
            tcBill.Size = new Size(904, 600);
            tcBill.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(896, 572);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(6, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 507);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 0);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.Size = new Size(878, 504);
            dtgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 47);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(399, 12);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(75, 23);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(681, 12);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 12);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(896, 572);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(472, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(421, 63);
            panel6.TabIndex = 1;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(12, 14);
            txbSearchFoodName.Multiline = true;
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(268, 37);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(302, 14);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(102, 37);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(472, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(421, 491);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(12, 192);
            panel10.Name = "panel10";
            panel10.Size = new Size(406, 53);
            panel10.TabIndex = 6;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(121, 13);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(271, 23);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 0;
            label4.Text = "Giá :";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(12, 133);
            panel9.Name = "panel9";
            panel9.Size = new Size(406, 53);
            panel9.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(121, 17);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(271, 23);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 18);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 0;
            label3.Text = "Danh mục :";
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Controls.Add(txbFoodName);
            panel8.Location = new Point(12, 74);
            panel8.Name = "panel8";
            panel8.Size = new Size(406, 53);
            panel8.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên món :";
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(121, 18);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(271, 23);
            txbFoodName.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(txbFoodID);
            panel7.Location = new Point(12, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(406, 53);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 19);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(121, 18);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(271, 23);
            txbFoodID.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Location = new Point(6, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 491);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.Size = new Size(454, 488);
            dtgvFood.TabIndex = 0;
            dtgvFood.CellContentClick += dtgvFood_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnShowFood);
            panel3.Controls.Add(btnEditFood);
            panel3.Controls.Add(btnDeleteFood);
            panel3.Controls.Add(btnAddFood);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 63);
            panel3.TabIndex = 0;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(327, 14);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(102, 37);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(219, 14);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(102, 37);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(111, 14);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(102, 37);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 14);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(102, 37);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel12);
            tpFoodCategory.Controls.Add(panel17);
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Location = new Point(4, 24);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(896, 572);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(471, 75);
            panel12.Name = "panel12";
            panel12.Size = new Size(421, 491);
            panel12.TabIndex = 6;
            // 
            // panel15
            // 
            panel15.Controls.Add(label7);
            panel15.Controls.Add(textBox2);
            panel15.Location = new Point(12, 74);
            panel15.Name = "panel15";
            panel15.Size = new Size(406, 53);
            panel15.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 18);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Controls.Add(label8);
            panel16.Controls.Add(txbCategoryID);
            panel16.Location = new Point(12, 15);
            panel16.Name = "panel16";
            panel16.Size = new Size(406, 53);
            panel16.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 18);
            label8.Name = "label8";
            label8.Size = new Size(35, 19);
            label8.TabIndex = 0;
            label8.Text = "ID :";
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(152, 18);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(240, 23);
            txbCategoryID.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.Controls.Add(dtgvCategory);
            panel17.Location = new Point(5, 75);
            panel17.Name = "panel17";
            panel17.Size = new Size(460, 491);
            panel17.TabIndex = 5;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.Size = new Size(454, 488);
            dtgvCategory.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnShowCategory);
            panel18.Controls.Add(btnEditCategory);
            panel18.Controls.Add(btnDeleteCategory);
            panel18.Controls.Add(btnAddCategory);
            panel18.Location = new Point(5, 6);
            panel18.Name = "panel18";
            panel18.Size = new Size(460, 63);
            panel18.TabIndex = 3;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(327, 14);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(102, 37);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(219, 14);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(102, 37);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(111, 14);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(102, 37);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 14);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(102, 37);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel11);
            tpTable.Controls.Add(panel19);
            tpTable.Controls.Add(dtgvTable);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(896, 572);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel20);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(474, 72);
            panel11.Name = "panel11";
            panel11.Size = new Size(421, 491);
            panel11.TabIndex = 9;
            // 
            // panel20
            // 
            panel20.Controls.Add(cbTableStatus);
            panel20.Controls.Add(label9);
            panel20.Location = new Point(10, 143);
            panel20.Name = "panel20";
            panel20.Size = new Size(406, 53);
            panel20.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(154, 14);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(240, 23);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 18);
            label9.Name = "label9";
            label9.Size = new Size(95, 19);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái :";
            // 
            // panel13
            // 
            panel13.Controls.Add(textBox1);
            panel13.Controls.Add(label5);
            panel13.Location = new Point(12, 74);
            panel13.Name = "panel13";
            panel13.Size = new Size(406, 53);
            panel13.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 18);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn :";
            // 
            // panel14
            // 
            panel14.Controls.Add(label6);
            panel14.Controls.Add(textBox3);
            panel14.Location = new Point(12, 15);
            panel14.Name = "panel14";
            panel14.Size = new Size(406, 53);
            panel14.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 18);
            label6.Name = "label6";
            label6.Size = new Size(35, 19);
            label6.TabIndex = 0;
            label6.Text = "ID :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 18);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 1;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnShowTable);
            panel19.Controls.Add(btnEditTable);
            panel19.Controls.Add(btnDeleteTable);
            panel19.Controls.Add(btnAddTable);
            panel19.Location = new Point(8, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(460, 63);
            panel19.TabIndex = 8;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(327, 14);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(102, 37);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(219, 14);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(102, 37);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(111, 14);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(102, 37);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 14);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(102, 37);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(11, 72);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.Size = new Size(454, 488);
            dtgvTable.TabIndex = 7;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel21);
            tpAccount.Controls.Add(dtgvAccount);
            tpAccount.Controls.Add(panel22);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(896, 572);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Controls.Add(btnShowAccount);
            panel21.Controls.Add(btnEditAccount);
            panel21.Controls.Add(btnDeleteAccount);
            panel21.Controls.Add(btnAddAccount);
            panel21.Location = new Point(3, 6);
            panel21.Name = "panel21";
            panel21.Size = new Size(460, 63);
            panel21.TabIndex = 3;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(327, 14);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(102, 37);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(219, 14);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(102, 37);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(111, 14);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(102, 37);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 14);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(102, 37);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(6, 75);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.Size = new Size(454, 488);
            dtgvAccount.TabIndex = 4;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnResetPass);
            panel22.Controls.Add(panel24);
            panel22.Controls.Add(panel25);
            panel22.Controls.Add(panel26);
            panel22.Location = new Point(469, 75);
            panel22.Name = "panel22";
            panel22.Size = new Size(421, 491);
            panel22.TabIndex = 5;
            // 
            // btnResetPass
            // 
            btnResetPass.Location = new Point(302, 210);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(102, 37);
            btnResetPass.TabIndex = 6;
            btnResetPass.Text = "Đặt lại mật khẩu";
            btnResetPass.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(cbAccountType);
            panel24.Controls.Add(label11);
            panel24.Location = new Point(12, 133);
            panel24.Name = "panel24";
            panel24.Size = new Size(406, 53);
            panel24.TabIndex = 5;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(150, 17);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(242, 23);
            cbAccountType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 18);
            label11.Name = "label11";
            label11.Size = new Size(126, 19);
            label11.TabIndex = 0;
            label11.Text = "Loại tài khoản :";
            // 
            // panel25
            // 
            panel25.Controls.Add(label12);
            panel25.Controls.Add(txbDisplayName);
            panel25.Location = new Point(12, 74);
            panel25.Name = "panel25";
            panel25.Size = new Size(406, 53);
            panel25.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 18);
            label12.Name = "label12";
            label12.Size = new Size(108, 19);
            label12.TabIndex = 0;
            label12.Text = "Tên hiển thị :";
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(150, 18);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(242, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // panel26
            // 
            panel26.Controls.Add(label13);
            panel26.Controls.Add(txbUserName);
            panel26.Location = new Point(12, 15);
            panel26.Name = "panel26";
            panel26.Size = new Size(406, 53);
            panel26.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(18, 18);
            label13.Name = "label13";
            label13.Size = new Size(122, 19);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản :";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(150, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(242, 23);
            txbUserName.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 1;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 624);
            Controls.Add(tcBill);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcBill.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel3.ResumeLayout(false);
            tpFoodCategory.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel18.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            tpAccount.ResumeLayout(false);
            panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel22.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcBill;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgvBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Button btnViewBill;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private DataGridView dtgvFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Button btnEditFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Button btnShowFood;
        private Panel panel10;
        private Label label4;
        private Panel panel9;
        private Label label3;
        private Panel panel8;
        private Label label2;
        private TextBox txbFoodName;
        private Panel panel7;
        private Label label1;
        private TextBox txbFoodID;
        private ComboBox cbFoodCategory;
        private NumericUpDown nmFoodPrice;
        private Panel panel12;
        private Panel panel15;
        private Label label7;
        private TextBox textBox2;
        private Panel panel16;
        private Label label8;
        private TextBox txbCategoryID;
        private Panel panel17;
        private DataGridView dtgvCategory;
        private Panel panel18;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel11;
        private Panel panel20;
        private Label label9;
        private Panel panel13;
        private Label label5;
        private Panel panel14;
        private Label label6;
        private TextBox textBox3;
        private Panel panel19;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dtgvTable;
        private ComboBox cbTableStatus;
        private Panel panel21;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private DataGridView dtgvAccount;
        private Panel panel22;
        private Panel panel24;
        private ComboBox cbAccountType;
        private Label label11;
        private Panel panel25;
        private Label label12;
        private TextBox txbDisplayName;
        private Panel panel26;
        private Label label13;
        private TextBox txbUserName;
        private Button btnResetPass;
        private TextBox textBox1;
    }
}
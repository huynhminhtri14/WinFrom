namespace QuanLy
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            label1 = new Label();
            txbUserName = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            txbDisPlayName = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            textPass = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txbNewPass = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            txbReEnterPass = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbUserName);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 53);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(182, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(246, 23);
            txbUserName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbDisPlayName);
            panel1.Location = new Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 53);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị :";
            // 
            // txbDisPlayName
            // 
            txbDisPlayName.Location = new Point(182, 18);
            txbDisPlayName.Name = "txbDisPlayName";
            txbDisPlayName.Size = new Size(246, 23);
            txbDisPlayName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textPass);
            panel3.Location = new Point(12, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(455, 53);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 18);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu :";
            // 
            // textPass
            // 
            textPass.Location = new Point(182, 18);
            textPass.Name = "textPass";
            textPass.Size = new Size(246, 23);
            textPass.TabIndex = 1;
            textPass.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txbNewPass);
            panel4.Location = new Point(12, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 53);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới :";
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(182, 18);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(246, 23);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txbReEnterPass);
            panel5.Location = new Point(12, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(455, 53);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 18);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu :";
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(182, 18);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(246, 23);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(263, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(365, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 31);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(479, 398);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox txbUserName;
        private Panel panel1;
        private Label label2;
        private TextBox txbDisPlayName;
        private Panel panel3;
        private Label label3;
        private TextBox textPass;
        private Panel panel4;
        private Label label4;
        private TextBox txbNewPass;
        private Panel panel5;
        private Label label5;
        private TextBox txbReEnterPass;
        private Button btnUpdate;
        private Button btnExit;
    }
}
namespace POS
{
    partial class FrmPayCash
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.butKey_Esc = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnKey0000 = new System.Windows.Forms.Button();
            this.btnKey000 = new System.Windows.Forms.Button();
            this.btnKey0 = new System.Windows.Forms.Button();
            this.btnKey9 = new System.Windows.Forms.Button();
            this.btnKey8 = new System.Windows.Forms.Button();
            this.btnKey7 = new System.Windows.Forms.Button();
            this.btnKey6 = new System.Windows.Forms.Button();
            this.btnKey5 = new System.Windows.Forms.Button();
            this.btnKey4 = new System.Windows.Forms.Button();
            this.btnKey3 = new System.Windows.Forms.Button();
            this.btnKey2 = new System.Windows.Forms.Button();
            this.btnKey1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(93, 30);
            this.txtName.TabIndex = 63;
            this.txtName.Text = "고객 구분";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butKey_Esc
            // 
            this.butKey_Esc.BackColor = System.Drawing.SystemColors.Control;
            this.butKey_Esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butKey_Esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKey_Esc.ForeColor = System.Drawing.Color.Black;
            this.butKey_Esc.Location = new System.Drawing.Point(549, 7);
            this.butKey_Esc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butKey_Esc.Name = "butKey_Esc";
            this.butKey_Esc.Size = new System.Drawing.Size(96, 60);
            this.butKey_Esc.TabIndex = 62;
            this.butKey_Esc.Text = "ESC";
            this.butKey_Esc.UseVisualStyleBackColor = false;
            this.butKey_Esc.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.Location = new System.Drawing.Point(549, 67);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(96, 60);
            this.btnEmpty.TabIndex = 61;
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnKey0000
            // 
            this.btnKey0000.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey0000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey0000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey0000.ForeColor = System.Drawing.Color.Black;
            this.btnKey0000.Location = new System.Drawing.Point(481, 187);
            this.btnKey0000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey0000.Name = "btnKey0000";
            this.btnKey0000.Size = new System.Drawing.Size(68, 60);
            this.btnKey0000.TabIndex = 60;
            this.btnKey0000.Text = "0000";
            this.btnKey0000.UseVisualStyleBackColor = false;
            this.btnKey0000.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey000
            // 
            this.btnKey000.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey000.ForeColor = System.Drawing.Color.Black;
            this.btnKey000.Location = new System.Drawing.Point(413, 187);
            this.btnKey000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey000.Name = "btnKey000";
            this.btnKey000.Size = new System.Drawing.Size(68, 60);
            this.btnKey000.TabIndex = 59;
            this.btnKey000.Text = "000";
            this.btnKey000.UseVisualStyleBackColor = false;
            this.btnKey000.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey0
            // 
            this.btnKey0.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey0.ForeColor = System.Drawing.Color.Black;
            this.btnKey0.Location = new System.Drawing.Point(345, 187);
            this.btnKey0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey0.Name = "btnKey0";
            this.btnKey0.Size = new System.Drawing.Size(68, 60);
            this.btnKey0.TabIndex = 58;
            this.btnKey0.Text = "0";
            this.btnKey0.UseVisualStyleBackColor = false;
            this.btnKey0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey9
            // 
            this.btnKey9.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey9.ForeColor = System.Drawing.Color.Black;
            this.btnKey9.Location = new System.Drawing.Point(481, 127);
            this.btnKey9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey9.Name = "btnKey9";
            this.btnKey9.Size = new System.Drawing.Size(68, 60);
            this.btnKey9.TabIndex = 57;
            this.btnKey9.Text = "9";
            this.btnKey9.UseVisualStyleBackColor = false;
            this.btnKey9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey8
            // 
            this.btnKey8.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey8.ForeColor = System.Drawing.Color.Black;
            this.btnKey8.Location = new System.Drawing.Point(413, 127);
            this.btnKey8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey8.Name = "btnKey8";
            this.btnKey8.Size = new System.Drawing.Size(68, 60);
            this.btnKey8.TabIndex = 56;
            this.btnKey8.Text = "8";
            this.btnKey8.UseVisualStyleBackColor = false;
            this.btnKey8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey7
            // 
            this.btnKey7.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey7.ForeColor = System.Drawing.Color.Black;
            this.btnKey7.Location = new System.Drawing.Point(345, 127);
            this.btnKey7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey7.Name = "btnKey7";
            this.btnKey7.Size = new System.Drawing.Size(68, 60);
            this.btnKey7.TabIndex = 55;
            this.btnKey7.Text = "7";
            this.btnKey7.UseVisualStyleBackColor = false;
            this.btnKey7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey6
            // 
            this.btnKey6.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey6.ForeColor = System.Drawing.Color.Black;
            this.btnKey6.Location = new System.Drawing.Point(481, 67);
            this.btnKey6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey6.Name = "btnKey6";
            this.btnKey6.Size = new System.Drawing.Size(68, 60);
            this.btnKey6.TabIndex = 54;
            this.btnKey6.Text = "6";
            this.btnKey6.UseVisualStyleBackColor = false;
            this.btnKey6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey5
            // 
            this.btnKey5.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey5.ForeColor = System.Drawing.Color.Black;
            this.btnKey5.Location = new System.Drawing.Point(413, 67);
            this.btnKey5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey5.Name = "btnKey5";
            this.btnKey5.Size = new System.Drawing.Size(68, 60);
            this.btnKey5.TabIndex = 53;
            this.btnKey5.Text = "5";
            this.btnKey5.UseVisualStyleBackColor = false;
            this.btnKey5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey4
            // 
            this.btnKey4.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey4.ForeColor = System.Drawing.Color.Black;
            this.btnKey4.Location = new System.Drawing.Point(345, 67);
            this.btnKey4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey4.Name = "btnKey4";
            this.btnKey4.Size = new System.Drawing.Size(68, 60);
            this.btnKey4.TabIndex = 52;
            this.btnKey4.Text = "4";
            this.btnKey4.UseVisualStyleBackColor = false;
            this.btnKey4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey3
            // 
            this.btnKey3.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey3.ForeColor = System.Drawing.Color.Black;
            this.btnKey3.Location = new System.Drawing.Point(481, 7);
            this.btnKey3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey3.Name = "btnKey3";
            this.btnKey3.Size = new System.Drawing.Size(68, 60);
            this.btnKey3.TabIndex = 51;
            this.btnKey3.Text = "3";
            this.btnKey3.UseVisualStyleBackColor = false;
            this.btnKey3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey2
            // 
            this.btnKey2.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey2.ForeColor = System.Drawing.Color.Black;
            this.btnKey2.Location = new System.Drawing.Point(413, 7);
            this.btnKey2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(68, 60);
            this.btnKey2.TabIndex = 50;
            this.btnKey2.Text = "2";
            this.btnKey2.UseVisualStyleBackColor = false;
            this.btnKey2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey1
            // 
            this.btnKey1.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey1.ForeColor = System.Drawing.Color.Black;
            this.btnKey1.Location = new System.Drawing.Point(345, 7);
            this.btnKey1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey1.Name = "btnKey1";
            this.btnKey1.Size = new System.Drawing.Size(68, 60);
            this.btnKey1.TabIndex = 49;
            this.btnKey1.Text = "1";
            this.btnKey1.UseVisualStyleBackColor = false;
            this.btnKey1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(549, 127);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 60);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(549, 187);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 60);
            this.btnRegister.TabIndex = 47;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(111, 7);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.MaxLength = 2;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(33, 30);
            this.txtType.TabIndex = 46;
            this.txtType.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtType_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 30);
            this.textBox1.TabIndex = 64;
            this.textBox1.Text = "고객 정보";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(111, 45);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.MaxLength = 2;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(231, 30);
            this.txtInfo.TabIndex = 65;
            this.txtInfo.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInfo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "0:개인 , 1:사업자";
            // 
            // FrmPayCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 255);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.butKey_Esc);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnKey0000);
            this.Controls.Add(this.btnKey000);
            this.Controls.Add(this.btnKey0);
            this.Controls.Add(this.btnKey9);
            this.Controls.Add(this.btnKey8);
            this.Controls.Add(this.btnKey7);
            this.Controls.Add(this.btnKey6);
            this.Controls.Add(this.btnKey5);
            this.Controls.Add(this.btnKey4);
            this.Controls.Add(this.btnKey3);
            this.Controls.Add(this.btnKey2);
            this.Controls.Add(this.btnKey1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtType);
            this.Name = "FrmPayCash";
            this.Text = "현금영수증";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button butKey_Esc;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnKey0000;
        private System.Windows.Forms.Button btnKey000;
        private System.Windows.Forms.Button btnKey0;
        private System.Windows.Forms.Button btnKey9;
        private System.Windows.Forms.Button btnKey8;
        private System.Windows.Forms.Button btnKey7;
        private System.Windows.Forms.Button btnKey6;
        private System.Windows.Forms.Button btnKey5;
        private System.Windows.Forms.Button btnKey4;
        private System.Windows.Forms.Button btnKey3;
        private System.Windows.Forms.Button btnKey2;
        private System.Windows.Forms.Button btnKey1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
    }
}
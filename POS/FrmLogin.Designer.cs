namespace POS
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnKey1 = new System.Windows.Forms.Button();
            this.btnKey2 = new System.Windows.Forms.Button();
            this.btnKey3 = new System.Windows.Forms.Button();
            this.btnKey4 = new System.Windows.Forms.Button();
            this.btnKey5 = new System.Windows.Forms.Button();
            this.btnKey6 = new System.Windows.Forms.Button();
            this.btnKey7 = new System.Windows.Forms.Button();
            this.btnKey8 = new System.Windows.Forms.Button();
            this.btnKey9 = new System.Windows.Forms.Button();
            this.btnKey0 = new System.Windows.Forms.Button();
            this.btnKey000 = new System.Windows.Forms.Button();
            this.btnKey0000 = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.butKey_Esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "캐셔 번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "비밀 번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "캐셔 성명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(89, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.MaxLength = 6;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 30);
            this.txtId.TabIndex = 4;
            this.txtId.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(89, 80);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.MaxLength = 2;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(112, 30);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(89, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(112, 30);
            this.txtName.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(409, 188);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 60);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "등록";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(409, 128);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 60);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnKey1
            // 
            this.btnKey1.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey1.ForeColor = System.Drawing.Color.Black;
            this.btnKey1.Location = new System.Drawing.Point(205, 8);
            this.btnKey1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey1.Name = "btnKey1";
            this.btnKey1.Size = new System.Drawing.Size(68, 60);
            this.btnKey1.TabIndex = 9;
            this.btnKey1.Text = "1";
            this.btnKey1.UseVisualStyleBackColor = false;
            this.btnKey1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey2
            // 
            this.btnKey2.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey2.ForeColor = System.Drawing.Color.Black;
            this.btnKey2.Location = new System.Drawing.Point(273, 8);
            this.btnKey2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(68, 60);
            this.btnKey2.TabIndex = 10;
            this.btnKey2.Text = "2";
            this.btnKey2.UseVisualStyleBackColor = false;
            this.btnKey2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey3
            // 
            this.btnKey3.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey3.ForeColor = System.Drawing.Color.Black;
            this.btnKey3.Location = new System.Drawing.Point(341, 8);
            this.btnKey3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey3.Name = "btnKey3";
            this.btnKey3.Size = new System.Drawing.Size(68, 60);
            this.btnKey3.TabIndex = 11;
            this.btnKey3.Text = "3";
            this.btnKey3.UseVisualStyleBackColor = false;
            this.btnKey3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey4
            // 
            this.btnKey4.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey4.ForeColor = System.Drawing.Color.Black;
            this.btnKey4.Location = new System.Drawing.Point(205, 68);
            this.btnKey4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey4.Name = "btnKey4";
            this.btnKey4.Size = new System.Drawing.Size(68, 60);
            this.btnKey4.TabIndex = 12;
            this.btnKey4.Text = "4";
            this.btnKey4.UseVisualStyleBackColor = false;
            this.btnKey4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey5
            // 
            this.btnKey5.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey5.ForeColor = System.Drawing.Color.Black;
            this.btnKey5.Location = new System.Drawing.Point(273, 68);
            this.btnKey5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey5.Name = "btnKey5";
            this.btnKey5.Size = new System.Drawing.Size(68, 60);
            this.btnKey5.TabIndex = 13;
            this.btnKey5.Text = "5";
            this.btnKey5.UseVisualStyleBackColor = false;
            this.btnKey5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey6
            // 
            this.btnKey6.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey6.ForeColor = System.Drawing.Color.Black;
            this.btnKey6.Location = new System.Drawing.Point(341, 68);
            this.btnKey6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey6.Name = "btnKey6";
            this.btnKey6.Size = new System.Drawing.Size(68, 60);
            this.btnKey6.TabIndex = 14;
            this.btnKey6.Text = "6";
            this.btnKey6.UseVisualStyleBackColor = false;
            this.btnKey6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey7
            // 
            this.btnKey7.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey7.ForeColor = System.Drawing.Color.Black;
            this.btnKey7.Location = new System.Drawing.Point(205, 128);
            this.btnKey7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey7.Name = "btnKey7";
            this.btnKey7.Size = new System.Drawing.Size(68, 60);
            this.btnKey7.TabIndex = 15;
            this.btnKey7.Text = "7";
            this.btnKey7.UseVisualStyleBackColor = false;
            this.btnKey7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey8
            // 
            this.btnKey8.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey8.ForeColor = System.Drawing.Color.Black;
            this.btnKey8.Location = new System.Drawing.Point(273, 128);
            this.btnKey8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey8.Name = "btnKey8";
            this.btnKey8.Size = new System.Drawing.Size(68, 60);
            this.btnKey8.TabIndex = 16;
            this.btnKey8.Text = "8";
            this.btnKey8.UseVisualStyleBackColor = false;
            this.btnKey8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey9
            // 
            this.btnKey9.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey9.ForeColor = System.Drawing.Color.Black;
            this.btnKey9.Location = new System.Drawing.Point(341, 128);
            this.btnKey9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey9.Name = "btnKey9";
            this.btnKey9.Size = new System.Drawing.Size(68, 60);
            this.btnKey9.TabIndex = 17;
            this.btnKey9.Text = "9";
            this.btnKey9.UseVisualStyleBackColor = false;
            this.btnKey9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey0
            // 
            this.btnKey0.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey0.ForeColor = System.Drawing.Color.Black;
            this.btnKey0.Location = new System.Drawing.Point(205, 188);
            this.btnKey0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey0.Name = "btnKey0";
            this.btnKey0.Size = new System.Drawing.Size(68, 60);
            this.btnKey0.TabIndex = 18;
            this.btnKey0.Text = "0";
            this.btnKey0.UseVisualStyleBackColor = false;
            this.btnKey0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey000
            // 
            this.btnKey000.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey000.ForeColor = System.Drawing.Color.Black;
            this.btnKey000.Location = new System.Drawing.Point(273, 188);
            this.btnKey000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey000.Name = "btnKey000";
            this.btnKey000.Size = new System.Drawing.Size(68, 60);
            this.btnKey000.TabIndex = 19;
            this.btnKey000.Text = "000";
            this.btnKey000.UseVisualStyleBackColor = false;
            this.btnKey000.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnKey0000
            // 
            this.btnKey0000.BackColor = System.Drawing.SystemColors.Control;
            this.btnKey0000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKey0000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKey0000.ForeColor = System.Drawing.Color.Black;
            this.btnKey0000.Location = new System.Drawing.Point(341, 188);
            this.btnKey0000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKey0000.Name = "btnKey0000";
            this.btnKey0000.Size = new System.Drawing.Size(68, 60);
            this.btnKey0000.TabIndex = 20;
            this.btnKey0000.Text = "0000";
            this.btnKey0000.UseVisualStyleBackColor = false;
            this.btnKey0000.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.Location = new System.Drawing.Point(409, 68);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(96, 60);
            this.btnEmpty.TabIndex = 21;
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // butKey_Esc
            // 
            this.butKey_Esc.BackColor = System.Drawing.SystemColors.Control;
            this.butKey_Esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butKey_Esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKey_Esc.ForeColor = System.Drawing.Color.Black;
            this.butKey_Esc.Location = new System.Drawing.Point(409, 8);
            this.butKey_Esc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butKey_Esc.Name = "butKey_Esc";
            this.butKey_Esc.Size = new System.Drawing.Size(96, 60);
            this.butKey_Esc.TabIndex = 22;
            this.butKey_Esc.Text = "ESC";
            this.butKey_Esc.UseVisualStyleBackColor = false;
            this.butKey_Esc.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(514, 255);
            this.ControlBox = false;
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
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "캐셔 로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnKey1;
        private System.Windows.Forms.Button btnKey2;
        private System.Windows.Forms.Button btnKey3;
        private System.Windows.Forms.Button btnKey4;
        private System.Windows.Forms.Button btnKey5;
        private System.Windows.Forms.Button btnKey6;
        private System.Windows.Forms.Button btnKey7;
        private System.Windows.Forms.Button btnKey8;
        private System.Windows.Forms.Button btnKey9;
        private System.Windows.Forms.Button btnKey0;
        private System.Windows.Forms.Button btnKey000;
        private System.Windows.Forms.Button btnKey0000;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button butKey_Esc;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPwd;
    }
}


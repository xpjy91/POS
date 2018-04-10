namespace POS
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStartSale = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCloseSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.grdNotice = new System.Windows.Forms.DataGridView();
            this.colSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveSale = new System.Windows.Forms.Button();
            this.lblCashierNo = new System.Windows.Forms.Label();
            this.pnlSaleInfo = new System.Windows.Forms.Panel();
            this.txtCashierNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.txtCurrentHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaleState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSaleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSale
            // 
            this.btnStartSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSale.Location = new System.Drawing.Point(817, 100);
            this.btnStartSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartSale.Name = "btnStartSale";
            this.btnStartSale.Size = new System.Drawing.Size(198, 71);
            this.btnStartSale.TabIndex = 1;
            this.btnStartSale.Text = "1. 영업개시";
            this.btnStartSale.UseVisualStyleBackColor = false;
            this.btnStartSale.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(817, 250);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "3. 마감입금";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(817, 325);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "4. 정산출력";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(817, 403);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 71);
            this.button6.TabIndex = 5;
            this.button6.Text = "5. 관리설정";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(817, 478);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 71);
            this.button7.TabIndex = 6;
            this.button7.Text = "6. 영업관리";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnCloseSale
            // 
            this.btnCloseSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseSale.Enabled = false;
            this.btnCloseSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSale.Location = new System.Drawing.Point(817, 553);
            this.btnCloseSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseSale.Name = "btnCloseSale";
            this.btnCloseSale.Size = new System.Drawing.Size(198, 71);
            this.btnCloseSale.TabIndex = 7;
            this.btnCloseSale.Text = "7. 영업종료";
            this.btnCloseSale.UseVisualStyleBackColor = false;
            this.btnCloseSale.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(817, 690);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 71);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "9. 종    료";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "1.xx.xxx.xxxx.test version";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(372, 452);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 41);
            this.button10.TabIndex = 25;
            this.button10.Text = "0. 공지조회";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(372, 495);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(413, 41);
            this.button11.TabIndex = 26;
            this.button11.Text = "What\'s new 공지사항";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // grdNotice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNotice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeq,
            this.colTitle});
            this.grdNotice.Location = new System.Drawing.Point(372, 539);
            this.grdNotice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdNotice.Name = "grdNotice";
            this.grdNotice.RowHeadersVisible = false;
            this.grdNotice.RowTemplate.Height = 23;
            this.grdNotice.Size = new System.Drawing.Size(413, 221);
            this.grdNotice.TabIndex = 27;
            // 
            // colSeq
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSeq.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSeq.HeaderText = "공지번호";
            this.colSeq.Name = "colSeq";
            // 
            // colTitle
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTitle.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTitle.HeaderText = "공지제목";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 300;
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(576, 100);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(85, 81);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(482, 100);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 81);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(389, 100);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(85, 81);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(294, 100);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 81);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(200, 100);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 81);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(105, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 81);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 81);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveSale
            // 
            this.btnSaveSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSale.Enabled = false;
            this.btnSaveSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSale.Location = new System.Drawing.Point(817, 175);
            this.btnSaveSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSale.Name = "btnSaveSale";
            this.btnSaveSale.Size = new System.Drawing.Size(198, 71);
            this.btnSaveSale.TabIndex = 2;
            this.btnSaveSale.Text = "2. 판매등록";
            this.btnSaveSale.UseVisualStyleBackColor = false;
            this.btnSaveSale.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblCashierNo
            // 
            this.lblCashierNo.AutoSize = true;
            this.lblCashierNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierNo.Location = new System.Drawing.Point(94, 65);
            this.lblCashierNo.Name = "lblCashierNo";
            this.lblCashierNo.Size = new System.Drawing.Size(62, 18);
            this.lblCashierNo.TabIndex = 83;
            this.lblCashierNo.Text = "000000";
            // 
            // pnlSaleInfo
            // 
            this.pnlSaleInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSaleInfo.Controls.Add(this.txtCashierNo);
            this.pnlSaleInfo.Controls.Add(this.label2);
            this.pnlSaleInfo.Controls.Add(this.txtCurrentDate);
            this.pnlSaleInfo.Controls.Add(this.textBox7);
            this.pnlSaleInfo.Controls.Add(this.textBox4);
            this.pnlSaleInfo.Controls.Add(this.label4);
            this.pnlSaleInfo.Controls.Add(this.txtPosNo);
            this.pnlSaleInfo.Controls.Add(this.label5);
            this.pnlSaleInfo.Controls.Add(this.label3);
            this.pnlSaleInfo.Controls.Add(this.textBox8);
            this.pnlSaleInfo.Controls.Add(this.label1);
            this.pnlSaleInfo.Controls.Add(this.textBox9);
            this.pnlSaleInfo.Controls.Add(this.txtState);
            this.pnlSaleInfo.Controls.Add(this.txtCashierName);
            this.pnlSaleInfo.Controls.Add(this.txtCurrentHour);
            this.pnlSaleInfo.Controls.Add(this.label6);
            this.pnlSaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSaleInfo.Location = new System.Drawing.Point(166, 11);
            this.pnlSaleInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSaleInfo.Name = "pnlSaleInfo";
            this.pnlSaleInfo.Size = new System.Drawing.Size(744, 82);
            this.pnlSaleInfo.TabIndex = 81;
            // 
            // txtCashierNo
            // 
            this.txtCashierNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierNo.Location = new System.Drawing.Point(280, 44);
            this.txtCashierNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCashierNo.Name = "txtCashierNo";
            this.txtCashierNo.ReadOnly = true;
            this.txtCashierNo.Size = new System.Drawing.Size(109, 30);
            this.txtCashierNo.TabIndex = 11;
            this.txtCashierNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "* 거래발생";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDate.Location = new System.Drawing.Point(168, 9);
            this.txtCurrentDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(109, 30);
            this.txtCurrentDate.TabIndex = 2;
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(657, 45);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(78, 30);
            this.textBox7.TabIndex = 15;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(480, 11);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(78, 30);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "* 거래번호";
            // 
            // txtPosNo
            // 
            this.txtPosNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosNo.Location = new System.Drawing.Point(89, 9);
            this.txtPosNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosNo.Name = "txtPosNo";
            this.txtPosNo.ReadOnly = true;
            this.txtPosNo.Size = new System.Drawing.Size(76, 30);
            this.txtPosNo.TabIndex = 1;
            this.txtPosNo.Text = "0001";
            this.txtPosNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "* 거래보류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "* 통신상태";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(89, 44);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(76, 30);
            this.textBox8.TabIndex = 9;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "* POS";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(480, 45);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(78, 30);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(657, 11);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(78, 30);
            this.txtState.TabIndex = 7;
            this.txtState.Text = "OFF";
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCashierName
            // 
            this.txtCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierName.Location = new System.Drawing.Point(168, 44);
            this.txtCashierName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.ReadOnly = true;
            this.txtCashierName.Size = new System.Drawing.Size(109, 30);
            this.txtCashierName.TabIndex = 10;
            this.txtCashierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentHour
            // 
            this.txtCurrentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHour.Location = new System.Drawing.Point(280, 9);
            this.txtCurrentHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentHour.Name = "txtCurrentHour";
            this.txtCurrentHour.ReadOnly = true;
            this.txtCurrentHour.Size = new System.Drawing.Size(109, 30);
            this.txtCurrentHour.TabIndex = 3;
            this.txtCurrentHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "* 거래송신";
            // 
            // lblSaleState
            // 
            this.lblSaleState.AutoSize = true;
            this.lblSaleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleState.Location = new System.Drawing.Point(86, 13);
            this.lblSaleState.Name = "lblSaleState";
            this.lblSaleState.Size = new System.Drawing.Size(86, 46);
            this.lblSaleState.TabIndex = 82;
            this.lblSaleState.Text = "마감";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(912, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 86);
            this.button1.TabIndex = 79;
            this.button1.Text = "프린터:ON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(14, 12);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(72, 77);
            this.pictureBox8.TabIndex = 80;
            this.pictureBox8.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblCashierNo);
            this.Controls.Add(this.pnlSaleInfo);
            this.Controls.Add(this.lblSaleState);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdNotice);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCloseSale);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStartSale);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSaveSale);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSaleInfo.ResumeLayout(false);
            this.pnlSaleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartSale;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnCloseSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView grdNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveSale;
        public System.Windows.Forms.Label lblCashierNo;
        public System.Windows.Forms.Panel pnlSaleInfo;
        public System.Windows.Forms.TextBox txtCashierNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox txtState;
        public System.Windows.Forms.TextBox txtCashierName;
        private System.Windows.Forms.TextBox txtCurrentHour;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblSaleState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
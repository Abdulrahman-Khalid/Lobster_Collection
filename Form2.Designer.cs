namespace WindowsFormsApp6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericId = new System.Windows.Forms.NumericUpDown();
            this.showList = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSUM = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSUM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(66, 717);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 53);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "أضافة ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.MintCream;
            this.btnShow.Location = new System.Drawing.Point(393, 717);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(230, 53);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "تحديث";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Navy;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangePassword.Location = new System.Drawing.Point(1035, 717);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(230, 53);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "تحديث كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(719, 717);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "مسح";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم الشركة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "كمية الاستاكوزا";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(78, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "المبلغ المدفوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(96, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "رقم المطالبة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(148, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "التاريخ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(160, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "الدولة";
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(257, 40);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(250, 24);
            this.txtBoxCompanyName.TabIndex = 13;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(257, 601);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 24);
            this.txtCountry.TabIndex = 14;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(257, 147);
            this.numericQuantity.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(250, 24);
            this.numericQuantity.TabIndex = 16;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(257, 255);
            this.numericPrice.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(250, 24);
            this.numericPrice.TabIndex = 17;
            this.numericPrice.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericId
            // 
            this.numericId.Location = new System.Drawing.Point(257, 373);
            this.numericId.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(250, 24);
            this.numericId.TabIndex = 18;
            // 
            // showList
            // 
            this.showList.AllowUserToAddRows = false;
            this.showList.AllowUserToDeleteRows = false;
            this.showList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showList.Location = new System.Drawing.Point(547, 82);
            this.showList.Name = "showList";
            this.showList.ReadOnly = true;
            this.showList.RowTemplate.Height = 26;
            this.showList.Size = new System.Drawing.Size(786, 339);
            this.showList.TabIndex = 19;
            this.showList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showList_CellContentClick);
            this.showList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showList_RowHeaderMouseClick);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(257, 491);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(250, 24);
            this.datePicker.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(643, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(690, 24);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(562, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "البحث";
            // 
            // dataSUM
            // 
            this.dataSUM.AllowUserToAddRows = false;
            this.dataSUM.AllowUserToDeleteRows = false;
            this.dataSUM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSUM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSUM.Location = new System.Drawing.Point(547, 427);
            this.dataSUM.Name = "dataSUM";
            this.dataSUM.ReadOnly = true;
            this.dataSUM.RowTemplate.Height = 26;
            this.dataSUM.Size = new System.Drawing.Size(786, 273);
            this.dataSUM.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.MintCream;
            this.btnClear.Location = new System.Drawing.Point(257, 647);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 53);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "تفريغ الخانات";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 783);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataSUM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.numericId);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtBoxCompanyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "حصر الاستاكوزا";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericId;
        private System.Windows.Forms.DataGridView showList;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataSUM;
        private System.Windows.Forms.Button btnClear;
    }
}
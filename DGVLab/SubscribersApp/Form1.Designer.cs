namespace SubscribersApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_debt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.button_rangeByYears = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_showDebt = new System.Windows.Forms.Button();
            this.button_findByNumber = new System.Windows.Forms.Button();
            this.textBox_findByNumber = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithBinaryFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWithXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWithBinaryFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(668, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(849, 113);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(144, 26);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(849, 166);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(146, 26);
            this.textBox_number.TabIndex = 2;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(849, 217);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(144, 26);
            this.textBox_year.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // checkBox_debt
            // 
            this.checkBox_debt.AutoSize = true;
            this.checkBox_debt.Location = new System.Drawing.Point(849, 275);
            this.checkBox_debt.Name = "checkBox_debt";
            this.checkBox_debt.Size = new System.Drawing.Size(70, 24);
            this.checkBox_debt.TabIndex = 7;
            this.checkBox_debt.Text = "Debt";
            this.checkBox_debt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add new Subscriber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(98, 426);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(100, 26);
            this.textBox_from.TabIndex = 9;
            // 
            // textBox_to
            // 
            this.textBox_to.Location = new System.Drawing.Point(98, 464);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(100, 26);
            this.textBox_to.TabIndex = 10;
            // 
            // button_rangeByYears
            // 
            this.button_rangeByYears.Location = new System.Drawing.Point(98, 513);
            this.button_rangeByYears.Name = "button_rangeByYears";
            this.button_rangeByYears.Size = new System.Drawing.Size(84, 34);
            this.button_rangeByYears.TabIndex = 11;
            this.button_rangeByYears.Text = "Find";
            this.button_rangeByYears.UseVisualStyleBackColor = true;
            this.button_rangeByYears.Click += new System.EventHandler(this.button_rangeByYears_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "To";
            // 
            // button_showDebt
            // 
            this.button_showDebt.Location = new System.Drawing.Point(442, 514);
            this.button_showDebt.Name = "button_showDebt";
            this.button_showDebt.Size = new System.Drawing.Size(115, 33);
            this.button_showDebt.TabIndex = 14;
            this.button_showDebt.Text = "Show Debts";
            this.button_showDebt.UseVisualStyleBackColor = true;
            this.button_showDebt.Click += new System.EventHandler(this.button_showDebt_Click);
            // 
            // button_findByNumber
            // 
            this.button_findByNumber.Location = new System.Drawing.Point(232, 514);
            this.button_findByNumber.Name = "button_findByNumber";
            this.button_findByNumber.Size = new System.Drawing.Size(170, 33);
            this.button_findByNumber.TabIndex = 15;
            this.button_findByNumber.Text = "Find by Number";
            this.button_findByNumber.UseVisualStyleBackColor = true;
            this.button_findByNumber.Click += new System.EventHandler(this.button_findByNumber_Click);
            // 
            // textBox_findByNumber
            // 
            this.textBox_findByNumber.Location = new System.Drawing.Point(232, 464);
            this.textBox_findByNumber.Name = "textBox_findByNumber";
            this.textBox_findByNumber.Size = new System.Drawing.Size(170, 26);
            this.textBox_findByNumber.TabIndex = 16;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWithXMLToolStripMenuItem,
            this.openWithBinaryFormatToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openWithXMLToolStripMenuItem
            // 
            this.openWithXMLToolStripMenuItem.Name = "openWithXMLToolStripMenuItem";
            this.openWithXMLToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.openWithXMLToolStripMenuItem.Text = "Open with XML";
            this.openWithXMLToolStripMenuItem.Click += new System.EventHandler(this.openWithXMLToolStripMenuItem_Click);
            // 
            // openWithBinaryFormatToolStripMenuItem
            // 
            this.openWithBinaryFormatToolStripMenuItem.Name = "openWithBinaryFormatToolStripMenuItem";
            this.openWithBinaryFormatToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.openWithBinaryFormatToolStripMenuItem.Text = "Open with BinaryFormat";
            this.openWithBinaryFormatToolStripMenuItem.Click += new System.EventHandler(this.openWithBinaryFormatToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveWithXMLToolStripMenuItem,
            this.saveWithBinaryFormatToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveWithXMLToolStripMenuItem
            // 
            this.saveWithXMLToolStripMenuItem.Name = "saveWithXMLToolStripMenuItem";
            this.saveWithXMLToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.saveWithXMLToolStripMenuItem.Text = "Save with XML";
            this.saveWithXMLToolStripMenuItem.Click += new System.EventHandler(this.saveWithXMLToolStripMenuItem_Click);
            // 
            // saveWithBinaryFormatToolStripMenuItem
            // 
            this.saveWithBinaryFormatToolStripMenuItem.Name = "saveWithBinaryFormatToolStripMenuItem";
            this.saveWithBinaryFormatToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.saveWithBinaryFormatToolStripMenuItem.Text = "Save with BinaryFormat";
            this.saveWithBinaryFormatToolStripMenuItem.Click += new System.EventHandler(this.saveWithBinaryFormatToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 609);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_findByNumber);
            this.Controls.Add(this.button_findByNumber);
            this.Controls.Add(this.button_showDebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_rangeByYears);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_debt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_debt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.Button button_rangeByYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_showDebt;
        private System.Windows.Forms.Button button_findByNumber;
        private System.Windows.Forms.TextBox textBox_findByNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem openWithXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithBinaryFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWithXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWithBinaryFormatToolStripMenuItem;
    }
}


namespace Module1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_painter = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_nameOfPicture = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(670, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add To Gallery";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(820, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(149, 26);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_painter
            // 
            this.textBox_painter.Location = new System.Drawing.Point(820, 84);
            this.textBox_painter.Name = "textBox_painter";
            this.textBox_painter.Size = new System.Drawing.Size(149, 26);
            this.textBox_painter.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_nameOfPicture
            // 
            this.textBox_nameOfPicture.Location = new System.Drawing.Point(820, 132);
            this.textBox_nameOfPicture.Name = "textBox_nameOfPicture";
            this.textBox_nameOfPicture.Size = new System.Drawing.Size(149, 26);
            this.textBox_nameOfPicture.TabIndex = 5;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(820, 179);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(149, 26);
            this.textBox_price.TabIndex = 6;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(820, 230);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(149, 26);
            this.textBox_status.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Painter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name of Picture:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "General Price";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 33);
            this.menuStrip1.TabIndex = 14;
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
            this.asBinaryToolStripMenuItem,
            this.openAsXMLToolStripMenuItem,
            this.openAsJSONToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // asBinaryToolStripMenuItem
            // 
            this.asBinaryToolStripMenuItem.Name = "asBinaryToolStripMenuItem";
            this.asBinaryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.asBinaryToolStripMenuItem.Text = "Open As Binary";
            this.asBinaryToolStripMenuItem.Click += new System.EventHandler(this.asBinaryToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsBinaryToolStripMenuItem,
            this.saveAsXMLToolStripMenuItem,
            this.saveAsJSONToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsBinaryToolStripMenuItem
            // 
            this.saveAsBinaryToolStripMenuItem.Name = "saveAsBinaryToolStripMenuItem";
            this.saveAsBinaryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveAsBinaryToolStripMenuItem.Text = "Save as Binary";
            this.saveAsBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveAsBinaryToolStripMenuItem_Click);
            // 
            // openAsXMLToolStripMenuItem
            // 
            this.openAsXMLToolStripMenuItem.Name = "openAsXMLToolStripMenuItem";
            this.openAsXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openAsXMLToolStripMenuItem.Text = "Open as XML";
            this.openAsXMLToolStripMenuItem.Click += new System.EventHandler(this.openAsXMLToolStripMenuItem_Click);
            // 
            // saveAsXMLToolStripMenuItem
            // 
            this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
            this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveAsXMLToolStripMenuItem.Text = "Save as XML";
            this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler(this.saveAsXMLToolStripMenuItem_Click);
            // 
            // openAsJSONToolStripMenuItem
            // 
            this.openAsJSONToolStripMenuItem.Name = "openAsJSONToolStripMenuItem";
            this.openAsJSONToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openAsJSONToolStripMenuItem.Text = "Open as JSON";
            this.openAsJSONToolStripMenuItem.Click += new System.EventHandler(this.openAsJSONToolStripMenuItem_Click);
            // 
            // saveAsJSONToolStripMenuItem
            // 
            this.saveAsJSONToolStripMenuItem.Name = "saveAsJSONToolStripMenuItem";
            this.saveAsJSONToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveAsJSONToolStripMenuItem.Text = "Save as JSON";
            this.saveAsJSONToolStripMenuItem.Click += new System.EventHandler(this.saveAsJSONToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(743, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 54);
            this.button3.TabIndex = 16;
            this.button3.Text = "Show Diagram";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(33, 404);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(689, 227);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(975, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 52);
            this.button4.TabIndex = 18;
            this.button4.Text = "Show Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 730);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_nameOfPicture);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_painter);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_painter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_nameOfPicture;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAsJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsJSONToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
    }
}


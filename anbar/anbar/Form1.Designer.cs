namespace anbar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox7 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(-2, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 189);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "product name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "weight";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "count";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "barcode";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "shelf numb";
            Column6.Name = "Column6";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product info";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(194, 77);
            button2.Name = "button2";
            button2.Size = new Size(106, 41);
            button2.TabIndex = 10;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(194, 37);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Search product";
            textBox7.Size = new Size(106, 25);
            textBox7.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(194, 222);
            button3.Name = "button3";
            button3.Size = new Size(106, 38);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(194, 175);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(18, 278);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Shelf num";
            textBox6.Size = new Size(106, 25);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 230);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Barcode";
            textBox5.Size = new Size(106, 25);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 180);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Price";
            textBox3.Size = new Size(106, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 133);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Count";
            textBox4.Size = new Size(106, 25);
            textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 86);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Weight";
            textBox2.Size = new Size(106, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(106, 25);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.business;
            pictureBox1.Location = new Point(436, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 325);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "All product list";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(633, 325);
            button4.Name = "button4";
            button4.Size = new Size(106, 38);
            button4.TabIndex = 11;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 556);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox7;
        private Button button3;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button4;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
    }
}

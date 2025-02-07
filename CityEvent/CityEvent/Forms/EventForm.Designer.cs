namespace CityEvent.Forms
{
    partial class EventForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtVenue = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtCapacity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            dateTimePicker = new DateTimePicker();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(72, 77);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(195, 73);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 34);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(77, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // txtVenue
            // 
            txtVenue.Font = new Font("Segoe UI", 12F);
            txtVenue.Location = new Point(195, 197);
            txtVenue.Margin = new Padding(3, 4, 3, 4);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(228, 34);
            txtVenue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(77, 201);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 4;
            label3.Text = "Venue";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(195, 372);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(228, 34);
            txtPrice.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(77, 376);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 10;
            label4.Text = "Ticket Price";
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Segoe UI", 12F);
            txtCapacity.Location = new Point(195, 311);
            txtCapacity.Margin = new Padding(3, 4, 3, 4);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(228, 34);
            txtCapacity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(77, 315);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 8;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(77, 252);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 6;
            label6.Text = "Type";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(281, 459);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(195, 140);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Conference", "Concert", "Wedding", "Other" });
            comboBox1.Location = new Point(195, 255);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 443);
            dataGridView1.TabIndex = 15;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 613);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtCapacity);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtVenue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtVenue;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtCapacity;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}
namespace DataBase01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Customers = new System.Windows.Forms.TabPage();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_button2 = new System.Windows.Forms.Button();
            this.update_button2 = new System.Windows.Forms.Button();
            this.add_button2 = new System.Windows.Forms.Button();
            this.download_button2 = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.TabPage();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_button1 = new System.Windows.Forms.Button();
            this.update_button1 = new System.Windows.Forms.Button();
            this.add_button1 = new System.Windows.Forms.Button();
            this.download_button1 = new System.Windows.Forms.Button();
            this.DB = new System.Windows.Forms.TabControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB1DataSet = new DataBase01.DB1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Timetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.DGV2);
            this.Customers.Controls.Add(this.groupBox2);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(697, 432);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Абонименты";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // DGV2
            // 
            this.DGV2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.Description,
            this.Price,
            this.Value});
            this.DGV2.Location = new System.Drawing.Point(0, 6);
            this.DGV2.Name = "DGV2";
            this.DGV2.Size = new System.Drawing.Size(694, 340);
            this.DGV2.TabIndex = 2;
            // 
            // id2
            // 
            this.id2.HeaderText = "Код абонимента";
            this.id2.Name = "id2";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            // 
            // Value
            // 
            this.Value.HeaderText = "Оплачено";
            this.Value.Name = "Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_button2);
            this.groupBox2.Controls.Add(this.update_button2);
            this.groupBox2.Controls.Add(this.add_button2);
            this.groupBox2.Controls.Add(this.download_button2);
            this.groupBox2.Location = new System.Drawing.Point(59, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // delete_button2
            // 
            this.delete_button2.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button2.Location = new System.Drawing.Point(408, 10);
            this.delete_button2.Name = "delete_button2";
            this.delete_button2.Size = new System.Drawing.Size(128, 42);
            this.delete_button2.TabIndex = 3;
            this.delete_button2.Text = "Удалить";
            this.delete_button2.UseCompatibleTextRendering = true;
            this.delete_button2.UseVisualStyleBackColor = true;
            this.delete_button2.Click += new System.EventHandler(this.delete_button2_Click);
            // 
            // update_button2
            // 
            this.update_button2.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button2.Location = new System.Drawing.Point(274, 10);
            this.update_button2.Name = "update_button2";
            this.update_button2.Size = new System.Drawing.Size(128, 42);
            this.update_button2.TabIndex = 2;
            this.update_button2.Text = "Обновить";
            this.update_button2.UseCompatibleTextRendering = true;
            this.update_button2.UseVisualStyleBackColor = true;
            this.update_button2.Click += new System.EventHandler(this.update_button2_Click);
            // 
            // add_button2
            // 
            this.add_button2.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button2.Location = new System.Drawing.Point(140, 10);
            this.add_button2.Name = "add_button2";
            this.add_button2.Size = new System.Drawing.Size(128, 42);
            this.add_button2.TabIndex = 1;
            this.add_button2.Text = "Добавить";
            this.add_button2.UseCompatibleTextRendering = true;
            this.add_button2.UseVisualStyleBackColor = true;
            this.add_button2.Click += new System.EventHandler(this.add_button2_Click);
            // 
            // download_button2
            // 
            this.download_button2.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_button2.Location = new System.Drawing.Point(6, 10);
            this.download_button2.Name = "download_button2";
            this.download_button2.Size = new System.Drawing.Size(128, 42);
            this.download_button2.TabIndex = 0;
            this.download_button2.Text = "Загрузить";
            this.download_button2.UseCompatibleTextRendering = true;
            this.download_button2.UseVisualStyleBackColor = true;
            this.download_button2.Click += new System.EventHandler(this.download_button2_Click);
            // 
            // Timetable
            // 
            this.Timetable.BackColor = System.Drawing.Color.Transparent;
            this.Timetable.Controls.Add(this.label1);
            this.Timetable.Controls.Add(this.textBox1);
            this.Timetable.Controls.Add(this.DGV1);
            this.Timetable.Controls.Add(this.groupBox1);
            this.Timetable.Location = new System.Drawing.Point(4, 22);
            this.Timetable.Name = "Timetable";
            this.Timetable.Padding = new System.Windows.Forms.Padding(3);
            this.Timetable.Size = new System.Drawing.Size(697, 432);
            this.Timetable.TabIndex = 0;
            this.Timetable.Text = "Информация о посетителях";
            // 
            // DGV1
            // 
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Last_name,
            this.Name,
            this.Code,
            this.Phone});
            this.DGV1.Location = new System.Drawing.Point(0, 3);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(694, 260);
            this.DGV1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Last_name
            // 
            this.Last_name.HeaderText = "Фамилия";
            this.Last_name.Name = "Last_name";
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Code
            // 
            this.Code.HeaderText = "Код абонимента";
            this.Code.Name = "Code";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.delete_button1);
            this.groupBox1.Controls.Add(this.update_button1);
            this.groupBox1.Controls.Add(this.add_button1);
            this.groupBox1.Controls.Add(this.download_button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // delete_button1
            // 
            this.delete_button1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button1.Location = new System.Drawing.Point(408, 10);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(128, 42);
            this.delete_button1.TabIndex = 3;
            this.delete_button1.Text = "Удалить";
            this.delete_button1.UseCompatibleTextRendering = true;
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Click += new System.EventHandler(this.delete_button1_Click);
            // 
            // update_button1
            // 
            this.update_button1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button1.Location = new System.Drawing.Point(274, 10);
            this.update_button1.Name = "update_button1";
            this.update_button1.Size = new System.Drawing.Size(128, 42);
            this.update_button1.TabIndex = 2;
            this.update_button1.Text = "Обновить";
            this.update_button1.UseCompatibleTextRendering = true;
            this.update_button1.UseVisualStyleBackColor = true;
            this.update_button1.Click += new System.EventHandler(this.update_button1_Click);
            // 
            // add_button1
            // 
            this.add_button1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button1.Location = new System.Drawing.Point(140, 10);
            this.add_button1.Name = "add_button1";
            this.add_button1.Size = new System.Drawing.Size(128, 42);
            this.add_button1.TabIndex = 1;
            this.add_button1.Text = "Добавить";
            this.add_button1.UseCompatibleTextRendering = true;
            this.add_button1.UseVisualStyleBackColor = true;
            this.add_button1.Click += new System.EventHandler(this.add_button1_Click);
            // 
            // download_button1
            // 
            this.download_button1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_button1.Location = new System.Drawing.Point(6, 10);
            this.download_button1.Name = "download_button1";
            this.download_button1.Size = new System.Drawing.Size(128, 42);
            this.download_button1.TabIndex = 0;
            this.download_button1.Text = "Загрузить";
            this.download_button1.UseCompatibleTextRendering = true;
            this.download_button1.UseVisualStyleBackColor = true;
            this.download_button1.Click += new System.EventHandler(this.download_button1_Click);
            // 
            // DB
            // 
            this.DB.Controls.Add(this.Timetable);
            this.DB.Controls.Add(this.Customers);
            this.DB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB.Location = new System.Drawing.Point(0, 0);
            this.DB.Name = "DB";
            this.DB.SelectedIndex = 0;
            this.DB.Size = new System.Drawing.Size(705, 458);
            this.DB.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dB1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // dB1DataSet
            // 
            this.dB1DataSet.DataSetName = "DB1DataSet";
            this.dB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск по Фамилии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(705, 458);
            this.Controls.Add(this.DB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
 
            this.Text = "БАЗА ДАННЫХ БАССЕЙНА";
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.Timetable.ResumeLayout(false);
            this.Timetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.DB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delete_button2;
        private System.Windows.Forms.Button update_button2;
        private System.Windows.Forms.Button add_button2;
        private System.Windows.Forms.Button download_button2;
        private System.Windows.Forms.TabPage Timetable;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_button1;
        private System.Windows.Forms.Button update_button1;
        private System.Windows.Forms.Button add_button1;
        private System.Windows.Forms.Button download_button1;
        private System.Windows.Forms.TabControl DB;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DB1DataSet dB1DataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


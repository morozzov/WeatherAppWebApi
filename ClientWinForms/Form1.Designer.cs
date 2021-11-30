namespace ClientWinForms
{
    partial class FormMain
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
            this.dataGridViewWeatherData = new System.Windows.Forms.DataGridView();
            this.buttonGetWeatherData = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGetByName = new System.Windows.Forms.Button();
            this.buttonDeleteByName = new System.Windows.Forms.Button();
            this.buttonUpdateByName = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeatherData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWeatherData
            // 
            this.dataGridViewWeatherData.AllowUserToAddRows = false;
            this.dataGridViewWeatherData.AllowUserToDeleteRows = false;
            this.dataGridViewWeatherData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeatherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeatherData.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewWeatherData.Name = "dataGridViewWeatherData";
            this.dataGridViewWeatherData.ReadOnly = true;
            this.dataGridViewWeatherData.RowHeadersWidth = 51;
            this.dataGridViewWeatherData.RowTemplate.Height = 24;
            this.dataGridViewWeatherData.Size = new System.Drawing.Size(458, 371);
            this.dataGridViewWeatherData.TabIndex = 0;
            // 
            // buttonGetWeatherData
            // 
            this.buttonGetWeatherData.Location = new System.Drawing.Point(12, 394);
            this.buttonGetWeatherData.Name = "buttonGetWeatherData";
            this.buttonGetWeatherData.Size = new System.Drawing.Size(458, 23);
            this.buttonGetWeatherData.TabIndex = 1;
            this.buttonGetWeatherData.Text = "GetWeatherData";
            this.buttonGetWeatherData.UseVisualStyleBackColor = true;
            this.buttonGetWeatherData.Click += new System.EventHandler(this.buttonGetWeatherData_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(487, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonGetByName
            // 
            this.buttonGetByName.Location = new System.Drawing.Point(487, 42);
            this.buttonGetByName.Name = "buttonGetByName";
            this.buttonGetByName.Size = new System.Drawing.Size(246, 23);
            this.buttonGetByName.TabIndex = 3;
            this.buttonGetByName.Text = "GetByName";
            this.buttonGetByName.UseVisualStyleBackColor = true;
            this.buttonGetByName.Click += new System.EventHandler(this.buttonGetByName_Click);
            // 
            // buttonDeleteByName
            // 
            this.buttonDeleteByName.Location = new System.Drawing.Point(487, 71);
            this.buttonDeleteByName.Name = "buttonDeleteByName";
            this.buttonDeleteByName.Size = new System.Drawing.Size(246, 23);
            this.buttonDeleteByName.TabIndex = 4;
            this.buttonDeleteByName.Text = "DeleteByName";
            this.buttonDeleteByName.UseVisualStyleBackColor = true;
            this.buttonDeleteByName.Click += new System.EventHandler(this.buttonDeleteByName_Click);
            // 
            // buttonUpdateByName
            // 
            this.buttonUpdateByName.Location = new System.Drawing.Point(487, 361);
            this.buttonUpdateByName.Name = "buttonUpdateByName";
            this.buttonUpdateByName.Size = new System.Drawing.Size(246, 23);
            this.buttonUpdateByName.TabIndex = 5;
            this.buttonUpdateByName.Text = "UpdateByName";
            this.buttonUpdateByName.UseVisualStyleBackColor = true;
            this.buttonUpdateByName.Click += new System.EventHandler(this.buttonUpdateByName_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(488, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(246, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(615, 298);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(119, 22);
            this.textBoxTemperature.TabIndex = 8;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(487, 298);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(119, 22);
            this.textBoxNewName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 191);
            this.button1.TabIndex = 9;
            this.button1.Text = "Don\'t touch me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.buttonUpdateByName);
            this.Controls.Add(this.buttonDeleteByName);
            this.Controls.Add(this.buttonGetByName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonGetWeatherData);
            this.Controls.Add(this.dataGridViewWeatherData);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeatherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWeatherData;
        private System.Windows.Forms.Button buttonGetWeatherData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGetByName;
        private System.Windows.Forms.Button buttonDeleteByName;
        private System.Windows.Forms.Button buttonUpdateByName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button button1;
    }
}


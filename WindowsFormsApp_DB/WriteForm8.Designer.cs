namespace WindowsFormsApp_DB
{
    partial class WriteForm8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.nameForm = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.namebd = new System.Windows.Forms.Label();
            this.groupBoxJob = new System.Windows.Forms.GroupBox();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRespond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRespond = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.groupBoxJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.nameForm);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.namebd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 161);
            this.panel1.TabIndex = 14;
            // 
            // closeButton
            // 
            this.closeButton.Image = global::WindowsFormsApp_DB.Properties.Resources.closeButton;
            this.closeButton.Location = new System.Drawing.Point(545, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 55);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 10;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.BackColor = System.Drawing.Color.Transparent;
            this.nameForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameForm.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForm.Location = new System.Drawing.Point(-6, 116);
            this.nameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(579, 33);
            this.nameForm.TabIndex = 6;
            this.nameForm.Text = "ДОБАВЛЕНИЕ ОБЯЗАННОСТЕЙ СОТРУДНИКАМ";
            this.nameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Image = global::WindowsFormsApp_DB.Properties.Resources.backArrow;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 55);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 6;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // namebd
            // 
            this.namebd.BackColor = System.Drawing.Color.Transparent;
            this.namebd.Cursor = System.Windows.Forms.Cursors.Default;
            this.namebd.Dock = System.Windows.Forms.DockStyle.Top;
            this.namebd.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namebd.Location = new System.Drawing.Point(0, 0);
            this.namebd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namebd.Name = "namebd";
            this.namebd.Size = new System.Drawing.Size(600, 161);
            this.namebd.TabIndex = 0;
            this.namebd.Text = "БАЗА ДАННЫХ \"СТОЛОВАЯ\"";
            this.namebd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namebd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseDown);
            this.namebd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseMove);
            // 
            // groupBoxJob
            // 
            this.groupBoxJob.Controls.Add(this.ComboBoxEmployee);
            this.groupBoxJob.Controls.Add(this.ComboBoxRoom);
            this.groupBoxJob.Controls.Add(this.label3);
            this.groupBoxJob.Controls.Add(this.textBoxRespond);
            this.groupBoxJob.Controls.Add(this.label2);
            this.groupBoxJob.Controls.Add(this.label1);
            this.groupBoxJob.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxJob.Location = new System.Drawing.Point(0, 168);
            this.groupBoxJob.Name = "groupBoxJob";
            this.groupBoxJob.Size = new System.Drawing.Size(302, 293);
            this.groupBoxJob.TabIndex = 19;
            this.groupBoxJob.TabStop = false;
            this.groupBoxJob.Text = "Параметры";
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(139, 32);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(144, 26);
            this.ComboBoxEmployee.TabIndex = 25;
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.Location = new System.Drawing.Point(148, 76);
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(135, 26);
            this.ComboBoxRoom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Обязанности";
            // 
            // textBoxRespond
            // 
            this.textBoxRespond.Location = new System.Drawing.Point(148, 119);
            this.textBoxRespond.Multiline = true;
            this.textBoxRespond.Name = "textBoxRespond";
            this.textBoxRespond.Size = new System.Drawing.Size(135, 111);
            this.textBoxRespond.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Помещение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сотрудник";
            // 
            // AddRespond
            // 
            this.AddRespond.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddRespond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRespond.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRespond.Location = new System.Drawing.Point(396, 258);
            this.AddRespond.Name = "AddRespond";
            this.AddRespond.Size = new System.Drawing.Size(136, 78);
            this.AddRespond.TabIndex = 28;
            this.AddRespond.Text = "Добавить обязанность";
            this.AddRespond.UseVisualStyleBackColor = false;
            this.AddRespond.Click += new System.EventHandler(this.AddRespond_Click);
            // 
            // WriteForm8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.AddRespond);
            this.Controls.Add(this.groupBoxJob);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteForm8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriteForm8";
            this.Load += new System.EventHandler(this.WriteForm8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.groupBoxJob.ResumeLayout(false);
            this.groupBoxJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label namebd;
        private System.Windows.Forms.GroupBox groupBoxJob;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.ComboBox ComboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRespond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddRespond;
    }
}
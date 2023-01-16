namespace WindowsFormsApp_DB
{
    partial class WriteForm7
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
            this.nameForm = new System.Windows.Forms.Label();
            this.namebd = new System.Windows.Forms.Label();
            this.groupBoxJob = new System.Windows.Forms.GroupBox();
            this.ComboBoxOrder = new System.Windows.Forms.ComboBox();
            this.ComboBoxDish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToOrder = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
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
            this.panel1.TabIndex = 13;
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.BackColor = System.Drawing.Color.Transparent;
            this.nameForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameForm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForm.Location = new System.Drawing.Point(80, 109);
            this.nameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(443, 38);
            this.nameForm.TabIndex = 6;
            this.nameForm.Text = "ДОБАВЛЕНИЕ БЛЮД К ЗАКАЗУ";
            this.nameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBoxJob.Controls.Add(this.ComboBoxOrder);
            this.groupBoxJob.Controls.Add(this.ComboBoxDish);
            this.groupBoxJob.Controls.Add(this.label3);
            this.groupBoxJob.Controls.Add(this.textBoxNumber);
            this.groupBoxJob.Controls.Add(this.label2);
            this.groupBoxJob.Controls.Add(this.label1);
            this.groupBoxJob.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxJob.Location = new System.Drawing.Point(0, 168);
            this.groupBoxJob.Name = "groupBoxJob";
            this.groupBoxJob.Size = new System.Drawing.Size(302, 293);
            this.groupBoxJob.TabIndex = 18;
            this.groupBoxJob.TabStop = false;
            this.groupBoxJob.Text = "Параметры";
            // 
            // ComboBoxOrder
            // 
            this.ComboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrder.FormattingEnabled = true;
            this.ComboBoxOrder.Location = new System.Drawing.Point(148, 32);
            this.ComboBoxOrder.Name = "ComboBoxOrder";
            this.ComboBoxOrder.Size = new System.Drawing.Size(135, 26);
            this.ComboBoxOrder.TabIndex = 25;
            // 
            // ComboBoxDish
            // 
            this.ComboBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDish.FormattingEnabled = true;
            this.ComboBoxDish.Location = new System.Drawing.Point(126, 76);
            this.ComboBoxDish.Name = "ComboBoxDish";
            this.ComboBoxDish.Size = new System.Drawing.Size(157, 26);
            this.ComboBoxDish.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Количество";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(148, 119);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(135, 26);
            this.textBoxNumber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Блюдо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер заказа";
            // 
            // AddToOrder
            // 
            this.AddToOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToOrder.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToOrder.Location = new System.Drawing.Point(396, 258);
            this.AddToOrder.Name = "AddToOrder";
            this.AddToOrder.Size = new System.Drawing.Size(136, 78);
            this.AddToOrder.TabIndex = 27;
            this.AddToOrder.Text = "Добавить к заказу";
            this.AddToOrder.UseVisualStyleBackColor = false;
            this.AddToOrder.Click += new System.EventHandler(this.AddToOrder_Click);
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
            // WriteForm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.AddToOrder);
            this.Controls.Add(this.groupBoxJob);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteForm7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriteForm7";
            this.Load += new System.EventHandler(this.WriteForm7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxJob.ResumeLayout(false);
            this.groupBoxJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label namebd;
        private System.Windows.Forms.GroupBox groupBoxJob;
        private System.Windows.Forms.ComboBox ComboBoxDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxOrder;
        private System.Windows.Forms.Button AddToOrder;
    }
}
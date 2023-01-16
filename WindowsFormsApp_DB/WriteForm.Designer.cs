namespace WindowsFormsApp_DB
{
    partial class WriteForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.query6 = new System.Windows.Forms.Button();
            this.query5 = new System.Windows.Forms.Button();
            this.query4 = new System.Windows.Forms.Button();
            this.query3 = new System.Windows.Forms.Button();
            this.query2 = new System.Windows.Forms.Button();
            this.query1 = new System.Windows.Forms.Button();
            this.query7 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.query8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(620, 161);
            this.panel1.TabIndex = 6;
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.BackColor = System.Drawing.Color.Transparent;
            this.nameForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameForm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForm.Location = new System.Drawing.Point(178, 109);
            this.nameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(246, 38);
            this.nameForm.TabIndex = 6;
            this.nameForm.Text = "ВИДЫ ЗАПИСЕЙ";
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
            this.namebd.Size = new System.Drawing.Size(620, 161);
            this.namebd.TabIndex = 0;
            this.namebd.Text = "БАЗА ДАННЫХ \"СТОЛОВАЯ\"";
            this.namebd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namebd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseDown);
            this.namebd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.query8);
            this.panel2.Controls.Add(this.query7);
            this.panel2.Controls.Add(this.query6);
            this.panel2.Controls.Add(this.query5);
            this.panel2.Controls.Add(this.query4);
            this.panel2.Controls.Add(this.query3);
            this.panel2.Controls.Add(this.query2);
            this.panel2.Controls.Add(this.query1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 359);
            this.panel2.TabIndex = 8;
            // 
            // query6
            // 
            this.query6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query6.Location = new System.Drawing.Point(170, 110);
            this.query6.Name = "query6";
            this.query6.Size = new System.Drawing.Size(136, 78);
            this.query6.TabIndex = 5;
            this.query6.Text = "Столовый инвентарь";
            this.query6.UseVisualStyleBackColor = false;
            this.query6.Click += new System.EventHandler(this.query6_Click);
            // 
            // query5
            // 
            this.query5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query5.Location = new System.Drawing.Point(28, 110);
            this.query5.Name = "query5";
            this.query5.Size = new System.Drawing.Size(136, 78);
            this.query5.TabIndex = 4;
            this.query5.Text = "Помещение";
            this.query5.UseVisualStyleBackColor = false;
            this.query5.Click += new System.EventHandler(this.query5_Click);
            // 
            // query4
            // 
            this.query4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query4.Location = new System.Drawing.Point(454, 26);
            this.query4.Name = "query4";
            this.query4.Size = new System.Drawing.Size(136, 78);
            this.query4.TabIndex = 3;
            this.query4.Text = "Заказ";
            this.query4.UseVisualStyleBackColor = false;
            this.query4.Click += new System.EventHandler(this.query4_Click);
            // 
            // query3
            // 
            this.query3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query3.Location = new System.Drawing.Point(312, 26);
            this.query3.Name = "query3";
            this.query3.Size = new System.Drawing.Size(136, 78);
            this.query3.TabIndex = 2;
            this.query3.Text = "Должность";
            this.query3.UseVisualStyleBackColor = false;
            this.query3.Click += new System.EventHandler(this.query3_Click);
            // 
            // query2
            // 
            this.query2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query2.Location = new System.Drawing.Point(170, 26);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(136, 78);
            this.query2.TabIndex = 1;
            this.query2.Text = "Блюдо";
            this.query2.UseVisualStyleBackColor = false;
            this.query2.Click += new System.EventHandler(this.query2_Click_1);
            // 
            // query1
            // 
            this.query1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query1.Location = new System.Drawing.Point(28, 26);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(136, 78);
            this.query1.TabIndex = 0;
            this.query1.Text = "Сотрудник";
            this.query1.UseVisualStyleBackColor = false;
            this.query1.Click += new System.EventHandler(this.query1_Click);
            // 
            // query7
            // 
            this.query7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query7.Location = new System.Drawing.Point(312, 110);
            this.query7.Name = "query7";
            this.query7.Size = new System.Drawing.Size(136, 78);
            this.query7.TabIndex = 6;
            this.query7.Text = "Состав заказа";
            this.query7.UseVisualStyleBackColor = false;
            this.query7.Click += new System.EventHandler(this.query7_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::WindowsFormsApp_DB.Properties.Resources.closeButton;
            this.closeButton.Location = new System.Drawing.Point(565, 0);
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
            // query8
            // 
            this.query8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query8.Location = new System.Drawing.Point(454, 110);
            this.query8.Name = "query8";
            this.query8.Size = new System.Drawing.Size(136, 78);
            this.query8.TabIndex = 7;
            this.query8.Text = "Рабочая смена";
            this.query8.UseVisualStyleBackColor = false;
            this.query8.Click += new System.EventHandler(this.query8_Click);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БАЗА ДАННЫХ \"СТОЛОВАЯ\"";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label namebd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button query1;
        private System.Windows.Forms.Button query4;
        private System.Windows.Forms.Button query3;
        private System.Windows.Forms.Button query2;
        private System.Windows.Forms.Button query5;
        private System.Windows.Forms.Button query6;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button query7;
        private System.Windows.Forms.Button query8;
    }
}
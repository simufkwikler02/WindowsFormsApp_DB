namespace WindowsFormsApp_DB
{
    partial class FormRead
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
            this.backButton = new System.Windows.Forms.PictureBox();
            this.namebd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.query2 = new System.Windows.Forms.Button();
            this.query1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(620, 181);
            this.panel1.TabIndex = 5;
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.BackColor = System.Drawing.Color.Transparent;
            this.nameForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameForm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForm.Location = new System.Drawing.Point(171, 114);
            this.nameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(264, 38);
            this.nameForm.TabIndex = 6;
            this.nameForm.Text = "ВИДЫ ЗАПРОСОВ";
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
            this.namebd.Size = new System.Drawing.Size(620, 175);
            this.namebd.TabIndex = 0;
            this.namebd.Text = "БАЗА ДАННЫХ \"СТОЛОВАЯ\"";
            this.namebd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namebd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseDown);
            this.namebd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.namebd_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.query2);
            this.panel2.Controls.Add(this.query1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 342);
            this.panel2.TabIndex = 7;
            // 
            // query2
            // 
            this.query2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query2.Location = new System.Drawing.Point(231, 7);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(159, 89);
            this.query2.TabIndex = 1;
            this.query2.Text = "Статистика инвенторя в помещениях";
            this.query2.UseVisualStyleBackColor = false;
            this.query2.Click += new System.EventHandler(this.query2_Click);
            // 
            // query1
            // 
            this.query1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.query1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query1.Location = new System.Drawing.Point(12, 7);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(159, 89);
            this.query1.TabIndex = 0;
            this.query1.Text = "Зарплаты Сотрудников";
            this.query1.UseVisualStyleBackColor = false;
            this.query1.Click += new System.EventHandler(this.query1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::WindowsFormsApp_DB.Properties.Resources.closeButton;
            this.closeButton.Location = new System.Drawing.Point(565, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 55);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FormRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БАЗА ДАННЫХ \"СТОЛОВАЯ\"";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label namebd;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button query1;
        private System.Windows.Forms.Button query2;
        private System.Windows.Forms.PictureBox closeButton;
    }
}
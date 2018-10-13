namespace WindowsFormsSample7
{
    partial class Form2
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
            this.btnEnterNum = new System.Windows.Forms.Button();
            this.lblCompare = new System.Windows.Forms.Label();
            this.txbEnterNum = new System.Windows.Forms.TextBox();
            this.lblAnyNum = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblCountTry = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterNum
            // 
            this.btnEnterNum.Location = new System.Drawing.Point(167, 88);
            this.btnEnterNum.Name = "btnEnterNum";
            this.btnEnterNum.Size = new System.Drawing.Size(75, 23);
            this.btnEnterNum.TabIndex = 0;
            this.btnEnterNum.Text = "ввод";
            this.btnEnterNum.UseVisualStyleBackColor = true;
            this.btnEnterNum.Click += new System.EventHandler(this.EnterNumbtn_Click);
            // 
            // Comparelbl
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(26, 44);
            this.lblCompare.Name = "Comparelbl";
            this.lblCompare.Size = new System.Drawing.Size(0, 13);
            this.lblCompare.TabIndex = 1;
            // 
            // txbEnterNum
            // 
            this.txbEnterNum.Location = new System.Drawing.Point(29, 90);
            this.txbEnterNum.Name = "txbEnterNum";
            this.txbEnterNum.Size = new System.Drawing.Size(100, 20);
            this.txbEnterNum.TabIndex = 3;
            // 
            // lblAnyNum
            // 
            this.lblAnyNum.AutoSize = true;
            this.lblAnyNum.Location = new System.Drawing.Point(26, 18);
            this.lblAnyNum.Name = "lblAnyNum";
            this.lblAnyNum.Size = new System.Drawing.Size(138, 13);
            this.lblAnyNum.TabIndex = 4;
            this.lblAnyNum.Text = "Угадай число от 1 до 100!";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(23, 146);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(55, 13);
            this.lblTry.TabIndex = 5;
            this.lblTry.Text = "Попытки:";
            // 
            // lblCountTry
            // 
            this.lblCountTry.AutoSize = true;
            this.lblCountTry.Location = new System.Drawing.Point(164, 146);
            this.lblCountTry.Name = "lblCountTry";
            this.lblCountTry.Size = new System.Drawing.Size(13, 13);
            this.lblCountTry.TabIndex = 6;
            this.lblCountTry.Text = "0";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 212);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Обновить";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 247);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblCountTry);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.lblAnyNum);
            this.Controls.Add(this.txbEnterNum);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.btnEnterNum);
            this.Name = "Form2";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterNum;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.TextBox txbEnterNum;
        private System.Windows.Forms.Label lblAnyNum;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblCountTry;
        private System.Windows.Forms.Button btnNew;
    }
}
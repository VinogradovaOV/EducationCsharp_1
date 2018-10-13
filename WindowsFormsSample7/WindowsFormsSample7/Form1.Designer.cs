namespace WindowsFormsSample7
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblGetNum = new System.Windows.Forms.Label();
            this.lblThisNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYourNum = new System.Windows.Forms.Label();
            this.btnCansel = new System.Windows.Forms.Button();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(231, 121);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(231, 164);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*2";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(231, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(134, 164);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(13, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "0";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(28, 293);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblGetNum
            // 
            this.lblGetNum.AutoSize = true;
            this.lblGetNum.Location = new System.Drawing.Point(25, 121);
            this.lblGetNum.Name = "lblGetNum";
            this.lblGetNum.Size = new System.Drawing.Size(86, 13);
            this.lblGetNum.TabIndex = 5;
            this.lblGetNum.Text = "Получите число";
            // 
            // lblThisNum
            // 
            this.lblThisNum.AutoSize = true;
            this.lblThisNum.Location = new System.Drawing.Point(134, 121);
            this.lblThisNum.Name = "lblThisNum";
            this.lblThisNum.Size = new System.Drawing.Size(13, 13);
            this.lblThisNum.TabIndex = 6;
            this.lblThisNum.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayToolStripMenuItem,
            this.CanselToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // PlayToolStripMenuItem
            // 
            this.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem";
            this.PlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PlayToolStripMenuItem.Text = "Играть";
            this.PlayToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // CanselToolStripMenuItem
            // 
            this.CanselToolStripMenuItem.Name = "CanselToolStripMenuItem";
            this.CanselToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CanselToolStripMenuItem.Text = "Отмена";
            this.CanselToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // lblYourNum
            // 
            this.lblYourNum.AutoSize = true;
            this.lblYourNum.Location = new System.Drawing.Point(25, 164);
            this.lblYourNum.Name = "lblYourNum";
            this.lblYourNum.Size = new System.Drawing.Size(66, 13);
            this.lblYourNum.TabIndex = 8;
            this.lblYourNum.Text = "Ваше число";
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(231, 205);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 10;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ResetToolStripMenuItem.Text = "Сброс";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 328);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.lblYourNum);
            this.Controls.Add(this.lblThisNum);
            this.Controls.Add(this.lblGetNum);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblGetNum;
        private System.Windows.Forms.Label lblThisNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanselToolStripMenuItem;
        private System.Windows.Forms.Label lblYourNum;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
    }
}


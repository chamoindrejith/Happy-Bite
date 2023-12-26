namespace Happy_Bite
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.lblHappyBite = new System.Windows.Forms.Label();
            this.lblHelloFoodie = new System.Windows.Forms.Label();
            this.lblTagLine = new System.Windows.Forms.Label();
            this.btnGetStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1080, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblHappyBite
            // 
            this.lblHappyBite.AutoSize = true;
            this.lblHappyBite.BackColor = System.Drawing.Color.Transparent;
            this.lblHappyBite.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappyBite.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblHappyBite.Location = new System.Drawing.Point(12, 9);
            this.lblHappyBite.Name = "lblHappyBite";
            this.lblHappyBite.Size = new System.Drawing.Size(128, 28);
            this.lblHappyBite.TabIndex = 2;
            this.lblHappyBite.Text = "Happy Bite";
            // 
            // lblHelloFoodie
            // 
            this.lblHelloFoodie.AutoSize = true;
            this.lblHelloFoodie.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloFoodie.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloFoodie.Location = new System.Drawing.Point(238, 204);
            this.lblHelloFoodie.Name = "lblHelloFoodie";
            this.lblHelloFoodie.Size = new System.Drawing.Size(213, 39);
            this.lblHelloFoodie.TabIndex = 3;
            this.lblHelloFoodie.Text = "Hello Foodie!";
            // 
            // lblTagLine
            // 
            this.lblTagLine.AutoSize = true;
            this.lblTagLine.BackColor = System.Drawing.Color.Transparent;
            this.lblTagLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagLine.Location = new System.Drawing.Point(205, 258);
            this.lblTagLine.Name = "lblTagLine";
            this.lblTagLine.Size = new System.Drawing.Size(276, 21);
            this.lblTagLine.TabIndex = 3;
            this.lblTagLine.Text = "Enjoy your favourite at your home!";
            // 
            // btnGetStart
            // 
            this.btnGetStart.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGetStart.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnGetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStart.ForeColor = System.Drawing.Color.Black;
            this.btnGetStart.Location = new System.Drawing.Point(257, 308);
            this.btnGetStart.Name = "btnGetStart";
            this.btnGetStart.Size = new System.Drawing.Size(165, 32);
            this.btnGetStart.TabIndex = 4;
            this.btnGetStart.Text = "Get Started Now";
            this.btnGetStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGetStart.UseVisualStyleBackColor = false;
            this.btnGetStart.Click += new System.EventHandler(this.btnGetStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(628, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGetStart);
            this.Controls.Add(this.lblTagLine);
            this.Controls.Add(this.lblHelloFoodie);
            this.Controls.Add(this.lblHappyBite);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHappyBite;
        private System.Windows.Forms.Label lblHelloFoodie;
        private System.Windows.Forms.Label lblTagLine;
        private System.Windows.Forms.Button btnGetStart;
        private System.Windows.Forms.Button btnClose;
    }
}
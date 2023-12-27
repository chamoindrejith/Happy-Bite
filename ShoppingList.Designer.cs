namespace Happy_Bite
{
    partial class ShoppingList
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecipie = new System.Windows.Forms.Button();
            this.btnShoppingList = new System.Windows.Forms.Button();
            this.btnMealPlan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblHappyBite = new System.Windows.Forms.Label();
            this.grpboxRecipies = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.grpboxRecipies.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(627, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 28);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRecipie
            // 
            this.btnRecipie.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRecipie.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnRecipie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnRecipie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipie.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipie.Location = new System.Drawing.Point(418, 431);
            this.btnRecipie.Name = "btnRecipie";
            this.btnRecipie.Size = new System.Drawing.Size(125, 31);
            this.btnRecipie.TabIndex = 31;
            this.btnRecipie.Text = "Recipies";
            this.btnRecipie.UseVisualStyleBackColor = false;
            this.btnRecipie.Click += new System.EventHandler(this.btnRecipie_Click);
            // 
            // btnShoppingList
            // 
            this.btnShoppingList.BackColor = System.Drawing.Color.OliveDrab;
            this.btnShoppingList.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnShoppingList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnShoppingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingList.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingList.Location = new System.Drawing.Point(557, 431);
            this.btnShoppingList.Name = "btnShoppingList";
            this.btnShoppingList.Size = new System.Drawing.Size(135, 31);
            this.btnShoppingList.TabIndex = 32;
            this.btnShoppingList.Text = "Shopping List";
            this.btnShoppingList.UseVisualStyleBackColor = false;
            this.btnShoppingList.Click += new System.EventHandler(this.btnShoppingList_Click);
            // 
            // btnMealPlan
            // 
            this.btnMealPlan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMealPlan.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnMealPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMealPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealPlan.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealPlan.Location = new System.Drawing.Point(165, 431);
            this.btnMealPlan.Name = "btnMealPlan";
            this.btnMealPlan.Size = new System.Drawing.Size(135, 31);
            this.btnMealPlan.TabIndex = 33;
            this.btnMealPlan.Text = "Meal Plans";
            this.btnMealPlan.UseVisualStyleBackColor = false;
            this.btnMealPlan.Click += new System.EventHandler(this.btnMealPlan_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.OliveDrab;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(314, 431);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 31);
            this.btnHome.TabIndex = 34;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHappyBite
            // 
            this.lblHappyBite.AutoSize = true;
            this.lblHappyBite.BackColor = System.Drawing.Color.Transparent;
            this.lblHappyBite.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappyBite.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblHappyBite.Location = new System.Drawing.Point(12, 10);
            this.lblHappyBite.Name = "lblHappyBite";
            this.lblHappyBite.Size = new System.Drawing.Size(166, 36);
            this.lblHappyBite.TabIndex = 29;
            this.lblHappyBite.Text = "Happy Bite";
            // 
            // grpboxRecipies
            // 
            this.grpboxRecipies.BackColor = System.Drawing.Color.LightGray;
            this.grpboxRecipies.Controls.Add(this.tableLayoutPanel1);
            this.grpboxRecipies.Controls.Add(this.label2);
            this.grpboxRecipies.Controls.Add(this.label1);
            this.grpboxRecipies.Controls.Add(this.btnGenerateList);
            this.grpboxRecipies.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxRecipies.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpboxRecipies.Location = new System.Drawing.Point(17, 61);
            this.grpboxRecipies.Name = "grpboxRecipies";
            this.grpboxRecipies.Size = new System.Drawing.Size(674, 339);
            this.grpboxRecipies.TabIndex = 36;
            this.grpboxRecipies.TabStop = false;
            this.grpboxRecipies.Text = "Cart Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.05699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.943F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(148, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 187);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Item";
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGenerateList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateList.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateList.Location = new System.Drawing.Point(285, 286);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(128, 32);
            this.btnGenerateList.TabIndex = 21;
            this.btnGenerateList.Text = "Generate List";
            this.btnGenerateList.UseVisualStyleBackColor = false;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFavorite.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnFavorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.Location = new System.Drawing.Point(17, 431);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(133, 31);
            this.btnFavorite.TabIndex = 30;
            this.btnFavorite.Text = "Favourites";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRecipie);
            this.Controls.Add(this.btnShoppingList);
            this.Controls.Add(this.btnMealPlan);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.lblHappyBite);
            this.Controls.Add(this.grpboxRecipies);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShoppingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingList";
            this.grpboxRecipies.ResumeLayout(false);
            this.grpboxRecipies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecipie;
        private System.Windows.Forms.Button btnShoppingList;
        private System.Windows.Forms.Button btnMealPlan;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Label lblHappyBite;
        private System.Windows.Forms.GroupBox grpboxRecipies;
        private System.Windows.Forms.Button btnGenerateList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
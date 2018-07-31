namespace GroceryStore1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ShoppingPanel = new System.Windows.Forms.Panel();
            this.textBoxBananaInput = new System.Windows.Forms.TextBox();
            this.textBoxAppleInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckoutPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBananaCount = new System.Windows.Forms.TextBox();
            this.AppleCount = new System.Windows.Forms.Label();
            this.textBoxAppleCount = new System.Windows.Forms.TextBox();
            this.quit = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShoppingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CheckoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Beate\'s Grocery store!";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today we are offering Apples and Banana. Apples are 30¢ each and Bananas are 50¢ " +
    "each or 5 for the price of 4.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apples";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(545, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bananas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShoppingPanel
            // 
            this.ShoppingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShoppingPanel.Controls.Add(this.textBoxBananaInput);
            this.ShoppingPanel.Controls.Add(this.textBoxAppleInput);
            this.ShoppingPanel.Controls.Add(this.pictureBox1);
            this.ShoppingPanel.Controls.Add(this.button3);
            this.ShoppingPanel.Controls.Add(this.label3);
            this.ShoppingPanel.Controls.Add(this.label2);
            this.ShoppingPanel.Controls.Add(this.button2);
            this.ShoppingPanel.Controls.Add(this.label1);
            this.ShoppingPanel.Controls.Add(this.button1);
            this.ShoppingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShoppingPanel.Location = new System.Drawing.Point(0, 0);
            this.ShoppingPanel.Name = "ShoppingPanel";
            this.ShoppingPanel.Size = new System.Drawing.Size(873, 470);
            this.ShoppingPanel.TabIndex = 4;
            // 
            // textBoxBananaInput
            // 
            this.textBoxBananaInput.Enabled = false;
            this.textBoxBananaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBananaInput.Location = new System.Drawing.Point(473, 272);
            this.textBoxBananaInput.Name = "textBoxBananaInput";
            this.textBoxBananaInput.Size = new System.Drawing.Size(49, 26);
            this.textBoxBananaInput.TabIndex = 8;
            // 
            // textBoxAppleInput
            // 
            this.textBoxAppleInput.Enabled = false;
            this.textBoxAppleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppleInput.Location = new System.Drawing.Point(149, 272);
            this.textBoxAppleInput.Name = "textBoxAppleInput";
            this.textBoxAppleInput.Size = new System.Drawing.Size(54, 26);
            this.textBoxAppleInput.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GroceryStore1.Properties.Resources.Red_and_white_striped_awning_on_a_black_background;
            this.pictureBox1.Location = new System.Drawing.Point(57, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(687, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "checkout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(766, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Click the Apples or Bananas buttons to add produce to your cart. Then click on ch" +
    "eckout to see your total cost.";
            // 
            // CheckoutPanel
            // 
            this.CheckoutPanel.Controls.Add(this.label6);
            this.CheckoutPanel.Controls.Add(this.textBoxBananaCount);
            this.CheckoutPanel.Controls.Add(this.AppleCount);
            this.CheckoutPanel.Controls.Add(this.textBoxAppleCount);
            this.CheckoutPanel.Controls.Add(this.quit);
            this.CheckoutPanel.Controls.Add(this.textBoxTotalPrice);
            this.CheckoutPanel.Controls.Add(this.label5);
            this.CheckoutPanel.Controls.Add(this.label4);
            this.CheckoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckoutPanel.Name = "CheckoutPanel";
            this.CheckoutPanel.Size = new System.Drawing.Size(873, 470);
            this.CheckoutPanel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bananas";
            // 
            // textBoxBananaCount
            // 
            this.textBoxBananaCount.Enabled = false;
            this.textBoxBananaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBananaCount.Location = new System.Drawing.Point(77, 263);
            this.textBoxBananaCount.Name = "textBoxBananaCount";
            this.textBoxBananaCount.Size = new System.Drawing.Size(77, 26);
            this.textBoxBananaCount.TabIndex = 6;
            // 
            // AppleCount
            // 
            this.AppleCount.AutoSize = true;
            this.AppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppleCount.Location = new System.Drawing.Point(194, 209);
            this.AppleCount.Name = "AppleCount";
            this.AppleCount.Size = new System.Drawing.Size(58, 20);
            this.AppleCount.TabIndex = 5;
            this.AppleCount.Text = "Apples";
            // 
            // textBoxAppleCount
            // 
            this.textBoxAppleCount.Enabled = false;
            this.textBoxAppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppleCount.Location = new System.Drawing.Point(77, 206);
            this.textBoxAppleCount.Name = "textBoxAppleCount";
            this.textBoxAppleCount.Size = new System.Drawing.Size(77, 26);
            this.textBoxAppleCount.TabIndex = 4;
            // 
            // quit
            // 
            this.quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(660, 365);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(120, 41);
            this.quit.TabIndex = 3;
            this.quit.Text = "Pay";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(231, 128);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(110, 26);
            this.textBoxTotalPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "your total is: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Checkout";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 470);
            this.Controls.Add(this.ShoppingPanel);
            this.Controls.Add(this.CheckoutPanel);
            this.Name = "Form1";
            this.Text = "Beate\'s grocery store";
            this.ShoppingPanel.ResumeLayout(false);
            this.ShoppingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CheckoutPanel.ResumeLayout(false);
            this.CheckoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ShoppingPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CheckoutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBananaCount;
        private System.Windows.Forms.Label AppleCount;
        private System.Windows.Forms.TextBox textBoxAppleCount;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBananaInput;
        private System.Windows.Forms.TextBox textBoxAppleInput;
    }
}


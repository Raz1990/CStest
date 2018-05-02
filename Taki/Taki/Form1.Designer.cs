namespace Taki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // picDeck
            // 
            this.picDeck.Image = ((System.Drawing.Image)(resources.GetObject("picDeck.Image")));
            this.picDeck.Location = new System.Drawing.Point(524, 85);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(100, 171);
            this.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeck.TabIndex = 0;
            this.picDeck.TabStop = false;
            this.picDeck.Click += new System.EventHandler(this.picDeck_Click);
            // 
            // picCard1
            // 
            this.picCard1.Location = new System.Drawing.Point(42, 445);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(100, 171);
            this.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard1.TabIndex = 1;
            this.picCard1.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.Location = new System.Drawing.Point(173, 445);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(100, 171);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard2.TabIndex = 2;
            this.picCard2.TabStop = false;
            // 
            // picCard3
            // 
            this.picCard3.Location = new System.Drawing.Point(309, 445);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(100, 171);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard3.TabIndex = 3;
            this.picCard3.TabStop = false;
            // 
            // picCard4
            // 
            this.picCard4.Location = new System.Drawing.Point(438, 445);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(100, 171);
            this.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard4.TabIndex = 4;
            this.picCard4.TabStop = false;
            // 
            // picCard5
            // 
            this.picCard5.Location = new System.Drawing.Point(568, 445);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(100, 171);
            this.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard5.TabIndex = 9;
            this.picCard5.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(631, 161);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(29, 20);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "X5";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDealer.Location = new System.Drawing.Point(14, 219);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(128, 37);
            this.lblDealer.TabIndex = 13;
            this.lblDealer.Text = "Dealer: ";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(524, 306);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 77);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "סיים";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotal.Location = new System.Drawing.Point(46, 346);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 37);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 644);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard1);
            this.Controls.Add(this.picDeck);
            this.Name = "Form1";
            this.Text = "Black Jack";
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDeck;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.PictureBox picCard5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblTotal;
    }
}


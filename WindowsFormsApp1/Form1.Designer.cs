
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.zLabel = new System.Windows.Forms.Label();
            this.zTextBox = new System.Windows.Forms.TextBox();
            this.rLabel = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1275, 726);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(13, 13);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(16, 15);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "N";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(13, 32);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 23);
            this.nTextBox.TabIndex = 2;
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(13, 61);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(20, 15);
            this.zLabel.TabIndex = 1;
            this.zLabel.Text = "Z0";
            // 
            // zTextBox
            // 
            this.zTextBox.Location = new System.Drawing.Point(13, 80);
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(100, 23);
            this.zTextBox.TabIndex = 2;
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(13, 112);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(14, 15);
            this.rLabel.TabIndex = 1;
            this.rLabel.Text = "R";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(13, 131);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(100, 23);
            this.rTextBox.TabIndex = 2;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(13, 160);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 15);
            this.aLabel.TabIndex = 1;
            this.aLabel.Text = "a";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(13, 179);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 23);
            this.aTextBox.TabIndex = 2;
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.Red;
            this.drawButton.Location = new System.Drawing.Point(43, 762);
            this.drawButton.Margin = new System.Windows.Forms.Padding(10);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(210, 97);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(303, 777);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(207, 67);
            this.save.TabIndex = 4;
            this.save.Text = "saveToPNG";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(559, 779);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(179, 62);
            this.zoom.TabIndex = 5;
            this.zoom.Text = "zoom";
            this.zoom.UseVisualStyleBackColor = true;
            this.zoom.Click += new System.EventHandler(this.zoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 962);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.save);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.zTextBox);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.TextBox zTextBox;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button zoom;
    }
}


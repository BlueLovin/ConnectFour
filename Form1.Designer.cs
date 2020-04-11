namespace ConnectFour
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
            this.C7Highlight = new System.Windows.Forms.Panel();
            this.C6Highlight = new System.Windows.Forms.Panel();
            this.C4Highlight = new System.Windows.Forms.Panel();
            this.C5Highlight = new System.Windows.Forms.Panel();
            this.C2Highlight = new System.Windows.Forms.Panel();
            this.C3Highlight = new System.Windows.Forms.Panel();
            this.C1Highlight = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.MoveCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // C7Highlight
            // 
            this.C7Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C7Highlight.Location = new System.Drawing.Point(421, 0);
            this.C7Highlight.Name = "C7Highlight";
            this.C7Highlight.Size = new System.Drawing.Size(70, 418);
            this.C7Highlight.TabIndex = 0;
            this.C7Highlight.Click += new System.EventHandler(this.C7Highlight_Click);
            // 
            // C6Highlight
            // 
            this.C6Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C6Highlight.Location = new System.Drawing.Point(351, 0);
            this.C6Highlight.Name = "C6Highlight";
            this.C6Highlight.Size = new System.Drawing.Size(70, 418);
            this.C6Highlight.TabIndex = 0;
            this.C6Highlight.Click += new System.EventHandler(this.C6Highlight_Click);
            // 
            // C4Highlight
            // 
            this.C4Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C4Highlight.Location = new System.Drawing.Point(213, 0);
            this.C4Highlight.Name = "C4Highlight";
            this.C4Highlight.Size = new System.Drawing.Size(70, 418);
            this.C4Highlight.TabIndex = 0;
            this.C4Highlight.Click += new System.EventHandler(this.C4Highlight_Click);
            // 
            // C5Highlight
            // 
            this.C5Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C5Highlight.Location = new System.Drawing.Point(283, 0);
            this.C5Highlight.Name = "C5Highlight";
            this.C5Highlight.Size = new System.Drawing.Size(70, 418);
            this.C5Highlight.TabIndex = 0;
            this.C5Highlight.Click += new System.EventHandler(this.C5Highlight_Click);
            // 
            // C2Highlight
            // 
            this.C2Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C2Highlight.Location = new System.Drawing.Point(71, 0);
            this.C2Highlight.Name = "C2Highlight";
            this.C2Highlight.Size = new System.Drawing.Size(70, 418);
            this.C2Highlight.TabIndex = 0;
            this.C2Highlight.Click += new System.EventHandler(this.C2Highlight_Click);
            // 
            // C3Highlight
            // 
            this.C3Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C3Highlight.Location = new System.Drawing.Point(141, 0);
            this.C3Highlight.Name = "C3Highlight";
            this.C3Highlight.Size = new System.Drawing.Size(70, 418);
            this.C3Highlight.TabIndex = 0;
            this.C3Highlight.Click += new System.EventHandler(this.C3Highlight_Click);
            // 
            // C1Highlight
            // 
            this.C1Highlight.BackColor = System.Drawing.Color.Transparent;
            this.C1Highlight.Location = new System.Drawing.Point(1, 0);
            this.C1Highlight.Name = "C1Highlight";
            this.C1Highlight.Size = new System.Drawing.Size(70, 418);
            this.C1Highlight.TabIndex = 0;
            this.C1Highlight.Click += new System.EventHandler(this.C1Highlight_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLabel.Location = new System.Drawing.Point(588, 320);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(88, 25);
            this.MoveLabel.TabIndex = 2;
            this.MoveLabel.Text = "Moves:";
            // 
            // MoveCount
            // 
            this.MoveCount.AutoSize = true;
            this.MoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveCount.Location = new System.Drawing.Point(669, 322);
            this.MoveCount.Name = "MoveCount";
            this.MoveCount.Size = new System.Drawing.Size(20, 24);
            this.MoveCount.TabIndex = 3;
            this.MoveCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONNECT 4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "by Matthew \"BlueLovin\" Jury";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(688, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "More Info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::ConnectFour.Properties.Resources.connect4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(802, 424);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoveCount);
            this.Controls.Add(this.MoveLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.C3Highlight);
            this.Controls.Add(this.C5Highlight);
            this.Controls.Add(this.C7Highlight);
            this.Controls.Add(this.C1Highlight);
            this.Controls.Add(this.C2Highlight);
            this.Controls.Add(this.C4Highlight);
            this.Controls.Add(this.C6Highlight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Connect Four -- Made by Matthew Jury";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel C7Highlight;
        private System.Windows.Forms.Panel C6Highlight;
        private System.Windows.Forms.Panel C4Highlight;
        private System.Windows.Forms.Panel C5Highlight;
        private System.Windows.Forms.Panel C2Highlight;
        private System.Windows.Forms.Panel C3Highlight;
        private System.Windows.Forms.Panel C1Highlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Label MoveCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


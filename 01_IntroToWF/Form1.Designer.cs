namespace _01_IntroToWF
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
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCSharp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Lime;
            this.btnClick.Font = new System.Drawing.Font("SimSun-ExtB", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClick.Location = new System.Drawing.Point(247, 295);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(600, 200);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click me";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseEnter += new System.EventHandler(this.btnClick_MouseEnter);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(771, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello Windows Form";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.Font = new System.Drawing.Font("SimSun-ExtB", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1252, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(600, 200);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCSharp
            // 
            this.btnCSharp.Location = new System.Drawing.Point(1035, 653);
            this.btnCSharp.Name = "btnCSharp";
            this.btnCSharp.Size = new System.Drawing.Size(200, 200);
            this.btnCSharp.TabIndex = 3;
            this.btnCSharp.Text = "C#";
            this.btnCSharp.UseVisualStyleBackColor = true;
            this.btnCSharp.Click += new System.EventHandler(this.btnCSharp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1890, 703);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(188, 58);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Move Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(247, 703);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(188, 58);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Move Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2289, 1132);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCSharp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClick;
        private Label label1;
        private Button btnClose;
        private Button btnCSharp;
        private Button btnRight;
        private Button btnLeft;
    }
}
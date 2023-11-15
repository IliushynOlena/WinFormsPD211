namespace _08_AdditionalsForm
{
    partial class SecondForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.userLb = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(607, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 136);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLb.Location = new System.Drawing.Point(545, 333);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(329, 89);
            this.userLb.TabIndex = 2;
            this.userLb.Text = "Helo, ........";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(373, 577);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(342, 136);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "Show User";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 784);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label userLb;
        private Button showBtn;
    }
}
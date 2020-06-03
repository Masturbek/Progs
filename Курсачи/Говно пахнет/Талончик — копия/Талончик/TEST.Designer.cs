namespace Талончик
{
    partial class TEST
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tx2 = new Талончик.NewTextBox();
            this.tx1 = new Талончик.NewTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "F";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tx2
            // 
            this.tx2.AutoSize = true;
            this.tx2.BackColor = System.Drawing.Color.Transparent;
            this.tx2.IsPassword = true;
            this.tx2.Location = new System.Drawing.Point(12, 62);
            this.tx2.MaxLength = 11;
            this.tx2.Name = "tx2";
            this.tx2.PasswordVisible = false;
            this.tx2.Size = new System.Drawing.Size(204, 21);
            this.tx2.StandartText = "Введите пароль";
            this.tx2.TabIndex = 3;
            // 
            // tx1
            // 
            this.tx1.AutoSize = true;
            this.tx1.BackColor = System.Drawing.Color.Transparent;
            this.tx1.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tx1.IsPassword = false;
            this.tx1.Location = new System.Drawing.Point(12, 6);
            this.tx1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tx1.MaxLength = 11;
            this.tx1.Name = "tx1";
            this.tx1.PasswordVisible = false;
            this.tx1.Size = new System.Drawing.Size(476, 44);
            this.tx1.StandartText = "Введите СНИЛС или телефон";
            this.tx1.TabIndex = 2;
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.button1);
            this.Name = "TEST";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private NewTextBox tx1;
        private NewTextBox tx2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
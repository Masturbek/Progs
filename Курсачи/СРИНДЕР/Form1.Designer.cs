namespace СРИНДЕР
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button bt1;
        public System.Windows.Forms.Button bt2;
        public System.Windows.Forms.Button regbutton;
        public System.Windows.Forms.Button backbutton;
        public System.Windows.Forms.Button buttonauth;
        public System.Windows.Forms.Button passbutton;
        public System.Windows.Forms.Button regbt1;
        public System.Windows.Forms.Button regbt2;
        public System.Windows.Forms.Button regbt3;
        public System.Windows.Forms.Button regbt4;
        public System.Windows.Forms.Button regbt5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelreg1;
        public System.Windows.Forms.Label labelreg2;
        public System.Windows.Forms.Label labelreg3;
        public System.Windows.Forms.Label labelauth1;
        public System.Windows.Forms.Label labelauth2;
        public System.Windows.Forms.Label labellogerr;
        public System.Windows.Forms.Label labelreg4;
        public System.Windows.Forms.Label labelreg5;
        public System.Windows.Forms.Label labelreg6;
        public System.Windows.Forms.TextBox textbox1;
        public System.Windows.Forms.TextBox textbox2;
        public System.Windows.Forms.TextBox textbox3;
        public System.Windows.Forms.TextBox textbox13;
        private System.Windows.Forms.TextBox textboxauth1;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.TextBox textboxauth2;
        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.ToolTip tooltip2;
        private System.Windows.Forms.ToolTip tooltip3;
        private System.Windows.Forms.ToolTip tooltip4;
        private System.Windows.Forms.ToolTip tooltip5;
        private System.Windows.Forms.ToolTip tooltip6;
        private System.Windows.Forms.ToolTip tooltip7;
        private System.Windows.Forms.ToolTip tooltip8;
        private System.Windows.Forms.PictureBox errpict;
        private System.Windows.Forms.PictureBox okpict;
        private System.Windows.Forms.PictureBox emptypict;
        private System.Windows.Forms.PictureBox littlepict;
        private System.Windows.Forms.PictureBox errpasspict;
        private System.Windows.Forms.PictureBox okpasspict;
        private System.Windows.Forms.PictureBox okemailpict;
        private System.Windows.Forms.PictureBox erremailpict;
        private System.Windows.Forms.PictureBox emptypasspict;
        private System.Windows.Forms.PictureBox incorrectemailpict;
        private System.Windows.Forms.PictureBox oknamepict;
        private System.Windows.Forms.PictureBox emptynamepict;
        private System.Windows.Forms.PictureBox incorrectnamepict;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.RadioButton gendermale;
        private System.Windows.Forms.RadioButton genderfemale;
        private System.Windows.Forms.CheckBox remember;
    }
}


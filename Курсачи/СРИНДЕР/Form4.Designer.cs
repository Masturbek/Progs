namespace СРИНДЕР
{
    partial class Form4
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
            this.SuspendLayout();
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование профиля";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nameedit;
        private System.Windows.Forms.Button ageedit;
        private System.Windows.Forms.Button profileimagedit;
        private System.Windows.Forms.Button infoedit;
        private System.Windows.Forms.Button passwordedit;
        private System.Windows.Forms.Label labeledit;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.PictureBox nullnameedit;
        private System.Windows.Forms.PictureBox incorrectnameedit;
        private System.Windows.Forms.PictureBox okpict;
        private System.Windows.Forms.PictureBox emptypasspict;
        private System.Windows.Forms.PictureBox errpasspict;
        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.ToolTip tooltip2;
        private System.Windows.Forms.Button filepick;     
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.OpenFileDialog filepickdialog;
        private System.Windows.Forms.TextBox textboxedit;
        private System.Windows.Forms.Button passbutton;

    }
}
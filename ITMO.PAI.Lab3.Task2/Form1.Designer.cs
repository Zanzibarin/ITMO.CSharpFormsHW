
namespace ITMO.PAI.Lab3.Task2
{
    partial class WinTimer2
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
            this.userControlTimer21 = new ITMO.PAI.Lab3.Task2.UserControlTimer2();
            this.SuspendLayout();
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(360, 220);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(75, 27);
            this.userControlTimer21.TabIndex = 0;
            this.userControlTimer21.Text = "userControlTimer21";
            // 
            // WinTimer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlTimer21);
            this.Name = "WinTimer2";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer2 userControlTimer21;
    }
}


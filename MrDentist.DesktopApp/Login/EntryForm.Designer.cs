namespace MrDentist.DesktopApp.Login
{
    partial class EntryForm
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
            this._loginControl = new MrDentist.DesktopApp.Login.LoginControl();
            this.SuspendLayout();
            // 
            // _loginControl
            // 
            this._loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loginControl.Location = new System.Drawing.Point(0, 0);
            this._loginControl.Name = "_loginControl";
            this._loginControl.Size = new System.Drawing.Size(435, 248);
            this._loginControl.TabIndex = 0;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 248);
            this.Controls.Add(this._loginControl);
            this.MaximizeBox = false;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private MrDentist.DesktopApp.Login.LoginControl _loginControl;
    }
}


namespace MrDentist.DesktopApp.Login
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._layout = new System.Windows.Forms.TableLayoutPanel();
            this._textEmail = new System.Windows.Forms.TextBox();
            this._textPassword = new System.Windows.Forms.TextBox();
            this._buttonEntry = new System.Windows.Forms.Button();
            this._labelEmail = new System.Windows.Forms.Label();
            this._labelPassword = new System.Windows.Forms.Label();
            this._textError = new System.Windows.Forms.TextBox();
            this._layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _layout
            // 
            this._layout.BackColor = System.Drawing.Color.White;
            this._layout.ColumnCount = 3;
            this._layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._layout.Controls.Add(this._textEmail, 1, 1);
            this._layout.Controls.Add(this._textPassword, 1, 2);
            this._layout.Controls.Add(this._buttonEntry, 1, 3);
            this._layout.Controls.Add(this._labelEmail, 0, 1);
            this._layout.Controls.Add(this._labelPassword, 0, 2);
            this._layout.Controls.Add(this._textError, 0, 5);
            this._layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layout.Location = new System.Drawing.Point(0, 0);
            this._layout.Margin = new System.Windows.Forms.Padding(5);
            this._layout.Name = "_layout";
            this._layout.Padding = new System.Windows.Forms.Padding(5);
            this._layout.RowCount = 7;
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._layout.Size = new System.Drawing.Size(269, 256);
            this._layout.TabIndex = 0;
            // 
            // _textEmail
            // 
            this._textEmail.Location = new System.Drawing.Point(57, 65);
            this._textEmail.Name = "_textEmail";
            this._textEmail.Size = new System.Drawing.Size(154, 20);
            this._textEmail.TabIndex = 0;
            // 
            // _textPassword
            // 
            this._textPassword.Location = new System.Drawing.Point(57, 91);
            this._textPassword.Name = "_textPassword";
            this._textPassword.Size = new System.Drawing.Size(154, 20);
            this._textPassword.TabIndex = 1;
            // 
            // _buttonEntry
            // 
            this._buttonEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonEntry.Location = new System.Drawing.Point(57, 116);
            this._buttonEntry.Name = "_buttonEntry";
            this._buttonEntry.Size = new System.Drawing.Size(154, 24);
            this._buttonEntry.TabIndex = 2;
            this._buttonEntry.Text = "Entrar";
            this._buttonEntry.UseVisualStyleBackColor = true;
            // 
            // _labelEmail
            // 
            this._labelEmail.AutoSize = true;
            this._labelEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this._labelEmail.Location = new System.Drawing.Point(16, 62);
            this._labelEmail.Name = "_labelEmail";
            this._labelEmail.Size = new System.Drawing.Size(35, 26);
            this._labelEmail.TabIndex = 3;
            this._labelEmail.Text = "Email:";
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this._labelPassword.Location = new System.Drawing.Point(10, 88);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(41, 25);
            this._labelPassword.TabIndex = 4;
            this._labelPassword.Text = "Senha:";
            // 
            // _textError
            // 
            this._textError.BackColor = System.Drawing.Color.White;
            this._textError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._layout.SetColumnSpan(this._textError, 3);
            this._textError.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textError.ForeColor = System.Drawing.Color.Red;
            this._textError.Location = new System.Drawing.Point(8, 166);
            this._textError.Multiline = true;
            this._textError.Name = "_textError";
            this._textError.Size = new System.Drawing.Size(253, 24);
            this._textError.TabIndex = 5;
            this._textError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._layout);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(269, 256);
            this._layout.ResumeLayout(false);
            this._layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _layout;
        private System.Windows.Forms.TextBox _textEmail;
        private System.Windows.Forms.TextBox _textPassword;
        private System.Windows.Forms.Button _buttonEntry;
        private System.Windows.Forms.Label _labelEmail;
        private System.Windows.Forms.Label _labelPassword;
        private System.Windows.Forms.TextBox _textError;
    }
}

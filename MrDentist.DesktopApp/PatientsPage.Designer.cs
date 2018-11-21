namespace MrDentist.DesktopApp
{
    partial class PatientsPage
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
            this.listviewPatients = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _listviewPatients
            // 
            this.listviewPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewPatients.Location = new System.Drawing.Point(0, 0);
            this.listviewPatients.Name = "_listviewPatients";
            this.listviewPatients.Size = new System.Drawing.Size(387, 338);
            this.listviewPatients.TabIndex = 2;
            this.listviewPatients.UseCompatibleStateImageBehavior = false;
            this.listviewPatients.View = System.Windows.Forms.View.Details;
            // 
            // PatientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listviewPatients);
            this.Name = "PatientsPage";
            this.Size = new System.Drawing.Size(387, 338);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewPatients;
    }
}

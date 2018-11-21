namespace MrDentist.DesktopApp
{
    partial class OdontogramEntryPage
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
            this.canvas = new OdontogramEntryCanvas();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.canvas.Location = new System.Drawing.Point(27, 19);
            this.canvas.MaximumSize = new System.Drawing.Size(640, 480);
            this.canvas.MinimumSize = new System.Drawing.Size(640, 480);
            this.canvas.Name = "picbox";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // layout
            // 
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.canvas, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(694, 518);
            this.layout.TabIndex = 1;
            // 
            // OdontogramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "OdontogramPage";
            this.Size = new System.Drawing.Size(694, 518);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OdontogramEntryCanvas canvas;
        private System.Windows.Forms.TableLayoutPanel layout;
    }
}

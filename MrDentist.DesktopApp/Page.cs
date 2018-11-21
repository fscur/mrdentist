using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public class Page : UserControl
    {
        public string TitleText { get; protected set; }
        public List<ToolStrip> ToolStrips { get; protected set; }
        public event EventHandler<NewPageRequestedEventArgs> NewPageRequested;

        public Page()
        {
            InitializeComponent();
            ToolStrips = new List<ToolStrip>();
            this.BackColor = Color.White;
        }

        protected void RaiseNewPageRequested(Page page)
        {
            if (NewPageRequested != null)
            {
                var args = new NewPageRequestedEventArgs(page);
                NewPageRequested.Invoke(this, args);
            }
        }

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BasePage";
            this.ResumeLayout(false);
        }
    }
}

namespace MrDentist.DesktopApp
{
    partial class PageBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageBrowser));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientsRegisterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.previousPageButton = new System.Windows.Forms.ToolStripButton();
            this.nextPageButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolstripContainer.TopToolStripPanel.SuspendLayout();
            this.toolstripContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.registryMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(60, 20);
            this.homeMenuItem.Text = "Agenda";
            // 
            // registryMenuItem
            // 
            this.registryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientsRegisterMenuItem});
            this.registryMenuItem.Name = "registryMenuItem";
            this.registryMenuItem.Size = new System.Drawing.Size(66, 20);
            this.registryMenuItem.Text = "Cadastro";
            // 
            // pacientsRegisterMenuItem
            // 
            this.pacientsRegisterMenuItem.Name = "pacientsRegisterMenuItem";
            this.pacientsRegisterMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pacientsRegisterMenuItem.Text = "Pacientes";
            // 
            // toolstripContainer
            // 
            this.toolstripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolstripContainer.ContentPanel
            // 
            this.toolstripContainer.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolstripContainer.ContentPanel.Size = new System.Drawing.Size(1109, 722);
            this.toolstripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripContainer.LeftToolStripPanelVisible = false;
            this.toolstripContainer.Location = new System.Drawing.Point(0, 24);
            this.toolstripContainer.Name = "toolstripContainer";
            this.toolstripContainer.RightToolStripPanelVisible = false;
            this.toolstripContainer.Size = new System.Drawing.Size(1109, 747);
            this.toolstripContainer.TabIndex = 1;
            this.toolstripContainer.Text = "toolStripContainer1";
            // 
            // toolstripContainer.TopToolStripPanel
            // 
            this.toolstripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousPageButton,
            this.nextPageButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(58, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // previousPageButton
            // 
            this.previousPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousPageButton.Image = ((System.Drawing.Image)(resources.GetObject("previousPageButton.Image")));
            this.previousPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(23, 22);
            this.previousPageButton.Text = "Voltar";
            // 
            // nextPageButton
            // 
            this.nextPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextPageButton.Image = ((System.Drawing.Image)(resources.GetObject("nextPageButton.Image")));
            this.nextPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(23, 22);
            this.nextPageButton.Text = "Avançar";
            // 
            // PageBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 771);
            this.Controls.Add(this.toolstripContainer);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PageBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolstripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolstripContainer.TopToolStripPanel.PerformLayout();
            this.toolstripContainer.ResumeLayout(false);
            this.toolstripContainer.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripContainer toolstripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton previousPageButton;
        private System.Windows.Forms.ToolStripButton nextPageButton;
        private System.Windows.Forms.ToolStripMenuItem registryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientsRegisterMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public partial class PageBrowser : Form
    {
        private Page currentPage;
        private Stack<Page> previousPages;
        private Stack<Page> nextPages;
        public PageBrowser(Page startPage)
        {
            InitializeComponent();

            previousPageButton.Click += (s, e) =>
            {
                GoBack();
            };

            nextPageButton.Click += (s, e) =>
            {
                GoForward();
            };

            previousPages = new Stack<Page>();
            nextPages = new Stack<Page>();

            OpenPage(startPage);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateUI();
        }

        private void UpdateUI()
        {
            var hasPreviousPages = previousPages.Count > 0;
            var hasNextPages = nextPages.Count > 0;
            previousPageButton.Enabled = hasPreviousPages;
            nextPageButton.Enabled = nextPages.Count > 0;

            if (hasPreviousPages)
                previousPageButton.ToolTipText = previousPages.Peek().TitleText;

            if (hasNextPages)
                nextPageButton.ToolTipText = nextPages.Peek().TitleText;
        }

        private void RemoveCurrentPage()
        {
            if (currentPage != null)
            {
                foreach (var toolStrip in currentPage.ToolStrips)
                    toolstripContainer.TopToolStripPanel.Controls.Remove(toolStrip);

                toolstripContainer.ContentPanel.Controls.Remove(currentPage);
            }
        }

        public void GoBack()
        {
            if (previousPages.Count == 0)
                return;

            RemoveCurrentPage();

            nextPages.Push(currentPage);
            currentPage = null;
            var page = previousPages.Pop();
            OpenPage(page);

            UpdateUI();
        }

        private void GoForward()
        {
            if (nextPages.Count == 0)
                return;

            RemoveCurrentPage();

            previousPages.Push(currentPage);
            currentPage = null;

            var page = nextPages.Pop();
            OpenPage(page);
            UpdateUI();
        }

        public void OpenPage(Page page)
        {
            if (currentPage != null)
                previousPages.Push(currentPage);

            RemoveCurrentPage();

            var mainToolstrip = toolstripContainer.TopToolStripPanel.Controls[0];
            var x = mainToolstrip.Location.X + mainToolstrip.Width;

            foreach (var toolStrip in page.ToolStrips)
                toolstripContainer.TopToolStripPanel.Join(toolStrip, x, 0);

            toolstripContainer.ContentPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;

            Text = $"Mr. Dentist - {page.TitleText}";
            currentPage = page;
            UpdateUI();
        }
    }
}

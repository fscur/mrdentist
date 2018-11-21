using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Pages;
using System;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public partial class OdontogramEntryPage : Page, IOdontogramEntryPage
    {
        private ToolStripButton checkedButton;

        private ToolStripButton addCavityButton;
        private ToolStripButton addRestorationButton;
        private ToolStripButton eraserButton;

        public event EventHandler AddCavityClicked;
        public event EventHandler AddRestorationClicked;
        public event EventHandler EraserClicked;
        public event EventHandler<IPointF> CanvasMouseUp;

        public OdontogramEntryPage()
        {
            InitializeComponent();
            TitleText = "Editar Odontograma";
            InitToolStrips();
            InitCanvas();
        }

        private void InitCanvas()
        {
            canvas.MouseUp += (s, e) =>
            {
                RaiseCanvasMouseUp(new PointF(e.X, e.Y));
            };
        }

        private void InitToolStrips()
        {
            var drawingToolStrip = new ToolStrip();

            addCavityButton = new ToolStripButton(Properties.Resources.cavities.ToBitmap());
            addCavityButton.ToolTipText = "Desenhar Cárie";
            addCavityButton.Click += (s, e) => { RaiseAddCavityClicked(); };
            addCavityButton.CheckOnClick = true;
            drawingToolStrip.Items.Add(addCavityButton);

            addRestorationButton = new ToolStripButton(Properties.Resources.restoration.ToBitmap());
            addRestorationButton.ToolTipText = "Desenhar Obturação";
            addRestorationButton.Click += (s, e) => { RaiseAddRestorationClicked(); };
            addRestorationButton.CheckOnClick = true;
            drawingToolStrip.Items.Add(addRestorationButton);

            eraserButton = new ToolStripButton(Properties.Resources.eraser);
            eraserButton.ToolTipText = "Apagar";
            eraserButton.Click += (s, e) => { RaiseEraserClicked(); };
            eraserButton.CheckOnClick = true;
            drawingToolStrip.Items.Add(eraserButton);

            ToolStrips.Add(drawingToolStrip);
        }

        private void RaiseAddCavityClicked()
        {
            if (AddCavityClicked != null)
                AddCavityClicked.Invoke(this, new EventArgs());
        }

        private void RaiseAddRestorationClicked()
        {
            if (AddRestorationClicked != null)
                AddRestorationClicked.Invoke(this, new EventArgs());
        }

        private void RaiseEraserClicked()
        {
            if (EraserClicked != null)
                EraserClicked.Invoke(this, new EventArgs());
        }

        private void RaiseCanvasMouseUp(PointF location)
        {
            if (CanvasMouseUp != null)
                CanvasMouseUp.Invoke(this, location);
        }

        public void SetEditMode(OdontogramEditMode mode)
        {
            if (checkedButton != null)
                checkedButton.Checked = false;

            switch (mode)
            {
                case OdontogramEditMode.None:
                    checkedButton = null;
                    break;
                case OdontogramEditMode.AddCavity:
                    checkedButton = addCavityButton;
                    break;
                case OdontogramEditMode.AddRestoration:
                    checkedButton = addRestorationButton;
                    break;
                case OdontogramEditMode.Eraser:
                    checkedButton = eraserButton;
                    break;
                default:
                    break;
            }

            checkedButton.Checked = true;
        }

        public void SetCanvasImage(System.Drawing.Image image)
        {
            this.canvas.Image = image;
        }

        public void AddShapeToCanvas(IDentalEventShape shape)
        {
            this.canvas.Shapes.Add(shape);
        }
    }
}

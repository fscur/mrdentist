using MrDentist.Models;
using System;

namespace MrDentist.Pages
{
    public interface IOdontogramEntryPage : IPage
    {
        event EventHandler AddCavityClicked;
        event EventHandler AddRestorationClicked;
        event EventHandler EraserClicked;
        event EventHandler<IPointF> CanvasMouseUp;
        void SetEditMode(OdontogramEditMode mode);
        void SetCanvasImage(System.Drawing.Image image);
        void AddShapeToCanvas(IDentalIssueShape shape);
    }
}

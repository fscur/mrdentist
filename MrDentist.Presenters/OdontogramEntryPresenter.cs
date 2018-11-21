using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Pages;
using System;
using System.Linq;

namespace MrDentist.Presenters
{
    public class OdontogramEntryPresenter : IOdontogramEntryPresenter
    {
        private readonly DataRepository dataRepository;
        private IOdontogramEntryPage page;
        private OdontogramEditMode editMode;
        private OdontogramEntry odontogramEntry;

        public OdontogramEntry OdontograEntry
        {
            get { return odontogramEntry; }
            set
            {
                if (odontogramEntry == value)
                    return;

                odontogramEntry = value;

                page.SetCanvasImage(odontogramEntry.Odontogram.BaseImage);
                odontogramEntry.DentalEvents.ForEach(e => page.AddShapeToCanvas(e.Shape));
            }
        }

        public IPage Page => page;

        public OdontogramEntryPresenter(DataRepository dataRepository, IOdontogramEntryPage page)
        {
            this.page = page;
            this.dataRepository = dataRepository;

            page.AddCavityClicked += (s, e) => {
                editMode = OdontogramEditMode.AddCavity;
                page.SetEditMode(editMode);
            };

            page.AddRestorationClicked += (s, e) => {
                editMode = OdontogramEditMode.AddRestoration;
                page.SetEditMode(editMode);
            };

            page.EraserClicked += (s, e) => {
                editMode = OdontogramEditMode.Eraser;
                page.SetEditMode(editMode);
            };

            page.CanvasMouseUp += (s, e) =>
            {
                switch (editMode)
                {
                    case OdontogramEditMode.None:
                        break;
                    case OdontogramEditMode.AddCavity:
                        var cavity = new Cavity(1, e);
                        odontogramEntry.DentalEvents.Add(cavity);
                        page.AddShapeToCanvas(cavity.Shape);
                        
                        break;
                    case OdontogramEditMode.AddRestoration:
                        var restoration = new Restoration(1, e);
                        odontogramEntry.DentalEvents.Add(restoration);
                        page.AddShapeToCanvas(restoration.Shape);
                        break;
                    case OdontogramEditMode.Eraser:
                        break;
                    default:
                        break;
                }
            };

            editMode = OdontogramEditMode.AddCavity;
            page.SetEditMode(editMode);
        }
    }
}

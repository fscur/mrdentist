using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Models.Extensions;
using MrDentist.Net.Http;
using MrDentist.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MrDentist.Presenters
{
    public class OdontogramEntryPresenter : IOdontogramEntryPresenter
    {
        private readonly Dictionary<string, Image> odontogramImagesCache;
        private readonly IDataRepository dataRepository;
        private IOdontogramEntryPage page;
        private OdontogramEditMode editMode;
        private OdontogramEntry odontogramEntry;
        private Odontogram odontogram;
        private OdontogramEntryPresenterParams @params;

        public OdontogramEntry OdontograEntry
        {
            get { return odontogramEntry; }
            set
            {
                if (odontogramEntry == value)
                    return;

                odontogramEntry = value;
            }
        }

        public IPage Page => page;

        public OdontogramEntryPresenter(IDataRepository dataRepository, IOdontogramEntryPage page)
        {
            this.page = page;
            this.dataRepository = dataRepository;
            odontogramImagesCache = new Dictionary<string, Image>();

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
                var id = 0;

                switch (editMode)
                {
                    case OdontogramEditMode.None:
                        break;
                    case OdontogramEditMode.AddCavity:
                        id = dataRepository.Odontograms.GetNextIssueId();
                        var cavity = new Cavity(id, e);
                        odontogramEntry.DentalIssues.Add(cavity);
                        page.AddShapeToCanvas(cavity.Shape);
                        dataRepository.Odontograms.AddOdontogramEntryIssue(odontogramEntry.Id, cavity);
                        break;
                    case OdontogramEditMode.AddRestoration:
                        id = dataRepository.Odontograms.GetNextIssueId();
                        var restoration = new Restoration(id, e);
                        odontogramEntry.DentalIssues.Add(restoration);
                        page.AddShapeToCanvas(restoration.Shape);
                        dataRepository.Odontograms.AddOdontogramEntryIssue(odontogramEntry.Id, restoration);
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

        public void SetParams(IPresenterParams @params)
        {
            var p = (@params as OdontogramEntryPresenterParams);

            odontogram = p.Odontogram;
            odontogramEntry = p.OdontogramEntry;

            odontogramImagesCache.TryGetValue(odontogram.BaseImageUrl, out Image image);

            if (image == null)
            {
                var uri = new Uri(odontogram.BaseImageUrl);
                var downloader = new Downloader();
                var imageStream = downloader.DownloadAsync(uri).Result;
                image = Image.FromStream(imageStream);
                odontogramImagesCache.Add(odontogram.BaseImageUrl, image);
            }

            page.SetCanvasImage(image);

            var entries = odontogram.Entries.Where(t => t.Date <= odontogramEntry.Date);
            page.ClearCanvas();

            foreach (var entry in entries)
            {
                entry.DentalIssues.ForEach(e => page.AddShapeToCanvas(e.Shape));
            }
        }
    }
}

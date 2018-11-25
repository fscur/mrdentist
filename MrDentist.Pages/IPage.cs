using System;

namespace MrDentist.Pages
{
    public interface IPage
    {
        string TitleText { get; }
        event EventHandler NeedsReloading;
    }
}

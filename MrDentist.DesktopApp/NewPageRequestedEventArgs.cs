using System;

namespace MrDentist.DesktopApp
{
    public class NewPageRequestedEventArgs : EventArgs
    {
        public Page Page { get; private set; }

        public NewPageRequestedEventArgs(Page page)
        {
            Page = page;
        }
    }
}

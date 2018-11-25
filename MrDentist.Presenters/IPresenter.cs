using MrDentist.Pages;

namespace MrDentist.Presenters
{
    public interface IPresenter
    {
        IPage Page { get; }
        void SetParams(IPresenterParams @params);
    }
}

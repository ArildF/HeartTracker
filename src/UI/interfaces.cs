namespace Rogue.HeartTracker.UI
{
    public interface IViewModel
    {
        
    }

    public interface IView<T>
    {
        object DataContext { get; set; }
    }

    public interface IShellViewModel : IViewModel
    {
        
    }

    public interface IShellView : IView<IShellViewModel>
    {
        void Show();
    }
    
}

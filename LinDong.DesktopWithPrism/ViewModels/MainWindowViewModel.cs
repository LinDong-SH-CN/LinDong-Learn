using Prism.Mvvm;

namespace LinDong.DesktopWithPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application With HandyControl UI";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}

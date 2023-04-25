using CommunityToolkit.Mvvm.ComponentModel;


namespace LinDong.Handy_Control.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string windowTitle = "上海君地生态农业科技有限公司";

        [ObservableProperty]
        private string companyTitle = "Shanghai_CHINA";

        public override string ToString()
        {
            return $"{{{nameof(WindowTitle)}={WindowTitle}, {nameof(CompanyTitle)}={CompanyTitle}}}";
        }
    }
}

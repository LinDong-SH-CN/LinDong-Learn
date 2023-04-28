using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDong.MVVM.CommuntiyToolkit.Models
{
    public partial class Company : ObservableObject
    {
        [ObservableProperty]
        private string? companyId = string.Empty;

        [ObservableProperty]
        private string? companyName = string.Empty;

        [ObservableProperty]
        private string? companyAddress = string.Empty;

        [ObservableProperty]
        private CompanyType companyType = CompanyType.MainCompany;

        [ObservableProperty]
        private string? companyDescription = string.Empty;
    }
}

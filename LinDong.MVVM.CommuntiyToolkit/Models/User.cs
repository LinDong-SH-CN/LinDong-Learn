using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LinDong.MVVM.CommuntiyToolkit.Models
{
    public partial class User : ObservableObject
    {
        [ObservableProperty]
        private string? userId = string.Empty;

        [ObservableProperty]
        private string? name = string.Empty;

        [ObservableProperty]
        private Image? image = null;

        [ObservableProperty]
        private string? phone = string.Empty;

        [ObservableProperty]
        private string? email = string.Empty;

        [ObservableProperty]
        private string? companyId = string.Empty;
    }
}
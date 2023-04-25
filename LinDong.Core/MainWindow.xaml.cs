using HandyControl.Controls;
using LinDong.Database;
using LinqToDB;
using System.Linq;

namespace LinDong.Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : GlowWindow
    {
        public MainWindow()
        {
            InitializeComponent();
           
            using (var db = App._config.DbConnection())
            {
                var q = from p in db.UserPowers orderby p.CreateDate select p;
                foreach (var _ in q)
                {
                    MessageBox.Show(_.UserPowerName + " | " + _.UserPowerId + " | " + _.CreateDate);
                }
            }
        }
    }
}

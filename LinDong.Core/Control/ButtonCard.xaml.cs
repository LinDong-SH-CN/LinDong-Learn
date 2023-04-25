using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinDong.Core.Control
{
    /// <summary>
    /// ButtonCard.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonCard : UserControl
    {
        public Brush BtnBackground {
            get
            {
                return Btn.Background;
            }
            set 
            {
                Btn.Background = value;
            } 
        }

        public Brush BtnBorderBrush {
            get
            {
                return Btn.BorderBrush;
            }
            set
            {
                Btn.BorderBrush = value;
            }
        }

        public string BtnText
        {
            get
            {
                return _BtnText.Text;
            }
            set
            {
                _BtnText.Text = value;
            }
        }

        public string TitleText
        {
            get
            {
                return _TitleText.Text;
            }
            set
            {
                _TitleText.Text = value;
            }
        }

        public string SubtitleText
        {
            get
            {
                return _SubtitleText.Text;
            }
            set
            {
                _SubtitleText.Text = value;
            }
        }

        public string ExplainText
        {
            get
            {
                return _ExplainText.Text;
            }
            set
            {
                _ExplainText.Text = value;
            }
        }

        public string ExplainInfo
        {
            get { return _ExplainInfo.Text; }
            set { _ExplainInfo.Text = value; }
        }

        public double IconSize
        {
            get
            {
                return Btn.Height;
            }

            set
            { 
                Btn.Height = value;
                Btn.Width = value;
                _BtnText.FontSize = value/2;
            }
        }

        public Brush BtnForeground
        {
            get { return _BtnText.Foreground; }
            set { _BtnText.Foreground = value; }
        }

        public ButtonCard()
        {
            InitializeComponent();
        }
    }
}

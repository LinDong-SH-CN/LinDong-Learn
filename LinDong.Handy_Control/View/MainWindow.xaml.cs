using LinDong.Handy_Control.ViewModel;
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
using System.Windows.Shapes;

namespace LinDong.Handy_Control.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        public override string ToString()
        {
            return $"{{{nameof(AllowsTransparency)}={AllowsTransparency.ToString()}, {nameof(DialogResult)}={DialogResult.ToString()}, {nameof(Icon)}={Icon}, {nameof(IsActive)}={IsActive.ToString()}, {nameof(Left)}={Left.ToString()}, {nameof(OwnedWindows)}={OwnedWindows}, {nameof(Owner)}={Owner}, {nameof(ResizeMode)}={ResizeMode.ToString()}, {nameof(RestoreBounds)}={RestoreBounds.ToString()}, {nameof(ShowActivated)}={ShowActivated.ToString()}, {nameof(ShowInTaskbar)}={ShowInTaskbar.ToString()}, {nameof(SizeToContent)}={SizeToContent.ToString()}, {nameof(TaskbarItemInfo)}={TaskbarItemInfo}, {nameof(Title)}={Title}, {nameof(Top)}={Top.ToString()}, {nameof(Topmost)}={Topmost.ToString()}, {nameof(WindowStartupLocation)}={WindowStartupLocation.ToString()}, {nameof(WindowState)}={WindowState.ToString()}, {nameof(WindowStyle)}={WindowStyle.ToString()}, {nameof(Content)}={Content}, {nameof(ContentStringFormat)}={ContentStringFormat}, {nameof(ContentTemplate)}={ContentTemplate}, {nameof(ContentTemplateSelector)}={ContentTemplateSelector}, {nameof(HasContent)}={HasContent.ToString()}, {nameof(Background)}={Background}, {nameof(BorderBrush)}={BorderBrush}, {nameof(BorderThickness)}={BorderThickness.ToString()}, {nameof(FontFamily)}={FontFamily}, {nameof(FontSize)}={FontSize.ToString()}, {nameof(FontStretch)}={FontStretch.ToString()}, {nameof(FontStyle)}={FontStyle.ToString()}, {nameof(FontWeight)}={FontWeight.ToString()}, {nameof(Foreground)}={Foreground}, {nameof(HorizontalContentAlignment)}={HorizontalContentAlignment.ToString()}, {nameof(IsTabStop)}={IsTabStop.ToString()}, {nameof(Padding)}={Padding.ToString()}, {nameof(TabIndex)}={TabIndex.ToString()}, {nameof(Template)}={Template}, {nameof(VerticalContentAlignment)}={VerticalContentAlignment.ToString()}, {nameof(ActualHeight)}={ActualHeight.ToString()}, {nameof(ActualWidth)}={ActualWidth.ToString()}, {nameof(BindingGroup)}={BindingGroup}, {nameof(ContextMenu)}={ContextMenu}, {nameof(Cursor)}={Cursor}, {nameof(DataContext)}={DataContext}, {nameof(FlowDirection)}={FlowDirection.ToString()}, {nameof(FocusVisualStyle)}={FocusVisualStyle}, {nameof(ForceCursor)}={ForceCursor.ToString()}, {nameof(Height)}={Height.ToString()}, {nameof(HorizontalAlignment)}={HorizontalAlignment.ToString()}, {nameof(InputScope)}={InputScope}, {nameof(IsInitialized)}={IsInitialized.ToString()}, {nameof(IsLoaded)}={IsLoaded.ToString()}, {nameof(Language)}={Language}, {nameof(LayoutTransform)}={LayoutTransform}, {nameof(Margin)}={Margin.ToString()}, {nameof(MaxHeight)}={MaxHeight.ToString()}, {nameof(MaxWidth)}={MaxWidth.ToString()}, {nameof(MinHeight)}={MinHeight.ToString()}, {nameof(MinWidth)}={MinWidth.ToString()}, {nameof(Name)}={Name}, {nameof(OverridesDefaultStyle)}={OverridesDefaultStyle.ToString()}, {nameof(Parent)}={Parent}, {nameof(Resources)}={Resources}, {nameof(Style)}={Style}, {nameof(Tag)}={Tag}, {nameof(TemplatedParent)}={TemplatedParent}, {nameof(ToolTip)}={ToolTip}, {nameof(Triggers)}={Triggers}, {nameof(UseLayoutRounding)}={UseLayoutRounding.ToString()}, {nameof(VerticalAlignment)}={VerticalAlignment.ToString()}, {nameof(Width)}={Width.ToString()}, {nameof(AllowDrop)}={AllowDrop.ToString()}, {nameof(AreAnyTouchesCaptured)}={AreAnyTouchesCaptured.ToString()}, {nameof(AreAnyTouchesCapturedWithin)}={AreAnyTouchesCapturedWithin.ToString()}, {nameof(AreAnyTouchesDirectlyOver)}={AreAnyTouchesDirectlyOver.ToString()}, {nameof(AreAnyTouchesOver)}={AreAnyTouchesOver.ToString()}, {nameof(BitmapEffect)}={BitmapEffect}, {nameof(BitmapEffectInput)}={BitmapEffectInput}, {nameof(CacheMode)}={CacheMode}, {nameof(Clip)}={Clip}, {nameof(ClipToBounds)}={ClipToBounds.ToString()}, {nameof(CommandBindings)}={CommandBindings}, {nameof(DesiredSize)}={DesiredSize.ToString()}, {nameof(Effect)}={Effect}, {nameof(Focusable)}={Focusable.ToString()}, {nameof(HasAnimatedProperties)}={HasAnimatedProperties.ToString()}, {nameof(InputBindings)}={InputBindings}, {nameof(IsArrangeValid)}={IsArrangeValid.ToString()}, {nameof(IsEnabled)}={IsEnabled.ToString()}, {nameof(IsFocused)}={IsFocused.ToString()}, {nameof(IsHitTestVisible)}={IsHitTestVisible.ToString()}, {nameof(IsInputMethodEnabled)}={IsInputMethodEnabled.ToString()}, {nameof(IsKeyboardFocused)}={IsKeyboardFocused.ToString()}, {nameof(IsKeyboardFocusWithin)}={IsKeyboardFocusWithin.ToString()}, {nameof(IsManipulationEnabled)}={IsManipulationEnabled.ToString()}, {nameof(IsMeasureValid)}={IsMeasureValid.ToString()}, {nameof(IsMouseCaptured)}={IsMouseCaptured.ToString()}, {nameof(IsMouseCaptureWithin)}={IsMouseCaptureWithin.ToString()}, {nameof(IsMouseDirectlyOver)}={IsMouseDirectlyOver.ToString()}, {nameof(IsMouseOver)}={IsMouseOver.ToString()}, {nameof(IsStylusCaptured)}={IsStylusCaptured.ToString()}, {nameof(IsStylusCaptureWithin)}={IsStylusCaptureWithin.ToString()}, {nameof(IsStylusDirectlyOver)}={IsStylusDirectlyOver.ToString()}, {nameof(IsStylusOver)}={IsStylusOver.ToString()}, {nameof(IsVisible)}={IsVisible.ToString()}, {nameof(Opacity)}={Opacity.ToString()}, {nameof(OpacityMask)}={OpacityMask}, {nameof(PersistId)}={PersistId.ToString()}, {nameof(RenderSize)}={RenderSize.ToString()}, {nameof(RenderTransform)}={RenderTransform}, {nameof(RenderTransformOrigin)}={RenderTransformOrigin.ToString()}, {nameof(SnapsToDevicePixels)}={SnapsToDevicePixels.ToString()}, {nameof(TouchesCaptured)}={TouchesCaptured}, {nameof(TouchesCapturedWithin)}={TouchesCapturedWithin}, {nameof(TouchesDirectlyOver)}={TouchesDirectlyOver}, {nameof(TouchesOver)}={TouchesOver}, {nameof(Uid)}={Uid}, {nameof(Visibility)}={Visibility.ToString()}, {nameof(DependencyObjectType)}={DependencyObjectType}, {nameof(IsSealed)}={IsSealed.ToString()}, {nameof(Dispatcher)}={Dispatcher}}}";
        }
    }
}

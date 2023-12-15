using System.Windows.Controls;
using WPF.MVVM.ViewModels;

namespace WPF.MVVM.Views.UserControls;
/// <summary>
/// Interaction logic for CounterUC.xaml
/// </summary>
public partial class CounterUC : UserControl
{
	public CounterUC()
	{
		InitializeComponent();
		DataContext = new CounterViewModel();
	}
}

using System.Windows.Controls;
using WPF.MVVM.ViewModels;

namespace WPF.MVVM.Views.UserControls;
/// <summary>
/// Interaction logic for ListViewUC.xaml
/// </summary>
public partial class ListViewUC : UserControl
{
	public ListViewUC()
	{
		InitializeComponent();
		DataContext = new ListViewViewModel();
	}
}

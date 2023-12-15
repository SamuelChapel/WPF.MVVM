using System.Windows.Input;

namespace WPF.MVVM.ViewModels;

public class CounterViewModel : ViewModelBase
{
	private int _counter;

	public int Counter
	{
		get => _counter;
		set
		{
			_counter = value;
			OnPropertyChanged(nameof(Counter));
		}
	}

	public ICommand IncreaseCounter => new RelayCommand(e => Counter++);
	public ICommand DecreaseCounter => new RelayCommand(e => Counter--);
	public ICommand InitCounter => new RelayCommand(e => Counter = 0);
}

using System.ComponentModel;
using System.Windows.Data;
using Bogus;
using Person = WPF.MVVM.Models.Person;

namespace WPF.MVVM.ViewModels;

public class ListViewViewModel : ViewModelBase
{
	private readonly List<Person> _listEmployees;

	public ListViewViewModel()
	{
		_listEmployees = new(Enumerable.Range(0, 100)
			.Select(i => new Faker<Person>()
				.RuleFor(e => e.FirstName, f => f.Person.FirstName)
				.RuleFor(e => e.LastName, f => f.Person.LastName).Generate()));
		_employeesView = new ListCollectionView(_listEmployees);
	}

	private string? searchString;
	public string? SearchString
	{
		get => searchString;
		set
		{
			searchString = value;
			OnPropertyChanged(nameof(searchString));

			EmployeesView.Filter = value is null ? null : new Predicate<object>(p => ((Person)p).FirstName.Contains(value) || ((Person)p).LastName.Contains(value));
		}
	}

	private readonly ListCollectionView _employeesView;
	public ICollectionView EmployeesView
	{
		get => _employeesView;
	}
}

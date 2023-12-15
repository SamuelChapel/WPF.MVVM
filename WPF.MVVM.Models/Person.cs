namespace WPF.MVVM.Models;

public class Person
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;

	public override string ToString()
	{
		return $"{FirstName,-15}{LastName,-15}";
	}
}

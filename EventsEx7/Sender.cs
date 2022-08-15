namespace EventsEx7;

internal abstract class Sender
{
	private int _myInt;

	public int MyInt
	{
		get => _myInt;
		set
		{
			if (_myInt != value)
			{
				_myInt = value;
				OnMyIntChanged();
			}
		}
	}

	public abstract event EventHandler? MyIntChanged;

	protected virtual void OnMyIntChanged() => Console.WriteLine("Sender.OnMyIntChanged()");
}

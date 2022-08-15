namespace EventsEx5;

internal class Sender : IMyInterface
{
	public event EventHandler? MyIntChanged;

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

	private void OnMyIntChanged() => MyIntChanged?.Invoke(this, EventArgs.Empty);
}

namespace UsingEventsAndLambdaExpressions;

internal class Sender
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

	public event EventHandler? MyIntChanged;

	private void OnMyIntChanged() => MyIntChanged?.Invoke(this, EventArgs.Empty);
}

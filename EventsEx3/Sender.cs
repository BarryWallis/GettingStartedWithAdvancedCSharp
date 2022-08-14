namespace EventsEx3;

internal delegate void MyIntChangedEventHandler(object sender, JobNumberEventArgs e);

internal class Sender
{
	public event MyIntChangedEventHandler? MyIntChanged;

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

	protected virtual void OnMyIntChanged() => MyIntChanged?.Invoke(this, new JobNumberEventArgs(_myInt));
}

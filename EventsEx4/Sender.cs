namespace EventsEx4;

internal delegate void MyIntChangedEventHandler(object sender, JobNumberEventArgs e);

internal class Sender
{
	private MyIntChangedEventHandler? _myIntChanged;
	public event MyIntChangedEventHandler MyIntChanged
	{
		add
		{
			lock (this)
			{
				Console.WriteLine("*** Inside add accesor entry point.");
				_myIntChanged += value;
			}
		}

		remove
		{
			lock (this)
			{
				_myIntChanged -= value;
				Console.WriteLine("*** Inside remove accessor exit point.");
			}
		}
	}

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

	protected virtual void OnMyIntChanged() => _myIntChanged?.Invoke(this, new JobNumberEventArgs(_myInt));
}

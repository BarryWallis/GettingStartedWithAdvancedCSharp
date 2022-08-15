namespace EventsEx6;

internal class Sender : IBeforeInterface, IAfterInterface
{
    private int _myInt;

    public int MyInt
    {
        get => _myInt;
        set
        {
            if (_myInt != value)
            {
                OnMyIntChangedBefore();
                Console.WriteLine($"Making a change to MyInt from {_myInt} to {value}");
                _myInt = value;
                OnMyIntChangedAfter();
            }
        }
    }

    public event EventHandler? AfterMyIntChanged;
    public event EventHandler? BeforeMyIntChanged;

    protected virtual void OnMyIntChangedAfter() => AfterMyIntChanged?.Invoke(this, EventArgs.Empty);

    protected virtual void OnMyIntChangedBefore() => BeforeMyIntChanged?.Invoke(this, EventArgs.Empty);

    event EventHandler? IAfterInterface.MyIntChanged
    {
        add
        {
            lock (this)
            {
                AfterMyIntChanged += value;
            }
        }

        remove
        {
            lock (this)
            {
                AfterMyIntChanged -= value;
            }
        }
    }

    event EventHandler? IBeforeInterface.MyIntChanged
    {
        add
        {
            lock (this)
            {
                BeforeMyIntChanged += value;
            }
        }

        remove
        {
            lock (this)
            {
                BeforeMyIntChanged -= value;
            }
        }
    }
}

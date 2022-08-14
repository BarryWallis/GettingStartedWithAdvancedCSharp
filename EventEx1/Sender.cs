namespace EventEx1;

internal class Sender
{
    public EventHandler? MyIntChanged;

    private int _myInt;
    public int MyInt
    {
        get => _myInt;
        set
        {
            _myInt = value;
            OnMyIntChanged();
        }
    }

    private void OnMyIntChanged() => MyIntChanged?.Invoke(this, EventArgs.Empty);

    public void GetNotificationItself(object sender, EventArgs eventArgs)
        => Console.WriteLine($"Sender itself sent a notification: I have changed myInt value to {MyInt}");
}

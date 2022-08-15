namespace EventsEx7;

internal class ConcreteSender : Sender
{
    public override event EventHandler? MyIntChanged;

    protected override void OnMyIntChanged() => MyIntChanged?.Invoke(this, EventArgs.Empty);
}

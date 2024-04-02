using SourceControlProject.Status;

namespace SourceControlProject.Memento;

public class ConcreteMemento : IMemento
{
    private IState _state;

    private DateTime _date;
    public ConcreteMemento(IState state, DateTime dateTime)
    {
        _state = state;
        _date = dateTime;   
    }
    public DateTime GetDate()
    {
        return DateTime.Now;
    }

    public string GetName()
    {
        return $"{this._date} / {this._state}.";
    }

    public IState GetState()
    {
        return _state;
    }
}
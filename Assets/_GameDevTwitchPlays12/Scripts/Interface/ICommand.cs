public interface ICommand
{
    string response { get; }
    bool feedbackUser { get; }
}

public interface IState {

    string response { get; }
    bool feedbackUser { get; }

}
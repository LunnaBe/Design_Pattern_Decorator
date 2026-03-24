using System.Windows.Input;

namespace App_Decorator_RPG;

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Predicate<object> _canExecute;

    // Construtor que aceita a ação de executar e a condição (opcional)
    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    // Verifica se o botão deve estar habilitado
    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    // Executa a lógica quando o botão é clicado
    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    // Gerencia a atualização visual do botão (habilitado/desabilitado)
    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}


using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace App_Decorator_RPG.ViewModels;

public class PersonagemViewModel : INotifyPropertyChanged
{
    private IPersonagem _personagem;
    public PersonagemViewModel()
    {
        _personagem = new Guerreiro();
    }
    
    public string Descricao => _personagem.Descricao;
    public int Ataque => _personagem.Ataque;
    public int Defesa => _personagem.Defesa;
    
    public ICommand EquiparEspadaCommand => new RelayCommand(_ => {
        _personagem = new EspadaDeFogo(_personagem);
        NotificarMudancas();
    });

    public ICommand EquiparArmaduraCommand => new RelayCommand(_ => {
        _personagem = new ArmaduraMagica(_personagem);
        NotificarMudancas();
    });

    public ICommand ResetarCommand => new RelayCommand(_ => {
        _personagem = new Guerreiro();
        NotificarMudancas();
    });

    private void NotificarMudancas()
    {
        OnPropertyChanged(nameof(Descricao));
        OnPropertyChanged(nameof(Ataque));
        OnPropertyChanged(nameof(Defesa));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}


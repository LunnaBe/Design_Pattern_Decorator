namespace App_Decorator_RPG;

public abstract class EquipamentoDecorator : IPersonagem
{
    protected IPersonagem _personagemDecorado;

    protected EquipamentoDecorator(IPersonagem personagem)
    {
        _personagemDecorado = personagem;
    }
    
    public virtual string Nome => _personagemDecorado.Nome;
    public virtual int Ataque => _personagemDecorado.Ataque;
    public virtual int Defense => _personagemDecorado.Defense;
    public virtual string Descricao => _personagemDecorado.Descricao;
    
}
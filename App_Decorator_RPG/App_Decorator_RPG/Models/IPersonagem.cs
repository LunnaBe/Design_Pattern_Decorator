namespace App_Decorator_RPG;

public interface IPersonagem
{
    string Nome { get; }
    int Ataque { get; }
    int Defesa { get; }
    string Descricao { get; }
}
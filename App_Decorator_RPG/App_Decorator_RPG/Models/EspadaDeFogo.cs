namespace App_Decorator_RPG;

public class EspadaDeFogo : EquipamentoDecorator
{
    public EspadaDeFogo(IPersonagem p) : base(p) { }
    public override int Ataque => _personagemDecorado.Ataque + 30;
    public override string Descricao => _personagemDecorado.Descricao + "\n ⚔️🔥 Ativar Ataque de Fogo";
}


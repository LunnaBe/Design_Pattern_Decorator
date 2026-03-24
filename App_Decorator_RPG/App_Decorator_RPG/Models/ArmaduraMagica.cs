namespace App_Decorator_RPG;

public class ArmaduraMagica : EquipamentoDecorator
{
    public ArmaduraMagica(IPersonagem p) : base(p) { }
    public override int Defesa => _personagemDecorado.Defesa * 4;
    public override string Descricao => _personagemDecorado.Descricao + "\n 🛡️ Ativar Defesa de Armadura Magica";
}




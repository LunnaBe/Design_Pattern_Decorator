namespace App_Decorator_RPG;

public class ArmaduraMagica : EquipamentoDecorator
{
    public ArmaduraMagica(IPersonagem p) : base(p) { }
    public override int Ataque => _personagemDecorado.Ataque * 40;
    public override string Descricao => _personagemDecorado.Descricao + "Defesa de Armadura Magica";
}
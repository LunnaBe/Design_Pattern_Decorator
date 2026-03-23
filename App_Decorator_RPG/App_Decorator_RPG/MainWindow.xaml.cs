using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace App_Decorator_RPG;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MetroWindow
{
    IPersonagem meuHeroi;
    public MainWindow()
    {
        InitializeComponent();
        Resetar();
    }
    private void AtualizarTela() {
        txtStatus.Text = $"Status Atual:\n⚔️ Ataque: {meuHeroi.Ataque}\n🛡️ Defesa: {meuHeroi.Defesa}";
        txtDesc.Text = meuHeroi.Descricao;
    }
    
    private void Resetar() {
        meuHeroi = new Guerreiro(); // Começa do zero
        AtualizarTela();
    }


    private void BtnEspada_Click(object sender, RoutedEventArgs e)
    {
        meuHeroi = new EspadaDeFogo(meuHeroi); 
        AtualizarTela();
    }
    
    private void BtnArmadura_Click(object sender, RoutedEventArgs e)
    {
        meuHeroi = new ArmaduraMagica(meuHeroi);
        AtualizarTela();
    }

    private void BtnReset_Click(object sender, RoutedEventArgs e)
    {
        Resetar();
    }
    
}
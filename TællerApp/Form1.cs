namespace TællerApp;

public partial class Form1 : Form
{
    private int tæller = 0;

    public Form1()
    {
        InitializeComponent();
        OpdaterTællerLabel();
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        tæller++;
        OpdaterTællerLabel();
        TilføjLog("+1");
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        tæller--;
        OpdaterTællerLabel();
        TilføjLog("-1");
    }

    private void btnNulstil_Click(object sender, EventArgs e)
    {
        tæller = 0;
        OpdaterTællerLabel();
        TilføjLog("Nulstil");
    }

    private void OpdaterTællerLabel()
    {
        lblTæller.Text = tæller.ToString();
    }

    private void TilføjLog(string handling)
    {
        lstLog.Items.Add($"{DateTime.Now:HH:mm:ss} - {handling}");
    }
}
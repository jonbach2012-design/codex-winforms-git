namespace TællerApp;

public partial class Form1 : Form
{
    private int tæller = 0;
    private const int MinVærdi = -10;
    private const int MaxVærdi = 10;
    private readonly System.Windows.Forms.Timer autoTimer = new();

    public Form1()
    {
        InitializeComponent();
        OpdaterTællerLabel();

        autoTimer.Interval = 10;
        autoTimer.Tick += autoTimer_Tick;
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        ForsøgÆndring(1, "+1");
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        ForsøgÆndring(-1, "-1");
    }

    private void btnNulstil_Click(object sender, EventArgs e)
    {
        tæller = 0;
        OpdaterTællerLabel();
        TilføjLog("Nulstil");
    }

    private void chkAutoPlus_CheckedChanged(object sender, EventArgs e)
    {
        autoTimer.Enabled = chkAutoPlus.Checked;
        TilføjLog(chkAutoPlus.Checked ? "Auto +1 slået til" : "Auto +1 slået fra");
    }

    private void autoTimer_Tick(object? sender, EventArgs e)
    {
        ForsøgÆndring(1, "Auto +1 tick");
    }

    private void ForsøgÆndring(int ændring, string handling)
    {
        int nyVærdi = tæller + ændring;

        if (nyVærdi < MinVærdi || nyVærdi > MaxVærdi)
        {
            MessageBox.Show(
                $"Tælleren må kun være mellem {MinVærdi} og {MaxVærdi}.",
                "Grænse nået",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            TilføjLog($"Forsøg udenfor grænse: {handling}");
            return;
        }

        tæller = nyVærdi;
        OpdaterTællerLabel();
        TilføjLog(handling);
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
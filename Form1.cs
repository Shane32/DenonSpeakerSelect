namespace DenonSpeakerSelect;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void timer1_Tick(object sender, EventArgs e)
    {
        if (timer1.Interval != 60000)
            timer1.Interval = 60000;
        await UpdateMenuAsync(false);
    }

    private async Task UpdateMenuAsync(bool displayError)
    {
        Denon.Speakers speakerMode = Denon.Speakers.Unknown;
        try
        {
            speakerMode = await Denon.GetSpeakerMode();
        }
        catch (Exception ex)
        {
            if (displayError)
                MessageBox.Show("Unable to get speaker mode: " + ex.ToString());
        }
        speakersAToolStripMenuItem.Checked = speakerMode == Denon.Speakers.A;
        speakersBToolStripMenuItem.Checked = speakerMode == Denon.Speakers.B;
        speakersABToolStripMenuItem.Checked = speakerMode == Denon.Speakers.AB;
    }

    private async Task SetSpeakerMode(Denon.Speakers speakers)
    {
        try
        {
            await Denon.SetSpeakerMode(speakers);
            await Task.Delay(1000);
            await UpdateMenuAsync(true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to set speaker mode: " + ex.ToString());
        }
    }
    private async void speakersAToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetSpeakerMode(Denon.Speakers.A);
    }

    private async void speakersBToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetSpeakerMode(Denon.Speakers.B);
    }

    private async void speakersABToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetSpeakerMode(Denon.Speakers.AB);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    protected override void SetVisibleCore(bool value)
    {
        if (!this.IsHandleCreated)
        {
            this.CreateHandle();
            value = false;   // Prevent window from becoming visible
        }
        base.SetVisibleCore(value);
    }
}
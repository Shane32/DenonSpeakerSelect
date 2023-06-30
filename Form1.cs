namespace DenonSpeakerSelect;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void timer1_Tick(object sender, EventArgs e)
    {
        if (timer1.Interval != 5000)
            timer1.Interval = 5000;
        await UpdateMenuAsync(false);
    }

    private async Task UpdateMenuAsync(bool displayError)
    {
        Denon.Speakers speakerMode = Denon.Speakers.Unknown;
        bool? muted = null;
        try
        {
            speakerMode = await Denon.GetSpeakerMode();
            await Task.Delay(100);
            muted = await Denon.GetMuteState();
        }
        catch (Exception ex)
        {
            if (displayError)
                MessageBox.Show("Unable to get speaker mode / mute: " + ex.ToString());
        }
        speakersAToolStripMenuItem.Checked = speakerMode == Denon.Speakers.A;
        speakersBToolStripMenuItem.Checked = speakerMode == Denon.Speakers.B;
        speakersABToolStripMenuItem.Checked = speakerMode == Denon.Speakers.AB;
        muteToolStripMenuItem.Checked = muted == true;
        unmuteToolStripMenuItem.Checked = muted == false;
    }

    private async Task SetSpeakerMode(Denon.Speakers speakers)
    {
        try
        {
            await Denon.SetSpeakerMode(speakers);
            timer1.Interval = 1000;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to set speaker mode: " + ex.ToString());
        }
    }

    private async Task SetVolume(int volume)
    {
        try
        {
            await Denon.SetVolume(volume);
            timer1.Interval = 500;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to set volume: " + ex.ToString());
        }
    }

    private async Task SetMute(bool muted)
    {
        try
        {
            await Denon.SetMute(muted);
            timer1.Interval = 500;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to set mute: " + ex.ToString());
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

    private async void volume50ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(50);
    }

    private async void volume40ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(40);
    }

    private async void volume30ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(30);
    }

    private async void muteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetMute(true);
    }

    private async void unmuteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetMute(false);
    }

    private async void volume60ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(60);
    }

    private async void volume35ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(35);
    }

    private async void volume45ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(45);
    }

    private async void volume55ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await SetVolume(55);
    }
}
﻿using System.Net.Sockets;

namespace DenonSpeakerSelect;

public class Denon
{
    private static CancellationTokenSource? _cts;
    private static readonly object _ctsLock = new();

    public static async Task<string?> SendCommandAsync(string command)
    {
        CancellationToken token;
        lock (_ctsLock) {
            var cts = _cts;
            if (cts != null)
            {
                if (!cts.IsCancellationRequested)
                    cts.CancelAfter(1);
            }
            _cts = new CancellationTokenSource(5000);
            token = _cts.Token;
        }
        using var client = new TcpClient();
        await client.ConnectAsync(Program.Settings.DenonIPAddress!, 23, token);
        using var stream = client.GetStream();
        var buffer = System.Text.Encoding.ASCII.GetBytes(command + "\r");
        await stream.WriteAsync(buffer, 0, buffer.Length, token);
        var inbuf = new MemoryStream();
        buffer = new byte[1024];
        do
        {
            var read = await stream.ReadAsync(buffer, 0, buffer.Length, token);
            if (read == 0)
                break;
            inbuf.Write(buffer, 0, read);
            if (buffer[read - 1] == 13)
                break;
        } while (true);
        var str = System.Text.Encoding.ASCII.GetString(inbuf.ToArray());
        if (str.EndsWith("\r"))
            str = str[..^1];
        return str;
    }

    public static async Task<Speakers> GetSpeakerMode()
    {
        var status = await SendCommandAsync("PSFRONT?");
        return status switch
        {
            "SSFRSDST SPA" => Speakers.A,
            "SSFRSDST SPB" => Speakers.B,
            "SSFRSDST A+B" => Speakers.AB,
            _ => throw new ApplicationException("Unknown speaker mode: " + status)
        };
    }

    public static async Task SetSpeakerMode(Speakers speakers)
    {
        await SendCommandAsync(speakers switch
        {
            Speakers.A => "PSFRONT SPA",
            Speakers.B => "PSFRONT SPB",
            Speakers.AB => "PSFRONT A+B",
            _ => throw new ApplicationException("Unknown speaker mode: " + speakers)
        });
    }
    
    public enum Speakers
    {
        Unknown,
        A,
        B,
        AB,
    }

    public static async Task SetVolume(int volume)
    {
        if (volume < 0 || volume > 100)
            throw new ArgumentOutOfRangeException(nameof(volume), "Volume must be between 0 and 100.");

        // If the volume is a single digit, we'll need to prepend a '0' to make it valid for the receiver
        var volumeString = volume.ToString().PadLeft(2, '0');

        await SendCommandAsync($"MV{volumeString}");
    }

    public static async Task SetMute(bool isMuted)
    {
        if ((await GetMuteState()) == isMuted)
            return;
        string command = isMuted ? "MUON" : "MUOFF";
        await SendCommandAsync(command);
    }

    public static async Task<bool> GetMuteState()
    {
        var status = await SendCommandAsync("MU?");
        switch (status)
        {
            case "MUON":
                return true;
            case "MUOFF":
                return false;
            default:
                throw new ApplicationException("Unknown mute state: " + status);
        }
    }

}

using System.Net.Sockets;

namespace DenonSpeakerSelect
{
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
    }
}

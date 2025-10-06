using AdapterPattern.Interface;

namespace AdapterPattern.Service;

public sealed class SmsAdapter : INotifier
{
    private readonly LegacySmsClient _sms;

    public SmsAdapter(LegacySmsClient sms) => _sms = sms;

    public void Send(string to, string message)
    {
        var e164 = NormalizeToE164(to);
        var ok = _sms.SendSms(e164, message);

        Console.WriteLine(ok
            ? "[SmsAdapter] SMS sent successfully."
            : "[SmsAdapter] SMS failed.");
    }

    private static string NormalizeToE164(string phone)
    {
        // minimal example: ensure it starts with '+'
        return phone.StartsWith("+") ? phone : "+" + phone;
    }
}

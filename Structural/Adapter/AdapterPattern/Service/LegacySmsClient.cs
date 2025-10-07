namespace AdapterPattern.Service;

public sealed class LegacySmsClient
{
    // expects E.164 number and different method name/signature
    public bool SendSms(string e164Number, string body)
    {
        Console.WriteLine($"[LegacySmsClient] -> SMS to {e164Number}: {body}");
        return true;
    }
}

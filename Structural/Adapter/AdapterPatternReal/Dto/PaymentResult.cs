namespace AdapterPatternReal.Dto;

public sealed record PaymentResult(bool Success, string TransactionId, string Error = "");

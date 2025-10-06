namespace AdapterPatternReal.Dto;

public sealed record PaymentRequest(string CustomerId, decimal Amount, string Currency);

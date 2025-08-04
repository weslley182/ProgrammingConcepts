using OOP_Concepts.Models.General;

namespace SOLIDConcepts.SRP;

public class InvoiceService
{
    private readonly InvoiceCalculator _invoiceCalculator;
    private readonly InvoiceRepository _invoiceRepository;
    private readonly EmailService _emailService;

    public InvoiceService(InvoiceCalculator invoiceCalculator, InvoiceRepository invoiceRepository, EmailService emailService)
    {
        _invoiceCalculator = invoiceCalculator;
        _invoiceRepository = invoiceRepository;
        _emailService = emailService;
    }
    public void GenerateInvoice(Order order)
    {
        var total = _invoiceCalculator.CalculateTotal(order);
        _invoiceRepository.SaveToDatabase(order, total);
        _emailService.SendEmail(order.CustomerEmail, total);
    }
}

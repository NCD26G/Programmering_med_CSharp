using System;

namespace FactoryDesignPattern;

public class InvoiceFactory : IInvoiceFactory
{
    public IInvoiceCreater GenerateInvoice(InvoiceTypeEnum type)
    {
        return type switch
        {
            InvoiceTypeEnum.PDF => new PDFCreator(),
            InvoiceTypeEnum.E_Faktura => new ECreator(),
            _ => throw new ArgumentException("Fattar inte vad du vill!", nameof(type))
        };
    }
}

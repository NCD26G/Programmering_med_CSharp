using System;

namespace FactoryDesignPattern;

public class PDFCreator : IInvoiceCreater
{
    public string CreateInvoice()
    {
        return "Skapat en pdf faktura";
    }
}

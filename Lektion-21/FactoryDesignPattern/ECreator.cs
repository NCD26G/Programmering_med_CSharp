using System;

namespace FactoryDesignPattern;

public class ECreator : IInvoiceCreater
{
    public string CreateInvoice()
    {
        return "Skapa en e-faktura";
    }
}

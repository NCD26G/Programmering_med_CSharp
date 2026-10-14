using System;

namespace FactoryDesignPattern;

public interface IInvoiceFactory
{
    IInvoiceCreater GenerateInvoice(InvoiceTypeEnum type);
}

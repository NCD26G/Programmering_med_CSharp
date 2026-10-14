namespace FactoryDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var factory = new InvoiceFactory();
            var pdf = factory.GenerateInvoice(InvoiceTypeEnum.PDF);
            var eInvoice = factory.GenerateInvoice(InvoiceTypeEnum.E_Faktura);
            var badInvoice = factory.GenerateInvoice(InvoiceTypeEnum.Unknown);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }
}

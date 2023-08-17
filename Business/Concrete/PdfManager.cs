using Business.Abstract;

namespace Business.Concrete;

public class PdfManager: IPdfService
{
    public byte[] ExportStaticPdf<T>(List<T> t) where T : class, new()
    {
throw new NotImplementedException();
        
        
    }
}
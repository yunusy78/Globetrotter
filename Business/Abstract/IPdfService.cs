namespace Business.Abstract;

public interface IPdfService
{
byte[] ExportStaticPdf<T>(List<T> t) where T : class, new();
}
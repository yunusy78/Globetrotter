namespace Business.Abstract;

public interface IExelService
{
    byte [] ExportStaticExcel<T>(List<T> t) where T: class, new();
}
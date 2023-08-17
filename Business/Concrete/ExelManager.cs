using Business.Abstract;
using OfficeOpenXml;

namespace Business.Concrete;

public class ExelManager : IExelService
{
    public byte[] ExportStaticExcel<T>(List<T> t) where T : class, new()
    {
        ExcelPackage excelPackage = new ExcelPackage();
        var ws = excelPackage.Workbook.Worksheets.Add("Side1");
        ws.Cells["A1"].LoadFromCollection(t, true , OfficeOpenXml.Table.TableStyles.Light10);
        return excelPackage.GetAsByteArray();
    }
}
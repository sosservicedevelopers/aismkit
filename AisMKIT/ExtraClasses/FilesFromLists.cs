using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using iText.Html2pdf;
using Microsoft.AspNetCore.Hosting;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.ComponentModel;

namespace AisMKIT.ExtraClasses
{
    public class FilesFromLists
    {
        // EXCEL----------!%_%_%_%_%_%_%_%_%_%_%_%_%_%_%_%_%_%__%_%_

        public MkitFile CreateExcel<T>(string title, IList<T> list, IWebHostEnvironment _appEnv)
        {
            // Тип файла - content-type
            string file_type = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            // Имя файла
            string file_name = title + "_" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss'-'ff") + ".xlsx";

            // Путь к файлу
            string file_path = Path.Combine(_appEnv.ContentRootPath, "wwwroot/DownloadFiles/" + file_name);


            // Создать Excel файл
            CreateSpreadsheetWorkbook(file_path);

            // Заполнить Excel файл
            DataSet mkitDataset = new DataSet("mkitDataset");
            mkitDataset.Tables.Add(ToDataTable<T>(list));
            ExportDataSet(mkitDataset, file_path);


            // отправка байтов
            byte[] mas = System.IO.File.ReadAllBytes(file_path);

            MkitFile file = new MkitFile();

            file.Name = file_name;
            file.Type = file_type;
            file.Path = file_path;
            file.Bytes = mas;

            // удаление созданного файла, т.к. незачем хранить это, и заполнять память по экспоненте
            FileInfo fileInf = new FileInfo(file_path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }

            return file;
        }


        private void ExportDataSet(DataSet ds, string destination)
        {
            using (var workbook = SpreadsheetDocument.Create(destination, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();

                workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();

                foreach (System.Data.DataTable table in ds.Tables)
                {

                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                    uint sheetId = 1;
                    if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                    {
                        sheetId =
                            sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                    }

                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = table.TableName };
                    sheets.Append(sheet);

                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                    List<String> columns = new List<string>();
                    foreach (System.Data.DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);

                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                        headerRow.AppendChild(cell);
                    }


                    sheetData.AppendChild(headerRow);

                    foreach (System.Data.DataRow dsrow in table.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        foreach (String col in columns)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(dsrow[col].ToString()); //
                            newRow.AppendChild(cell);
                        }

                        sheetData.AppendChild(newRow);
                    }

                }
            }
        }


        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void CreateSpreadsheetWorkbook(string filepath)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Таблица1"
            };
            sheets.Append(sheet);

            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
        }

        // PDF------------!%_%_%_%___%_%_%_%_%_%_%_%_%_%_%_%_%_%_%_
        public void CreatePdfFromHtml(string html, string file_path)
        {

            HtmlConverter.ConvertToPdf(html, new FileStream(file_path, FileMode.Create));
        }

        public MkitFile CreatePdf(string title, string html, IWebHostEnvironment _appEnv)
        {
            // Тип файла - content-type
            string file_type = "application/pdf";

            // Имя файла
            string file_name = title + "_" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss'-'ff") + ".pdf";

            // Путь к файлу
            string file_path = Path.Combine(_appEnv.ContentRootPath, "wwwroot/DownloadFiles/" + file_name);

            CreatePdfFromHtml(html, file_path);

            // отправка байтов
            byte[] mas = System.IO.File.ReadAllBytes(file_path);

            MkitFile file = new MkitFile();

            file.Name = file_name;
            file.Type = file_type;
            file.Path = file_path;
            file.Bytes = mas;

            // удаление созданного файла, т.к. незачем хранить это, и заполнять память по экспоненте
            FileInfo fileInf = new FileInfo(file_path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }

            return file;
        }

    }
}

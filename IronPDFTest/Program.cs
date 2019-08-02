using System;
using IronPdf;


namespace IronPDFTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Get the path for the original empty form. Hardcode this if it doesnt work for you.
            var formsPath = System.IO.Path.GetFullPath(@"..\..\..\Forms");
            var pdf = PdfDocument.FromFile($"{formsPath}\\InvoiceForm.pdf");


            
            //Fill the form fields with junk values
            pdf.Form.GetFieldByName("TaxID").Value = "TESTVALUE";

            pdf.Form.GetFieldByName("FromContactName").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("FromName").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("FromAddress").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("FromRestOfAddress").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("FromPhone").Value = "TESTVALUE";

            pdf.Form.GetFieldByName("WaybillNumber").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("ShipmentID").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("Date").Value = DateTime.Now.ToString("dd/MMM/yyyy");

            pdf.Form.GetFieldByName("ShipToContactName").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("ShipToName").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("ShipToAddress").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("ShipToRestOfAddress").Value = "TESTVALUE";
            pdf.Form.GetFieldByName("ShipToPhone").Value = "TESTVALUE";

            pdf.SaveAs($"{formsPath}\\FilledOutForm.pdf");

            Console.WriteLine("Form filled and saved as FilledOutForm.pdf");
        }
    }
}

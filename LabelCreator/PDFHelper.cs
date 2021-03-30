using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.IO;
using iTextSharp.text.pdf;

public class PDFHelper
{

    public static byte[] GeneratePDF(string pdfPath, Dictionary<string, string> formFieldMap)
    {
        var output = new MemoryStream();
        var reader = new PdfReader(pdfPath);
        var stamper = new PdfStamper(reader, output);
        var formFields = stamper.AcroFields;

        foreach (var fieldName in formFieldMap.Keys)
            formFields.SetField(fieldName, formFieldMap[fieldName]);

        stamper.FormFlattening = true;
        stamper.Close();
        reader.Close();

        return output.ToArray();
    }
}
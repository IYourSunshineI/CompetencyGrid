using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using Font = iTextSharp.text.Font;

namespace CompetencyGrid.Classes {
    public static class Printer {

        static string calibriNormalPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\calibri.ttf";
        static BaseFont calibri = BaseFont.CreateFont(calibriNormalPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        static Font calibriNormal = new Font(calibri, 10, Font.NORMAL, BaseColor.BLACK);
        static Font calibriBold = new Font(calibri, 12, Font.BOLD, BaseColor.BLACK);
        static Font calibriHeader = new Font(calibri, 11, Font.NORMAL, BaseColor.BLACK);
        //static Font calibriDef = FontFactory.GetFont("Calibri Regular", 10);
        //static Font calibriBold = FontFactory.GetFont("Calibri Regular", BaseFont.CP1252, BaseFont.EMBEDDED, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
        //static Font calibriHeader = FontFactory.GetFont("Calibri Regular", 11);
        static string windingsPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\wingding.ttf";
        static BaseFont windings = BaseFont.CreateFont(windingsPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        static Font windingsNormal = new Font(windings, 15, Font.NORMAL, BaseColor.BLACK);

        public static void printToPDF(string folderName, Template template) {

            if (!Directory.Exists(folderName)) {
                Directory.CreateDirectory(folderName);
            }

            Document doc = new Document();
            try {
                PdfWriter.GetInstance(doc, new FileStream(folderName + "/" + template.getName() + ".pdf", FileMode.Create));
                doc.Open();

                Paragraph p = new Paragraph(template.getHeader(), calibriHeader);
                p.SpacingAfter = 15f;
                doc.Add(p);

                p = new Paragraph(template.getDescription(), calibriBold);
                p.SpacingAfter = 15f;
                doc.Add(p);

                //creating Subject with corresponding competencies and table
                List<Subject> subjects = template.getSubjects();
                foreach (Subject s in subjects) {
                    p = new Paragraph(s.getName().ToUpper(), calibriBold);
                    p.SpacingAfter = 4f;
                    doc.Add(p);

                    //Table setup
                    PdfPTable table = new PdfPTable(4);

                    //fix absolute width of table
                    table.WidthPercentage = 100;
                    //table.LockedWidth = true;

                    //relative col widths
                    float[] widths = new float[] { 17f, 1f, 1f, 1f };
                    table.SetWidths(widths);
                    table.HorizontalAlignment = 0;
                    table.DefaultCell.VerticalAlignment = 0;
                    table.DefaultCell.Padding = 5;
                    table.DefaultCell.MinimumHeight = 22.5f;
                    //-------------------

                    List<string> competencies = s.getCompetencies();
                    foreach (string c in competencies) {
                        p = new Paragraph(c, calibriNormal);
                        table.AddCell(p);

                        p = new Paragraph(((char)0xFC).ToString(), windingsNormal);
                        table.AddCell(p);
                        table.AddCell(p);
                        table.AddCell(p);
                    }
                    table.SpacingAfter = 10f;
                    doc.Add(table);
                }
            } catch (DocumentException e) {
                doc.Close();
                Console.Error.WriteLine(e.ToString());
            } catch (IOException e) {
                doc.Close();
                Console.Error.WriteLine(e.ToString());
            } finally {
                doc.Close();
            }
        }

        public static void printToPDF(string folderName, CompetencyForm form) { }
    }
}

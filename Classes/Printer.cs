using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;

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
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(folderName + "/" + template.getName() + ".pdf", FileMode.Create));
                doc.Open();
                doc.SetMargins(doc.LeftMargin, doc.RightMargin, 80, doc.BottomMargin);
                //add header on each page
                writer.PageEvent = new Header(template.getHeader(), calibriHeader);

                Paragraph p = new Paragraph("\n" + template.getDescription(), calibriBold);
                p.SpacingAfter = 15f;
                doc.Add(p);

                //creating Subject with corresponding competencies and table
                List<Subject> subjects = template.getSubjects();
                for (int index = 0; index < subjects.Count; index++) {
                    Subject s = subjects[index];
                    Paragraph SubjectParagraph = new Paragraph(s.getName().ToUpper(), calibriBold);

                    //Table setup
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    float[] widths = new float[] { 17f, 1f, 1f, 1f };
                    table.SetWidths(widths);
                    table.HorizontalAlignment = 0;
                    table.DefaultCell.VerticalAlignment = 0;
                    table.DefaultCell.Padding = 5;
                    table.DefaultCell.MinimumHeight = 22.5f;
                    table.KeepTogether = true;
                    //-------------------
                    PdfPCell cell = new PdfPCell(SubjectParagraph);
                    cell.FixedHeight = 20;
                    cell.Colspan = 4;
                    cell.Border = 0;
                    table.AddCell(cell);

                    List<Subject> subS = s.getSubSections();
                    if (subS == null) {
                        buildTable(s, table, false);
                    } else {
                        foreach (Subject sub in subS) {
                            buildTable(sub, table, true);
                        }
                    }
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

        private static void buildTable(Subject s, PdfPTable table, bool subSection) {
            List<string> competencies = s.getCompetencies();
            foreach (string c in competencies) {
                Paragraph p;
                if (subSection) {
                    PdfPCell cell = new PdfPCell(new Paragraph(s.getName(), calibriNormal));
                    cell.Colspan = 4;
                    cell.Border = 0;
                    table.AddCell(cell);
                }
                p = new Paragraph(c, calibriNormal);
                table.AddCell(p);

                p = new Paragraph(((char)0xFC).ToString(), windingsNormal);
                table.AddCell(p);
                table.AddCell(p);
                table.AddCell(p);
            }
            table.SpacingAfter = 10f;
        }
    }
}

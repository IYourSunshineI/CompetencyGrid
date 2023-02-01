using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using Paragraph = iTextSharp.text.Paragraph;

namespace CompetencyGrid.Classes {
    public static class Printer {

        static string calibriNormalPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\calibri.ttf";
        static BaseFont calibri = BaseFont.CreateFont(calibriNormalPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        static Font calibriNormal = new Font(calibri, 10, Font.NORMAL, BaseColor.BLACK);
        static Font calibriBold = new Font(calibri, 12, Font.BOLD, BaseColor.BLACK);
        static Font calibriHeader = new Font(calibri, 11, Font.NORMAL, BaseColor.BLACK);
        static string windingsPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\wingding.ttf";
        static BaseFont windings = BaseFont.CreateFont(windingsPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        static Font windingsNormal = new Font(windings, 15, Font.NORMAL, BaseColor.BLACK);

        static private bool isTemplate = false;

        public static void printToPDF(string folderName, MyDocument myDocument) {
            if (myDocument.GetType() == typeof(Template)) {
                isTemplate = true;
            } else {
                isTemplate = false;
            }

            if (!Directory.Exists(folderName)) {
                Directory.CreateDirectory(folderName);
            }

            Document doc = new Document();
            try {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(folderName + "/" + myDocument.getName() + ".pdf", FileMode.Create));
                doc.Open();
                doc.SetMargins(doc.LeftMargin, doc.RightMargin, 80, doc.BottomMargin);
                //add header on each page
                writer.PageEvent = new Header(myDocument.getHeader(), calibriHeader);

                PdfPTable table;
                float[] widths;
                PdfPCell cell;
                Paragraph p = new Paragraph("\n" + myDocument.getDescription(), calibriBold);
                p.SpacingAfter = 15f;
                doc.Add(p);

                //creating Subject with corresponding competencies and table
                List<Subject> subjects = myDocument.getSubjects();
                for (int index = 0; index < subjects.Count; index++) {
                    Subject s = subjects[index];
                    Paragraph subjectParagraph = new Paragraph(s.getName().ToUpper(), calibriBold);

                    //Table setup
                    table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    widths = new float[] { 17f, 1f, 1f, 1f };
                    table.SetWidths(widths);
                    table.HorizontalAlignment = 0;
                    table.DefaultCell.VerticalAlignment = 0;
                    table.DefaultCell.Padding = 5;
                    table.DefaultCell.MinimumHeight = 22.5f;
                    table.KeepTogether = true;
                    //-------------------
                    cell = new PdfPCell(subjectParagraph);
                    cell.FixedHeight = 20;
                    cell.Colspan = 4;
                    cell.Border = 0;
                    table.AddCell(cell);


                    List<Subject> subS = s.getSubSections();
                    if (subS == null) {
                        buildTable(s, table);
                        doc.Add(table);
                    } else {
                        doc.Add(table);
                        foreach (Subject sub in subS) {
                            PdfPTable temp = buildSubTable(sub);
                            doc.Add(temp);
                        }
                    }
                }
                // add foot stuff ;)
                addFooter(doc, myDocument.getOrt());
                doc.Close();
            } catch (DocumentException e) {
                doc.Close();
                Console.Error.WriteLine(e.ToString());
            } catch (IOException e) {
                doc.Close();
                Console.Error.WriteLine(e.ToString());
            }
        }

        private static void buildTable(Subject s, PdfPTable table) {
            List<string> competencies = s.getCompetencies();
            foreach (string c in competencies) {
                Paragraph p;
                p = new Paragraph(c, calibriNormal);
                table.AddCell(p);

                p = new Paragraph(((char)0xFC).ToString(), windingsNormal);
                int score = 0;
                if (isTemplate)
                    score = 3;
                else {
                    try {
                        score = s.getCompScore(c);
                    } catch (KeyNotFoundException e) {
                        Console.Error.WriteLine(e.ToString());
                    }
                }
                for (int i = 0; i < 3 - score; i++) {
                    table.AddCell(" ");
                }
                for (int i = 0; i < score; i++) {
                    table.AddCell(p);
                }
            }
            List<string> opt = s.getOptionalSpecifications();
            if (opt != null && opt.Count > 0) {
                PdfPCell cell = new PdfPCell(new Paragraph("Zu den folgenden Themen hast du gearbeitet:", calibriNormal));
                cell.Colspan = 4;
                cell.Border = 0;
                table.AddCell(cell);
                foreach (string o in opt) {
                    cell = new PdfPCell(new Paragraph(o, calibriNormal));
                    cell.MinimumHeight = 22.5f;
                    cell.Padding = 5;
                    table.AddCell(cell);
                    cell = new PdfPCell();
                    cell.Border = 0;
                    table.AddCell(cell);
                    table.AddCell(cell);
                    table.AddCell(cell);
                }
            }
            table.SpacingAfter = 10f;
        }

        private static PdfPTable buildSubTable(Subject s) {
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            float[] widths = new float[] { 17f, 1f, 1f, 1f };
            table.SetWidths(widths);
            table.HorizontalAlignment = 0;
            table.DefaultCell.VerticalAlignment = 0;
            table.DefaultCell.Padding = 5;
            table.DefaultCell.MinimumHeight = 22.5f;
            table.KeepTogether = true;

            PdfPCell cell = new PdfPCell(new Paragraph(s.getName(), calibriNormal));
            cell.Colspan = 4;
            cell.Border = 0;
            table.AddCell(cell);
            buildTable(s, table);
            return table;
        }

        private static void addFooter(Document doc, string ort) {
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            float[] widths = new float[] { 1.1f, 1.5f, 1.5f, 1.1f };
            table.SetWidths(widths);
            table.HorizontalAlignment = 0;
            table.DefaultCell.VerticalAlignment = 0;
            table.DefaultCell.Padding = 5;
            table.DefaultCell.MinimumHeight = 22.5f;
            table.KeepTogether = true;
            //-------------------
            PdfPCell cell = new PdfPCell(new Paragraph("\nDie angeführten Kompetenzen wurden", calibriBold));
            cell.Colspan = 4;
            cell.Border = 0;
            table.AddCell(cell);

            Chunk chunk = new Chunk(((char)0xFC).ToString(), windingsNormal);
            Paragraph p = new Paragraph();
            p.Add(chunk);
            p.Add(new Paragraph(" selten, teilweise", calibriNormal));
            cell = new PdfPCell(p);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            table.AddCell(cell);

            p = new Paragraph();
            p.Add(chunk);
            p.Add(chunk);
            p.Add(new Paragraph(" wechselnd, überwiegend", calibriNormal));
            cell = new PdfPCell(p);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            table.AddCell(cell);

            p = new Paragraph();
            p.Add(chunk);
            p.Add(chunk);
            p.Add(chunk);
            p.Add(new Paragraph(" häufig, meistens", calibriNormal));
            cell = new PdfPCell(p);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Paragraph("erreicht.", calibriNormal));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 7;
            cell.Border = 0;
            table.AddCell(cell);
            //----------------------------
            //empty row
            cell = new PdfPCell();
            cell.Colspan = 4;
            cell.FixedHeight = 50;
            cell.Border = 0;
            table.AddCell(cell);
            //----------------------------
            p = new Paragraph();
            p.Leading = 10;
            Phrase spacer = new Phrase("\n----------------------------------", calibriNormal);
            Phrase phrase = new Phrase(ort + ", am " + DateTime.Now.ToString("dd.MM.yyyy"), calibriNormal);
            p.Add(phrase);
            p.Add(spacer);
            phrase = new Phrase("\nDatum", calibriNormal);
            p.Add(phrase);
            cell = new PdfPCell(p);
            cell.Border = 0;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            p = new Paragraph();
            p.Leading = 10;
            if (Directory.Exists("Images")) {
                Image img = Image.GetInstance("Images/Graxn.jpg");
                img.ScaleAbsolute(157, 52);
                p.Add(new Chunk(img, 0, 0, true));
            }
            p.Add(spacer);
            phrase = new Phrase("\nSchulleitung", calibriNormal);
            p.Add(phrase);
            cell = new PdfPCell(p);
            cell.Border = 0;
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            p = new Paragraph();
            p.Leading = 10;
            p.Add(spacer);
            phrase = new Phrase("\nKlassenlehrer/in", calibriNormal);
            p.Add(phrase);
            cell = new PdfPCell(p);
            cell.Border = 0;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            doc.Add(table);
        }
    }
}

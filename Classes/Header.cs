using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyGrid.Classes {
    internal class Header : PdfPageEventHelper {

        private string header;
        private Font font;

        public Header(string header, Font font) {
            this.header = header;
            this.font = font;
        }
        public override void OnEndPage(PdfWriter writer, Document document) {
            PdfPTable table = new PdfPTable(1);
            table.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin; //this centers [table]

            //title
            PdfPCell cell = new PdfPCell(new Phrase(header, font));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            table.AddCell(cell);

            table.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.Height - 36, writer.DirectContent);
        }
    }
}

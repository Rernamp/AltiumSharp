
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchSheetFileName : SchGraphicalObject {
        public override int Record => 33;
        public int FontId { get; set; }
        public string Text { get; set; }
        public string UniqueId { get; set; }
        

        public SchSheetFileName() {
        }


        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            FontId = p["FONTID"].AsIntOrDefault();
            UniqueId = p["UNIQUEID"].AsStringOrDefault();
            Text = p["TEXT"].AsStringOrDefault();
        }

    }
}

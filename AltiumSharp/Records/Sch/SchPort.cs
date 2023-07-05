
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchPort : SchGraphicalObject {
        public override int Record => 18;
        public int FontId { get; set; }
        public string Name { get; set; }
        public string HarnessType { get; set; }
        public string UniqueId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color TextColor { get; set; }


        public SchPort() {
        }


        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            FontId = p["FONTID"].AsIntOrDefault();
            UniqueId = p["UNIQUEID"].AsStringOrDefault();
            Name = p["Name"].AsStringOrDefault();
            HarnessType = p["HarnessType"].AsStringOrDefault();
            Width = p["Width"].AsIntOrDefault();
            Height = p["Height"].AsIntOrDefault();
            TextColor = p["TEXTCOLOR"].AsColorOrDefault();
        }

    }
}

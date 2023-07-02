
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchSheetEntry : SchGraphicalObject {
        public override int Record => 16;
        public string UniqueId { get; set; }
        public Color TextColor { get; set; }
        public Color Color { get; set; }
        public Color AreaColor { get; set; }
        public int TextFontID { get; set; }
        public string TextStyle { get; set; }
        public string ArrowKind { get; set; }
        public string Name { get; set; }
        public int IOType { get; set; }

        public SchSheetEntry() {
        }


        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UNIQUEID"].AsStringOrDefault();
            TextColor = p["TEXTCOLOR"].AsColorOrDefault();
            Color = p["COLOR"].AsColorOrDefault();
            AreaColor = p["AREACOLOR"].AsColorOrDefault();
            TextFontID = p["TextFontID"].AsIntOrDefault();
            TextStyle = p["TextStyle"].AsStringOrDefault();
            Name = p["NAME"].AsStringOrDefault();
            ArrowKind = p["ArrowKind"].AsStringOrDefault();
            IOType = p["IOType"].AsIntOrDefault();
        }

    }
}

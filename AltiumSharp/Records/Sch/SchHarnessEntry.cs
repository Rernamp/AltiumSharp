
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchHarnessEntry : SchPrimitive {
        public enum Side : int {
            Left = 0,
            Right = 1,
            Top = 2,
            Bottom = 3
        }
        public override int Record => 216;
        public string UniqueId { get; set; }
        public bool OwnerIndexAdditionalList { get; set; }
        public Side SideOfEntry { get; set; }
        public Color Color { get; set; }
        public Color AreaColor { get; set; }
        public int TextFontID { get; set; }
        public string TextStyle { get; set; }
        public string Name { get; set; }
        public int DistanceFromTop { get; set; }
        public int DistanceFromTop_Frac1 { get; set; }



        public SchHarnessEntry() : base() {
        }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
            OwnerIndexAdditionalList = p["OwnerIndexAdditionalList"].AsBool();
            SideOfEntry = p["Side"].AsEnumOrDefault<Side>();
            Color = p["COLOR"].AsColorOrDefault();
            AreaColor = p["AREACOLOR"].AsColorOrDefault();
            TextFontID = p["TextFontID"].AsIntOrDefault();
            TextStyle = p["TextStyle"].AsStringOrDefault();
            Name = p["NAME"].AsStringOrDefault();
            DistanceFromTop = p["DistanceFromTop"].AsIntOrDefault();
            DistanceFromTop_Frac1 = p["DistanceFromTop_Frac1"].AsIntOrDefault();
        }

    }
}

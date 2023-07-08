
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchBus : SchGraphicalObject {
        public override int Record => 26;
        public bool IsSolid { get; set; }
        public LineWidth LineWidth { get; set; }
        public List<CoordPoint> Vertices { get; set; } = new List<CoordPoint>();
        public string UniqueId { get; set; }


        public SchBus() : base() {
            LineWidth = LineWidth.Small;
        }

        public override CoordRect CalculateBounds() =>
            new CoordRect(
                new CoordPoint(Vertices.Min(p => p.X), Vertices.Min(p => p.Y)),
                new CoordPoint(Vertices.Max(p => p.X), Vertices.Max(p => p.Y)));

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            IsSolid = p["ISSOLID"].AsBool();
            LineWidth = p["LINEWIDTH"].AsEnumOrDefault<LineWidth>();
            Vertices = Enumerable.Range(1, p["LOCATIONCOUNT"].AsInt())
                .Select(i => new CoordPoint(
                    Utils.DxpFracToCoord(p[$"X{i}"].AsIntOrDefault(), p[$"X{i}_FRAC"].AsIntOrDefault()),
                    Utils.DxpFracToCoord(p[$"Y{i}"].AsIntOrDefault(), p[$"Y{i}_FRAC"].AsIntOrDefault())))
                .ToList();
            UniqueId = p["UniqueID"].AsStringOrDefault();
        }

    }
}

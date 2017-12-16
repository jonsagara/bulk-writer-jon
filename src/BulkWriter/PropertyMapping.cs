namespace BulkWriter
{
    public class PropertyMapping
    {
        public bool ShouldMap { get; set; }

        public MappingSource Source { get; set; }

        public MappingDestination Destination { get; set; }

        public override string ToString() => $"Destination: {Destination.ColumnName}; ShouldMap: {ShouldMap}; SrcOrd: {Source.Ordinal}; DestOrd: {Destination.ColumnOrdinal}";
    }
}
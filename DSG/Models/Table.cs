
namespace DSRG.Models
{
    public class Table
    {
        public string TableName { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string PropertyLeangth { get; set; }
        public string PropertyPrecision { get; set; }
        public string PropertyScale { get; set; }
        public string ColumnDefault { get; set; }
        public string IsNullable { get; set; }
        public string ConstraintName { get; set; }
    }
}


namespace DSG.Models
{
    using System;

    public class Trigger
    {
        public string TableName { get; set; }
        public string TrigerName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Text { get; set; }
    }
}

using System.Data;

namespace Apteka
{
    internal class PhapmDataSetMed
    {
        internal string DataSetName;
        internal SchemaSerializationMode SchemaSerializationMode;

        public PhapmDataSet.MedicamentsDataTable Medicaments { get; internal set; }
    }
}
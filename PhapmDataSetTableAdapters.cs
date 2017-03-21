using System;
using PhapmDataSet;

namespace Apteka
{
    internal class PhapmDataSetTableAdapters
    {
        internal class MedicamentsTableAdapter
        {
            public MedicamentsTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }

            internal void Fill()
            {
                throw new NotImplementedException();
            }

            internal void FillBy1(MedicamentsDataTable medicaments)
            {
                throw new NotImplementedException();
            }

            internal void FillBy(MedicamentsDataTable medicaments)
            {
                throw new NotImplementedException();
            }
        }
    }
}
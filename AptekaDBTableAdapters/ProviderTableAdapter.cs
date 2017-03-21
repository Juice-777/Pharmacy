using System;

namespace Apteka.AptekaDBTableAdapters
{
    internal class ProviderTableAdapter
    {
        public bool ClearBeforeFill { get; internal set; }

        internal void Fill(object provider)
        {
            throw new NotImplementedException();
        }
    }
}
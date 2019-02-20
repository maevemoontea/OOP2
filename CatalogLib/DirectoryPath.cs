using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLib
{
    public abstract class DirectoryPath
    {
        private protected string name;
        private protected string lookupPath;
        private protected string resultPath;

        public abstract void Paste();

        public DirectoryPath(string lookup, string result)
        {
            lookupPath = lookup;
            resultPath = result;
        }
    }
}

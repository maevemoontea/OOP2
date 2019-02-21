
namespace CatalogLib
{
    public abstract class DirectoryPath
    {
        private protected string name;
        private protected string lookupPath;
        private protected string resultPath;

        public string Name { get { return name; } }
        public string OriginPath { get { return lookupPath; } }
        public string NewParentPath { get { return resultPath; } }

        public abstract void Paste();

        public DirectoryPath(string lookup, string result)
        {
            lookupPath = lookup;
            resultPath = result;
        }
    }
}

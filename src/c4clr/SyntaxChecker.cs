namespace c4clr
{
    using System.IO;

    internal class SyntaxChecker
    {
        private Stream inputStream;

        public SyntaxChecker(string fileName)
            : this(new FileStream(fileName, FileMode.Open))
        {
        }

        public SyntaxChecker(Stream inputStream)
        {
            this.inputStream = inputStream;
        }

        public bool Parse()
        {
            return true;
        }
    } 
}
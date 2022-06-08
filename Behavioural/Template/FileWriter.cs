using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class FileWriter
    {
        protected string path = null;
        protected abstract void DecryptFile();
        protected virtual void AppendFile(string data)
        {
            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                    tw.Write(data);
            }
        }
        protected abstract void EncryptFile();
        public void Append(string data)
        {
            DecryptFile();
            AppendFile(data);
            EncryptFile();
        }
    }
}

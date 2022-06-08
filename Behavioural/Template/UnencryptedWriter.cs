using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class UnencryptWriter : FileWriter
    {
        public UnencryptWriter(string path)
        {
            this.path = path;
        }

        protected override void DecryptFile()
        {
            
        }

        protected override void EncryptFile()
        {
            
        }
    }
}

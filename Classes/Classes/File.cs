using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }

        void Compress();
    }
}

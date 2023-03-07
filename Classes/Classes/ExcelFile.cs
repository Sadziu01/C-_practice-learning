using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ExcelFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get ; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing ExcekFile.");
        }

        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report..");
        }
    }
}

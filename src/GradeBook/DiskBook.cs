using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    public class DiskBook : Book
    {
        public DiskBook(string diskName):base(diskName)
        {
            DiskName = diskName;
        }
        public string DiskName { get; set; }

        public string Name => throw new NotImplementedException();


        public override void AddGrade(double grade)
        {
            var writer = File.AppendText($"{Name}.txt");
            writer.WriteLine(grade);
        }

        public override Statistics GetStatistic()
        {
            throw new NotImplementedException();
        }
    }
}

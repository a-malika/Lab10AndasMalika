using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            File file1 = new File("SecterniyParol");
            File file2 = new File("LubovnoePismo");

            Directory main = new Directory("home");
            Directory dir1 = new Directory("ShPP");
            Directory dir2 = new Directory("CS");

            main.Add(dir1);
            main.Add(dir2);
            main.Add(file1);
            main.Add(file2);

            dir1.Add(new File("Lab1_ShPP"));
            dir1.Add(new File("Lab2_ShPP"));
            dir1.Add(new File("Lab3_ShPP"));
            dir1.Add(new File("Lab4_ShPP"));

            dir2.Add(new File("Lab1_CS"));
            dir2.Add(new File("Lab2_CS"));
            dir2.Add(new File("Lab3_CS"));

            main.Display(0);
        }
    }
}

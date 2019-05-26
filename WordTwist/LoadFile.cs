using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTwist
{
    class LoadFile
    {
        public static ArrayList Load(string file)
        {
            ArrayList array = new ArrayList();
            string line;
            System.IO.StreamReader MyReader;
            MyReader = new StreamReader(file);
            line = MyReader.ReadLine();
            while (line != null)
            {
                array.Add(line.ToString());
                line = MyReader.ReadLine();
            }
            MyReader.Close();
            return array;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    class Program
    {
        ArrayList nodeList = new ArrayList();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.LoadData();
            for(int i =0; i<2; i++)
            {
                p.SaveInfo();
            }
        }

        
        public void LoadData()
        {
            /* 
             * Make sure the nodeList is Empty  
             */
            nodeList.Clear();
            string line;
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    DataAttributes da = new DataAttributes();
                    string[] values = line.Split(',');

                    da.a1 = Int32.Parse(values[0]);
                    da.a2 = Int32.Parse(values[1]);
                    da.a3 = Int32.Parse(values[2]);
                    da.a4 = Int32.Parse(values[3]);
                    da.a5 = Int32.Parse(values[4]);

                    da.a6 = Double.Parse(values[5]);
                    da.a7 = Double.Parse(values[6]);

                    da.a8 = Int32.Parse(values[7]);
                    da.a9 = Int32.Parse(values[8]);

                    //Store it in nodeList 
                    nodeList.Add(da);
                }
            }
        }

        public void SaveInfo()
        {
            using (StreamWriter sw = new StreamWriter("data.csv", append: true))
            {
                foreach (DataAttributes da in nodeList)
                {
                    sw.WriteLine(da.a1 + "," + da.a2 + "," + da.a3 + "," + da.a4 +
                    "," + da.a5 + "," + da.a6 + "," + da.a7 + "," + da.a8 + "," +
                    da.a9);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop
{
    internal interface Cars
    {

        public void AddData(string name, string id, string color, int model, double price);
        public  String[] ShowData();

        public string searchModel(int model);
    }
}

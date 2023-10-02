using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project_oop
{
    internal class Mercedes : Cars
    {
        string Name { get; set; }
        string ID { get; set; }
        string color { get; set; }
        double price { get; set; }
        int model { get; set; }
   

        public void AddData(string name, string id, string color, int model, double price)
        {
            var mercedes = new Mercedes
            {
                Name = name,
                ID = id,
                color = color,
                price = price,
                model = model,
            };
            File.AppendAllText("Mercedes.txt", "Name of car : " + mercedes.Name + "," + "ID of car : " + mercedes.ID + "," +
               "Color of car : " + mercedes.color + "," + "Price of car : " + mercedes.price + "," +
               "Model of car : " + mercedes.model + " END");
        }

        public string[] ShowData()
        {
            string reData = File.ReadAllText("Mercedes.txt");
            return reData.Split("END");
        }
        public string searchModel(int model)
        {
            string[] check = ShowData();
            for (int i = 0; i < check.Length; i++)
            {
                string myPart = "";
                try
                {
                    myPart = check[i].Substring(check[i].Length - 5, check[i].IndexOf(" "));
                }
                catch
                {

                    return "Not Found";
                }
                int myModel = int.Parse(myPart);
                if (model == myModel)
                {
                    return "Found";
                }
            }
            return "Not Found";
        }
    }
}

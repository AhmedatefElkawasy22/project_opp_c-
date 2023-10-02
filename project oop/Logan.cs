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
    internal class Logan : Cars
    {
        string Name { get; set; }
        string ID { get; set; }
        string color { get; set; }
        double price { get; set; }
        int model { get; set; }
        public void AddData(string name, string id, string color, int model, double price)
        {
            var logan = new Logan
            {
                Name = name,
                ID = id,
                color = color,
                price = price,
                model = model,
            };
            File.AppendAllText("Logan.txt", "Name of car : " + logan.Name + "," + "ID of car : " + logan.ID + "," +
               "Color of car : " + logan.color + "," + "Price of car : " + logan.price + "," +
               "Model of car : " + logan.model + " END");
        }
        public string[] ShowData()
        {
            string reData = File.ReadAllText("Logan.txt");
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

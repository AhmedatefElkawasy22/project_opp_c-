using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_oop
{
    internal class BMW : Cars
    {

        string Name { get; set; }
        string ID { get; set; }
        string color { get; set; }
        double price { get; set; }
        int model { get; set; }
        public  void AddData(string name, string id, string color, int model, double price)
        {
            var bmw = new BMW
            {
                Name = name,
                ID = id,
                color = color,
                price = price,
                model = model,
            };
            File.AppendAllText("BMW.txt", "Name of car : " + bmw.Name + "," + "ID of car : " + bmw.ID + "," +
               "Color of car : " + bmw.color + "," + "Price of car : " + bmw.price + "," +
               "Model of car : " + bmw.model + " END");
        }

        public string[] ShowData()
        {
            string reData = File.ReadAllText("BMW.txt");
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
                catch {

                    return "Not Found";
                }
                int myModel=int.Parse(myPart);
                if (model==myModel)
                {
                    return "Found";
                }
            }
            return "Not Found";
        }

    }
}

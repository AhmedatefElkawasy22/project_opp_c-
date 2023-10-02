namespace project_oop
{
    internal class Program
    {
        static void checkModel(int model)
        {
            Console.WriteLine("Enter Type of car\n" +
                              "BMW      :write 1\n" +
                              "Hyundai  :write 2\n" +
                              "Logan    :write 3\n" +
                              "Marcedes :write 4");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    BMW B = new BMW();
                    Console.WriteLine(B.searchModel(model));
                    break;
                case 2:
                    Hyundai H = new Hyundai();
                    Console.WriteLine(H.searchModel(model));

                    break;
                case 3:
                    Logan L = new Logan();
                    Console.WriteLine(L.searchModel(model));

                    break;
                case 4:
                    Mercedes M = new Mercedes();
                    Console.WriteLine(M.searchModel(model));

                    break;
                default:
                    Console.WriteLine("unfound option");
                    break;
            }
            // return
        }
        static void Main(string[] args)
        {
            var Bm = new BMW();
            string agine = "";
            do
            {
                Console.Clear();
                Console.WriteLine("<***list of options***>");
                Console.WriteLine("Add to BMW            : write 1 \n" +
                                  "Add to Hyundai        : write 2 \n" +
                                  "Add to Logan          : write 3 \n" +
                                  "Add to Mercedes       : write 4 \n" +
                                  "show cars of BMW      : write 5 \n" +
                                  "show cars of Hyundai  : write 6 \n" +
                                  "show cars of Logan    : write 7 \n" +
                                  "show cars of Mercedes : write 8 \n" +
                                  "search by model       : write 9 ");
                int option = int.Parse(Console.ReadLine());
                while (option > 9 || option < 1)
                {
                    Console.WriteLine("wrong chose,please enter valed option");
                    option = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                string NameCar = "", IDCar = "", ColorCar = "";
                int modelCar = 0;
                double PriceCar = 0;
                if (option >= 1 && option <= 4)
                {
                    Console.WriteLine("please enter name of car : ");
                    NameCar = Console.ReadLine();
                    Console.WriteLine("please enter ID of car : ");
                    IDCar = Console.ReadLine();
                    Console.WriteLine("please enter color of car : ");
                    ColorCar = Console.ReadLine();
                    Console.WriteLine("please enter price of car : ");
                    PriceCar = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter model of car : ");
                    modelCar = int.Parse(Console.ReadLine());
                    Console.WriteLine("if you need re enter data , please write * yes *,otherwise write * no * : ");
                    string check = Console.ReadLine();
                    if (check == "YES" || check == "yes")
                    {
                        Console.WriteLine("If you want to change name  : write 1\n" +
                                          "If you want to change ID    : write 2\n" +
                                          "If you want to change color : write 3\n" +
                                          "If you want to change price : write 4\n" +
                                          "If you want to change model : write 5\n" +
                                          "If you continue             : write 0");
                        int chose = int.Parse(Console.ReadLine());
                        if (chose >= 1 && chose <= 5)
                        {
                            Console.WriteLine("enter change :");
                        }
                        switch (chose)
                        {
                            case 1:
                                NameCar = Console.ReadLine();
                                break;
                            case 2:
                                IDCar = Console.ReadLine();
                                break;
                            case 3:
                                ColorCar = Console.ReadLine();
                                break;
                            case 4:
                                PriceCar = double.Parse(Console.ReadLine());
                                break;
                            case 5:
                                modelCar = int.Parse(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("DONE :)");
                                break;
                        }
                    }
                }
                switch (option)
                {
                    case 1:
                        var bmw = new BMW();
                        bmw.AddData(NameCar, IDCar, ColorCar, modelCar, PriceCar);
                        break;
                    case 2:
                        Hyundai hyundai = new Hyundai();
                        hyundai.AddData(NameCar, IDCar, ColorCar, modelCar, PriceCar);
                        break;
                    case 3:
                        Logan logan = new Logan();
                        logan.AddData(NameCar, IDCar, ColorCar, modelCar, PriceCar);
                        break;
                    case 4:
                        Mercedes merceds = new Mercedes();
                        merceds.AddData(NameCar, IDCar, ColorCar, modelCar, PriceCar);
                        break;
                    case 5:
                        var B = new BMW();
                        string[] ShowB = B.ShowData();
                        for (int i = 0; i < ShowB.Length; i++)
                        {
                            string[] showB2 = ShowB[i].Split(',');
                            for (int j = 0; j < showB2.Length; j++)
                            {
                                Console.Write($"{showB2[j]}\n");
                            }
                            Console.WriteLine("_____________________________");
                        }
                        break;
                    case 6:
                        var H = new Hyundai();
                        string[] ShowH = H.ShowData();
                        for (int i = 0; i < ShowH.Length; i++)
                        {
                            string[] showH2 = ShowH[i].Split(',');
                            for (int j = 0; j < showH2.Length; j++)
                            {
                                Console.WriteLine(showH2[j]);
                            }
                            Console.WriteLine("_____________________________");
                        }
                        break;
                    case 7:
                        var L = new Logan();
                        string[] ShowL = L.ShowData();
                        for (int i = 0; i < ShowL.Length; i++)
                        {
                            string[] showL2 = ShowL[i].Split(',');
                            for (int j = 0; j < showL2.Length; j++)
                            {
                                Console.WriteLine(showL2[j]);
                            }
                            Console.WriteLine("_____________________________");
                        }
                        break;
                    case 8:
                        var M = new Mercedes();
                        string[] ShowM = M.ShowData();
                        for (int i = 0; i < ShowM.Length; i++)
                        {
                            string[] showM2 = ShowM[i].Split(',');
                            for (int j = 0; j < showM2.Length; j++)
                            {
                                Console.WriteLine(showM2[j]);
                            }
                            Console.WriteLine("_____________________________");
                        }
                        break;
                    case 9:
                        Console.WriteLine("enter model:");
                        int model = int.Parse(Console.ReadLine());
                        checkModel(model);
                        break;

                    default:
                        Console.WriteLine("wrong chose,please enter valed option");
                        break;
                }
                //Console.Clear();
                Console.WriteLine("order you is done :)\nare you need anther order? \n" +
                    "enter * yes * if you need to that, other with enter * no * :");
                agine = Console.ReadLine();
            } while (agine == "YES" || agine == "yes");
        }
    }
}
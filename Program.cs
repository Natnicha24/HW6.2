using System;

namespace HW6._2
{
    class Program
    {
        //คำนวนหารายรับรายจ่ายและเงินคงเหลือ
        enum stableincomeandexpenses
        {
           income=200,
           expenses=70
        }
        struct data
        {
            public string list;
            public double price;
            public int number;
            public double total;
           

        }
            static void Main(string[] args)
        {
            int i,numberoflist=0;
            double output=0;
            Console.WriteLine("INCOME AND EXPENSES ACCOUNT PER DAY\n");

            Console.Write("Input number of goods that you buy : ");
            numberoflist = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            data[] dataarray = new data[numberoflist];
            for (i = 0; i < numberoflist; i++)
            {
                Console.Write("Input name of the goods : ");
                dataarray[i].list = Console.ReadLine();
                Console.Write("Input price of the goods : ");
                dataarray[i].price = double.Parse(Console.ReadLine());
                Console.Write("Input number of the {0} : ",dataarray[i].list);
                dataarray[i].number = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                dataarray[i].total = dataarray[i].number * dataarray[i].price;
            }
            for(int h = 0; h < numberoflist; h++)
            {
                output = output + dataarray[h].total;
            }
            Console.WriteLine("******************");
            Console.WriteLine("TODAY'S ACCOUNT");
            Console.WriteLine("******************");
            Console.WriteLine("Income : +{0}",(int)stableincomeandexpenses.income);
            Console.WriteLine("Stable Expenses : -{0}",(int)stableincomeandexpenses.expenses);
            for(int g = 0; g < numberoflist; g++)
            {
                Console.WriteLine("Buy {0} {1} pieces || Price:{2} per one : -{3}", dataarray[g].list,dataarray[g].number,dataarray[g].price,dataarray[g].total);
            }
            Console.WriteLine("\nIncome : {0}", (int)stableincomeandexpenses.income);
            Console.WriteLine("Expenses : {0}", (int)stableincomeandexpenses.expenses + output);
            Console.WriteLine("Balance :{0}",(int)stableincomeandexpenses.income-((int)stableincomeandexpenses.expenses+output));
            Console.WriteLine("");
        }
            }

        }

   

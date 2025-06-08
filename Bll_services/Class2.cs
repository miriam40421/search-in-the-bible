
using Da_repository;
using DTO_Common_enteties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Bll_services
{


    public class Class2
    {
        //הקובץ
        //List<List<List<Tora>>> books = new List<List<List<Tora>>>();
        //List<List<List<Tora.>>> books = new List<List<List<Tora>>>();
        //public static string[] books = { "", "בראשית", "שמות", "ויקרא", "במדבר", "דברים" };
        public static string fileFromdata()
        {
            string A = Da_repository.Class1.ourfile();
            return A;
        }

        private static List<DTO_Common_enteties.location> Pasuklocations = new List<DTO_Common_enteties.location>();

        private static string Tora;


        public static List<DTO_Common_enteties.location> loc()
        {

            string[] Chumashim = Tora.Split('$');
            for (int i = 1; i < Chumashim.Length; i++)
            {
                string c1 = Chumashim[i].Substring(0, Chumashim[i].IndexOf("^"));
                string[] Parashut = Chumashim[i].Split('^');
                for (int j = 1; j < Parashut.Length; j++)
                {
                    int a1 = Parashut[j].IndexOf("~");
                    int a2 = Parashut[j].IndexOf("!");
                    string c2 = "";
                    if (a1 < a2)
                    {
                        c2 = Parashut[j].Substring(0, a1);
                    }
                    else
                    {
                        c2 = Parashut[j].Substring(0, a2);
                    }

                    string[] Prakim = Parashut[j].Split('~');
                    for (int t = 1; t < Prakim.Length; t++)
                    {
                        string pr1 = Prakim[t].Substring(0, Prakim[t].IndexOf('!'));
                        string[] Psukim = Prakim[t].Split('!');

                        for (int k = 1; k < Psukim.Length; k++)
                        {
                            Pasuklocations.Add(new DTO_Common_enteties.Tora()
                            {
                                Book = c1,
                                Parasha = c2,
                                Perek = pr1,
                                Pasuk = k,
                                Text = Psukim[k],
                            });


                        }

                    }
                }

            }
            string updatedJson = JsonConvert.SerializeObject(Pasuklocations);
            StreamWriter allTora = new StreamWriter(@"D:\C#\TanachProject\Da_repository\bin\Debug\AllTora.json");
            allTora.WriteLine(updatedJson);
            allTora.Close();
            return Pasuklocations;

        }

        public static List<DTO_Common_enteties.Tora> ChangeFromjson()
        {
            string tora = File.ReadAllText(@"D:\C#\TanachProject\Da_repository\bin\Debug\AllTora.json");
            List<DTO_Common_enteties.Tora> text = JsonConvert.DeserializeObject<List<DTO_Common_enteties.Tora>>(tora);
            return text;
        }

        public static List<DTO_Common_enteties.Tora> find(string s)
        {
            List<DTO_Common_enteties.Tora> Tora = ChangeFromjson();
            List<DTO_Common_enteties.Tora> newTora = new List<DTO_Common_enteties.Tora>();
            foreach (var item in Tora)
            {
                if (item.Text.IndexOf(s) != -1)
                {
                    newTora.Add(item);
                }
            }
            return newTora;
        }

        public static List<DTO_Common_enteties.Tora> Chumashfind(string s1, string s2, string s3)
        {
            List<DTO_Common_enteties.Tora> Tora = ChangeFromjson();
            List<DTO_Common_enteties.Tora> newTora1 = new List<DTO_Common_enteties.Tora>();
            List<DTO_Common_enteties.Tora> newTora2= new List<DTO_Common_enteties.Tora>();

            foreach (var item in Tora)
            {
               
                
                    if (item.Text.IndexOf(s1) != -1 && item.Book == s2 + "\r\n"&&(item.Parasha.Contains(s3)))
                    {
                        newTora1.Add(item);
                    }
               
                else if(item.Text.IndexOf(s1) != -1 && item.Book == s2 + "\r\n"&& (item.Parasha.Contains(s3)==false))
                    {
                        newTora2.Add(item);
                    }
                
            }
            if (newTora1.Count > 0)
            {

                return newTora1;
            }
            else
            {
                return newTora2;
            }
        }
        static Class2()
        {
            Tora = Da_repository.Class1.ourfile();
            Pasuklocations = loc();
        }



        public static List<string> Gimatria(string a)
        {
            char[] arrst = { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ך', 'ל', 'מ', 'ם', 'נ', 'ן', 'ס', 'ע', 'פ', 'ף', 'צ', 'ץ', 'ק', 'ר', 'ש', 'ת' };
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 20, 30, 40, 40, 50, 50, 60, 70, 80, 80, 90, 90, 100, 200, 300, 400 };
            string A = Da_repository.Class1.ourfile();
            String[] ArrTora = A.Split(' ');

            if (a.Contains("0")|| a.Contains("1")||a.Contains("2")||a.Contains("3")||a.Contains("4")||a.Contains("5")||a.Contains("6")|| a.Contains("7")||a.Contains("8")||a.Contains("9"))
            {
                int num = int.Parse(a);

               
                //string[] gimatryArr = new string[ArrTora.Length];
                List<string> gimatryArr = new List<string>();
                for (int i = 0; i < ArrTora.Length; i++)
                {
                    int sum = 0;
                    foreach (var item in ArrTora[i])
                    {


                        for (int j = 0; j < arrst.Length; j++)
                        {
                            if (arrst[j] == item)
                                sum += arr[j];
                        }


                    }
                    Boolean flag = false;
                    if (sum == num)
                    {

                        for (int j = 0; j < gimatryArr.Count; j++)
                        {
                            if (ArrTora[i] == gimatryArr[j])
                                flag = true;

                        }
                        if (flag == false) gimatryArr.Add(ArrTora[i]);
                    }
                }
                return gimatryArr;
            }
            else {
                int sum1 = 0;
                foreach (var item in a)
                {


                    for (int j = 0; j < arrst.Length; j++)
                    {
                        if (arrst[j] == item)
                            sum1 += arr[j];
                    }
                }


                    List<string> gimatryArr = new List<string>();
                for (int i = 0; i < ArrTora.Length; i++)
                {
                    int sum2 = 0;
                    foreach (var item in ArrTora[i])
                    {


                        for (int j = 0; j < arrst.Length; j++)
                        {
                            if (arrst[j] == item)
                                sum2+= arr[j];
                        }


                    }
                    Boolean flag = false;
                    if (sum2 == sum1)
                    {

                        for (int j = 0; j < gimatryArr.Count; j++)
                        {
                            if (ArrTora[i] == gimatryArr[j])
                                flag = true;

                        }
                        if (flag == false) gimatryArr.Add(ArrTora[i]);
                    }
                }
                return gimatryArr;

            }

                }
     


    }
}









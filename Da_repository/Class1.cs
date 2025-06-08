namespace Da_repository
{
    public class Class1
    {
     public static string ourfile()
        {
            string s = File.ReadAllText(@"D:\C#\tora.txt");
       return s;
        }
    }
}
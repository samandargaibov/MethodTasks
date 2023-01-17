namespace StringLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ceaser shifrelenme
            //string text = StringTasks.AddString();
            //Console.Write("Key: ");
            //int k = int.Parse(Console.ReadLine());

            //Console.WriteLine("Shiflerenmish hali: " + StringTasks.Ceaser(k, text));
            #endregion

            #region Ceaser Deshifrelenme
            string text1 = StringTasks.AddString();
            Console.Write("Key: ");
            int k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Shiflerenmish hali: " + StringTasks.AntiCeaser(k1, text1));

            #endregion

            #region ZamanFerqi
            //string text1 = StringTasks.AddTime();
            //string text2 = StringTasks.EndTime();

            //Console.WriteLine("Muddet: " + StringTasks.DifferenceTime(text1,text2));
            #endregion
        }
    }
}
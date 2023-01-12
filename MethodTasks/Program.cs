namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArraysTask
            var array = new ArrayTasks();

            int[] y = array.FindSqrtElements();
            array.Print(y);
            #endregion

            #region NumberTasks
            //var number = new NumberTasks();

            //int n= number.EnterNumber();
            //number.Print(n);
            #endregion

        }
    }
}
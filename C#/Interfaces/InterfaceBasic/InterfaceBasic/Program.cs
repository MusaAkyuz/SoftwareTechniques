namespace InterfaceBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file1 = new File();
            File file2 = new File();

            file1.ReadFile();
            file1.WriteFile();
            //file1.SearchDile(); Error

            file2.ReadFile();
            file2.WriteFile();
            file2.SearchFile();

            /////////////////////////////////////////

            ICar car1 = new Car();
            Car car2 = new Car();

            car1.Drive();
            car1.Stop();

            //car2.Drive(); Error
            car2.Stop();
        }
    }
}
namespace MemoryCacheApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryCacheService memoryCacheService = new MemoryCacheService();

            memoryCacheService.AddItemToCache("key1", "value1", 10);
            Console.WriteLine(memoryCacheService.GetItemFromCache("key1"));
            Thread.Sleep(5000);
            Console.WriteLine(memoryCacheService.GetItemFromCache("key1"));
            Thread.Sleep(6000);
        }
    }
}
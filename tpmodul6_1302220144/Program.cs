using tpmodul6_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Fauzan Majid");
        video.PrintVideoDetails();
        video.IncreasePlayCount(10);
        Console.WriteLine();
        video.PrintVideoDetails();
    }
}
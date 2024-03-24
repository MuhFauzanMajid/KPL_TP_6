using tpmodul6_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Fauzan Majid");
        video.PrintVideoDetails();

        //SayaTubeVideo videoNull = new SayaTubeVideo("");
        //video.IncreasePlayCount(100000000);

        for (int i = 0; i < 215; i++)
        {
            video.IncreasePlayCount(10000000);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302220144
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judul_video)
        {
            Random random = new Random();
            
            this.title = judul_video;
            this.id =  random.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video id : "+id);
            Console.WriteLine("Video title : "+title);
            Console.WriteLine("Video play count : "+playCount);
        }
    }
}

using System;
using Assignment_2_Santiago_Leal_Novoa_301093542.Models;

namespace Assignment_2_Santiago_Leal_Novoa_301093542
{
    class Program
    {
        static void Main(string[] args)
        {
            TweetManager.Initialize("0");
            TweetManager.ShowAll();
            TweetManager.ShowAll("Raptors");
        }
    }
}

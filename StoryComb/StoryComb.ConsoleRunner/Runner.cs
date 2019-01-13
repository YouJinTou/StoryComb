using StoryComb.SDK;
using System;

namespace StoryComb.ConsoleRunner
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            var storyGenerator = new StoryGenerator();

            while (true)
            {
                Console.ReadLine();

                Console.WriteLine(storyGenerator.GenerateStory());
            }
        }
    }
}

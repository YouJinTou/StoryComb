using System;

namespace StoryComb.SDK
{
    public class StoryContainer : IStoryContainer
    {
        private readonly string[] characters;
        private readonly string[] goals;
        private readonly string[] twists;

        public StoryContainer(
            string[] characters, string[] goals, string[] twists)
        {
            if (characters == null || characters.Length == 0)
            {
                throw new ArgumentException(nameof(characters));
            }

            if (goals == null || goals.Length == 0)
            {
                throw new ArgumentException(nameof(goals));
            }

            if (twists == null || twists.Length == 0)
            {
                throw new ArgumentException(nameof(twists));
            }

            this.characters = characters;
            this.goals = goals;
            this.twists = twists;
        }

        public string[] Characters => this.characters;

        public string[] Goals => this.goals;

        public string[] Twists => this.twists;
    }
}

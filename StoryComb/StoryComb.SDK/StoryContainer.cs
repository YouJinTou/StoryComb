using System;
using System.Collections.Generic;
using System.Linq;

namespace StoryComb.SDK
{
    public class StoryContainer : IStoryContainer
    {
        private readonly IEnumerable<string> characters;
        private readonly IEnumerable<string> goals;
        private readonly IEnumerable<string> twists;

        public StoryContainer(
            IEnumerable<string> characters, IEnumerable<string> goals, IEnumerable<string> twists)
        {
            if (characters == null || characters.Count() == 0)
            {
                throw new ArgumentException(nameof(characters));
            }

            if (goals == null || goals.Count() == 0)
            {
                throw new ArgumentException(nameof(goals));
            }

            if (twists == null || twists.Count() == 0)
            {
                throw new ArgumentException(nameof(twists));
            }

            this.characters = characters;
            this.goals = goals;
            this.twists = twists;
        }

        public IEnumerable<string> Characters => this.characters;

        public IEnumerable<string> Goals => this.goals;

        public IEnumerable<string> Twists => this.twists;
    }
}

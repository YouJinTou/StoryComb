using System;

namespace StoryComb.SDK
{
    public class StoryGenerator : IStoryGenerator
    {
        private readonly IStoryContainer storyContainer;
        private readonly Random random;

        public StoryGenerator()
        {
            this.storyContainer = new SampleStoryContainer();
            this.random = new Random();
        }

        public StoryGenerator(IStoryContainer storyContainer)
        {
            this.storyContainer = storyContainer ?? 
                throw new ArgumentNullException(nameof(storyContainer));
            this.random = new Random();
        }

        public string GenerateStory()
        {
            var character = this.storyContainer.Characters[
                this.random.Next(0, this.storyContainer.Characters.Length)].ToUpper();
            var goal = this.storyContainer.Goals[
                this.random.Next(0, this.storyContainer.Goals.Length)].ToUpper();
            var twist = this.storyContainer.Twists[
              this.random.Next(0, this.storyContainer.Twists.Length)].ToUpper();

            return $"{character} must {goal} but {twist}.";
        }
    }
}

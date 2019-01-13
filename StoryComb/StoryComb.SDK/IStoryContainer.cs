namespace StoryComb.SDK
{
    public interface IStoryContainer
    {
        string[] Characters { get; }

        string[] Goals { get; }

        string[] Twists { get; }
    }
}

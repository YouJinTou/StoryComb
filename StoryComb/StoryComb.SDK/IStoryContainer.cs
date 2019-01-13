using System.Collections.Generic;

namespace StoryComb.SDK
{
    public interface IStoryContainer
    {
        IEnumerable<string> Characters { get; }

        IEnumerable<string> Goals { get; }

        IEnumerable<string> Twists { get; }
    }
}

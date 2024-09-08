using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public class HighScores
{
    private readonly IReadOnlyCollection<int> scores;
    public HighScores(IReadOnlyCollection<int> collection)
        => scores = collection ?? new List<int>();
    public IEnumerable<int> Scores()
        => scores;
    public int Latest()
        => scores.LastOrDefault();
    public int PersonalBest()
        => scores.Max();
    public IEnumerable<int> PersonalTopThree()
        => scores.OrderByDescending(s => s).Take(3);
}
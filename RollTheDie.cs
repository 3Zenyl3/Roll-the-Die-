public class Player
{
    Random Random = new Random();
    public int RollDie()
    {
        int a = Random.Next(1,18);
        return a;
    }

    public double GenerateSpellStrength()
    {
        double value = 100*Random.NextDouble();
        return value;
    }
}

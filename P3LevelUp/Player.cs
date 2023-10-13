namespace ConsoleApp1;

class Player
{
    public int Level { get; private set; }
    public int Experience { get; private set; }

    public Player()
    {
        Level = 0;
        Experience = 0;
    }

    public void GrantExperience(int experience)
    {
        Experience += experience;

        while (Experience >= 100)
        {
            Level++;
            Experience -= 100;
        }
    }
}
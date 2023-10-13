namespace P6GoodKnight;

class Shield
{
    public bool IsPierced { get; private set; }

    public void Defend()
    {
        IsPierced = true;
    }
}


class Sword { }


class Knight
{
    public Shield Shield { get; set; }
    public Sword Sword { get; set; }

    public void GetHit(Sword sword)
    {
        if (Shield != null)
        {
            Shield.Defend();
        }
        else
        {
            Console.WriteLine("Knight is wounded");
        }
    }

    public void Attack(Knight target)
    {
        if (Sword != null)
        {
            target.GetHit(Sword);
        }
        else
        {
            target.GetHit(null);
        }
    }
}


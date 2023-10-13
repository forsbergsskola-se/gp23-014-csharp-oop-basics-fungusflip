namespace P4Attack;
    class Player
    {
        public int Damage { get; private set; }

        public void Attack(Player target)
        {
            target.Damage++;
        }
    }
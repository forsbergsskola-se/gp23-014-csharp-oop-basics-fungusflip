using P6GoodKnight;

        // Create two knights, attacker and defender
        Knight defender = new Knight();
        defender.Shield = new Shield();

        Knight attacker = new Knight();

        // Let attacker Attack defender
        attacker.Attack(defender);

        // Give attacker a Sword
        attacker.Sword = new Sword();

        // Let attacker Attack defender
        attacker.Attack(defender);

        // Let attacker Attack defender
        attacker.Attack(defender);
        
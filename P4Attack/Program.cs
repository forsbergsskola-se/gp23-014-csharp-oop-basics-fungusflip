using P4Attack;

Player player1 = new Player();
Player player2 = new Player();

player1.Attack(player2);
Console.WriteLine("Player 1 Damage: " + player1.Damage);
Console.WriteLine("Player 2 Damage: " + player2.Damage);

player2.Attack(player1);
Console.WriteLine("Player 1 Damage: " + player1.Damage);
Console.WriteLine("Player 2 Damage: " + player2.Damage);

player1.Attack(player1);
Console.WriteLine("Player 1 Damage: " + player1.Damage);
Console.WriteLine("Player 2 Damage: " + player2.Damage);

Player player3 = player1;
player2.Attack(player3);
Console.WriteLine("Player 1 Damage: " + player1.Damage);
Console.WriteLine("Player 2 Damage: " + player2.Damage);
Console.WriteLine("Player 3 Damage: " + player3.Damage);
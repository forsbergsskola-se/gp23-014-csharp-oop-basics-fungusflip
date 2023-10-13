using RTSGAME;

Player playerA = new Player();
playerA.Gold = 200;
playerA.Stone = 110;
playerA.Wood = 53;
playerA.Level = 12;
playerA.Experience = 123;
playerA.VIPSubscription = true;
playerA.PVPEnabled = false;
playerA.DisplayName = "Marc";
playerA.EmailAddress = "marc@zaku.de";

// Print all information of the Player
Console.WriteLine($"Player A has {playerA.Gold} Gold, {playerA.Stone} Stone, {playerA.Wood} Wood.");
Console.WriteLine($"Level: {playerA.Level}, Experience: {playerA.Experience}");
Console.WriteLine($"VIP Subscription: {playerA.VIPSubscription}, PVP Enabled: {playerA.PVPEnabled}");
Console.WriteLine($"Display Name: {playerA.DisplayName}, Email Address: {playerA.EmailAddress}");
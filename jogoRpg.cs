int heroLife = 10;
int monsterLife = 10;

Random random = new Random();

do
{  // ataque do heroi
  ataque = random.Next (1,11);
    monsterLife -= ataque;
  Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {monsterLife} health.");

  // ataque do monstro
  ataque = random.Next (1,11);
  heroLife -= ataque;
  Console.WriteLine ($"Hero was damaged and lost {ataque} health and now has {heroLife} health.");

} while( heroLife > 0 && monsterLife > 0);

Console.WriteLine( heroLife > monsterLife ? "Hero Wins!" : "Monster Wins!");
   

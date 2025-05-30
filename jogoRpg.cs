int heroLife = 10;
int monsterLife = 10;

Random random = new Random();

do
{
  ataque = random.Next (1,11);
    monsterLife -= ataque;
  Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {monsterLife} health.");
   if (monsterLife <= 0)
   {
     Console.WriteLine("Hero Wins!"); 
     break;
   }
     
  ataque = random.Next (1,11);
  heroLife -= ataque;
  Console.WriteLine ($"Hero was damaged and lost {ataque} health and now has {heroLife} health.");
     
  if (heroLife <= 0)
   {
     Console.WriteLine("Monster Wins!"); 
    break;
   }
 
} while( heroLife > 0 && monsterLife > 0);
   

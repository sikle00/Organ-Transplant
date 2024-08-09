namespace Organ_Transplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bernt = new Persons("Bernt", "kidney", "The rest of the organs are fine", true);
            var kåre = new Persons("Kåre", "no damaged organs", "all organs are intact", true);
            var rand = new Random();
            var survivalChance = rand.Next(0, 9);
            switch (survivalChance)
            {
                case 1:
                    bernt.Alive = false;
                    break;
                default:
                    bernt.Alive = true;
                    break;
            }
            Console.WriteLine($"{bernt.Name} has been in an accident and needs new {bernt.NeededOrgans} to survive!");
            Console.WriteLine($"{bernt.Name}'s cousin, {kåre.Name}, has {kåre.NeededOrgans}, and can spare one {bernt.NeededOrgans} with a good success rate");
            Console.WriteLine("Press 1 if you confirm the transplant, if you deny, press any other number");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    if (bernt.Alive == true)
                    {
                        Console.WriteLine($"{bernt.Name} survived the transplant, congratulations!");
                    }
                    else
                    {
                        Console.WriteLine($"{bernt.Name} did unfortunately not survive the transplant");
                    }
                    break;
                default:
                    bernt.Alive = false;
                    Console.WriteLine($"Like said in the start {bernt.Name} needed a new {bernt.NeededOrgans} to survive!");
                    break;
            }

        }
    }
}

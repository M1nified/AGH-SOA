using Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceClient
{
				class Program
				{
								static void Main(string[] args)
								{
												Starship starship1 = new Starship();

												starship1.Captain = new Person();
												starship1.Captain.Age = 30;
												starship1.Captain.Name = "Captain Jack";

												starship1.Crew.Add(new Person("Mate 1", 10));
												starship1.Crew.Add(new Person("Mate 2", 50));
												starship1.Crew.Add(new Person("Mate 3", 80));
												starship1.Crew.Add(new Person("Mate 4", 100));
												starship1.Crew.Add(new Person("Mate 5", 45));

												PresentCrew(starship1);

												ServiceReferenceBlackHole.BlackHoleClient blackHole = new ServiceReferenceBlackHole.BlackHoleClient();

												string ultimateAnswer = blackHole.UltimateAnswer();
												Console.WriteLine("The Ultimate Answer is: {0}", ultimateAnswer);

												Starship starship1Pulled = blackHole.PullStarship(starship1);
												PresentCrew(starship1);
												PresentCrew(starship1Pulled);

												Console.ReadLine();
								}

								static void PresentCrew(Starship starship)
								{
												Console.WriteLine("Captain: {0} is {1}.",starship.Captain.Name,starship.Captain.Age);
												starship.Crew.ForEach(crewMember => Console.WriteLine("Crew member: {0} is {1}.",crewMember.Name,crewMember.Age));
								}
				}
}

using EFSamurai.Data;
using EFSamurai.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EFSamurai.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to my EF Samurai Repo Project!");
            Console.WriteLine();
            //AddOneSamurai();
            //AddSomeSamurais();
            //AddOneSamuraiWithRelatedData();
            //ClearDatabase();
            List<Samurai> listOfSamurais = ListAllSamuraiNames();
            List<Samurai> listOfSamuraisByName = ListAllSamuraiNames_OrderByName();
            List<Samurai> listOfSamuraisByIdDesc = ListAllSamuraiNames_OrderByIdDescending();

            PrintAllSamurais(listOfSamurais);
            Console.WriteLine("------------");
            PrintAllSamurais(listOfSamuraisByName);
            Console.WriteLine("------------");
            PrintAllSamurais(listOfSamuraisByIdDesc);
            Console.WriteLine("------------");

            Console.WriteLine("Insert a real name of a Samurai.");
            var name = Console.ReadLine();
            bool anySamurai = FindSamuraiWithRealName(name);
            RespondSamuraiWithRealName(anySamurai, name);
            Console.WriteLine();

            var quoteType = QuoteTypes.Awesome;
            List<Quote> listOfQuoteTypes = ListAllQuotesOfType(quoteType);
            PrintAllQuotes(listOfQuoteTypes);
            Console.WriteLine();

            var quoteType2 = QuoteTypes.Awesome;
            List<Quote> listOfQuoteTypesWithSamurai = ListAllQuotesOfType_WithSamurai(quoteType2);
            PrintAllQuotesWithSamurai(listOfQuoteTypesWithSamurai);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to Quit. . .");
            Console.ReadLine();
        }

        private static List<Quote> ListAllQuotesOfType_WithSamurai(QuoteTypes quoteType2)
        {
            var list = new List<Quote>();
            using (var repo = new SamuraiContext())
            {
                var quoteList = repo.Quotes.Where(x => x.QuoteType == quoteType2).ToList();
                var samuraiList = repo.Samurais.Select(x => x).ToList();
                foreach (var item in quoteList)
                {
                    var samurai = samuraiList.Find(s => s.Id == item.SamuraiId);
                    if (samurai != null)
                    {
                        item.Samurai = samurai;
                    }
                }
                return quoteList;
            }
        }

        private static void PrintAllQuotesWithSamurai(List<Quote> listOfQuoteTypesWithSamurai)
        {
            foreach (var quote in listOfQuoteTypesWithSamurai)
            {
                Console.WriteLine($"Quote Type: {quote.QuoteType.ToString()}");
                Console.WriteLine($"Quote Text: {quote.Text}");
                Console.WriteLine($"Quote By: {quote.Samurai.Name}");
            }
        }

        private static void PrintAllQuotes(List<Quote> listOfQuoteTypes)
        {
            foreach (var quote in listOfQuoteTypes)
            {
                Console.WriteLine($"Quote Type: {quote.QuoteType.ToString()}");
                Console.WriteLine($"Quote Text: {quote.Text}");
            }
        }

        private static List<Quote> ListAllQuotesOfType(QuoteTypes quoteType)
        {
            using (var repo = new SamuraiContext())
            {
                var list = repo.Quotes.Where(x => x.QuoteType == quoteType).ToList();
                return list;
            }
        }

        private static void RespondSamuraiWithRealName(bool anySamurai, string name)
        {
            if (anySamurai == true)
            {
                Console.WriteLine($"Samurai with the real name '{name}' was found.");
            }
            else
            {
                Console.WriteLine($"Samurai with the real name '{name}' was not found.");
            }
        }

        private static bool FindSamuraiWithRealName(string name)
        {
            using (var repo = new SamuraiContext())
            {
                var samurai = repo.Samurais.Any(x => x.SecretIdentity.RealName.ToLower() == name.ToLower());
                return samurai;
            }
        }

        private static List<Samurai> ListAllSamuraiNames_OrderByIdDescending()
        {
            using (var repo = new SamuraiContext())
            {
                var list = repo.Samurais.Select(x => x).OrderByDescending(s => s.Id).ToList();
                return list;
            }
        }

        private static List<Samurai> ListAllSamuraiNames_OrderByName()
        {
            using (var repo = new SamuraiContext())
            {
                var list = repo.Samurais.Select(x => x).OrderBy(s => s.Name).ToList();
                return list;
            }
        }

        private static void PrintAllSamurais(List<Samurai> listOfSamurais)
        {
            foreach (var sam in listOfSamurais)
            {
                Console.WriteLine($"Id: {sam.Id} Name: {sam.Name}");
            }
        }

        private static List<Samurai> ListAllSamuraiNames()
        {
            using (var repo = new SamuraiContext())
            {
                var list = repo.Samurais.Select(x => x).ToList();
                return list;
            }
        }

        private static void ClearDatabase()
        {
            using (var repo = new SamuraiContext())
            {
                var events = repo.BattleEvents.Select(x => x);
                repo.BattleEvents.RemoveRange(events);

                var logs = repo.BattleLogs.Select(x => x);
                repo.BattleLogs.RemoveRange(logs);

                var samBattles = repo.SamuraiBattles.Select(x => x);
                repo.SamuraiBattles.RemoveRange(samBattles);

                var battles = repo.Battles.Select(x => x);
                repo.Battles.RemoveRange(battles);

                var secrets = repo.SecretIdentities.Select(x => x);
                repo.SecretIdentities.RemoveRange(secrets);

                var quotes = repo.Quotes.Select(x => x);
                repo.Quotes.RemoveRange(quotes);

                var sams = repo.Samurais.Select(x => x);
                repo.Samurais.RemoveRange(sams);

                repo.SaveChanges();
            }

            Console.WriteLine("Cleared the database.");
        }

        private static void AddOneSamuraiWithRelatedData()
        {
            var sam = new Samurai { Name = "Hanzo", Sword = "Bow", HairStyle = HairStyles.Western, };
            var quotes = new List<Quote>()
            {
                new Quote { QuoteType = QuoteTypes.Cheesy, Text = "I shoot fishes.", Samurai = sam },
                new Quote { QuoteType = QuoteTypes.Awesome, Text = "Like shooting fishes in a barrel.", Samurai = sam }
            };
            var secret = new SecretIdentity { RealName = "Hönan", Samurai = sam };
            var battle = new Battle { Name = "Overwatch battle", Brutal = false, StartDate = DateTime.Today, EndDate = DateTime.Now };
            var samuraiBattles = new SamuraiBattles { Battles = battle, Samurais = sam };
            var battleLog = new BattleLog { Name = "Battle Of Overwatch", Battles = battle };
            var battleEvents = new List<BattleEvent>()
            {
                new BattleEvent { Conclusion = "Overwatch saved the world.", Description = "Almost all robots died.", BattleEventDate = DateTime.Now, BattleLogs = battleLog },
                new BattleEvent { Conclusion = "Overwatch saved the world.", Description = "The humans survived.", BattleEventDate = DateTime.Now, BattleLogs = battleLog }
            };

            using (var repo = new SamuraiContext())
            {
                repo.Samurais.Add(sam);
                repo.Quotes.AddRange(quotes);
                repo.SecretIdentities.Add(secret);
                repo.Battles.Add(battle);
                repo.SamuraiBattles.Add(samuraiBattles);
                repo.BattleLogs.Add(battleLog);
                repo.BattleEvents.AddRange(battleEvents);
                repo.SaveChanges();
            }

            Console.WriteLine("Added a Samurai with lot's of data.");
        }

        private static int GetSamuraiById(Samurai sam)
        {
            using (var repo = new SamuraiContext())
            {
                var samsam = repo.Samurais.FirstOrDefault(s => s.Id == sam.Id);
                return samsam.Id;
            }
        }

        private static void AddSomeSamurais()
        {
            var list = new List<Samurai>()
            {
                new Samurai { Name = "Hanzo1", Sword = "Bow", HairStyle = HairStyles.Western },
                new Samurai { Name = "Hanzo2", Sword = "Bow", HairStyle = HairStyles.Western },
                new Samurai { Name = "Hanzo3", Sword = "Bow", HairStyle = HairStyles.Western }
            };

            using (var repo = new SamuraiContext())
            {
                repo.Samurais.AddRange(list);
                repo.SaveChanges();
            }
            Console.WriteLine("Added some Samurais.");
        }

        private static void AddOneSamurai()
        {
            var sam = new Samurai { Name = "Hanzo", Sword = "Bow", HairStyle = HairStyles.Western };
            using (var repo = new SamuraiContext())
            {
                repo.Samurais.Add(sam);
                repo.SaveChanges();
            }
            Console.WriteLine("Added a Samurai.");
        }
    }
}
using FootballAppDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAppDb
{
    class Program
    {
        static FootballModel db = new FootballModel();

        static void Main(string[] args)
        {
            #region Menu choises 
            while (true)
            {
                ShowMenu();
                var choise = Console.ReadLine();
                switch(choise)
                {
                    case "1":
                        AddArena();
                        break;
                    case "2":
                        ListAllArenas();
                        break;
                    case "3":
                        AddTeam();
                        break;
                    case "4":
                        ListAllTeams();
                        break;
                    case "5":
                        return;
                }
            }
        }
        #endregion
#region 
        private static void ListAllTeams()
        {
            foreach(var Teams in db.Teams)
            {
                Console.WriteLine(Teams.Name);
            }           
        }
        private static void AddTeam()
        {
            Console.WriteLine("Name your team");
            var teamName = Console.ReadLine();
            db.Teams.Add(new Teams { Name = teamName});
            db.SaveChanges();
        }

        private static void ListAllArenas()
        {
            foreach(var Arenas in db.Arenas)
            {
                Console.WriteLine(Arenas.Name);
            }
        }

        private static void AddArena()
        {
            Console.WriteLine("Name your arena");
            var arenaName = Console.ReadLine();
            db.Arenas.Add(new Arenas { Name = arenaName });
            db.SaveChanges();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1. Create arena");
            Console.WriteLine("2. List all arenas");
            Console.WriteLine("3. Create team");
            Console.WriteLine("4. List all teams");
            Console.WriteLine("5. Close application");
        }
    }
}

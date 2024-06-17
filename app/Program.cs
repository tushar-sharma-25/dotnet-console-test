using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Program
    {
        public record Hero(string name, bool canFly, string alias);
        // we can not use var directly in class
        public static List<Hero> heros = new List<Hero>(){
            new ("Tushar", true, "tus" ),
            new ("Max", false, "m" ),
            new (string.Empty, true, "home" )
        };

        public delegate bool Condition(Hero hero);

        public static void Main(string[] args)
        {
            var result = FilterHeroes(heros, (hero)=>hero.canFly);
            foreach(var h in result){
                Console.WriteLine(h.alias);
            }
        }

        public static List<Hero>  FilterHeroes(List<Hero> heroes, Condition cond){
            var result = new List<Hero>();
            foreach(var hero in heroes){
                if(cond(hero)){
                    result.Add(hero);
                }
            }
            return result;
        }
    }
}

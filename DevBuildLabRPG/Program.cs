using System;
using System.Collections.Generic;
using System.Linq;

namespace TestC
{
    public class GameCharacters
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public GameCharacters(string name, int inte, int str)
        {
            Name = name;
            Strength = str;
            Intelligence = inte;

        }

        public virtual void Play()
        {
            Console.WriteLine(Name + " " + Intelligence + " " + Strength);
        }
    }
    public class Warrior : GameCharacters
    {

        public string WeaponType;
        public Warrior(string weapon, string name, int inte, int str) : base(name, inte, str)
        {

            WeaponType = weapon;
        }
        public override void Play()
        {
            Console.WriteLine(Name + " " + Intelligence + " " + Strength + " " + WeaponType);
        }
    }
    public class MasicUsingCharacter : GameCharacters
    {
        public int MagicalEnergy;
        public MasicUsingCharacter(int mEnergy, string name, int inte, int str) : base(name, inte, str)
        {
            MagicalEnergy = mEnergy;

        }
        public override void Play()
        {
            Console.WriteLine(Name + " " + Intelligence + " " + Strength + " " + MagicalEnergy);
        }
    }
    public class Wizard : MasicUsingCharacter
    {
        public int SpellNumber;
        public Wizard(int sn, int mEnergy, string name, int inte, int str) : base(mEnergy, name, inte, str)
        {
            SpellNumber = sn;
        }
        public override void Play()
        {
            Console.WriteLine(Name + " " + Intelligence + " " + Strength + " " + SpellNumber + " " + MagicalEnergy);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            List<GameCharacters> gameCharacters = new List<GameCharacters>();
            var x1 = new Warrior("Axe", "Barbarian", 1, 2);
            var x2 = new Warrior("XXX", "Fighter", 1, 2);
            var x3 = new Warrior("YYY", "Fighter2", 1, 2);

            gameCharacters.Add(x1);
            gameCharacters.Add(x2);
            gameCharacters.Add(x3);
            var y1 = new Wizard(1, 2, "Viking", 4, 5);
            var y2 = new Wizard(1, 2, "Magician", 4, 5);
            gameCharacters.Add(y1);
            gameCharacters.Add(y2);


            int ck = 0;
            foreach (var item in gameCharacters)
            {
                if (item is Warrior)
                {
                    if (ck == 0)
                    {
                        Warrior obj = new Warrior(x1.WeaponType, item.Name, item.Intelligence, item.Strength);
                        obj.Play();

                    }
                    else if (ck == 1)
                    {
                        Warrior obj = new Warrior(x2.WeaponType, item.Name, item.Intelligence, item.Strength);
                        obj.Play();
                    }
                    else if (ck == 2)
                    {
                        Warrior obj = new Warrior(x2.WeaponType, item.Name, item.Intelligence, item.Strength);
                        obj.Play();
                    }
                }
                else if (item is Wizard)
                {
                    if (ck == 3)
                    {
                        Wizard obj2 = new Wizard(y1.SpellNumber, y1.MagicalEnergy, item.Name, item.Intelligence, item.Strength);
                        obj2.Play();
                    }
                    else if (ck == 4)
                    {
                        Wizard obj2 = new Wizard(y2.SpellNumber, y2.MagicalEnergy, item.Name, item.Intelligence, item.Strength);
                        obj2.Play();
                    }
                }

                ck++;

            }

        }
    }
}
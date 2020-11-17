using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Character
                
        ///internal позволяет использовать только внутри сборки (5_OOP)
        ///protected доступен только в наследниках
        ///private только внутри класса
    {        
        /// <summary>
        /// static расшариваются (разделяются) между всеми 
        /// экземплярами класса
        /// </summary>
        private const int speed = 10;

        private int health = 100;

        //автосвойства:
        public int Health { get; private set; } = 100; // краткая запись свойства
        // подробная запись свойства:
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}

        public int Armor { get; private set; }

        public string Race { get; private set; }

        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }

        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;

           // health -= damage;
            Health -= damage;
        }

        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
           // speed += 10;
        }
    }
}

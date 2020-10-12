using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    public class Character

        //internal позволяет использовать только внутри сборки (5_OOP)
        //protected доступен только в наследниках
    {
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


        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;

           // health -= damage;
            Health -= damage;
        }
    }
}

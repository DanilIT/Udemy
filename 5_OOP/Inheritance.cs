using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    public class BankTerminal
    {
        protected string id;

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="id"></param>
        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("General Connecting protocol...");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id)  //id передается по базовому конструктору
        {           
        }

        public override void Connect()
        {            
            base.Connect();
            Console.WriteLine("Additional actions for Model X");
        }
    }

    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)  //id передается по базовому конструктору
        {
        }

        public override void Connect()
        {

            base.Connect();
            Console.WriteLine("Additional actions for Model Y");
        }
    }
}

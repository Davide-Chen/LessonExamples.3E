using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BlaisePascal.LessonExample.ExampleEnemy.Domain
{
    public class Enemy
    {
        private int _health;
        public string Name { get; set; }
        public int Damage { get; private set; }


        //public int Health { get; set;  } //forma abbrevata senza controlli
        //public int Health { get; private set; }

        //Ctrl + K, Ctrl + C
        //public int Health
        //{
        //    get { return _health; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        }
        //        else if (value > 100)
        //        {
        //            _health = 100;
        //        }
        //        else
        //        {
        //            _health = value;
        //        }
        //    }
        //}
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void SetHealth(int newHealth)
        {
            if (newHealth < 0)
                Health = 0; //se il corpo del costrutto è solo di una riga, allora posso omettere le graffe
            else if (newHealth > 100)
                Health = 100;
            else
                Health = newHealth;
        }
        public bool IsAlive()
        {
            return Health > 0;
        }
        public void TakeDamage(int damage)
        {

            if (damage > 0)
            {
                Health -= damage;
            }
        }
    }
}

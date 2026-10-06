namespace BlaisePascal.LessonExample.Domain
{
    public class Enemy
    {
        private int _health;

        //public int Health { get; set;  } //forma abbrevata senza controlli
        public int Health { get; private set; }

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

        public Enemy()
        {

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
        public bool isAlive()
        {
            return Health > 0;
        }
        public void TakeDamage(int damage)
        {
            
            SetHealth(_health - damage);
        }
    }
}

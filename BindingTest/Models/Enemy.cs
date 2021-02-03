using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingTest.Models
{
    public class Enemy : ObservableObject
    {
        private int _health;
        private int _lives;

        public int Lives
        {
            get { return _lives; }
            set
            {
                _lives = value;
                OnPropertyChanged(nameof(Lives));
            }
        }

        public int Health
        {
            get { return _health; }
            set 
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

    }
}

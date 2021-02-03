using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest;

namespace BindingTest.Models
{
    public class Player : ObservableObject
    {
        private string _name;
        private int _lives;
        private int _health;
        private bool _isAlive;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

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

        public bool IsAlive
        {
            get { return _isAlive; }
            set
            {
                _isAlive = value;
                OnPropertyChanged(nameof(IsAlive));
            }
        }
    }
}

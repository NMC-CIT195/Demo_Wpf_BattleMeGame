using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest.Models;

namespace BindingTest.Presentation
{
    public class GameViewModel : ObservableObject
    {
        private Player _player;
        private Enemy _enemy;
        private Random _random;
        private string _battleMessage;

        public Player Player
        {
            get { return _player; }
            set 
            { 
                _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        public Enemy Enemy
        {
            get { return _enemy; }
            set 
            { 
                _enemy = value;
                OnPropertyChanged(nameof(Enemy));
            }
        }

        public string BattleMessage
        {
            get { return _battleMessage; }
            set 
            { 
                _battleMessage = value;
                OnPropertyChanged(nameof(BattleMessage));
            }
        }

        public void CalculateAttackResults()
        {
            int playerHit = _random.Next(1, 101);
            int enemyHit = _random.Next(1, 101);

            Player.Name = "Fred";

            if (playerHit > enemyHit)
            {
                Enemy.Health -= playerHit - enemyHit;
                BattleMessage = "Player Wins";

                if (Enemy.Health <= 0) 
                {
                    Enemy.Health = 100;
                    Enemy.Lives--;
                    BattleMessage = "Enemy Looses a Life";
                }
            }
            else if (enemyHit > playerHit)
            {
                Player.Health -= enemyHit - playerHit;
                BattleMessage = "Enemy Wins";

                if (Player.Health <= 0)
                {
                    Player.Health = 100;
                    Player.Lives--;
                    BattleMessage = "Player Looses a Life";
                }
            }
        }

        public GameViewModel()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            _player = new Player();
            Player.Name = "Bonzo";
            Player.Lives = 3;
            Player.Health = 104;

            _enemy = new Enemy();
            Enemy.Health = 100;
            Enemy.Lives = 3;

            // common random object for reuse
            _random = new Random();
        }
    }
}

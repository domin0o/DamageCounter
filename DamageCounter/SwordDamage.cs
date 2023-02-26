using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCounter
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        private bool magic;
        private bool flaming;
        private int roll;
        /// <summary>
        /// Przypisuje wylosowaną liczbę do Roll.
        /// </summary>
        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Zawiera obliczone obrażenia
        /// </summary>
        public int Damage
        {
            get;
            private set;
        }
        /// <summary>
        /// Główna funkcja obliczająca obrażenia. Dodatkowo sprawdza czy miecz jest magiczny i płonący i na tej podstawie oblicza obrażenia.
        /// </summary>
        public void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
            {
                magicMultiplier = 1.75M;
            }
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }

        /// <summary>
        /// Zwraca true jeśli miecz jest magiczny, false jeśli nie
        /// </summary>
        public bool Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Zwraca true jesli miecz jest płonący, false jeśli nie.
        /// </summary>
        public bool Flaming
        {
            get
            {
                return flaming;
            }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Konstruktor przypisuje początkowy rzut do roll i wywołuje funkcję CalculateDamage();
        /// </summary>
        /// <param name="startingRoll">Początkowy rzut</param>
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public string AttackType;
        public Hero MarriedTo;

        public Hero(string Name, int Level, string HeroType, int HP, string AttackType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.AttackType = AttackType;
        }

        public override string ToString()
        {
            return $"{this.Name} stats: Level:{this.Level} Type:{this.HeroType} HP:{this.HP} Attack Type:{this.AttackType}";
        }

        public string Attack(Hero inimigo) {
            if (this.HP == 0){
                return $"{this.Name} já está morto";
            }
            if (inimigo.HP == 0){
                return $"Inimigo {inimigo.Name} já está morto";
            }

            if (inimigo.HP - this.Level <= 0) {
                inimigo.HP = 0;
                return $"{this.Name} ataca {inimigo.Name} com {this.AttackType}!! Oponente {inimigo.Name} derrotado";
            }
            else {
                inimigo.HP -= this.Level;
                return $"{this.Name} ataca {inimigo.Name} com {this.AttackType}!! HP de {inimigo.Name}: {inimigo.HP + this.Level} -> {inimigo.HP}";
            }
        }

        public abstract string SpecialAttack(Hero inimigo);

        public string Marry(Hero partner) {
            if (this.MarriedTo != null)
            {
                return $"{this.Name} já está casado/a";
            }
            else if (partner.MarriedTo != null)
            {
                return $"{partner.Name} já está casado/a";
            }
            else
            {
                this.MarriedTo = partner;
                partner.MarriedTo = this;
                return $"Parabéns, {this.Name} e {partner.Name} estão casados!";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int HP)
            : base(Name, Level, "Knight", HP, "espada")
        {
            
        }

        public override string SpecialAttack(Hero inimigo) {
            if (this.HP == 0){
                return $"{this.Name} já está morto";
            }
            if (inimigo.HP == 0){
                return $"Inimigo {inimigo.Name} já está morto";
            }

            if (inimigo.HP - (this.Level * 2) <= 0) {
                inimigo.HP = 0;
                return $"{this.Name} faz um ataque forte em {inimigo.Name}!! Oponente {inimigo.Name} derrotado";
            }
            else {
                inimigo.HP -= this.Level * 2;
                return $"{this.Name} faz um ataque forte em {inimigo.Name}!! HP de {inimigo.Name}: {inimigo.HP + (this.Level * 2)} -> {inimigo.HP}";
            }
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CombatApp.Models
{
    public class Character
    {
        [Required]
        public int HP { get; set; } = 1;
        [Required]
        public string Name { get; set; } = "Default";
        [Required]
        public int Attack { get; set; } = 1;
        [Required]
        public int Defense { get; set; } = 1;
        [Required]
        public int Magic { get; set; } = 1;
        [Required]
        public int SkillPoints { get; set; } = 1;
        [Required]
        public int Level { get; set; } = 1;

        public int Combat(Character enemy)
        {
            while (this.HP > 0 && enemy.HP > 0)
            {
                // Combat loop
                this.HP -= enemy.Attack;
                enemy.HP -= this.Attack;
            }

            if(enemy.HP <= 0)
            {
                return 0;
            }
            return 1;
        }
    }
}

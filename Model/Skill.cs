using System.Collections.Generic;

namespace dotnet_rpg.Model
{
    public class Skill
    {
        //Entity framework is not available to create a JOIN relation for itself
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}
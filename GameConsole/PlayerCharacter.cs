using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
	class PlayerCharacter
	{
		private readonly SpecialDefence _specialDefense;
		public PlayerCharacter(SpecialDefence specialDefense)
		{
			_specialDefense = specialDefense;
		}
		public string Name { get; set; }
		public int Health { get; set; } = 100;
		public void Hit(int damage)
		{
			int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);
			Health -= totalDamageTaken;
			Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
		}
	}
}

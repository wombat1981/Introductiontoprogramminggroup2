/*
 * Created by SharpDevelop.
 * User: 102688864
 * Date: 28/03/2019
 * Time: 3:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace consoleApp1
{
	class Program{
		
		public static void Main(string[] args){
			HealPotion Hp1 = new HealPotion(50);
			PoisonPotion Pp1 = new PoisonPotion(5);
			Person p1 = new Person("Fred", 1,  Hp1, Pp1 );
			
			Console.WriteLine("P1 name: " + p1.name);
			Console.WriteLine("P1 health: " + p1.healthpool);
			Console.WriteLine("P1 potion value: " + p1.potion1.health);
			Console.WriteLine("P1 potion value: " + p1.potion2.health);
			
			p1.usepotion2();
			Console.WriteLine("p1 health: " + p1.healthpool);
			
			
			Console.ReadKey();
			
		}
	}
			
	

	
		public class PoisonPotion {
		public int health;
		
		// constructor	
		public PoisonPotion(int h) {
			health = h;
	
		}
		
		public int usePotion(){
			return health;
		}
		public int usePotion2(){
			return health;
		}
	
	}	
		public class HealPotion {
		public int health;
		
		// Constructor 
		public HealPotion(int h) {
			health = h;
		
		}
		// Constuctor
		
		public int use() {
			return health;
			
		}
			
	}
	public class Person {
		public string name;
		public int healthpool;
		public HealPotion potion1;
		public PoisonPotion potion2;
		
		public Person(string n, int hp, HealPotion p, PoisonPotion PP) {
			name = n;
			healthpool = hp;
			potion1 = p;
			potion2 = PP;
		}
		
	
		public void usepotion() {
			healthpool += potion1.use();
			potion1 = null;
		}
		public void usepotion2() {
			healthpool -= potion2.usePotion2();
			potion2 = null;
		}
	}
}	
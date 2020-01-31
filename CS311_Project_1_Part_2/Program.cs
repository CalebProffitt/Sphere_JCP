using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS311_Project_1_Part_2
{
	/**
 * This class models a sphere object
 * @author Rob Kelley
 * @version 1.0
 * Lab02-Solution
 * SP19
 */
	public class Sphere
	{

		private double diameter;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Sphere()
		{
			diameter = 2.0;
		}//end constructor

		/**
		 * Constructor accepts value of diameter.
		 * Preferred constructor.
		 * @param diameter
		 */
		public Sphere(double diameter)
		{

			this.setDiameter(diameter);

		}//end constructor

		/**
		 * Calculates the volume of the sphere.
		 * @return volume
		 */
		public double getVolume()
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end getVolume

		/**
		 * Calculates the surface area of the sphere.
		 * @return - surface area
		 */
		public double getSurfaceArea()
		{

			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end getSurfaceArea


		/**
		 * Getter for diameter
		 * @return
		 */
		public double getDiameter()
		{
			return diameter;
		}//end getDiameter

		/**
		 * Setter for diameter. Checks bound on
		 * formal parameter and resets to 2 if
		 * the value is less than 2.
		 * @param diameter
		 */
		public void setDiameter(double diameter)
		{
			if (diameter < 2)
				this.diameter = 2;
			else
				this.diameter = diameter;
		}//end setDiameter

		
		public override String ToString()
		{
			return "Sphere [diameter=" + diameter + "]";
		}//end toString

	}//end class

	class Program
	{
		private static void Main(String[] args)
		{
			Sphere sphere = new Sphere();
			sphere.setDiameter(12);

			Console.WriteLine("Diameter of the sphere: " + sphere.getDiameter());
			Console.WriteLine("Surface area of the sphere: " + sphere.getSurfaceArea());
			Console.WriteLine("Volume of the sphere: " + sphere.getVolume());
			Console.WriteLine("Diameter using ToString(): " + sphere.ToString());
			Console.WriteLine("\nPress enter to exit");
			Console.ReadKey();
		}
	}
}

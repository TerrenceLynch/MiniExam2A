using System;




class MainClass {


  public static void Main (string[] args) {
   
    Console.WriteLine("How many cylinders do you want the volume of?");
    int totalmath = Convert.ToInt32(Console.ReadLine());
   for(int counter = 1; counter <= totalmath; counter++)
  {
    CylinderVolume();
  }
  
  }

  public static void CylinderVolume (){

  Console.WriteLine("What is the radius of the cylinder?");
  double radius = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("What is the height of the cylinder?");
  double height = Convert.ToDouble(Console.ReadLine());
 
  double volume = 3.14 * radius * radius * height;
  
  Console.WriteLine("The Volume of the cylinder is " + volume + ".");

} 

}
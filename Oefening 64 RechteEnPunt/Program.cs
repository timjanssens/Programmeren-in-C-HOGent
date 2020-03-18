using System;

namespace Oefening_64_RechteEnPunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechte rechte1 = new Rechte();            
            Console.WriteLine(rechte1.Start.X == 0);    
            Console.WriteLine(rechte1.Start.Y == 0);    
            Console.WriteLine(rechte1.Eind.X == 0);     
            Console.WriteLine(rechte1.Eind.Y == 0);     
         //   Console.WriteLine(rechte1.Lengte() == 0d);  
            
            rechte1.Start.X = 1;       
            rechte1.Start.Y = 2;       
            rechte1.Eind.X = 4;        
            rechte1.Eind.Y = 6;        
            
            Console.WriteLine(rechte1.Start.X == 1);    
            Console.WriteLine(rechte1.Start.Y == 2);    
            Console.WriteLine(rechte1.Eind.X == 4);     
            Console.WriteLine(rechte1.Eind.Y == 6);     
          //  Console.WriteLine(rechte1.Lengte() == 5d);  
            
            //Punt punt1 = new Punt() { X = 31, Y = 42 }; 
            //rechte1.Eind = punt1;            
            //Console.WriteLine(rechte1.Lengte() == 50d); 
            //rechte1.Start = punt1;            
            //Console.WriteLine(rechte1.Lengte() == 0d);

            Console.ReadKey();
        }
    }

    class Rechte
    {
        public Start Start { get; set; } = new Start();
        public Eind Eind { get; set; } = new Eind();
        //public Punt Punt { get; set; } = new Punt();

    }

    class Start
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Eind
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

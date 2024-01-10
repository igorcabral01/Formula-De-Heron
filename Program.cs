using CursoC_.models;
  Triangulo x,y;

  x = new Triangulo();
  y = new Triangulo();

   Console.WriteLine("Entre com as medidas do triangulo x");
   x.A = double.Parse(Console.ReadLine());
   x.B = double.Parse(Console.ReadLine());
   x.C = double.Parse(Console.ReadLine());

   Console.WriteLine("Entre com as medidas do triangulo y") ;
   y.A = double.Parse(Console.ReadLine());
   y.B = double.Parse(Console.ReadLine());
   y.C = double.Parse(Console.ReadLine());

   double Areax = x.Area();

   double Arexy = y.Area();

   Console.WriteLine($"Area de X = {Areax}");
   Console.WriteLine($"Area de Y = {Arexy}");

   if(Areax > Arexy)
   {
    Console.WriteLine("Maior Area x");
   }else
   {
    Console.WriteLine("Maior Area Y");
   }
   
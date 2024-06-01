using System;
using  System.Threading;
using System.Diagnostics;


namespace ConsoleApp8{

class Program{

static void Main(string [] args ){
Stopwatch watch = new Stopwatch();
watch.Start();
for(int index=0; index<15; index++){
	Console.WriteLine("Digging completed for" + index + "mtr. area");
Thread.Sleep(1000);
}
watch.Stop();
Console.WriteLine("Time required single handed: "  + watch.Elapsed.Seconds);
}
}
}

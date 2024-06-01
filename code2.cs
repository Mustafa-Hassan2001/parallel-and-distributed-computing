using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp{
class Program{
static void Main(){
Stopwatch watch = new Stopwatch();
watch.Start();

Parallel.For(0, 15, index=> {
Console.WriteLine("Digging completed for" + index + "mtr. area");
Thread.Sleep(1000);
}
);
watch.Stop();
Console.WriteLine("Time required more than 1 persons digginng:{0} secounds"  + watch.Elapsed.Seconds);
}
}
}

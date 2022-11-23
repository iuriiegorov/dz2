Console.WriteLine ("Input first number");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number");
int P = Convert.ToInt32(Console.ReadLine());

if (N > M){   
    if (N > P){
        Console.WriteLine("MAX = " + N); 
    } else {
       Console.WriteLine("MAX = " + P);  
        }
}
else if (M > P) {
    Console.WriteLine("MAX = " + M);    
}
else {
    Console.WriteLine("MAX = " + P);
}    

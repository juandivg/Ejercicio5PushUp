// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Ingrese SamDaily");
int sam=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese KellyDaily");
int kelly=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese Diferencia");
int difference=int.Parse(Console.ReadLine());

System.Console.WriteLine(MinNum(sam, kelly, difference));


int MinNum(int s, int k, int d)
{
    int i;
    int x=s;
    int y=k;
   
    if(s>=k)
    {
        return -1;
    }
     s+=d;
    i=1;
    while(s>=k)
    {
        s=s+i*x;
        k=k+i*y;
        i++;
    }

    return i;
}

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int c = 1;
while(c<=i)
 { if(c%2 == 0) 
  {
   Console.WriteLine("Четное число - " + c);
  } 
  c++;
 }
  
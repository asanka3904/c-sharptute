using System;

namespace my
{
    class Program
    {
        static void Main(string[] args)
        {
            String str="string value";
            int intvalue;

            //data type
            String phase="string value";
            int intvalue1=20;
            double doublevalue=24.56;
            bool istrue=true;




            Console.WriteLine("variable"+str);
            Console.WriteLine(phase[2]);

          //number

          Console.WriteLine(5+2);
          //can use all Math function max, min, 
          Console.WriteLine(Math.Abs(-50));
          Console.WriteLine(Math.Pow(2,5));
         
       


            Console.Write("enter name : ");
            String name=Console.ReadLine();
            Console.WriteLine("hello "+name);


         //   class

         Book book1=new Book("load of the ring",600);
        book1.displaytitle();

         Book book2=new Book("harry potter",400);
         book2.author="jk rowling";
         book2.author;

        }
    }
}

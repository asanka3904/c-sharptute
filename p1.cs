using System;

namespace my{

    class p1{
        static void Main(string[] args){

      int num=Convert.ToInt32(5);
      Console.WriteLine(num);

 
  //array
   int [] numarray={44,45,85,63};
   string [] strarry=new string[2];

   //multidimentional array

   int [,] mul_int={
       {1,2},
       {3,4},
       {4,5}

   };


   int [,,] int3=new int[2,2];


    

    //method // create method and call in main method

     static void syHi(string name,int age){
        Console.WriteLine("hello "+name + " age is "+ age);
     }

   //return method

   static int  cube(int x){
       return x*2;
   }


     //if else 

  bool x=true;
  bool y=false;
     if(x){
         //print some
     }else if(y){
   //print another
     }else{
         //print las
     }


     //and or condition
   string m="male";
   string y="female";
     if(m && y){
         //and condition
     }else if(m || y){
         //or condition
     }else if(m && !Y)
     




    //exception handle
    // use System.DivideByZeroException,System.NullReferenceException, ..etc

    try
    {
        //run correct
    }
    catch (Exception e)
    {
        
        Console.WriteLine(e.Message);
    }

    //finally
    finally { Console.WriteLine("Finally block is executed"); }  

//custome exception

try {
    //when ok
    validate(14)
}catch (invalidAgeException e){
    //when not wor
   
}


function void validate(int age){
if(age<21){
 throw new invalidAgeException{"sorry, must be 21"}
}
}

class
        
    }



    class invalidAgeException : Exception{
        public invalidAgeException(String message){
                :base(message);
        }
    }
}



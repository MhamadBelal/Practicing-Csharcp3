using System;
using System.Diagnostics;
using System.Collections.Generic;
namespace ConsoleApp3

{
    class Program
    {


        /*                  //example 1
        static void fun(ref int x) { x = 6; }    //intilatizing by reference 
        static void fun1(out int x) { x = 6; }
        */


        static void Main(string[] args)
        {


            /*                                //example 1
            int a;
            fun(ref a);      //we sould give a varible a value becuse be define it as a reference 
            Console.WriteLine(a);
            int b ;      // we can give it value or not ...this is the difference betwwen calling in reference or calling by out
            fun1(out b);
            Console.WriteLine(b);

             //the difference between call by reference and call by out:
             //1-must change value of receive variable when you use call by out
             //2-must be sender variable it has a value if (intializatio)when you see call by ref
            */



            /*                                //example 2
            Computer c1 = new Computer("HP");
            Computer c2 = new Computer("dOLl");
            c1.getram = 8;
            c1.setcpu = "I7";
            c2.getram = 4;
            c2.setcpu = "I5";
            if (c1.getram > c2.getram)
                Console.WriteLine("motherboard: {0}\nram {1}\ncpu: {2}", c1.motherboard, c1.getram, c1.getcpu);
            else
                Console.WriteLine("motherboard: {0}\nram {1}\ncpu: {2}", c1.motherboard, c2.getram, c2.getcpu);
            */



            /*
            Student s1 = new Student("Ahemed","amman",-18);
            Student s2 = new Student("belal", "Irbid", 17);
            if (s1.getage > s2.getage)
                Console.WriteLine(s1.getname+"  older than  "+s2.getname);
            else
                Console.WriteLine(s2.getname + "  older than  " + s1.getname);
            */




            /*                  //example 3
            A a = new A();   //we can not make objects of static classes ...we enter directly
            A.print();
            */


            /*                       //example 4
             abc a = new abc();
             a.pi;     //false because it is a const variable
             Console.WriteLine(a.name);
             a.name = "khaled";          //we just can read the name...we can change it just inside constructot
            */


            /*
             Random x = new Random();
             Console.WriteLine(x.Next());   //will print any number
             Console.WriteLine(x.Next(5));   //will print any number bwtween 0-4
             Console.WriteLine(x.Next(4, 9));  //will print any number between 4-8
             Random v = new Random(5);       //when we put a pn integer value in parameter ...this mean the number will be the same like the first one that generated
             for (int i = 0; i < 3; i++)
                 Console.WriteLine(v.Next());
             Random c = new Random();
             Console.WriteLine(c.Next(1,5) * 5);
             */



            /*
            Console.WriteLine(Math.Floor(3.3)); //the nearst integer number under it
            Console.WriteLine(Math.Ceiling(3.3));  //the nearest integer number abov it
            Console.WriteLine(Math.PI ) ;
            Console.WriteLine(Math.E);
            */



            /*
            //ways of declare an array
            int[] arr = { 1, 2, 3 };
            int[] arr1 = new int[5] { 1, 2 ,3,4,5};
            int[] arr2 = new int[] { 1, 2, 3 };
            */



            /*
            int[,] arr = new int[2, 3];
            for (int i = 0; i < arr.GetLength(0); i++)     //the first dimentinal
                for (int j = 0; j < arr.GetLength(1); j++)    //the second dimentiona;
                    arr[i, j] = Convert.ToInt16(Console.ReadLine());
            //the defference between arr.Length and arr.GetLength(diemantional)
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.GetLength(0));
            */



            /*
            //jagged or ragged array
            //a jagged array is an array whose elements are array.the elements of a jagged can be of different dimenions and size.a jagged array is called an "array of arrays".
            int[][] jag = new int[4][];
            jag[0] = new int[4];         //there are four colon in this row 
            jag[1] = new int[2];         //there are two colon in this row
            jag[2] = new int[1];         //there are one colon in this row
            jag[3] = new int[3];         //there are three colon in this row
            */


            /*
            double[] s1 = new double[3] { 19, 26, 43 };
            double[] s2 = new double[3] { 19, 25.2, 46 };
            marks m1 = new marks(s1, 1, "ahmed");
            marks m2 = new marks(s2, 2, "Khaled");
            double sum1 = 0;
            double sum2 = 0;
            for(int i=0;i<3;i++)
            {
                sum1 = m1.mark[i];
                sum2 = m2.mark[i];
            }
            if (sum1 > sum2)
                Console.WriteLine("Name : {0}\nId : {1}\nsum of marks : {2}", m1.name, m1.id, sum1);
            else
                Console.WriteLine("Name : {0}\nId : {1}\nsum of marks : {2}", m2.name, m2.id, sum2);
            */


            /*
            student[] s = new student[3];
            for (int i = 0; i < s.Length; i++)
            {
                string n = Console.ReadLine();
                s[i] = new student(n);
            }
               
            s[0].name = "Khaled";
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i].name) ;
            */




            //single inheritance- from one class only(suppurt by c#.net,java)
            //multiple inheritance (suppurt by c++)


            /*                   //example 5
            person p1 = new programmer();   //it is a programmer object    //this is called polymorephism
            person p2 = new person();     //it is a person object
            */



            /*                    //example 6
            information n1 = new person();  //we can not make objects of abstract classes
            person n2 = new person();
            */



            /*                                 //example 7
            student s1 = new student("ahmed",34,18,19,10,40,"sport");
            s1.print1();
            */



            /*             example 8
            A a = new A();
            fun(a);
            B b = new B();
            fun(b);
            C c = new C();
            fun(c);
            */


            /*       //example 9
            operators a = new operators();
            Console.WriteLine(a.sum(2.3, 4, 5.1));
            Console.WriteLine(a.sum(2.4, 4.2, 5.4,6.7));
            */



            /*               //example 10
            int a = 9, b = 7;
            swap<int>(ref a,ref b);
            Console.WriteLine("a:{0}\nb:{1}", a, b);
            string n = "ahmed",m="mJed";
            swap<string>(ref n, ref m);
            Console.WriteLine("n:{0}\nm:{1}", n, m);
            */


            //I can not make inhertance from sealed classes but I can make object
            //if the function was sealed (not the whole class) here we can not make override for it when we make an inhertance


            /*            //example 11
            //we can not deteremine the access modefire for the members of interface
            //we can not make objects of interfaces
            //we degfine properties without implementation ...it is just to be override
            //interfaces doesnt have instance variable ..it is only has propreties
            //we can not make constructor of interfaces
            //the class that inherit from the interfacwe should make an implemntation for all the abstract method in the interface(all the methods is abstract inside the interface)
            //I can add variable for the interface just if we make get and set for it
            //interface can inherit another interface
            id m;
            m = new man(); //I can do like this
            */



            /*
            //?: operator
            //has the following form:         exp1? exp2 :exp3;
            //the ?: operator works the folloing way:
            //exp1 is evaluated if it is true,then exp2 is evaluated and becomes the value of the entire expression,if exp1 is flase then exp3 is evaluted and its value becomes the value of the expression
            int age=42;
            string msg;
            msg = (age >= 18) ? "welcome" : "sorry";
            Console.WriteLine(msg);
            */



            Console.ReadKey();
        }


        /*                  //example 8
        static void fun(A abs)          //if we make the base class in parameter we can pass the child class of it
        {
            abs.print();
        }
        */

        
          /*             //example 10
        // generic methods
        static void swap<t>(ref t x,ref t y)
        {
            t f = x;
            x = y;
            y = f;
        }
        static  t sum<t>(t x,t y)
        {
            return x + y;    //error ..we can not make like this operator like + or - etc... in generic methods.
        }
        static t sir<t>(t x,t y)
        {
            return x;
        }
        */
    }
    /*                          //example 2
    class Computer
    {
        public string motherboard;
        int ram;
        string cpu;
        public Computer(string motherboard)
        {
            this.motherboard = motherboard;
        }
        public Computer() { }
        public int getram
        {
            get { return ram; }
            set { ram = value;}
        }
        public string setcpu
        {
            set { cpu = value; }
        }
        public string getcpu
        {
            get { return cpu; }
        }
    }
    */



    /*
    class Student
    {
        string name;
        string location;
        int age;
        public int setage
        {
            set
            {
                if (value > 0)
                    age = value;
                else if (value == 0)
                    age = 18;
                else
                    age = value * -1;
            }
        }
        public string getname
        {
            get { return name; }
        }
        public Student(string n, string m,int a)
        {
            name = n;
            location = m;
            setage = a;
        }
        public int getage
        {
            get { return age; }
        }
    }
    */



    /*                  example 3
    //if the class was static  all the members should be static 
    static class A
    {
        static int p;
        static public void print() { Console.WriteLine("hi"); }
        public static int getp { get { return p; } }
    }
    */


    /*                    //example 4
        class abc
        {
            public const double pi = 3.14;
            public readonly string name = "Ahmed";
            public abc()
            {
                name = "mhammed";
            }
        }
    */



    /*
    class marks
    {
        public double[] mark;
        public int id;
        public string name;
        public marks(double[] m, int i, string n)
            {
            mark = new double[3];
            mark = m;
            id = i;
            name = n;
            }
    }
    */


    /*
    class student
    {
        public string name;
        public student(string _name) { name = _name; }
    }
    */


    /*              //example 5
  class person
  {    
  }
  class programmer: person
  {
  }
  */



    /*
    abstract class information                  //example 6
    {
        public string name;
        public int id;
        public abstract void print();
        public abstract string getname
        {
            get;
            set;
        }
    }
    class person:information
    {
        public override void print()
        {
            Console.WriteLine("jaber ibn hayyean");
        }
        public override string getname
        {
            get { return name; }
            set { name = value; }
        }
    }
   */


    /*                                                       //example 7
    //compistion
    class Marks
    {
        public double firstmark;
        public double secondmark;
        public double thirdmark;
        public double finalmark;
        public double clac()
        {
            double sum = firstmark + secondmark + thirdmark + finalmark;
            return sum;
        }
        public Marks(double f,double s,double t,double fa)
        {
            firstmark = f;
            secondmark = s;
            thirdmark = t;
            finalmark = fa;
        }
    }

    class student
    {
        string name;
        int id;
        Marks mark;
        string major;
        public void print()
        {
            mark.firstmark = 50;
            Console.WriteLine(mark.firstmark);
        }
        public student(string name, int id,double f,double s,double t,double fa,string major)
        {
            this.name = name;
            this.id =id;
            this.major = major;
            mark = new Marks(f, s, t, fa);
        }
        public void print1()
        {
            Console.WriteLine("Name:{0}\nId:{1}\nMajor:{2}", name, id, major);
            Console.WriteLine("firstmark:{0}\nsecondmark:{1}\nthirdmark:{2}\nfinalmark:{3}", mark.firstmark, mark.secondmark, mark.thirdmark, mark.finalmark);
            Console.WriteLine("your total mark is:{0}", mark.clac());
        }
    }
    */



    /*                //example 8
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("from A");
        }
    }
    class B:A
    {
        public override void print()
        {
            Console.WriteLine("from B");
        }
    }
    class C:A
    {
        public override void print()
        {
            Console.WriteLine("from C");
        }
    }
    */



    /*                     //example 9
    class operators
        {
            public double sum(params double [] a)   //amount of parameter as I like
        {
            double sum1 = 0;
            for (int i = 0; i < a.Length; i++)
                sum1 += a[i];
            return sum1;
        }
        }
    */


/*          //example 11
    interface id
    { string Name { set; get; } }
    class man:id
    {
        string name;
        public string Name           //we should put public on the metodes of interface when we do reimplement
        {
            get { return name;}
            set { name = value; }
        }
    }
    */
 


}

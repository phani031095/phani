using System;

namespace infinite
{
    class Program
    {
        static void Main(string[] args)
        {
             string str1 =Console.ReadLine();
            string str2 =Console.ReadLine();
            int [] input1 =new int[str1.Length];
            int [] input2 =new int[str2.Length];
            void add (string str ,string stv,int diff)
            {
                  int [] sum =new int[diff];
                input1=convert1(str);
                input2=convert1(stv);
          for(int c=sum.Length-1;c>=0;c--)
               {
                   int rem=input2[c]+input1[c];
                   if(rem>10)
                   {
                       int add1=rem/10;
                       input1[c-1]=input1[c-1]+add1;
                       rem=rem%10;
                   }
                   sum[c]=rem;
 }                 
                for(int i=0;i< sum.Length;i++)
                    Console.Write(sum[i]);
                    
            }
            int [] convert1(string st)
            {    int i=0;
                 int [] input =new int[st.Length];
                foreach(char ch in st.ToCharArray())
                {
                   input[i] =Convert.ToInt32(ch.ToString());
                    i++;
                }
                return input;
            }
       if(str1.Length>str2.Length) 
            add(str1,(str2.PadLeft(input1.Length, '0')),str1.Length ); 
    else if(str1.Length<str2.Length)
         add(str2,(str1.PadLeft(str2.Length, '0')),str2.Length);
         else
                  add(str1,str2,str1.Length);
         
         }
    }
}

using System;
using System.ComponentModel;

public class Program
{
	public static void Main()
	{
        //Mr Jensen hates comments, because his job doesnt do that
        //just do better variable names

        //clean code 
        //Naming matters
        //"u is utah sales tax" is the wrong way to document this 
        double u = 4.5;
        int w = 0;
        //comments are nice but your code should be self documenting

        //the right way to tell someone what your double is
        double utahSalesTax = 4.5;

        //pascalCase - header things, class, method global attributes, properties
        //camelCase - variables, method parameters(string flipFlop);


        //if you are going to comment you have to say, here is what is acceptable 
        // Why not What 

        //we have to use a special utah salestax because of policy 6401
        double utahspecial6401policysalestax = 4.5;
	}
}
using System.Runtime.CompilerServices;

namespace CSharp12
{
    public static class InlineArraysDemo
    {
        public static void Run(){
            var buffer = new InLineBuffer();
            for(int i =0; i<3; i++){
                buffer[i]=  i;
            }

            foreach (var i in buffer){
                Console.WriteLine(i);
            }
        }
    }


[InlineArray(3)] // Define a fixed-size array with 3 elements
struct InLineBuffer
{
    // Declare private backing fields for the array elements.
    private int _element0;
}

}
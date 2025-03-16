namespace CSharp8
{
  

    /// <summary>
    /// Represents a temporary buffer that is stack-allocated using a ref struct.
    /// </summary>
    ref struct TemporaryBuffer
    {
        private Span<byte> _buffer;

        /// <summary>
        /// Initializes the buffer with a given size.
        /// </summary>
        /// <param name="size">Size of the buffer.</param>
        public TemporaryBuffer(int size)
        {
            _buffer = new byte[size]; // Stack-allocated buffer
            Console.WriteLine($"Temporary buffer of {size} bytes allocated.");
        }

        /// <summary>
        /// Writes data into the buffer.
        /// </summary>
        public void WriteData()
        {
            _buffer.Fill(1); 
            Console.WriteLine("Data written to buffer.");
        }

        /// <summary>
        /// Releases the buffer when no longer needed.
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Buffer released.");
        }
    }

    /// <summary>
    /// Demonstrates the use of the 'disposable ref struct' feature introduced in C# 8.0
    /// </summary>
    public static class DisposableRefStructDemo
    {
        public static void Run()
        {
            using (var buffer = new TemporaryBuffer(10))
            {
                buffer.WriteData();
            }

            Console.WriteLine("Buffer scope exited.");
        }
    }
}
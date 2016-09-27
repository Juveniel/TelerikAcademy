namespace Matrix.Contracts
{
    public interface IWriter
    {
        void WriteLine(string format = null, object obj = null);

        void Write(string format = null, object obj = null);
    }
}
namespace IdexerInCSharp
{
    public class GenericXodim<T> 
    {
        private T[] genericxodim = new T[9];

        public T this[int index] 
        {
            get 
            {
                return genericxodim[index];
            }
            set 
            {
                genericxodim[index] = value;
            }
        }
    }
}
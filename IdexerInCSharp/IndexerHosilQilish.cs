namespace IdexerInCSharp
{
    public class IndexerHosilQilish
    {
        private int[] massiv = new int[4];
        
        public int this[int index]
        {
            get
            {
                return massiv[index];
            }
            set 
            {
                massiv[index] = value;
            }
        }
    }
}

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountDuplicateElements DupEle = new CountDuplicateElements();
            DupEle.Count_Duplicate_Elements();

            UniqueElements uniqueEle = new UniqueElements();
            uniqueEle.Unique_Elements();
                
            CountFrequentEle countFrequentEle = new CountFrequentEle();
            countFrequentEle.Count_Frequency();

            PrintPattern printPattern = new PrintPattern();
            printPattern.Prin_tPattern();

            BoxPattern boxPattern = new BoxPattern();
            boxPattern.Box_Pattern();

            ReverseEachWord reverseEachWord = new ReverseEachWord();
            reverseEachWord.Reverse_EachWord();

            Matrix matrix = new Matrix();
            matrix.Rows_Of_Matrix();







        }
}
}
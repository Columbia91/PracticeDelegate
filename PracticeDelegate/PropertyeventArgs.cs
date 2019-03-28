namespace PracticeDelegate
{
    public class PropertyeventArgs
    {

        public int Sum { get; }
        public string Message { get; }
        public PropertyeventArgs(int sum, string message)
        {
            Sum = sum; Message = message;
        }
    }
}
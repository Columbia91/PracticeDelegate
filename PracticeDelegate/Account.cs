namespace PracticeDelegate
{
    public class Account : iPropertychanged
    {
        public event PropertyeventHandler Propertychanged;
        private int Sum { get; set; }
        public Account(int sum)
        {
            Sum = sum;
        }

        public void Put(int sum, string sender)
        {
            Sum += sum;
            Propertychanged(sender, new PropertyeventArgs(sum, $"На ваш счет поступили средства"));
        }
    }
}
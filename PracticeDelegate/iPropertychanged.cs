namespace PracticeDelegate
{
    public delegate void PropertyeventHandler(object sender, PropertyeventArgs e);
    public interface iPropertychanged
    {
        event PropertyeventHandler Propertychanged;
        void Put(int sum, string sender);
    }
}
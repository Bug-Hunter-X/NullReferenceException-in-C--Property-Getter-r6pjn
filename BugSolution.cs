public class ExampleClass
{
    private int _myField = 0; // Initialize the backing field

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here
        if (MyProperty > 10)
        {
            //Do something
        }
    }
}
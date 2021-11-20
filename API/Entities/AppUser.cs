namespace API.Entities
{
    public class AppUser
    {
// This auto increments the id field on databases. 
        public int Id { get; set; }
// public means that that this property can be get or set from any other class in our application. And the same applies for the class itself.
// Other options are: private, protected, internal.
        public string UserName { get; set; }

// But we can also use the full implementation of the property "propofol", which allows us to set the get and set the properties. 
        // private int myVar;

        // public int MyProperty
        // {
        //     get { return myVar; }
        //     set { myVar = value; }
        // }
    }
}
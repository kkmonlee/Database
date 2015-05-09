namespace Domain
{
    public class Person
    {
        //public static int Id;
        private int id;
        // Declares integer called id

        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public string UserName { get; set; }
        // Declares string called Username

        public string PassWord { get; set; }
        // Declares string called PassWord
        public override string ToString()
        {
            return UserName + " " + PassWord;
            // Overrides the ToString() function and replaces it with a space between UserName and PassWord
        }
    }
}
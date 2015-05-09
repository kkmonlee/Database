namespace Domain
{
    public class Person
    {
        public static int Id;
        private int id;
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public string UserName { get; set; }
        public string PassWord { get; set; }

        public override string ToString()
        {
            return UserName + " " + PassWord;
        }
    }
}
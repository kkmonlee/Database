namespace Domain
{
    public class Person
    {
        int id;
        public static int Id;
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public override string ToString()
        {
            return UserName + " " + PassWord;

        }
    }
}

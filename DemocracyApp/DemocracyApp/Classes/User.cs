namespace DemocracyApp.Classes
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1}", this.FirstName, this.LastName); } }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Grade { get; set; }

        public string Group { get; set; }

        public string Photo { get; set; }
    }
}

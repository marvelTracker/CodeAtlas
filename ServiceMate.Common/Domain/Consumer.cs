namespace CarMate.Common.Domain
{
    public class Consumer
    {
        public int ID { get; set; }
        public User User
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Profile Profile
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}

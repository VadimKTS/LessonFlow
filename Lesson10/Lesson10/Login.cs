namespace Lesson10
{
    public class Login 
    {
        private string confirmLogin;
        public string Value { get; set; } = "";
        public string ConfirmLogin
        {
            get { return confirmLogin; }
            set
            {
                if (!Value.Equals(value))//!!!!! Разобраться в этом...
                {
                    throw new LoginException("Пароли не совпадают!");
                }
                else
                {
                    confirmLogin = value;
                }
            }    
        }   
    }
}

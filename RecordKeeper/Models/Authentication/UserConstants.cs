namespace RecordKeeper.Models.Authentication
{
    public class UserConstants
    {
        public static List<UserModel> UsersList = new()
        {
            new()
            {
                UserName = "krishna", Email = "ta.ayi@gmail.com", Password = "Passwd", FirstName = "Krishn Teja",
                LastName = "Ayinala", Role = "Administrator"
            },
            new()
            {
                UserName = "test", Email = "test@gmail.com", Password = "test", FirstName = "Test",
                LastName = "Test", Role = "Administrator"
            },
        };
    }
}

public class User{
    [JsonField(Name = "user_name")]
    public string Name = "Aman";

    [JsonField(Name = "user_age")]
    public int Age = 21;
}
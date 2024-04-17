namespace WinFormsApp_anketForm.Models;
public class User
{
    public string Name {  get; set; }

    public string Surname {  get; set; }

    public string Father { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string PhoneNumber { get; set; }

    public DateTime Birthday { get; set; }

    public string Username { get; set; }

    public string Gender { get; set; }

    public User(string Surname,string Name,string Father,string Country,string City,string PhoneNumber,string Username,DateTime Birthday,string Gender)
    {
        this.Name = Name;
        this.Surname = Surname; 
        this.Father = Father;
        this.Country = Country;
        this.City = City;
        this.Username = Username;
        this.Birthday = Birthday;
        this.Gender = Gender;
    }


    public override string ToString()
    {
        return $"Surname: {Surname} \nName: {Name} \nFather :{Father} \nCountry: {Country} \nCity: {City} \nUsername: {Username} \nBirthday: {Birthday} \nGender: {Gender} \n";
    }

}

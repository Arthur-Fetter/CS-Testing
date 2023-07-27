using System.Text.Json;
using System.Text.Json.Serialization;

public class Person
{
    [JsonPropertyName("phone_number")]
    public string   Phone_number    { get; set; }
    [JsonPropertyName("first_name")]
    public string   First_name      { get; set; }
    [JsonPropertyName("last_name")]
    public string   Last_name       { get; set; }
    [JsonPropertyName("email")]
    public string?  Email           { get; set; }
    [JsonPropertyName("gender")]
    public string   Gender          { get; set; }
    [JsonPropertyName("profession")]
    public string?  Profession      { get; set; }
    [JsonPropertyName("language")]
    public string   Language          { get; set; }
}

public class Program
{
    public static async Task Main()
    {
        string jsonFile = "../../../../../../MOCK_DATA.json";
        string jsonData = await File.ReadAllTextAsync(jsonFile);
        var People = JsonSerializer.Deserialize<Person[]>(jsonData);

        /*Select all people that are teachers or professors*/
        var teachers =
            from teacher in People
            where teacher.Profession.Equals("Teacher") || teacher.Profession.Equals("Professor")
            orderby teacher.Email ascending
            select teacher.First_name;

        /*Select the names of all men whose phone number starts with a 1. Order by their profession (descending)*/
        var namesOfMalesWhoseNumbersStartWith1 = 
            People.Where(p => p.Phone_number.StartsWith("1") && p.Gender.Equals("Male"))
            .OrderByDescending(p => p.Profession)
            .Select(p => p.Last_name);

        /*Select all languages spoken by polygenders working in sales*/
        var polygenderLanguagesInCanada = 
            from polygender_language in People
            where polygender_language.Gender.Equals("Polygender") && polygender_language.Profession.Contains("Sales")
            select polygender_language.Language;

        /*Select the names of the people who work for the Canadian Government*/
        var peopleWorkingForTheEnemy =
            People.Where(enemy => enemy.Email.Contains("@ca.gov"))
            .Select(enemy => enemy.First_name);

        foreach ( var person in peopleWorkingForTheEnemy)
        {
            Console.WriteLine(person);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Coordinates
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}

public class Location
{
    public class Street
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

    public Street StreetInfo { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Postcode { get; set; }
    public Coordinates Coordinates { get; set; }
    public class Timezone
    {
        public string Offset { get; set; }
        public string Description { get; set; }
    }
    public Timezone TimezoneInfo { get; set; }
}

public class Name
{
    public string Title { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
}

public class Dob
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class Registered
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class Login
{
    public string Uuid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Md5 { get; set; }
    public string Sha1 { get; set; }
    public string Sha256 { get; set; }
}

public class Picture
{
    public string Large { get; set; }
    public string Medium { get; set; }
    public string Thumbnail { get; set; }
}

public class Id
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class Person
{
    public string Gender { get; set; }
    public Name NameInfo { get; set; }
    public Location LocationInfo { get; set; }
    public string Email { get; set; }
    public Login LoginInfo { get; set; }
    public Dob DobInfo { get; set; }
    public Registered RegisteredInfo { get; set; }
    public string Phone { get; set; }
    public string Cell { get; set; }
    public Id IdInfo { get; set; }
    public Picture PictureInfo { get; set; }
    public string Nat { get; set; }
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
}

public static class JsonExtensions
{
    public static string ToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public static T FromJson<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}

public static class ReflectionExtensions
{
    public static string ObjectToJson(object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public static T JsonToObject<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}

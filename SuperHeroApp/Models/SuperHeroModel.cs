using Newtonsoft.Json;

namespace SuperHeroApp.Models
{
    public class SuperHeroModel
    {
        public superhero[] results { get; set; }
    }

    public class superhero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PowerDetails Powerstats { get; set; }
        public BiographyDetails Biography { get; set; }
        public WorkDetails Work { set; get; }
        public ConnectionDetails Connections { set; get; }
        public AppearanceDetails Appearance { get; set; }   
        public ImageModel Image { get; set; }
    }

    public class WorkDetails
    {
        public string Occupation { get; set; }
        public string Base { get; set; }
    }

    public class PowerDetails
    {
        public int Intelligence { set; get; }
        public int Strength { set; get; }
        public int Speed { set; get; }
        public int Durability { set; get; }
        public int Power { set; get; }
        public int Combat { set; get; }
    }

    public class BiographyDetails
    {
        public string Fullname { set; get; }

        [JsonProperty(PropertyName = "alter-egos")]
        public string Alter_egos { set; get; }

        [JsonProperty(PropertyName = "place-of-birth")]
        public string Place_of_birth { set; get; }

        [JsonProperty(PropertyName = "first-appearance")]
        public string First_appearance { set; get; }

        public string Publisher { set; get; }
        public string Alignment { set; get; }

    }

    public class ConnectionDetails
    {
        [JsonProperty(PropertyName = "group-affiliation")]
        public string Group_affiliation { set; get; }
        public string Relatives { set; get; }
    } 

    public class AppearanceDetails
    {
        public string Gender { set; get; }
        public string Race { set; get; }
        [JsonProperty(PropertyName = "eye-color")]
        public string Eye_color { set; get; }

        [JsonProperty(PropertyName = "hair-color")]
        public string Hair_color { set; get; }
    }

    public class ImageModel
    {
        public string Url { get; set; }
    }
}

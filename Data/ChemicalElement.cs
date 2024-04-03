public class Rootobject
{
    public List<Element> elements { get; set; }
}

public class Element
{
    public string name { get; set; }
    public string symbol { get; set; }
    public int atomicNumber { get; set; }
    public float atomicWeight { get; set; }
    public int group { get; set; }
    public int period { get; set; }
    public List<Usage> usage { get; set; }
    
    public List<Isotopes> isotopes { get; set; }
}

public class Usage
{
    public string name { get; set; }
    public string description { get; set; }
    public string photo { get; set; }
}

public class Isotopes
{
    public int mass { get; set; }
    public float? naturalAbundance { get; set; }
    public string symbol { get; set; }
    public string name { get; set; }
}
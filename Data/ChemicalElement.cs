﻿public class Rootobject
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
    public Occurrence? occurrence { get; set; }

    public bool IsMetal()
    {
        var nonMetalsNumber = new List<int> {1, 2, 5, 6, 7, 8, 9, 10, 14, 15, 16, 17, 18, 33, 34, 35, 36, 52, 53, 54, 85, 86, 118};
        
        return !nonMetalsNumber.Contains(atomicNumber);
    }
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

public class Occurrence
{
    public string name { get; set; }
    public string photo { get; set; }
}
public class Rootobject
{
    public Element[] elements { get; set; }
}

public class Element
{
    public string name { get; set; }
    public string appearance { get; set; }
    public float atomic_mass { get; set; }
    public float? boil { get; set; }
    public string category { get; set; }
    public float? density { get; set; }
    public string discovered_by { get; set; }
    public float? melt { get; set; }
    public float? molar_heat { get; set; }
    public string named_by { get; set; }
    public int number { get; set; }
    public int period { get; set; }
    public int group { get; set; }
    public string phase { get; set; }
    public string source { get; set; }
    public string bohr_model_image { get; set; }
    public string bohr_model_3d { get; set; }
    public string spectral_img { get; set; }
    public string summary { get; set; }
    public string symbol { get; set; }
    public int xpos { get; set; }
    public int ypos { get; set; }
    public int wxpos { get; set; }
    public int wypos { get; set; }
    public int[] shells { get; set; }
    public string electron_configuration { get; set; }
    public string electron_configuration_semantic { get; set; }
    public float? electron_affinity { get; set; }
    public float? electronegativity_pauling { get; set; }
    public float?[] ionization_energies { get; set; }
    public string cpkhex { get; set; }
    public Image image { get; set; }
    public string block { get; set; }
}

public class Image
{
    public string title { get; set; }
    public string url { get; set; }
    public string attribution { get; set; }
}
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Data;

public interface IChemicalElementService
{
    Task<Rootobject> GetChemicalElements();
}
public class ChemicalElementService : IChemicalElementService
{
    public async Task<Rootobject> GetChemicalElements()
    {
        await using Stream fileStream = await FileSystem.OpenAppPackageFileAsync("PeriodicTableJSON.json");
        using var reader = new StreamReader(fileStream);

        var json = await reader.ReadToEndAsync();

        var elements = JsonConvert.DeserializeObject<Rootobject>(json);
        return elements!;
    }
}

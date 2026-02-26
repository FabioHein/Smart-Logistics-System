using SmartLogistics.src.Items;
using SmartLogistics.src.Enums;
using System.Globalization;
using SmartLogistics.src.Interfaces;
using SmartLogistics.src.Services;

var kisten = new LoadingStation();
List<Freight> fracht = new List<Freight>();

fracht.Add(new SteelBeam("HEB 240", 800));
fracht.Add(new ChemicalDrum("00-25", 250, HazardClass.Toxic));

foreach(var palette in fracht)
{
    palette.GetLoadingInstruction();

    if (palette is IHeavyLoad e)
    {
        e.SecureWithChains();
    }
    if (palette is IRefrigerated a)
    {
        a.CheckTemperature();
    }
}
double ergebniss = kisten.LoadingMath(fracht);


Console.WriteLine($"Die Fracht hat {ergebniss}kg.");


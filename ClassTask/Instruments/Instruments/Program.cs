using Instruments.Models;

Flute flute = new Flute()
{
    Model = "I don't know 1",
    Brand = "I really don't know 1",
    Price = 600,
    Color="Cold"
};

Guitar guitar = new Guitar()
{
    Model = "I don't know 2",
    Brand = "I really don't know 2",
    Price = 1000,
    Type = "Elektro"
};

Piano piano = new Piano()
{
    Model = "I don't know 2",
    Brand = "I really don't know 2",
    Price = 1000,
    Key = 88
};

Instrument[] Instruments = {flute, guitar, piano};

PrintAllInstruments(Instruments);

static void PrintAllInstruments(Instrument[] Instrument)
{
    foreach (var item in Instrument)
    {
        Console.WriteLine($"Instrument: {item.GetType().Name}");
        Console.WriteLine($"Sound: {item.Sound()}");
        item.GetType().GetProperties().ToList().ForEach(x =>
        {
            Console.WriteLine($"{x.Name}: {x.GetValue(item)}");
        });
        Console.WriteLine("***********");
    }
}
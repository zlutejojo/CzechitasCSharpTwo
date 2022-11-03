using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// Definice Banky
public class Banka
{
    public string Symbol { get; set; }
    public string Jmeno { get; set; }
}

// Definice Zákazníka
public class Zakaznik
{
    public string Jmeno { get; set; }
    public double Zustatek { get; set; }
    public string Banka { get; set; }
}

// Definice Skupiny milionářů
public class SkupinaMilionaru
{
    public string Banka { get; set; }
    public IEnumerable<string> Milionari { get; set; }
}


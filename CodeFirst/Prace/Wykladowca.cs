using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class Wykladowca
{
    public int IdWykladowcy { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public int NrWykladowcy { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Temat> Temats { get; set; } = new List<Temat>();
}

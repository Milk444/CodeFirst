using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class WersjaPracy
{
    public int IdWersji { get; set; }

    public int IdTematu { get; set; }

    public DateTime Data { get; set; }

    public string Plik { get; set; } = null!;

    public virtual Temat IdTematuNavigation { get; set; } = null!;
}

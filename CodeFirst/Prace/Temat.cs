using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class Temat
{
    public int IdTematu { get; set; }

    public string Temat1 { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int IdWykladowcy { get; set; }

    public DateTime DataRozpoczecia { get; set; }

    public virtual Wykladowca IdWykladowcyNavigation { get; set; } = null!;

    public virtual ICollection<PracaStudentum> PracaStudenta { get; set; } = new List<PracaStudentum>();

    public virtual ICollection<WersjaPracy> WersjaPracies { get; set; } = new List<WersjaPracy>();
}

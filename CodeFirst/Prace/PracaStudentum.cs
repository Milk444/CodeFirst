using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class PracaStudentum
{
    public int IdPracystud { get; set; }

    public int IdTematu { get; set; }

    public int IdStudenta { get; set; }

    public virtual Student IdStudentaNavigation { get; set; } = null!;

    public virtual Temat IdTematuNavigation { get; set; } = null!;

    public virtual ICollection<Konsultacje> Konsultacjes { get; set; } = new List<Konsultacje>();
}

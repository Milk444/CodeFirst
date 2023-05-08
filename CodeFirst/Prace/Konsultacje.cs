using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class Konsultacje
{
    public int IdKonsultacji { get; set; }

    public int IdWykladowcy { get; set; }

    public int IdPracystud { get; set; }

    public DateTime Data { get; set; }

    public string? Notatki { get; set; }

    public virtual PracaStudentum IdPracystudNavigation { get; set; } = null!;
}

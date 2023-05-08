using System;
using System.Collections.Generic;

namespace CodeFirst.Prace;

public partial class Student
{
    public int IdStudenta { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public int NrAlbumu { get; set; }

    public string Kierunek { get; set; } = null!;

    public short Rok { get; set; }

    public string Semestr { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<PracaStudentum> PracaStudenta { get; set; } = new List<PracaStudentum>();
}

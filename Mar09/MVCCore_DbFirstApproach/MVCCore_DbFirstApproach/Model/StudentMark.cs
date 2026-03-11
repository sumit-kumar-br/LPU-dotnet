using System;
using System.Collections.Generic;

namespace MVCCore_DbFirstApproach.Model;

public partial class StudentMark
{
    public int SrNo { get; set; }

    public int? RollNo { get; set; }

    public int Physics { get; set; }

    public int Chem { get; set; }

    public int Maths { get; set; }

    public int? TotalMarks { get; set; }

    public int? Perc { get; set; }

    public virtual StudentInfo? RollNoNavigation { get; set; }
}

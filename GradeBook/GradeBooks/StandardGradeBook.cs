using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            Type = GradeBookType.Standard;
            IsWeighted = isWeight;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeLeetCode
{
    public interface IProblem
    {
        void ReadInput();
        void Solve();
        void ShowAnswer();
    }
}

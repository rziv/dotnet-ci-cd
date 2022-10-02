using System;

namespace calendar_matrix
{
    public interface ICalculator
    {
        int Add(int a, int b);
        string Mode { get; set; }
        event Action PoweringUp;
    }
}


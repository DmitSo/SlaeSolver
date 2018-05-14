namespace SlaeSolver
{
    //public delegate double[] SlaeSolvingMethod(Slae slae);

    public interface ISlaeSolvingMethod
    {
        double[] Solve(Slae slae);
    }
}

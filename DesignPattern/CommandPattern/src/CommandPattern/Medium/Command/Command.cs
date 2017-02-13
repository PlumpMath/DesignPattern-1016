namespace CommandPattern.Medium.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface Command
    {
        void Execute();
        void Undo();
        void Store();
        void Load();
    }
}

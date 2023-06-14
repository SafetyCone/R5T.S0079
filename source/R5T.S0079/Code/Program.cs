using System;
using System.Threading.Tasks;


namespace R5T.S0079
{
    class Program
    {
        static async Task Main()
        {
            await SemanticScripts.Instance.OpenProject();
        }
    }
}
using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0079
{
    [FunctionalityMarker]
    public partial interface ISemanticScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Open a C# project file.
        /// This is a basic hello-world operation for Roslyn semantics.
        /// </summary>
        public async Task OpenProject()
        {
            /// Inputs.
            var projectFilePath =
                Instances.ProjectFilePaths.Example_SimpleWithProjectReference
                ;


            /// Run.
            await Instances.SemanticsOperator.In_ProjectContext(
                projectFilePath,
                project =>
                {
                    Console.WriteLine(project.FilePath);
                    Console.WriteLine($"{project.Language}: language");
                });
        }
    }
}

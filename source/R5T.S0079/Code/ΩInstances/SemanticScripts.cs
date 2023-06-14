using System;


namespace R5T.S0079
{
    public class SemanticScripts : ISemanticScripts
    {
        #region Infrastructure

        public static ISemanticScripts Instance { get; } = new SemanticScripts();


        private SemanticScripts()
        {
        }

        #endregion
    }
}

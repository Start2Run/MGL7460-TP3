using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;

            


            String restApiApp = "dotnet build " + @"""C:\RestApi-main\src\RestApiApp\RestApiApp.csproj""";
            String specFlowBDD = "dotnet build " + @"""C:\RestApi-main\tests\SpecFlow-BDD\SpecFlowBDD.csproj""";
            String persistenceTests = "dotnet build " + @"""C:\RestApi-main\tests\PersistenceTests\PersistenceTests.csproj""";
            String apiConnectionTests = "dotnet build " + @"""C:\RestApi-main\tests\ApiConnectionTests\ApiConnectionTests.csproj""";

            List<string> myUrls = new List<string>();


            myUrls.Add(restApiApp);
            myUrls.Add(specFlowBDD);
            myUrls.Add(persistenceTests);
            myUrls.Add(apiConnectionTests);


            

            for (int i = 0; i < myUrls.Count; i++)
            {
                ExecuteCmd exe = new ExecuteCmd();
                exe.ExecuteCommandSync(myUrls[i]);
                exe.ExecuteCommandAsync(myUrls[i]);
            }

        }
    }
}

using PetaPoco.Providers;
using PetaPoco;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryDb
    {
        private static IDatabase _libraryDb;
        
        // singleton
        private LibraryDb() { }
        public static IDatabase GetDatabaseInstance()
        {
            if (_libraryDb == null)
            {
                InitializeDatabase();
            }
            return _libraryDb;
        }
        private static void InitializeDatabase()
        {
            _libraryDb = DatabaseConfiguration.Build()
                .UsingConnectionString("Server=.;Database=LibraryDb;Trusted_Connection=True;")
                .UsingProvider<SqlServerDatabaseProvider>()
                .UsingDefaultMapper<ConventionMapper>(m =>
                {
                    m.InflectTableName = (inflector, s) => inflector.Pluralise(inflector.Pascalise(s));
                    m.InflectColumnName = (inflector, s) => inflector.Pascalise(s);
                })
                .Create();
        }

    }
}

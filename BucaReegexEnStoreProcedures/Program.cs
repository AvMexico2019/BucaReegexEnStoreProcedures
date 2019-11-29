using System;
using SQLServer;
using INDAABIN_Utilerias;

namespace BucaReegexEnStoreProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\desa21\source\repos\BucaReegexEnStoreProcedures\BucaReegexEnStoreProcedures\Resultados\SPs.txt"))
            {
                var results = ctx.Database.SqlQuery<INFORMATION_SCHEMA_Result>("SELECT ROUTINE_NAME, ROUTINE_DEFINITION FROM INFORMATION_SCHEMA.ROUTINES");
                foreach (var reg in results)
                {
                    if (U.IsExcelNull(reg.ROUTINE_DEFINITION))
                    {
                        file.WriteLine(reg.ROUTINE_NAME + " ......< definición vacia");
                    }
                    else
                    {
                        if (UserDefinedFunctions.fncRegexFind("Cat_Parametro", reg.ROUTINE_DEFINITION.Equals(null) ? " " : reg.ROUTINE_DEFINITION))
                        {
                            file.WriteLine("NAME >> " + reg.ROUTINE_NAME + " <<");
                            file.WriteLine("---------------------------------");
                            file.WriteLine(reg.ROUTINE_DEFINITION);
                            file.WriteLine("////////////////////////////==================================");
                        }
                    }

                }        
            }
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }

    public  class INFORMATION_SCHEMA_Result
    {
        public string ROUTINE_NAME { get; set; }
        public string ROUTINE_DEFINITION { get; set; }
    }
}

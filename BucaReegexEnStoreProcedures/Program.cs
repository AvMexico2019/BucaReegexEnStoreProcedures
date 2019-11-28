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
            SQL_Formatter.Formatter fmtr = new SQL_Formatter.Formatter();

            var results = ctx.Database.SqlQuery<INFORMATION_SCHEMA_Result>("SELECT ROUTINE_NAME, ROUTINE_DEFINITION FROM INFORMATION_SCHEMA.ROUTINES");
            foreach(var reg in results)
            {
                if (U.IsExcelNull(reg.ROUTINE_DEFINITION))
                {
                    Console.WriteLine(reg.ROUTINE_NAME + " ......< definición vacia");
                }
                else
                {
                    if (UserDefinedFunctions.fncRegexFind("Folio", reg.ROUTINE_DEFINITION.Equals(null) ? " " : reg.ROUTINE_DEFINITION))
                    {
                        Console.WriteLine("NAME >> " + reg.ROUTINE_NAME + " <<");
                        Console.WriteLine(reg.ROUTINE_DEFINITION);
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.WriteLine(reg.ROUTINE_DEFINITION);
                        Console.WriteLine("////////////////////////////==================================");
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

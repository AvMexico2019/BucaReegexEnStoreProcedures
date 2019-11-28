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
            SQL_Formatter.Formatter formatter = new SQL_Formatter.Formatter();

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
                        Console.WriteLine(reg.ROUTINE_NAME);
                        Console.WriteLine(reg.ROUTINE_DEFINITION);
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.WriteLine(formatter.Format(reg.ROUTINE_DEFINITION, "LeadingCommas=False;LeadingJoins=True;RemoveComments=False"));
                        Console.WriteLine("////////////////////////////==================================");
                    }
                }
                   
            }
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
    // <TK11877:DESA21>TODO: blabkabkb  wñifgdfuqkjwa
    // <TK12980:DESA06>COMMENT: es necesario cambiar
    public  class INFORMATION_SCHEMA_Result
    {
        public string ROUTINE_NAME { get; set; }
        public string ROUTINE_DEFINITION { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERwin_CA
{
    public class ConfigFile : IDisposable
    {
        void IDisposable.Dispose()
        {

        }

        public static string LOG_FILE = @"C:\ERWIN\Log.txt";

        public static string TABELLE = "Censimento Tabelle";
        public static string COLONNA_01 = "SSA";
        public static int HEADER_RIGA = 3;
        public static int HEADER_COLONNA_MIN = 1;
        public static int HEADER_COLONNA_MAX = 10;
        public static int HEADER_MAX_COLONNE = 10;

        public static int SSA;

        public static Dictionary<string, int> _TABELLE = new Dictionary<string, int>()
        {
            {"SSA", 1 },
            {"Nome host", 2 },
            {"Nome Database", 3 },
            {"Schema", 4 },
            {"Nome Tabella", 5 },
            {"Descrizione Tabella", 6 },
            {"Tipologia Informazione", 7 },
            {"Perimetro Tabella", 8 },
            {"Granularità Tabella", 9 },
            {"Flag BFD", 10 }
        };

        public static Dictionary<string, string> _TAB_NAME = new Dictionary<string, string>()
        {
            {"SSA", "ENTITY.PHYSICAL.SSA" },
            {"Nome host", "DB2_Database.Physical.NOME.HOST" },
            {"Nome Database", "Name" },
            {"Schema", "Name_Qualifier" },
            {"Nome Tabella", "Physical_Name" },
            {"Descrizione Tabella", "Comment" },
            {"Tipologia Informazione", "ENTITY.PHYSICAL.TIPOLOGIA_INFORMAZIONE" },
            {"Perimetro Tabella", "ENTITY.PHYSICAL.PERIMETRO_TABELLA" },
            {"Granularità Tabella", "ENTITY.PHYSICAL.GRANULARITA_TABELLA" },
            {"Flag BFD", "ENTITY.PHYSICAL.FLAG_BFD" }
        };

        public static string FILETEST = @"C:\ERWIN\CODICE\Extra\Test.xlsx";

    }
}

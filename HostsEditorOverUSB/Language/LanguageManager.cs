using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostsEditorOverUSB.Core
{
    class LanguageManager
    {
        /* I'm working on this. */
        private static string[] germanLanguage = { "Datei", "Über", "Einstellungen", "Logs speichern", "Schließen", "Credits", "Info", "GUI Einstellungen", "Sprache", "Warten auf USB-Verbindung" };
        private static string[] frenchLanguage = { "Fichier", "Environ", "Paramètres", "Sauver les logs", "Fermeture", "Credits", "Info", "GUI Paramètres", "Langue", "En attente de connexion USB" };
        private static string[] spainLanguage = { "Archivo", "Acerca de", "Ajustes", "Guardar Registros", "Cierre", "Credits", "Info", "GUI Registros", "Idioma", "A la espera de la conexión USB" };
        public static void setLanguage(Language lan)
        {
           
            switch (lan)
            {
                case Language.ENGLISH:
                case Language.GERMAN:
                case Language.FRENCH:
                case Language.SPAIN:
                default:
                    break;
            }
        }
    }
}

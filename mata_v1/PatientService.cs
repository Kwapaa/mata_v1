using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    public class PatientService
    {
        public static string savePatient(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(MainSettings.Default.PatientFolderPath) || !Directory.Exists(MainSettings.Default.PatientFolderPath))
            {
                MessageBox.Show("Brak ścieżki w konfiguracji, lub folder nie istnieje");
                return "Brak ścieżki w konfiguracji, lub folder nie istnieje";
            }
            else
            {
                var json = JsonConvert.SerializeObject(patient);
                System.IO.File.WriteAllText(string.Format("{0}/{1}.json", MainSettings.Default.PatientFolderPath, patient.PESEL), json);

                return string.Format("Zapisano pacjenta");
            }

        }


    }
}

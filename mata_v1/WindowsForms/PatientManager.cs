using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    
    public partial class PatientManager : Form
    {
        private void reloadList()
        {
            cPatientList.DataSource = patientList;
            cPatientList.DisplayMember = ("PESEL");
            cPatientList.Refresh();
        }

        List<Patient> patientList = new List<Patient>();

        public PatientManager()
        {
            InitializeComponent();
            string path = MainSettings.Default.PatientFolderPath;
            if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
            {
                DirectoryInfo info = new DirectoryInfo(path);
                foreach (var file in info.GetFiles("*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Patient patient = (Patient)serializer.Deserialize(fi, typeof(Patient));
                        patientList.Add(patient);
                    }
                }
                //foreach (var patient in patientList)
                //{
                //    ComboboxItem item = new ComboboxItem();
                //    item.Text = string.Format("{0} {1}", patient.imie, patient.nazwisko);
                //    item.Value = patient;

                //    cPatientList.Items.Add(item);
                //}

                cPatientList.DataSource = patientList;
                cPatientList.DisplayMember = ("PESEL");
            }
        }
       
        private void bPatientChoose_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if (cPatientList.SelectedItem != null)
            {
                var tmp = cPatientList.SelectedItem as Patient;
                
                // cPatientList.DataSource
                //Patient patp1ient = (Patient)cPatientList.Items[0];
                //ComboboxItem item = cPatientList.SelectedItem.ToString() ;
            }
            else
            {
                //todo error
            }
        }

        private void cPatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = cPatientList.SelectedItem as Patient;
            tPatientName.Text = tmp.imie;
            tPatientLastname.Text = tmp.nazwisko;
            tPatientPESEL.Text = tmp.PESEL;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bPatientAddNew_Click(object sender, EventArgs e)
        {
            tPatientName.Clear();
            tPatientLastname.Clear();
            tPatientPESEL.Clear();
        }

        private void bPatientSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tPatientName.Text) && !string.IsNullOrWhiteSpace(tPatientLastname.Text) && !string.IsNullOrWhiteSpace(tPatientPESEL.Text))
            {
                Patient patient = new Patient()
                {
                    imie = tPatientName.Text,
                    nazwisko = tPatientLastname.Text,
                    PESEL = tPatientPESEL.Text
                };
                patientList.Add(patient);
                MessageBox.Show(PatientService.savePatient(patient));

                reloadList();
                cPatientList.SelectedItem = patient;
            }
            else
                MessageBox.Show(text: "Nie wprowadzono wszystkich danych");

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public Patient Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}

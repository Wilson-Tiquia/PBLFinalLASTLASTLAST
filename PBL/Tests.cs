using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PBL
{
   
    public partial class Tests : Form
    {
        

        public void populateHospitals()
        {
            List<string> hospitals = new List<string>();
            hospitals.Add("RESEARCH INSTITUTE FOR TROPICAL MEDICINE (RITM)");
            hospitals.Add("PHILIPPINE RED CROSS (PRC)");
            hospitals.Add("PHILIPPINE RED CROSS LOGISTICS & MULTIPURPOSE CENTER");
            hospitals.Add("VICENTE SOTTO MEMORIAL MEDICAL CENTER (VSMMC)");
            hospitals.Add("LUNG CENTER OF THE PHILIPPINES(LCP)");
            hospitals.Add("BAGUIO GENERAL HOSPITAL AND MEDICAL CENTER (BGHMC)");
            hospitals.Add("SAN LAZARO HOSPITAL (SLH)");
            hospitals.Add("UP NATIONAL INSTITUTES OF HEALTH (UP-NIH)");
            hospitals.Add("WESTERN VISAYAS MEDICAL CENTER");
            hospitals.Add("ST.LUKE’S MEDICAL CENTER - BGC(SLMC - BGC)");
            hospitals.Add("DETOXICARE MOLECULAR DIAGNOSTICS LABORATORY");
            hospitals.Add("SOUTHERN PHILIPPINES MEDICAL CENTER(SPMC)");
            hospitals.Add("CHINESE GENERAL HOSPITAL (CGH)");
            hospitals.Add("THE MEDICAL CITY(TMC)");
            hospitals.Add("MAKATI MEDICAL CENTER");
            hospitals.Add("V.LUNA HOSPITAL");
            hospitals.Add("SINGAPORE DIAGNOSTICS");
            hospitals.Add("PHILIPPINE GENOME CENTER");
            hospitals.Add("MARIKINA MOLECULAR DIAGNOSTICS LIBRARY");
            hospitals.Add("DE LA SALLE UNIVERSITY - CAVITE");
            hospitals.Add("ZAMBOANGA CITY MEDICAL CENTER GENEXPERT LABORATORY");
            hospitals.Add("LUNG CENTER OF THE PHILIPPINES GENEXPERT LABORATORY");
            hospitals.Add("CEBU TB REFERENCE LABORATORY");
            hospitals.Add("UP-PGH MOLECULAR LABORATORY");
            hospitals.Add("EASTERN VISAYAS REGIONAL COVID TESTING CENTER");
            hospitals.Add("ALLEGIANT REGIONAL CARE HOSPITAL");
           
            for (int i =0; i <hospitals.Count;i++)
            {
                hospitalComboBox.Items.Add(hospitals[i]);
            }
        }


        public Tests()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void map_Click(object sender, EventArgs e)
        {
            Mapa_ni_Tiquia mapForm = new Mapa_ni_Tiquia();
            mapForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void equipments_Click(object sender, EventArgs e)
        {
            Equipments equipmentsForms = new Equipments();
            equipmentsForms.Show();
        }

    
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            TopMost = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 370;
            pictureBox6.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Width = 1290;
            this.Height = 770;
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
        }

        private void extend1_Click_1(object sender, EventArgs e)
        {
            panel16.Visible = true;
            map.Visible = true;
            casess.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            extend2.Visible = true;
            extend1.Visible = false;
        }

        private void extend2_Click_1(object sender, EventArgs e)
        {
            panel16.Visible = false;
            map.Visible = false;
            casess.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            extend2.Visible = false;
            extend1.Visible = true;
        }


        private void map_Click_1(object sender, EventArgs e)
        {
            Mapa_ni_Tiquia mapForm = new Mapa_ni_Tiquia();
            mapForm.Show();
        }

        private void casess_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();
        }

    

        private void openAdd_Click(object sender, EventArgs e)
        {
            cumulativePanel.Visible = true;
            hospitalLabel.Visible = true;
            hospitalPanel.Visible = true;
            hospitalComboBox.Visible = true;
            uniqueLabel.Visible = true;
            uniquePanel.Visible = true;
            uniqueTextBox.Visible = true;
            positiveLabel.Visible = true;
            positivePanel.Visible = true;
            positiveTextBox.Visible = true;
            negativeLabel.Visible = true;
            negativePanel.Visible = true;
            negativeTextBox.Visible = true;
            equivocalLabel.Visible = true;
            equivocalPanel.Visible = true;
            equivocalTextBox.Visible = true;
            invalidLabel.Visible = true;
            invalidPanel.Visible = true;
            invalidTextBox.Visible = true;
            totalLabel.Visible = true;
            totalPanel.Visible = true;
            totalTextBox.Visible = true;
            remainingLabel.Visible = true;
            remainingPanel.Visible = true;
            remainingTextBox.Visible = true;
            openAdd.Visible = false;
            closeAdd.Visible = true;
            saveButtonTest.Visible = true;
        }
        public void clearEntries()
        {
            // clear laman
            hospitalComboBox.Text = string.Empty;
            uniqueTextBox.Text = string.Empty;
            positiveTextBox.Text = string.Empty;
            negativeTextBox.Text = string.Empty;
            equivocalTextBox.Text = string.Empty;
            invalidTextBox.Text = string.Empty;
            totalTextBox.Text = string.Empty;
            remainingTextBox.Text = string.Empty;
            hospitalComboBox.Focus();


        }
        private void closeAdd_Click(object sender, EventArgs e)
        {
            clearEntries();
            cumulativePanel.Visible = false;
            hospitalLabel.Visible = false;
            hospitalPanel.Visible = false;
            hospitalComboBox.Visible = false;
            uniqueLabel.Visible = false;
            uniquePanel.Visible = false;
            uniqueTextBox.Visible = false;
            positiveLabel.Visible = false;
            positivePanel.Visible = false;
            positiveTextBox.Visible = false;
            negativeLabel.Visible = false;
            negativePanel.Visible = false;
            negativeTextBox.Visible = false;
            equivocalLabel.Visible = false;
            equivocalPanel.Visible = false;
            equivocalTextBox.Visible = false;
            invalidLabel.Visible = false;
            invalidPanel.Visible = false;
            invalidTextBox.Visible = false;
            totalLabel.Visible = false;
            totalPanel.Visible = false;
            totalTextBox.Visible = false;
            remainingLabel.Visible = false;
            remainingPanel.Visible = false;
            remainingTextBox.Visible = false;
            openAdd.Visible = true;
            closeAdd.Visible = false;
            saveButtonTest.Visible = false;
            hospitalComboBox.SelectedIndex = -1;
            listView1.Items.Clear();
            allHospitals();
        }

        private void openTest_Click(object sender, EventArgs e)
        {
            clearEntries();
            testPanel.Visible = true;
            hospitalLabel.Visible = true;
            hospitalComboBox.Visible = true;
            hospitalPanel.Visible = true;
            dateLabel.Visible = true;
            dateTimePicker1.Visible = true;
            datePanel.Visible = true;
            conductedLabel.Visible = true;
            conductedPanel.Visible = true;
            conductedTextBox.Visible = true;
            openTest.Visible = false;
            closeTest.Visible = true;
        }

        private void closeTest_Click(object sender, EventArgs e)
        {
            testPanel.Visible = false;
            hospitalLabel.Visible = false;
            hospitalComboBox.Visible = false;
            hospitalPanel.Visible = false;
            dateLabel.Visible = false;
            dateTimePicker1.Visible = false;
            datePanel.Visible = false;
            conductedLabel.Visible = false;
            conductedPanel.Visible = false;
            conductedTextBox.Visible = false;
            openTest.Visible = true;
            closeTest.Visible = false;
        }

        public void sort()
        {
            string hospital = hospitalComboBox.GetItemText(hospitalComboBox.SelectedItem);
            StreamReader sorter = new StreamReader(@"C:/Cumulative-Tests.txt");
            while (sorter.Peek() != -1)
            {
                string read = sorter.ReadLine();
                string[] splitRead = read.Split(',');
                string hospitalName = splitRead[0];
                string unique = splitRead[1];
                string positive = splitRead[2];
                string negative = splitRead[3];
                string equivocal = splitRead[4];
                string invalid = splitRead[5];
                string total = splitRead[6];
                string remaining = splitRead[7];
                if (hospitalName == hospital)
                {   
                    ListViewItem lvi = new ListViewItem(hospitalName);
                    lvi.SubItems.Add(unique);
                    lvi.SubItems.Add(positive);
                    lvi.SubItems.Add(negative);
                    lvi.SubItems.Add(equivocal);
                    lvi.SubItems.Add(invalid);
                    lvi.SubItems.Add(total);
                    lvi.SubItems.Add(remaining);
                    listView1.Items.Add(lvi);
                }
            }
            sorter.Close();


        }

        private void hospitalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sort();
        }
        public void allHospitals()
        {
            StreamReader allHospitals = new StreamReader(@"C:/Cumulative-Tests.txt");
            allHospitals.ReadLine();
            
            while (allHospitals.Peek()!=-1)
            {
                string allDetails = allHospitals.ReadLine();
                string[] splitDetails = allDetails.Split(',');
                string hospitalName = splitDetails[0];
                string unique = splitDetails[1];
                string positive = splitDetails[2];
                string negative = splitDetails[3];
                string equivocal = splitDetails[4];
                string invalid = splitDetails[5];
                string total = splitDetails[6];
                string remaining = splitDetails[7];
                ListViewItem hospitals = new ListViewItem(hospitalName);
                hospitals.SubItems.Add(unique);
                hospitals.SubItems.Add(positive);
                hospitals.SubItems.Add(negative);
                hospitals.SubItems.Add(equivocal);
                hospitals.SubItems.Add(invalid);
                hospitals.SubItems.Add(total);
                hospitals.SubItems.Add(remaining);
                listView1.Items.Add(hospitals);

            }
        }
        private void Tests_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            string selectedHospital = hospitalComboBox.GetItemText(hospitalComboBox.SelectedItem);
            if (selectedHospital == string.Empty)
            {
                allHospitals();
            }
            populateHospitals();
          
        }
        private void aboutUs_Click(object sender, EventArgs e)
        {
            SplashScreen aboutForm = new SplashScreen();
            aboutForm.Show();
        }

        private void saveButtonTest_Click_1(object sender, EventArgs e)
        {
            if (hospitalComboBox.Text == string.Empty)
            {
                MessageBox.Show("Input Hospital");
            }
            else
            {
                StreamWriter addTests = new StreamWriter(@"C:/Cumulative-Tests.txt", true);
                string hospital = hospitalComboBox.GetItemText(hospitalComboBox.SelectedItem);
                string empty = "0";
                // check condition if walang laman set mo sa 0
                if (uniqueTextBox.Text == string.Empty)
                {
                    uniqueTextBox.Text = empty;
                }
                if (positiveTextBox.Text == string.Empty)
                {
                    positiveTextBox.Text = empty;
                }
                if (negativeTextBox.Text == string.Empty)
                {
                    negativeTextBox.Text = empty;
                }
                if (equivocalTextBox.Text == string.Empty)
                {
                    equivocalTextBox.Text = empty;
                }
                if (invalidTextBox.Text == string.Empty)
                {
                    invalidTextBox.Text = empty;
                }
                if (totalTextBox.Text == string.Empty)
                {
                    totalTextBox.Text = empty;
                }
                if (remainingTextBox.Text == string.Empty)
                {
                    remainingTextBox.Text = empty;
                }
                for (int i  =0; i < hospitalComboBox.Items.Count - 1; i++) 
                {
                    if (hospital == hospitalComboBox.GetItemText(hospitalComboBox.Items[i]))
                    {
                        Console.WriteLine("meron na");

                    }
                    else
                    {
                        Console.WriteLine("wala pa po ");
                    }
                  
                }
                // i write line mo sa file
                MessageBox.Show("ADDED TESTS");
                string[] all = { hospitalComboBox.Text, ",", uniqueTextBox.Text, ",", positiveTextBox.Text, ",", negativeTextBox.Text, ",", equivocalTextBox.Text, ",", invalidTextBox.Text, ",", totalTextBox.Text, ",", remainingTextBox.Text };
                addTests.WriteLine();
                for (int i = 0; i < all.Length; i++)
                {
                    addTests.Write(all[i]);
                }
                addTests.Close();
                listView1.Items.Clear();
                clearEntries();
                allHospitals();
              
            }

        }

        private void hospitalComboBox_DropDown(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            allHospitals();
            sort();
        }

        private void mapShadow_Click(object sender, EventArgs e)
        {

        }
    }
}

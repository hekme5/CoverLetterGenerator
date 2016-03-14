using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCoverLetter
{
    public partial class Form1 : Form
    {
        public string theCL = "Dear Madam/Sir,\n\n\nMy name is Emile Issaelkhoury and I would greatly appreciate to be considered for the {0} position (ReqID: {1}) at {2} in {3}. I believe that I would be a good fit for this position because my experience with C#/ASP.NET/Java/JavaScript/SQL, my current clearance, my B.S. degree in Computer engineer and my will to learn and to be challenged at {2}.\n\nI currently work as a software engineer with Novetta Solutions. I work on both the front end and the back end of a client web service. I develop backend code with C#, ASP.Net, SQL, AutoFac and nHibernate. I also work on the frontend using Javascript and multiple libraries like Backbone, jQuery and KnockoutJS. My current project is an agile project using JIRA and my position is going away because of funding. I currently hold an active TS clearance but held a TS/SCI and a CI/poly.\n\nPrior to this position, I was working on government site with BAE system as a backend developer using C#, .NET, JavaScript and SQL. I fixed bugs and update geocoder on the customer Google earth client: it parses a queried string (address) and provides latitude and longitude after multiple database lookup. The geocoder uses a RESTful web service that I manage through IIS. It is also available with downloadable libraries (DLLs).  I used the .NET to create a status page of the geocoder containing multiple charts and tables.\n\nEarlier, I was working with Lockheed Martin Corporation in Gaithersburg, MD as a Software engineer Asc. I was working on the IEC-ASP program under Rochelle Jones management. My main task was software integration of COTS into a government customer. This includes virtualization using Microsoft App-V. I also deployed these new packages using SCCM 2012. I worked with automated test software like Selenium and PhantomJS to test our widgets (OWF). This program used JIRA as an agile environment.\n\nI graduated from the University of Maryland Baltimore County (UMBC) in Baltimore, MD with a BS in Computer Engineering in May 2013 with a GPA of 3.31. Some of my relevant class work in engineering includes Principles of Digital Design, Circuits, Systems Design and Programing (assembly), Communication lab and Signals and Systems, DSP and Communication engineering. Most of my engineering classes required labs with MATLAB. I have also taken classes in computer science such as in programing (Python), Data structure (Java), Operating Systems (C language) and computer architecture (VHDL).\n\nBefore attending UMBC, I served in the United States Army working as a TMDE specialist (Test Measurements and Diagnostic Equipment specialist, MOS: 94H) or calibration specialist. My main responsibility was to test, calibrate and repair electronic test equipment used by the military. For over five years, I was responsible for maintaining a wide range of equipment that the military used to adjust their own equipment like torq wrench, oscilloscopes and RF (Radio Frequency) equipment; In summary, my daily duties was to fix hardware for the armed forces in the field. I was also trained as a Human Intelligence Specialist or HUMINT (MOS:35M) with the Army Reserves. I was in that position for two years. I am also a native speaker in Arabic and French including reading and writing.\n\nDuring the summer of 2012, I interned at the Northrop Grumman’s BWI facility in Linthicum, MD. I worked on testing failing RF parts, IMU testing and data mining. I also wrote different programs for engineers in MATLAB.\n\nIf you would like to meet in person or have any questions please feel free to reach me at (703)678-5980 (cell) or via email at emileissak@gmail.com.\n\nThank you for your time and consideration, I look forward to hearing back from you soon.\n\nSincerely,\nEmile Issaelkhoury";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = String.Format(theCL, positionBox.Text, reqID.Text, companyBox.Text,location.Text );
            //System.IO.File.WriteAllText(@"C:\Users\emileMac\Desktop\CoverLetter_" + reqID.Text + ".txt", output);

            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\emileMac\Desktop\CoverLetter_" + reqID.Text + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);

            Document doc = new Document();


            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            doc.Add(new Paragraph(output));


            doc.Close();
            System.Diagnostics.Process.Start(@"C:\Users\emileMac\Desktop\CoverLetter_" + reqID.Text + ".pdf");
            Application.Exit();
            
        }
    }
}

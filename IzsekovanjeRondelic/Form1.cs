using CircleInRectangleLib;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IzsekovanjeRondelic
{
    public partial class Form1 : Form
    {
        Slug slugObject = new Slug();
        CircleInRectangle cir = new CircleInRectangle();
        double result = 0;
        public Form1()
        {
            InitializeComponent();
            getSlugsList();
        }

        private void buttonCalculate(object sender, EventArgs e)
        {

            result = cir.numberOfSlugs(257, 157, 1.7, 1);

            slugObject.lenght = 257;
            slugObject.width = 157;
            slugObject.radious = 1;
            slugObject.space = 1;
            slugObject.result = 3300;

            labResult.Text = slugObject.result.ToString();
            Console.WriteLine(slugObject.result);

            using (DBEntities db = new DBEntities())
            {
                db.Slugs.Add(slugObject);
                db.SaveChanges();
            }
            clearTxt();
            getSlugsList();
        }
        private void getSlugsList()
        {
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Slugs.ToList<Slug>();
            }
        }

        private void resetTextBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void clearTxt()
        {
            widthTxt.Text = "";
            lenghtTxt.Text = "";
            radiousTxt.Text = "";
            spaceTxt.Text = "";
            labResult.Text = "";
        }
    }
}

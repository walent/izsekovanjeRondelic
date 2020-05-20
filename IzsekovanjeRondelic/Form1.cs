using CircleInRectangleLib;
using IzsekovanjeRondelic.Db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IzsekovanjeRondelic
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        Slug slugObject = new Slug();
        CircleInRectangle cir = new CircleInRectangle();


        decimal result = 0;
        double tempLenght = 0;
        double tempWidth = 0;
        double tempradious = 0;
        double tempSpace = 0;
        public Form1()
        {
            InitializeComponent();
            getSlugsList();
            log.Info("Projekt incializiran");

        }
        // Izračun in dodajanje objekta v bazo
        private void buttonCalculate(object sender, EventArgs e)
        {
            try
            {
                tempLenght = Convert.ToDouble(lenghtTxt.Text);
                tempWidth = Convert.ToDouble(widthTxt.Text);
                tempradious = Convert.ToDouble(radiousTxt.Text);
                tempSpace = Convert.ToDouble(spaceTxt.Text);
                result = Convert.ToDecimal(cir.numberOfSlugs(tempLenght, tempWidth, tempradious, tempSpace));
                labResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vnos parametrov v nepravilnem formatu.");
                log.Error("Vnos parametrov v nepravilnem formatu");
            }

            slugObject.lenght = Convert.ToDecimal(tempLenght);
            slugObject.width = Convert.ToDecimal(tempWidth);
            slugObject.radious = Convert.ToDecimal(tempradious);
            slugObject.space = Convert.ToDecimal(tempSpace);
            slugObject.result = result;

            try
            {
                using (DBEntities db = new DBEntities())
                {
                    db.Slugs.Add(slugObject);
                    db.SaveChanges();
                    log.Info("Dodan nov zapis v Bazo. " + slugObject.ToString());
                }

                getSlugsList();
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka pri branju iz baze");
                log.Error("Napaka pri branju iz baze:");
            }
            // clearTxt();
        }

        // Pridobivanje zapisov iz baze
        private void getSlugsList()
        {
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    dataGridView1.DataSource = db.Slugs.ToList<Slug>();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Napaka pri branju iz baze");
                log.Error("Napaka pri branju iz baze:" + e);
            }

        }
        // Brisanje zapisov iz baze
        private void delateEntryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                slugObject.id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                if (MessageBox.Show("Ali želiš izbrisat zapis", "Izbris zapisa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        var zapis = db.Entry(slugObject);
                        if (zapis.State == System.Data.Entity.EntityState.Detached)
                            db.Slugs.Attach(slugObject);
                        db.Slugs.Remove(slugObject);
                        db.SaveChanges();
                        getSlugsList();
                        clearTxt();
                        log.Info("Izbrisan zapis :" + slugObject.id);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Brisanje neznanega vnosa");
                log.Error("Brisanje nenzanega vnosa:" + er);
            }

        }
        private void resetTextBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void clearTxt()
        {
            lenghtTxt.Text = "";
            widthTxt.Text = "";
            radiousTxt.Text = "";
            spaceTxt.Text = "";
            labResult.Text = "";

        }

    }
}

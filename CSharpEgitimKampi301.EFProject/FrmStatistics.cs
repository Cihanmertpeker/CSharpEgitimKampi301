using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            var locationCount = db.Location.Count();
            lblLocationCount.Text = locationCount.ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAverageCapacity.Text = db.Location.Average(x=>x.LocationCapacity).ToString();     
            lblAverageTourPrice.Text = db.Location.Average(x => (decimal)x.LocationPrice).ToString("F2") + " ₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x=>x.LocationId==lastCountryId).Select(y=>y.LocationCountry).FirstOrDefault();
            lblCappadociaLocationCapacity.Text = db.Location.Where(x=>x.LocationCity=="Kapadokya").Select(y=>y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeAverageCapacity.Text = db.Location.Where(x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity).ToString();
            var RomeGuideId= db.Location.Where(x=>x.LocationCity=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x=>x.GuideId==RomeGuideId).Select(y=>y.GuideName +" "+y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacityTour = db.Location.Max(x=>x.LocationCapacity);
            lblMaxCapacityTour.Text = db.Location.Where(x=>x.LocationCapacity==maxCapacityTour).Select(y=>y.LocationCity).FirstOrDefault().ToString();
            var MaxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPricetour.Text= db.Location.Where(x=>x.LocationPrice==MaxPrice).Select(y=>y.LocationCity).FirstOrDefault().ToString();
            var guideIdByNameAygesul = db.Guide.Where(x=>x.GuideName=="Ayşegül" && x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulCount.Text = db.Location.Where(x=>x.GuideId==guideIdByNameAygesul).Count().ToString();
        }
    }
}

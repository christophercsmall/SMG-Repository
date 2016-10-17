using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystemInventoryManager
{
    public partial class PatchToSwitchForm : Form
    {
        private MainForm mf;

        List<string> venueList = new List<string>();
        List<string> venueSpaceList = new List<string>();
        List<string> idfList = new List<string>();
        List<string> PPList = new List<string>();
        List<string> PPPortList = new List<string>();
        List<string> switchList = new List<string>();
        List<string> switchPortList = new List<string>();

        string venueListQuery = "SELECT Venue.VenueName FROM [Venue];";
        string venueSpaceQuery = "SELECT VenueSpace.VenueSpaceName FROM [VenueSpace]";

        public PatchToSwitchForm(MainForm mainForm)
        {            
            InitializeComponent();
            mf = mainForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mf.dbConnect();

            if (MainForm.connected)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(venueListQuery, MainForm.dbConnection.conn);
                DataSet ds = new DataSet();

                try
                {
                    da.Fill(ds);

                    venueList.Add("");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        venueList.Add(dr.ItemArray.GetValue(0).ToString());
                    }

                    venueBox.DataSource = venueList;

                    mf.dbClose();
                }
                catch (OleDbException exp)
                {
                    MessageBox.Show("Database Error:" + exp.Message.ToString());
                }
            }
        }

        private void venueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (venueSpaceBox.SelectedValue.ToString() != "") //null exception
            {
                venueSpaceBox.Enabled = true;

                mf.dbConnect();

                if (MainForm.connected)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(venueSpaceQuery, MainForm.dbConnection.conn);
                    DataSet ds = new DataSet();

                    try
                    {
                        da.Fill(ds);

                        venueSpaceList.Add("");

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            venueSpaceList.Add(dr.ItemArray.GetValue(0).ToString());
                        }

                        venueSpaceBox.DataSource = venueSpaceList;

                        mf.dbClose();
                    }
                    catch (OleDbException exp)
                    {
                        MessageBox.Show("Database Error:" + exp.Message.ToString());
                    }
                }

            }
            else
            {
                venueSpaceBox.Enabled = false;
            }
        }

        private void areaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

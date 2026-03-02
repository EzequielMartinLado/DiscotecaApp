using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Discoteca
{
    public partial class DiscotecaForm : Form
    {
        private List<Disco> listDisc;
        public DiscotecaForm()
        {
            InitializeComponent();
        }

        private void DiscotecaForm_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listDisc = negocio.listarDisco();
            DiscoDataGridView.DataSource = listDisc;
            DiscoDataGridView.Columns["UrlCover"].Visible = false;
            ImageLoad(listDisc[0].UrlCover);
        }

        private void DiscoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Disco discSelected = (Disco)DiscoDataGridView.CurrentRow.DataBoundItem;
            ImageLoad(discSelected.UrlCover);
        }

        private void ImageLoad(string image)
        {
            try
            {
                DiscoPictureBox.Load(image);
            }
            catch (Exception)
            {

                DiscoPictureBox.Load("https://www.svgrepo.com/show/508699/landscape-placeholder.svg");
            }
        }
    }
}

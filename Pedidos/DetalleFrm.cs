using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class DetalleFrm : Form
    {
        private string id;
        public DetalleFrm(string id)
        {
            this.Id = id;
            InitializeComponent();
        }

        public string Id { get => id; set => id = value; }

        private void DetalleFrm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(id);
            DetallePedido dp = new DetallePedido();
            dp.IdPedido = Convert.ToInt64(Id);
            dgvDetalle.DataSource = dp.getDetallePedido();

        }
    }
}

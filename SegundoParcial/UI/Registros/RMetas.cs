using System;
using SegundoParcial.BLL;
using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial.UI.Registros
{
    public partial class RMetas : Form
    {
        RepositorioBase<Metas> repositorio;
        public RMetas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            errorProvider.Clear();
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CuotanumericUpDown.Value = 0;

        }
        private bool Validar()
        {
            bool paso = true;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
            if (CuotanumericUpDown.Value == 0)
            {
                errorProvider.SetError(CuotanumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }
            return paso;
        }
        private Metas LlenaClase()
        {
            Metas Metas = new Metas()
            {
                Id = Convert.ToInt32(IDnumericUpDown.Value),
                Descripcion = DescripciontextBox.Text,
                Cuota = Convert.ToDecimal(CuotanumericUpDown.Value)
            };
            return Metas;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
            {
                repositorio = new RepositorioBase<Metas>();
                Metas Meta;
                bool paso = false;
                if (!Validar())
                    return;

                Meta = LlenaClase();
                if (IDnumericUpDown.Value == 0)
                    paso = repositorio.Guardar(Meta);
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        return;
                    }
                    paso = repositorio.Modificar(Meta);
                }
                if (paso)
                {
                    MessageBox.Show("Meta Guardada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Metas>();
            Metas Meta = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (Meta != null);
        }
    }
    
}


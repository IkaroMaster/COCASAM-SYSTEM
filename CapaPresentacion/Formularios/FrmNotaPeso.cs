using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Formularios;
using System.IO;



namespace CapaPresentacion.Formularios
{
    public partial class FrmNotaPeso : Form
    {
        CNNotaPeso objNP = new CNNotaPeso();
        public FrmNotaPeso()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            

            

            if (slueProductor.EditValue == null)
            {
                slueProductor.ErrorText = "Seleccione el productor";
                return false;
            }
            if (slueCalidadCafe.EditValue == null)
            {   
                slueCalidadCafe.ErrorText = "Seleccione la calidad del cafe";
                return false;
            }
            if (slueLugar.EditValue == null)
            {
                slueLugar.ErrorText = "Seleccione un lugar";
                return false;
            }
            if (String.IsNullOrEmpty(txtDescuento.EditValue.ToString().Trim()))
            {
                txtDescuento.ErrorText = "Ingrese el descuento";
                return false;
            }


            if (String.IsNullOrEmpty(txtHumedad.EditValue.ToString().Trim()))
            {
                txtHumedad.ErrorText = "Ingrese el porcentaje de humedad";
                return false;
            }
            if (String.IsNullOrEmpty(txtPrecioQ.EditValue.ToString().Trim()))
            {
                txtPrecioQ.ErrorText = "Ingrese el precio por Quital";
                return false;
            }

            if (dgvDetalleNotaPeso.Rows[0].Cells[0].Value == null)
            {
                XtraMessageBox.Show("Imposible calcular sin la cantidad de sacos y el peso.", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dgvDetalleNotaPeso.Focus();
                return false;
            }




            return true;

        }

        private void Limpiar()
        {
            deFecha.DateTime = DateTime.Today;
            txtNumeroFactura.EditValue = "";
            slueProductor.EditValue = null;
            slueCalidadCafe.EditValue = null;
            slueLugar.EditValue = null;
            txtDescuento.EditValue = "";
            txtHumedad.EditValue = "";
            txtObservacion.EditValue = "";
            txtPrecioQ.EditValue = "";
            txtPesoBruto.EditValue = "";
            txtTara.EditValue = "";
            txtPesoNeto.EditValue = "";
            txtQuintales.EditValue = "";
            txtQuitalesOroLegal.EditValue = "";
            txtPrecioTotal.EditValue = "";
            dgvDetalleNotaPeso.Rows.Clear();
            dgvDetalleNotaPeso.Rows.Add();
            slueLugar.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNotaPeso_Load(object sender, EventArgs e)
        {
            Limpiar();
            LlenarCombobox();
            ListadoNotaPeso();
            HabilitarControles(true, false, false, true, true);
        }

        private void LlenarCombobox()
        {

            slueProductor.Properties.DataSource = objNP.ListadoProductor().Tables["Productor"];
            slueCalidadCafe.Properties.DataSource = objNP.ListadoTipoCafe().Tables["TipoCafe"];

            CNUsuario objU = new CNUsuario();
            slueUsuario.Properties.DataSource = objU.ListadoUsuario().Tables["Usuario"];

            txtNumeroFactura.Text = objNP.ObtenerMaximoNotaPeso().Tables["NotaPeso"].Rows[0]["IdNotaPeso"].ToString();


            slueUsuario.EditValue = Funciones.Funciones.idUsuario;


        }

        private Boolean GuardarDetallesNotaPeso()
        {
            dgvDetalleNotaPeso.AllowUserToAddRows = false;
            if (dgvDetalleNotaPeso.Rows.Count > 0)
            {
                CNNotaPeso objGuardarDetalleNotaPeso = new CNNotaPeso();
                foreach (DataGridViewRow item in dgvDetalleNotaPeso.Rows)
                {
                    CENotaPeso objDetalleNotaPeso = new CENotaPeso()
                    {
                        IdNotaPeso = int.Parse(txtNumeroFactura.Text.Trim()),
                        Peso = Convert.ToDecimal(item.Cells["colPeso"].Value),
                        Saco = Convert.ToInt32(item.Cells["colSacos"].Value),


                    };

                    if (objGuardarDetalleNotaPeso.NuevoDetalleNotaPeso(objDetalleNotaPeso) > 0)
                    {
                    }
                    else
                    {
                        XtraMessageBox.Show("No se ha logrado almacenar los lugares del productor", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                return true;


            }

            return true;


        }


        

        

       
        private void btnCalcularSacos_Click(object sender, EventArgs e)
        {
            double totalPeso = 0;
            int totalSacos = 0;
            foreach (DataGridViewRow item in dgvDetalleNotaPeso.Rows)
            {
                totalPeso += Convert.ToDouble(item.Cells["ColPeso"].Value);
                totalSacos += Convert.ToInt32(item.Cells["ColSacos"].Value);
            }

            double pesoBruto = totalPeso / 100;
            double tara = totalSacos * 0.005;
            double descuentoHumedad = Convert.ToDouble(txtDescuento.Text.Trim());

            double pesoNeto = pesoBruto - tara - descuentoHumedad;
            double quintalOro = pesoNeto / 1.20;
            double quintalOroLegal = pesoNeto / 1.25;
            double precioUnitario = Convert.ToDouble(txtPrecioQ.Text);
            double precioTotal = quintalOro * precioUnitario;
            txtObservacion.Text = Convert.ToString(descuentoHumedad);

            txtPesoBruto.Text = (pesoBruto.ToString());
            txtTara.Text = (tara.ToString());
            txtPesoNeto.Text = (pesoNeto.ToString());
            txtQuintales.Text = (quintalOro.ToString());
            txtQuitalesOroLegal.Text = (quintalOroLegal.ToString());
            txtPrecioTotal.Text = (precioTotal.ToString());

            




        }

        private void pBxGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcularSacos_Click_1(object sender, EventArgs e)
        {
        }

        

        private void pBxNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(false, true, true, false, false);

        }

        private void ListadoNotaPeso()
        {
            CNNotaPeso objP = new CNNotaPeso();
            gcDatosNotaPeso.DataSource = objP.ListadoNotaPeso().Tables["NotaPeso"];
        }


        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean cancelar, Boolean regresar, Boolean group)
        {

            //FileStream file = new FileStream("rutaImagen.jpg", FileMode.Open);
            //Image toLoad = Image.FromStream(file);
            //button.Image = toLoad;

            //pBxNuevo.Image = Image.FromFile(@"Recursos/guadar.png");
            pBxNuevo.Enabled = nuevo;
            
            pBxGuardar.Enabled = guardar;
            pBxCancelar.Enabled = cancelar;
            pBxRegresar.Enabled = regresar;
            gcDatosNotaPeso.Visible = group;

            if (nuevo == true)
            {
                pBxNuevo.Image = imgLista.Images[0];
            }
            else
            {
                pBxNuevo.Image = imgLista.Images[1];
            }

            if (guardar == true)
            {
                pBxGuardar.Image = imgLista.Images[2];
            }
            else
            {
                pBxGuardar.Image = imgLista.Images[3];
            }

            //if (actualizar == true)
            //{
            //    pBxActualizar.Image = imgLista.Images[4];
            //}
            //else
            //{
            //    pBxActualizar.Image = imgLista.Images[5];
            //}

            if (cancelar == true)
            {
                pBxCancelar.Image = imgLista.Images[6];
            }
            else
            {
                pBxCancelar.Image = imgLista.Images[7];
            }

            if (regresar == true)
            {
                pBxRegresar.Image = imgLista.Images[8];
            }
            else
            {
                pBxRegresar.Image = imgLista.Images[9];
            }

        }

        private void pBxCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true, false, false, true, true);
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            int idNotaPeso = int.Parse(gvDatosNotaPeso.GetRowCellValue(gvDatosNotaPeso.FocusedRowHandle, colIdNotaPeso).ToString());

            DialogResult dialogResult = XtraMessageBox.Show("Desea Anular la Nota Peso Numero --> "+idNotaPeso+"  ?", "COCASAM", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CNNotaPeso objActualizarNotaPeso = new CNNotaPeso();
                CENotaPeso objNotaPeso = new CENotaPeso()
                {
                    IdNotaPeso = idNotaPeso,
                    Anulada = true
                };

                if (objActualizarNotaPeso.ActualizarNotaPeso(objNotaPeso) > 0)
                {
                    ListadoNotaPeso();

                    XtraMessageBox.Show("Nota peso con N " + idNotaPeso + " ha sido anulada!. ", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al Actualizar el Registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                XtraMessageBox.Show("Accion Cancelada!", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
         
        }

        private void pBxGuardar_Click_1(object sender, EventArgs e)
        {
            this.Validar();
            if (Validar())
            {

                CNNotaPeso objGuardarNotaPeso = new CNNotaPeso();
                CENotaPeso objNotaPeso = new CENotaPeso()
                {
                    IdNotaPeso = int.Parse(txtNumeroFactura.Text.Trim()),
                    IdProductor = slueProductor.EditValue.ToString(),
                    IdTipoCafe = int.Parse(slueCalidadCafe.EditValue.ToString()),
                    IdLugar = int.Parse(slueLugar.EditValue.ToString()),
                    IdUsuario = int.Parse(slueUsuario.EditValue.ToString()),
                    Fecha = deFecha.DateTime.Date,
                    PesoBruto = float.Parse(txtPesoBruto.Text.Trim()),
                    Tara = decimal.Parse(txtTara.Text.Trim()),
                    Descuento = decimal.Parse(txtDescuento.Text.Trim()),
                    Humedad = float.Parse(txtHumedad.Text.Trim()),
                    Observaciones = txtObservacion.Text.Trim(),
                    PrecioUnitario = decimal.Parse(txtPrecioQ.Text.Trim()),
                    Anulada = false

                };

                if (objGuardarNotaPeso.NuevaNotaPeso(objNotaPeso) > 0)
                {
                    //XtraMessageBox.Show("Registro almacenado satisfatoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (GuardarDetallesNotaPeso())
                    {
                        Limpiar();
                        // ListadoProductor();
                        HabilitarControles(true,false,false,false,true);
                        ListadoNotaPeso();
                        XtraMessageBox.Show("Registro almacenado satisfatoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }

        }

        private void slueProductor_EditValueChanged_1(object sender, EventArgs e)
        {
            if (slueProductor.EditValue != null)
            {
                slueLugar.Enabled = true;
                string idProductor = slueProductor.EditValue.ToString();
                slueLugar.Properties.DataSource = objNP.ListarLugarXProductor(idProductor).Tables["Productor"];

            }
        }

        private void btnCalcularSacos_Click_2(object sender, EventArgs e)
        {
            if (Validar())
            {
                double totalPeso = 0;
                int totalSacos = 0;
                foreach (DataGridViewRow item in dgvDetalleNotaPeso.Rows)
                {
                    totalPeso += Convert.ToDouble(item.Cells["ColPeso"].Value);
                    totalSacos += Convert.ToInt32(item.Cells["ColSacos"].Value);
                }

                double pesoBruto = totalPeso / 100;
                double tara = totalSacos * 0.005;
                double descuentoHumedad = Convert.ToDouble(txtDescuento.Text.Trim());

                double pesoNeto = pesoBruto - tara - descuentoHumedad;
                double quintalOro = pesoNeto / 1.20;
                double quintalOroLegal = pesoNeto / 1.25;
                double precioUnitario = Convert.ToDouble(txtPrecioQ.Text);
                double precioTotal = quintalOro * precioUnitario;
                txtObservacion.Text = Convert.ToString(descuentoHumedad);

                txtPesoBruto.Text = (pesoBruto.ToString());
                txtTara.Text = (tara.ToString());
                txtPesoNeto.Text = (pesoNeto.ToString());
                txtQuintales.Text = (quintalOro.ToString());
                txtQuitalesOroLegal.Text = (quintalOroLegal.ToString());
                txtPrecioTotal.Text = (precioTotal.ToString());

            }

           





        }

        private void imprimirNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idNota = int.Parse(gvDatosNotaPeso.GetRowCellValue(gvDatosNotaPeso.FocusedRowHandle, colIdNotaPeso).ToString());
            Reportes.rptNotaPeso reporte = new Reportes.rptNotaPeso(idNota);
            DevExpress.XtraReports.UI.ReportPrintTool viewer = new DevExpress.XtraReports.UI.ReportPrintTool(reporte);
            viewer.ShowRibbonPreview();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class lrt : Form
    {
        private int quantity = 1;
        public lrt()
        {
            InitializeComponent();
        }

        private void cbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbfrom.SelectedIndex)
            {
                case 1: //recto
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = false;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btnjruiz.Enabled = true;
                    btngilmore.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 2: //legarda
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = false;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btnjruiz.Enabled = true;
                    btngilmore.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 3: //Pureza
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = false;
                    btnvmapa.Enabled = true;
                    btnjruiz.Enabled = true;
                    btngilmore.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 4: //V.Mapa
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = false;
                    btnjruiz.Enabled = true;
                    btngilmore.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 5: //J.Ruiz
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;                    
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = false;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 6: //Gilmore
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = false;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 7: //Betty Go
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = false;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 8: //cubao
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = false;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 9: //Anonas
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = false;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = true;
                    break;

                case 10: //Katipunan
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = false;
                    btnsantolan.Enabled = true;
                    break;

                case 11: //Santolan
                    btnrecto.Visible = true;
                    btnlegarda.Visible = true;
                    btnpureza.Visible = true;
                    btnvmapa.Visible = true;
                    btnjruiz.Visible = true;
                    btngilmore.Visible = true;
                    btnbettygo.Visible = true;
                    btncubao.Visible = true;
                    btnanonas.Visible = true;
                    btnkatipunan.Visible = true;
                    btnsantolan.Visible = true;
                    //choose destination
                    btnrecto.Enabled = true;
                    btnlegarda.Enabled = true;
                    btnpureza.Enabled = true;
                    btnvmapa.Enabled = true;
                    btngilmore.Enabled = true;
                    btnjruiz.Enabled = true;
                    btnbettygo.Enabled = true;
                    btncubao.Enabled = true;
                    btnanonas.Enabled = true;
                    btnkatipunan.Enabled = true;
                    btnsantolan.Enabled = false; 
                    break;

            }
        }

        private void grp_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsantolan_Click(object sender, EventArgs e)
        {
            double price;
            price = 60.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Santolan";
        }

        private void btnbettygo_Click(object sender, EventArgs e)
        {
            double price;
            price = 40.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Betty-Go";
        }

        private void btnlegarda_Click(object sender, EventArgs e)
        {
            double price;
            price = 15.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Legarda";
        }

        private void btnrecto_Click(object sender, EventArgs e)
        {
            double price;
            price = 10.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Recto";
        }

        private void btnpureza_Click(object sender, EventArgs e)
        {
            double price;
            price = 20.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Pureza";
        }

        private void btnvmapa_Click(object sender, EventArgs e)
        {
            double price;
            price = 25.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "V. Mapa";
        }

        private void btnjruiz_Click(object sender, EventArgs e)
        {
            double price;
            price = 30.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "J. Ruiz";
        }

        private void btngilmore_Click(object sender, EventArgs e)
        {
            double price;
            price = 35.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Gilmore";
        }

        private void btncubao_Click(object sender, EventArgs e)
        {
            double price;
            price = 45.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Cubao";
        }

        private void btnanonas_Click(object sender, EventArgs e)
        {
            double price;
            price = 50.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Anonas";
        }

        private void btnkatipunan_Click(object sender, EventArgs e)
        {
            double price;
            price = 55.00;

            lblprice.Text = price.ToString() + ".00";
            lbldestination.Text = "Katipunan";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {

            quantity++;
            txtqty.Text = quantity.ToString();

            double price;
            double totalprice;
            int quantity_2;

            price = Convert.ToDouble(lblprice.Text);
            quantity_2 = Convert.ToInt32(txtqty.Text);

            totalprice = price * quantity_2;
            lbltotal.Text = totalprice.ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            quantity--;
            txtqty.Text = quantity.ToString();

            double price;
            double totalprice;
            int quantity_2;

            price = Convert.ToDouble(lblprice.Text);
            quantity_2 = Convert.ToInt32(txtqty.Text);

            totalprice = price * quantity_2;
            lbltotal.Text = totalprice.ToString();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {
            
        }

        private void lblchange_Click(object sender, EventArgs e)
        {
            
          
        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            double cash;
            double totalprice;
            double change;
            if (txtcash.Text == "")
            {
                txtcash.Text = "0";
            }

            cash = Convert.ToDouble(txtcash.Text);
            totalprice = Convert.ToDouble(lbltotal.Text);

            change = cash - totalprice;
            lblchange.Text = change.ToString();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double price;
            double totalprice;
            int quantity_2;          
            
      

            price = Convert.ToDouble(lblprice.Text);
            quantity_2 = Convert.ToInt32(txtqty.Text);

            totalprice = price * quantity_2;
            lbltotal.Text = totalprice.ToString();

            receipt summary = new receipt();
            summary.lblfrom.Text = cbfrom.Text;
            summary.lblto.Text =lbldestination.Text;
            summary.lbltprice.Text = totalprice.ToString();

            summary.Show();
            this.Hide();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

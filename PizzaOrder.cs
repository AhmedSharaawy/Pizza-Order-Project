using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pizza_Project
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OrderSummary_Size();
            OrderSummary_CurstType();
            OrderSummary_Toppings();
            OrderSummary_WhereToEat();
            TotalPrice();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lblSize_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void lblCurstTypy_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {

        }

        // _______________________________________________________________________

        void OrderSummary_Size()
        {
            TotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }

            if (rbMedium .Checked)
            {
                lblSize.Text = "Medium";
            }
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Size();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Size();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Size();
        }

        // __________________________________________________________________________

        void OrderSummary_CurstType()
        {
            TotalPrice();

            if (rbThinCurst.Checked)
            {
                lblCurstTypy.Text = "Thin";
            }

            if (rbThinkCurst.Checked)
            {
                lblCurstTypy.Text = "Think";
            }
        }
        private void rbThinCurst_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_CurstType();
        }
        private void rbThinkCurst_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_CurstType();
        }

        // ___________________________________________________________________________

        void OrderSummary_Toppings()
        {
            TotalPrice();

            lblToppings.Text = "";

            if (chkExtraChees.Checked)
            {
                lblToppings.Text = "Extra Chees";
            }

            if (chkMuchrooms.Checked)
            {
                lblToppings.Text += ", Muchrooms";
            }

            if (chkOlives.Checked)
            {
                lblToppings.Text += ", Olives";
            }

            if (chkOnion.Checked)
            {
                lblToppings.Text += ", Onion";
            }

            if (chkTomatoes.Checked)
            {
                lblToppings.Text += ", Tomatoes";
            }
            if (chkGreenPeppers.Checked)
            {
                lblToppings.Text += ", Green Peppers";
            }

            if (lblToppings.Text == "")
            {
                lblToppings.Text = "No Toppings";
            }
        }
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void chkMuchrooms_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            OrderSummary_Toppings();
        }

        // -------------------------------------------------------------------------

        void OrderSummary_WhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }

            else if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
            }
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_WhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            OrderSummary_WhereToEat();
        }

        // --------------------------------------------------------------------------

        float GetSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);
            else
                return Convert.ToSingle(rbMedium.Tag);
        }
        float GetToppingsPrice()
        {
            float TotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                TotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkMuchrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chkMuchrooms.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return TotalPrice;
        }
        float GetCurstTypePrice()
        {
            if (rbThinkCurst.Checked)
            {
                return Convert.ToSingle(rbThinkCurst.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinCurst.Tag);
            }
        }
        float Calculator_TotalPrice()
        {
            return GetSizePrice() + GetToppingsPrice() + GetCurstTypePrice();
        }
        void TotalPrice()
        {
            lblTotalPrice.Text = "$" + Calculator_TotalPrice().ToString(); 
        }

        // ---------------------------------------------------------------------------

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCurst.Enabled = false;
                gbToppoings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update yor Order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCurst.Enabled = true;
            gbToppoings.Enabled = true;
            gbWhereToEat.Enabled = true;
            rbSmall.Checked = true;
            chkExtraChees.Checked = false;
            chkMuchrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
            rbThinCurst.Checked = true;
            rbTakeOut.Checked = true;
            btnOrderPizza.Enabled = true;

            lblTotalPrice.Text = "$20";
        }
    }
}

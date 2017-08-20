using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBusCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFares_Click(object sender, EventArgs e)
        {
            double amount, discountAmount, tAsh, tTim, tOm, tDun, tInv;
            int age;
            bool disabled, discount, weekend; //, //weekend;
            //discount = false;
            string name;
            discount = false;
            weekend = chkWeekend.Checked;
           
            age = Convert.ToInt16(txtAge.Text);
            disabled = chkDisabled.Checked;
            //weekend = chkWeekend.Checked;
            name = txtName.Text;

            discount = Convert.ToBoolean(value: discounted(age, disabled.ToString()));
            //discount2 = Convert.ToBoolean(value: weekendD(weekend.ToString(), discount.ToString()));

            if (weekend == true)
            {
                
                amount = Convert.ToDouble(whatdiscountWeekend(discount.ToString()));
            }

            else
            {
                amount = Convert.ToDouble(whatdiscount(discount.ToString()));
            }

            discountAmount = 1 - amount;
                txtDiscount.Text = discountAmount.ToString();
                tAsh = Convert.ToDouble(txtAsh.Text);
                tTim = Convert.ToDouble(txtTim.Text);
                tOm = Convert.ToDouble(txtOm.Text);
                tDun = Convert.ToDouble(txtDun.Text);
                tInv = Convert.ToDouble(txtInv.Text);

                string Ash, Tim, Om, Dun, Inv;


                //Ash = (amount * 17.99).ToString("#.##");
                Ash = city(amount, tAsh).ToString("#.##");
                Tim = city(amount, tTim).ToString("#.##");
                ;

                Om = city(amount, tOm).ToString("#.##");

                Dun = city(amount, tDun).ToString("#.##");
                ;

                Inv = city(amount, tInv).ToString("#.##");
                ;

                ////txtAsh.Text = 
                //txtAsh.Text = Ash;
                //txtTim.Text = Tim;
                //txtDun.Text = Dun;
                //txtInv.Text = Inv;
                //txtOm.Text = Om;


                lbxResults.Items.Add(name + " Ash:" + Ash + " Tim:" + Tim + " Om:" + Om + " Dun:" + Dun + " Inv:" +
                                     Inv);
            }

            private string discounted(int age, string disabled)
            {
                bool tfDisabled, discount;
                tfDisabled = Convert.ToBoolean(disabled);
                discount = false;
                if (age > 64 || age < 20 || tfDisabled == true)
                {
                    discount = true;
                }

                return discount.ToString();
            }



            private string whatdiscount(string Discount)
            {
                Double amount;
                bool tfDiscount;
                tfDiscount = Convert.ToBoolean(Discount);
                if (tfDiscount == true)
                {
                    amount = 0.8;
                }
                else
                {
                    amount = 1;
                }
                return amount.ToString();
            }

            private string whatdiscountWeekend(string Discount)
            {
                Double amount;
                bool tfDiscount;
                tfDiscount = Convert.ToBoolean(Discount);
                if (tfDiscount == true)
                {
                    amount = 0.75;
                }
                else
                {
                    amount = 0.8;
                }
                return amount.ToString();
            }


            public double city(double amount, double city)
            {
                //double dAmount;
                //dAmount = Convert.ToDouble(amount);
                return (amount * Convert.ToDouble(city));

            }

        private void chkWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWeekend.Checked == true)
            {
                chkWeekend.Visible = true;
            }
        }
    }
    }
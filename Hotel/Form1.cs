using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class sige : Form
    {
        
        public sige()
        {
            InitializeComponent();


            // Disable the maximize button

            this.MaximizeBox = false;
            gbdisc.Enabled = false;
            gbtype.Enabled = false;
 
            lblamount.TextChanged += lblamount_TextChanged;
            lbldisc.TextChanged += lbldisc_TextChanged;

            CalculateDue();
            UpdateTotalLabel();

        }

        private void UpdateTotalLabel()
        {
            // Get the quantity from the NumericUpDown control
            int quantity = Decimal.ToInt32(updpax.Value);
        }
        private void CalculateDue()


        {
            string amountt = lblamount.Text.Replace("₱", "");
            string discountt = lbldisc.Text.Replace("₱", "");
           
            if (double.TryParse(amountt, out double value1) && double.TryParse(discountt, out double value2))
            {
                double result = value1 - value2;
                lbldue.Text = $"₱{result.ToString("F2")}";
            }


        }

        private void CalculateDiscount()
        {
            string amountt = lblamount.Text.Replace("₱", "");

            if (rbstudent.Checked)
            {
                if (double.TryParse(amountt, out double totalAmount))
                {
                    double discountPercentage = 0.10; // 10% discount expressed as a decimal
                    double discount = totalAmount * discountPercentage;

                    lbldisc.Text = $"₱{discount}"; // Format as currency and set in lbldisc
                }
            }

            if (rbpwd.Checked)
            {
                if (double.TryParse(amountt, out double totalAmount))
                {
                    double discountPercentage = 0.20; // 20% discount expressed as a decimal
                    double discount = totalAmount * discountPercentage;

                    lbldisc.Text = $"₱{discount}"; // Format as currency and set in lbldisc
                }
            }

            if (rbsenior.Checked)
            {
                if (double.TryParse(amountt, out double totalAmount))
                {
                    double discountPercentage = 0.25; // 25% discount expressed as a decimal
                    double discount = totalAmount * discountPercentage;

                    lbldisc.Text = $"₱{discount}"; // Format as currency and set in lbldisc
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            tbpayment.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbname.Text))
            {
                // TextBox has text, so enable the panel
                gbtype.Enabled = true;
                gbdisc.Enabled = true;
                button1.Enabled = true;
                tbpayment.Enabled = true;
                foreach (Control control in gbtype.Controls)
                {
                    if (control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false; // Reset CheckBoxes to unchecked state
                    }
                    else if (control is RadioButton)
                    {
                        ((RadioButton)control).Checked = false;

                    }
                }
            }
            else
            {
                // TextBox is empty, so disable the panel
                gbdisc.Enabled = false;
                gbtype.Enabled = false;
                lblamount.Text = " ";
                lbldisc.Text = " ";
                lbldue.Text = " ";
                button1.Enabled = false;


            }
        }


        private string GetCheckedTypeButtonName()
        {
            foreach (Control control in gbtype.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Return the name of the checked RadioButton
                }
            }

            return "No RadioButton selected"; // Return a default value if no RadioButton is checked
        }

        private string GetCheckedDiscButtonName()
        {
            foreach (Control control in gbdisc.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Return the name of the checked RadioButton
                }
            }

            return "No RadioButton selected"; // Return a default value if no RadioButton is checked
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String name = tbname.Text;
            string contactno = tbcont.Text;
            int age = (int)updage.Value;
            int pax = (int)updpax.Value;
            string discount = lbldisc.Text;
            string due = lbldue.Text.Replace("₱", "");
            string totalamount = lblamount.Text;
          
            

            // Check if the TextBox is empty or contains only whitespace

            string contactnoval = tbcont.Text;
            string amountinput = tbpayment.Text;
            bool anyAccoButtonChecked = rbStandard.Checked || rbDeluxe.Checked || rbEcon.Checked || rbExe.Checked;
            bool anyDiscountButtonChecked = rbreg.Checked || rbstudent.Checked || rbpwd.Checked || rbsenior.Checked;





            if (string.IsNullOrWhiteSpace(contactnoval))
            {
                MessageBox.Show("Contact number is empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (!anyAccoButtonChecked)
                {
                    MessageBox.Show("No accomodation type was chosen yet, select one first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (!anyDiscountButtonChecked)
                    {
                        MessageBox.Show("Select a discount type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {


                        if (string.IsNullOrWhiteSpace(amountinput))
                        {
                            MessageBox.Show("Payment is empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else

                        {
                            if (double.TryParse(due, out double amountDue))
                            {
                                // Attempt to parse the paymentStr into an integer
                                if (double.TryParse(amountinput, out double payment))
                                {


                                    if (payment < amountDue)
                                    {
                                        MessageBox.Show("Insufficient payment. Please enter a higher amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    else
                                    {
                                        string checkedDiscButtonName = GetCheckedDiscButtonName();
                                        string checkedTypeButtonName = GetCheckedTypeButtonName();
                                        double sukli = payment - amountDue;

                                        string message = $"Name : {name}\nYour Contact Number : {contactno}\nYour age : {age}\nAccomodation : {checkedTypeButtonName}\nPax : {pax}\nDiscount Type : {checkedDiscButtonName}\n------------\nTotal Amount : {totalamount}\nDiscount : {discount}\nAmount Due : ₱{due}\nPayment : ₱{payment:F2}\n-------------\nChange : {sukli:F2} ";

                                        MessageBox.Show(message, "BILLING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tbname.Clear();
                                        tbcont.Clear();
                      
                                        lbldisc.Text = "";
                                        lblamount.Text = "";
                                        tbpayment.Clear();

                                        rbreg.Checked = false;
                                        rbstudent.Checked = false;
                                        rbpwd.Checked = false;
                                        rbsenior.Checked = false;

                                        rbDeluxe.Checked = false;   
                                        rbEcon.Checked = false;
                                        rbExe.Checked = false;
                                        rbStandard.Checked = false;

                                        updage.Value = 18;
                                        updpax.Value = 2;




                                    }


                                }
                            }
                        }
                    }


                }







            }
        }







        private void tbname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                // Cancel the keypress event
                e.Handled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (rbStandard.Checked)
            {
                


                int amount = 400;
                lblamount.Text = $"₱{amount.ToString("F2")}";

                bool anyRadioButtonChecked = rbStandard.Checked || rbEcon.Checked || rbDeluxe.Checked || rbExe.Checked;

                gbtype.Enabled = anyRadioButtonChecked;

            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbEcon.Checked)
            {
             
                int amount = 300;
                lblamount.Text = $"₱{amount.ToString("F2")}";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int discount = 0;
            lbldisc.Text = $"₱{discount}";
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)


        {
            string amountt = lblamount.Text.Replace("₱", "");

            if (double.TryParse(amountt, out double totalAmount))
            {
                double discountPercentage = 0.10; // 10% discount expressed as a decimal
                double discount = totalAmount * discountPercentage;

                lbldisc.Text = $"₱{discount.ToString("F2")}"; // Format as currency and set in lbldisc
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            string amountt = lblamount.Text.Replace("₱", "");
            if (double.TryParse(amountt, out double totalAmount))
            {
                double discountPercentage = 0.20; // 10% discount expressed as a decimal
                double discount = totalAmount * discountPercentage;

                lbldisc.Text = $"₱{discount.ToString("F2")}"; // Format as currency and set in lbldisc
            }
        }

        private void r_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeluxe.Checked)
            {
            
                int amount = 800;
                lblamount.Text = $"₱{amount.ToString("F2")}";
            }
        }

        private void rbjewel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExe.Checked)
            {
            
                int amount = 1000;
                lblamount.Text = $"₱{amount.ToString("F2")}";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExe.Checked)
            {
              
                int amount = 1000;
                lblamount.Text = $"₱{amount}";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

            string amountt = lblamount.Text.Replace("₱", "");
            if (double.TryParse(amountt, out double totalAmount))
            {
                double discountPercentage = 0.25; // 10% discount expressed as a decimal
                double discount = totalAmount * discountPercentage;

                lbldisc.Text = $"₱{discount.ToString("F2")}"; // Format as currency and set in lbldisc
            }
        }

        private void typepanel_Paint(object sender, PaintEventArgs e)
        {
            bool anyRadioButtonChecked = rbStandard.Checked || rbEcon.Checked || rbDeluxe.Checked || rbExe.Checked;

            gbdisc.Enabled = anyRadioButtonChecked;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblamount.Text, out int value1) && int.TryParse(lbldisc.Text, out int value2))
            {
                // Subtract the value of label2 from label1
                int result = value1 - value2;

                // Set the result in label3
                lbldue.Text = result.ToString();
            }
        }

        private void lbldisc_Click(object sender, EventArgs e)
        {

        }

        private void lblamount_TextChanged(object sender, EventArgs e)
        {
            CalculateDue();
            CalculateDiscount();
        }

        private void lbldisc_TextChanged(object sender, EventArgs e)
        {
            CalculateDue();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Suppress the keypress
            }

            // Ensure only one decimal point
            if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Suppress the keypress if a decimal point already exists
            }
        }

        private void lblamount_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void discpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbtype_Enter(object sender, EventArgs e)
        {

        }
    }
}
 
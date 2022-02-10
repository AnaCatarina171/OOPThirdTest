using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Ana Silva
 * ITPA 2021-12-16
 * OOP Test 3
 */

namespace OOPTest3.UI
{
    public partial class Form1 : Form
    {
        private List<Subscription> subscriptions = new List<Subscription>();
        private DigitalSubscription digitalSubscription;
        private PrintSubscription printSubscription;
        private decimal totalDigitalAmount = 0;
        private decimal totalPrintAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVolume.DataSource = Subscription.OrderableVolumes();

            for (int i = 1; i <= Publication.AvailableIssues; i++)
            {
                cmbIssue.Items.Add(i);
            }


            cmbIssue.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MediaType media;

                if (rdoDigital.Checked)
                    media = MediaType.Digital;
                else
                    media = MediaType.Print;

                Publication publication = new Publication(
                    txtPublicationName.Text,
                    Convert.ToInt32(cmbVolume.SelectedItem),
                    Convert.ToInt32(cmbIssue.SelectedItem),
                    Convert.ToInt32(txtPrice.Text),
                    media);

                if (publication.Media == MediaType.Digital)
                {
                    if (digitalSubscription == null)
                    {
                        digitalSubscription = new DigitalSubscription(
                            txtFirstName.Text,
                            txtLastName.Text,
                            txtEmail.Text);
                    }

                    subscriptions.Add(digitalSubscription);

                    digitalSubscription.AddPublication(publication);

                    totalDigitalAmount = digitalSubscription.CalculateSubscriptionPrice();

                    lblDigitalSubtotal.Text = totalDigitalAmount.ToString("c");

                    lstDigital.Items.Add($"{publication.PublicationName} Volume: {publication.VolumeNumber}" +
                        $" Issue: {publication.IssueNumber} Price: {publication.IssuePrice.ToString("c")}");
                }
                else
                {
                    if (printSubscription == null)
                    {
                        printSubscription = new PrintSubscription(
                            txtFirstName.Text,
                            txtLastName.Text,
                            txtMailingAddress.Text,
                            txtCity.Text,
                            txtProvince.Text,
                            txtPostalCode.Text);
                    }

                    subscriptions.Add(printSubscription);

                    printSubscription.AddPublication(publication);

                    totalPrintAmount = printSubscription.CalculateSubscriptionPrice();

                    lblPrint.Text = totalPrintAmount.ToString("c");

                    lstPrint.Items.Add($"{publication.PublicationName} Volume: {publication.VolumeNumber}" +
                        $" Issue: {publication.IssueNumber} Price: {publication.IssuePrice.ToString("c")}");
                }

                lblTotal.Text = (totalDigitalAmount + totalPrintAmount).ToString("c");

                //End Implementation

                //Final step. Do not touch
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        #region [Given Helpers]

        private void ResetForm()
        {
            txtPublicationName.ResetText();
            txtPrice.ResetText();
            cmbIssue.SelectedIndex = 0;

            if (subscriptions.Count() > 0)
                grpPersonalInfo.Enabled = false;

            txtPublicationName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RecurseControls(this.Controls);
            lstDigital.Items.Clear();
            lstPrint.Items.Clear();
            subscriptions = new List<Subscription>();
            lblDigitalSubtotal.ResetText();
            lblPrint.ResetText();
            lblTotal.ResetText();
            grpPersonalInfo.Enabled = true;
        }

        /// <summary>
        /// Call this to clear all the text of any texbox container in a container like a group box or panel
        /// </summary>
        /// <param name="controls"></param>
        private void RecurseControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case GroupBox groupBox:
                        RecurseControls(ctl.Controls);
                        break;
                    case TextBox textBox:
                        textBox.ResetText();
                        break;
                }
            }
        }

        #endregion
    }
}

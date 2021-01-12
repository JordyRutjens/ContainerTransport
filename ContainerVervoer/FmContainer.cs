using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerTransport
{
    public partial class FmContainer : Form
    {
        private Logic logicServices;

        public FmContainer()
        {
            InitializeComponent();
            btnAddContainer.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnSetShip_Click(object sender, EventArgs e)
        {
            logicServices = new Logic(nbShipWeight.Value);

            btnAddContainer.Enabled = true;
            btnStart.Enabled = true;
            rtbProgramLog.Clear();

            rtbProgramLog.Text = String.Format("You successfully created the ship with the weight of {0} kg!",
                nbShipWeight.Value);

            lbUpdateShipInfo();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            logicServices.AddContainer(nbContainerWeight.Value, rbStandard.Checked, rbValuable.Checked, rbCooled.Checked);
            lbContainerUpdate();
        }

        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            var removeIndex = lbContainerList.SelectedIndex;

            try
            {
                if (removeIndex != -1)
                {
                    logicServices.RemoveContainer(removeIndex);

                    lbContainerUpdate();
                }
                else
                {
                    MessageBox.Show("Please select a container first!");
                }
            }
            catch
            {
            }
        }
        private void lbContainerUpdate()
        {
            lbContainerList.Items.Clear();
            foreach (Container container in logicServices.DockedContainers)
            {
                lbContainerList.Items.Add(container.ToString());
            }

            lbUpdateShipInfo();
        }
        private void lbUpdateShipInfo()
        {
            lblTotalContainers.Text = lbContainerList.Items.Count.ToString();

            lblTotalContainerWeight.Text = logicServices.DockedContainersWeight.ToString();

            lblShipMaxWeight.Text = logicServices.ship.MaxWeight.ToString();

            lblShipMinWeight.Text = (logicServices.ship.MaxWeight / 2).ToString();

            lblShipBalance.Text = logicServices.ship.Balance.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                logicServices.StartAlgoritem();
                SetSelectionList(logicServices.ship);
                lbUpdateShipInfo();
            }
            catch (ExceptionHandler exception)
            {
                rtbProgramLog.Clear();
                rtbProgramLog.Text = exception.Message;
            }
        }

        private void SetSelectionList(Ship ship)
        {
            lbContainerSection1.Items.Clear();
            lbContainerSection2.Items.Clear();
            lbContainerSection3.Items.Clear();
            lbContainerSection4.Items.Clear();
            lbContainerSection5.Items.Clear();
            lbContainerSection6.Items.Clear();
            lbContainerSection7.Items.Clear();
            lbContainerSection8.Items.Clear();

            foreach (var selection in ship.Selections)
            {
                foreach (Container container in selection.Containers)
                {
                    switch (selection.Place)
                    {
                        case 1:
                            lbContainerSection1.Items.Add(container.ToString());
                            break;
                        case 2:
                            lbContainerSection2.Items.Add(container.ToString());
                            break;
                        case 3:
                            lbContainerSection3.Items.Add(container.ToString());
                            break;
                        case 4:
                            lbContainerSection4.Items.Add(container.ToString());
                            break;
                        case 5:
                            lbContainerSection5.Items.Add(container.ToString());
                            break;
                        case 6:
                            lbContainerSection6.Items.Add(container.ToString());
                            break;
                        case 7:
                            lbContainerSection7.Items.Add(container.ToString());
                            break;
                        case 8:
                            lbContainerSection8.Items.Add(container.ToString());
                            break;
                    }

                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
